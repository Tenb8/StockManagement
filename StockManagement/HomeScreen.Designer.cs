namespace StockManagement
{
    partial class HomeScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeScreen));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userBtn = new System.Windows.Forms.Button();
            this.proDD = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.purchaseBtn = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.catBtn = new System.Windows.Forms.Button();
            this.suplierBtn = new System.Windows.Forms.Button();
            this.customerBtn = new System.Windows.Forms.Button();
            this.btnPrice = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Size = new System.Drawing.Size(165, 400);
            this.leftPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftPanel_Paint);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.tableLayoutPanel1);
            this.rightPanel.Size = new System.Drawing.Size(707, 400);
            this.rightPanel.Controls.SetChildIndex(this.tableLayoutPanel1, 0);
            // 
            // userLabel
            // 
            this.userLabel.Size = new System.Drawing.Size(662, 100);
            this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tableLayoutPanel1.BackgroundImage")));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.userBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.proDD, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.purchaseBtn, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.button5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.catBtn, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.suplierBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.customerBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnPrice, 3, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(707, 300);
            this.tableLayoutPanel1.TabIndex = 1;
            this.tableLayoutPanel1.UseWaitCursor = true;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // userBtn
            // 
            this.userBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.userBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.userBtn.FlatAppearance.BorderSize = 2;
            this.userBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.userBtn.Location = new System.Drawing.Point(3, 3);
            this.userBtn.Name = "userBtn";
            this.userBtn.Size = new System.Drawing.Size(135, 54);
            this.userBtn.TabIndex = 0;
            this.userBtn.Text = "Users";
            this.userBtn.UseVisualStyleBackColor = true;
            this.userBtn.UseWaitCursor = true;
            this.userBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // proDD
            // 
            this.proDD.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.proDD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.proDD.FlatAppearance.BorderSize = 2;
            this.proDD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.proDD.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.proDD.Location = new System.Drawing.Point(144, 3);
            this.proDD.Name = "proDD";
            this.proDD.Size = new System.Drawing.Size(135, 54);
            this.proDD.TabIndex = 1;
            this.proDD.Text = "Products -Товар";
            this.proDD.UseVisualStyleBackColor = true;
            this.proDD.UseWaitCursor = true;
            this.proDD.Click += new System.EventHandler(this.proDD_Click);
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button3.FlatAppearance.BorderSize = 2;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button3.Location = new System.Drawing.Point(285, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 54);
            this.button3.TabIndex = 1;
            this.button3.Text = "Stock";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.UseWaitCursor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // purchaseBtn
            // 
            this.purchaseBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.purchaseBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.purchaseBtn.FlatAppearance.BorderSize = 2;
            this.purchaseBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.purchaseBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.purchaseBtn.Location = new System.Drawing.Point(426, 3);
            this.purchaseBtn.Name = "purchaseBtn";
            this.purchaseBtn.Size = new System.Drawing.Size(135, 54);
            this.purchaseBtn.TabIndex = 1;
            this.purchaseBtn.Text = "Purchase Invoice-Покупка";
            this.purchaseBtn.UseVisualStyleBackColor = true;
            this.purchaseBtn.UseWaitCursor = true;
            this.purchaseBtn.Click += new System.EventHandler(this.purchaseBtn_Click);
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.button5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button5.FlatAppearance.BorderSize = 2;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.button5.Location = new System.Drawing.Point(567, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(137, 54);
            this.button5.TabIndex = 1;
            this.button5.Text = "Sales-Продажа";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.UseWaitCursor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // catBtn
            // 
            this.catBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.catBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.catBtn.FlatAppearance.BorderSize = 2;
            this.catBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.catBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.catBtn.Location = new System.Drawing.Point(3, 63);
            this.catBtn.Name = "catBtn";
            this.catBtn.Size = new System.Drawing.Size(135, 54);
            this.catBtn.TabIndex = 2;
            this.catBtn.Text = "Categories-Категории";
            this.catBtn.UseVisualStyleBackColor = true;
            this.catBtn.UseWaitCursor = true;
            this.catBtn.Click += new System.EventHandler(this.catBtn_Click);
            // 
            // suplierBtn
            // 
            this.suplierBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.suplierBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.suplierBtn.FlatAppearance.BorderSize = 2;
            this.suplierBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.suplierBtn.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.suplierBtn.Location = new System.Drawing.Point(144, 63);
            this.suplierBtn.Name = "suplierBtn";
            this.suplierBtn.Size = new System.Drawing.Size(135, 54);
            this.suplierBtn.TabIndex = 3;
            this.suplierBtn.Text = "Suplier-Поставшики";
            this.suplierBtn.UseVisualStyleBackColor = true;
            this.suplierBtn.UseWaitCursor = true;
            this.suplierBtn.Click += new System.EventHandler(this.suplierBtn_Click);
            // 
            // customerBtn
            // 
            this.customerBtn.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.customerBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customerBtn.FlatAppearance.BorderSize = 2;
            this.customerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.customerBtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.customerBtn.ForeColor = System.Drawing.Color.Coral;
            this.customerBtn.Location = new System.Drawing.Point(285, 63);
            this.customerBtn.Name = "customerBtn";
            this.customerBtn.Size = new System.Drawing.Size(135, 54);
            this.customerBtn.TabIndex = 4;
            this.customerBtn.Text = "CUstomer";
            this.customerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.customerBtn.UseVisualStyleBackColor = true;
            this.customerBtn.UseWaitCursor = true;
            this.customerBtn.Visible = true;
            this.customerBtn.Click += new System.EventHandler(this.customerBtn_Click);
            // 
            // btnPrice
            // 
            this.btnPrice.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnPrice.FlatAppearance.BorderSize = 2;
            this.btnPrice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnPrice.Location = new System.Drawing.Point(426, 63);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(135, 54);
            this.btnPrice.TabIndex = 5;
            this.btnPrice.Text = "Product Prices-Управление Цена";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.UseWaitCursor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // HomeScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 400);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name = "HomeScreen";
            this.Text = "HomeScreen";
            this.Load += new System.EventHandler(this.HomeScreen_Load);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button userBtn;
        private System.Windows.Forms.Button proDD;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button purchaseBtn;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button catBtn;
        private System.Windows.Forms.Button suplierBtn;
        private System.Windows.Forms.Button customerBtn;
        private System.Windows.Forms.Button btnPrice;
    }
}