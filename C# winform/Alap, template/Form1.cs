using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alap__template
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void kilépésAProgrambólToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void eszközökFelméréseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //start(); //ezt a dll-ből kapom
            }
            catch(Exception)
            {
                Console.WriteLine("Eszköz inicializálási hiba, ellenőrizze az eszközök csatlakozóit! ");
            }
            
        }

        private void eszközökInicializálásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int r;
            //--------------------------TODO--------------------------
            //r = SLDLL_felemeres(); //TODO
            //label1.Caption = r.ToString(); //TODO (label1.Caption := inttostr(r);)
        }

        private void csoportküldésTeszteléseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;
            int elemszam;
            //--------------------------TODO--------------------------
            /*
             * lista[0].azonos := dev485[0].azonos;
               lista[0].vilrgb.rossze := 0;
               lista[0].vilrgb.gossze := 0;
               lista[0].vilrgb.bossze := 0;
               devList[i].nilmeg := 0; // 1 //2 strToBool(elements[3]);

               lista[1].azonos := dev485[1].azonos;
               lista[1].vilrgb.rossze := 0;
               lista[1].vilrgb.gossze := 0;
               lista[1].vilrgb.bossze := 0;
               devList[i].nilmeg := 0; // 1 //2 strToBool(elements[3]);

               lista[2].azonos := dev485[2].azonos;
               devList[i].nilmeg := 0; // 1 //2 strToBool(elements[3]);
               lista[2].vilrgb.rossze := 20;
               lista[2].vilrgb.gossze := 0;
               lista[2].vilrgb.bossze := 0;


               lista[3].azonos := dev485[3].azonos;
               lista[3].vilrgb.rossze := 20;
               lista[3].vilrgb.gossze := 0;
               lista[3].vilrgb.bossze := 0;
               devList[i].nilmeg := 0; // 1 //2 strToBool(elements[3]);

               elemszam := 2;

               i := SLDLL_SetLista(elemszam, lista);
            */
        }

        private void ujlista()
        {
            //--------------------------TODO--------------------------
            //inc(LISTADB); //TODO
            //eszkozPanelLista(ScrollBox1); //TODO
        }
        private void ütemHozzáadásaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ujlista();
        }

        private void BTN_save_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                //--------------------------TODO--------------------------
                //richTextBox.SaveFile(saveFileDialog.FileName);
            }
        }

        private void BTNopen_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog()==DialogResult.OK)
            {
                //--------------------------TODO--------------------------
                //richTextBox.LoadFile(openFileDialog.FileName);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //--------------------------TODO--------------------------
            /*
            Label1.Caption := inttostr(MyCounter + 1) + '. kör';
            setRound(myCounter);
            //label1.Caption := teststring;
            if( MyCounter < SLprogram.Count - 1 )
            {
                inc(MyCounter);
            }
            else
            {
               Timer1.Enabled := false;
            }
            */
        }

        private void Panel2_Click(object sender, EventArgs e) 
        {
            string N, N7;
            //------------------TODO--------------
            //deviceType DEV;
            List<int> container = new List<int>();
            //------------------TODO--------------
            /*
             * AKT_PANEL:= Sender as TPanel;
                DEVICE_select_by_button(Sender);
                AKT_MENTETT_ESZKOZ.active := NOT AKT_MENTETT_ESZKOZ.active;
                save_selectted_DEVICE();
            */
            /*
            if ((Sender as TPanel).BevelOuter = bvRaised)
            {

                (Sender as TPanel).BevelOuter := bvLowered;
                //    (Sender as TPanel).Color := clRed;
                //    (Sender as TPanel).Font.Color := clWhite;
                (Sender as TPanel).PopupMenu := PopupMenu1;
                AKT_PANEl.BevelWidth := 1;
            }
            else
            {
                //(Sender as TPanel).Color := clBtnFace;
                (Sender as TPanel).BevelOuter := bvRaised;
                //(Sender as TPanel).Font.Color := clBlack;
                (Sender as TPanel).PopupMenu := nil;
                AKT_PANEl.BevelWidth := 1;
            }
            */


        }

    }
}
