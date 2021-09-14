
namespace C_Sharp_Mini_programs
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TSMI_file = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_file_exit = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_helt_about = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(115, 28);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(114, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_file,
            this.TSMI_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // TSMI_file
            // 
            this.TSMI_file.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_file_exit});
            this.TSMI_file.Name = "TSMI_file";
            this.TSMI_file.Size = new System.Drawing.Size(59, 24);
            this.TSMI_file.Text = "Файл";
            // 
            // TSMI_file_exit
            // 
            this.TSMI_file_exit.Name = "TSMI_file_exit";
            this.TSMI_file_exit.Size = new System.Drawing.Size(224, 26);
            this.TSMI_file_exit.Text = "Выход";
            this.TSMI_file_exit.Click += new System.EventHandler(this.TSMI_Click);
            // 
            // TSMI_help
            // 
            this.TSMI_help.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_helt_about});
            this.TSMI_help.Name = "TSMI_help";
            this.TSMI_help.Size = new System.Drawing.Size(83, 24);
            this.TSMI_help.Text = "Помошь";
            // 
            // TSMI_helt_about
            // 
            this.TSMI_helt_about.Name = "TSMI_helt_about";
            this.TSMI_helt_about.Size = new System.Drawing.Size(224, 26);
            this.TSMI_helt_about.Text = "О программе";
            this.TSMI_helt_about.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem TSMI_file;
        private System.Windows.Forms.ToolStripMenuItem TSMI_file_exit;
        private System.Windows.Forms.ToolStripMenuItem TSMI_help;
        private System.Windows.Forms.ToolStripMenuItem TSMI_helt_about;
    }
}

