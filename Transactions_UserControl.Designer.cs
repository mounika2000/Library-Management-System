namespace LibraryManagementSystem
{
    partial class Transactions_UserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Book2_label = new System.Windows.Forms.Label();
            this.Book1_label = new System.Windows.Forms.Label();
            this.Borrowedby_label = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.borrower_id = new System.Windows.Forms.TextBox();
            this.AccNoTextField = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.searchbook_button = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SearchB_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(79, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Borrower\'s Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(57, 170);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Accesion Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(396, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Book1";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(524, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Book2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Book2_label
            // 
            this.Book2_label.AutoSize = true;
            this.Book2_label.BackColor = System.Drawing.Color.Transparent;
            this.Book2_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book2_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Book2_label.Location = new System.Drawing.Point(524, 122);
            this.Book2_label.Name = "Book2_label";
            this.Book2_label.Size = new System.Drawing.Size(55, 16);
            this.Book2_label.TabIndex = 12;
            this.Book2_label.Text = "Acc No.";
            this.Book2_label.Click += new System.EventHandler(this.Book2_label_Click);
            // 
            // Book1_label
            // 
            this.Book1_label.AutoSize = true;
            this.Book1_label.BackColor = System.Drawing.Color.Transparent;
            this.Book1_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Book1_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Book1_label.Location = new System.Drawing.Point(396, 122);
            this.Book1_label.Name = "Book1_label";
            this.Book1_label.Size = new System.Drawing.Size(55, 16);
            this.Book1_label.TabIndex = 13;
            this.Book1_label.Text = "Acc No.";
            this.Book1_label.Click += new System.EventHandler(this.Book1_label_Click);
            // 
            // Borrowedby_label
            // 
            this.Borrowedby_label.AutoSize = true;
            this.Borrowedby_label.BackColor = System.Drawing.Color.Transparent;
            this.Borrowedby_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Borrowedby_label.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Borrowedby_label.Location = new System.Drawing.Point(468, 227);
            this.Borrowedby_label.Name = "Borrowedby_label";
            this.Borrowedby_label.Size = new System.Drawing.Size(84, 16);
            this.Borrowedby_label.TabIndex = 15;
            this.Borrowedby_label.Text = "Borrowed by";
            this.Borrowedby_label.Click += new System.EventHandler(this.Borrowedby_label_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(461, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Borrowed  By";
            // 
            // borrower_id
            // 
            this.borrower_id.Location = new System.Drawing.Point(227, 43);
            this.borrower_id.Name = "borrower_id";
            this.borrower_id.Size = new System.Drawing.Size(246, 20);
            this.borrower_id.TabIndex = 16;
            // 
            // AccNoTextField
            // 
            this.AccNoTextField.Location = new System.Drawing.Point(227, 168);
            this.AccNoTextField.Name = "AccNoTextField";
            this.AccNoTextField.Size = new System.Drawing.Size(246, 20);
            this.AccNoTextField.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(281, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(81, 38);
            this.button2.TabIndex = 25;
            this.button2.Text = "Clear";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(433, 295);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 24;
            this.button1.Text = "Return Book";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // searchbook_button
            // 
            this.searchbook_button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.searchbook_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbook_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.searchbook_button.Location = new System.Drawing.Point(163, 199);
            this.searchbook_button.Name = "searchbook_button";
            this.searchbook_button.Size = new System.Drawing.Size(138, 41);
            this.searchbook_button.TabIndex = 23;
            this.searchbook_button.Text = "Search Book";
            this.searchbook_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.searchbook_button.UseVisualStyleBackColor = false;
            this.searchbook_button.Click += new System.EventHandler(this.button5_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(61, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 34);
            this.button3.TabIndex = 21;
            this.button3.Text = "Issue Book";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SearchB_Button
            // 
            this.SearchB_Button.BackColor = System.Drawing.SystemColors.ControlLight;
            this.SearchB_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchB_Button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SearchB_Button.Location = new System.Drawing.Point(134, 96);
            this.SearchB_Button.Name = "SearchB_Button";
            this.SearchB_Button.Size = new System.Drawing.Size(177, 41);
            this.SearchB_Button.TabIndex = 18;
            this.SearchB_Button.Text = "Search Borrowers";
            this.SearchB_Button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SearchB_Button.UseVisualStyleBackColor = false;
            this.SearchB_Button.Click += new System.EventHandler(this.SearchB_Button_Click);
            // 
            // Transactions_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.searchbook_button);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.SearchB_Button);
            this.Controls.Add(this.AccNoTextField);
            this.Controls.Add(this.borrower_id);
            this.Controls.Add(this.Borrowedby_label);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Book1_label);
            this.Controls.Add(this.Book2_label);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Name = "Transactions_UserControl";
            this.Size = new System.Drawing.Size(712, 389);
            this.Load += new System.EventHandler(this.Transactions_UserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Book2_label;
        private System.Windows.Forms.Label Book1_label;
        private System.Windows.Forms.Label Borrowedby_label;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox borrower_id;
        private System.Windows.Forms.TextBox AccNoTextField;
        private System.Windows.Forms.Button SearchB_Button;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button searchbook_button;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}
