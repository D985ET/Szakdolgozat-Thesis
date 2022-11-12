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


            //kétszer kell lefuttatni
            Res.Text = SLFormHelper.FormHelper.CallSLDLL_Open(this.Handle).ToString();
            Res.Text = SLFormHelper.FormHelper.CallSLDLL_Open(this.Handle).ToString(); //Felmérés,

            Res2.Text = SLFormHelper.FormHelper.CallFelmeres().ToString(); //Inicializálás, hány eszköz van bekötve
            
            
            

        }
    



        private void Eszk_feltolt_BTN_Click(object sender, EventArgs e)
        {
           
            Point p = new Point(0, 0);
            bool elsosor = false;
            bool masodiksor = false;
            SLFormHelper.FormHelper.FillDeviceListWithDevices(); //DEV485 Töltése
            SLFormHelper.FormHelper.FillDevices(); //JSON-ös parseolás
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
                if (SLFormHelper.FormHelper.Devices.Count > 9 && elsosor == true)/* SLFormHelper.FormHelper.Devices.Count > 6*/
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
                    else if(p.X == 0 && p.Y == 100)
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

            arrowButton.Width = 45;
            arrowButton.Height = 45;
           
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
           
            lampaButton.Width = 45;
            lampaButton.Height = 45;
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

            hangszoroButton.Width = 45;
            hangszoroButton.Height = 45;
            /*hangszoroButton.Location = location;*/
            hangszoroButton.Image = Image.FromFile(@"img\speaker-filled-audio-tool.png");

            hangszoroButton.FlatStyle = FlatStyle.Flat;
            hangszoroButton.FlatAppearance.BorderSize = 0;
            /*hangszoroButton.Text = "HANGSZORO";//TODO IMA*/
            panel1.Controls.Add(hangszoroButton);
        }
    }
}
