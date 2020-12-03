namespace App001.UI
{
    partial class MainSettings
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_settings_title = new System.Windows.Forms.Label();
            this.label_separator = new System.Windows.Forms.Label();
            this.button_delete_all_data = new System.Windows.Forms.Button();
            this.button_dark_light_mode_toggle = new System.Windows.Forms.Button();
            this.button_change_language = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_settings_title
            // 
            this.label_settings_title.AutoSize = true;
            this.label_settings_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_settings_title.Location = new System.Drawing.Point(14, 4);
            this.label_settings_title.Name = "label_settings_title";
            this.label_settings_title.Size = new System.Drawing.Size(76, 24);
            this.label_settings_title.TabIndex = 0;
            this.label_settings_title.Text = "Settings";
            // 
            // label_separator
            // 
            this.label_separator.AutoSize = true;
            this.label_separator.Location = new System.Drawing.Point(8, 28);
            this.label_separator.Name = "label_separator";
            this.label_separator.Size = new System.Drawing.Size(517, 13);
            this.label_separator.TabIndex = 3;
            this.label_separator.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // button_delete_all_data
            // 
            this.button_delete_all_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_delete_all_data.FlatAppearance.BorderSize = 0;
            this.button_delete_all_data.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_all_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_delete_all_data.Location = new System.Drawing.Point(18, 301);
            this.button_delete_all_data.Name = "button_delete_all_data";
            this.button_delete_all_data.Size = new System.Drawing.Size(507, 81);
            this.button_delete_all_data.TabIndex = 4;
            this.button_delete_all_data.Text = "Delete all data";
            this.button_delete_all_data.UseVisualStyleBackColor = false;
            this.button_delete_all_data.Click += new System.EventHandler(this.button_delete_all_data_Click);
            // 
            // button_dark_light_mode_toggle
            // 
            this.button_dark_light_mode_toggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_dark_light_mode_toggle.FlatAppearance.BorderSize = 0;
            this.button_dark_light_mode_toggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dark_light_mode_toggle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button_dark_light_mode_toggle.Location = new System.Drawing.Point(18, 182);
            this.button_dark_light_mode_toggle.Name = "button_dark_light_mode_toggle";
            this.button_dark_light_mode_toggle.Size = new System.Drawing.Size(507, 81);
            this.button_dark_light_mode_toggle.TabIndex = 5;
            this.button_dark_light_mode_toggle.Text = "Dark mode";
            this.button_dark_light_mode_toggle.UseVisualStyleBackColor = false;
            this.button_dark_light_mode_toggle.Click += new System.EventHandler(this.button_dark_light_mode_toggle_Click);
            // 
            // button_change_language
            // 
            this.button_change_language.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_change_language.FlatAppearance.BorderSize = 0;
            this.button_change_language.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_change_language.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_change_language.Location = new System.Drawing.Point(18, 67);
            this.button_change_language.Name = "button_change_language";
            this.button_change_language.Size = new System.Drawing.Size(507, 81);
            this.button_change_language.TabIndex = 6;
            this.button_change_language.Text = "Change language (Español)";
            this.button_change_language.UseVisualStyleBackColor = false;
            this.button_change_language.Click += new System.EventHandler(this.button_change_language_Click);
            // 
            // MainSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_change_language);
            this.Controls.Add(this.button_dark_light_mode_toggle);
            this.Controls.Add(this.button_delete_all_data);
            this.Controls.Add(this.label_separator);
            this.Controls.Add(this.label_settings_title);
            this.Name = "MainSettings";
            this.Size = new System.Drawing.Size(581, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_settings_title;
        private System.Windows.Forms.Label label_separator;
        private System.Windows.Forms.Button button_delete_all_data;
        private System.Windows.Forms.Button button_dark_light_mode_toggle;
        private System.Windows.Forms.Button button_change_language;
    }
}
