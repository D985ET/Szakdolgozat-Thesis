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
        private byte felmereslefutctr = 0;
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

            if (felmereslefutctr == 0 )
            {
                Res.Text = SLFormHelper.FormHelper.CallSLDLL_Open(this.Handle).ToString();
                Res.Text = SLFormHelper.FormHelper.CallSLDLL_Open(this.Handle).ToString(); //Felmérés,
                Res2.Text = SLFormHelper.FormHelper.CallFelmeres().ToString(); //Inicializálás, hány eszköz van bekötve
                felmereslefutctr += 1;
            }
            

        }
    



        private void Eszk_feltolt_BTN_Click(object sender, EventArgs e)
        {
           
            Point p = new Point(0, 0);
            SLFormHelper.FormHelper.FillDeviceListWithDevices(); //DEV485 Töltése
            SLFormHelper.FormHelper.FillDevices(); //JSON-ös parseolás
            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++)
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
                p.X = p.X + 100;

            }
            EszkozokdbTxt.Text += SLFormHelper.FormHelper.Devices.Count.ToString() + " db"; //hány db eszköz van
                felmereslefutctr += 1;
               
            
        }
        private void nyilatKirak(Point location)
        {
            Button arrowButton = new Button();
            arrowButton.Width = 50;
            arrowButton.Location = location;
            //arrowButton.Text = "->";//TODO IMAGE

            panel1.Controls.Add(arrowButton);
        }
        private void lampatKirak(Point location)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));

            Button lampaButton = new Button();
            lampaButton.Width = 50;
            lampaButton.Location = location;
            //lampaButton.Text = "LAMPA";//TODO IMAGE
            lampaButton.Image = Image.FromFile(@"img\lamp.png");
            panel1.Controls.Add(lampaButton);
        }
        private void hangszoroKirak(Point location)
        {
            Button hangszoroButton = new Button();
            hangszoroButton.Width = 50;
            hangszoroButton.Location = location;
            hangszoroButton.Text = "HANGSZORO";//TODO IMAGE
            panel1.Controls.Add(hangszoroButton);
        }
    }
}
