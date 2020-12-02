using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.OCR;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form

    {
         Tesseract _ocr;
         Image<Bgr, byte> image;
         Image<Gray, byte> gray;
        
        public Form1()
        {
            InitializeComponent();
            recognizebtn.Enabled = false;
            //_ocr = new Tesseract();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void loadimgbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openimage = new OpenFileDialog();
            if(openimage.ShowDialog()==System.Windows.Forms.DialogResult.OK)
            {
                  image = new Image<Bgr, byte>(openimage.FileName);
                  gray = image.Convert<Gray, Byte>();
            }
            imageBox1.Image = image;
            recognizebtn.Enabled = true;

        }

        private void recognizebtn_Click(object sender, EventArgs e)
        {
            string path = Application.StartupPath+"\\tessdata";
            string language = "";
            if(checkBox1.Checked&&checkBox2.Checked)
            {
                language = "chi_sim+eng";

            }
            else
            {
                if(checkBox2.Checked)
                {
                    language = "chi_sim";

                }
                else
                {
                    language = "eng";
                    checkBox1.Checked = true;
                }
                try
                {
                    _ocr = new Tesseract(path, language, OcrEngineMode.Default);
                    _ocr.Recognize(gray);
                    Tesseract.Character[] characters = _ocr.GetCharacters();
                    Bgr drawcolor = new Bgr(Color.Blue);
                    foreach(Tesseract.Character c in characters)
                    {
                        image.Draw(c.Region, drawcolor, 1);
                    }
                    imageBox1.Image = image;
                    string text = _ocr.GetText();
                    richTextBox1.Text = text;

                }
                catch
                {
                    MessageBox.Show("检查运行目录是否有语言包");
                }
            }
        }
    }
}
