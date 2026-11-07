using System;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Windows.Forms;

namespace App_511_Weather
{
    public partial class Form1 : Form
    {
        private WeatherManager weatherManager = new WeatherManager();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // 1. Setup the FlowLayoutPanel to look nice and allow scrolling
            weatherItemsPanel.AutoScroll = true;
            weatherItemsPanel.WrapContents = true;

            // 2. Load the background image programmatically
            try
            {
                string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Backgrounds", "clouds_bg.jpg");
                if (File.Exists(imagePath))
                {
                    this.BackgroundImage = Image.FromFile(imagePath);
                    this.BackgroundImageLayout = ImageLayout.Stretch;
                }
                else
                {
                    this.BackColor = Color.SkyBlue; // Fallback if image is missing
                }
            }
            catch
            {
                this.BackColor = Color.SkyBlue;
            }
        }

        private async void buttonGetData_Click(object sender, EventArgs e)
        {
            string city = textBoxCityName.Text.Trim();
            if (string.IsNullOrEmpty(city)) return;

            buttonGetData.Enabled = false;
            buttonGetData.Text = "Loading...";

            WeatherResponse? weather = await weatherManager.GetWeatherAsync(city);

            buttonGetData.Enabled = true;
            buttonGetData.Text = "Get data";

            if (weather != null)
            {
                // Update main UI
                labelCity.Text = $"{weather.Name}, {weather.Sys.Country}";
                labelTemperature.Text = $"{Math.Round(weather.Main.Temp)}°C";

                if (weather.Weather.Count > 0)
                {
                    labelSummary.Text = weather.Weather[0].Description;
                }

                // Clear old tiles
                weatherItemsPanel.Controls.Clear();

                // Add new tiles with icons
                AddWeatherItem("Feels like", $"{Math.Round(weather.Main.Feels_Like)}°C", "🌡️");
                AddWeatherItem("Humidity", $"{weather.Main.Humidity}%", "💧");
                AddWeatherItem("Wind", $"{weather.Wind.Speed} m/s", "💨");
                AddWeatherItem("Pressure", $"{weather.Main.Pressure} hPa", "⏱️");
                AddWeatherItem("Clouds", $"{weather.Clouds.All}%", "☁️");
                AddWeatherItem("Visibility", $"{weather.Visibility / 1000.0} km", "👁️");
            }
            else
            {
                MessageBox.Show("City not found or network error. Please try again.", "Error");
            }
        }

        private void AddWeatherItem(string title, string value, string emoji)
        {
            WeatherItemControl item = new WeatherItemControl();
            item.Title = title;
            item.Value = value;
            item.Icon = GenerateEmojiIcon(emoji);
            item.Margin = new Padding(10);
            weatherItemsPanel.Controls.Add(item);
        }

        private Image GenerateEmojiIcon(string emoji)
        {
            Bitmap bmp = new Bitmap(60, 60);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                using (Font font = new Font("Segoe UI Emoji", 28))
                {
                    SizeF size = g.MeasureString(emoji, font);
                    float x = (bmp.Width - size.Width) / 2;
                    float y = (bmp.Height - size.Height) / 2;
                    g.DrawString(emoji, font, Brushes.White, x, y);
                }
            }
            return bmp;
        }
    }
}