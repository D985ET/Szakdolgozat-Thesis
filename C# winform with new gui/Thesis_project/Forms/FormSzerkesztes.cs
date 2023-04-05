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
          

            //kinézet:
            //this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            //this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Application.EnableVisualStyles();
            LoadTheme();
            dataGridSzerkesztes.Width = Screen.PrimaryScreen.WorkingArea.Width - 970;
            dataGridSzerkesztes.Height = Screen.PrimaryScreen.WorkingArea.Height - 600;
            dataGridSzerkesztes.AllowUserToAddRows = false;
            dataGridSzerkesztes.RowHeadersVisible = false;

            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = string.Format("Eszköz_{0}", i);
                column.HeaderText = string.Format("{0}", FormHelper.Devices[i].GetType().Name);
                column.Resizable = DataGridViewTriState.False;
                dataGridSzerkesztes.Columns.Add(column);
            }
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Height = 100; //magasság
            dataGridSzerkesztes.Rows.Add(newRow);
            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                dataGridSzerkesztes.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridSzerkesztes.Columns[i].Resizable = DataGridViewTriState.False;

            }
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
            /*foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = SzinTema.PrimaryColor;
                    btn.ForeColor = Color.Black; //ezt visszakell rakni majd white-ra
                    btn.FlatAppearance.BorderColor = SzinTema.SecondaryColor;
                }
            }*/
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
                    p.X = p.X + 300;
                }
                p.Y = p.Y + 310;
                p.X = 0;
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


            arrowButton.Width = 500;
            arrowButton.Height = 500;

            arrowButton.BackColor = Color.White;
            arrowButton.Image = Image.FromFile(@"img\right-arrow.png");
            arrowButton.FlatStyle = FlatStyle.Flat;
            arrowButton.FlatAppearance.BorderSize = 0;
           /* DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewButtonCell());
            dataGridSzerkesztes.Rows.Add(newRow);*/
            /*panel1.Controls.Add(arrowButton);
            arrowButton.Click += ArrowButton_Click;*/
        }
        private FormNyilSzerk nyilSzerkForm; //nyil kirakás új form Clickre.
        LEDArrow ledArrow1;
        private void ArrowButton_Click(object sender, EventArgs e)
        {
            /*LEDArrow ledArrow1;
            if (FormHelper.Devices[0] is LEDArrow)
            {
                FormMainMenu formMain = new FormMainMenu();
                ledArrow1 = (LEDArrow)FormHelper.Devices[0];
                nyilSzerkForm = new FormNyilSzerk();
            }*/
            /*FormMainMenu formMain = new FormMainMenu();
            var frm = (FormMainMenu)this.Owner;
            if (frm != null)
            {
                frm.btnSzerkesztes_Click(sender, e);
            }*/

            /*nyilSzerkForm.Show();*/
        }
        Button lampaButton;
        private void lampatKirak(Point location)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));

            lampaButton = new Button();

            lampaButton.Width = 500;
            lampaButton.Height = 500;
            lampaButton.Location = location;
            lampaButton.BackColor = Color.White;
            lampaButton.FlatStyle = FlatStyle.Flat;
            lampaButton.FlatAppearance.BorderSize = 0;
            //lampaButton.Text = "LAMPA";//TODO IMAGE
            lampaButton.Image = Image.FromFile(@"img\lamp.png");

           /* panel1.Controls.Add(lampaButton);
            lampaButton.Click += LampaButton_Click;*/
        }
        FormLampaSzerk lampaSzerkForm;
        LEDLight ledLight1;
        private void LampaButton_Click(object sender, EventArgs e)
        {
            /*LEDLight ledLight1;
            if (FormHelper.Devices[0] is LEDLight)
            {
                FormMainMenu formMain = new FormMainMenu();
                ledLight1 = (LEDLight)FormHelper.Devices[0];
                lampaSzerkForm = new FormLampaSzerk(ref ledLight1, ref lampaButton);
            }
            lampaSzerkForm.Show();*/
        }

        private void hangszoroKirak(Point location)
        {
            Button hangszoroButton = new Button();

            hangszoroButton.Location = location;

            hangszoroButton.Width = 500;
            hangszoroButton.Height = 500;
            /*hangszoroButton.Location = location;*/
            hangszoroButton.Image = Image.FromFile(@"img\speaker-filled-audio-tool.png");
            hangszoroButton.BackColor = Color.White;
            hangszoroButton.FlatStyle = FlatStyle.Flat;
            hangszoroButton.FlatAppearance.BorderSize = 0;
            /*hangszoroButton.Text = "HANGSZORO";//TODO IMA*/
            /*panel1.Controls.Add(hangszoroButton);
            hangszoroButton.Click += hangszoroButton_Click;*/
        }
        FormHangszSzerk hangSzerkForm;
        Speaker speaker1;
        private void hangszoroButton_Click(object sender, EventArgs e)
        {
        //    Speaker speaker1;
        //    for (int i = 0; i < FormHelper.Devices.Count; i++)
        //    {
        //        if (FormHelper.Devices[i] is Speaker)
        //        {
        //            speaker1 = (Speaker)FormHelper.Devices[i];
        //            speaker1.AddSound(Pitch.H_OKTAV3, 63, 300);
        //            hangSzerkForm = new FormHangszSzerk(ref speaker1);
        //            hangSzerkForm.Show();
        //        }
             
        //    }
          
            
     
        }

        private void dataGridSzerkesztes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormLampaSzerk.rowCount = dataGridSzerkesztes.Rows.Count;
            if (dataGridSzerkesztes.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {

                if (FormHelper.Devices[e.ColumnIndex] is LEDLight)
                {
                    //FormMainMenu formMain = new FormMainMenu();
                    ledLight1 = (LEDLight)FormHelper.Devices[e.ColumnIndex];
                    lampaSzerkForm = new FormLampaSzerk(e.RowIndex);
                    lampaSzerkForm.Show();
                }
                if (FormHelper.Devices[e.ColumnIndex] is Speaker)
                {
                    speaker1 = (Speaker)FormHelper.Devices[e.ColumnIndex];
                    hangSzerkForm = new FormHangszSzerk(e.RowIndex);
                    hangSzerkForm.Show();
                }
                if (FormHelper.Devices[e.ColumnIndex] is LEDArrow)
                {
                    ledArrow1 = (LEDArrow)FormHelper.Devices[e.ColumnIndex];
                    nyilSzerkForm = new FormNyilSzerk(e.RowIndex);
                    nyilSzerkForm.Show();
                }
                //IDE KELL A TÖBBI IF 
            }
        }

        private void btnFuttatasSzerk_Click(object sender, EventArgs e)
        {
            
           
        }
    }
}
