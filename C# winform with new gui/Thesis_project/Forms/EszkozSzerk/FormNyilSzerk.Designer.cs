﻿
namespace Thesis_project.Forms
{
    partial class FormNyilSzerk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nyilAzLbl = new System.Windows.Forms.Label();
            this.btnMentNyil = new System.Windows.Forms.Button();
            this.nyilAz = new System.Windows.Forms.Label();
            this.nyilSzinLbl = new System.Windows.Forms.Label();
            this.nyilIranyLbl = new System.Windows.Forms.Label();
            this.nyilSzerkR = new System.Windows.Forms.Button();
            this.nyilSzerkB = new System.Windows.Forms.Button();
            this.nyilSzerkG = new System.Windows.Forms.Button();
            this.nyilSzerkDefault = new System.Windows.Forms.Button();
            this.nyilSzerkBal = new System.Windows.Forms.Button();
            this.nyilSzerkJobb = new System.Windows.Forms.Button();
            this.nyilSzerkBoth = new System.Windows.Forms.Button();
            this.nyilSzinAkt = new System.Windows.Forms.Label();
            this.nyilAktIrany = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nyilAzLbl
            // 
            this.nyilAzLbl.AutoSize = true;
            this.nyilAzLbl.Location = new System.Drawing.Point(25, 9);
            this.nyilAzLbl.Name = "nyilAzLbl";
            this.nyilAzLbl.Size = new System.Drawing.Size(73, 13);
            this.nyilAzLbl.TabIndex = 0;
            this.nyilAzLbl.Text = "nyilAzonosító:";
            // 
            // btnMentNyil
            // 
            this.btnMentNyil.Location = new System.Drawing.Point(278, 306);
            this.btnMentNyil.Name = "btnMentNyil";
            this.btnMentNyil.Size = new System.Drawing.Size(221, 108);
            this.btnMentNyil.TabIndex = 1;
            this.btnMentNyil.Text = "Mentés";
            this.btnMentNyil.UseVisualStyleBackColor = true;
            this.btnMentNyil.Click += new System.EventHandler(this.btnMentNyil_Click);
            // 
            // nyilAz
            // 
            this.nyilAz.AutoSize = true;
            this.nyilAz.Location = new System.Drawing.Point(28, 38);
            this.nyilAz.Name = "nyilAz";
            this.nyilAz.Size = new System.Drawing.Size(0, 13);
            this.nyilAz.TabIndex = 2;
            // 
            // nyilSzinLbl
            // 
            this.nyilSzinLbl.AutoSize = true;
            this.nyilSzinLbl.Location = new System.Drawing.Point(345, 9);
            this.nyilSzinLbl.Name = "nyilSzinLbl";
            this.nyilSzinLbl.Size = new System.Drawing.Size(45, 13);
            this.nyilSzinLbl.TabIndex = 3;
            this.nyilSzinLbl.Text = "nyilSzin:";
            // 
            // nyilIranyLbl
            // 
            this.nyilIranyLbl.AutoSize = true;
            this.nyilIranyLbl.Location = new System.Drawing.Point(650, 9);
            this.nyilIranyLbl.Name = "nyilIranyLbl";
            this.nyilIranyLbl.Size = new System.Drawing.Size(45, 13);
            this.nyilIranyLbl.TabIndex = 4;
            this.nyilIranyLbl.Text = "nyilIrany";
            // 
            // nyilSzerkR
            // 
            this.nyilSzerkR.Location = new System.Drawing.Point(278, 27);
            this.nyilSzerkR.Name = "nyilSzerkR";
            this.nyilSzerkR.Size = new System.Drawing.Size(75, 23);
            this.nyilSzerkR.TabIndex = 5;
            this.nyilSzerkR.Text = "Piros";
            this.nyilSzerkR.UseVisualStyleBackColor = true;
            this.nyilSzerkR.Click += new System.EventHandler(this.nyilSzerkR_Click);
            // 
            // nyilSzerkB
            // 
            this.nyilSzerkB.Location = new System.Drawing.Point(278, 56);
            this.nyilSzerkB.Name = "nyilSzerkB";
            this.nyilSzerkB.Size = new System.Drawing.Size(75, 23);
            this.nyilSzerkB.TabIndex = 6;
            this.nyilSzerkB.Text = "Kék";
            this.nyilSzerkB.UseVisualStyleBackColor = true;
            this.nyilSzerkB.Click += new System.EventHandler(this.nyilSzerkB_Click);
            // 
            // nyilSzerkG
            // 
            this.nyilSzerkG.Location = new System.Drawing.Point(278, 85);
            this.nyilSzerkG.Name = "nyilSzerkG";
            this.nyilSzerkG.Size = new System.Drawing.Size(75, 23);
            this.nyilSzerkG.TabIndex = 7;
            this.nyilSzerkG.Text = "Zöld";
            this.nyilSzerkG.UseVisualStyleBackColor = true;
            this.nyilSzerkG.Click += new System.EventHandler(this.nyilSzerkG_Click);
            // 
            // nyilSzerkDefault
            // 
            this.nyilSzerkDefault.Location = new System.Drawing.Point(359, 56);
            this.nyilSzerkDefault.Name = "nyilSzerkDefault";
            this.nyilSzerkDefault.Size = new System.Drawing.Size(75, 23);
            this.nyilSzerkDefault.TabIndex = 8;
            this.nyilSzerkDefault.Text = "Üres";
            this.nyilSzerkDefault.UseVisualStyleBackColor = true;
            this.nyilSzerkDefault.Click += new System.EventHandler(this.nyilSzerkDefault_Click);
            // 
            // nyilSzerkBal
            // 
            this.nyilSzerkBal.Location = new System.Drawing.Point(620, 28);
            this.nyilSzerkBal.Name = "nyilSzerkBal";
            this.nyilSzerkBal.Size = new System.Drawing.Size(121, 23);
            this.nyilSzerkBal.TabIndex = 9;
            this.nyilSzerkBal.Text = "Balra";
            this.nyilSzerkBal.UseVisualStyleBackColor = true;
            this.nyilSzerkBal.Click += new System.EventHandler(this.nyilSzerkBal_Click);
            // 
            // nyilSzerkJobb
            // 
            this.nyilSzerkJobb.Location = new System.Drawing.Point(620, 57);
            this.nyilSzerkJobb.Name = "nyilSzerkJobb";
            this.nyilSzerkJobb.Size = new System.Drawing.Size(121, 23);
            this.nyilSzerkJobb.TabIndex = 10;
            this.nyilSzerkJobb.Text = "Jobbra";
            this.nyilSzerkJobb.UseVisualStyleBackColor = true;
            this.nyilSzerkJobb.Click += new System.EventHandler(this.nyilSzerkJobb_Click);
            // 
            // nyilSzerkBoth
            // 
            this.nyilSzerkBoth.Location = new System.Drawing.Point(620, 86);
            this.nyilSzerkBoth.Name = "nyilSzerkBoth";
            this.nyilSzerkBoth.Size = new System.Drawing.Size(121, 23);
            this.nyilSzerkBoth.TabIndex = 11;
            this.nyilSzerkBoth.Text = "Balra és jobbra";
            this.nyilSzerkBoth.UseVisualStyleBackColor = true;
            this.nyilSzerkBoth.Click += new System.EventHandler(this.nyilSzerkBoth_Click);
            // 
            // nyilSzinAkt
            // 
            this.nyilSzinAkt.AutoSize = true;
            this.nyilSzinAkt.Location = new System.Drawing.Point(275, 172);
            this.nyilSzinAkt.Name = "nyilSzinAkt";
            this.nyilSzinAkt.Size = new System.Drawing.Size(71, 13);
            this.nyilSzinAkt.TabIndex = 12;
            this.nyilSzinAkt.Text = "Aktuális szin: ";
            // 
            // nyilAktIrany
            // 
            this.nyilAktIrany.AutoSize = true;
            this.nyilAktIrany.Location = new System.Drawing.Point(617, 172);
            this.nyilAktIrany.Name = "nyilAktIrany";
            this.nyilAktIrany.Size = new System.Drawing.Size(72, 13);
            this.nyilAktIrany.TabIndex = 13;
            this.nyilAktIrany.Text = "Aktuális irány:";
            // 
            // FormNyilSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nyilAktIrany);
            this.Controls.Add(this.nyilSzinAkt);
            this.Controls.Add(this.nyilSzerkBoth);
            this.Controls.Add(this.nyilSzerkJobb);
            this.Controls.Add(this.nyilSzerkBal);
            this.Controls.Add(this.nyilSzerkDefault);
            this.Controls.Add(this.nyilSzerkG);
            this.Controls.Add(this.nyilSzerkB);
            this.Controls.Add(this.nyilSzerkR);
            this.Controls.Add(this.nyilIranyLbl);
            this.Controls.Add(this.nyilSzinLbl);
            this.Controls.Add(this.nyilAz);
            this.Controls.Add(this.btnMentNyil);
            this.Controls.Add(this.nyilAzLbl);
            this.Name = "FormNyilSzerk";
            this.Text = "FormNyilSzerk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nyilAzLbl;
        private System.Windows.Forms.Button btnMentNyil;
        private System.Windows.Forms.Label nyilAz;
        private System.Windows.Forms.Label nyilSzinLbl;
        private System.Windows.Forms.Label nyilIranyLbl;
        private System.Windows.Forms.Button nyilSzerkR;
        private System.Windows.Forms.Button nyilSzerkB;
        private System.Windows.Forms.Button nyilSzerkG;
        private System.Windows.Forms.Button nyilSzerkDefault;
        private System.Windows.Forms.Button nyilSzerkBal;
        private System.Windows.Forms.Button nyilSzerkJobb;
        private System.Windows.Forms.Button nyilSzerkBoth;
        private System.Windows.Forms.Label nyilSzinAkt;
        private System.Windows.Forms.Label nyilAktIrany;
    }
}