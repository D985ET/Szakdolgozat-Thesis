using SLFormHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_project.Forms
{
    public partial class FormLampaSzerk : Form
    {
        private LEDLight lightToSzerk;
        public FormLampaSzerk(ref LEDLight lightToSzerk)
        {
            this.lightToSzerk = lightToSzerk;
            InitializeComponent();
            //kinézet:
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            Application.EnableVisualStyles();
            LoadTheme();
            SzerkLampa();
        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black; //ezt visszakell rakni majd white-ra
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }
        private void SzerkLampa()
        {
            lampaAzLbl.Text = lightToSzerk.Azonos.ToString();
            aktSzinLamp.Text = lightToSzerk.Color.ToString();
          
        }
        private void lampaBtnPir_Click(object sender, EventArgs e)
        {
            lightToSzerk.Color = Color.Red;
            aktSzinLamp.Text = lightToSzerk.Color.ToString();
        }

        private void lampaBtnKek_Click(object sender, EventArgs e)
        {
            lightToSzerk.Color = Color.Blue;
            aktSzinLamp.Text = lightToSzerk.Color.ToString();
        }

        private void lampaBtnZold_Click(object sender, EventArgs e)
        { 

            lightToSzerk.Color = Color.Green;
            aktSzinLamp.Text = lightToSzerk.Color.ToString();
        }

        private void lampaBtnUres_Click(object sender, EventArgs e)
        {
            lightToSzerk.Color = Color.Black;
            aktSzinLamp.Text = "Üres!";

        }

        private void lampaMentBtn_Click(object sender, EventArgs e)
        {
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();
            FormHelper.CallSetTurnForEachDevice(ref json_source);//ez futtatja le a színt
        }
    }
}
