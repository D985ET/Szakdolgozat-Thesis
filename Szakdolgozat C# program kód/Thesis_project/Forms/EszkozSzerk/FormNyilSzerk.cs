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
        private int rowIndex;
        public static int rowCount;
        public FormNyilSzerk(int rowIndex)
        {
            this.rowIndex = rowIndex;
            InitializeComponent();
            //kinézet:
            /*this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            this.ControlBox = false;
            /* this.WindowState = FormWindowState.Minimized;*/
            Application.EnableVisualStyles();
            LoadTheme();
            SzerkNyil();
        }
      
        private void LoadTheme()
        {
           /* foreach (Control btns in this.Controls)
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
        private void SzerkNyil()
        {
          
            //nyilSzinAkt.Text = arrowToSzerk.Color.ToString();
            //nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }
        public static Direction[] directions = new Direction[100];
        public static Color[] colors = new Color[100];
        Direction selectedDirection;
        

        private void nyilSzerkBal_Click_1(object sender, EventArgs e)
        {
            selectedDirection = Direction.LEFT;
            //nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }

        private void nyilSzerkJobb_Click_1(object sender, EventArgs e)
        {
            selectedDirection = Direction.RIGHT;
            //nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }

        private void nyilSzerkBoth_Click_1(object sender, EventArgs e)
        {
            selectedDirection = Direction.BOTH;
            //arrowToSzerk.Direction = Direction.BOTH;
            //nyilAktIrany.Text = arrowToSzerk.Direction.ToString();
        }

        private void ColorPickerBox_Click(object sender, EventArgs e)
        {
            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                ColorPickerBox.BackColor = colorPicker.Color; //megjelenik a color dialog cuccos
            }
            colors[rowIndex] = ColorPickerBox.BackColor;
            nyilSzinAkt.Text = ColorPickerBox.BackColor.Name;
        }

        private void btnCloseTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnMentNyil_Click_1(object sender, EventArgs e)
        {
            directions[rowIndex] = selectedDirection;
            this.Close();
        }
    }
}
