
namespace Thesis_project.Forms
{
    partial class FormSzerkesztes
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
            this.dataGridSzerkesztes = new System.Windows.Forms.DataGridView();
            this.btnFuttatasSzerk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSzerkesztes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridSzerkesztes
            // 
            this.dataGridSzerkesztes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSzerkesztes.Location = new System.Drawing.Point(16, 59);
            this.dataGridSzerkesztes.Name = "dataGridSzerkesztes";
            this.dataGridSzerkesztes.Size = new System.Drawing.Size(610, 353);
            this.dataGridSzerkesztes.TabIndex = 1;
            this.dataGridSzerkesztes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridSzerkesztes_CellContentClick);
            // 
            // btnFuttatasSzerk
            // 
            this.btnFuttatasSzerk.Location = new System.Drawing.Point(458, 12);
            this.btnFuttatasSzerk.Name = "btnFuttatasSzerk";
            this.btnFuttatasSzerk.Size = new System.Drawing.Size(168, 43);
            this.btnFuttatasSzerk.TabIndex = 9;
            this.btnFuttatasSzerk.Text = "Futtatás";
            this.btnFuttatasSzerk.UseVisualStyleBackColor = true;
            this.btnFuttatasSzerk.Click += new System.EventHandler(this.btnFuttatasSzerk_Click);
            // 
            // FormSzerkesztes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 424);
            this.Controls.Add(this.btnFuttatasSzerk);
            this.Controls.Add(this.dataGridSzerkesztes);
            this.Name = "FormSzerkesztes";
            this.Text = "FormSzerkesztes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSzerkesztes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridSzerkesztes;
        private System.Windows.Forms.Button btnFuttatasSzerk;
    }
}