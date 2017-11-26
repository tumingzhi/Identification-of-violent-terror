using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Net.Http;

namespace _88142725tmz
{

    public partial class Form1 : Form
    {
        Sunisoft.IrisSkin.SkinEngine se = null;
        public Form1()
        {
            InitializeComponent();
          //  se = new Sunisoft.IrisSkin.SkinEngine();
          //  se.SkinAllForm = true;
         //   se.SkinFile = "ssk_files/60种皮肤界面ssk文件/界面ssk/SportsGreen.ssk";
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (ofdmain.ShowDialog() == DialogResult.OK)
            {
                if (null == ofdmain.FileName)
                    return;
                pb.Image = new Bitmap(ofdmain.FileName);
            }
        }
        public string antiterror()
        {
            string token = "24.034998681737127c0e0b678fe14b0cf2.2592000.1499330575.282335-9731591";
            string host = "https://aip.baidubce.com/rest/2.0/antiterror/v1/detect?access_token=" + token;
            MemoryStream m = new MemoryStream();
            Bitmap bp = new Bitmap(ofdmain.FileName);
            bp.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            byte[] b = m.GetBuffer();
            string strbaser64 = Convert.ToBase64String(b);
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.ContentType = "application/x-www-form-urlencoded";
            request.KeepAlive = true;
            String str = "image=" + HttpUtility.UrlEncode(strbaser64);


            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            // Console.WriteLine("暴恐识别:");
            //   Console.WriteLine(result);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            string zone = jo["result"].ToString();
            double number = Convert.ToDouble(zone);
            if (number > 0.5)
            {
                string baokong = "暴恐";
                return "识别结果:" + "         " + baokong + "\r\n" + "概率:" + "         " + number;
            }
            else
            {
                string normal = "正常";
                return normal + number;
            }
        }
        private void bt1_Click(object sender, EventArgs e)
        {
            txtResult.Font = new Font(txtResult.Font.Name, 16);
            txtResult.Text = antiterror();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
            if (textBox1.Text == "请输入网络图片URL")
            {
                textBox1.Text = "";
            }
        }

        private void pb_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void txtResult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtResult.Font = new Font(txtResult.Font.Name, 16);
                txtResult.Text = antiterror1();
            }
        }
                    public string antiterror1() {
            string url = string.Format(@"{0}", textBox1.Text);
            System.Net.WebRequest webreq = System.Net.WebRequest.Create(url);
            System.Net.WebResponse webres = webreq.GetResponse();
            using (System.IO.Stream stream = webres.GetResponseStream())
            {
                pb.Image = Image.FromStream(stream);
            }
            string token = "24.034998681737127c0e0b678fe14b0cf2.2592000.1499330575.282335-9731591";
            string host = "https://aip.baidubce.com/rest/2.0/antiterror/v1/detect?access_token=" + token;
            MemoryStream m = new MemoryStream();
            Bitmap bp = new Bitmap(pb.Image);
            bp.Save(m, System.Drawing.Imaging.ImageFormat.Png);
            byte[] b = m.GetBuffer();
            string strbaser64 = Convert.ToBase64String(b);
            Encoding encoding = Encoding.Default;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(host);
            request.Method = "post";
            request.ContentType = "application/x-www-form-urlencoded";
            request.KeepAlive = true;
            String str = "image=" + HttpUtility.UrlEncode(strbaser64);
            byte[] buffer = encoding.GetBytes(str);
            request.ContentLength = buffer.Length;
            request.GetRequestStream().Write(buffer, 0, buffer.Length);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.Default);
            string result = reader.ReadToEnd();
            // Console.WriteLine("暴恐识别:");
            //   Console.WriteLine(result);
            JObject jo = (JObject)JsonConvert.DeserializeObject(result);
            string zone = jo["result"].ToString();
            double number = Convert.ToDouble(zone);
            if (number > 0.5)
            {
                string baokong = "暴恐";
                return "识别结果:" + "         " + baokong + "\r\n" + "概率:" + "         " + number;
            }
            else
            {
                string normal = "正常";
                return normal + number;
            }
        }

        private void ostmain_Click(object sender, EventArgs e)
        {
            if (ofdmain.ShowDialog() == DialogResult.OK)
            {
                if (null == ofdmain.FileName)
                    return;
                pb.Image = new Bitmap(ofdmain.FileName);
            }
        }

        private void ctsmain_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void helpmain_Click(object sender, EventArgs e)
        {
            MessageBox.Show("可支持PNG、JPG、BMP图片文件，不支持GIF图片，图片大小不超过2M。为保证正常识别效果，请保证需要识别部分为图片主体部分。暴恐图像判断：result的值超过0.5则为暴恐图片，低于0.5为正常图片", "使用说明");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tsl.Text =DateTime.Now.ToString();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {

        }
    }
    }
        
   
