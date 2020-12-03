namespace App001.UI
{
    partial class MainItemManagement
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
            this.label_create_new_item = new System.Windows.Forms.Label();
            this.label_item_name_1 = new System.Windows.Forms.Label();
            this.textBox_item_name_create = new System.Windows.Forms.TextBox();
            this.label_item_content_1 = new System.Windows.Forms.Label();
            this.textBox_item_content_create = new System.Windows.Forms.TextBox();
            this.button_create_new_item = new System.Windows.Forms.Button();
            this.label_separator_2 = new System.Windows.Forms.Label();
            this.label_edit_or_delete_item = new System.Windows.Forms.Label();
            this.listBox_item_list = new System.Windows.Forms.ListBox();
            this.label_edit_item = new System.Windows.Forms.Label();
            this.label_item_name_2 = new System.Windows.Forms.Label();
            this.label_item_content_2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.button_save_changes = new System.Windows.Forms.Button();
            this.label_separator_3 = new System.Windows.Forms.Label();
            this.button_delete_selected_item = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_selected_profile
            // 
            this.label_selected_profile.AutoSize = true;
            this.label_selected_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selected_profile.Location = new System.Drawing.Point(14, 4);
            this.label_selected_profile.Name = "label_selected_profile";
            this.label_selected_profile.Size = new System.Drawing.Size(221, 24);
            this.label_selected_profile.TabIndex = 1;
            this.label_selected_profile.Text = "Selected profile: Profile X";
            // 
            // label_separator_1
            // 
            this.label_separator_1.AutoSize = true;
            this.label_separator_1.Location = new System.Drawing.Point(8, 28);
            this.label_separator_1.Name = "label_separator_1";
            this.label_separator_1.Size = new System.Drawing.Size(445, 13);
            this.label_separator_1.TabIndex = 2;
            this.label_separator_1.Text = "_________________________________________________________________________";
            // 
            // label_create_new_item
            // 
            this.label_create_new_item.AutoSize = true;
            this.label_create_new_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_create_new_item.Location = new System.Drawing.Point(8, 53);
            this.label_create_new_item.Name = "label_create_new_item";
            this.label_create_new_item.Size = new System.Drawing.Size(109, 17);
            this.label_create_new_item.TabIndex = 3;
            this.label_create_new_item.Text = "Create new item";
            // 
            // label_item_name_1
            // 
            this.label_item_name_1.AutoSize = true;
            this.label_item_name_1.Location = new System.Drawing.Point(11, 77);
            this.label_item_name_1.Name = "label_item_name_1";
            this.label_item_name_1.Size = new System.Drawing.Size(62, 13);
            this.label_item_name_1.TabIndex = 4;
            this.label_item_name_1.Text = "Item name: ";
            // 
            // textBox_item_name_create
            // 
            this.textBox_item_name_create.Location = new System.Drawing.Point(82, 77);
            this.textBox_item_name_create.Name = "textBox_item_name_create";
            this.textBox_item_name_create.Size = new System.Drawing.Size(480, 20);
            this.textBox_item_name_create.TabIndex = 5;
            // 
            // label_item_content_1
            // 
            this.label_item_content_1.AutoSize = true;
            this.label_item_content_1.Location = new System.Drawing.Point(10, 105);
            this.label_item_content_1.Name = "label_item_content_1";
            this.label_item_content_1.Size = new System.Drawing.Size(72, 13);
            this.label_item_content_1.TabIndex = 6;
            this.label_item_content_1.Text = "Item content: ";
            // 
            // textBox_item_content_create
            // 
            this.textBox_item_content_create.Location = new System.Drawing.Point(82, 103);
            this.textBox_item_content_create.Name = "textBox_item_content_create";
            this.textBox_item_content_create.Size = new System.Drawing.Size(480, 20);
            this.textBox_item_content_create.TabIndex = 7;
            // 
            // button_create_new_item
            // 
            this.button_create_new_item.FlatAppearance.BorderSize = 0;
            this.button_create_new_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_create_new_item.Location = new System.Drawing.Point(135, 129);
            this.button_create_new_item.Name = "button_create_new_item";
            this.button_create_new_item.Size = new System.Drawing.Size(357, 23);
            this.button_create_new_item.TabIndex = 9;
            this.button_create_new_item.Text = "Create new item";
            this.button_create_new_item.UseVisualStyleBackColor = true;
            this.button_create_new_item.Click += new System.EventHandler(this.button_create_new_item_Click);
            // 
            // label_separator_2
            // 
            this.label_separator_2.AutoSize = true;
            this.label_separator_2.Location = new System.Drawing.Point(8, 164);
            this.label_separator_2.Name = "label_separator_2";
            this.label_separator_2.Size = new System.Drawing.Size(553, 13);
            this.label_separator_2.TabIndex = 11;
            this.label_separator_2.Text = "_________________________________________________________________________________" +
    "__________";
            // 
            // label_edit_or_delete_item
            // 
            this.label_edit_or_delete_item.AutoSize = true;
            this.label_edit_or_delete_item.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label_edit_or_delete_item.Location = new System.Drawing.Point(13, 181);
            this.label_edit_or_delete_item.Name = "label_edit_or_delete_item";
            this.label_edit_or_delete_item.Size = new System.Drawing.Size(122, 17);
            this.label_edit_or_delete_item.TabIndex = 13;
            this.label_edit_or_delete_item.Text = "Edit or delete item";
            // 
            // listBox_item_list
            // 
            this.listBox_item_list.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.listBox_item_list.FormattingEnabled = true;
            this.listBox_item_list.ItemHeight = 18;
            this.listBox_item_list.Location = new System.Drawing.Point(288, 193);
            this.listBox_item_list.Name = "listBox_item_list";
            this.listBox_item_list.Size = new System.Drawing.Size(273, 202);
            this.listBox_item_list.TabIndex = 14;
            this.listBox_item_list.Click += new System.EventHandler(this.listBox_item_list_Click);
            // 
            // label_edit_item
            // 
            this.label_edit_item.AutoSize = true;
            this.label_edit_item.Location = new System.Drawing.Point(15, 206);
            this.label_edit_item.Name = "label_edit_item";
            this.label_edit_item.Size = new System.Drawing.Size(47, 13);
            this.label_edit_item.TabIndex = 16;
            this.label_edit_item.Text = "Edit item";
            // 
            // label_item_name_2
            // 
            this.label_item_name_2.AutoSize = true;
            this.label_item_name_2.Location = new System.Drawing.Point(28, 225);
            this.label_item_name_2.Name = "label_item_name_2";
            this.label_item_name_2.Size = new System.Drawing.Size(56, 13);
            this.label_item_name_2.TabIndex = 17;
            this.label_item_name_2.Text = "Item name";
            // 
            // label_item_content_2
            // 
            this.label_item_content_2.AutoSize = true;
            this.label_item_content_2.Location = new System.Drawing.Point(27, 268);
            this.label_item_content_2.Name = "label_item_content_2";
            this.label_item_content_2.Size = new System.Drawing.Size(66, 13);
            this.label_item_content_2.TabIndex = 18;
            this.label_item_content_2.Text = "Item content";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(31, 241);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(240, 20);
            this.textBox3.TabIndex = 19;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(31, 284);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(240, 20);
            this.textBox4.TabIndex = 20;
            // 
            // button_save_changes
            // 
            this.button_save_changes.FlatAppearance.BorderSize = 0;
            this.button_save_changes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save_changes.Location = new System.Drawing.Point(30, 310);
            this.button_save_changes.Name = "button_save_changes";
            this.button_save_changes.Size = new System.Drawing.Size(241, 23);
            this.button_save_changes.TabIndex = 21;
            this.button_save_changes.Text = "Save changes";
            this.button_save_changes.UseVisualStyleBackColor = true;
            // 
            // label_separator_3
            // 
            this.label_separator_3.AutoSize = true;
            this.label_separator_3.Location = new System.Drawing.Point(40, 336);
            this.label_separator_3.Name = "label_separator_3";
            this.label_separator_3.Size = new System.Drawing.Size(223, 13);
            this.label_separator_3.TabIndex = 22;
            this.label_separator_3.Text = "____________________________________";
            // 
            // button_delete_selected_item
            // 
            this.button_delete_selected_item.FlatAppearance.BorderSize = 0;
            this.button_delete_selected_item.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_delete_selected_item.Location = new System.Drawing.Point(82, 357);
            this.button_delete_selected_item.Name = "button_delete_selected_item";
            this.button_delete_selected_item.Size = new System.Drawing.Size(126, 23);
            this.button_delete_selected_item.TabIndex = 23;
            this.button_delete_selected_item.Text = "Delete selected item";
            this.button_delete_selected_item.UseVisualStyleBackColor = true;
            // 
            // MainItemManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.button_delete_selected_item);
            this.Controls.Add(this.label_separator_3);
            this.Controls.Add(this.button_save_changes);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label_item_content_2);
            this.Controls.Add(this.label_item_name_2);
            this.Controls.Add(this.label_edit_item);
            this.Controls.Add(this.listBox_item_list);
            this.Controls.Add(this.label_edit_or_delete_item);
            this.Controls.Add(this.label_separator_2);
            this.Controls.Add(this.button_create_new_item);
            this.Controls.Add(this.textBox_item_content_create);
            this.Controls.Add(this.label_item_content_1);
            this.Controls.Add(this.textBox_item_name_create);
            this.Controls.Add(this.label_item_name_1);
            this.Controls.Add(this.label_create_new_item);
            this.Controls.Add(this.label_separator_1);
            this.Controls.Add(this.label_selected_profile);
            this.Name = "MainItemManagement";
            this.Size = new System.Drawing.Size(581, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_selected_profile;
        private System.Windows.Forms.Label label_separator_1;
        private System.Windows.Forms.Label label_create_new_item;
        private System.Windows.Forms.Label label_item_name_1;
        private System.Windows.Forms.TextBox textBox_item_name_create;
        private System.Windows.Forms.Label label_item_content_1;
        private System.Windows.Forms.TextBox textBox_item_content_create;
        private System.Windows.Forms.Button button_create_new_item;
        private System.Windows.Forms.Label label_separator_2;
        private System.Windows.Forms.Label label_edit_or_delete_item;
        private System.Windows.Forms.ListBox listBox_item_list;
        private System.Windows.Forms.Label label_edit_item;
        private System.Windows.Forms.Label label_item_name_2;
        private System.Windows.Forms.Label label_item_content_2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button_save_changes;
        private System.Windows.Forms.Label label_separator_3;
        private System.Windows.Forms.Button button_delete_selected_item;
    }
}
