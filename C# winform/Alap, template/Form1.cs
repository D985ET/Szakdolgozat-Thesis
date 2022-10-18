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
    }
}
