using Microsoft.VisualStudio.TestTools.UnitTesting;
using Thesis_project;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_project.MainFormTest
{
    [TestClass()]
    public class FormMainMenuMainFormTest
    {
        [TestMethod()]
        public void TestOpenChildForm()
        {
            FormMainMenu formMain = new FormMainMenu();
            try
            {

                formMain.OpenChildForm(null,null);
            }
            catch (Exception e)
            {
                StringAssert.Contains(e.Message,"A form vagy a btn nem megfelelő!");
                return;
            }
            Assert.Fail("No exception was thrown!");
        }
    
    }
}