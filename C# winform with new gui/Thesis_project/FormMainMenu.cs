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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            //ne lehessen állítani a size-t
            Application.EnableVisualStyles();
            
           
            if(open == false)
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

        public void OpenChildForm(Form childForm, object btnSender)
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


        private void btnInditas_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormInditas(),sender);
        }

        private void btnMentes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMentes(), sender);
        }

        private void btnBetoltes_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormBetoltes(), sender);
        }
    
        public void btnSzerkesztes_Click(object sender, EventArgs e)
        {
            //Ha nem sikerül a több eszközös
            /*if (FormHelper.Devices[0] is LEDArrow)
            {
                LEDArrow ledArrow1;
                FormNyilSzerk nyilSzerkForm; //ny
                ledArrow1 = (LEDArrow)FormHelper.Devices[0];
                nyilSzerkForm = new FormNyilSzerk(ref ledArrow1);
                OpenChildForm(new Forms.FormNyilSzerk(ref ledArrow1), sender);
            }
            if (FormHelper.Devices[0] is LEDLight)
            {
                LEDLight ledLight1;
                FormLampaSzerk lampaSzerkForm; //ny
                ledLight1 = (LEDLight)FormHelper.Devices[0];
                lampaSzerkForm = new FormLampaSzerk(ref ledLight1);
                OpenChildForm(new Forms.FormLampaSzerk(ref ledLight1), sender);
            }
            if (FormHelper.Devices[0] is Speaker)
            {
                Speaker speaker1;
                FormHangszSzerk hangSzerkForm;
                speaker1 = (Speaker)FormHelper.Devices[0];
                hangSzerkForm = new FormHangszSzerk(ref speaker1);
                OpenChildForm(new Forms.EszkozSzerk.FormHangszSzerk(ref speaker1), sender);
            }*/
        
            OpenChildForm(new Forms.FormSzerkesztes(), sender);

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
        private void Reset()
        {
            DisableButton();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.DodgerBlue;
            panelLogo.BackColor = Color.FromArgb(39, 39, 60);
            currentButton = null;
            btnCloseChildForm.Visible = false;
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
