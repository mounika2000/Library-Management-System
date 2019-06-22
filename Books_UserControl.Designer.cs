namespace LibraryManagementSystem
{
    partial class Books_UserControl
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
            this.booksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookid_textbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.author_textBox = new System.Windows.Forms.TextBox();
            this.publisher_textBox = new System.Windows.Forms.TextBox();
            this.isbn_textBox = new System.Windows.Forms.TextBox();
            this.name_textBox = new System.Windows.Forms.TextBox();
            this.accno_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.department_Combobox = new System.Windows.Forms.Label();
            this.dept_textBox = new System.Windows.Forms.TextBox();
            this.update_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.delete_button = new System.Windows.Forms.Button();
            this.add_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.booksToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(107, 26);
            // 
            // booksToolStripMenuItem
            // 
            this.booksToolStripMenuItem.Name = "booksToolStripMenuItem";
            this.booksToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.booksToolStripMenuItem.Text = "books";
            // 
            // bookid_textbox
            // 
            this.bookid_textbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.bookid_textbox.Location = new System.Drawing.Point(175, 21);
            this.bookid_textbox.Name = "bookid_textbox";
            this.bookid_textbox.Size = new System.Drawing.Size(305, 22);
            this.bookid_textbox.TabIndex = 2;
            this.bookid_textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(64, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Accession Number";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(41, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(409, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ISBN";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(41, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Publisher";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(409, 356);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Author";
            // 
            // author_textBox
            // 
            this.author_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.author_textBox.Location = new System.Drawing.Point(486, 353);
            this.author_textBox.Name = "author_textBox";
            this.author_textBox.Size = new System.Drawing.Size(152, 22);
            this.author_textBox.TabIndex = 8;
            // 
            // publisher_textBox
            // 
            this.publisher_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.publisher_textBox.Location = new System.Drawing.Point(104, 353);
            this.publisher_textBox.Name = "publisher_textBox";
            this.publisher_textBox.Size = new System.Drawing.Size(163, 22);
            this.publisher_textBox.TabIndex = 9;
            // 
            // isbn_textBox
            // 
            this.isbn_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.isbn_textBox.Location = new System.Drawing.Point(486, 311);
            this.isbn_textBox.Name = "isbn_textBox";
            this.isbn_textBox.Size = new System.Drawing.Size(152, 22);
            this.isbn_textBox.TabIndex = 10;
            // 
            // name_textBox
            // 
            this.name_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.name_textBox.Location = new System.Drawing.Point(104, 311);
            this.name_textBox.Name = "name_textBox";
            this.name_textBox.Size = new System.Drawing.Size(163, 22);
            this.name_textBox.TabIndex = 11;
            // 
            // accno_textbox
            // 
            this.accno_textbox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.accno_textbox.Location = new System.Drawing.Point(104, 271);
            this.accno_textbox.Name = "accno_textbox";
            this.accno_textbox.Size = new System.Drawing.Size(163, 22);
            this.accno_textbox.TabIndex = 12;
            this.accno_textbox.TextChanged += new System.EventHandler(this.accno_textbox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(41, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Acc No:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(44, 65);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(633, 144);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // department_Combobox
            // 
            this.department_Combobox.AutoSize = true;
            this.department_Combobox.BackColor = System.Drawing.Color.Transparent;
            this.department_Combobox.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.department_Combobox.ForeColor = System.Drawing.SystemColors.Control;
            this.department_Combobox.Location = new System.Drawing.Point(400, 275);
            this.department_Combobox.Name = "department_Combobox";
            this.department_Combobox.Size = new System.Drawing.Size(72, 13);
            this.department_Combobox.TabIndex = 22;
            this.department_Combobox.Text = "Department";
            this.department_Combobox.Click += new System.EventHandler(this.depa_Click);
            // 
            // dept_textBox
            // 
            this.dept_textBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.dept_textBox.Location = new System.Drawing.Point(487, 272);
            this.dept_textBox.Name = "dept_textBox";
            this.dept_textBox.Size = new System.Drawing.Size(152, 22);
            this.dept_textBox.TabIndex = 23;
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.update_button.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Image = global::LibraryManagementSystem.Properties.Resources.update;
            this.update_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.update_button.Location = new System.Drawing.Point(236, 215);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(87, 36);
            this.update_button.TabIndex = 19;
            this.update_button.Text = "Refresh";
            this.update_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.update_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.clear_button.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Image = global::LibraryManagementSystem.Properties.Resources.brrom;
            this.clear_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clear_button.Location = new System.Drawing.Point(603, 215);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(74, 36);
            this.clear_button.TabIndex = 18;
            this.clear_button.Text = "Clear";
            this.clear_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.clear_button.UseVisualStyleBackColor = false;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // delete_button
            // 
            this.delete_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.delete_button.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_button.Image = global::LibraryManagementSystem.Properties.Resources.bin4;
            this.delete_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_button.Location = new System.Drawing.Point(422, 215);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(87, 36);
            this.delete_button.TabIndex = 17;
            this.delete_button.Text = "Delete";
            this.delete_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_button.UseVisualStyleBackColor = false;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // add_button
            // 
            this.add_button.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.add_button.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_button.Image = global::LibraryManagementSystem.Properties.Resources.plus2;
            this.add_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_button.Location = new System.Drawing.Point(43, 215);
            this.add_button.Name = "add_button";
            this.add_button.Size = new System.Drawing.Size(98, 36);
            this.add_button.TabIndex = 16;
            this.add_button.Text = "Add New";
            this.add_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_button.UseVisualStyleBackColor = false;
            this.add_button.Click += new System.EventHandler(this.add_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackColor = System.Drawing.SystemColors.Control;
            this.search_button.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.Image = global::LibraryManagementSystem.Properties.Resources.search2;
            this.search_button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.search_button.Location = new System.Drawing.Point(503, 10);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(136, 41);
            this.search_button.TabIndex = 14;
            this.search_button.Text = "Search Books";
            this.search_button.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_button.UseVisualStyleBackColor = false;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // Books_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LibraryManagementSystem.Properties.Resources.digital_hexagon_abstract_background_dark_black_tone_hwvmzh_vl_thumbnail_full01;
            this.Controls.Add(this.dept_textBox);
            this.Controls.Add(this.department_Combobox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.update_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.add_button);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.accno_textbox);
            this.Controls.Add(this.name_textBox);
            this.Controls.Add(this.isbn_textBox);
            this.Controls.Add(this.publisher_textBox);
            this.Controls.Add(this.author_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bookid_textbox);
            this.Font = new System.Drawing.Font("Segoe UI Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Books_UserControl";
            this.Size = new System.Drawing.Size(712, 389);
            this.Load += new System.EventHandler(this.Books_UserControl_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.TextBox bookid_textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox author_textBox;
        private System.Windows.Forms.TextBox publisher_textBox;
        private System.Windows.Forms.TextBox isbn_textBox;
        private System.Windows.Forms.TextBox name_textBox;
        private System.Windows.Forms.TextBox accno_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button add_button;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label department_Combobox;
        private System.Windows.Forms.TextBox dept_textBox;
    }
}
