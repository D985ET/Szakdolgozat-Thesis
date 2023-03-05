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

namespace Thesis_project.Forms.EszkozSzerk
{
    public partial class FormHangszSzerk : Form
    {
        private Speaker speakerToSzerk;
        private Pitch selectedPitch;
        public FormHangszSzerk(ref Speaker speakerToSzerk)
        {
            this.speakerToSzerk = speakerToSzerk;
            speakerToSzerk.ClearSounds();
           
            InitializeComponent();
            //kinézet:
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            Application.EnableVisualStyles();
            
            
            LoadTheme();
            SzerkHangsz();
        }
        private int pitchEnumCount = Enum.GetNames(typeof(Pitch)).Length;
  
        private void SzerkHangsz()
        {
            hangszAzLbl.Text = speakerToSzerk.Azonos.ToString();

            foreach (Pitch pitches in Enum.GetValues(typeof(Pitch)))
            {
                pitchComboBox.Items.Add(pitches);
            }
           
          

           /* for (int i = 0; i < pitchEnumCount; i++)
            {
                
                pitchComboBox.Items.Add(pitchEnumCount)
            }*/
                

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
        private void timeMilisecBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.')) 
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

        }
      
        private void pitchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(pitchComboBox.SelectedItem);
            selectedPitch = (Pitch)pitchComboBox.SelectedItem;
        }

        private void btnHangMent_Click(object sender, EventArgs e)
        {
            if(pitchComboBox.SelectedItem == null)
            {
                aktHszinLbl.Text = "Válasszon ki hangszínt!";
                aktHszinLbl.BackColor = Color.Red;
                return;
            }
            speakerToSzerk.AddSound(selectedPitch, (byte)hangeroNumUp.Value, (ushort)timeMilisecBox.Value);
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();
            FormHelper.CallSetTurnForEachDevice(ref json_source); //ez futtatja le a színt
            speakerToSzerk.ClearSounds();
        }
    }
}
