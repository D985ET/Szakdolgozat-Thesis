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
            this.lblHangszin = new System.Windows.Forms.Label();
            this.timeMilisecBox = new System.Windows.Forms.NumericUpDown();
            this.hangeroNumUp = new System.Windows.Forms.NumericUpDown();
            this.lblHangero = new System.Windows.Forms.Label();
            this.lblHanghossz = new System.Windows.Forms.Label();
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
            this.pitchComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pitchComboBox.FormattingEnabled = true;
            this.pitchComboBox.Location = new System.Drawing.Point(411, 108);
            this.pitchComboBox.Name = "pitchComboBox";
            this.pitchComboBox.Size = new System.Drawing.Size(121, 21);
            this.pitchComboBox.TabIndex = 0;
            this.pitchComboBox.SelectedIndexChanged += new System.EventHandler(this.pitchComboBox_SelectedIndexChanged);
            // 
            // lblHangszin
            // 
            this.lblHangszin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHangszin.AutoSize = true;
            this.lblHangszin.Font = new System.Drawing.Font("Myanmar Text", 20.25F);
            this.lblHangszin.Location = new System.Drawing.Point(248, 94);
            this.lblHangszin.Name = "lblHangszin";
            this.lblHangszin.Size = new System.Drawing.Size(158, 48);
            this.lblHangszin.TabIndex = 1;
            this.lblHangszin.Text = "hangszínek:";
            // 
            // timeMilisecBox
            // 
            this.timeMilisecBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.timeMilisecBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timeMilisecBox.Location = new System.Drawing.Point(412, 182);
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
            this.hangeroNumUp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hangeroNumUp.Location = new System.Drawing.Point(412, 38);
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
            // lblHangero
            // 
            this.lblHangero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHangero.AutoSize = true;
            this.lblHangero.Font = new System.Drawing.Font("Myanmar Text", 20.25F);
            this.lblHangero.Location = new System.Drawing.Point(280, 23);
            this.lblHangero.Name = "lblHangero";
            this.lblHangero.Size = new System.Drawing.Size(126, 48);
            this.lblHangero.TabIndex = 6;
            this.lblHangero.Text = "hangerő:";
            // 
            // lblHanghossz
            // 
            this.lblHanghossz.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHanghossz.AutoSize = true;
            this.lblHanghossz.Font = new System.Drawing.Font("Myanmar Text", 20.25F);
            this.lblHanghossz.Location = new System.Drawing.Point(261, 167);
            this.lblHanghossz.Name = "lblHanghossz";
            this.lblHanghossz.Size = new System.Drawing.Size(145, 48);
            this.lblHanghossz.TabIndex = 7;
            this.lblHanghossz.Text = "hanghossz";
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
            this.hangszAzLbl.Font = new System.Drawing.Font("Myanmar Text", 20.25F);
            this.hangszAzLbl.Location = new System.Drawing.Point(12, 23);
            this.hangszAzLbl.Name = "hangszAzLbl";
            this.hangszAzLbl.Size = new System.Drawing.Size(183, 48);
            this.hangszAzLbl.TabIndex = 11;
            this.hangszAzLbl.Text = "hangszóró az:";
            // 
            // btnHangMent
            // 
            this.btnHangMent.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnHangMent.Font = new System.Drawing.Font("Myanmar Text", 20.25F);
            this.btnHangMent.Location = new System.Drawing.Point(115, 337);
            this.btnHangMent.Name = "btnHangMent";
            this.btnHangMent.Size = new System.Drawing.Size(598, 112);
            this.btnHangMent.TabIndex = 12;
            this.btnHangMent.Text = "Mentés";
            this.btnHangMent.UseVisualStyleBackColor = true;
            this.btnHangMent.Click += new System.EventHandler(this.btnHangMent_Click);
            // 
            // FormHangszSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.btnHangMent);
            this.Controls.Add(this.hangszAzLbl);
            this.Controls.Add(this.aktHanghosszLBl);
            this.Controls.Add(this.aktHerőLbl);
            this.Controls.Add(this.aktHszinLbl);
            this.Controls.Add(this.lblHanghossz);
            this.Controls.Add(this.lblHangero);
            this.Controls.Add(this.hangeroNumUp);
            this.Controls.Add(this.timeMilisecBox);
            this.Controls.Add(this.lblHangszin);
            this.Controls.Add(this.pitchComboBox);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormHangszSzerk";
            this.Text = "FormHangszSzerk";
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangeroNumUp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox pitchComboBox;
        private System.Windows.Forms.Label lblHangszin;
        private System.Windows.Forms.NumericUpDown timeMilisecBox;
        private System.Windows.Forms.NumericUpDown hangeroNumUp;
        private System.Windows.Forms.Label lblHangero;
        private System.Windows.Forms.Label lblHanghossz;
        private System.Windows.Forms.Label aktHszinLbl;
        private System.Windows.Forms.Label aktHerőLbl;
        private System.Windows.Forms.Label aktHanghosszLBl;
        private System.Windows.Forms.Label hangszAzLbl;
        private System.Windows.Forms.Button btnHangMent;
    }
}