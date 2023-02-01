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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lampaBtnZold = new System.Windows.Forms.Button();
            this.lampaBtnUres = new System.Windows.Forms.Button();
            this.lampaBtnKek = new System.Windows.Forms.Button();
            this.lampaBtnPir = new System.Windows.Forms.Button();
            this.lampaAzLbl = new System.Windows.Forms.Label();
            this.lampaMentBtn = new System.Windows.Forms.Button();
            this.aktSzinLamp = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(386, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lámpa színe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Azonosító:";
            // 
            // lampaBtnZold
            // 
            this.lampaBtnZold.Location = new System.Drawing.Point(297, 169);
            this.lampaBtnZold.Name = "lampaBtnZold";
            this.lampaBtnZold.Size = new System.Drawing.Size(112, 68);
            this.lampaBtnZold.TabIndex = 4;
            this.lampaBtnZold.Text = "Zöld";
            this.lampaBtnZold.UseVisualStyleBackColor = true;
            this.lampaBtnZold.Click += new System.EventHandler(this.lampaBtnZold_Click);
            // 
            // lampaBtnUres
            // 
            this.lampaBtnUres.Location = new System.Drawing.Point(415, 29);
            this.lampaBtnUres.Name = "lampaBtnUres";
            this.lampaBtnUres.Size = new System.Drawing.Size(112, 208);
            this.lampaBtnUres.TabIndex = 5;
            this.lampaBtnUres.Text = "Üres";
            this.lampaBtnUres.UseVisualStyleBackColor = true;
            this.lampaBtnUres.Click += new System.EventHandler(this.lampaBtnUres_Click);
            // 
            // lampaBtnKek
            // 
            this.lampaBtnKek.Location = new System.Drawing.Point(297, 99);
            this.lampaBtnKek.Name = "lampaBtnKek";
            this.lampaBtnKek.Size = new System.Drawing.Size(112, 68);
            this.lampaBtnKek.TabIndex = 6;
            this.lampaBtnKek.Text = "Kék";
            this.lampaBtnKek.UseVisualStyleBackColor = true;
            this.lampaBtnKek.Click += new System.EventHandler(this.lampaBtnKek_Click);
            // 
            // lampaBtnPir
            // 
            this.lampaBtnPir.Location = new System.Drawing.Point(297, 29);
            this.lampaBtnPir.Name = "lampaBtnPir";
            this.lampaBtnPir.Size = new System.Drawing.Size(112, 68);
            this.lampaBtnPir.TabIndex = 7;
            this.lampaBtnPir.Text = "Piros";
            this.lampaBtnPir.UseVisualStyleBackColor = true;
            this.lampaBtnPir.Click += new System.EventHandler(this.lampaBtnPir_Click);
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
            this.lampaMentBtn.Location = new System.Drawing.Point(191, 326);
            this.lampaMentBtn.Name = "lampaMentBtn";
            this.lampaMentBtn.Size = new System.Drawing.Size(409, 112);
            this.lampaMentBtn.TabIndex = 9;
            this.lampaMentBtn.Text = "Mentés";
            this.lampaMentBtn.UseVisualStyleBackColor = true;
            this.lampaMentBtn.Click += new System.EventHandler(this.lampaMentBtn_Click);
            // 
            // aktSzinLamp
            // 
            this.aktSzinLamp.AutoSize = true;
            this.aktSzinLamp.Location = new System.Drawing.Point(339, 266);
            this.aktSzinLamp.Name = "aktSzinLamp";
            this.aktSzinLamp.Size = new System.Drawing.Size(70, 13);
            this.aktSzinLamp.TabIndex = 11;
            this.aktSzinLamp.Text = "Aktuális szín:";
            // 
            // FormLampaSzerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.aktSzinLamp);
            this.Controls.Add(this.lampaMentBtn);
            this.Controls.Add(this.lampaAzLbl);
            this.Controls.Add(this.lampaBtnPir);
            this.Controls.Add(this.lampaBtnKek);
            this.Controls.Add(this.lampaBtnUres);
            this.Controls.Add(this.lampaBtnZold);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormLampaSzerk";
            this.Text = "FormLampaSzerk";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lampaBtnZold;
        private System.Windows.Forms.Button lampaBtnUres;
        private System.Windows.Forms.Button lampaBtnKek;
        private System.Windows.Forms.Button lampaBtnPir;
        private System.Windows.Forms.Label lampaAzLbl;
        private System.Windows.Forms.Button lampaMentBtn;
        private System.Windows.Forms.Label aktSzinLamp;
    }
}