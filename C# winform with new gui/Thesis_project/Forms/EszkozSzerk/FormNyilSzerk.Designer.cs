
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
            this.nyilAz = new System.Windows.Forms.Label();
            this.nyilSzinAkt = new System.Windows.Forms.Label();
            this.ColorPickerBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nyilSzerkBal = new System.Windows.Forms.Button();
            this.nyilSzerkJobb = new System.Windows.Forms.Button();
            this.nyilAktIrany = new System.Windows.Forms.Label();
            this.nyilSzerkBoth = new System.Windows.Forms.Button();
            this.btnMentNyil = new System.Windows.Forms.Button();
            this.btnCloseTop = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerBox)).BeginInit();
            this.SuspendLayout();
            // 
            // nyilAz
            // 
            this.nyilAz.AutoSize = true;
            this.nyilAz.Location = new System.Drawing.Point(28, 38);
            this.nyilAz.Name = "nyilAz";
            this.nyilAz.Size = new System.Drawing.Size(0, 13);
            this.nyilAz.TabIndex = 2;
            // 
            // nyilSzinAkt
            // 
            this.nyilSzinAkt.AutoSize = true;
            this.nyilSzinAkt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.nyilSzinAkt.Location = new System.Drawing.Point(43, 22);
            this.nyilSzinAkt.Name = "nyilSzinAkt";
            this.nyilSzinAkt.Size = new System.Drawing.Size(84, 16);
            this.nyilSzinAkt.TabIndex = 25;
            this.nyilSzinAkt.Text = "Aktuális szin:";
            // 
            // ColorPickerBox
            // 
            this.ColorPickerBox.BackColor = System.Drawing.Color.Transparent;
            this.ColorPickerBox.Location = new System.Drawing.Point(46, 41);
            this.ColorPickerBox.Name = "ColorPickerBox";
            this.ColorPickerBox.Size = new System.Drawing.Size(146, 73);
            this.ColorPickerBox.TabIndex = 26;
            this.ColorPickerBox.TabStop = false;
            this.ColorPickerBox.Click += new System.EventHandler(this.ColorPickerBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.25F);
            this.label1.Location = new System.Drawing.Point(28, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 27;
            this.label1.Text = "(Kattints a dobozra a szín váltáshoz)";
            // 
            // nyilSzerkBal
            // 
            this.nyilSzerkBal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nyilSzerkBal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nyilSzerkBal.Location = new System.Drawing.Point(46, 165);
            this.nyilSzerkBal.Name = "nyilSzerkBal";
            this.nyilSzerkBal.Size = new System.Drawing.Size(59, 50);
            this.nyilSzerkBal.TabIndex = 28;
            this.nyilSzerkBal.Text = "←";
            this.nyilSzerkBal.UseVisualStyleBackColor = true;
            this.nyilSzerkBal.Click += new System.EventHandler(this.nyilSzerkBal_Click_1);
            // 
            // nyilSzerkJobb
            // 
            this.nyilSzerkJobb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nyilSzerkJobb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.nyilSzerkJobb.Location = new System.Drawing.Point(133, 165);
            this.nyilSzerkJobb.Name = "nyilSzerkJobb";
            this.nyilSzerkJobb.Size = new System.Drawing.Size(59, 50);
            this.nyilSzerkJobb.TabIndex = 29;
            this.nyilSzerkJobb.Text = "→";
            this.nyilSzerkJobb.UseVisualStyleBackColor = true;
            this.nyilSzerkJobb.Click += new System.EventHandler(this.nyilSzerkJobb_Click_1);
            // 
            // nyilAktIrany
            // 
            this.nyilAktIrany.AutoSize = true;
            this.nyilAktIrany.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.nyilAktIrany.Location = new System.Drawing.Point(43, 146);
            this.nyilAktIrany.Name = "nyilAktIrany";
            this.nyilAktIrany.Size = new System.Drawing.Size(90, 16);
            this.nyilAktIrany.TabIndex = 30;
            this.nyilAktIrany.Text = "Aktuális irány:";
            // 
            // nyilSzerkBoth
            // 
            this.nyilSzerkBoth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nyilSzerkBoth.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.nyilSzerkBoth.Location = new System.Drawing.Point(46, 221);
            this.nyilSzerkBoth.Name = "nyilSzerkBoth";
            this.nyilSzerkBoth.Size = new System.Drawing.Size(146, 50);
            this.nyilSzerkBoth.TabIndex = 31;
            this.nyilSzerkBoth.Text = "⇔";
            this.nyilSzerkBoth.UseVisualStyleBackColor = true;
            this.nyilSzerkBoth.Click += new System.EventHandler(this.nyilSzerkBoth_Click_1);
            // 
            // btnMentNyil
            // 
            this.btnMentNyil.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnMentNyil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.btnMentNyil.Location = new System.Drawing.Point(46, 288);
            this.btnMentNyil.Name = "btnMentNyil";
            this.btnMentNyil.Size = new System.Drawing.Size(146, 53);
            this.btnMentNyil.TabIndex = 32;
            this.btnMentNyil.Text = "Mentés";
            this.btnMentNyil.UseVisualStyleBackColor = true;
            this.btnMentNyil.Click += new System.EventHandler(this.btnMentNyil_Click_1);
            // 
            // btnCloseTop
            // 
            this.btnCloseTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTop.FlatAppearance.BorderSize = 0;
            this.btnCloseTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTop.ForeColor = System.Drawing.Color.Black;
            this.btnCloseTop.Location = new System.Drawing.Point(214, 0);
            this.btnCloseTop.Name = "btnCloseTop";
            this.btnCloseTop.Size = new System.Drawing.Size(28, 24);
            this.btnCloseTop.TabIndex = 33;
            this.btnCloseTop.Text = "✖";
            this.btnCloseTop.UseVisualStyleBackColor = true;
            this.btnCloseTop.Click += new System.EventHandler(this.btnCloseTop_Click);
            // 
            // FormNyilSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(240, 353);
            this.Controls.Add(this.btnCloseTop);
            this.Controls.Add(this.btnMentNyil);
            this.Controls.Add(this.nyilSzerkBoth);
            this.Controls.Add(this.nyilAktIrany);
            this.Controls.Add(this.nyilSzerkJobb);
            this.Controls.Add(this.nyilSzerkBal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ColorPickerBox);
            this.Controls.Add(this.nyilSzinAkt);
            this.Controls.Add(this.nyilAz);
            this.Name = "FormNyilSzerk";
            this.Text = "FormNyilSzerk";
            ((System.ComponentModel.ISupportInitialize)(this.ColorPickerBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label nyilAz;
        private System.Windows.Forms.Label nyilSzinAkt;
        private System.Windows.Forms.PictureBox ColorPickerBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button nyilSzerkBal;
        private System.Windows.Forms.Button nyilSzerkJobb;
        private System.Windows.Forms.Label nyilAktIrany;
        private System.Windows.Forms.Button nyilSzerkBoth;
        private System.Windows.Forms.Button btnMentNyil;
        private System.Windows.Forms.Button btnCloseTop;
    }
}