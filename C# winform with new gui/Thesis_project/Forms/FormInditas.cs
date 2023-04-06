using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Newtonsoft.Json;
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
            /* this.WindowState = FormWindowState.Maximized;*/
            this.WindowState = FormWindowState.Normal;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            Application.EnableVisualStyles();
            LoadTheme();
            dataGridInditas.Width = Screen.PrimaryScreen.WorkingArea.Width-970;
            dataGridInditas.Height = Screen.PrimaryScreen.WorkingArea.Height-600;
            dataGridInditas.AllowUserToAddRows = false;
            dataGridInditas.RowHeadersVisible = false;

            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                DataGridViewButtonColumn column = new DataGridViewButtonColumn();
                column.Name = string.Format("Eszköz_{0}", i);
                column.HeaderText = string.Format("{0}", FormHelper.Devices[i].GetType().Name);
                column.Resizable = DataGridViewTriState.False;
               
                dataGridInditas.Columns.Add(column);
            }
          
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Height = 100; //magasság

            dataGridInditas.Rows.Add(newRow);
            
            

            for (int i = 0; i < SLFormHelper.FormHelper.Devices.Count; i++) //megszámolja mennyi Device van.
            {
                dataGridInditas.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                dataGridInditas.Columns[i].Resizable = DataGridViewTriState.False;
                dataGridInditas.Columns[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                dataGridInditas.Columns[i].DefaultCellStyle.BackColor = Color.Red;
            }



            /* panel1.AutoScroll = true;
             panel1.Width = Screen.PrimaryScreen.WorkingArea.Width;
             panel1.Height = Screen.PrimaryScreen.WorkingArea.Height;*/
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
           
              
            /*lampAktSzin.Text = ((LEDLight)FormHelper.Devices[0]).Color.ToString();*/
            EszkozokdbTxt.Text = SLFormHelper.FormHelper.Devices.Count.ToString() + " db"; //hány db eszköz van

        }


        //buttonok kirakása attól függően hogy mik.



        public void nyilatKirak(Point location)
        {

           /* Button arrowButton = new Button();

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

            DataGridViewRow newRow = new DataGridViewRow();*/
            //DataGridViewButtonColumn datagridcolum = new DataGridViewButtonColumn();
            //datagridcolum.Resizable = DataGridViewTriState.False;
          /*  newRow.Cells.Add(new DataGridViewButtonCell());
            dataGridInditas.Rows.Add(newRow);*/
            
            /* panel1.Controls.Add(arrowButton);*/

        }
        private FormNyilSzerk nyilSzerkForm; //nyil kirakás új form Clickre
        LEDArrow ledArrow1;
        private void ArrowButton_Click(object sender, EventArgs e)
        {
           
            
            //for (int i = 0; i < FormHelper.Devices.Count; i++)
            //{
            //    if (FormHelper.Devices[i] is LEDArrow)
            //    {
            //        FormMainMenu formMain = new FormMainMenu();
            //        ledArrow1 = (LEDArrow)FormHelper.Devices[i];
            //        nyilSzerkForm = new FormNyilSzerk(ref ledArrow1);
            //        nyilSzerkForm.Show();
            //    }
            //}

            /*
            if (FormHelper.Devices[0] is LEDArrow)
            {
                FormMainMenu formMain = new FormMainMenu();
                ledArrow1 = (LEDArrow)FormHelper.Devices[i];
                nyilSzerkForm = new FormNyilSzerk(ref ledArrow1);
            }*/
               

            }



        Button lampaButton;
        
        private void lampatKirak(Point location)
        {
           /* System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            
            lampaButton = new Button();
           
            lampaButton.Width = 300;
            lampaButton.Height = 300;
            lampaButton.Location = location;
            lampaButton.BackColor = Color.White;
            lampaButton.FlatStyle = FlatStyle.Flat;
            lampaButton.FlatAppearance.BorderSize = 0;*/
           /* lampaButton.Tag = newUtemCounter;*/
            
            //lampaButton.Text = "LAMPA";//TODO IMAGE
           /* lampaButton.Image = Image.FromFile(@"img\lamp.png");*/
            /*dataGridInditas.Controls.Add(lampaButton);*/

            /*DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewButtonCell());
            //dataGridInditas.Rows[dataGridInditas.Rows.Count - 1].Cells.Add(new DataGridViewButtonCell());
            dataGridInditas.Rows.Add(newRow);*/

            /* panel1.Controls.Add(lampaButton);*/
            /*lampaButton.Click += LampaButton_Click;*/
        }
        FormLampaSzerk lampaSzerkForm;
        LEDLight ledLight1;
        private void LampaButton_Click(object sender, DataGridViewCellEventArgs e)
        {
            //belelepettVMelyikbe = true;
            //if (dataGridInditas.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            //{
            //    for (int i = 0; i < FormHelper.Devices.Count; i++)
            //    {
            //        if (FormHelper.Devices[i] is LEDLight)
            //        {
            //            FormMainMenu formMain = new FormMainMenu();
            //            ledLight1 = (LEDLight)FormHelper.Devices[i];
            //            lampaSzerkForm = new FormLampaSzerk(ref ledLight1, ref lampaButton);
            //            lampaSzerkForm.Show();
            //        }
            //    }
            //}
         
            
        }



        private void hangszoroKirak(Point location)
        {
            /*Button hangszoroButton = new Button();
          
            hangszoroButton.Location = location;

            hangszoroButton.Width = 300;
            hangszoroButton.Height = 300;*/
            /*hangszoroButton.Location = location;*/
            /*hangszoroButton.Image = Image.FromFile(@"img\speaker-filled-audio-tool.png");
            hangszoroButton.BackColor= Color.White;
            hangszoroButton.FlatStyle = FlatStyle.Flat;
            hangszoroButton.FlatAppearance.BorderSize = 0;*/
            /*hangszoroButton.Text = "HANGSZORO";//TODO IMA*/

           /* DataGridViewRow newRow = new DataGridViewRow();
            newRow.Cells.Add(new DataGridViewButtonCell());
            dataGridInditas.Rows.Add(newRow);*/
            //dataGridInditas.Rows[dataGridInditas.Rows.Count - 1].Cells.Add(new DataGridViewButtonCell());
            /*panel1.Controls.Add(hangszoroButton); //itt adom hozzá a panelt*/
            //hangszoroButton.Click += hangszoroButton_Click;
        }
        FormHangszSzerk hangSzerkForm;
        Speaker speaker1;
        private void hangszoroButton_Click(object sender, EventArgs e)
        {
            
            //for (int i = 0; i < FormHelper.Devices.Count; i++)
            //{
            //    if (FormHelper.Devices[i] is Speaker)
            //    {
            //        speaker1 = (Speaker)FormHelper.Devices[i];
            //        speaker1.AddSound(Pitch.H_OKTAV3, 63, 300);
            //        hangSzerkForm = new FormHangszSzerk(ref speaker1);
            //        hangSzerkForm.Show();
            //    }

            //}
        }
        

        int i = 0;
        private void btnFuttatas_Click(object sender, EventArgs e)
        {
            btnFuttatas.Enabled = false;
            utemTimer.Enabled = true;
            utemTimer.Interval = (int)(nUPTimer.Value*1000);
            for (int i = 0; i < FormLampaSzerk.colors.Length; i++)
            {
                Console.WriteLine(FormLampaSzerk.colors[i]);

            }
           



            //ez futtatja le a színt és a directiont
        }

        private void utemTimer_Tick(object sender, EventArgs e)
        {
            if (i == dataGridInditas.Rows.Count) //kilépési feltétel, két ütem fut le.
            {
                i = 0; //reset
                btnFuttatas.Enabled = true;
                utemTimer.Enabled = false;
                return;
            }
            if (ledLight1 != null)
            {
                ledLight1.Color = FormLampaSzerk.colors[i];
            }
            if(ledArrow1 != null)
            {
                ledArrow1.Color = FormNyilSzerk.colors[i];
                ledArrow1.Direction = FormNyilSzerk.directions[i];
            }
            if (speaker1 != null)
            {
                speaker1.AddSound(FormHangszSzerk.pitch[i], 63, FormHangszSzerk.timeMilisec[i]);
            }
           
        
            /*ledLight1.Color = FormLampaSzerk.colors[i];*/

            string json_source = FormHelper.DevicesToJSON();//átalakítja az ezsközbeállításokat JSON-é
            FormHelper.CallSetTurnForEachDevice(ref json_source);//ez futtatja le a színt
            if (speaker1 != null)
            {
                speaker1.ClearSounds();
            }
            i++;
        }
        public void jsonBeMentes(string jsonPathToFile)
        {
            SerializedTurnSettings[] turnSettings = new SerializedTurnSettings[dataGridInditas.Rows.Count];
           
            for (int j = 0; j < dataGridInditas.Rows.Count; j++)
            {
                if (ledLight1 != null)
                {
                    ledLight1.Color = FormLampaSzerk.colors[j];
                }
                if (ledArrow1 != null)
                {
                    ledArrow1.Color = FormNyilSzerk.colors[j];
                    ledArrow1.Direction = FormNyilSzerk.directions[j];
                }
                if (speaker1 != null)
                {
                    speaker1.ClearSounds();
                    speaker1.AddSound(FormHangszSzerk.pitch[j], 63, FormHangszSzerk.timeMilisec[j]);
                }

                //Beállítások.
               
                turnSettings[j] = new SerializedTurnSettings(devices: new SerializedDeviceSettings[FormHelper.Devices.Count],time: (ushort)(nUPTimer.Value * 1000));
                for (int i = 0; i < FormHelper.Devices.Count; i++)
                {
                    turnSettings[j].Devices[i] = new SerializedDeviceSettings(FormHelper.Devices[i].GetJSONType(), FormHelper.Devices[i].GetJSONSettings());
                }
                /*FormHelper.UnloadDeviceSettings((ushort)(nUPTimer.Value * 1000), jsonPathToFile);*/
                //Elmenti
                
            }
          
            File.WriteAllText(jsonPathToFile,JsonConvert.SerializeObject(turnSettings, Newtonsoft.Json.Formatting.Indented));
        }
        public void jsonBolBetoltes(string jsonPathToFile)
        { 
            dataGridInditas.Rows.Clear();
            SerializedTurnSettings[] turnSettings;
            turnSettings = FormHelper.LoadDeviceSettings(jsonPathToFile, out ushort time);
            nUPTimer.Value = time / 1000;
            for (int i = 0; i < turnSettings.Length; i++)
            {

                for (int j = 0; j < FormHelper.Devices.Count; j++)
                {
                    //FormHelper.Devices[i].LoadDeviceSettings(turnSettings[j].Devices[i].Settings.Split('|'));
                    if (turnSettings[i].Devices[j] != null && turnSettings[i].Devices[j].Type == 'L')
                    {
                        FormLampaSzerk.colors[i] = ((LEDLight)(FormHelper.Devices[j])).Color;
                    }
                    if (turnSettings[i].Devices[j] != null && turnSettings[i].Devices[j].Type == 'N')
                    {
                        FormNyilSzerk.colors[i] = ((LEDArrow)(FormHelper.Devices[j])).Color;
                        FormNyilSzerk.directions[i] = ((LEDArrow)(FormHelper.Devices[j])).Direction;
                    }
                    if (turnSettings[i].Devices[j] != null && turnSettings[i].Devices[j].Type == 'H')
                    {
                        FormHangszSzerk.timeMilisec[i] = ((Speaker)(FormHelper.Devices[j])).Sounds[0].Length;
                        FormHangszSzerk.pitch[i] = (Pitch)((Speaker)(FormHelper.Devices[j])).Sounds[0].Index;
                        //speaker1.AddSound(FormHangszSzerk.pitch[i], 63, FormHangszSzerk.timeMilisec[i]);
                    }
                    
                }
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.Height = 100;
                dataGridInditas.Rows.Add(newRow);

            }
        }

        private void btnNewUtem_Click(object sender, EventArgs e)
        {
            DataGridViewRow newRow = new DataGridViewRow();
            newRow.Height = 100;
            dataGridInditas.Rows.Add(newRow);

          /*  Gombokat_Kirak();*/
            
        }

        private void dataGridInditas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormLampaSzerk.rowCount = dataGridInditas.Rows.Count;
            FormNyilSzerk.rowCount = dataGridInditas.Rows.Count;
            if (nyilSzerkForm != null)
            {
                nyilSzerkForm.Close();
            }
            if (lampaSzerkForm != null)
            {
                lampaSzerkForm.Close();
            }
            if (hangSzerkForm != null)
            {
                hangSzerkForm.Close();
            }
           



            if (dataGridInditas.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if (FormHelper.Devices[e.ColumnIndex] is LEDArrow)
                {
                    ledArrow1 = (LEDArrow)FormHelper.Devices[e.ColumnIndex];
                    nyilSzerkForm = new FormNyilSzerk(e.RowIndex);
                    nyilSzerkForm.Show();
                    
                }
                else if (FormHelper.Devices[e.ColumnIndex] is LEDLight)
                {
                    //FormMainMenu formMain = new FormMainMenu();
                    ledLight1 = (LEDLight)FormHelper.Devices[e.ColumnIndex];
                    /*  dataGridInditas.Columns[e.ColumnIndex].DefaultCellStyle.ForeColor = ledLight1.Color;*/
                    lampaSzerkForm = new FormLampaSzerk(e.RowIndex);
                    lampaSzerkForm.Show();
                }
                else if (FormHelper.Devices[e.ColumnIndex] is Speaker)
                {
                    speaker1 = (Speaker)FormHelper.Devices[e.ColumnIndex];
                    hangSzerkForm = new FormHangszSzerk(e.RowIndex);
                    hangSzerkForm.Show();
                }
              
                //IDE KELL A TÖBBI IF 
            }


        }


    }
}
