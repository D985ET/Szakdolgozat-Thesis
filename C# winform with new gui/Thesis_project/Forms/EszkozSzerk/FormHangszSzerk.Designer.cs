namespace Thesis_project.Forms.EszkozSzerk
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
            this.label1 = new System.Windows.Forms.Label();
            this.timeMilisecBox = new System.Windows.Forms.NumericUpDown();
            this.hangeroNumUp = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aktHszinLbl = new System.Windows.Forms.Label();
            this.aktHerőLbl = new System.Windows.Forms.Label();
            this.aktHanghosszLBl = new System.Windows.Forms.Label();
            this.hangszAzLbl = new System.Windows.Forms.Label();
            this.btnHangMent = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangeroNumUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pitchComboBox
            // 
            this.pitchComboBox.FormattingEnabled = true;
            this.pitchComboBox.Location = new System.Drawing.Point(12, 38);
            this.pitchComboBox.Name = "pitchComboBox";
            this.pitchComboBox.Size = new System.Drawing.Size(121, 21);
            this.pitchComboBox.TabIndex = 0;
            this.pitchComboBox.SelectedIndexChanged += new System.EventHandler(this.pitchComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "hangszínek:";
            // 
            // timeMilisecBox
            // 
            this.timeMilisecBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timeMilisecBox.Location = new System.Drawing.Point(618, 38);
            this.timeMilisecBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeMilisecBox.Name = "timeMilisecBox";
            this.timeMilisecBox.Size = new System.Drawing.Size(120, 20);
            this.timeMilisecBox.TabIndex = 4;
            this.timeMilisecBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.timeMilisecBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeMilisecBox_KeyPress);
            // 
            // hangeroNumUp
            // 
            this.hangeroNumUp.Location = new System.Drawing.Point(322, 38);
            this.hangeroNumUp.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.hangeroNumUp.Name = "hangeroNumUp";
            this.hangeroNumUp.Size = new System.Drawing.Size(120, 20);
            this.hangeroNumUp.TabIndex = 5;
            this.hangeroNumUp.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(322, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "hangerő:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(615, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "hanghossz";
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
            // hangszAzLbl
            // 
            this.hangszAzLbl.AutoSize = true;
            this.hangszAzLbl.Location = new System.Drawing.Point(12, 337);
            this.hangszAzLbl.Name = "hangszAzLbl";
            this.hangszAzLbl.Size = new System.Drawing.Size(73, 13);
            this.hangszAzLbl.TabIndex = 11;
            this.hangszAzLbl.Text = "hangszóró az:";
            // 
            // btnHangMent
            // 
            this.btnHangMent.Location = new System.Drawing.Point(322, 300);
            this.btnHangMent.Name = "btnHangMent";
            this.btnHangMent.Size = new System.Drawing.Size(162, 126);
            this.btnHangMent.TabIndex = 12;
            this.btnHangMent.Text = "Mentés";
            this.btnHangMent.UseVisualStyleBackColor = true;
            this.btnHangMent.Click += new System.EventHandler(this.btnHangMent_Click);
            // 
            // FormHangszSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnHangMent);
            this.Controls.Add(this.hangszAzLbl);
            this.Controls.Add(this.aktHanghosszLBl);
            this.Controls.Add(this.aktHerőLbl);
            this.Controls.Add(this.aktHszinLbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.hangeroNumUp);
            this.Controls.Add(this.timeMilisecBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pitchComboBox);
            this.Name = "FormHangszSzerk";
            this.Text = "FormHangszSzerk";
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangeroNumUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pitchComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timeMilisecBox;
        private System.Windows.Forms.NumericUpDown hangeroNumUp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label aktHszinLbl;
        private System.Windows.Forms.Label aktHerőLbl;
        private System.Windows.Forms.Label aktHanghosszLBl;
        private System.Windows.Forms.Label hangszAzLbl;
        private System.Windows.Forms.Button btnHangMent;
    }
}