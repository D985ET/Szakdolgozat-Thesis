
namespace Thesis_project.Forms
{
    partial class FormInditas
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
            this.Res = new System.Windows.Forms.Label();
            this.Res2 = new System.Windows.Forms.Label();
            this.EszkozokdbTxt = new System.Windows.Forms.Label();
            this.Eszközöknevei = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKekLampa = new System.Windows.Forms.Button();
            this.nyilUres = new System.Windows.Forms.Button();
            this.hangszOn = new System.Windows.Forms.Button();
            this.hangszOff = new System.Windows.Forms.Button();
            this.kekLampa = new System.Windows.Forms.Button();
            this.lampaUres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Res
            // 
            this.Res.AutoSize = true;
            this.Res.Location = new System.Drawing.Point(335, 13);
            this.Res.Name = "Res";
            this.Res.Size = new System.Drawing.Size(0, 13);
            this.Res.TabIndex = 1;
            // 
            // Res2
            // 
            this.Res2.AutoSize = true;
            this.Res2.Location = new System.Drawing.Point(395, 13);
            this.Res2.Name = "Res2";
            this.Res2.Size = new System.Drawing.Size(0, 13);
            this.Res2.TabIndex = 2;
            // 
            // EszkozokdbTxt
            // 
            this.EszkozokdbTxt.AutoSize = true;
            this.EszkozokdbTxt.Location = new System.Drawing.Point(171, 13);
            this.EszkozokdbTxt.Name = "EszkozokdbTxt";
            this.EszkozokdbTxt.Size = new System.Drawing.Size(91, 13);
            this.EszkozokdbTxt.TabIndex = 4;
            this.EszkozokdbTxt.Text = "Észlelt eszközök: ";
            // 
            // Eszközöknevei
            // 
            this.Eszközöknevei.Location = new System.Drawing.Point(275, 60);
            this.Eszközöknevei.Name = "Eszközöknevei";
            this.Eszközöknevei.Size = new System.Drawing.Size(100, 63);
            this.Eszközöknevei.TabIndex = 5;
            this.Eszközöknevei.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(171, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eszközök nevei:";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(13, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 283);
            this.panel1.TabIndex = 7;
            // 
            // btnKekLampa
            // 
            this.btnKekLampa.Location = new System.Drawing.Point(509, 13);
            this.btnKekLampa.Name = "btnKekLampa";
            this.btnKekLampa.Size = new System.Drawing.Size(75, 23);
            this.btnKekLampa.TabIndex = 8;
            this.btnKekLampa.Text = "kekNyil";
            this.btnKekLampa.UseVisualStyleBackColor = true;
            this.btnKekLampa.Click += new System.EventHandler(this.nyilKek_Click);
            // 
            // nyilUres
            // 
            this.nyilUres.Location = new System.Drawing.Point(607, 12);
            this.nyilUres.Name = "nyilUres";
            this.nyilUres.Size = new System.Drawing.Size(75, 23);
            this.nyilUres.TabIndex = 9;
            this.nyilUres.Text = "kikapcsNyil";
            this.nyilUres.UseVisualStyleBackColor = true;
            this.nyilUres.Click += new System.EventHandler(this.nyilUres_Click);
            // 
            // hangszOn
            // 
            this.hangszOn.Location = new System.Drawing.Point(509, 58);
            this.hangszOn.Name = "hangszOn";
            this.hangszOn.Size = new System.Drawing.Size(75, 23);
            this.hangszOn.TabIndex = 10;
            this.hangszOn.Text = "hangszOn";
            this.hangszOn.UseVisualStyleBackColor = true;
            this.hangszOn.Click += new System.EventHandler(this.hangszOn_Click);
            // 
            // hangszOff
            // 
            this.hangszOff.Location = new System.Drawing.Point(607, 58);
            this.hangszOff.Name = "hangszOff";
            this.hangszOff.Size = new System.Drawing.Size(75, 23);
            this.hangszOff.TabIndex = 11;
            this.hangszOff.Text = "hangszOff";
            this.hangszOff.UseVisualStyleBackColor = true;
            this.hangszOff.Click += new System.EventHandler(this.hangszOff_Click);
            // 
            // kekLampa
            // 
            this.kekLampa.Location = new System.Drawing.Point(509, 100);
            this.kekLampa.Name = "kekLampa";
            this.kekLampa.Size = new System.Drawing.Size(75, 23);
            this.kekLampa.TabIndex = 12;
            this.kekLampa.Text = "kekLampa";
            this.kekLampa.UseVisualStyleBackColor = true;
            this.kekLampa.Click += new System.EventHandler(this.kekLampa_Click);
            // 
            // lampaUres
            // 
            this.lampaUres.Location = new System.Drawing.Point(607, 100);
            this.lampaUres.Name = "lampaUres";
            this.lampaUres.Size = new System.Drawing.Size(75, 23);
            this.lampaUres.TabIndex = 13;
            this.lampaUres.Text = "kikapcsLamp";
            this.lampaUres.UseVisualStyleBackColor = true;
            this.lampaUres.Click += new System.EventHandler(this.lampaUres_Click);
            // 
            // FormInditas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lampaUres);
            this.Controls.Add(this.kekLampa);
            this.Controls.Add(this.hangszOff);
            this.Controls.Add(this.hangszOn);
            this.Controls.Add(this.nyilUres);
            this.Controls.Add(this.btnKekLampa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eszközöknevei);
            this.Controls.Add(this.EszkozokdbTxt);
            this.Controls.Add(this.Res2);
            this.Controls.Add(this.Res);
            this.Name = "FormInditas";
            this.Text = "Gyakorlat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label Res2;
        private System.Windows.Forms.Label EszkozokdbTxt;
        private System.Windows.Forms.RichTextBox Eszközöknevei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnKekLampa;
        private System.Windows.Forms.Button nyilUres;
        private System.Windows.Forms.Button hangszOn;
        private System.Windows.Forms.Button hangszOff;
        private System.Windows.Forms.Button kekLampa;
        private System.Windows.Forms.Button lampaUres;
    }
}