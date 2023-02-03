
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
            this.label2 = new System.Windows.Forms.Label();
            this.lampEllenBtn = new System.Windows.Forms.Button();
            this.lampAktSzin = new System.Windows.Forms.Label();
            this.utemFuttLmpBtn = new System.Windows.Forms.Button();
            this.nyilEllenBtn = new System.Windows.Forms.Button();
            this.hangszEllenBtn = new System.Windows.Forms.Button();
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
            this.panel1.Location = new System.Drawing.Point(13, 129);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 309);
            this.panel1.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(416, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Lámpa színe:";
            // 
            // lampEllenBtn
            // 
            this.lampEllenBtn.Location = new System.Drawing.Point(659, 12);
            this.lampEllenBtn.Name = "lampEllenBtn";
            this.lampEllenBtn.Size = new System.Drawing.Size(129, 23);
            this.lampEllenBtn.TabIndex = 9;
            this.lampEllenBtn.Text = "lampaEllenőrzés";
            this.lampEllenBtn.UseVisualStyleBackColor = true;
            this.lampEllenBtn.Click += new System.EventHandler(this.lampEllenBtn_Click);
            // 
            // lampAktSzin
            // 
            this.lampAktSzin.AutoSize = true;
            this.lampAktSzin.Location = new System.Drawing.Point(511, 18);
            this.lampAktSzin.Name = "lampAktSzin";
            this.lampAktSzin.Size = new System.Drawing.Size(0, 13);
            this.lampAktSzin.TabIndex = 10;
            // 
            // utemFuttLmpBtn
            // 
            this.utemFuttLmpBtn.Location = new System.Drawing.Point(659, 100);
            this.utemFuttLmpBtn.Name = "utemFuttLmpBtn";
            this.utemFuttLmpBtn.Size = new System.Drawing.Size(75, 23);
            this.utemFuttLmpBtn.TabIndex = 11;
            this.utemFuttLmpBtn.Text = "utemFuttatas";
            this.utemFuttLmpBtn.UseVisualStyleBackColor = true;
            this.utemFuttLmpBtn.Click += new System.EventHandler(this.utemFuttLmpBtn_Click);
            // 
            // nyilEllenBtn
            // 
            this.nyilEllenBtn.Location = new System.Drawing.Point(659, 41);
            this.nyilEllenBtn.Name = "nyilEllenBtn";
            this.nyilEllenBtn.Size = new System.Drawing.Size(129, 23);
            this.nyilEllenBtn.TabIndex = 12;
            this.nyilEllenBtn.Text = "nyilEllenőrzés";
            this.nyilEllenBtn.UseVisualStyleBackColor = true;
            this.nyilEllenBtn.Click += new System.EventHandler(this.nyilEllenBtn_Click);
            // 
            // hangszEllenBtn
            // 
            this.hangszEllenBtn.Location = new System.Drawing.Point(659, 71);
            this.hangszEllenBtn.Name = "hangszEllenBtn";
            this.hangszEllenBtn.Size = new System.Drawing.Size(129, 23);
            this.hangszEllenBtn.TabIndex = 13;
            this.hangszEllenBtn.Text = "hangszEllenőrzés";
            this.hangszEllenBtn.UseVisualStyleBackColor = true;
            this.hangszEllenBtn.Click += new System.EventHandler(this.hangszEllenBtn_Click);
            // 
            // FormInditas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hangszEllenBtn);
            this.Controls.Add(this.nyilEllenBtn);
            this.Controls.Add(this.utemFuttLmpBtn);
            this.Controls.Add(this.lampAktSzin);
            this.Controls.Add(this.lampEllenBtn);
            this.Controls.Add(this.label2);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button lampEllenBtn;
        private System.Windows.Forms.Label lampAktSzin;
        private System.Windows.Forms.Button utemFuttLmpBtn;
        private System.Windows.Forms.Button nyilEllenBtn;
        private System.Windows.Forms.Button hangszEllenBtn;
    }
}