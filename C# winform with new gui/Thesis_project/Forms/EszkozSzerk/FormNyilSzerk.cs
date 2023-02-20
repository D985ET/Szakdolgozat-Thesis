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
    public partial class FormNyilSzerk : Form
    {
        private LEDArrow arrowToSzerk;
        //FORMHOZ:
        private Button currentButton;
        private Random vsz;
        private int tempIndex;
        private Form activeForm;
        public FormNyilSzerk(ref LEDArrow arrowToSzerk)
        {
            this.arrowToSzerk = arrowToSzerk;
            InitializeComponent();
            //kinézet:
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            Application.EnableVisualStyles();
            LoadTheme();
            SzerkNyil();
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
        private void SzerkNyil()
        {
            nyilAz.Text = arrowToSzerk.Azonos.ToString();
            nyilSzinAkt.Text = arrowToSzerk.Color.ToString();
            nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }

        private void nyilSzerkR_Click(object sender, EventArgs e)
        {
            arrowToSzerk.Color = Color.Red;
            nyilSzinAkt.Text = arrowToSzerk.Color.ToString();
        }

        private void nyilSzerkB_Click(object sender, EventArgs e)
        {
            arrowToSzerk.Color = Color.Blue;
            nyilSzinAkt.Text = arrowToSzerk.Color.ToString();
        }

        private void nyilSzerkG_Click(object sender, EventArgs e)
        {
            arrowToSzerk.Color = Color.Green;
            nyilSzinAkt.Text = arrowToSzerk.Color.ToString();
          
        }

        private void nyilSzerkDefault_Click(object sender, EventArgs e)
        {
            arrowToSzerk.Color = Color.Black;
            nyilSzinAkt.Text = arrowToSzerk.Color.ToString();
        }

        private void nyilSzerkBal_Click(object sender, EventArgs e)
        {
            arrowToSzerk.Direction = Direction.LEFT;
            nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }

        private void nyilSzerkJobb_Click(object sender, EventArgs e)
        {
            arrowToSzerk.Direction = Direction.RIGHT;
            nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }

        private void nyilSzerkBoth_Click(object sender, EventArgs e)
        {
            arrowToSzerk.Direction = Direction.BOTH;
            nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }

        private void btnMentNyil_Click(object sender, EventArgs e)
        {
            
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref json_source);//ez futtatja le a színt és a directiont
        }

     
    }
}
