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
            this.label2 = new System.Windows.Forms.Label();
            this.lampaAzLbl = new System.Windows.Forms.Label();
            this.lampaMentBtn = new System.Windows.Forms.Button();
            this.aktSzinLamp = new System.Windows.Forms.Label();
            this.ColorPickerBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 43);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azonosító:";
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
            this.lampaMentBtn.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lampaMentBtn.Location = new System.Drawing.Point(191, 337);
            this.lampaMentBtn.Name = "lampaMentBtn";
            this.lampaMentBtn.Size = new System.Drawing.Size(409, 112);
            this.lampaMentBtn.TabIndex = 9;
            this.lampaMentBtn.Text = "Mentés";
            this.lampaMentBtn.UseVisualStyleBackColor = true;
            this.lampaMentBtn.Click += new System.EventHandler(this.lampaMentBtn_Click);
            // 
            // aktSzinLamp
            // 
            this.aktSzinLamp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.aktSzinLamp.AutoSize = true;
            this.aktSzinLamp.Font = new System.Drawing.Font("Myanmar Text", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aktSzinLamp.Location = new System.Drawing.Point(183, 283);
            this.aktSzinLamp.Name = "aktSzinLamp";
            this.aktSzinLamp.Size = new System.Drawing.Size(171, 48);
            this.aktSzinLamp.TabIndex = 11;
            this.aktSzinLamp.Text = "Aktuális szín:";
            // 
            // ColorPickerBox
            // 
            this.ColorPickerBox.BackColor = System.Drawing.Color.Transparent;
            this.ColorPickerBox.Location = new System.Drawing.Point(351, 258);
            this.ColorPickerBox.Name = "ColorPickerBox";
            this.ColorPickerBox.Size = new System.Drawing.Size(127, 73);
            this.ColorPickerBox.TabIndex = 16;
            this.ColorPickerBox.TabStop = false;
            this.ColorPickerBox.Click += new System.EventHandler(this.ColorPickerBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(302, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kattints a dobozra a váltáshoz";
            // 
            // FormLampaSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorPickerBox);
            this.Controls.Add(this.aktSzinLamp);
            this.Controls.Add(this.lampaMentBtn);
            this.Controls.Add(this.lampaAzLbl);
            this.Controls.Add(this.label2);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "FormLampaSzerk";
            this.Text = "FormLampaSzerk";
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lampaAzLbl;
        private System.Windows.Forms.Button lampaMentBtn;
        private System.Windows.Forms.Label aktSzinLamp;
        private System.Windows.Forms.PictureBox ColorPickerBox;
        private System.Windows.Forms.Label label1;
    }
}