using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SLFormHelper;
using Thesis_project.Forms;
using Thesis_project.Forms.EszkozSzerk;

namespace Thesis_project
{
    public partial class FormMainMenu : Form
    {
        private Button currentButton;
        private Random vsz;
        private int tempIndex;
        private Form activeForm;
        private static bool open = false;


        //CTOR
        public FormMainMenu()
        {
            InitializeComponent();
            vsz = new Random();
            btnCloseChildForm.Visible = false;
            //kinézet:
          /*  this.Size = Screen.PrimaryScreen.WorkingArea.Size;*/
            this.WindowState = FormWindowState.Normal;
            //ne lehessen állítani a size-t
            Application.EnableVisualStyles();
            panelBeallitas();
          


            if (open == false)
            {
                FormHelper.CallOpen(this.Handle);
                open = true;
            }
            
            this.Text = string.Empty; //a border teteje ne adjon semmi szöveget
            this.ControlBox = false;
            //így már lehet oldalra kitenni
           // this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        //DRAG 
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        //Methods
        public void panelBeallitas()
        {
            panelDesktopPanel.Controls.Add(HangszPanel);
       
            panelDesktopPanel.Controls.Add(nyilPanel);
            panelDesktopPanel.Controls.Add(lampaPanel);
            panelDesktopPanel.Controls.Add(funkciokPanel);
            panelDesktopPanel.Controls.Add(leirasPanel);
            panelDesktopPanel.Controls.Add(funkciokCimP);
            panelDesktopPanel.Controls.Add(funkcLeirCim);
            //hangszoró:
            Label hangszoroCimLbl = new Label();
            Label hangszoroLbl = new Label();
            hangszoroCimLbl.Text = "A hangszóró eszköz beállításai: ";
            hangszoroCimLbl.Dock = DockStyle.Top;
            hangszoroCimLbl.AutoSize = false;
            hangszoroCimLbl.TextAlign = ContentAlignment.MiddleCenter;
            hangszoroCimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hangszoroLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hangszoroLbl.Text = "\n-  hangerő (Állandó hangerő), \n-  hangszín (Hangskálán lévő összes hangszin)  \n-  hanghossz (Másodpercben)";
            hangszoroLbl.Dock = DockStyle.Fill;
            hangszoroLbl.AutoSize = false;
            hangszoroLbl.TextAlign = ContentAlignment.MiddleCenter;
            HangszPanel.Controls.Add(hangszoroCimLbl);
            HangszPanel.Controls.Add(hangszoroLbl);
            HangszPanel.BorderStyle = BorderStyle.FixedSingle;
            nyilPanel.BorderStyle = BorderStyle.FixedSingle;
            lampaPanel.BorderStyle = BorderStyle.FixedSingle;
            //nyíl
            Label nyilCimLbl = new Label();
            Label nyilLbl = new Label();
            nyilCimLbl.Text = "A nyíl eszköz beállításai: ";
            nyilCimLbl.Dock = DockStyle.Top;
            nyilCimLbl.AutoSize = false;
            nyilCimLbl.TextAlign = ContentAlignment.MiddleCenter;
            nyilCimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nyilLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nyilLbl.Text = "\n-  nyíl iránya (balra/jobbra/balra-jobbra), \n- szín (Színpalettán lévő színekkel)";
            nyilLbl.Dock = DockStyle.Fill;
            nyilLbl.AutoSize = false;
            nyilLbl.TextAlign = ContentAlignment.MiddleCenter;
            nyilPanel.Controls.Add(nyilCimLbl);
            nyilPanel.Controls.Add(nyilLbl);


            //lampa
            Label lampaCimLbl = new Label();
            Label lampaLbl = new Label();
            lampaCimLbl.Text = "A lámpa eszköz beállításai: ";
            lampaCimLbl.Dock = DockStyle.Top;
            lampaCimLbl.AutoSize = false;
            lampaCimLbl.TextAlign = ContentAlignment.MiddleCenter;
            lampaCimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lampaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lampaLbl.Text = "\n- szín (Színpalettán lévő színekkel)";
            lampaLbl.Dock = DockStyle.Fill;
            lampaLbl.AutoSize = false;
            lampaLbl.TextAlign = ContentAlignment.MiddleCenter;
            lampaPanel.Controls.Add(lampaCimLbl);
            lampaPanel.Controls.Add(lampaLbl);

            //funkciók címe:
            Label funkciokLbl = new Label();
            funkciokLbl.Text = "Indítás: \n" +
                "Ütemsor Mentés:  \n" +
                "Ütemsor Betöltése:  \n" +
                "Eszközök Tesztelése:  \n" +
                "Kilépés:";
            funkciokLbl.Dock = DockStyle.Fill;
            funkciokLbl.AutoSize = false;
            funkciokLbl.TextAlign = ContentAlignment.MiddleCenter;
            funkciokLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
           
            funkciokPanel.Controls.Add(funkciokLbl);
            //funkciok leírasa:
            Label funkciokLeirasLbl = new Label();
            funkciokLeirasLbl.Text = "1 vagy több eszköz együttes beállítása, ütemidők szerint.\n" +
                "Adott eszközök beállításainak elmentése külön fájlba, ütemidővel együtt. \n" +
                "Adott eszközök beállításainak betöltése külső fájlból. (JSON formátum) \n" +
                "Egyénileg tesztelhető a különféle eszközök megfelelő működése. \n" +
                "A projekt bezárása.";
            funkciokLeirasLbl.Dock = DockStyle.Fill;
            funkciokLeirasLbl.AutoSize = false;
            funkciokLeirasLbl.TextAlign = ContentAlignment.MiddleLeft;
            funkciokLeirasLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          
            leirasPanel.Controls.Add(funkciokLeirasLbl);
            //funkciók cím:
            Label funkciokCimLbl = new Label();
            funkciokCimLbl.Text = "Ablakok:";
            funkciokCimLbl.Dock = DockStyle.Fill;
            funkciokCimLbl.AutoSize = false;
            funkciokCimLbl.TextAlign = ContentAlignment.BottomCenter;
            funkciokCimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            funkciokCimP.Controls.Add(funkciokCimLbl);
            //funkciok leirasa cim:
            Label funkciokLeirasCimLbl = new Label();
            funkciokLeirasCimLbl.Text = "Ablakok részletesebb leírása:";
            funkciokLeirasCimLbl.Dock = DockStyle.Fill;
            funkciokLeirasCimLbl.AutoSize = false;
            funkciokLeirasCimLbl.TextAlign = ContentAlignment.BottomLeft;
            funkciokLeirasCimLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.0F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));

            funkcLeirCim.Controls.Add(funkciokLeirasCimLbl);
            //Border:
            funkciokCimP.BorderStyle = BorderStyle.FixedSingle;
            funkciokLeirasCimLbl.BorderStyle = BorderStyle.FixedSingle;
            HangszPanel.BorderStyle = BorderStyle.FixedSingle;
            nyilPanel.BorderStyle = BorderStyle.FixedSingle;
            lampaPanel.BorderStyle = BorderStyle.FixedSingle;

        }
        public Color SelectThemeColor()
        {
            string color;
            try
            {
               
                int index = vsz.Next(SzinTema.getColorList().Count);
                while (tempIndex == index) //amíg egyenlő addig randomoljuk, ez azért kell hogy mindig más színt kapjunk, mert ha az előző szín megegyezik akkor nem jó
                {
                    index = vsz.Next(SzinTema.getColorList().Count);
                }
                tempIndex = index;//elmentjük a tempindex-be, és így nem kapjuk meg az előző értéket
                color = SzinTema.getColorList()[index];
                /*color = SzinTema.ColorList[index];*/
            }
            catch(Exception e)
            {
                throw new Exception("A color nem lehet null vagy üres! ",e);
               
            }
            
            return ColorTranslator.FromHtml(color); //"#0000ff" -> [A=255, R=0, G=0, B=255]

        }
        public void ActivateButton(object btnSender)
        {
            try
            {
                if (btnSender != null)
                {
                    if (currentButton != (Button)btnSender)
                    {
                        DisableButton();
                        Color color = SelectThemeColor();
                        currentButton = (Button)btnSender;
                        currentButton.BackColor = color;
                        currentButton.ForeColor = Color.White;
                        currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        panelTitleBar.BackColor = color;
                        panelLogo.BackColor = SzinTema.ChangeColorBrightness(color, -0.3f); 
                        SzinTema.PrimaryColor = color;
                        SzinTema.SecondaryColor = SzinTema.ChangeColorBrightness(color, -0.3f);
                        btnCloseChildForm.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("A btn értéke null!",ex);
            }
         
        }
        private void DisableButton()
        {
            foreach (Control previousBtn in panelMenu.Controls) //amikor rákattintok a buttonra beszínezi olyannal ami éppen a témaszíne,
            {                                                  
                if (previousBtn.GetType() == typeof(Button)) //és miután másikra kattintok el is tűnik ilyenkor kell eltűntetni a másik buttonrol
                {
                    
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        public void OpenSubForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            try
            {
                ActivateButton(btnSender);
                activeForm = childForm;
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
            }
            catch(Exception ex) 
            {
                throw new Exception("A form vagy a btn nem megfelelő!",ex);
            }
            this.panelDesktopPanel.Controls.Add(childForm);
            this.panelDesktopPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
           

        }
         private void Reset()
        {
            DisableButton();
            lblTitle.Text = "Kezdőlap";
            panelTitleBar.BackColor = Color.DodgerBlue;
            panelLogo.BackColor = Color.FromArgb(39, 39, 60);
            currentButton = null;
            btnCloseChildForm.Visible = false;
        }

        FormInditas formInditas;
        private void btnInditas_Click(object sender, EventArgs e)
        {
            if (formInditas == null)
            {
                formInditas = new Forms.FormInditas();
            }
            OpenSubForm(formInditas, sender);
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            OpenSubForm(new Forms.FormMentes(formInditas), sender);
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            if(formInditas == null)
            {
                formInditas = new Forms.FormInditas();
            }
            OpenSubForm(new Forms.FormBetoltes(formInditas), sender);
        }
    
        public void btnSzerkesztes_Click(object sender, EventArgs e)
        {
            OpenSubForm(new Forms.FormSzerkesztes(), sender);

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            Reset();
        }
       


        //BENCE DLL-ből
        protected override void WndProc(ref Message msg)
        {
            FormHelper.CallWndProc(ref msg);
            base.WndProc(ref msg);
        }


        //DRAG
        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCloseTop_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizeTop_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
            else
            {
                this.Size = this.MinimumSize;
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btnMinimizeTop_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

    
    }
}
