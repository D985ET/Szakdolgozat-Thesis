﻿namespace Thesis_project.Forms.EszkozSzerk
{
    partial class FormHangszSzerk
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
            this.pitchComboBox = new System.Windows.Forms.ComboBox();
            this.timeMilisecBox = new System.Windows.Forms.NumericUpDown();
            this.aktHszinLbl = new System.Windows.Forms.Label();
            this.aktHerőLbl = new System.Windows.Forms.Label();
            this.aktHanghosszLBl = new System.Windows.Forms.Label();
            this.btnHangMent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pitchComboBox
            // 
            this.pitchComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pitchComboBox.FormattingEnabled = true;
            this.pitchComboBox.Location = new System.Drawing.Point(56, 36);
            this.pitchComboBox.Name = "pitchComboBox";
            this.pitchComboBox.Size = new System.Drawing.Size(128, 21);
            this.pitchComboBox.TabIndex = 0;
            this.pitchComboBox.SelectedIndexChanged += new System.EventHandler(this.pitchComboBox_SelectedIndexChanged);
            // 
            // timeMilisecBox
            // 
            this.timeMilisecBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeMilisecBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timeMilisecBox.Location = new System.Drawing.Point(57, 110);
            this.timeMilisecBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeMilisecBox.Name = "timeMilisecBox";
            this.timeMilisecBox.Size = new System.Drawing.Size(128, 20);
            this.timeMilisecBox.TabIndex = 4;
            this.timeMilisecBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.timeMilisecBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeMilisecBox_KeyPress);
            // 
            // aktHszinLbl
            // 
            this.aktHszinLbl.AutoSize = true;
            this.aktHszinLbl.Location = new System.Drawing.Point(12, 81);
            this.aktHszinLbl.Name = "aktHszinLbl";
            this.aktHszinLbl.Size = new System.Drawing.Size(0, 13);
            this.aktHszinLbl.TabIndex = 8;
            // 
            // aktHerőLbl
            // 
            this.aktHerőLbl.AutoSize = true;
            this.aktHerőLbl.Location = new System.Drawing.Point(319, 81);
            this.aktHerőLbl.Name = "aktHerőLbl";
            this.aktHerőLbl.Size = new System.Drawing.Size(0, 13);
            this.aktHerőLbl.TabIndex = 9;
            // 
            // aktHanghosszLBl
            // 
            this.aktHanghosszLBl.AutoSize = true;
            this.aktHanghosszLBl.Location = new System.Drawing.Point(615, 81);
            this.aktHanghosszLBl.Name = "aktHanghosszLBl";
            this.aktHanghosszLBl.Size = new System.Drawing.Size(0, 13);
            this.aktHanghosszLBl.TabIndex = 10;
            // 
            // btnHangMent
            // 
            this.btnHangMent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnHangMent.Location = new System.Drawing.Point(57, 187);
            this.btnHangMent.Name = "btnHangMent";
            this.btnHangMent.Size = new System.Drawing.Size(128, 44);
            this.btnHangMent.TabIndex = 21;
            this.btnHangMent.Text = "Mentés";
            this.btnHangMent.UseVisualStyleBackColor = true;
            this.btnHangMent.Click += new System.EventHandler(this.btnHangMent_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(54, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "hanghossz:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(54, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "hangszín:";
            // 
            // btnCloseTop
            // 
            this.btnCloseTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTop.FlatAppearance.BorderSize = 0;
            this.btnCloseTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTop.Font = new System.Drawing.Font("Bauhaus 93", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTop.ForeColor = System.Drawing.Color.Black;
            this.btnCloseTop.Location = new System.Drawing.Point(215, 1);
            this.btnCloseTop.Name = "btnCloseTop";
            this.btnCloseTop.Size = new System.Drawing.Size(28, 24);
            this.btnCloseTop.TabIndex = 25;
            this.btnCloseTop.Text = "✖";
            this.btnCloseTop.UseVisualStyleBackColor = true;
            this.btnCloseTop.Click += new System.EventHandler(this.btnCloseTop_Click);
            // 
            // FormHangszSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 253);
            this.Controls.Add(this.btnCloseTop);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHangMent);
            this.Controls.Add(this.aktHanghosszLBl);
            this.Controls.Add(this.aktHerőLbl);
            this.Controls.Add(this.aktHszinLbl);
            this.Controls.Add(this.timeMilisecBox);
            this.Controls.Add(this.pitchComboBox);
            this.Name = "FormHangszSzerk";
            this.Text = "FormHangszSzerk";
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pitchComboBox;
        private System.Windows.Forms.NumericUpDown timeMilisecBox;
        private System.Windows.Forms.Label aktHszinLbl;
        private System.Windows.Forms.Label aktHerőLbl;
        private System.Windows.Forms.Label aktHanghosszLBl;
        private System.Windows.Forms.Button btnHangMent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseTop;
    }
}