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
        public FormHangszSzerk(ref Speaker speakerToSzerk)
        {
            this.speakerToSzerk = speakerToSzerk;
            InitializeComponent();
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
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.Black; //ezt visszakell rakni majd white-ra
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
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
    }
}
