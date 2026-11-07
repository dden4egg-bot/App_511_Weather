using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace App_511_Weather
{
    public partial class WeatherItemControl : UserControl
    {
        public WeatherItemControl()
        {
            InitializeComponent();
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Title
        {
            get => labelTitle.Text;
            set => labelTitle.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public string Value
        {
            get => labelValue.Text;
            set => labelValue.Text = value;
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public Image? Icon
        {
            get => pictureBoxIcon.Image;
            set => pictureBoxIcon.Image = value;
        }
    }
}