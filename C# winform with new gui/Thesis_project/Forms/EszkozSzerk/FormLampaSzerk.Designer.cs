namespace Thesis_project.Forms
{
    partial class FormLampaSzerk
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
            this.lampaAzLbl = new System.Windows.Forms.Label();
            this.lampaMentBtn = new System.Windows.Forms.Button();
            this.ColorPickerBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.aktSzinLamp = new System.Windows.Forms.Label();
            this.btnCloseTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lampaAzLbl
            // 
            this.lampaAzLbl.AutoSize = true;
            this.lampaAzLbl.Location = new System.Drawing.Point(59, 39);
            this.lampaAzLbl.Name = "lampaAzLbl";
            this.lampaAzLbl.Size = new System.Drawing.Size(0, 13);
            this.lampaAzLbl.TabIndex = 8;
            // 
            // lampaMentBtn
            // 
            this.lampaMentBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lampaMentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.lampaMentBtn.Location = new System.Drawing.Point(58, 203);
            this.lampaMentBtn.Name = "lampaMentBtn";
            this.lampaMentBtn.Size = new System.Drawing.Size(146, 53);
            this.lampaMentBtn.TabIndex = 9;
            this.lampaMentBtn.Text = "Mentés";
            this.lampaMentBtn.UseVisualStyleBackColor = true;
            this.lampaMentBtn.Click += new System.EventHandler(this.lampaMentBtn_Click);
            // 
            // ColorPickerBox
            // 
            this.ColorPickerBox.BackColor = System.Drawing.Color.Red;
            this.ColorPickerBox.Location = new System.Drawing.Point(62, 55);
            this.ColorPickerBox.Name = "ColorPickerBox";
            this.ColorPickerBox.Size = new System.Drawing.Size(146, 73);
            this.ColorPickerBox.TabIndex = 16;
            this.ColorPickerBox.TabStop = false;
            this.ColorPickerBox.Click += new System.EventHandler(this.ColorPickerBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.Location = new System.Drawing.Point(46, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "(Kattints a dobozra a szín váltáshoz)";
            // 
            // aktSzinLamp
            // 
            this.aktSzinLamp.AutoSize = true;
            this.aktSzinLamp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.aktSzinLamp.Location = new System.Drawing.Point(59, 25);
            this.aktSzinLamp.Name = "aktSzinLamp";
            this.aktSzinLamp.Size = new System.Drawing.Size(83, 16);
            this.aktSzinLamp.TabIndex = 24;
            this.aktSzinLamp.Text = "Aktuális szin:";
            // 
            // btnCloseTop
            // 
            this.btnCloseTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTop.FlatAppearance.BorderSize = 0;
            this.btnCloseTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTop.ForeColor = System.Drawing.Color.Black;
            this.btnCloseTop.Location = new System.Drawing.Point(211, -2);
            this.btnCloseTop.Name = "btnCloseTop";
            this.btnCloseTop.Size = new System.Drawing.Size(28, 24);
            this.btnCloseTop.TabIndex = 26;
            this.btnCloseTop.Text = "✖";
            this.btnCloseTop.UseVisualStyleBackColor = true;
            this.btnCloseTop.Click += new System.EventHandler(this.btnCloseTop_Click);
            // 
            // FormLampaSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(238, 282);
            this.Controls.Add(this.btnCloseTop);
            this.Controls.Add(this.aktSzinLamp);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorPickerBox);
            this.Controls.Add(this.lampaMentBtn);
            this.Controls.Add(this.lampaAzLbl);
            this.Name = "FormLampaSzerk";
            this.Text = "FormLampaSzerk";
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lampaAzLbl;
        private System.Windows.Forms.Button lampaMentBtn;
        private System.Windows.Forms.PictureBox ColorPickerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label aktSzinLamp;
        private System.Windows.Forms.Button btnCloseTop;
    }
}