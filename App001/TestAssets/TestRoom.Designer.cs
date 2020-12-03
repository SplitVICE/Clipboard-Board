namespace App001.UI
{
    partial class TestRoom
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
            this.button_agregar_texto = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button_INI_FILE = new System.Windows.Forms.Button();
            this.button_show_program_path = new System.Windows.Forms.Button();
            this.button_read_ini_file = new System.Windows.Forms.Button();
            this.button_read_sqlite_values = new System.Windows.Forms.Button();
            this.button_create_database_and_give_values = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_agregar_texto
            // 
            this.button_agregar_texto.Location = new System.Drawing.Point(12, 12);
            this.button_agregar_texto.Name = "button_agregar_texto";
            this.button_agregar_texto.Size = new System.Drawing.Size(75, 23);
            this.button_agregar_texto.TabIndex = 0;
            this.button_agregar_texto.Text = "Agregar";
            this.button_agregar_texto.UseVisualStyleBackColor = true;
            this.button_agregar_texto.Click += new System.EventHandler(this.button_agregar_texto_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.Location = new System.Drawing.Point(12, 77);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(203, 95);
            this.listBox.TabIndex = 2;
            this.listBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.click_on_list);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Copia al portapapeles con click";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Test random number";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_INI_FILE
            // 
            this.button_INI_FILE.Location = new System.Drawing.Point(295, 12);
            this.button_INI_FILE.Name = "button_INI_FILE";
            this.button_INI_FILE.Size = new System.Drawing.Size(75, 23);
            this.button_INI_FILE.TabIndex = 5;
            this.button_INI_FILE.Text = "Create Ini";
            this.button_INI_FILE.UseVisualStyleBackColor = true;
            this.button_INI_FILE.Click += new System.EventHandler(this.button_INI_FILE_Click);
            // 
            // button_show_program_path
            // 
            this.button_show_program_path.Location = new System.Drawing.Point(295, 53);
            this.button_show_program_path.Name = "button_show_program_path";
            this.button_show_program_path.Size = new System.Drawing.Size(75, 23);
            this.button_show_program_path.TabIndex = 6;
            this.button_show_program_path.Text = "Show program directory";
            this.button_show_program_path.UseVisualStyleBackColor = true;
            this.button_show_program_path.Click += new System.EventHandler(this.button_show_program_path_Click);
            // 
            // button_read_ini_file
            // 
            this.button_read_ini_file.Location = new System.Drawing.Point(385, 12);
            this.button_read_ini_file.Name = "button_read_ini_file";
            this.button_read_ini_file.Size = new System.Drawing.Size(75, 23);
            this.button_read_ini_file.TabIndex = 7;
            this.button_read_ini_file.Text = "Read ini file";
            this.button_read_ini_file.UseVisualStyleBackColor = true;
            this.button_read_ini_file.Click += new System.EventHandler(this.button_read_ini_file_Click);
            // 
            // button_read_sqlite_values
            // 
            this.button_read_sqlite_values.Location = new System.Drawing.Point(15, 263);
            this.button_read_sqlite_values.Name = "button_read_sqlite_values";
            this.button_read_sqlite_values.Size = new System.Drawing.Size(160, 23);
            this.button_read_sqlite_values.TabIndex = 8;
            this.button_read_sqlite_values.Text = "Read Sqlite database values";
            this.button_read_sqlite_values.UseVisualStyleBackColor = true;
            this.button_read_sqlite_values.Click += new System.EventHandler(this.button_read_sqlite_values_Click);
            // 
            // button_create_database_and_give_values
            // 
            this.button_create_database_and_give_values.Location = new System.Drawing.Point(15, 220);
            this.button_create_database_and_give_values.Name = "button_create_database_and_give_values";
            this.button_create_database_and_give_values.Size = new System.Drawing.Size(177, 23);
            this.button_create_database_and_give_values.TabIndex = 9;
            this.button_create_database_and_give_values.Text = "Create database and give values";
            this.button_create_database_and_give_values.UseVisualStyleBackColor = true;
            this.button_create_database_and_give_values.Click += new System.EventHandler(this.button_create_database_and_give_values_Click);
            // 
            // TestRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 333);
            this.Controls.Add(this.button_create_database_and_give_values);
            this.Controls.Add(this.button_read_sqlite_values);
            this.Controls.Add(this.button_read_ini_file);
            this.Controls.Add(this.button_show_program_path);
            this.Controls.Add(this.button_INI_FILE);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button_agregar_texto);
            this.Name = "TestRoom";
            this.Text = "TestRoom";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_agregar_texto;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_INI_FILE;
        private System.Windows.Forms.Button button_show_program_path;
        private System.Windows.Forms.Button button_read_ini_file;
        private System.Windows.Forms.Button button_read_sqlite_values;
        private System.Windows.Forms.Button button_create_database_and_give_values;
    }
}