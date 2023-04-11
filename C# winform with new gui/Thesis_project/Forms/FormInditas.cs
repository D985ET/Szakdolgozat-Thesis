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
            DataGridViewBetolt();
        }
        public void DataGridViewBetolt()
        {
            dataGridInditas.Width = Screen.PrimaryScreen.WorkingArea.Width - 970;
            dataGridInditas.Height = Screen.PrimaryScreen.WorkingArea.Height - 600;
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
        }
     


        //buttonok kirakása attól függően hogy mik.



       
        private FormNyilSzerk nyilSzerkForm; //nyil kirakás új form Clickre
        LEDArrow ledArrow1;
        


        Button lampaButton;
        FormLampaSzerk lampaSzerkForm;
        LEDLight ledLight1;
  



        FormHangszSzerk hangSzerkForm;
        Speaker speaker1;

        

        int i = 0;
        private void btnFuttatas_Click(object sender, EventArgs e)
        {
            btnFuttatas.Enabled = false;
            utemTimer.Enabled = true;
            utemTimer.Interval = (int)(nUPTimer.Value*1000);
           
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
            Console.WriteLine("TIMER:");
            Console.WriteLine(ledArrow1.Color);
            Console.WriteLine(ledArrow1.Direction);
        
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
