namespace cafe
{
    partial class frmOrder
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
            this.lblTableNo = new System.Windows.Forms.Label();
            this.btnDrinks2 = new System.Windows.Forms.Button();
            this.menu = new System.Windows.Forms.GroupBox();
            this.btnPasta7 = new System.Windows.Forms.Button();
            this.btnFastFood5 = new System.Windows.Forms.Button();
            this.btnSweets3 = new System.Windows.Forms.Button();
            this.btnMainDish1 = new System.Windows.Forms.Button();
            this.btnAraSıcak8 = new System.Windows.Forms.Button();
            this.btnSoup6 = new System.Windows.Forms.Button();
            this.btnSalads4 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvMenu = new System.Windows.Forms.ListView();
            this.productName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPrice = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lvOrders = new System.Windows.Forms.ListView();
            this.productName1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productPrice1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.productId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.salesId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deletedId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.lvNewAdded = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTableNo
            // 
            this.lblTableNo.AutoSize = true;
            this.lblTableNo.BackColor = System.Drawing.Color.Transparent;
            this.lblTableNo.Font = new System.Drawing.Font("Palatino Linotype", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTableNo.Location = new System.Drawing.Point(121, 9);
            this.lblTableNo.Name = "lblTableNo";
            this.lblTableNo.Size = new System.Drawing.Size(109, 37);
            this.lblTableNo.TabIndex = 0;
            this.lblTableNo.Text = "TABL 1";
            // 
            // btnDrinks2
            // 
            this.btnDrinks2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDrinks2.BackgroundImage = global::cafe.Properties.Resources.soft_drinks_icon_in_illustration_vector_removebg_preview;
            this.btnDrinks2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDrinks2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDrinks2.Location = new System.Drawing.Point(201, 19);
            this.btnDrinks2.Name = "btnDrinks2";
            this.btnDrinks2.Size = new System.Drawing.Size(180, 96);
            this.btnDrinks2.TabIndex = 0;
            this.btnDrinks2.UseVisualStyleBackColor = false;
            this.btnDrinks2.Click += new System.EventHandler(this.btnDrinks2_Click);
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.Transparent;
            this.menu.Controls.Add(this.btnPasta7);
            this.menu.Controls.Add(this.btnFastFood5);
            this.menu.Controls.Add(this.btnSweets3);
            this.menu.Controls.Add(this.btnMainDish1);
            this.menu.Controls.Add(this.btnAraSıcak8);
            this.menu.Controls.Add(this.btnSoup6);
            this.menu.Controls.Add(this.btnSalads4);
            this.menu.Controls.Add(this.btnDrinks2);
            this.menu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menu.Location = new System.Drawing.Point(12, 70);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(396, 449);
            this.menu.TabIndex = 1;
            this.menu.TabStop = false;
            this.menu.Text = "Menu";
            // 
            // btnPasta7
            // 
            this.btnPasta7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPasta7.BackgroundImage = global::cafe.Properties.Resources._4465494;
            this.btnPasta7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPasta7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPasta7.Location = new System.Drawing.Point(6, 325);
            this.btnPasta7.Name = "btnPasta7";
            this.btnPasta7.Size = new System.Drawing.Size(180, 96);
            this.btnPasta7.TabIndex = 0;
            this.btnPasta7.UseVisualStyleBackColor = false;
            this.btnPasta7.Click += new System.EventHandler(this.btnPasta7_Click);
            // 
            // btnFastFood5
            // 
            this.btnFastFood5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnFastFood5.BackgroundImage = global::cafe.Properties.Resources._2819194;
            this.btnFastFood5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFastFood5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFastFood5.Location = new System.Drawing.Point(6, 223);
            this.btnFastFood5.Name = "btnFastFood5";
            this.btnFastFood5.Size = new System.Drawing.Size(180, 96);
            this.btnFastFood5.TabIndex = 0;
            this.btnFastFood5.UseVisualStyleBackColor = false;
            this.btnFastFood5.Click += new System.EventHandler(this.btnFastFood5_Click);
            // 
            // btnSweets3
            // 
            this.btnSweets3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnSweets3.BackgroundImage = global::cafe.Properties.Resources._3081792;
            this.btnSweets3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSweets3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSweets3.Location = new System.Drawing.Point(6, 121);
            this.btnSweets3.Name = "btnSweets3";
            this.btnSweets3.Size = new System.Drawing.Size(180, 96);
            this.btnSweets3.TabIndex = 0;
            this.btnSweets3.UseVisualStyleBackColor = false;
            this.btnSweets3.Click += new System.EventHandler(this.btnSweets3_Click);
            // 
            // btnMainDish1
            // 
            this.btnMainDish1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnMainDish1.BackgroundImage = global::cafe.Properties.Resources.main_dish_icon_colorful_flat_design_illustration_graphics_free_vector_removebg_preview;
            this.btnMainDish1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainDish1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMainDish1.Location = new System.Drawing.Point(6, 19);
            this.btnMainDish1.Name = "btnMainDish1";
            this.btnMainDish1.Size = new System.Drawing.Size(180, 96);
            this.btnMainDish1.TabIndex = 0;
            this.btnMainDish1.UseVisualStyleBackColor = false;
            this.btnMainDish1.Click += new System.EventHandler(this.btnMainDish1_Click);
            // 
            // btnAraSıcak8
            // 
            this.btnAraSıcak8.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAraSıcak8.BackgroundImage = global::cafe.Properties.Resources.png_transparent_fork_and_knife_icon_computer_icons_meal_lunch_meal_miscellaneous_logo_silhouette_removebg_preview;
            this.btnAraSıcak8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAraSıcak8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAraSıcak8.Location = new System.Drawing.Point(201, 325);
            this.btnAraSıcak8.Name = "btnAraSıcak8";
            this.btnAraSıcak8.Size = new System.Drawing.Size(180, 96);
            this.btnAraSıcak8.TabIndex = 0;
            this.btnAraSıcak8.UseVisualStyleBackColor = false;
            this.btnAraSıcak8.Click += new System.EventHandler(this.btnAraSıcak8_Click);
            // 
            // btnSoup6
            // 
            this.btnSoup6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSoup6.BackgroundImage = global::cafe.Properties.Resources.istockphoto_1350556413_612x612_removebg_preview;
            this.btnSoup6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSoup6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSoup6.Location = new System.Drawing.Point(201, 223);
            this.btnSoup6.Name = "btnSoup6";
            this.btnSoup6.Size = new System.Drawing.Size(180, 96);
            this.btnSoup6.TabIndex = 0;
            this.btnSoup6.UseVisualStyleBackColor = false;
            this.btnSoup6.Click += new System.EventHandler(this.btnSoup6_Click);
            // 
            // btnSalads4
            // 
            this.btnSalads4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSalads4.BackgroundImage = global::cafe.Properties.Resources._2619557;
            this.btnSalads4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalads4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalads4.Location = new System.Drawing.Point(201, 121);
            this.btnSalads4.Name = "btnSalads4";
            this.btnSalads4.Size = new System.Drawing.Size(180, 96);
            this.btnSalads4.TabIndex = 0;
            this.btnSalads4.UseVisualStyleBackColor = false;
            this.btnSalads4.Click += new System.EventHandler(this.btnSalads4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.lvMenu);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(426, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 231);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu";
            // 
            // lvMenu
            // 
            this.lvMenu.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName,
            this.productPrice,
            this.productNo});
            this.lvMenu.FullRowSelect = true;
            this.lvMenu.GridLines = true;
            this.lvMenu.HideSelection = false;
            this.lvMenu.Location = new System.Drawing.Point(6, 25);
            this.lvMenu.Name = "lvMenu";
            this.lvMenu.Size = new System.Drawing.Size(465, 200);
            this.lvMenu.TabIndex = 0;
            this.lvMenu.UseCompatibleStateImageBehavior = false;
            this.lvMenu.View = System.Windows.Forms.View.Details;
            
            this.lvMenu.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvMenu_MouseDoubleClick);
            // 
            // productName
            // 
            this.productName.Text = "Product Name";
            this.productName.Width = 212;
            // 
            // productPrice
            // 
            this.productPrice.Text = "Product Price";
            this.productPrice.Width = 248;
            // 
            // productNo
            // 
            this.productNo.Text = "Product No";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.lvOrders);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox2.Location = new System.Drawing.Point(426, 307);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(477, 219);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Order";
            // 
            // lvOrders
            // 
            this.lvOrders.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.productName1,
            this.productCount,
            this.productPrice1,
            this.productId,
            this.salesId,
            this.deletedId});
            this.lvOrders.FullRowSelect = true;
            this.lvOrders.GridLines = true;
            this.lvOrders.HideSelection = false;
            this.lvOrders.Location = new System.Drawing.Point(6, 24);
            this.lvOrders.Name = "lvOrders";
            this.lvOrders.Size = new System.Drawing.Size(465, 188);
            this.lvOrders.TabIndex = 0;
            this.lvOrders.UseCompatibleStateImageBehavior = false;
            this.lvOrders.View = System.Windows.Forms.View.Details;
            this.lvOrders.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvOrders_MouseDoubleClick);
            // 
            // productName1
            // 
            this.productName1.Text = "Product Name";
            this.productName1.Width = 137;
            // 
            // productCount
            // 
            this.productCount.Text = "Product Count";
            this.productCount.Width = 133;
            // 
            // productPrice1
            // 
            this.productPrice1.Text = "Product Price";
            this.productPrice1.Width = 153;
            // 
            // productId
            // 
            this.productId.Text = "Product Id";
            this.productId.Width = 112;
            // 
            // salesId
            // 
            this.salesId.Text = "Sale Id";
            this.salesId.Width = 80;
            // 
            // deletedId
            // 
            this.deletedId.Text = "Deleted Id";
            this.deletedId.Width = 36;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(448, 44);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(171, 20);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(347, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Product No";
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn7.Location = new System.Drawing.Point(915, 258);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(77, 68);
            this.btn7.TabIndex = 4;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            // 
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn8.Location = new System.Drawing.Point(998, 258);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(77, 68);
            this.btn8.TabIndex = 5;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            // 
            // btn9
            // 
            this.btn9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn9.Location = new System.Drawing.Point(1081, 258);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(77, 68);
            this.btn9.TabIndex = 5;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = false;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn1.Location = new System.Drawing.Point(915, 110);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(77, 68);
            this.btn1.TabIndex = 4;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2.Location = new System.Drawing.Point(998, 110);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(77, 68);
            this.btn2.TabIndex = 5;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3.Location = new System.Drawing.Point(1081, 110);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(77, 68);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn4.Location = new System.Drawing.Point(915, 184);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(77, 68);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn5.Location = new System.Drawing.Point(998, 184);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(77, 68);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn6.Location = new System.Drawing.Point(1081, 184);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(77, 68);
            this.btn6.TabIndex = 5;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnClear.Location = new System.Drawing.Point(915, 332);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(160, 68);
            this.btnClear.TabIndex = 4;
            this.btnClear.Text = "C";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btn0
            // 
            this.btn0.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn0.Location = new System.Drawing.Point(1081, 332);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(77, 68);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = false;
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(915, 70);
            this.txtCount.Multiline = true;
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(243, 34);
            this.txtCount.TabIndex = 6;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BackgroundImage = global::cafe.Properties.Resources.png_clipart_computer_icons_login_logo_logout_emblem_trademark_thumbnail_removebg_preview;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(70, 537);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(54, 51);
            this.btnExit.TabIndex = 13;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = global::cafe.Properties.Resources._3982046_200;
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBack.Location = new System.Drawing.Point(12, 537);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(52, 51);
            this.btnBack.TabIndex = 12;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.BackgroundImage = global::cafe.Properties.Resources._1019607;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(915, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 78);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnOrder.BackgroundImage = global::cafe.Properties.Resources._3496155;
            this.btnOrder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOrder.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnOrder.Location = new System.Drawing.Point(1045, 406);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(113, 78);
            this.btnOrder.TabIndex = 1;
            this.btnOrder.UseVisualStyleBackColor = false;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button3.BackgroundImage = global::cafe.Properties.Resources._66847;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Location = new System.Drawing.Point(982, 490);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(113, 78);
            this.button3.TabIndex = 1;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // lvNewAdded
            // 
            this.lvNewAdded.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvNewAdded.HideSelection = false;
            this.lvNewAdded.Location = new System.Drawing.Point(147, 497);
            this.lvNewAdded.Name = "lvNewAdded";
            this.lvNewAdded.Size = new System.Drawing.Size(309, 92);
            this.lvNewAdded.TabIndex = 14;
            this.lvNewAdded.UseCompatibleStateImageBehavior = false;
            this.lvNewAdded.View = System.Windows.Forms.View.Details;
            this.lvNewAdded.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "AdditionId";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "ProductId";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Count";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "TableId";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "deletedId";
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cafe.Properties.Resources.cement_concrete_wall_texture_background_decorated_loft_style_use_backdrop_wallpaper_149453_392;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1219, 591);
            this.Controls.Add(this.lvNewAdded);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.lblTableNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmOrder";
            this.Load += new System.EventHandler(this.frmOrder_Load);
            this.menu.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableNo;
        private System.Windows.Forms.Button btnDrinks2;
        private System.Windows.Forms.GroupBox menu;
        private System.Windows.Forms.Button btnFastFood5;
        private System.Windows.Forms.Button btnSweets3;
        private System.Windows.Forms.Button btnMainDish1;
        private System.Windows.Forms.Button btnSoup6;
        private System.Windows.Forms.Button btnSalads4;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnPasta7;
        private System.Windows.Forms.Button btnAraSıcak8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvMenu;
        private System.Windows.Forms.ColumnHeader productName;
        private System.Windows.Forms.ColumnHeader productPrice;
        private System.Windows.Forms.ColumnHeader productNo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListView lvOrders;
        private System.Windows.Forms.ColumnHeader productName1;
        private System.Windows.Forms.ColumnHeader productCount;
        private System.Windows.Forms.ColumnHeader productPrice1;
        private System.Windows.Forms.ColumnHeader productId;
        private System.Windows.Forms.ColumnHeader salesId;
        private System.Windows.Forms.ColumnHeader deletedId;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView lvNewAdded;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}