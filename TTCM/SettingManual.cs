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
                string url = String.Format("https://api.openweathermap.org/data/3.0/onecall?lat=10.75&lon=106.6667&exclude={part}&appid=ec491fdc2b690a4af777}&units=metric&cnt=6");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root outPut = result;
                lb_thanhpho.Text = String.Format("{0}", outPut.name);
                lb_nhietdo.Text = String.Format("{0} \u00B0 C", outPut.main.temp);
            }
        }
    }
}