using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLFormHelper;

namespace Thesis_project.Forms
{
    public partial class FormInditas : Form
    {

        bool dev485Set = false;
        public FormInditas()
        {
            InitializeComponent();
            LoadTheme();
        }
        //ez az összes formba megy majd
       
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
            
            if(dev485Set == false)
            {
               Res.Text = FormHelper.CallFelmeres().ToString();
              
                dev485Set = true;
                Gombokat_Kirak();
            }

        }
        private void Gombokat_Kirak()
        {

            Point p = new Point(0, 0);
            bool elsosor = false;

            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                Console.WriteLine();
                Console.WriteLine(SLFormHelper.FormHelper.Devices[i].GetType().Name);
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
            EszkozokdbTxt.Text = SLFormHelper.FormHelper.Devices.Count.ToString() + " db"; //hány db eszköz van

        }
        
   
        private void nyilatKirak(Point location)
        {

            Button arrowButton = new Button();

            
            arrowButton.Location = location;

            arrowButton.Width = 100;
            arrowButton.Height = 100;
           
            arrowButton.BackColor = Color.White;
            arrowButton.Image = Image.FromFile(@"img\right-arrow.png");
            arrowButton.FlatStyle = FlatStyle.Flat;
            arrowButton.FlatAppearance.BorderSize = 0;
     

            panel1.Controls.Add(arrowButton);
        }
        private void lampatKirak(Point location)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));

            Button lampaButton = new Button();
           
            lampaButton.Width = 100;
            lampaButton.Height = 100;
            lampaButton.Location = location;
            lampaButton.BackColor = Color.White;
            lampaButton.FlatStyle = FlatStyle.Flat;
            lampaButton.FlatAppearance.BorderSize = 0;
            //lampaButton.Text = "LAMPA";//TODO IMAGE
            lampaButton.Image = Image.FromFile(@"img\lamp.png");
           
            panel1.Controls.Add(lampaButton);
        }

        private void hangszoroKirak(Point location)
        {
            Button hangszoroButton = new Button();
          
            hangszoroButton.Location = location;

            hangszoroButton.Width = 100;
            hangszoroButton.Height = 100;
            /*hangszoroButton.Location = location;*/
            hangszoroButton.Image = Image.FromFile(@"img\speaker-filled-audio-tool.png");

            hangszoroButton.FlatStyle = FlatStyle.Flat;
            hangszoroButton.FlatAppearance.BorderSize = 0;
            /*hangszoroButton.Text = "HANGSZORO";//TODO IMA*/
            panel1.Controls.Add(hangszoroButton);
        }

        private void button1_Click(object sender, EventArgs e)
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

            FormHelper.CallSetTurnForEachDevice(ref turn, ref json_source);
        }

        private void nyilUres_Click(object sender, EventArgs e)
        {
            LEDArrow ledArrow1 = (LEDArrow)FormHelper.Devices[0];
            ledArrow1.Color = Color.Black;
            ledArrow1.Direction = Direction.BOTH;

            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref turn, ref json_source);
        }

        private void hangszOn_Click(object sender, EventArgs e)
        {
            Speaker speaker1 = (Speaker)FormHelper.Devices[0];
            Speaker newSpeaker = new Speaker(speaker1.Azonos, 20, 20, 10000);
            FormHelper.Devices[0] = newSpeaker;
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref turn, ref json_source);
        }

        private void hangszOff_Click(object sender, EventArgs e)
        {
            Speaker speaker1 = (Speaker)FormHelper.Devices[0];
            Speaker newSpeaker = new Speaker(speaker1.Azonos, 0, 0, 0);
            FormHelper.Devices[0] = newSpeaker;
            byte turn = 1;
            string json_source = FormHelper.DevicesToJSON();

            FormHelper.CallSetTurnForEachDevice(ref turn, ref json_source);
        }
    }
}
