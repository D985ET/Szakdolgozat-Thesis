using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thesis_project.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Moq;
using System.Windows.Forms;
using SLFormHelper;
using System.IO;

namespace Thesis_project.Forms
{
    [TestClass()]
    public class FormInditasFormKirakTest
    {
        
        [TestMethod()]
        public void jsonBeMentesTest()
        {
            FormHelper.CallFillDev485Static();
            FormInditas formInditas = new FormInditas();
            formInditas.Show();
            formInditas.jsonBeMentes("test.json");
            bool letezikEFajl = File.Exists("test.json");
            Assert.Equals(letezikEFajl, true); //megnézzük hogy létezik e a fájl
        }
        [TestMethod()]
        public void jsonBeMentes_NemTalalDLL_Test()
        {
            Assert.ThrowsException<DllNotFoundException>(() => { FormHelper.CallFillDev485Static(); });
        }
    }
}