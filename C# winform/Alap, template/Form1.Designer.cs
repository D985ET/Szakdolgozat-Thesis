
namespace Alap__template
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközökFelméréseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eszközökInicializálásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kilépésAProgrambólToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tesztekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.csoportküldésTeszteléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programKészítéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ütemHozzáadásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programokKezeléseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatsorBetöltéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatsorMentéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatsorSzerkesztéseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feladatsorFuttatásaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.BTN_save = new System.Windows.Forms.Button();
            this.BTNopen = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.Panel2 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.tesztekToolStripMenuItem,
            this.programKészítéseToolStripMenuItem,
            this.programokKezeléseToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(854, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eszközökFelméréseToolStripMenuItem,
            this.eszközökInicializálásaToolStripMenuItem,
            this.kilépésAProgrambólToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // eszközökFelméréseToolStripMenuItem
            // 
            this.eszközökFelméréseToolStripMenuItem.Name = "eszközökFelméréseToolStripMenuItem";
            this.eszközökFelméréseToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eszközökFelméréseToolStripMenuItem.Text = "Eszközök felmérése";
            this.eszközökFelméréseToolStripMenuItem.Click += new System.EventHandler(this.eszközökFelméréseToolStripMenuItem_Click);
            // 
            // eszközökInicializálásaToolStripMenuItem
            // 
            this.eszközökInicializálásaToolStripMenuItem.Name = "eszközökInicializálásaToolStripMenuItem";
            this.eszközökInicializálásaToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.eszközökInicializálásaToolStripMenuItem.Text = "Eszközök inicializálása";
            this.eszközökInicializálásaToolStripMenuItem.Click += new System.EventHandler(this.eszközökInicializálásaToolStripMenuItem_Click);
            // 
            // kilépésAProgrambólToolStripMenuItem
            // 
            this.kilépésAProgrambólToolStripMenuItem.Name = "kilépésAProgrambólToolStripMenuItem";
            this.kilépésAProgrambólToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.kilépésAProgrambólToolStripMenuItem.Text = "Kilépés a programból";
            this.kilépésAProgrambólToolStripMenuItem.Click += new System.EventHandler(this.kilépésAProgrambólToolStripMenuItem_Click);
            // 
            // tesztekToolStripMenuItem
            // 
            this.tesztekToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csoportküldésTeszteléseToolStripMenuItem});
            this.tesztekToolStripMenuItem.Name = "tesztekToolStripMenuItem";
            this.tesztekToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.tesztekToolStripMenuItem.Text = "Tesztek";
            // 
            // csoportküldésTeszteléseToolStripMenuItem
            // 
            this.csoportküldésTeszteléseToolStripMenuItem.Name = "csoportküldésTeszteléseToolStripMenuItem";
            this.csoportküldésTeszteléseToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.csoportküldésTeszteléseToolStripMenuItem.Text = "Csoportküldés tesztelése";
            this.csoportküldésTeszteléseToolStripMenuItem.Click += new System.EventHandler(this.csoportküldésTeszteléseToolStripMenuItem_Click);
            // 
            // programKészítéseToolStripMenuItem
            // 
            this.programKészítéseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ütemHozzáadásaToolStripMenuItem});
            this.programKészítéseToolStripMenuItem.Name = "programKészítéseToolStripMenuItem";
            this.programKészítéseToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.programKészítéseToolStripMenuItem.Text = "Program készítése";
            // 
            // ütemHozzáadásaToolStripMenuItem
            // 
            this.ütemHozzáadásaToolStripMenuItem.Name = "ütemHozzáadásaToolStripMenuItem";
            this.ütemHozzáadásaToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.ütemHozzáadásaToolStripMenuItem.Text = "Ütem hozzáadása";
            this.ütemHozzáadásaToolStripMenuItem.Click += new System.EventHandler(this.ütemHozzáadásaToolStripMenuItem_Click);
            // 
            // programokKezeléseToolStripMenuItem
            // 
            this.programokKezeléseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feladatsorBetöltéseToolStripMenuItem,
            this.feladatsorMentéseToolStripMenuItem,
            this.feladatsorSzerkesztéseToolStripMenuItem,
            this.feladatsorFuttatásaToolStripMenuItem});
            this.programokKezeléseToolStripMenuItem.Name = "programokKezeléseToolStripMenuItem";
            this.programokKezeléseToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.programokKezeléseToolStripMenuItem.Text = "Programok kezelése";
            // 
            // feladatsorBetöltéseToolStripMenuItem
            // 
            this.feladatsorBetöltéseToolStripMenuItem.Name = "feladatsorBetöltéseToolStripMenuItem";
            this.feladatsorBetöltéseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.feladatsorBetöltéseToolStripMenuItem.Text = "Feladatsor betöltése";
            // 
            // feladatsorMentéseToolStripMenuItem
            // 
            this.feladatsorMentéseToolStripMenuItem.Name = "feladatsorMentéseToolStripMenuItem";
            this.feladatsorMentéseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.feladatsorMentéseToolStripMenuItem.Text = "Feladatsor mentése";
            // 
            // feladatsorSzerkesztéseToolStripMenuItem
            // 
            this.feladatsorSzerkesztéseToolStripMenuItem.Name = "feladatsorSzerkesztéseToolStripMenuItem";
            this.feladatsorSzerkesztéseToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.feladatsorSzerkesztéseToolStripMenuItem.Text = "Feladatsor szerkesztése";
            // 
            // feladatsorFuttatásaToolStripMenuItem
            // 
            this.feladatsorFuttatásaToolStripMenuItem.Name = "feladatsorFuttatásaToolStripMenuItem";
            this.feladatsorFuttatásaToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.feladatsorFuttatásaToolStripMenuItem.Text = "Feladatsor futtatása";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Információs sáv";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "Rich Text Format (.rtf)|*.rtf|Png Image (.png)|*.png|C#files|*.cs|All files|*.*";
            // 
            // BTN_save
            // 
            this.BTN_save.Location = new System.Drawing.Point(97, 37);
            this.BTN_save.Name = "BTN_save";
            this.BTN_save.Size = new System.Drawing.Size(43, 23);
            this.BTN_save.TabIndex = 3;
            this.BTN_save.Text = "&Save";
            this.BTN_save.UseVisualStyleBackColor = true;
            this.BTN_save.Click += new System.EventHandler(this.BTN_save_Click);
            // 
            // BTNopen
            // 
            this.BTNopen.Location = new System.Drawing.Point(146, 37);
            this.BTNopen.Name = "BTNopen";
            this.BTNopen.Size = new System.Drawing.Size(43, 23);
            this.BTNopen.TabIndex = 4;
            this.BTNopen.Text = "&Open";
            this.BTNopen.UseVisualStyleBackColor = true;
            this.BTNopen.Click += new System.EventHandler(this.BTNopen_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "Rich Text Format (.rtf)|*.rtf|Png Image (.png)|*.png|C#files|*.cs|All files|*.*";
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(392, 37);
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(414, 45);
            this.trackBar.TabIndex = 6;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 66);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(830, 412);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(822, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ütemek beállítása";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(822, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Programszöveg";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // Panel2
            // 
            this.Panel2.Location = new System.Drawing.Point(311, 37);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(75, 23);
            this.Panel2.TabIndex = 8;
            this.Panel2.Text = "&mainPanel";
            this.Panel2.UseVisualStyleBackColor = true;
            this.Panel2.Click += new System.EventHandler(this.Panel2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 490);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.BTNopen);
            this.Controls.Add(this.BTN_save);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszközökFelméréseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eszközökInicializálásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kilépésAProgrambólToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tesztekToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem csoportküldésTeszteléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programKészítéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ütemHozzáadásaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem programokKezeléseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatsorBetöltéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatsorMentéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatsorSzerkesztéseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feladatsorFuttatásaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Button BTN_save;
        private System.Windows.Forms.Button BTNopen;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Button Panel2;
    }
}

