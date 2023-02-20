﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLFormHelper;
using Thesis_project.Forms.EszkozSzerk;

namespace Thesis_project.Forms
{
    public partial class FormInditas : Form
    {

        bool dev485Set;
        public void setDev485(bool dev485Set)
        {
     
            this.dev485Set = dev485Set;
        }
        public bool getDev485()
        {
            return this.dev485Set;
        }
        
        public FormInditas()
        {
            InitializeComponent();
            //kinézet:
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            Application.EnableVisualStyles();
            LoadTheme();
            
        }

        //ez az összes formba megy majd
       
        public void LoadTheme()
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
            
            if(dev485Set == false)
            {
               Res.Text = FormHelper.CallFelmeres().ToString();

                setDev485(true);
                Gombokat_Kirak();
            }

        }
        public void Gombokat_Kirak()
        {

            Point p = new Point(0, 0);
            bool elsosor = false;

            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                Console.WriteLine();
                Console.WriteLine(SLFormHelper.FormHelper.Devices[i].GetType().Name);
                Eszközöknevei.Text += SLFormHelper.FormHelper.Devices[i].GetType().Name + "\n";
                for (int j = 0; j < 1; j++)
                {
                    if (SLFormHelper.FormHelper.Devices[i].GetType() == typeof(LEDArrow))
                    {
                        nyilatKirak(p);
                    }
                    if (SLFormHelper.FormHelper.Devices[i].GetType() == typeof(LEDLight))
                    {
                        lampatKirak(p);

                    }
                    if (SLFormHelper.FormHelper.Devices[i].GetType() == typeof(Speaker))
                    {
                        hangszoroKirak(p);
                    }
                    if (SLFormHelper.FormHelper.Devices.Count > 9 && elsosor == true) /* SLFormHelper.FormHelper.Devices.Count > 6*/
                    {

                        if (p.X != 0 && p.Y == 100)
                        {
                            p.X = 0;
                            p.Y = 200;
                        }
                        else if (p.X == 0 && p.Y == 200)
                        {
                            p.X = p.X + 100;
                        }
                        else
                        {
                            p.X = p.X + 100;
                        }

                    }
                    if (SLFormHelper.FormHelper.Devices.Count > 6 && elsosor == false)/* SLFormHelper.FormHelper.Devices.Count > 6*/
                    {

                        if (SLFormHelper.FormHelper.Devices.Count == 5)
                        {
                            elsosor = true;
                        }
                        if (p.X != 0 && p.Y == 0)
                        {
                            p.X = 0;
                            p.Y = 100;
                        }
                        else if (p.X == 0 && p.Y == 100)
                        {
                            p.X = p.X + 100;
                        }
                        else
                        {
                            p.X = p.X + 100;
                        }
                    }

                    else //6 alatt fut le
                    {
                        p.Y = 0;
                        p.X = p.X + 100;
                    }

                }
            }
              
            /*lampAktSzin.Text = ((LEDLight)FormHelper.Devices[0]).Color.ToString();*/
            EszkozokdbTxt.Text = SLFormHelper.FormHelper.Devices.Count.ToString() + " db"; //hány db eszköz van

        }
        

        //buttonok kirakása attól függően hogy mik.
   
        public void nyilatKirak(Point location)
        {

            Button arrowButton = new Button();

            try
            {
                if(location.X < 0 || location.Y < 0)
                {
                    throw new Exception("A paraméterben kapott érték nem megfelelő");
                }
                arrowButton.Location = location;
            }
            catch (Exception e)
            {

                throw new Exception("A paraméterben kapott érték nem megfelelő",e);
            }
           

            arrowButton.Width = 200;
            arrowButton.Height = 200;
           
            arrowButton.BackColor = Color.White;
            arrowButton.Image = Image.FromFile(@"img\right-arrow.png");
            arrowButton.FlatStyle = FlatStyle.Flat;
            arrowButton.FlatAppearance.BorderSize = 0;

            panel1.Controls.Add(arrowButton);
            arrowButton.Click += ArrowButton_Click;
        }
        private FormNyilSzerk nyilSzerkForm; //nyil kirakás új form Clickre.
        private void ArrowButton_Click(object sender, EventArgs e)
        {
            LEDArrow ledArrow1;
            if (FormHelper.Devices[0] is LEDArrow)
            {
                FormMainMenu formMain = new FormMainMenu();
                ledArrow1 = (LEDArrow)FormHelper.Devices[0];
                nyilSzerkForm = new FormNyilSzerk(ref ledArrow1);
            }
            /*FormMainMenu formMain = new FormMainMenu();
            var frm = (FormMainMenu)this.Owner;
            if (frm != null)
            {
                frm.btnSzerkesztes_Click(sender, e);
            }*/
           
            nyilSzerkForm.Show();
        }

        private void lampatKirak(Point location)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));

            Button lampaButton = new Button();
           
            lampaButton.Width = 200;
            lampaButton.Height = 200;
            lampaButton.Location = location;
            lampaButton.BackColor = Color.White;
            lampaButton.FlatStyle = FlatStyle.Flat;
            lampaButton.FlatAppearance.BorderSize = 0;
            //lampaButton.Text = "LAMPA";//TODO IMAGE
            lampaButton.Image = Image.FromFile(@"img\lamp.png");
           
            panel1.Controls.Add(lampaButton);
            lampaButton.Click += LampaButton_Click;
        }
        FormLampaSzerk lampaSzerkForm;
        private void LampaButton_Click(object sender, EventArgs e)
        {
            LEDLight ledLight1;
            if (FormHelper.Devices[0] is LEDLight)
            {
                FormMainMenu formMain = new FormMainMenu();
                ledLight1 = (LEDLight)FormHelper.Devices[0];
                lampaSzerkForm = new FormLampaSzerk(ref ledLight1);
            }
            lampaSzerkForm.Show();
        }

        private void hangszoroKirak(Point location)
        {
            Button hangszoroButton = new Button();
          
            hangszoroButton.Location = location;

            hangszoroButton.Width = 200;
            hangszoroButton.Height = 200;
            /*hangszoroButton.Location = location;*/
            hangszoroButton.Image = Image.FromFile(@"img\speaker-filled-audio-tool.png");

            hangszoroButton.FlatStyle = FlatStyle.Flat;
            hangszoroButton.FlatAppearance.BorderSize = 0;
            /*hangszoroButton.Text = "HANGSZORO";//TODO IMA*/
            panel1.Controls.Add(hangszoroButton);
            hangszoroButton.Click += hangszoroButton_Click;
        }
        FormHangszSzerk hangSzerkForm;
        private void hangszoroButton_Click(object sender, EventArgs e)
        {
            Speaker speaker1;
            
            if (FormHelper.Devices[0] is Speaker)
            {
                speaker1 = (Speaker)FormHelper.Devices[0];
                hangSzerkForm = new FormHangszSzerk(ref speaker1);
            }
            hangSzerkForm.Show();
        }



        //nyíl
        private void nyilKek_Click(object sender, EventArgs e)
        {
            /*LEDLight light = (LEDLight)FormHelper.Devices[0];
            light.Color = Color.Blue;
            
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();
            
            FormHelper.CallSetTurnForEachDevice(ref turn, ref json_source);*/
        
            LEDArrow ledArrow1 = (LEDArrow)FormHelper.Devices[0];
            ledArrow1.Color = Color.Red;
            ledArrow1.Direction = Direction.RIGHT;

            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }

        private void nyilUres_Click(object sender, EventArgs e)
        {
            LEDArrow ledArrow1 = (LEDArrow)FormHelper.Devices[0];
            ledArrow1.Color = Color.Black;
            ledArrow1.Direction = Direction.BOTH;

            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }
        //hangszóró
        private void hangszOn_Click(object sender, EventArgs e)
        {
            Speaker speaker1;
            speaker1 = (Speaker)FormHelper.Devices[0]; //itt baj van, mert egy hangtömböt kéne kiküldeni

            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.D_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.C_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.GISZ, volume: 63, length: 200);
            speaker1.AddSound(Pitch.H_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.C_OKTAV1, volume: 63, length: 200);
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();
           
            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }

        private void hangszOff_Click(object sender, EventArgs e)
        {
            Speaker speaker1;
            speaker1 = (Speaker)FormHelper.Devices[0]; //itt baj van, mert egy hangtömböt kéne kiküldeni
            speaker1.ClearSounds();

            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }
        //lámpa
        private void kekLampa_Click(object sender, EventArgs e)
        {
            LEDLight ledlight1;
            if (FormHelper.Devices[0] is LEDLight)
            {
                ledlight1 = (LEDLight)FormHelper.Devices[0];
                ledlight1.Color = Color.Blue;
            }
          
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();
            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }

        private void lampaUres_Click(object sender, EventArgs e)
        {

            LEDLight ledlight1;
            if (FormHelper.Devices[0] is LEDLight)
            {
                ledlight1 = (LEDLight)FormHelper.Devices[0];
                ledlight1.Color = Color.Black;

            }
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }

        private void lampEllenBtn_Click(object sender, EventArgs e)
        {
            string json_source = FormHelper.DevicesToJSON();
            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }

        private void utemFuttLmpBtn_Click(object sender, EventArgs e)
        {

        }

        private void nyilEllenBtn_Click(object sender, EventArgs e)
        {
            string json_source = FormHelper.DevicesToJSON();
            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }

        private void hangszEllenBtn_Click(object sender, EventArgs e)
        {
           /* Speaker speaker1;
            speaker1 = (Speaker)FormHelper.Devices[0]; //itt baj van, mert egy hangtömböt kéne kiküldeni

            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.D_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.C_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.E, volume: 63, length: 200);
            speaker1.AddSound(Pitch.GISZ, volume: 63, length: 200);
            speaker1.AddSound(Pitch.H_OKTAV1, volume: 63, length: 200);
            speaker1.AddSound(Pitch.C_OKTAV1, volume: 63, length: 200);*/
            string json_source = FormHelper.DevicesToJSON();
            FormHelper.CallSetTurnForEachDevice(ref json_source);
        }

        private void timeMilisecBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            //only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void kekespiroslamp_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                
               

                if (FormHelper.Devices[i] is LEDLight)
                {
                    LEDLight ledlight1;
                    ledlight1 = (LEDLight)FormHelper.Devices[0];
                    ledlight1.Color = Color.Blue;
                }
                if (FormHelper.Devices[i] is Speaker)
                {
                    Speaker speaker1;

                    if (timeElapsed == timeMilisecBox.Value)
                    {
                        speaker1 = (Speaker)FormHelper.Devices[i]; //itt baj van, mert egy hangtömböt kéne kiküldeni
                        speaker1.AddSound(Pitch.C_OKTAV1, volume: 63, length: 200);
                    }
                }
                byte turn = 1;
                string json_source = FormHelper.DevicesToJSON();
                FormHelper.CallSetTurnForEachDevice(ref json_source);

                /* LEDLight ledlight1;
                 if (FormHelper.Devices[0] is LEDLight)
                 {
                     ledlight1 = (LEDLight)FormHelper.Devices[0];
                     ledlight1.Color = Color.Blue;

                 }

                 byte turn = 1;
                 string json_source = FormHelper.DevicesToJSON();
                 FormHelper.CallSetTurnForEachDevice(ref json_source);*/
            }
        }
        private int timeElapsed = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            timeElapsed = timeElapsed + 100;
            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                 //100-al növelem
                if (FormHelper.Devices[i] is LEDLight)
                {
                    LEDLight ledlight1;
                    if (timeElapsed == timeMilisecBox.Value)
                    {
                        ledlight1 = (LEDLight)FormHelper.Devices[i];
                        ledlight1.Color = Color.Black;
                    }
                    if (timeElapsed == timeMilisecBox.Value + 1000)
                    {
                        ledlight1 = (LEDLight)FormHelper.Devices[i];
                        ledlight1.Color = Color.Green;
                    }

                }
                //speaker
                if (FormHelper.Devices[i] is Speaker)
                {
                    Speaker speaker1;
                   
                    if (timeElapsed == timeMilisecBox.Value)
                    {
                        speaker1 = (Speaker)FormHelper.Devices[i]; //itt baj van, mert egy hangtömböt kéne kiküldeni
                        speaker1.ClearSounds();
                    }
                    if (timeElapsed == timeMilisecBox.Value + 1000)
                    {
                        speaker1 = (Speaker)FormHelper.Devices[i]; //itt baj van, mert egy hangtömböt kéne kiküldeni
                        speaker1.AddSound(Pitch.E, volume: 63, length: 200);
                    }
                   
                }
                byte turn = 1;
                string json_source = FormHelper.DevicesToJSON();
                FormHelper.CallSetTurnForEachDevice(ref json_source);
            }
        }
    }
}
