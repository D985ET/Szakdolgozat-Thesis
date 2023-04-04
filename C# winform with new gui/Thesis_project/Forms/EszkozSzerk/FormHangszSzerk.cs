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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Thesis_project.Forms.EszkozSzerk
{
    public partial class FormHangszSzerk : Form
    {
        private Speaker speakerToSzerk;
        private Pitch selectedPitch;
        private int rowIndex;
        public static int rowCount;
        public FormHangszSzerk(int rowIndex)
        {
            this.rowIndex = rowIndex;
            //speakerToSzerk.ClearSounds();
           
            InitializeComponent();
            //kinézet:
            /* this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            this.ControlBox = false;
            /* this.WindowState = FormWindowState.Minimized;*/
            Application.EnableVisualStyles();
            
            
            LoadTheme();
            SzerkHangsz();
        }
        private int pitchEnumCount = Enum.GetNames(typeof(Pitch)).Length;
  
        private void SzerkHangsz()
        {
/*
            hangszAzLbl.Text = speakerToSzerk.Azonos.ToString();
            hangszAzLbl.Font = new Font("Myanmar Text", 20);
            hangszAzLbl.ForeColor = Color.Black;
            hangszAzLbl.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            hangszAzLbl.Dock = DockStyle.None;*/
            /*
            lblHangero.Font = new Font("Myanmar Text", 20);
            lblHangero.ForeColor = Color.Black;
            lblHangero.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHangero.Dock = DockStyle.None;

            lblHanghossz.Font = new Font("Myanmar Text", 20);
            lblHanghossz.ForeColor = Color.Black;
            lblHanghossz.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHanghossz.Dock = DockStyle.None;

            lblbtnHangero.Font = new Font("Myanmar Text", 20);
            lblHangszin.ForeColor = Color.Black;
            lblHangszin.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            lblHangszin.Dock = DockStyle.None;*/
            foreach (Pitch pitches in Enum.GetValues(typeof(Pitch)))
            {
                pitchComboBox.Items.Add(pitches);
            }
            pitchComboBox.SelectedIndex = 0;



            /* for (int i = 0; i < pitchEnumCount; i++)
             {

                 pitchComboBox.Items.Add(pitchEnumCount)
             }*/


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
        private void timeMilisecBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) 
            {
                e.Handled = true;
            }
            //only allow one decimal point
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

        }
      
        private void pitchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(pitchComboBox.SelectedItem);
            selectedPitch = (Pitch)pitchComboBox.SelectedItem;
        }
        private void btnCloseTop_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static Pitch[] pitch = new Pitch[100]; //rowCount
        public static byte[] hangero = new byte[100];
        public static ushort[] timeMilisec = new ushort[100];
        private void btnHangMent_Click_1(object sender, EventArgs e)
        {
            if (pitchComboBox.SelectedItem == null)
            {
                aktHszinLbl.Text = "Válasszon ki hangszínt!";
                aktHszinLbl.BackColor = Color.Red;
                return;
            }
            pitch[rowIndex] = selectedPitch;
           /* hangero[rowIndex] = (byte)hangeroNumUp.Value;*/
            timeMilisec[rowIndex] = (ushort)timeMilisecBox.Value;
            MessageBox.Show("Mentve!");
                     
        }
    }
}
