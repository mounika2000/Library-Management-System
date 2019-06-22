namespace LibraryManagementSystem
{
    partial class AppBody
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
            this.Log_in_Timer = new System.Windows.Forms.Timer(this.components);
            this.TitleBar = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CloseButton = new System.Windows.Forms.Button();
            this.LOgOffButton = new System.Windows.Forms.Button();
            this.slidingpanneltimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.SettingButton = new System.Windows.Forms.Button();
            this.AboutTabButton = new System.Windows.Forms.Button();
            this.BorrowersTabButton = new System.Windows.Forms.Button();
            this.BooksTabButton = new System.Windows.Forms.Button();
            this.TransactionTabButton = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggleButton = new System.Windows.Forms.Button();
            this.TitleBar.SuspendLayout();
            this.ContentPanel.SuspendLayout();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Log_in_Timer
            // 
            this.Log_in_Timer.Interval = 25;
            this.Log_in_Timer.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // TitleBar
            // 
            this.TitleBar.BackColor = System.Drawing.Color.Black;
            this.TitleBar.Controls.Add(this.MinimizeButton);
            this.TitleBar.Controls.Add(this.CloseButton);
            this.TitleBar.Controls.Add(this.LOgOffButton);
            this.TitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitleBar.Location = new System.Drawing.Point(0, 0);
            this.TitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.TitleBar.Name = "TitleBar";
            this.TitleBar.Size = new System.Drawing.Size(912, 37);
            this.TitleBar.TabIndex = 0;
            this.TitleBar.Paint += new System.Windows.Forms.PaintEventHandler(this.TitleBar_Paint);
            this.TitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TitleBar_MouseDown);
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.aas;
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MinimizeButton.Location = new System.Drawing.Point(848, 3);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(4);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(31, 31);
            this.MinimizeButton.TabIndex = 3;
            this.MinimizeButton.UseVisualStyleBackColor = true;
            this.MinimizeButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.cross;
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Location = new System.Drawing.Point(876, -1);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(32, 35);
            this.CloseButton.TabIndex = 1;
            this.CloseButton.UseVisualStyleBackColor = true;
            this.CloseButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // LOgOffButton
            // 
            this.LOgOffButton.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.jjd;
            this.LOgOffButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LOgOffButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LOgOffButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LOgOffButton.Location = new System.Drawing.Point(820, 4);
            this.LOgOffButton.Margin = new System.Windows.Forms.Padding(4);
            this.LOgOffButton.Name = "LOgOffButton";
            this.LOgOffButton.Size = new System.Drawing.Size(31, 30);
            this.LOgOffButton.TabIndex = 2;
            this.LOgOffButton.UseVisualStyleBackColor = true;
            this.LOgOffButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // slidingpanneltimer
            // 
            this.slidingpanneltimer.Tick += new System.EventHandler(this.slidingpanneltimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.digital_hexagon_abstract_background_dark_black_tone_hwvmzh_vl_thumbnail_full01;
            this.ContentPanel.Controls.Add(this.richTextBox1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(199, 37);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(713, 441);
            this.ContentPanel.TabIndex = 2;
            this.ContentPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ContentPanel_Paint);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox1.Font = new System.Drawing.Font("Consolas", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.richTextBox1.Location = new System.Drawing.Point(127, 109);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(279, 220);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "Library Management System";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SlidingPanel.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.sdj;
            this.SlidingPanel.Controls.Add(this.SettingButton);
            this.SlidingPanel.Controls.Add(this.AboutTabButton);
            this.SlidingPanel.Controls.Add(this.BorrowersTabButton);
            this.SlidingPanel.Controls.Add(this.BooksTabButton);
            this.SlidingPanel.Controls.Add(this.TransactionTabButton);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 37);
            this.SlidingPanel.Margin = new System.Windows.Forms.Padding(4);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(202, 441);
            this.SlidingPanel.TabIndex = 1;
            this.SlidingPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SettingButton.Image = global::LibraryManagementSystem.Properties.Resources.set;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingButton.Location = new System.Drawing.Point(2, 227);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(200, 52);
            this.SettingButton.TabIndex = 6;
            this.SettingButton.Text = "Settings";
            this.SettingButton.UseVisualStyleBackColor = false;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click_1);
            // 
            // AboutTabButton
            // 
            this.AboutTabButton.BackColor = System.Drawing.Color.Transparent;
            this.AboutTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutTabButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.AboutTabButton.Image = global::LibraryManagementSystem.Properties.Resources.info;
            this.AboutTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutTabButton.Location = new System.Drawing.Point(0, 283);
            this.AboutTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.AboutTabButton.Name = "AboutTabButton";
            this.AboutTabButton.Size = new System.Drawing.Size(200, 52);
            this.AboutTabButton.TabIndex = 5;
            this.AboutTabButton.Text = "About";
            this.AboutTabButton.UseVisualStyleBackColor = false;
            this.AboutTabButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // BorrowersTabButton
            // 
            this.BorrowersTabButton.BackColor = System.Drawing.Color.Transparent;
            this.BorrowersTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BorrowersTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BorrowersTabButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BorrowersTabButton.Image = global::LibraryManagementSystem.Properties.Resources.people;
            this.BorrowersTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BorrowersTabButton.Location = new System.Drawing.Point(0, 112);
            this.BorrowersTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.BorrowersTabButton.Name = "BorrowersTabButton";
            this.BorrowersTabButton.Size = new System.Drawing.Size(200, 52);
            this.BorrowersTabButton.TabIndex = 3;
            this.BorrowersTabButton.Text = "Borrowers";
            this.BorrowersTabButton.UseVisualStyleBackColor = false;
            this.BorrowersTabButton.Click += new System.EventHandler(this.BorrowersTabButton_Click);
            // 
            // BooksTabButton
            // 
            this.BooksTabButton.BackColor = System.Drawing.Color.Transparent;
            this.BooksTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BooksTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BooksTabButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BooksTabButton.Image = global::LibraryManagementSystem.Properties.Resources.book;
            this.BooksTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BooksTabButton.Location = new System.Drawing.Point(0, 55);
            this.BooksTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.BooksTabButton.Name = "BooksTabButton";
            this.BooksTabButton.Size = new System.Drawing.Size(200, 52);
            this.BooksTabButton.TabIndex = 2;
            this.BooksTabButton.Text = "Books\r\n";
            this.BooksTabButton.UseVisualStyleBackColor = false;
            this.BooksTabButton.Click += new System.EventHandler(this.BooksTabButton_Click);
            // 
            // TransactionTabButton
            // 
            this.TransactionTabButton.BackColor = System.Drawing.Color.Transparent;
            this.TransactionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TransactionTabButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransactionTabButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TransactionTabButton.Image = global::LibraryManagementSystem.Properties.Resources.trans;
            this.TransactionTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TransactionTabButton.Location = new System.Drawing.Point(2, 169);
            this.TransactionTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.TransactionTabButton.Name = "TransactionTabButton";
            this.TransactionTabButton.Size = new System.Drawing.Size(198, 52);
            this.TransactionTabButton.TabIndex = 1;
            this.TransactionTabButton.Text = "Transaction";
            this.TransactionTabButton.UseVisualStyleBackColor = false;
            this.TransactionTabButton.Click += new System.EventHandler(this.TransactionTabButton_Click);
            // 
            // SlidingPanel_ToggleButton
            // 
            this.SlidingPanel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggleButton.Image = global::LibraryManagementSystem.Properties.Resources.left2;
            this.SlidingPanel_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingPanel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel_ToggleButton.Margin = new System.Windows.Forms.Padding(4);
            this.SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            this.SlidingPanel_ToggleButton.Size = new System.Drawing.Size(200, 52);
            this.SlidingPanel_ToggleButton.TabIndex = 0;
            this.SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggleButton.Click += new System.EventHandler(this.SlidingPanel_ToggleButton_Click);
            // 
            // AppBody
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.digital_hexagon_abstract_background_dark_black_tone_hwvmzh_vl_thumbnail_full01;
            this.ClientSize = new System.Drawing.Size(912, 478);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Controls.Add(this.TitleBar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AppBody";
            this.RightToLeftLayout = true;
            this.Text = "AppBody";
            this.Load += new System.EventHandler(this.AppBody_Load);
            this.TitleBar.ResumeLayout(false);
            this.ContentPanel.ResumeLayout(false);
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Log_in_Timer;
        private System.Windows.Forms.Panel TitleBar;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button LOgOffButton;
        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Timer slidingpanneltimer;
        private System.Windows.Forms.Button AboutTabButton;
        private System.Windows.Forms.Button BorrowersTabButton;
        private System.Windows.Forms.Button BooksTabButton;
        private System.Windows.Forms.Button TransactionTabButton;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button SettingButton;
    }
}