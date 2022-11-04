
namespace Thesis_project.Forms
{
    partial class FormGyakorlat
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
            this.Eszk_feltolt_BTN = new System.Windows.Forms.Button();
            this.EszkozokdbTxt = new System.Windows.Forms.Label();
            this.Eszközöknevei = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
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
            // Eszk_feltolt_BTN
            // 
            this.Eszk_feltolt_BTN.Location = new System.Drawing.Point(12, 13);
            this.Eszk_feltolt_BTN.Name = "Eszk_feltolt_BTN";
            this.Eszk_feltolt_BTN.Size = new System.Drawing.Size(139, 60);
            this.Eszk_feltolt_BTN.TabIndex = 3;
            this.Eszk_feltolt_BTN.Text = "Eszközök felmérése (Valid eszközök nélkül)";
            this.Eszk_feltolt_BTN.UseVisualStyleBackColor = true;
            this.Eszk_feltolt_BTN.Click += new System.EventHandler(this.Eszk_feltolt_BTN_Click);
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
            // FormGyakorlat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Eszközöknevei);
            this.Controls.Add(this.EszkozokdbTxt);
            this.Controls.Add(this.Eszk_feltolt_BTN);
            this.Controls.Add(this.Res2);
            this.Controls.Add(this.Res);
            this.Name = "FormGyakorlat";
            this.Text = "Gyakorlat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Res;
        private System.Windows.Forms.Label Res2;
        private System.Windows.Forms.Button Eszk_feltolt_BTN;
        private System.Windows.Forms.Label EszkozokdbTxt;
        private System.Windows.Forms.RichTextBox Eszközöknevei;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
    }
}