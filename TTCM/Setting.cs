using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTCM
{
    public partial class Setting : Form
    {
        public double s1;
        public Setting()
        {
            InitializeComponent();
            string[] baudrate = { "2400", "4800", "9600", "11200" };
            comboBox_Baudrate.Items.AddRange(baudrate);
            double s1;
            String[] Port = SerialPort.GetPortNames();
            foreach (String port in Port)
                comboBox_COM.Items.Add(port);
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            groupketnoi.Enabled = true;
            groupchedo.Enabled = false;
            groupdulieu.Enabled = false;    
            groupcaidat.Enabled = false;    
            groupthietbi.Enabled = false;
            button_ngat.Enabled = false;
            btn_Save.Enabled = false;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string AllData = "";
            AllData = serialPort1.ReadLine();
            txtdulieu.Text = AllData;
        }

        private void button_ketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = comboBox_COM.Text;
                serialPort1.BaudRate = Convert.ToInt32(comboBox_Baudrate.Text);
                serialPort1.Open();
                button_ketnoi.Enabled = false;
                button_ngat.Enabled = true;
                if (button_ngat.Enabled)
                {
                    groupdulieu.Enabled = false;
                    groupchedo.Enabled = true;
                    groupcaidat.Enabled = true;
                }
                MessageBox.Show("Đã Kết Nối");
            }
            catch
            {
                MessageBox.Show("Chưa Kết Nối");
            }
        }

        private void button_ngat_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Close();

                button_ketnoi.Enabled = true;
                button_ngat.Enabled = false;
                groupdulieu.Enabled = false;
                groupchedo.Enabled = false;

                groupcaidat.Enabled = false;
                MessageBox.Show("Đã Ngắt Kết Nối");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            Application.Exit();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            String Select = cb_cheDo.SelectedItem.ToString();
            if (Select == "Auto")
            {
                MessageBox.Show("Đã chọn chế độ Auto");
                groupcaidat.Enabled = false;
                caidat1.Enabled = false;
                btn_Save.Enabled = false;
                WeatherInfo.root weatherInfo = new WeatherInfo.root();
                getWeather();
                using (WebClient web = new WebClient())
                    {
                        string url = String.Format("https://api.openweathermap.org/data/2.5/weather?lat=10.8333&lon=106.66679&appid=ec491fdc2b690a4af7775606317e84e3&units=metric&cnt=6");
                        var json = web.DownloadString(url);
                        var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                        WeatherInfo.root outPut = result;
                        double nhietdo = outPut.main.temp;


                        if (Convert.ToDouble(txtdulieu.Text) > (nhietdo))
                        {
                            MessageBox.Show("Nhiệt độ phòng sẽ được điều chỉnh về 25 °C, nếu muốn điều chỉnh thêm về nhiệt độ vui lòng chọn chế độ Manual", "Khuyến nghị", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            txttrangthai.BackColor = Color.Green;
                            serialPort1.Write("A");
                        }
                        else
                        {
                            MessageBox.Show("Nhiệt độ phòng đang thấp hơn dữ liệu OpenWeather, các thiết bị làm mát sẽ không được bật, nếu muốn điều chỉnh thêm về nhiệt độ vui lòng chọn chế độ Manual", "Khuyến nghị", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            txttrangthai.BackColor = Color.Red;
                            serialPort1.Write("B");
                        }
                    }

                }
            else
                {
                    groupcaidat.Enabled = true;
                    btn_Save.Enabled = true;
                    MessageBox.Show("Đã chọn chế độ Manual");
                }
        }
        public void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = String.Format("https://api.openweathermap.org/data/2.5/weather?lat=10.8333&lon=106.66679&appid=ec491fdc2b690a4af7775606317e84e3&units=metric&cnt=6");
                var json = web.DownloadString(url);
                var result = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                WeatherInfo.root outPut = result;
                lb_thanhpho.Text = String.Format("{0}", outPut.name);
                lb_nhietdo.Text = String.Format("{0} \u00B0", outPut.main.temp);
                double nhietdo = outPut.main.temp;
            }
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtdulieu.Text) > Convert.ToDouble(caidat1.Text))
            {

                txttrangthai.BackColor = Color.Green;
                serialPort1.Write("A");
            }
            else
            {
                txttrangthai.BackColor = Color.Red;
                serialPort1.Write("B");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.ShowDialog();
        }
    }
}
