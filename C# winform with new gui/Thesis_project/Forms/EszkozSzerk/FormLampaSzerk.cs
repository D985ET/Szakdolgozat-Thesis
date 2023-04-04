using SLFormHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
  
        private int rowIndex;
        public static int rowCount;
        public FormLampaSzerk(int rowIndex)
        {
            this.rowIndex = rowIndex;
            InitializeComponent();
            //kinézet:
            /* this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            this.ControlBox = false;
            /* this.WindowState = FormWindowState.Minimized;*/
            //Application.EnableVisualStyles();
            /*LoadTheme();*/
            SzerkLampa();
            
        }
        private void LoadTheme()
        {
            /*foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = SzinTema.PrimaryColor;
                    btn.ForeColor = Color.Black; //ezt visszakell rakni majd white-ra
                    btn.FlatAppearance.BorderColor = SzinTema.SecondaryColor;
                }
            }*/
        }
        private void SzerkLampa()
        {
            //lampaAzLbl.Font = new Font("Myanmar Text", 20);
            //lampaAzLbl.ForeColor = Color.Black;
            //lampaAzLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            //lampaAzLbl.Dock = DockStyle.None;
            //lampaAzLbl.Text = lightToSzerk.Azonos.ToString();
            
            //aktSzinLamp.Font = new Font("Myanmar Text", 20);
            //aktSzinLamp.ForeColor = Color.Black;
            //aktSzinLamp.Anchor = AnchorStyles.Top;
            //aktSzinLamp.Dock = DockStyle.None;
            //aktSzinLamp.Text = lightToSzerk.Color.ToString();
           
           /* ColorPickerBox.BackColor = lightToSzerk.Color;*/
            aktSzinLamp.Text = ColorPickerBox.BackColor.ToString();
        }
        /*
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

        }*/

        private void lampaMentBtn_Click(object sender, EventArgs e)
        {

            this.Close();
            //string json_source = FormHelper.DevicesToJSON();
            //FormHelper.CallSetTurnForEachDevice(ref json_source);//ez futtatja le a színt
            //MessageBox.Show("Sikeresen beállítva");
        }
        public static Color[] colors = new Color[100];
     
        private void ColorPickerBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            
            if(colorPicker.ShowDialog() == DialogResult.OK)
            {
                ColorPickerBox.BackColor = colorPicker.Color; //megjelenik a color dialog cuccos
            }
           //lightToSzerk.Color = ColorPickerBox.BackColor;
            aktSzinLamp.Text = ColorPickerBox.BackColor.Name;
            colors[rowIndex] = ColorPickerBox.BackColor;
            Console.WriteLine(rowIndex);
            Console.WriteLine(colors[rowIndex]);
       

        }

        private void btnCloseTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
