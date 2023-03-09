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
            panel1.AutoScroll = true;
            panel1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            panel1.Height = Screen.PrimaryScreen.WorkingArea.Height;
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
                setDev485(true);
                Gombokat_Kirak();
                Gombokat_Kirak();
                Gombokat_Kirak();
                Gombokat_Kirak();
                Gombokat_Kirak();
              
            }

        }
        Point p = new Point(0,0);
        public void Gombokat_Kirak()
        {

            bool elsosor = true;

            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                Console.WriteLine();
                Console.WriteLine(SLFormHelper.FormHelper.Devices[i].GetType().Name);
                Console.WriteLine(SLFormHelper.FormHelper.Devices[i]);
                Eszközöknevei.Text += SLFormHelper.FormHelper.Devices[i].GetType().Name + "\n";
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
                p.X = p.X + 300; 

            }
            p.Y = p.Y + 300;
            p.X = 0;
           
              
            /*lampAktSzin.Text = ((LEDLight)FormHelper.Devices[0]).Color.ToString();*/
            EszkozokdbTxt.Text = SLFormHelper.FormHelper.Devices.Count.ToString() + " db"; //hány db eszköz van

        }


        //buttonok kirakása attól függően hogy mik.

        bool belelepettVMelyikbe = false;


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


            arrowButton.Width = 300; //panel1.Width / 4
            arrowButton.Height = 300;

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
            belelepettVMelyikbe = true;
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
           
            lampaButton.Width = 300;
            lampaButton.Height =300;
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
            belelepettVMelyikbe = true;
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

            hangszoroButton.Width = 300;
            hangszoroButton.Height = 300;
            /*hangszoroButton.Location = location;*/
            hangszoroButton.Image = Image.FromFile(@"img\speaker-filled-audio-tool.png");
            hangszoroButton.BackColor= Color.White;
            hangszoroButton.FlatStyle = FlatStyle.Flat;
            hangszoroButton.FlatAppearance.BorderSize = 0;
            /*hangszoroButton.Text = "HANGSZORO";//TODO IMA*/
            panel1.Controls.Add(hangszoroButton);
            hangszoroButton.Click += hangszoroButton_Click;
        }
        FormHangszSzerk hangSzerkForm;
        private void hangszoroButton_Click(object sender, EventArgs e)
        {
            belelepettVMelyikbe = true;
            Speaker speaker1;
            for (int i = 0; i < FormHelper.Devices.Count; i++)
            {
                if (FormHelper.Devices[i] is Speaker)
                {
                    speaker1 = (Speaker)FormHelper.Devices[i];
                    speaker1.AddSound(Pitch.H_OKTAV3, 63, 300);
                    hangSzerkForm = new FormHangszSzerk(ref speaker1);
                    hangSzerkForm.Show();
                }

            }
        }

        int i = 0;
        private void btnFuttatas_Click(object sender, EventArgs e)
        {
            btnFuttatas.Enabled = false;
            utemTimer.Enabled = true;
            utemTimer.Interval = (int)nUPTimer.Value;
            
        }

        private void utemTimer_Tick(object sender, EventArgs e)
        {
            if (i == 2) //kilépési feltétel, két ütem fut le.
            {
                i = 0; //reset
                btnFuttatas.Enabled = true;
                utemTimer.Enabled = false;
            }
            i++;
        }



        //hangszóró
        /* private void hangszOn_Click(object sender, EventArgs e)
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
         }*/










    }
}
