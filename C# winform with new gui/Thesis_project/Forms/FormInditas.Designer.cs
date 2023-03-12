
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
            this.EszkozokdbTxt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Res2 = new System.Windows.Forms.Label();
            this.Eszközöknevei = new System.Windows.Forms.RichTextBox();
            this.btnFuttatas = new System.Windows.Forms.Button();
            this.utemTimer = new System.Windows.Forms.Timer(this.components);
            this.nUPTimer = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNewUtem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nUPTimer)).BeginInit();
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
            // EszkozokdbTxt
            // 
            this.EszkozokdbTxt.AutoSize = true;
            this.EszkozokdbTxt.Location = new System.Drawing.Point(12, 13);
            this.EszkozokdbTxt.Name = "EszkozokdbTxt";
            this.EszkozokdbTxt.Size = new System.Drawing.Size(91, 13);
            this.EszkozokdbTxt.TabIndex = 4;
            this.EszkozokdbTxt.Text = "Észlelt eszközök: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Eszközök nevei:";
            // 
            // Res2
            // 
            this.Res2.AutoSize = true;
            this.Res2.Location = new System.Drawing.Point(395, 13);
            this.Res2.Name = "Res2";
            this.Res2.Size = new System.Drawing.Size(0, 13);
            this.Res2.TabIndex = 2;
            // 
            // Eszközöknevei
            // 
            this.Eszközöknevei.Location = new System.Drawing.Point(103, 57);
            this.Eszközöknevei.Name = "Eszközöknevei";
            this.Eszközöknevei.Size = new System.Drawing.Size(100, 63);
            this.Eszközöknevei.TabIndex = 5;
            this.Eszközöknevei.Text = "";
            // 
            // btnFuttatas
            // 
            this.btnFuttatas.Location = new System.Drawing.Point(569, 12);
            this.btnFuttatas.Name = "btnFuttatas";
            this.btnFuttatas.Size = new System.Drawing.Size(219, 111);
            this.btnFuttatas.TabIndex = 8;
            this.btnFuttatas.Text = "Futtatás";
            this.btnFuttatas.UseVisualStyleBackColor = true;
            this.btnFuttatas.Click += new System.EventHandler(this.btnFuttatas_Click);
            // 
            // utemTimer
            // 
            this.utemTimer.Tick += new System.EventHandler(this.utemTimer_Tick);
            // 
            // nUPTimer
            // 
            this.nUPTimer.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUPTimer.Location = new System.Drawing.Point(422, 13);
            this.nUPTimer.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nUPTimer.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nUPTimer.Name = "nUPTimer";
            this.nUPTimer.Size = new System.Drawing.Size(120, 20);
            this.nUPTimer.TabIndex = 9;
            this.nUPTimer.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(433, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "ütemek közötti idő";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 128);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(776, 321);
            this.panel1.TabIndex = 11;
            // 
            // btnNewUtem
            // 
            this.btnNewUtem.Location = new System.Drawing.Point(395, 69);
            this.btnNewUtem.Name = "btnNewUtem";
            this.btnNewUtem.Size = new System.Drawing.Size(168, 53);
            this.btnNewUtem.TabIndex = 12;
            this.btnNewUtem.Text = "Új ütem hozzáadás";
            this.btnNewUtem.UseVisualStyleBackColor = true;
            this.btnNewUtem.Click += new System.EventHandler(this.btnNewUtem_Click);
            // 
            // FormInditas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnNewUtem);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nUPTimer);
            this.Controls.Add(this.btnFuttatas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eszközöknevei);
            this.Controls.Add(this.EszkozokdbTxt);
            this.Controls.Add(this.Res2);
            this.Controls.Add(this.Res);
            this.Name = "FormInditas";
            this.Text = "Gyakorlat";
            ((System.ComponentModel.ISupportInitialize)(this.nUPTimer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label EszkozokdbTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Res2;
        private System.Windows.Forms.RichTextBox Eszközöknevei;
        private System.Windows.Forms.Button btnFuttatas;
        private System.Windows.Forms.Timer utemTimer;
        private System.Windows.Forms.NumericUpDown nUPTimer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnNewUtem;
    }
}