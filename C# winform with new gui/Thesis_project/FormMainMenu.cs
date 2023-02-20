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
     


        //CTOR
        public FormMainMenu()
        {
            InitializeComponent();
            vsz = new Random();
            btnCloseChildForm.Visible = false;
            //kinézet:
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            Application.EnableVisualStyles();
            byte dbDev = (byte)(SLFormHelper.FormHelper.Devices.Count()+1);
            eszlelteszkLbl.Text += ": " + dbDev.ToString() + " db";

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
                while (tempIndex == index)
                {
                    index = vsz.Next(SzinTema.getColorList().Count);
                }
                tempIndex = index;
                color = SzinTema.getColorList()[index];
                /*color = SzinTema.ColorList[index];*/
            }
            catch(Exception e)
            {
                throw new Exception("A color nem lehet null vagy üres! ",e);
               
            }
            
            return ColorTranslator.FromHtml(color);
            
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
                        panelLogo.BackColor = SzinTema.ChangeColorBrightness(color, -0.3f); //
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
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
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
                Console.WriteLine("Openchildform cucos");
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
        private int drb485;
        private bool dev485Set = false;
        /// <summary>
        /// Ez lényegében a Delphi-ből érkező uzfeld-metódus C#-os változata
        /// Feldolgozza a Win32-es üzeneteket a Form és a rendszer/DLL között.
        /// </summary>
        /// <param name="msg">A feldolgozandó Win32-szabványnak megfelelő üzenet.</param>
        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == 0x0400)
            {
                int responseCode = msg.WParam.ToInt32();
                if (responseCode != 0)
                    switch (responseCode)
                    {
                        //-------Pozitív válaszkódok (tájékoztatások) esetei--------
                        case FELMOK:
                            this.DRB485 = (int)msg.LParam;
                            if (!dev485Set)
                            {
                             
                                FormHelper.CallListelem(ref drb485,true);
                                dev485Set = true;
                                
                            }
                            break;
                        //itt van egy while/for-ciklus, de egyébként nem csinál semmit
                        case AZOOKE: break;
                        //megváltoztattam az eszköz számát, akkor jön ez a válasz  
                        case LEDRGB: break;
                        //ledbea(PELVSTA(Msg.LParam) ^); - relayelni
                        case NYIRGB: break;
                        //nyilbe(PELVSTA(Msg.LParam)^); - relayelni
                        case HANGEL: break;
                        //hanbea(PELVSTA(Msg.LParam)^); - relayelni - elég a Msg.LPARAM-ot átadni mindhárom esetben - egész szám értékként kell átadni
                        case STATKV: break;
                        //itt kapom vissza az értéket
                        case LISVAL: break; //A lista_hívás adja vissza message-ben
                                            //-------Negatív válaszkódok (hibakódok) esetei--------
                        case USBREM: break;
                        // Az USB vezérlő eltávolításra került
                        case VALTIO: break;
                        // Válaszvárás time-out következett be
                        case FELMHK: break;
                        // Felmérés vége hibával
                        //s := Format(ENDHIK, [Msg.LParam]);
                        case FELMHD: break;
                        // Nincs egy darab sem hibakód (elvben sem lehet ilyen)
                        //s := DARSEM;
                        case FELMDE: break;
                        // A 16 és 64 bites darabszám nem egyforma
                        //s := DARELT;
                        default:
                            break;
                    }
            }
            base.WndProc(ref msg);
        }

        //////////////////////////////////////////////////////////////////////////////////////
        //  A DLL használatának megkezdése után az ott megadott üzenetszámra küldött        //
        //  üzenetekkel tartja a kapcsolatot a hívóval. Az üzenet (Message) WParam értéke   //
        //  tartalmazza az üzenet kódját. Ez vagy nagyobb vagy kisebb mint nulla.           //
        //  A negatív érték hibaüzenetet jelent, míg a pozitív az elvégzett művelet         //
        //  végrehajtásáról ad tájékoztatást. Ha az üzenethez tartozik paraméter, adat,     //
        //  akkor arra az üzenet LParam értéke hivatkozik.                                  //
        //////////////////////////////////////////////////////////////////////////////////////
        // Válaszkódok
        private const byte FELMOK = 1;                              // A felmérés rendben lezajlott
        private const byte AZOOKE = 2;                              // Az azonosító váltás rendben lezajlott
                                                                    //private const byte FIRMUZ  = 3;                              // Förmvercsere információs kódja
                                                                    //private const byte FIRMEN  = 4;                              // Förmvercsere vége, újraindítás elndul
        private const byte LEDRGB = 5;                              // A LED lámpa RGB értéke
        private const byte NYIRGB = 6;                              // A nyíl RGB és irány értéke
        private const byte HANGEL = 7;                              // A hangstring állapota
        private const byte STATKV = 8;                              // A státusz értéke
        private const byte LISVAL = 9;                              // A táblázat végének a válasza
                                                                    //Negatív érték 
        private const sbyte USBREM = -1;                             // Az USB vezérlő eltávolításra került
        private const sbyte VALTIO = -2;                             // Felmérés közben válaszvárás time-out következett be
        private const sbyte FELMHK = -3;                             // Felmérés vége hibával
        private const sbyte FELMHD = -4;                             // Nincs egy darab sem hibakód (elvben sem lehet ilyen)
        private const sbyte FELMDE = -5;                             // A 16 és 64 bites darabszám nem egyforma (elvben sem lehet ilyen)

        public int DRB485
        {
            get
            {
                return this.drb485;
            }
            set
            {
                if (value < 0)
                    throw new ArgumentOutOfRangeException("Az eszközök darabszáma nem lehet negatív!");
                drb485 = value;
            }
        }

        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            if (!dev485Set)
            {
                FormHelper.CallOpen(this.Handle);
            }
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
