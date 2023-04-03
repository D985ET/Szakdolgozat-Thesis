
namespace Thesis_project
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSzerkesztés = new System.Windows.Forms.Button();
            this.btnBetöltés = new System.Windows.Forms.Button();
            this.btnMentés = new System.Windows.Forms.Button();
            this.btnInditás = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizeTop = new System.Windows.Forms.Button();
            this.btnMaximizeTop = new System.Windows.Forms.Button();
            this.btnCloseTop = new System.Windows.Forms.Button();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.panelDesktopPanel = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnSzerkesztés);
            this.panelMenu.Controls.Add(this.btnBetöltés);
            this.panelMenu.Controls.Add(this.btnMentés);
            this.panelMenu.Controls.Add(this.btnInditás);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 611);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 480);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnExit.Size = new System.Drawing.Size(200, 100);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = " Kilépés";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSzerkesztés
            // 
            this.btnSzerkesztés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnSzerkesztés.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSzerkesztés.FlatAppearance.BorderSize = 0;
            this.btnSzerkesztés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSzerkesztés.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSzerkesztés.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSzerkesztés.Image = ((System.Drawing.Image)(resources.GetObject("btnSzerkesztés.Image")));
            this.btnSzerkesztés.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSzerkesztés.Location = new System.Drawing.Point(0, 380);
            this.btnSzerkesztés.Name = "btnSzerkesztés";
            this.btnSzerkesztés.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnSzerkesztés.Size = new System.Drawing.Size(200, 100);
            this.btnSzerkesztés.TabIndex = 4;
            this.btnSzerkesztés.Text = " Feladatsor Szerkesztés";
            this.btnSzerkesztés.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSzerkesztés.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSzerkesztés.UseVisualStyleBackColor = false;
            this.btnSzerkesztés.Click += new System.EventHandler(this.btnSzerkesztes_Click);
            // 
            // btnBetöltés
            // 
            this.btnBetöltés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnBetöltés.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBetöltés.FlatAppearance.BorderSize = 0;
            this.btnBetöltés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBetöltés.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBetöltés.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBetöltés.Image = ((System.Drawing.Image)(resources.GetObject("btnBetöltés.Image")));
            this.btnBetöltés.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBetöltés.Location = new System.Drawing.Point(0, 280);
            this.btnBetöltés.Name = "btnBetöltés";
            this.btnBetöltés.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnBetöltés.Size = new System.Drawing.Size(200, 100);
            this.btnBetöltés.TabIndex = 3;
            this.btnBetöltés.Text = " Feladatsor Betöltés";
            this.btnBetöltés.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBetöltés.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBetöltés.UseVisualStyleBackColor = false;
            this.btnBetöltés.Click += new System.EventHandler(this.btnBetoltes_Click);
            // 
            // btnMentés
            // 
            this.btnMentés.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnMentés.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMentés.FlatAppearance.BorderSize = 0;
            this.btnMentés.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMentés.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnMentés.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMentés.Image = ((System.Drawing.Image)(resources.GetObject("btnMentés.Image")));
            this.btnMentés.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMentés.Location = new System.Drawing.Point(0, 180);
            this.btnMentés.Name = "btnMentés";
            this.btnMentés.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnMentés.Size = new System.Drawing.Size(200, 100);
            this.btnMentés.TabIndex = 2;
            this.btnMentés.Text = " Feladatsor Mentés";
            this.btnMentés.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMentés.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMentés.UseVisualStyleBackColor = false;
            this.btnMentés.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // btnInditás
            // 
            this.btnInditás.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.btnInditás.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInditás.FlatAppearance.BorderSize = 0;
            this.btnInditás.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInditás.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInditás.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInditás.Image = ((System.Drawing.Image)(resources.GetObject("btnInditás.Image")));
            this.btnInditás.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInditás.Location = new System.Drawing.Point(0, 80);
            this.btnInditás.Name = "btnInditás";
            this.btnInditás.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnInditás.Size = new System.Drawing.Size(200, 100);
            this.btnInditás.TabIndex = 1;
            this.btnInditás.Text = " Indítás";
            this.btnInditás.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInditás.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInditás.UseVisualStyleBackColor = false;
            this.btnInditás.Click += new System.EventHandler(this.btnInditas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(60)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.panelLogo.Size = new System.Drawing.Size(200, 80);
            this.panelLogo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.Location = new System.Drawing.Point(63, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = " ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 140);
            this.button1.Name = "button1";
            this.button1.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button1.Size = new System.Drawing.Size(200, 60);
            this.button1.TabIndex = 2;
            this.button1.Text = " Tesztek";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.Gainsboro;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 200);
            this.button2.Name = "button2";
            this.button2.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button2.Size = new System.Drawing.Size(200, 60);
            this.button2.TabIndex = 3;
            this.button2.Text = " Új Gyakorlat hozzáadás";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.ForeColor = System.Drawing.Color.Gainsboro;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 260);
            this.button3.Name = "button3";
            this.button3.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.button3.Size = new System.Drawing.Size(200, 60);
            this.button3.TabIndex = 4;
            this.button3.Text = " Gyakorlatok kezelése";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DodgerBlue;
            this.panelTitleBar.Controls.Add(this.btnMinimizeTop);
            this.panelTitleBar.Controls.Add(this.btnMaximizeTop);
            this.panelTitleBar.Controls.Add(this.btnCloseTop);
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(200, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(984, 80);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizeTop
            // 
            this.btnMinimizeTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimizeTop.FlatAppearance.BorderSize = 0;
            this.btnMinimizeTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizeTop.Font = new System.Drawing.Font("Bauhaus 93", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinimizeTop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMinimizeTop.Location = new System.Drawing.Point(882, 0);
            this.btnMinimizeTop.Name = "btnMinimizeTop";
            this.btnMinimizeTop.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizeTop.TabIndex = 4;
            this.btnMinimizeTop.Text = "-̶--";
            this.btnMinimizeTop.UseVisualStyleBackColor = true;
            this.btnMinimizeTop.Click += new System.EventHandler(this.btnMinimizeTop_Click);
            // 
            // btnMaximizeTop
            // 
            this.btnMaximizeTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximizeTop.FlatAppearance.BorderSize = 0;
            this.btnMaximizeTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximizeTop.Font = new System.Drawing.Font("Bauhaus 93", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaximizeTop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnMaximizeTop.Location = new System.Drawing.Point(918, 0);
            this.btnMaximizeTop.Name = "btnMaximizeTop";
            this.btnMaximizeTop.Size = new System.Drawing.Size(30, 30);
            this.btnMaximizeTop.TabIndex = 3;
            this.btnMaximizeTop.Text = "O";
            this.btnMaximizeTop.UseVisualStyleBackColor = true;
            this.btnMaximizeTop.Click += new System.EventHandler(this.btnMaximizeTop_Click);
            // 
            // btnCloseTop
            // 
            this.btnCloseTop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCloseTop.FlatAppearance.BorderSize = 0;
            this.btnCloseTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseTop.Font = new System.Drawing.Font("Bauhaus 93", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseTop.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloseTop.Location = new System.Drawing.Point(954, 0);
            this.btnCloseTop.Name = "btnCloseTop";
            this.btnCloseTop.Size = new System.Drawing.Size(30, 30);
            this.btnCloseTop.TabIndex = 2;
            this.btnCloseTop.Text = "✖";
            this.btnCloseTop.UseVisualStyleBackColor = true;
            this.btnCloseTop.Click += new System.EventHandler(this.btnCloseTop_Click);
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = ((System.Drawing.Image)(resources.GetObject("btnCloseChildForm.Image")));
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(75, 80);
            this.btnCloseChildForm.TabIndex = 1;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Myanmar Text", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(417, 17);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(191, 48);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "SLProject_0.1";
            // 
            // panelDesktopPanel
            // 
            this.panelDesktopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPanel.Location = new System.Drawing.Point(200, 80);
            this.panelDesktopPanel.Name = "panelDesktopPanel";
            this.panelDesktopPanel.Size = new System.Drawing.Size(984, 531);
            this.panelDesktopPanel.TabIndex = 2;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 611);
            this.Controls.Add(this.panelDesktopPanel);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.MaximumSize = new System.Drawing.Size(1200, 650);
            this.MinimumSize = new System.Drawing.Size(1200, 650);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMainMenu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnInditás;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSzerkesztés;
        private System.Windows.Forms.Button btnBetöltés;
        private System.Windows.Forms.Button btnMentés;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelDesktopPanel;
        private System.Windows.Forms.Button btnCloseChildForm;
        private System.Windows.Forms.Button btnMinimizeTop;
        private System.Windows.Forms.Button btnMaximizeTop;
        private System.Windows.Forms.Button btnCloseTop;
    }
}

