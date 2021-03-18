using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Drawing.Drawing2D;
using WindowsFormsApp1.Properties;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Bitmap radar = new Bitmap(Resources.radar360);


        SerialPort sp = new SerialPort("COM8", 9600, Parity.None, 8, StopBits.One);
               
        private void Form1_Load(object sender, EventArgs e)
        {

            pictureBox1.Image = (Bitmap)radar.Clone();

            //sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            //sp.Open();
        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string veri = sp.ReadLine();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sp.Close();
        }

        //private Bitmap ResimCiz(Bitmap Resim, Bitmap CizilecekResim)
        //{

        //    Graphics g = Graphics.FromImage(Resim);

        //    g.SmoothingMode = SmoothingMode.HighQuality;
            

        //    g.DrawImage((Image)CizilecekResim, new Point() { X = 15, Y = 14 });
                        
        //    return Resim;

        //}


        private double DegToRad(int deg)
        {
            return Math.PI * deg / 180;  // dereceyi radyana çevir
        }
      

        public void ResimCiz2(int KalemBoyutu)
        {
            Bitmap bmp = new Bitmap(pictureBox1.Image);

            Graphics g = Graphics.FromImage(bmp);
           
            //Pen blackPen = new Pen(Color.Blue, 10);

            //PointF y1p = new PointF(180, 0);
            //PointF y2p = new PointF(180, 360);

            //PointF x1p = new PointF(0, 180);
            //PointF x2p = new PointF(360, 180);

            //g.DrawLine(blackPen, y1p, y2p);
            //g.DrawLine(blackPen, x1p, x2p);


            Color alphaForeColor = Color.FromArgb(10, Color.LightGreen);
            Pen rectanglePen = new Pen(alphaForeColor, 2.0f);
            SolidBrush textBrush = new SolidBrush(alphaForeColor);

            Pen redPen = new Pen(alphaForeColor, KalemBoyutu);

            try
            {
                float x1 = 360 - Convert.ToSingle(x1Text.Text);
                float y1 = 180 - Convert.ToSingle(y1Text.Text);
                float x2 = 180 + Convert.ToSingle(Convert.ToDouble(x2Text.Text) * Math.Cos(DegToRad(Convert.ToInt32(Aci.Text))));
                float y2 = 180 - Convert.ToSingle(Convert.ToDouble(y2Text.Text) * Math.Sin(DegToRad(Convert.ToInt32(Aci.Text))));
                g.DrawLine(redPen, x1, y1, x2, y2);
            }
            catch
            { }
          
          
            redPen.Dispose();
            //blackPen.Dispose();

            pictureBox1.Image = bmp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResimCiz2(10);
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            //if (trackBar1.Value > 0)
            //{
            //    x2Text.Text = (100 - (trackBar1.Value*10)).ToString();
            //    y2Text.Text = trackBar1.Value.ToString();
            //}
            //else
            //{
            //    y2Text.Text = (100 - (trackBar1.Value*10)).ToString();
            //    x2Text.Text = trackBar1.Value.ToString();
            //}
            
            ResimCiz2(10);
        }

        private void button2_Click(object sender, EventArgs e)
        {

            #region VERSİYON 1
            //Açı text kutusu varsayılan değeri 0
            //for (int i = 0; i < 90; i++)
            //{
            //    Aci.Text = Convert.ToInt32(i).ToString();               
            //    ResimCiz2(20);              
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(200);             
            //}
            #endregion

            #region VERSİYON 2
            //Açı text kutusu varsayılan değeri 180
            //for (int i = 0; i < 180; i++)
            //{
            //    int sayi = Convert.ToInt32(Aci.Text);

            //    Aci.Text = i.ToString();
            //    ResimCiz2(10);
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(200);
            //}
            #endregion

            #region SOL TARAF
            //Açı text kutusu varsayılan değeri 180

            for (int i = 90; i < 270; i++)
            {
                Aci.Text = i.ToString();
                ResimCiz2(10);
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }

            Reset();

            for (int i = 270; i > 90; i--)
            {
                Aci.Text = i.ToString();
                ResimCiz2(10);
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }

            Reset();

            #endregion

            #region VERSİYON 4
            //Açı text kutusu varsayılan değeri 180
            //for (int i = 180; i < 360; i++)
            //{

            //    Aci.Text = i.ToString();
            //    ResimCiz2(10);
            //    Application.DoEvents();
            //    System.Threading.Thread.Sleep(200);
            //}
            #endregion

            #region SAĞ TARAF
            //Açı text kutusu varsayılan değeri 180
            for (int i = 270; i < 450; i++)
            {

                Aci.Text = i.ToString();
                ResimCiz2(10);
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }

            Reset();

            for (int i = 450; i > 270; i--)
            {

                Aci.Text = i.ToString();
                ResimCiz2(10);
                Application.DoEvents();
                System.Threading.Thread.Sleep(50);
            }

            Reset();


            #endregion



        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        public void Reset()
        {
            pictureBox1.Image = (Bitmap)radar.Clone();
        }
    }
}
