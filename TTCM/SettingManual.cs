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
using Newtonsoft.Json;

namespace TTCM
{
    public partial class SettingManual : Form
    {
        public SettingManual()
        {
            InitializeComponent();
            getWeather();
        }
        void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?lat=10.8333&lon=106.66679&appid=ec491fdc2b690a4af7775606317e84e3&units=metric&cnt=6");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root outPut = result;
                lb_thanhpho.Text = String.Format("{0}", outPut.name);
                lb_nhietdo.Text = String.Format("{0} \u00B0 C", outPut.main.temp);
            }
        }
    }
}