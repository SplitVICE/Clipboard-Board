namespace App001.UI
{
    partial class MainAbout
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
            this.label_about_title = new System.Windows.Forms.Label();
            this.label_separator_1 = new System.Windows.Forms.Label();
            this.label_made_by = new System.Windows.Forms.Label();
            this.label_separator_2 = new System.Windows.Forms.Label();
            this.label_links = new System.Windows.Forms.Label();
            this.button_twitter = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button_github = new System.Windows.Forms.Button();
            this.button_webpage = new System.Windows.Forms.Button();
            this.button_clipboard_board_webpage = new System.Windows.Forms.Button();
            this.label_vice_message = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_about_title
            // 
            this.label_about_title.AutoSize = true;
            this.label_about_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.label_about_title.Location = new System.Drawing.Point(14, 4);
            this.label_about_title.Name = "label_about_title";
            this.label_about_title.Size = new System.Drawing.Size(60, 24);
            this.label_about_title.TabIndex = 1;
            this.label_about_title.Text = "About";
            // 
            // label_separator_1
            // 
            this.label_separator_1.AutoSize = true;
            this.label_separator_1.Location = new System.Drawing.Point(8, 28);
            this.label_separator_1.Name = "label_separator_1";
            this.label_separator_1.Size = new System.Drawing.Size(517, 13);
            this.label_separator_1.TabIndex = 4;
            this.label_separator_1.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // label_made_by
            // 
            this.label_made_by.AutoSize = true;
            this.label_made_by.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_made_by.Location = new System.Drawing.Point(85, 56);
            this.label_made_by.Name = "label_made_by";
            this.label_made_by.Size = new System.Drawing.Size(90, 24);
            this.label_made_by.TabIndex = 6;
            this.label_made_by.Text = "Made by";
            // 
            // label_separator_2
            // 
            this.label_separator_2.AutoSize = true;
            this.label_separator_2.Location = new System.Drawing.Point(8, 243);
            this.label_separator_2.Name = "label_separator_2";
            this.label_separator_2.Size = new System.Drawing.Size(517, 13);
            this.label_separator_2.TabIndex = 7;
            this.label_separator_2.Text = "_________________________________________________________________________________" +
    "____";
            // 
            // label_links
            // 
            this.label_links.AutoSize = true;
            this.label_links.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_links.Location = new System.Drawing.Point(15, 273);
            this.label_links.Name = "label_links";
            this.label_links.Size = new System.Drawing.Size(46, 20);
            this.label_links.TabIndex = 9;
            this.label_links.Text = "Links";
            // 
            // button_twitter
            // 
            this.button_twitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_twitter.FlatAppearance.BorderSize = 0;
            this.button_twitter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_twitter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_twitter.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_twitter.Location = new System.Drawing.Point(19, 296);
            this.button_twitter.Name = "button_twitter";
            this.button_twitter.Size = new System.Drawing.Size(138, 48);
            this.button_twitter.TabIndex = 10;
            this.button_twitter.Text = "Twitter";
            this.button_twitter.UseVisualStyleBackColor = false;
            this.button_twitter.Click += new System.EventHandler(this.button_twitter_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App001.Properties.Resources.FIRM_V2_bigger;
            this.pictureBox1.Location = new System.Drawing.Point(195, 56);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // button_github
            // 
            this.button_github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_github.FlatAppearance.BorderSize = 0;
            this.button_github.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_github.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_github.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_github.Location = new System.Drawing.Point(179, 296);
            this.button_github.Name = "button_github";
            this.button_github.Size = new System.Drawing.Size(138, 48);
            this.button_github.TabIndex = 11;
            this.button_github.Text = "Github";
            this.button_github.UseVisualStyleBackColor = false;
            this.button_github.Click += new System.EventHandler(this.button_github_Click);
            // 
            // button_webpage
            // 
            this.button_webpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_webpage.FlatAppearance.BorderSize = 0;
            this.button_webpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_webpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_webpage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_webpage.Location = new System.Drawing.Point(338, 296);
            this.button_webpage.Name = "button_webpage";
            this.button_webpage.Size = new System.Drawing.Size(138, 48);
            this.button_webpage.TabIndex = 12;
            this.button_webpage.Text = "Web page";
            this.button_webpage.UseVisualStyleBackColor = false;
            this.button_webpage.Click += new System.EventHandler(this.button_webpage_Click);
            // 
            // button_clipboard_board_webpage
            // 
            this.button_clipboard_board_webpage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button_clipboard_board_webpage.FlatAppearance.BorderSize = 0;
            this.button_clipboard_board_webpage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_clipboard_board_webpage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.button_clipboard_board_webpage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_clipboard_board_webpage.Location = new System.Drawing.Point(19, 360);
            this.button_clipboard_board_webpage.Name = "button_clipboard_board_webpage";
            this.button_clipboard_board_webpage.Size = new System.Drawing.Size(230, 48);
            this.button_clipboard_board_webpage.TabIndex = 13;
            this.button_clipboard_board_webpage.Text = "Clipboard Board web page";
            this.button_clipboard_board_webpage.UseVisualStyleBackColor = false;
            this.button_clipboard_board_webpage.Click += new System.EventHandler(this.button_clipboard_board_webpage_Click);
            // 
            // label_vice_message
            // 
            this.label_vice_message.AutoSize = true;
            this.label_vice_message.Location = new System.Drawing.Point(405, 99);
            this.label_vice_message.Name = "label_vice_message";
            this.label_vice_message.Size = new System.Drawing.Size(108, 13);
            this.label_vice_message.TabIndex = 14;
            this.label_vice_message.Text = "Message placeholder";
            // 
            // MainAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label_vice_message);
            this.Controls.Add(this.button_clipboard_board_webpage);
            this.Controls.Add(this.button_webpage);
            this.Controls.Add(this.button_github);
            this.Controls.Add(this.button_twitter);
            this.Controls.Add(this.label_links);
            this.Controls.Add(this.label_separator_2);
            this.Controls.Add(this.label_made_by);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label_separator_1);
            this.Controls.Add(this.label_about_title);
            this.Name = "MainAbout";
            this.Size = new System.Drawing.Size(581, 422);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_about_title;
        private System.Windows.Forms.Label label_separator_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label_made_by;
        private System.Windows.Forms.Label label_separator_2;
        private System.Windows.Forms.Label label_links;
        private System.Windows.Forms.Button button_twitter;
        private System.Windows.Forms.Button button_github;
        private System.Windows.Forms.Button button_webpage;
        private System.Windows.Forms.Button button_clipboard_board_webpage;
        private System.Windows.Forms.Label label_vice_message;
    }
}
