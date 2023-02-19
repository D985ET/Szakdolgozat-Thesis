
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
            this.components = new System.ComponentModel.Container();
            this.Res = new System.Windows.Forms.Label();
            this.Res2 = new System.Windows.Forms.Label();
            this.EszkozokdbTxt = new System.Windows.Forms.Label();
            this.Eszközöknevei = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.lampAktSzin = new System.Windows.Forms.Label();
            this.timeMilisecBox = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.kekespiroslamp = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).BeginInit();
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
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
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
            // lampAktSzin
            // 
            this.lampAktSzin.AutoSize = true;
            this.lampAktSzin.Location = new System.Drawing.Point(511, 18);
            this.lampAktSzin.Name = "lampAktSzin";
            this.lampAktSzin.Size = new System.Drawing.Size(0, 13);
            this.lampAktSzin.TabIndex = 10;
            // 
            // timeMilisecBox
            // 
            this.timeMilisecBox.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.timeMilisecBox.Location = new System.Drawing.Point(523, 53);
            this.timeMilisecBox.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.timeMilisecBox.Name = "timeMilisecBox";
            this.timeMilisecBox.Size = new System.Drawing.Size(120, 20);
            this.timeMilisecBox.TabIndex = 11;
            this.timeMilisecBox.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.timeMilisecBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.timeMilisecBox_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Idő a váltakozás között";
            // 
            // kekespiroslamp
            // 
            this.kekespiroslamp.Location = new System.Drawing.Point(687, 53);
            this.kekespiroslamp.Name = "kekespiroslamp";
            this.kekespiroslamp.Size = new System.Drawing.Size(75, 23);
            this.kekespiroslamp.TabIndex = 13;
            this.kekespiroslamp.Text = "Lamp";
            this.kekespiroslamp.UseVisualStyleBackColor = true;
            this.kekespiroslamp.Click += new System.EventHandler(this.kekespiroslamp_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormInditas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.kekespiroslamp);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.timeMilisecBox);
            this.Controls.Add(this.lampAktSzin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eszközöknevei);
            this.Controls.Add(this.EszkozokdbTxt);
            this.Controls.Add(this.Res2);
            this.Controls.Add(this.Res);
            this.Name = "FormInditas";
            this.Text = "Gyakorlat";
            ((System.ComponentModel.ISupportInitialize)(this.timeMilisecBox)).EndInit();
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
        private System.Windows.Forms.Label lampAktSzin;
        private System.Windows.Forms.NumericUpDown timeMilisecBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button kekespiroslamp;
        private System.Windows.Forms.Timer timer1;
    }
}