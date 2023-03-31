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
            this.timeMilisecBox = new System.Windows.Forms.NumericUpDown();
            this.hangeroNumUp = new System.Windows.Forms.NumericUpDown();
            this.aktHszinLbl = new System.Windows.Forms.Label();
            this.aktHerőLbl = new System.Windows.Forms.Label();
            this.aktHanghosszLBl = new System.Windows.Forms.Label();
            this.btnHangMent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hangeroNumUp)).BeginInit();
            this.SuspendLayout();
            // 
            // pitchComboBox
            // 
            this.pitchComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pitchComboBox.FormattingEnabled = true;
            this.pitchComboBox.Location = new System.Drawing.Point(61, 90);
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
            this.timeMilisecBox.Location = new System.Drawing.Point(60, 149);
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
            // hangeroNumUp
            // 
            this.hangeroNumUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.hangeroNumUp.Location = new System.Drawing.Point(61, 28);
            this.hangeroNumUp.Maximum = new decimal(new int[] {
            63,
            0,
            0,
            0});
            this.hangeroNumUp.Name = "hangeroNumUp";
            this.hangeroNumUp.Size = new System.Drawing.Size(128, 20);
            this.hangeroNumUp.TabIndex = 5;
            this.hangeroNumUp.Value = new decimal(new int[] {
            30,
            0,
            0,
            0});
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
            this.btnHangMent.Location = new System.Drawing.Point(61, 226);
            this.btnHangMent.Name = "btnHangMent";
            this.btnHangMent.Size = new System.Drawing.Size(128, 44);
            this.btnHangMent.TabIndex = 21;
            this.btnHangMent.Text = "Mentés";
            this.btnHangMent.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label1.Location = new System.Drawing.Point(58, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "hanghossz:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label2.Location = new System.Drawing.Point(58, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.TabIndex = 23;
            this.label2.Text = "hangerő:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.label3.Location = new System.Drawing.Point(58, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "hanghossz:";
            // 
            // FormHangszSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(246, 282);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHangMent);
            this.Controls.Add(this.aktHanghosszLBl);
            this.Controls.Add(this.aktHerőLbl);
            this.Controls.Add(this.aktHszinLbl);
            this.Controls.Add(this.hangeroNumUp);
            this.Controls.Add(this.timeMilisecBox);
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
        private System.Windows.Forms.NumericUpDown timeMilisecBox;
        private System.Windows.Forms.NumericUpDown hangeroNumUp;
        private System.Windows.Forms.Label aktHszinLbl;
        private System.Windows.Forms.Label aktHerőLbl;
        private System.Windows.Forms.Label aktHanghosszLBl;
        private System.Windows.Forms.Button btnHangMent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}