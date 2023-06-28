using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM
{
    public partial class InfoWeather : Form
    {
        public InfoWeather()
        {
            InitializeComponent();
        }
        
        public void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?lat=10.8333&lon=106.66679&appid=ec491fdc2b690a4af7775606317e84e3&units=metric&cnt=6");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root outPut = result;
                label2.Text = String.Format("{0}", outPut.name);
                label3.Text = String.Format("{0} \u00B0", outPut.main.temp);
                label4.Text = String.Format("{0}", outPut.wind.speed);
                label5.Text = String.Format ("{0}", outPut.main.humidity);
                label6.Text = String.Format("{0}", outPut.clouds.all);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            this.Hide();
            setting.ShowDialog();
        }

        private void InfoWeather_Load(object sender, EventArgs e)
        {
            getWeather();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            Application.Exit();
        }
    }
}
