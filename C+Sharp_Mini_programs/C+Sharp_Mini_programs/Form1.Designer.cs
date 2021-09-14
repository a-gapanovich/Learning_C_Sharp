
namespace C_Sharp_Mini_programs
{
    partial class My_Form
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
            this.TSMI_Notepad = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Time = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_Data = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_help = new System.Windows.Forms.ToolStripMenuItem();
            this.TSMI_helt_about = new System.Windows.Forms.ToolStripMenuItem();
            this.Notepad = new System.Windows.Forms.TabControl();
            this.TP_Counter = new System.Windows.Forms.TabPage();
            this.LB_counter = new System.Windows.Forms.Label();
            this.BTN_reset = new System.Windows.Forms.Button();
            this.BTN_mimus = new System.Windows.Forms.Button();
            this.BTN_plus = new System.Windows.Forms.Button();
            this.TB_Generator = new System.Windows.Forms.TabPage();
            this.CB_Rand = new System.Windows.Forms.CheckBox();
            this.BT_RandCopy = new System.Windows.Forms.Button();
            this.BT_Rand_clear = new System.Windows.Forms.Button();
            this.TB_Random = new System.Windows.Forms.TextBox();
            this.NUD_down = new System.Windows.Forms.NumericUpDown();
            this.NUD_up = new System.Windows.Forms.NumericUpDown();
            this.LB_genWrite = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BTN_Generate = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.RTB_Notepad = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.Notepad.SuspendLayout();
            this.TP_Counter.SuspendLayout();
            this.TB_Generator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_down)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_up)).BeginInit();
            this.tabPage1.SuspendLayout();
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
            this.TSMI_Notepad,
            this.TSMI_help});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(535, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
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
            this.TSMI_file_exit.Size = new System.Drawing.Size(136, 26);
            this.TSMI_file_exit.Text = "Выход";
            this.TSMI_file_exit.Click += new System.EventHandler(this.TSMI_Click);
            // 
            // TSMI_Notepad
            // 
            this.TSMI_Notepad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSMI_Time,
            this.TSMI_Data,
            this.toolStripMenuItem1,
            this.cToolStripMenuItem,
            this.cToolStripMenuItem1});
            this.TSMI_Notepad.Name = "TSMI_Notepad";
            this.TSMI_Notepad.Size = new System.Drawing.Size(80, 24);
            this.TSMI_Notepad.Text = "Блокнот";
            // 
            // TSMI_Time
            // 
            this.TSMI_Time.Name = "TSMI_Time";
            this.TSMI_Time.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.T)));
            this.TSMI_Time.Size = new System.Drawing.Size(299, 26);
            this.TSMI_Time.Text = "Вставить время";
            this.TSMI_Time.Click += new System.EventHandler(this.TSMI_Time_Click);
            // 
            // TSMI_Data
            // 
            this.TSMI_Data.Name = "TSMI_Data";
            this.TSMI_Data.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
            this.TSMI_Data.Size = new System.Drawing.Size(299, 26);
            this.TSMI_Data.Text = "Вставить дату";
            this.TSMI_Data.Click += new System.EventHandler(this.TSMI_Data_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(296, 6);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(299, 26);
            this.cToolStripMenuItem.Text = "Сохранить";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.cToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem1
            // 
            this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
            this.cToolStripMenuItem1.Size = new System.Drawing.Size(299, 26);
            this.cToolStripMenuItem1.Text = "Загрузить";
            this.cToolStripMenuItem1.Click += new System.EventHandler(this.cToolStripMenuItem1_Click);
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
            this.TSMI_helt_about.Size = new System.Drawing.Size(187, 26);
            this.TSMI_helt_about.Text = "О программе";
            this.TSMI_helt_about.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Notepad
            // 
            this.Notepad.Controls.Add(this.TP_Counter);
            this.Notepad.Controls.Add(this.TB_Generator);
            this.Notepad.Controls.Add(this.tabPage1);
            this.Notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Notepad.Location = new System.Drawing.Point(0, 28);
            this.Notepad.Name = "Notepad";
            this.Notepad.SelectedIndex = 0;
            this.Notepad.Size = new System.Drawing.Size(535, 421);
            this.Notepad.TabIndex = 2;
            // 
            // TP_Counter
            // 
            this.TP_Counter.Controls.Add(this.LB_counter);
            this.TP_Counter.Controls.Add(this.BTN_reset);
            this.TP_Counter.Controls.Add(this.BTN_mimus);
            this.TP_Counter.Controls.Add(this.BTN_plus);
            this.TP_Counter.Location = new System.Drawing.Point(4, 29);
            this.TP_Counter.Name = "TP_Counter";
            this.TP_Counter.Padding = new System.Windows.Forms.Padding(3);
            this.TP_Counter.Size = new System.Drawing.Size(527, 388);
            this.TP_Counter.TabIndex = 0;
            this.TP_Counter.Text = "Счетчик";
            this.TP_Counter.UseVisualStyleBackColor = true;
            // 
            // LB_counter
            // 
            this.LB_counter.AutoSize = true;
            this.LB_counter.Font = new System.Drawing.Font("Segoe UI Historic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_counter.Location = new System.Drawing.Point(184, 159);
            this.LB_counter.Name = "LB_counter";
            this.LB_counter.Size = new System.Drawing.Size(38, 45);
            this.LB_counter.TabIndex = 3;
            this.LB_counter.Text = "0";
            // 
            // BTN_reset
            // 
            this.BTN_reset.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_reset.Location = new System.Drawing.Point(334, 154);
            this.BTN_reset.Name = "BTN_reset";
            this.BTN_reset.Size = new System.Drawing.Size(137, 59);
            this.BTN_reset.TabIndex = 2;
            this.BTN_reset.Text = "Сброс";
            this.BTN_reset.UseVisualStyleBackColor = true;
            this.BTN_reset.Click += new System.EventHandler(this.BTN_reset_Click);
            // 
            // BTN_mimus
            // 
            this.BTN_mimus.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_mimus.Location = new System.Drawing.Point(135, 256);
            this.BTN_mimus.Name = "BTN_mimus";
            this.BTN_mimus.Size = new System.Drawing.Size(137, 59);
            this.BTN_mimus.TabIndex = 1;
            this.BTN_mimus.Text = "-";
            this.BTN_mimus.UseVisualStyleBackColor = true;
            this.BTN_mimus.Click += new System.EventHandler(this.BTN_mimus_Click);
            // 
            // BTN_plus
            // 
            this.BTN_plus.Font = new System.Drawing.Font("Segoe UI Historic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_plus.Location = new System.Drawing.Point(135, 42);
            this.BTN_plus.Name = "BTN_plus";
            this.BTN_plus.Size = new System.Drawing.Size(137, 59);
            this.BTN_plus.TabIndex = 0;
            this.BTN_plus.Text = "+";
            this.BTN_plus.UseVisualStyleBackColor = true;
            this.BTN_plus.Click += new System.EventHandler(this.BTN_plus_Click);
            // 
            // TB_Generator
            // 
            this.TB_Generator.Controls.Add(this.CB_Rand);
            this.TB_Generator.Controls.Add(this.BT_RandCopy);
            this.TB_Generator.Controls.Add(this.BT_Rand_clear);
            this.TB_Generator.Controls.Add(this.TB_Random);
            this.TB_Generator.Controls.Add(this.NUD_down);
            this.TB_Generator.Controls.Add(this.NUD_up);
            this.TB_Generator.Controls.Add(this.LB_genWrite);
            this.TB_Generator.Controls.Add(this.label2);
            this.TB_Generator.Controls.Add(this.label1);
            this.TB_Generator.Controls.Add(this.BTN_Generate);
            this.TB_Generator.Location = new System.Drawing.Point(4, 29);
            this.TB_Generator.Name = "TB_Generator";
            this.TB_Generator.Padding = new System.Windows.Forms.Padding(3);
            this.TB_Generator.Size = new System.Drawing.Size(527, 388);
            this.TB_Generator.TabIndex = 1;
            this.TB_Generator.Text = "Генератор";
            this.TB_Generator.UseVisualStyleBackColor = true;
            // 
            // CB_Rand
            // 
            this.CB_Rand.AutoSize = true;
            this.CB_Rand.Location = new System.Drawing.Point(332, 172);
            this.CB_Rand.Name = "CB_Rand";
            this.CB_Rand.Size = new System.Drawing.Size(144, 24);
            this.CB_Rand.TabIndex = 9;
            this.CB_Rand.Text = "Без повторений";
            this.CB_Rand.UseVisualStyleBackColor = true;
            // 
            // BT_RandCopy
            // 
            this.BT_RandCopy.Location = new System.Drawing.Point(39, 255);
            this.BT_RandCopy.Name = "BT_RandCopy";
            this.BT_RandCopy.Size = new System.Drawing.Size(119, 36);
            this.BT_RandCopy.TabIndex = 8;
            this.BT_RandCopy.Text = "Копировать";
            this.BT_RandCopy.UseVisualStyleBackColor = true;
            this.BT_RandCopy.Click += new System.EventHandler(this.BT_RandCopy_Click);
            // 
            // BT_Rand_clear
            // 
            this.BT_Rand_clear.Location = new System.Drawing.Point(39, 213);
            this.BT_Rand_clear.Name = "BT_Rand_clear";
            this.BT_Rand_clear.Size = new System.Drawing.Size(119, 36);
            this.BT_Rand_clear.TabIndex = 7;
            this.BT_Rand_clear.Text = "Очистить";
            this.BT_Rand_clear.UseVisualStyleBackColor = true;
            this.BT_Rand_clear.Click += new System.EventHandler(this.BT_Rand_clear_Click);
            // 
            // TB_Random
            // 
            this.TB_Random.Location = new System.Drawing.Point(308, 213);
            this.TB_Random.Multiline = true;
            this.TB_Random.Name = "TB_Random";
            this.TB_Random.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_Random.Size = new System.Drawing.Size(199, 78);
            this.TB_Random.TabIndex = 6;
            // 
            // NUD_down
            // 
            this.NUD_down.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUD_down.Location = new System.Drawing.Point(70, 67);
            this.NUD_down.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUD_down.Name = "NUD_down";
            this.NUD_down.Size = new System.Drawing.Size(123, 34);
            this.NUD_down.TabIndex = 5;
            // 
            // NUD_up
            // 
            this.NUD_up.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NUD_up.Location = new System.Drawing.Point(70, 129);
            this.NUD_up.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.NUD_up.Name = "NUD_up";
            this.NUD_up.Size = new System.Drawing.Size(123, 34);
            this.NUD_up.TabIndex = 4;
            // 
            // LB_genWrite
            // 
            this.LB_genWrite.AutoSize = true;
            this.LB_genWrite.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LB_genWrite.Location = new System.Drawing.Point(218, 99);
            this.LB_genWrite.Name = "LB_genWrite";
            this.LB_genWrite.Size = new System.Drawing.Size(69, 27);
            this.LB_genWrite.TabIndex = 3;
            this.LB_genWrite.Text = "Число";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(14, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "До";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(14, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 27);
            this.label1.TabIndex = 1;
            this.label1.Text = "От";
            // 
            // BTN_Generate
            // 
            this.BTN_Generate.Font = new System.Drawing.Font("Segoe UI Emoji", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BTN_Generate.Location = new System.Drawing.Point(308, 90);
            this.BTN_Generate.Name = "BTN_Generate";
            this.BTN_Generate.Size = new System.Drawing.Size(186, 45);
            this.BTN_Generate.TabIndex = 0;
            this.BTN_Generate.Text = "Сгенерировать";
            this.BTN_Generate.UseVisualStyleBackColor = true;
            this.BTN_Generate.Click += new System.EventHandler(this.BTN_Generate_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.RTB_Notepad);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(527, 388);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Блокнот";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // RTB_Notepad
            // 
            this.RTB_Notepad.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RTB_Notepad.Location = new System.Drawing.Point(0, 0);
            this.RTB_Notepad.Name = "RTB_Notepad";
            this.RTB_Notepad.Size = new System.Drawing.Size(527, 388);
            this.RTB_Notepad.TabIndex = 0;
            this.RTB_Notepad.Text = "";
            // 
            // My_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 449);
            this.Controls.Add(this.Notepad);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "My_Form";
            this.Text = "Утилиты";
            this.Load += new System.EventHandler(this.My_Form_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.Notepad.ResumeLayout(false);
            this.TP_Counter.ResumeLayout(false);
            this.TP_Counter.PerformLayout();
            this.TB_Generator.ResumeLayout(false);
            this.TB_Generator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_down)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_up)).EndInit();
            this.tabPage1.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl Notepad;
        private System.Windows.Forms.TabPage TP_Counter;
        private System.Windows.Forms.Label LB_counter;
        private System.Windows.Forms.Button BTN_reset;
        private System.Windows.Forms.Button BTN_mimus;
        private System.Windows.Forms.Button BTN_plus;
        private System.Windows.Forms.TabPage TB_Generator;
        private System.Windows.Forms.NumericUpDown NUD_down;
        private System.Windows.Forms.NumericUpDown NUD_up;
        private System.Windows.Forms.Label LB_genWrite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BTN_Generate;
        private System.Windows.Forms.TextBox TB_Random;
        private System.Windows.Forms.Button BT_Rand_clear;
        private System.Windows.Forms.Button BT_RandCopy;
        private System.Windows.Forms.CheckBox CB_Rand;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.RichTextBox RTB_Notepad;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Notepad;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Time;
        private System.Windows.Forms.ToolStripMenuItem TSMI_Data;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem1;
    }
}

