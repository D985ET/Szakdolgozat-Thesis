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

namespace Thesis_project.Forms.FormKirakTest
{
    [TestClass()]
    public class FormInditasFormKirakTest
    {
        [TestMethod()]
        public void nyilatKiraknyilatKirakTest()
        {
            Point p = new Point(1, 1);
            var mock = new Mock<Form>();
            var service = new FormInditas();

            mock.Verify(x => service.Gombokat_Kirak(), Times.Never());

        }

        [TestMethod()]
        public void LoadThemeLoadThemeTest()
        {
            FormInditas formInditas = new FormInditas();
           
            Assert.Fail();
        }

    
    }
}