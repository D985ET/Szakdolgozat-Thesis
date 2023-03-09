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
using static System.Net.Mime.MediaTypeNames;

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
            /* this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            this.Width = 800;
            this.Height = 500;
           /* this.WindowState = FormWindowState.Minimized;*/
            //Application.EnableVisualStyles();
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
                    btn.BackColor = SzinTema.PrimaryColor;
                    btn.ForeColor = Color.Black; //ezt visszakell rakni majd white-ra
                    btn.FlatAppearance.BorderColor = SzinTema.SecondaryColor;
                }
            }
        }
        private void SzerkLampa()
        {
            lampaAzLbl.Font = new Font("Myanmar Text", 20);
            lampaAzLbl.ForeColor = Color.Black;
            lampaAzLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lampaAzLbl.Dock = DockStyle.None;
            lampaAzLbl.Text = lightToSzerk.Azonos.ToString();
            
            aktSzinLamp.Font = new Font("Myanmar Text", 20);
            aktSzinLamp.ForeColor = Color.Black;
            aktSzinLamp.Anchor = AnchorStyles.Top;
            aktSzinLamp.Dock = DockStyle.None;
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
