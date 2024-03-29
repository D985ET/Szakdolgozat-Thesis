﻿using SLFormHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thesis_project.Forms
{
    public partial class FormMentes : Form
    {
        public FormMentes(FormInditas formInditas)
        {
            InitializeComponent();
            //kinézet:
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.WindowState = FormWindowState.Maximized;
            Application.EnableVisualStyles();
            LoadTheme();
            Mentes();
            formInditas.jsonBeMentes(filePath);
        }
        private void LoadTheme()
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

        string fileContent = string.Empty;
        string filePath = string.Empty;

        public void Mentes()
        {
            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.InitialDirectory = "c:\\";
                saveFileDialog.Filter = "JSON files (*.json)|*.json";
                saveFileDialog.FilterIndex = 2;
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                }
            }
            catch (Exception e)
            {
                throw new Exception("Probléma volt a fájl mentése során! ", e);
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);

           /* FormHelper.UnloadDeviceSettings(filePath);*///kiment
        }

    }
}
