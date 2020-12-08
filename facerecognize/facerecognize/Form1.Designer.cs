namespace facerecognize
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
            this.components = new System.ComponentModel.Container();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.opencap = new System.Windows.Forms.Button();
            this.savebtn = new System.Windows.Forms.Button();
            this.trainbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labeltextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 23);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(555, 313);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            this.imageBox1.Click += new System.EventHandler(this.imageBox1_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(623, 23);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(115, 110);
            this.imageBox2.TabIndex = 2;
            this.imageBox2.TabStop = false;
            // 
            // opencap
            // 
            this.opencap.Location = new System.Drawing.Point(193, 351);
            this.opencap.Name = "opencap";
            this.opencap.Size = new System.Drawing.Size(75, 23);
            this.opencap.TabIndex = 3;
            this.opencap.Text = "打开摄像头";
            this.opencap.UseVisualStyleBackColor = true;
            this.opencap.Click += new System.EventHandler(this.opencap_Click);
            // 
            // savebtn
            // 
            this.savebtn.Location = new System.Drawing.Point(417, 351);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(75, 23);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "保存图片";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // trainbtn
            // 
            this.trainbtn.Location = new System.Drawing.Point(623, 351);
            this.trainbtn.Name = "trainbtn";
            this.trainbtn.Size = new System.Drawing.Size(75, 23);
            this.trainbtn.TabIndex = 5;
            this.trainbtn.Text = "训练图片";
            this.trainbtn.UseVisualStyleBackColor = true;
            this.trainbtn.Click += new System.EventHandler(this.trainbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(588, 304);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "名字";
            // 
            // labeltextBox
            // 
            this.labeltextBox.Location = new System.Drawing.Point(623, 301);
            this.labeltextBox.Name = "labeltextBox";
            this.labeltextBox.Size = new System.Drawing.Size(100, 21);
            this.labeltextBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labeltextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trainbtn);
            this.Controls.Add(this.savebtn);
            this.Controls.Add(this.opencap);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.imageBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBox1;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button opencap;
        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.Button trainbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox labeltextBox;
    }
}

