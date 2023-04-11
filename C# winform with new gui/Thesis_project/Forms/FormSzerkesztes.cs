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
        FormNyilSzerk nyilSzerkForm; //nyil kirakás új form Clickre.
        LEDArrow ledArrow1;
     
        
        
        FormLampaSzerk lampaSzerkForm;
        LEDLight ledLight1;
       
        FormHangszSzerk hangSzerkForm;
        Speaker speaker1;
    

        private void dataGridSzerkesztes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormLampaSzerk.rowCount = dataGridSzerkesztes.Rows.Count;
            if (dataGridSzerkesztes.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
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
                    lampaSzerkForm = new FormLampaSzerk(e.RowIndex);
                    lampaSzerkForm.Show();
                }
                else if (FormHelper.Devices[e.ColumnIndex] is Speaker)
                {
                    speaker1 = (Speaker)FormHelper.Devices[e.ColumnIndex];
                    hangSzerkForm = new FormHangszSzerk(e.RowIndex);
                    hangSzerkForm.Show();
                }
                else
                {
                    MessageBox.Show("nem létezik ilyen eszköz!");
                }
               
                
            }
        }

        private void btnFuttatasSzerk_Click(object sender, EventArgs e)
        {
           
            if (ledLight1 != null)
            {
                ledLight1.Color = FormLampaSzerk.colors[0];
            }
            if (ledArrow1 != null)
            {
                ledArrow1.Color = FormNyilSzerk.colors[0];
                ledArrow1.Direction = FormNyilSzerk.directions[0];
            }
            if (speaker1 != null)
            {
                speaker1.AddSound(FormHangszSzerk.pitch[0], 63, FormHangszSzerk.timeMilisec[0]);
            }
            string json_source = FormHelper.DevicesToJSON();//átalakítja az ezsközbeállításokat JSON-é
            FormHelper.CallSetTurnForEachDevice(ref json_source);//ez futtatja le a színt
            if (speaker1 != null)
            {
                speaker1.ClearSounds();
            }
           

        }
    }
}
