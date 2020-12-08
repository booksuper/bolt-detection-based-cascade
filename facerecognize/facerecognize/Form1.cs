using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Face;
using Emgu.CV.Structure;
using Emgu.CV.Util;
using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace facerecognize
{
    public partial class Form1 : Form
    {
        Capture _capture;
        CascadeClassifier face_detect = new CascadeClassifier(@"haarcascade\haarcascade_frontalface_alt2.xml");//haarcascade_frontalface_alt2
        Mat face_image = new Mat();
        VectorOfInt image_lable = new VectorOfInt();
        VectorOfMat image_data = new VectorOfMat();
        string[] name;
        FaceRecognizer face_recognize = new LBPHFaceRecognizer();
        bool after_train = false;
        bool catch_face = false;
        ASCIIEncoding ascii = new ASCIIEncoding();


        public Form1()
        {
            InitializeComponent();
        }

        void frame(object sender,EventArgs e)
        {
            Mat scr = _capture.QueryFrame();
            CvInvoke.Resize(scr, scr, new Size(320, 240));
            Rectangle[] recs = face_detect.DetectMultiScale(scr);
            foreach(Rectangle rec in recs)
            {
                CvInvoke.Rectangle(scr, rec, new MCvScalar(0, 0, 255));
                imageBox2.Image = new Mat(scr, rec);
                imageBox1.Image = scr;

            }
            if(catch_face)
            {
                if(labeltextBox.Text!=null)
                {
                    string labeltext = labeltextBox.Text;
                    //MessageBox.Show(labeltext.ToString());
                    //byte[] by = Encoding.GetEncoding("GB2312").GetBytes(labeltext);
                    ////labeltext = ascii.GetString(by);
                    //labeltext = Encoding.Unicode.GetString(by);

                    //MessageBox.Show(labeltext);

                    face_image = new Image<Gray, byte>(new Bitmap(imageBox2.Image.Bitmap)).Resize(120, 120, Inter.Area).Mat;
                    face_image.Save("Image_data" + "\\" + labeltext + "_" + DateTime.Now.Year + DateTime.Now.Month + DateTime.Now.Day + ".jpg");
                    MessageBox.Show("保存成功");
                    catch_face = false;
                }
            }

            if(after_train)
            {
                foreach(Rectangle rec in recs)
                {
                    string text = "";
                    Mat scr_image = new Mat(scr, rec);
                    scr_image = scr_image.ToImage<Gray, byte>().Resize(120, 120, Inter.Area).Mat;
                    FaceRecognizer.PredictionResult result = face_recognize.Predict(scr_image);
                    text = name[result.Label];
                    if(result.Distance>3000)
                    {
                        text = "Miss";

                    }
                    CvInvoke.PutText(scr, text, rec.Location, FontFace.HersheyComplex, 1, new MCvScalar(0, 0, 255));
                    imageBox1.Image = scr;

                }
            }
        }

        private void imageBox1_Click(object sender, EventArgs e)
        {

        }

        private void opencap_Click(object sender, EventArgs e)
        {
            _capture = new Capture(0);
            Application.Idle += frame;

        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            catch_face = true;
        }

        private void trainbtn_Click(object sender, EventArgs e)
        {
            string[] path = Directory.GetFiles("Image_data");
            Mat[] data = new Mat[path.Length];
            int[] label = new int[path.Length];
            name = new string[path.Length];
            for(int i =0;i<path.Length;i++)
            {
                Image<Gray, byte> image = new Image<Gray, byte>(path[i]);
                data[i] = image.Mat;
                label[i] = i;
                int a = path[i].LastIndexOf('\\');
                int b = path[i].LastIndexOf('_');
                name[i] = path[i].Substring(a+1, b - a - 1);

            }
            image_data.Push(data);
            image_lable.Push(label);
            face_recognize.Train(image_data, image_lable);
            face_recognize.Save("face\\data.txt");
            MessageBox.Show("训练成功");
            after_train = true;
            

        }
    }
}
