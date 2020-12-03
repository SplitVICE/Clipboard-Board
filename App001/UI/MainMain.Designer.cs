namespace App001.UI
{
    partial class MainMain
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label_selected_profile = new System.Windows.Forms.Label();
            this.label_item_copied = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(14, 27);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(547, 381);
            this.listBox1.TabIndex = 0;
            // 
            // label_selected_profile
            // 
            this.label_selected_profile.AutoSize = true;
            this.label_selected_profile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_selected_profile.Location = new System.Drawing.Point(14, 4);
            this.label_selected_profile.Name = "label_selected_profile";
            this.label_selected_profile.Size = new System.Drawing.Size(186, 20);
            this.label_selected_profile.TabIndex = 1;
            this.label_selected_profile.Text = "Selected profile: Profile X";
            // 
            // label_item_copied
            // 
            this.label_item_copied.AutoSize = true;
            this.label_item_copied.Location = new System.Drawing.Point(258, 8);
            this.label_item_copied.Name = "label_item_copied";
            this.label_item_copied.Size = new System.Drawing.Size(76, 13);
            this.label_item_copied.TabIndex = 2;
            this.label_item_copied.Text = "ITEM COPIED";
            // 
            // MainMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_item_copied);
            this.Controls.Add(this.label_selected_profile);
            this.Controls.Add(this.listBox1);
            this.Name = "MainMain";
            this.Size = new System.Drawing.Size(581, 422);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label_selected_profile;
        private System.Windows.Forms.Label label_item_copied;
    }
}
