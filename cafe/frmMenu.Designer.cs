namespace cafe
{
    partial class frmMenu
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
            this.btnTableOrder = new System.Windows.Forms.Button();
            this.btnKasaİşlemleri = new System.Windows.Forms.Button();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnKitchen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnTableOrder
            // 
            this.btnTableOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnTableOrder.BackgroundImage = global::cafe.Properties.Resources.png_clipart_cutlery_cloth_napkins_spoon_grass_fork_removebg_preview;
            this.btnTableOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTableOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTableOrder.Location = new System.Drawing.Point(184, 78);
            this.btnTableOrder.Name = "btnTableOrder";
            this.btnTableOrder.Size = new System.Drawing.Size(290, 114);
            this.btnTableOrder.TabIndex = 0;
            this.btnTableOrder.UseVisualStyleBackColor = false;
            this.btnTableOrder.Click += new System.EventHandler(this.btnTableOrder_Click);
            // 
            // btnKasaİşlemleri
            // 
            this.btnKasaİşlemleri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnKasaİşlemleri.BackgroundImage = global::cafe.Properties.Resources.png_transparent_computer_icons_calculator_vecteezy_calculator_electronics_rectangle_calculator_removebg_preview;
            this.btnKasaİşlemleri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKasaİşlemleri.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKasaİşlemleri.Location = new System.Drawing.Point(184, 198);
            this.btnKasaİşlemleri.Name = "btnKasaİşlemleri";
            this.btnKasaİşlemleri.Size = new System.Drawing.Size(142, 114);
            this.btnKasaİşlemleri.TabIndex = 0;
            this.btnKasaİşlemleri.UseVisualStyleBackColor = false;
            this.btnKasaİşlemleri.Click += new System.EventHandler(this.btnKasaİşlemleri_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnSettings.BackgroundImage = global::cafe.Properties.Resources.icon_4399639_1280;
            this.btnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSettings.Location = new System.Drawing.Point(480, 78);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(142, 114);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::cafe.Properties.Resources.png_clipart_computer_icons_login_logo_logout_emblem_trademark_thumbnail_removebg_preview;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(480, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(142, 114);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnKitchen
            // 
            this.btnKitchen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnKitchen.BackgroundImage = global::cafe.Properties.Resources.png_transparent_illustration_of_kitchen_kitchen_kitchen_miscellaneous_purple_angle_removebg_preview;
            this.btnKitchen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKitchen.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKitchen.Location = new System.Drawing.Point(332, 198);
            this.btnKitchen.Name = "btnKitchen";
            this.btnKitchen.Size = new System.Drawing.Size(290, 114);
            this.btnKitchen.TabIndex = 1;
            this.btnKitchen.UseVisualStyleBackColor = false;
            this.btnKitchen.Click += new System.EventHandler(this.btnKitchen_Click_1);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafe.Properties.Resources.desktop_wallpaper_pink_and_yellow_pastel_pink_and_yellow;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(858, 525);
            this.Controls.Add(this.btnKitchen);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSettings);
            this.Controls.Add(this.btnKasaİşlemleri);
            this.Controls.Add(this.btnTableOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTableOrder;
        private System.Windows.Forms.Button btnKasaİşlemleri;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnKitchen;
    }
}