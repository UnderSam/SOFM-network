namespace SOFM_network
{
    partial class SOFM
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.titledb = new System.Windows.Forms.Label();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.modeChange = new System.Windows.Forms.Button();
            this.clearinput = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.limit = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.opSize = new System.Windows.Forms.TextBox();
            this.trainButton = new System.Windows.Forms.Button();
            this.RetryButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.inputsz = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.trainTime = new System.Windows.Forms.Label();
            this.panel1 = new SOFM_network.drawPanel();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dimen1 = new System.Windows.Forms.CheckBox();
            this.dimen2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.linearyes = new System.Windows.Forms.CheckBox();
            this.linearno = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // titledb
            // 
            this.titledb.AutoSize = true;
            this.titledb.Font = new System.Drawing.Font("新細明體", 35F);
            this.titledb.Location = new System.Drawing.Point(47, 9);
            this.titledb.Name = "titledb";
            this.titledb.Size = new System.Drawing.Size(436, 47);
            this.titledb.TabIndex = 1;
            this.titledb.Text = "Kohoenen Feature map";
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(12, 611);
            this.inputBox.Multiline = true;
            this.inputBox.Name = "inputBox";
            this.inputBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.inputBox.Size = new System.Drawing.Size(500, 67);
            this.inputBox.TabIndex = 2;
            // 
            // modeChange
            // 
            this.modeChange.Location = new System.Drawing.Point(539, 296);
            this.modeChange.Name = "modeChange";
            this.modeChange.Size = new System.Drawing.Size(134, 82);
            this.modeChange.TabIndex = 3;
            this.modeChange.Text = "change to random input";
            this.modeChange.UseVisualStyleBackColor = true;
            this.modeChange.Click += new System.EventHandler(this.modeChange_Click);
            // 
            // clearinput
            // 
            this.clearinput.Location = new System.Drawing.Point(695, 296);
            this.clearinput.Name = "clearinput";
            this.clearinput.Size = new System.Drawing.Size(149, 82);
            this.clearinput.TabIndex = 4;
            this.clearinput.Text = "ClearInput";
            this.clearinput.UseVisualStyleBackColor = true;
            this.clearinput.Click += new System.EventHandler(this.clearinput_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 20F);
            this.label1.Location = new System.Drawing.Point(12, 581);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 27);
            this.label1.TabIndex = 5;
            this.label1.Text = "inputBox";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20F);
            this.label2.Location = new System.Drawing.Point(534, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 27);
            this.label2.TabIndex = 6;
            this.label2.Text = "learning rate";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20F);
            this.label3.Location = new System.Drawing.Point(705, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 27);
            this.label3.TabIndex = 7;
            this.label3.Text = "limit train";
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(539, 70);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(100, 22);
            this.rate.TabIndex = 8;
            // 
            // limit
            // 
            this.limit.Location = new System.Drawing.Point(710, 70);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(100, 22);
            this.limit.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20F);
            this.label4.Location = new System.Drawing.Point(534, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Output Size";
            // 
            // opSize
            // 
            this.opSize.Location = new System.Drawing.Point(539, 146);
            this.opSize.Name = "opSize";
            this.opSize.Size = new System.Drawing.Size(100, 22);
            this.opSize.TabIndex = 11;
            // 
            // trainButton
            // 
            this.trainButton.Font = new System.Drawing.Font("Tekton Pro Ext", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainButton.Location = new System.Drawing.Point(539, 384);
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size(305, 132);
            this.trainButton.TabIndex = 13;
            this.trainButton.Text = "TRAIN";
            this.trainButton.UseVisualStyleBackColor = true;
            this.trainButton.Click += new System.EventHandler(this.trainButton_Click);
            // 
            // RetryButton
            // 
            this.RetryButton.Font = new System.Drawing.Font("Tekton Pro Ext", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetryButton.Location = new System.Drawing.Point(539, 522);
            this.RetryButton.Name = "RetryButton";
            this.RetryButton.Size = new System.Drawing.Size(305, 132);
            this.RetryButton.TabIndex = 14;
            this.RetryButton.Text = "RETRY";
            this.RetryButton.UseVisualStyleBackColor = true;
            this.RetryButton.Click += new System.EventHandler(this.RetryButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 20F);
            this.label6.Location = new System.Drawing.Point(534, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 27);
            this.label6.TabIndex = 15;
            this.label6.Text = "input size :";
            // 
            // inputsz
            // 
            this.inputsz.AutoSize = true;
            this.inputsz.Font = new System.Drawing.Font("新細明體", 20F);
            this.inputsz.Location = new System.Drawing.Point(701, 257);
            this.inputsz.Name = "inputsz";
            this.inputsz.Size = new System.Drawing.Size(32, 27);
            this.inputsz.TabIndex = 16;
            this.inputsz.Text = " 0";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("新細明體", 20F);
            this.label7.Location = new System.Drawing.Point(361, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 27);
            this.label7.TabIndex = 17;
            this.label7.Text = "Train :";
            // 
            // trainTime
            // 
            this.trainTime.AutoSize = true;
            this.trainTime.Font = new System.Drawing.Font("新細明體", 20F);
            this.trainTime.Location = new System.Drawing.Point(437, 462);
            this.trainTime.Name = "trainTime";
            this.trainTime.Size = new System.Drawing.Size(32, 27);
            this.trainTime.TabIndex = 18;
            this.trainTime.Text = " 0";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.trainTime);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(500, 500);
            this.panel1.TabIndex = 19;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.repaint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.getInput);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mousemove);
            // 
            // dimen1
            // 
            this.dimen1.AutoSize = true;
            this.dimen1.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dimen1.Location = new System.Drawing.Point(706, 218);
            this.dimen1.Name = "dimen1";
            this.dimen1.Size = new System.Drawing.Size(44, 31);
            this.dimen1.TabIndex = 20;
            this.dimen1.Text = "1";
            this.dimen1.UseVisualStyleBackColor = true;
            this.dimen1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // dimen2
            // 
            this.dimen2.AutoSize = true;
            this.dimen2.Checked = true;
            this.dimen2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.dimen2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.dimen2.Location = new System.Drawing.Point(782, 218);
            this.dimen2.Name = "dimen2";
            this.dimen2.Size = new System.Drawing.Size(44, 31);
            this.dimen2.TabIndex = 21;
            this.dimen2.Text = "2";
            this.dimen2.UseVisualStyleBackColor = true;
            this.dimen2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 20F);
            this.label5.Location = new System.Drawing.Point(534, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(138, 27);
            this.label5.TabIndex = 22;
            this.label5.Text = "Dimension :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("新細明體", 20F);
            this.label8.Location = new System.Drawing.Point(534, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(172, 27);
            this.label8.TabIndex = 23;
            this.label8.Text = "Linear Update :";
            // 
            // linearyes
            // 
            this.linearyes.AutoSize = true;
            this.linearyes.Checked = true;
            this.linearyes.CheckState = System.Windows.Forms.CheckState.Checked;
            this.linearyes.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linearyes.Location = new System.Drawing.Point(706, 180);
            this.linearyes.Name = "linearyes";
            this.linearyes.Size = new System.Drawing.Size(70, 31);
            this.linearyes.TabIndex = 24;
            this.linearyes.Text = "Yes";
            this.linearyes.UseVisualStyleBackColor = true;
            this.linearyes.CheckedChanged += new System.EventHandler(this.linearyes_CheckedChanged);
            // 
            // linearno
            // 
            this.linearno.AutoSize = true;
            this.linearno.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.linearno.Location = new System.Drawing.Point(782, 180);
            this.linearno.Name = "linearno";
            this.linearno.Size = new System.Drawing.Size(62, 31);
            this.linearno.TabIndex = 25;
            this.linearno.Text = "No";
            this.linearno.UseVisualStyleBackColor = true;
            this.linearno.CheckedChanged += new System.EventHandler(this.linearno_CheckedChanged);
            // 
            // SOFM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(885, 685);
            this.Controls.Add(this.linearno);
            this.Controls.Add(this.linearyes);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dimen2);
            this.Controls.Add(this.dimen1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.inputsz);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.RetryButton);
            this.Controls.Add(this.trainButton);
            this.Controls.Add(this.opSize);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.rate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearinput);
            this.Controls.Add(this.modeChange);
            this.Controls.Add(this.inputBox);
            this.Controls.Add(this.titledb);
            this.Name = "SOFM";
            this.Text = "SOFM";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titledb;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button modeChange;
        private System.Windows.Forms.Button clearinput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox limit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox opSize;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button RetryButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label inputsz;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label trainTime;
        private drawPanel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.CheckBox dimen1;
        private System.Windows.Forms.CheckBox dimen2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox linearyes;
        private System.Windows.Forms.CheckBox linearno;
    }
}

