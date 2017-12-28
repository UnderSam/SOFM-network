using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace SOFM_network
{
    public partial class SOFM : Form
    {
        bool DEBUG = false;
        double[,] inputArray;
        bool[,] visited;
        int dimension;
        int outputSize = 10;
        int inputMode = 0;
        int count;
        int[,] neighbor;
        bool init = true;
        double[,,] weight;
        bool linear_update;
        int train_limit=100;
        bool end;
        double train_rate=0.1;
        int now;
        public SOFM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            inputArray = new double[250000,2];
            visited = new bool[this.Size.Width, this.Size.Height];
            Array.Clear(visited, 0, visited.Length);
            count = 0;
            limit.Text = train_limit.ToString();
            rate.Text = train_rate.ToString();
            opSize.Text = outputSize.ToString();
            end = false;
        }

        private void mousemove(object sender, MouseEventArgs e)
        {
            int x = e.X;
            int y = e.Y;
            double tx = (double)x/500;
            double ty = (double)y/500;
          
        }

        private void getInput(object sender, MouseEventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            int x = e.X;
            int y = e.Y;
            double tx = 0;
            double ty = 0;
            if (inputMode == 0 && !visited[x,y] )
            {
                g.FillRectangle(Brushes.Black, x, y, 2, 2);
                visited[x, y] = true;
                tx = (double)x / 500;
                ty = (double)y / 500;
                inputArray[count, 0] = tx;
                inputArray[count, 1] = ty;
                inputBox.Text += tx + "," + ty + "\n";
                count++;
                
                inputsz.Text = count.ToString();
            }
            if (inputMode == 1)
            {
                Random rdm = new Random();
                int rdCount = 0;
                while(rdCount < 30)
                {
                    int rx = rdm.Next(-40, 40);
                    int ry = rdm.Next(-40, 40);
                    int newX = x + rx;
                    int newY = y + ry;
                    if(newX>=0 && newY >= 0 && newX<=500 && newY<=500 )
                    {
                        if(visited[newX,newY]==false)
                        {
                            g.FillRectangle(Brushes.Black, newX, newY, 2, 2);
                            visited[newX, newY] = true;
                            tx = (double)newX / 500;
                            ty = (double)newY / 500;
                            inputArray[count, 0] = tx;
                            inputArray[count, 1] = ty;
                            rdCount++;
                            inputBox.Text += tx + "," + ty + "\n";
                            count++;
                        }
                    }
                }
                
                inputsz.Text = count.ToString();
            }
            g.Dispose();
        }

        private void modeChange_Click(object sender, EventArgs e)
        {
            if(inputMode == 0)
            {
                inputMode = 1;
                modeChange.Text = "change to single input";
            }
            else
            {
                inputMode = 0;
                modeChange.Text = "change to random input";
            }
        }

        private void clearinput_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            init = true;
            g.Clear(Color.White);
            Array.Clear(inputArray, 0, inputArray.Length);
            Array.Clear(visited, 0, visited.Length);
            inputBox.Clear();
            inputsz.Text = "0";
            count = 0;
        }

        private void trainButton_Click(object sender, EventArgs e)
        {
            train_limit = int.Parse(limit.Text);
            train_rate = double.Parse(rate.Text);
            outputSize = int.Parse(opSize.Text);
            if (dimen1.Checked)
                dimension = 1;
            else if (dimen2.Checked)
                dimension = 2;
            if (linearyes.Checked)
                linear_update = true;
            else if (linearno.Checked)
                linear_update = false;
            init = false;
            //if (outputSize > 20)
              //  outputSize = 20;
            if (DEBUG)
            {
                label1.Text = "Debug View";
                inputBox.Clear();
                inputBox.Text += "inputSize:"+count+",limit:" + train_limit + ",rate:" + train_rate + ",outputSize:" + outputSize+",dimension"+dimension;
               
            }
            //test();
            SOM(count, outputSize, train_limit, train_rate, inputArray);
        }

        private void RetryButton_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
            init = true;
            Array.Clear(inputArray, 0, inputArray.Length);
            Array.Clear(visited, 0, visited.Length);
            inputBox.Clear();
            rate.Text = "0.1";
            limit.Text = "100";
            count = 0;
            label1.Text = "inputBox";
            trainTime.Text = "0";
            inputsz.Text = "0";
            end = false;
        }
        
        private void SOM(int pattern_size, int number_of_output, int epoch, double learning_rate, double[,] input)
        {
            
            neighbor = new int[2, 4] { { 1, 0, -1, 0 }, { 0, 1, 0, -1 } };
            weight = new double[number_of_output, number_of_output, 2];
            Random r = new Random();
            for (int i = 0; i < number_of_output; i++)
            {
                for (int j = 0; j < number_of_output; j++)
                {
                    weight[i, j, 0] = r.NextDouble();
                    weight[i, j, 1] = r.NextDouble();
                }
            }

            //should input be in range of 0 to 1?
            //input should be [pattern_size][2] size. 2 means there are exactly 2 nodes in input layer.
            double radius;
            now = 0;
            //第幾次更新
            for (int i = 0; i < epoch; i++)
            {
                now = i + 1;

                //是否要線性更新
                //線性更新:大範圍更新的時間較多，優點是不管在高次數或低次數的訓練下，都能得到不錯的結果(比較不容易發生折疊)，缺點是要到訓練接近完畢才能看到較為接近的結果。
                if(linear_update == true) radius = epoch - i;
                //反比更新:大範圍更新的時間減短，較快速的到達微調部分，優點是在高次數的訓練下不用等到訓練接近完畢就能得到很不錯的結果，缺點是低次數的訓練下較容易發生摺疊情形。
                else radius = epoch * (1.0 / (i + 1));

                //每一個input
                for (int j = 0; j < pattern_size; j++)
                {
                    //兩層迴圈跑所有output
                    double min = double.MaxValue;
                    int min_1 = 0, min_2 = 0;
                    for (int m = 0; m < number_of_output; m++)
                    {
                        for (int n = 0; n < number_of_output; n++)
                        {
                            if (min > Math.Pow(input[j,0] - weight[m, n, 0], 2) + Math.Pow(input[j,1] - weight[m, n, 1], 2))
                            {
                                min = Math.Pow(input[j,0] - weight[m, n, 0], 2) + Math.Pow(input[j,1] - weight[m, n, 1], 2);
                                min_1 = m;
                                min_2 = n;
                            }
                        }
                    }
                    weight[min_1, min_2, 0] += learning_rate * (input[j,0] - weight[min_1, min_2, 0]);
                    weight[min_1, min_2, 1] += learning_rate * (input[j,1] - weight[min_1, min_2, 1]);
                    //鄰近的4個方向都更新
                    /*for (int k = 0; k < 4; k++)
                    {
                        //檢查邊界
                        if (min_1 + neighbor[0, k] >= 0 && min_2 + neighbor[1, k] >= 0 && min_1 + neighbor[0, k] < number_of_output && min_2 + neighbor[1, k] < number_of_output)
                        {
                            weight[min_1 + neighbor[0, k], min_2 + neighbor[1, k], 0] += learning_rate * (input[j,0] - weight[min_1 + neighbor[0, k], min_2 + neighbor[1, k], 0]);
                            weight[min_1 + neighbor[0, k], min_2 + neighbor[1, k], 1] += learning_rate * (input[j,1] - weight[min_1 + neighbor[0, k], min_2 + neighbor[1, k], 1]);
                        }
                    }*/
                    //根據radius來變更更新的範圍
                    for(int m = 0; m < outputSize; m++)
                    {
                        for(int n = 0; n < outputSize; n++)
                        {
                            if (dimension == 2)
                            {
                                /*if (Math.Abs(min_1 - m) + Math.Abs(min_2 - n) <= radius)
                                {
                                    weight[m, n, 0] += learning_rate * (input[j, 0] - weight[m, n, 0]);
                                    weight[m, n, 1] += learning_rate * (input[j, 1] - weight[m, n, 1]);
                                }*/
                                weight[m, n, 0] += Math.Pow(Math.E, (-1) * (Math.Pow(min_1 - m, 2) + Math.Pow(min_2 - n, 2)) / radius) * learning_rate * (input[j, 0] - weight[m, n, 0]);
                                weight[m, n, 1] += Math.Pow(Math.E, (-1) * (Math.Pow(min_1 - m, 2) + Math.Pow(min_2 - n, 2)) / radius) * learning_rate * (input[j, 1] - weight[m, n, 1]);
                            }
                            else if(dimension == 1)
                            {
                                weight[m, n, 0] += Math.Pow(Math.E, (-1) * (Math.Pow((m * outputSize + n) - (min_1 * outputSize + min_2), 2)) / radius) * learning_rate * (input[j, 0] - weight[m, n, 0]);
                                weight[m, n, 1] += Math.Pow(Math.E, (-1) * (Math.Pow((m * outputSize + n) - (min_1 * outputSize + min_2), 2)) / radius) * learning_rate * (input[j, 1] - weight[m, n, 1]);
                            }
                        }
                    }
                    //
                    if (i%10==0)
                        this.panel1.Refresh();
                }

               
                end = true;
                //this.panel1.Refresh();
            }
            trainTime.Text = (now).ToString();
            this.panel1.Refresh();
            //init = true;
            return;
        }
       
        private void test()
        {
            //Pen blackpen = new Pen(Color.Black, 2);
            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
            for (int i = 0; i < count; i++)
            {

                int x = (int)(inputArray[i, 0] * 500);
                int y = (int)(inputArray[i, 1] * 500);
                g.FillRectangle(Brushes.Black, x, y, 2, 2);
            }
        }
        private void repaint(object sender, PaintEventArgs e)
        {
            if (init)
                return;
            trainTime.Text = (now).ToString();
            Pen blackpen = new Pen(Color.Black, 2);
            Graphics g = e.Graphics;
            int number_of_output = int.Parse(opSize.Text);
            trainTime.Text = (now).ToString();
            int output_count = (int)Math.Pow(number_of_output, 2);
            if (dimension == 2)
            {
                for (int a = 0; a < output_count; a += 2)
                {
                    int m = a / number_of_output;
                    int j = a % number_of_output;
                    if (output_count % 2 == 0 && m % 2 == 1) j++;
                    for (int k = 0; k < 4; k++)
                    {
                        if (m + neighbor[0, k] >= 0 && j + neighbor[1, k] >= 0 && m + neighbor[0, k] < number_of_output && j + neighbor[1, k] < number_of_output)
                        {
                            int sx = (int)(weight[m, j, 0] * 500);
                            int sy = (int)(weight[m, j, 1] * 500);
                            int fx = (int)((weight[m + neighbor[0, k], j + neighbor[1, k], 0]) * 500);
                            int fy = (int)((weight[m + neighbor[0, k], j + neighbor[1, k], 1]) * 500);
                            g.DrawLine(blackpen, new Point(sx, sy), new Point(fx, fy));
                        }
                    }
                }
            }
            else if(dimension == 1)
            {
                for(int a = 0; a < output_count - 1; a++)
                {
                    int m = a / number_of_output;
                    int j = a % number_of_output;
                    int m_next = (a + 1) / number_of_output;
                    int j_next = (a + 1) % number_of_output;
                    int sx = (int)(weight[m, j, 0] * 500);
                    int sy = (int)(weight[m, j, 1] * 500);
                    int fx = (int)(weight[m_next, j_next, 0] * 500);
                    int fy = (int)(weight[m_next, j_next, 1] * 500);
                    g.DrawLine(blackpen, new Point(sx, sy), new Point(fx, fy));
                }
            }
            if (end || train_limit==1)
            {
                
                for (int i = 0; i < count; i++)
                {
                    int x = (int)(inputArray[i, 0] * 500);
                    int y = (int)(inputArray[i, 1] * 500);
                    g.FillRectangle(Brushes.Red, x, y, 3, 3);
                }
            }
            e.Dispose();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (dimen2.Checked)
            {
               
                dimen2.Checked = false;
              
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
 
            if (dimen1.Checked)
            {
                
                dimen1.Checked = false;
                
            }
        }

        private void linearyes_CheckedChanged(object sender, EventArgs e)
        {
            if (linearno.Checked)
            {
                linearno.Checked = false;
            }
        }

        private void linearno_CheckedChanged(object sender, EventArgs e)
        {
            if (linearyes.Checked)
            {
                linearyes.Checked = false;
            }
        }
    }
}
