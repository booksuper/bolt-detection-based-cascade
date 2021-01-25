using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cascadewinform
{
    public partial class Form1 : Form
    {
        //获取当前文件夹所在的基目录
        string cdpath = Directory.GetCurrentDirectory();
        //定义三个线程
        Thread thread1;
        Thread thread2;
        Thread thread3;
        string stagenums;
      
        public Form1()
        {
            InitializeComponent();  
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        //生成样本vec文件的方法
        private void createsamples()
        {
            try
            {
                //创建一个进程
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;//不显示程序窗口

                p.Start();//启动程序
                //获取基目录所在的盘符
                string panpath = cdpath.Substring(0, 2);
                //将操作命令组合成一个字符串，传给cmd命令台
                string createsample = "opencv_createsamples.exe" + " -vec " + vectextbox.Text + ".vec" + " -info " + infotextbox.Text + ".txt" + " -num " + numtextbox.Text + " -w " + widthtextbox.Text + " -h " + heighttextbox.Text;
                //注意！&&代表连续执行命令，中途不退出；&代表执行完之后就退出当前的cmd工作台
                string strCMD = panpath + "&&" + "cd " + cdpath + "&&" + createsample + "&exit";
                //向cmd窗口发送输入信息
                p.StandardInput.WriteLine(strCMD);
                p.StandardInput.AutoFlush = true;
                //获取cmd窗口的输出信息
                string output = p.StandardOutput.ReadToEnd();
                outtextbox.Text = output;
                MessageBox.Show("样本矢量文件posvec.vec生成成功，文件保存目录是" + cdpath,"结果");

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n跟踪;" + ex.StackTrace);
            }
            
        }

        //训练xml文件的方法
        private void trainsample()
        {
            //开始训练时，锁住控件，直到训练结束释放
            trainbtn.Enabled = false;
            createbtn.Enabled = false;
            defaultbtn.Enabled = false;
            try
            {
                //创建一个进程
                Process p = new Process();
                p.StartInfo.FileName = "cmd.exe";
                p.StartInfo.UseShellExecute = false;//是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;//接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;//由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;//重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;//不显示程序窗口

                p.Start();//启动程序
                // 创建放置xml文件的文件夹
                if (!Directory.Exists(cdpath + "\\" + xmltextbox.Text))
                {
                    Directory.CreateDirectory(cdpath + "\\" + xmltextbox.Text);
                }

                string panpath = cdpath.Substring(0, 2);
                string train = "opencv_traincascade.exe" + " -vec " + vectextbox.Text + ".vec" + " -numPos " + numtextbox.Text + " -numNeg " + negnumtextBox.Text + " -w " + widthtextbox.Text + " -h " + heighttextbox.Text + " -data " + xmltextbox.Text + " -bg " + negtextBox.Text + ".txt" + " -numStages " + numstagetextbox.Text + " -minHitRate " + minhittextBox.Text + " -maxFalseAlarmRate " + maxfalsetextBox.Text + " -weightTrimRate 0.95 " + " -featureType " + featuretextBox.Text + " -precalcValBufSize " + buffertextBox.Text + " -precalcIdxBufSize " + buffertextBox.Text;
                string strCMD = panpath + "&&" + "cd " + cdpath + "&&" + train + "&exit";
                //MessageBox.Show(strCMD);
                //向cmd窗口发送输入信息
                p.StandardInput.WriteLine(strCMD);
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息，这段命令笔者注释了，主要是觉得文本框中输出信息太多，看起来很繁琐
                //string output = p.StandardOutput.ReadToEnd();
                //outtextbox.Text = output;
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\r\n跟踪;" + ex.StackTrace);
            }
            //训练结束，释放控件
            trainbtn.Enabled = true;
            createbtn.Enabled = true;
            defaultbtn.Enabled = true;

        }

        //输出训练结果的信息
        private void trainout()
        {
            //先将该线程挂起0.5秒，让线程一先运行，生成放置xml的文件夹。若是这个线程先于线程一运行，可能找不到xml文件夹
            Thread.Sleep(500);
            int fileSum = 0;
            //获得用户输入的级联器数量，因为最后生成的文件多了params和cascade文件，所以加2
            stagenums = numstagetextbox.Text;
            int stagenum = Convert.ToInt32(stagenums);
            stagenum = stagenum + 2;
            do
            {
                string DocumentPath = cdpath +"\\" + xmltextbox.Text;
                //拿到该目录下的所有文件路径
                string[] files = Directory.GetFiles(DocumentPath);

                fileSum = files.Length;
                //string str = Convert.ToString(fileSum);
                //MessageBox.Show(str);
                //a用于显示进度
                int a = (fileSum * 100) / stagenum;
                //循环拿到生成的每一个的文件字符串，并保存到content中
                string content = "";
                foreach (string file in files)
                {
                    int b = file.LastIndexOf("\\") + 1;
                    string targetfile = file.Substring(b);
                    //此处换行为"\r\n"，\n不行
                    content = content + targetfile + "\r\n";

                }
                content = "正在输出训练好的文件，保存在" + cdpath + "\\" + xmltextbox.Text + "\r\n" + content;
                //有时候因为数据文件或者参数设置不恰当，会导致没有训练到预设的级联器数量便提前终止训练
                //此时依然会生成cascade文件，但该文件往往效果很差，一般需要重新训练
                //此段代码功能就是为了在训练提前终止时告知用户，及时修改相关参数和数据
                if(content.Contains("cascade.xml"))
                {
                    if(fileSum<stagenum)
                    {
                        progressBar1.Value = 100;
                        processtextbox.Text = "100" + "/" + "100";
                        MessageBox.Show("训练异常导致提前结束，请检查正反例的数据文件或者相关训练参数。");
                        break;
                    }
                    string result = content + "\r\n" + "训练完成。可使用的xml文件名为cascade.xml,保存目录是:" + cdpath + "\\" + xmltextbox.Text;
                    MessageBox.Show("训练完成。可使用的xml文件名为cascade.xml","训练结果");

                }
                
                outtextbox.Text = content;
                //给进度条赋值
                progressBar1.Value = a;
                progressBar1.Refresh();
                //给文本框赋值，需要加上refresh语句，不然文本框只会显示最终结果
                processtextbox.Text = a + "/" + "100";
                processtextbox.Refresh();

            } while (fileSum < stagenum);
            
        }

        private void createbtn_Click(object sender, EventArgs e)
        {
            createbtn.Enabled = false;
            //调用线程二，生成样本文件
            thread2 = new Thread(new ThreadStart(createsamples));
            thread2.IsBackground = true;
            thread2.Start();
            //释放按钮
            createbtn.Enabled = true;
            trainbtn.Enabled = true;
        }

        private void trainbtn_Click(object sender, EventArgs e)
        {
            //调用线程一和线程三，开始训练并且实时的输出训练信息
            thread1 = new Thread(new ThreadStart(trainsample));
            thread1.IsBackground = true;
            thread1.Start();
            thread3 = new Thread(new ThreadStart(trainout));
            thread3.IsBackground = true;
            thread3.Start();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            
            trainbtn.Enabled = false;
            //将该句设置为false，就不会出现线程调用错误，但这样不是很安全
            CheckForIllegalCrossThreadCalls = false;
            //预加载训练数据所在文件
            int d = cdpath.LastIndexOf('2');
            cdpath = cdpath.Substring(0, d + 2);
            cdpath = cdpath + "cascade_train";
            
        }
        //设置默认值
        private void defaultbtn_Click(object sender, EventArgs e)
        {
            vectextbox.Text = "posvec";
            infotextbox.Text = "pos";
            widthtextbox.Text = "40";
            heighttextbox.Text = "40";
            xmltextbox.Text = "cascade";
            negtextBox.Text = "neg";
            numstagetextbox.Text = "10";
            minhittextBox.Text = "0.995";
            maxfalsetextBox.Text = "0.3";
            featuretextBox.Text = "LBP";
            buffertextBox.Text = "256";
           
            string posnumPath = cdpath + "\\" + infotextbox.Text;
            string negnumpath = cdpath + "\\" + negtextBox.Text;
            //通过检测文件夹中的pos.txt中的信息，截取图片的长和宽
            string poswhpath = cdpath + "\\" + infotextbox.Text + ".txt";
            StreamReader sr = new StreamReader(poswhpath, Encoding.Default);
            string poswh = sr.ReadLine();
            int f = poswh.LastIndexOf(' ');
            string height = poswh.Substring(f + 1);
            string width = poswh.Substring(f - 2, 2);
            //获得pos和neg文件夹中的文件个数
            string[] negfiles = Directory.GetFiles(negnumpath);
            string[] posfiles = Directory.GetFiles(posnumPath);
            int posnum = posfiles.Length;
            int negnum = negfiles.Length;
            numtextbox.Text = Convert.ToString(posnum);
            negnumtextBox.Text = Convert.ToString(negnum);
            widthtextbox.Text = width;
            heighttextbox.Text = height;
        }
    }

}
    

