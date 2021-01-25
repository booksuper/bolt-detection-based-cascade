namespace cascadewinform
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.createbtn = new System.Windows.Forms.Button();
            this.outtextbox = new System.Windows.Forms.TextBox();
            this.vectextbox = new System.Windows.Forms.TextBox();
            this.trainbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.heighttextbox = new System.Windows.Forms.TextBox();
            this.widthtextbox = new System.Windows.Forms.TextBox();
            this.numtextbox = new System.Windows.Forms.TextBox();
            this.infotextbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buffertextBox = new System.Windows.Forms.TextBox();
            this.featuretextBox = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.minhittextBox = new System.Windows.Forms.TextBox();
            this.maxfalsetextBox = new System.Windows.Forms.TextBox();
            this.numstagetextbox = new System.Windows.Forms.TextBox();
            this.negnumtextBox = new System.Windows.Forms.TextBox();
            this.negtextBox = new System.Windows.Forms.TextBox();
            this.xmltextbox = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.defaultbtn = new System.Windows.Forms.Button();
            this.processtextbox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createbtn
            // 
            this.createbtn.Location = new System.Drawing.Point(31, 207);
            this.createbtn.Name = "createbtn";
            this.createbtn.Size = new System.Drawing.Size(92, 23);
            this.createbtn.TabIndex = 0;
            this.createbtn.Text = "生成vec文件";
            this.createbtn.UseVisualStyleBackColor = true;
            this.createbtn.TextChanged += new System.EventHandler(this.button1_Click);
            this.createbtn.Click += new System.EventHandler(this.createbtn_Click);
            // 
            // outtextbox
            // 
            this.outtextbox.Location = new System.Drawing.Point(422, 25);
            this.outtextbox.Multiline = true;
            this.outtextbox.Name = "outtextbox";
            this.outtextbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outtextbox.Size = new System.Drawing.Size(348, 328);
            this.outtextbox.TabIndex = 3;
            // 
            // vectextbox
            // 
            this.vectextbox.Location = new System.Drawing.Point(81, 32);
            this.vectextbox.Name = "vectextbox";
            this.vectextbox.Size = new System.Drawing.Size(70, 21);
            this.vectextbox.TabIndex = 4;
            this.vectextbox.Text = "posvec";
            // 
            // trainbtn
            // 
            this.trainbtn.Location = new System.Drawing.Point(56, 258);
            this.trainbtn.Name = "trainbtn";
            this.trainbtn.Size = new System.Drawing.Size(75, 23);
            this.trainbtn.TabIndex = 5;
            this.trainbtn.Text = "开始训练";
            this.trainbtn.UseVisualStyleBackColor = true;
            this.trainbtn.Click += new System.EventHandler(this.trainbtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.heighttextbox);
            this.groupBox1.Controls.Add(this.widthtextbox);
            this.groupBox1.Controls.Add(this.numtextbox);
            this.groupBox1.Controls.Add(this.infotextbox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.createbtn);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.vectextbox);
            this.groupBox1.Location = new System.Drawing.Point(12, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 252);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "步骤一：生成样本vec文件";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "正例图片高";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 128);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "正例图片宽";
            // 
            // heighttextbox
            // 
            this.heighttextbox.Location = new System.Drawing.Point(81, 161);
            this.heighttextbox.Name = "heighttextbox";
            this.heighttextbox.Size = new System.Drawing.Size(70, 21);
            this.heighttextbox.TabIndex = 12;
            // 
            // widthtextbox
            // 
            this.widthtextbox.Location = new System.Drawing.Point(81, 125);
            this.widthtextbox.Name = "widthtextbox";
            this.widthtextbox.Size = new System.Drawing.Size(70, 21);
            this.widthtextbox.TabIndex = 11;
            // 
            // numtextbox
            // 
            this.numtextbox.Location = new System.Drawing.Point(81, 91);
            this.numtextbox.Name = "numtextbox";
            this.numtextbox.Size = new System.Drawing.Size(70, 21);
            this.numtextbox.TabIndex = 10;
            // 
            // infotextbox
            // 
            this.infotextbox.Location = new System.Drawing.Point(81, 64);
            this.infotextbox.Name = "infotextbox";
            this.infotextbox.Size = new System.Drawing.Size(70, 21);
            this.infotextbox.TabIndex = 9;
            this.infotextbox.Text = "pos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 12);
            this.label4.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "正例数量";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "正例信息文件";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "vec文件名";
            // 
            // buffertextBox
            // 
            this.buffertextBox.Location = new System.Drawing.Point(95, 231);
            this.buffertextBox.Name = "buffertextBox";
            this.buffertextBox.Size = new System.Drawing.Size(100, 21);
            this.buffertextBox.TabIndex = 32;
            this.buffertextBox.Text = "256";
            // 
            // featuretextBox
            // 
            this.featuretextBox.Location = new System.Drawing.Point(95, 204);
            this.featuretextBox.Name = "featuretextBox";
            this.featuretextBox.Size = new System.Drawing.Size(100, 21);
            this.featuretextBox.TabIndex = 31;
            this.featuretextBox.Text = "LBP";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 207);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(53, 12);
            this.label15.TabIndex = 29;
            this.label15.Text = "特征类型";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 234);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(65, 12);
            this.label14.TabIndex = 28;
            this.label14.Text = "缓冲区大小";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 115);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 26;
            this.label12.Text = "级联器数量";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 146);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 12);
            this.label11.TabIndex = 25;
            this.label11.Text = "最小命中率";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "最大错误警告率";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 23;
            this.label9.Text = "负例数量";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "放xml的文件夹\r\n";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 12);
            this.label7.TabIndex = 21;
            this.label7.Text = "反例文件夹";
            // 
            // minhittextBox
            // 
            this.minhittextBox.Location = new System.Drawing.Point(95, 143);
            this.minhittextBox.Name = "minhittextBox";
            this.minhittextBox.Size = new System.Drawing.Size(100, 21);
            this.minhittextBox.TabIndex = 20;
            this.minhittextBox.Text = "0.995";
            // 
            // maxfalsetextBox
            // 
            this.maxfalsetextBox.Location = new System.Drawing.Point(95, 176);
            this.maxfalsetextBox.Name = "maxfalsetextBox";
            this.maxfalsetextBox.Size = new System.Drawing.Size(100, 21);
            this.maxfalsetextBox.TabIndex = 19;
            this.maxfalsetextBox.Text = "0.3";
            // 
            // numstagetextbox
            // 
            this.numstagetextbox.Location = new System.Drawing.Point(95, 110);
            this.numstagetextbox.Name = "numstagetextbox";
            this.numstagetextbox.Size = new System.Drawing.Size(100, 21);
            this.numstagetextbox.TabIndex = 18;
            this.numstagetextbox.Text = "10";
            // 
            // negnumtextBox
            // 
            this.negnumtextBox.Location = new System.Drawing.Point(95, 83);
            this.negnumtextBox.Name = "negnumtextBox";
            this.negnumtextBox.Size = new System.Drawing.Size(100, 21);
            this.negnumtextBox.TabIndex = 17;
            // 
            // negtextBox
            // 
            this.negtextBox.Location = new System.Drawing.Point(95, 56);
            this.negtextBox.Name = "negtextBox";
            this.negtextBox.Size = new System.Drawing.Size(100, 21);
            this.negtextBox.TabIndex = 16;
            this.negtextBox.Text = "neg";
            // 
            // xmltextbox
            // 
            this.xmltextbox.Location = new System.Drawing.Point(95, 27);
            this.xmltextbox.Name = "xmltextbox";
            this.xmltextbox.Size = new System.Drawing.Size(100, 21);
            this.xmltextbox.TabIndex = 15;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(472, 374);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(245, 23);
            this.progressBar1.TabIndex = 8;
            // 
            // defaultbtn
            // 
            this.defaultbtn.Location = new System.Drawing.Point(197, 356);
            this.defaultbtn.Name = "defaultbtn";
            this.defaultbtn.Size = new System.Drawing.Size(63, 23);
            this.defaultbtn.TabIndex = 33;
            this.defaultbtn.Text = "默认值";
            this.defaultbtn.UseVisualStyleBackColor = true;
            this.defaultbtn.Click += new System.EventHandler(this.defaultbtn_Click);
            // 
            // processtextbox
            // 
            this.processtextbox.Location = new System.Drawing.Point(723, 376);
            this.processtextbox.Name = "processtextbox";
            this.processtextbox.Size = new System.Drawing.Size(47, 21);
            this.processtextbox.TabIndex = 9;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(413, 379);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 12);
            this.label13.TabIndex = 10;
            this.label13.Text = "训练进度";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.buffertextBox);
            this.groupBox2.Controls.Add(this.xmltextbox);
            this.groupBox2.Controls.Add(this.trainbtn);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.featuretextBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.negtextBox);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.maxfalsetextBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.minhittextBox);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.negnumtextBox);
            this.groupBox2.Controls.Add(this.numstagetextbox);
            this.groupBox2.Location = new System.Drawing.Point(201, 35);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 301);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "步骤二：开始训练";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(41, 361);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(149, 12);
            this.label16.TabIndex = 15;
            this.label16.Text = "对级联分类不熟请点击默认";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.defaultbtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.processtextbox);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.outtextbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createbtn;
        private System.Windows.Forms.TextBox outtextbox;
        private System.Windows.Forms.TextBox vectextbox;
        private System.Windows.Forms.Button trainbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox heighttextbox;
        private System.Windows.Forms.TextBox widthtextbox;
        private System.Windows.Forms.TextBox numtextbox;
        private System.Windows.Forms.TextBox infotextbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox minhittextBox;
        private System.Windows.Forms.TextBox maxfalsetextBox;
        private System.Windows.Forms.TextBox numstagetextbox;
        private System.Windows.Forms.TextBox negnumtextBox;
        private System.Windows.Forms.TextBox negtextBox;
        private System.Windows.Forms.TextBox xmltextbox;
        private System.Windows.Forms.TextBox buffertextBox;
        private System.Windows.Forms.TextBox featuretextBox;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button defaultbtn;
        private System.Windows.Forms.TextBox processtextbox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label16;
    }
}

