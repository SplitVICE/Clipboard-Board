namespace App001.UI
{
    partial class MainProfileManagement
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
            this.label_selected_profile = new System.Windows.Forms.Label();
            this.label_separator_1 = new System.Windows.Forms.Label();
            this.label_create_new_profile = new System.Windows.Forms.Label();
            this.label_profile_name = new System.Windows.Forms.Label();
            this.textBox_profile_name_create = new System.Windows.Forms.TextBox();
            this.button_profile_name_create = new System.Windows.Forms.Button();
            this.label_separator_2 = new System.Windows.Forms.Label();
            this.label_edit_selected_profile = new System.Windows.Forms.Label();
            this.listBox_profile_list = new System.Windows.Forms.ListBox();
            this.button_set_this_profile_as_current = new System.Windows.Forms.Button();
            this.label_set_new_name = new System.Windows.Forms.Label();
            this.textBox_set_new_name = new System.Windows.Forms.TextBox();
            this.button_edit_name = new System.Windows.Forms.Button();
            this.label_separator_3 = new System.Windows.Forms.Label();
            this.label_delete_profile = new System.Windows.Forms.Label();
            this.label_select_the_profile_to_delete = new System.Windows.Forms.Label();
            this.label_no_selected_profile = new System.Windows.Forms.Label();
            this.button_delete_selected_profile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_selected_profile
            // 
            this.label_selected_profile.AutoSize = true;
            this.label_selected_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selected_profile.Location = new System.Drawing.Point(14, 4);
            this.label_selected_profile.Name = "label_selected_profile";
            this.label_selected_profile.Size = new System.Drawing.Size(221, 24);
            this.label_selected_profile.TabIndex = 0;
            this.label_selected_profile.Text = "Selected profile: Profile X";
            // 
            // label_separator_1
            // 
            this.label_separator_1.AutoSize = true;
            this.label_separator_1.Location = new System.Drawing.Point(8, 28);
            this.label_separator_1.Name = "label_separator_1";
            this.label_separator_1.Size = new System.Drawing.Size(445, 13);
            this.label_separator_1.TabIndex = 1;
            this.label_separator_1.Text = "_________________________________________________________________________";
            // 
            // label_create_new_profile
            // 
            this.label_create_new_profile.AutoSize = true;
            this.label_create_new_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_create_new_profile.Location = new System.Drawing.Point(8, 53);
            this.label_create_new_profile.Name = "label_create_new_profile";
            this.label_create_new_profile.Size = new System.Drawing.Size(122, 17);
            this.label_create_new_profile.TabIndex = 2;
            this.label_create_new_profile.Text = "Create new profile";
            // 
            // label_profile_name
            // 
            this.label_profile_name.AutoSize = true;
            this.label_profile_name.Location = new System.Drawing.Point(59, 88);
            this.label_profile_name.Name = "label_profile_name";
            this.label_profile_name.Size = new System.Drawing.Size(68, 13);
            this.label_profile_name.TabIndex = 3;
            this.label_profile_name.Text = "Profile name:";
            // 
            // textBox_profile_name_create
            // 
            this.textBox_profile_name_create.Location = new System.Drawing.Point(129, 86);
            this.textBox_profile_name_create.Name = "textBox_profile_name_create";
            this.textBox_profile_name_create.Size = new System.Drawing.Size(207, 20);
            this.textBox_profile_name_create.TabIndex = 4;
            this.textBox_profile_name_create.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_profile_name_create_KeyDown);
            // 
            // button_profile_name_create
            // 
            this.button_profile_name_create.FlatAppearance.BorderSize = 0;
            this.button_profile_name_create.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_profile_name_create.Location = new System.Drawing.Point(129, 115);
            this.button_profile_name_create.Name = "button_profile_name_create";
            this.button_profile_name_create.Size = new System.Drawing.Size(207, 23);
            this.button_profile_name_create.TabIndex = 5;
            this.button_profile_name_create.Text = "Create";
            this.button_profile_name_create.UseVisualStyleBackColor = true;
            this.button_profile_name_create.Click += new System.EventHandler(this.button_profile_name_create_Click);
            // 
            // label_separator_2
            // 
            this.label_separator_2.AutoSize = true;
            this.label_separator_2.Location = new System.Drawing.Point(8, 141);
            this.label_separator_2.Name = "label_separator_2";
            this.label_separator_2.Size = new System.Drawing.Size(331, 13);
            this.label_separator_2.TabIndex = 6;
            this.label_separator_2.Text = "______________________________________________________";
            // 
            // label_edit_selected_profile
            // 
            this.label_edit_selected_profile.AutoSize = true;
            this.label_edit_selected_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_edit_selected_profile.Location = new System.Drawing.Point(11, 169);
            this.label_edit_selected_profile.Name = "label_edit_selected_profile";
            this.label_edit_selected_profile.Size = new System.Drawing.Size(132, 17);
            this.label_edit_selected_profile.TabIndex = 7;
            this.label_edit_selected_profile.Text = "Edit selected profile";
            // 
            // listBox_profile_list
            // 
            this.listBox_profile_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_profile_list.FormattingEnabled = true;
            this.listBox_profile_list.ItemHeight = 18;
            this.listBox_profile_list.Location = new System.Drawing.Point(363, 53);
            this.listBox_profile_list.Name = "listBox_profile_list";
            this.listBox_profile_list.Size = new System.Drawing.Size(187, 310);
            this.listBox_profile_list.TabIndex = 8;
            this.listBox_profile_list.Click += new System.EventHandler(this.listBox_profile_list_Click);
            // 
            // button_set_this_profile_as_current
            // 
            this.button_set_this_profile_as_current.FlatAppearance.BorderSize = 0;
            this.button_set_this_profile_as_current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_set_this_profile_as_current.Location = new System.Drawing.Point(363, 375);
            this.button_set_this_profile_as_current.Name = "button_set_this_profile_as_current";
            this.button_set_this_profile_as_current.Size = new System.Drawing.Size(187, 23);
            this.button_set_this_profile_as_current.TabIndex = 9;
            this.button_set_this_profile_as_current.Text = "Set this profile as current";
            this.button_set_this_profile_as_current.UseVisualStyleBackColor = true;
            this.button_set_this_profile_as_current.Click += new System.EventHandler(this.button_set_this_profile_as_current_Click);
            // 
            // label_set_new_name
            // 
            this.label_set_new_name.AutoSize = true;
            this.label_set_new_name.Location = new System.Drawing.Point(52, 207);
            this.label_set_new_name.Name = "label_set_new_name";
            this.label_set_new_name.Size = new System.Drawing.Size(78, 13);
            this.label_set_new_name.TabIndex = 10;
            this.label_set_new_name.Text = "Set new name:";
            // 
            // textBox_set_new_name
            // 
            this.textBox_set_new_name.Location = new System.Drawing.Point(129, 204);
            this.textBox_set_new_name.Name = "textBox_set_new_name";
            this.textBox_set_new_name.Size = new System.Drawing.Size(207, 20);
            this.textBox_set_new_name.TabIndex = 11;
            this.textBox_set_new_name.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_set_new_name_KeyDown);
            // 
            // button_edit_name
            // 
            this.button_edit_name.BackColor = System.Drawing.Color.Transparent;
            this.button_edit_name.FlatAppearance.BorderSize = 0;
            this.button_edit_name.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_edit_name.Location = new System.Drawing.Point(129, 230);
            this.button_edit_name.Name = "button_edit_name";
            this.button_edit_name.Size = new System.Drawing.Size(207, 23);
            this.button_edit_name.TabIndex = 12;
            this.button_edit_name.Text = "Edit name";
            this.button_edit_name.UseVisualStyleBackColor = false;
            this.button_edit_name.Click += new System.EventHandler(this.button_edit_name_Click);
            // 
            // label_separator_3
            // 
            this.label_separator_3.AutoSize = true;
            this.label_separator_3.Location = new System.Drawing.Point(11, 256);
            this.label_separator_3.Name = "label_separator_3";
            this.label_separator_3.Size = new System.Drawing.Size(331, 13);
            this.label_separator_3.TabIndex = 13;
            this.label_separator_3.Text = "______________________________________________________";
            // 
            // label_delete_profile
            // 
            this.label_delete_profile.AutoSize = true;
            this.label_delete_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_delete_profile.Location = new System.Drawing.Point(11, 281);
            this.label_delete_profile.Name = "label_delete_profile";
            this.label_delete_profile.Size = new System.Drawing.Size(92, 17);
            this.label_delete_profile.TabIndex = 14;
            this.label_delete_profile.Text = "Delete profile";
            // 
            // label_select_the_profile_to_delete
            // 
            this.label_select_the_profile_to_delete.AutoSize = true;
            this.label_select_the_profile_to_delete.Location = new System.Drawing.Point(57, 311);
            this.label_select_the_profile_to_delete.Name = "label_select_the_profile_to_delete";
            this.label_select_the_profile_to_delete.Size = new System.Drawing.Size(130, 13);
            this.label_select_the_profile_to_delete.TabIndex = 15;
            this.label_select_the_profile_to_delete.Text = "Select the profile to delete";
            // 
            // label_no_selected_profile
            // 
            this.label_no_selected_profile.AutoSize = true;
            this.label_no_selected_profile.Location = new System.Drawing.Point(60, 338);
            this.label_no_selected_profile.Name = "label_no_selected_profile";
            this.label_no_selected_profile.Size = new System.Drawing.Size(101, 13);
            this.label_no_selected_profile.TabIndex = 16;
            this.label_no_selected_profile.Text = "- No selected profile";
            // 
            // button_delete_selected_profile
            // 
            this.button_delete_selected_profile.FlatAppearance.BorderSize = 0;
            this.button_delete_selected_profile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_selected_profile.Location = new System.Drawing.Point(129, 365);
            this.button_delete_selected_profile.Name = "button_delete_selected_profile";
            this.button_delete_selected_profile.Size = new System.Drawing.Size(207, 23);
            this.button_delete_selected_profile.TabIndex = 17;
            this.button_delete_selected_profile.Text = "Delete selected profile";
            this.button_delete_selected_profile.UseVisualStyleBackColor = true;
            this.button_delete_selected_profile.Click += new System.EventHandler(this.button_delete_selected_profile_Click);
            // 
            // MainProfileManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_delete_selected_profile);
            this.Controls.Add(this.label_no_selected_profile);
            this.Controls.Add(this.label_select_the_profile_to_delete);
            this.Controls.Add(this.label_delete_profile);
            this.Controls.Add(this.label_separator_3);
            this.Controls.Add(this.button_edit_name);
            this.Controls.Add(this.textBox_set_new_name);
            this.Controls.Add(this.label_set_new_name);
            this.Controls.Add(this.button_set_this_profile_as_current);
            this.Controls.Add(this.listBox_profile_list);
            this.Controls.Add(this.label_edit_selected_profile);
            this.Controls.Add(this.label_separator_2);
            this.Controls.Add(this.button_profile_name_create);
            this.Controls.Add(this.textBox_profile_name_create);
            this.Controls.Add(this.label_profile_name);
            this.Controls.Add(this.label_create_new_profile);
            this.Controls.Add(this.label_separator_1);
            this.Controls.Add(this.label_selected_profile);
            this.Name = "MainProfileManagement";
            this.Size = new System.Drawing.Size(581, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_selected_profile;
        private System.Windows.Forms.Label label_separator_1;
        private System.Windows.Forms.Label label_create_new_profile;
        private System.Windows.Forms.Label label_profile_name;
        private System.Windows.Forms.TextBox textBox_profile_name_create;
        private System.Windows.Forms.Button button_profile_name_create;
        private System.Windows.Forms.Label label_separator_2;
        private System.Windows.Forms.Label label_edit_selected_profile;
        private System.Windows.Forms.ListBox listBox_profile_list;
        private System.Windows.Forms.Button button_set_this_profile_as_current;
        private System.Windows.Forms.Label label_set_new_name;
        private System.Windows.Forms.TextBox textBox_set_new_name;
        private System.Windows.Forms.Button button_edit_name;
        private System.Windows.Forms.Label label_separator_3;
        private System.Windows.Forms.Label label_delete_profile;
        private System.Windows.Forms.Label label_select_the_profile_to_delete;
        private System.Windows.Forms.Label label_no_selected_profile;
        private System.Windows.Forms.Button button_delete_selected_profile;
    }
}
