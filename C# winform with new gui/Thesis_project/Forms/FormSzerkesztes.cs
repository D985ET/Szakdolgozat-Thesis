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
using Thesis_project.Forms.EszkozSzerk;

namespace Thesis_project.Forms
{
    public partial class FormSzerkesztes : Form
    {
        private Button currentButton;
        private Random vsz;
        private int tempIndex;
        private Form activeForm;
        bool dev485Set;

        public FormSzerkesztes()
        {
            InitializeComponent();
            LoadTheme();

            //kinézet:
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            Application.EnableVisualStyles();
        }
        public void setDev485(bool dev485Set)
        {

            this.dev485Set = dev485Set;
        }
        public bool getDev485()
        {
            return this.dev485Set;
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
            if (dev485Set == false)
            {
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
        }
        public void nyilatKirak(Point location)
        {

            Button arrowButton = new Button();

            try
            {
                if (location.X < 0 || location.Y < 0)
                {
                    throw new Exception("A paraméterben kapott érték nem megfelelő");
                }
                arrowButton.Location = location;
            }
            catch (Exception e)
            {

                throw new Exception("A paraméterben kapott érték nem megfelelő", e);
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

    }
}
