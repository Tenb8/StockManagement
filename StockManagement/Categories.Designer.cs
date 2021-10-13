namespace StockManagement
{
    partial class Categories
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
            this.catNameTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.catNameErrorLabel = new System.Windows.Forms.Label();
            this.isactErrorLabel = new System.Windows.Forms.Label();
            this.activeDD = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.catIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameCatGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusCatGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(0, 0);
            // 
            // backBtn
            // 
            this.backBtn.FlatAppearance.BorderSize = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.activeDD);
            this.leftPanel.Controls.Add(this.catNameTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.catNameErrorLabel);
            this.leftPanel.Controls.Add(this.isactErrorLabel);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.isactErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.catNameErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.catNameTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.activeDD, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 49);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // catNameTxt
            // 
            this.catNameTxt.Location = new System.Drawing.Point(24, 179);
            this.catNameTxt.Name = "catNameTxt";
            this.catNameTxt.Size = new System.Drawing.Size(120, 23);
            this.catNameTxt.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 15);
            this.label6.TabIndex = 3;
            this.label6.Text = "Emplacement";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Categories Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // catNameErrorLabel
            // 
            this.catNameErrorLabel.AutoSize = true;
            this.catNameErrorLabel.Location = new System.Drawing.Point(125, 161);
            this.catNameErrorLabel.Name = "catNameErrorLabel";
            this.catNameErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.catNameErrorLabel.TabIndex = 5;
            this.catNameErrorLabel.Text = "*";
            // 
            // isactErrorLabel
            // 
            this.isactErrorLabel.AutoSize = true;
            this.isactErrorLabel.Location = new System.Drawing.Point(125, 222);
            this.isactErrorLabel.Name = "isactErrorLabel";
            this.isactErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.isactErrorLabel.TabIndex = 6;
            this.isactErrorLabel.Text = "*";
            // 
            // activeDD
            // 
            this.activeDD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.activeDD.FormattingEnabled = true;
            this.activeDD.Items.AddRange(new object[] {
            "N00002",
            "K00002"});
            this.activeDD.Location = new System.Drawing.Point(13, 245);
            this.activeDD.Name = "activeDD";
            this.activeDD.Size = new System.Drawing.Size(151, 23);
            this.activeDD.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.catIDGV,
            this.nameCatGV,
            this.statusCatGV});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(909, 273);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // catIDGV
            // 
            this.catIDGV.HeaderText = "catID";
            this.catIDGV.Name = "catIDGV";
            this.catIDGV.ReadOnly = true;
            this.catIDGV.Visible = false;
            // 
            // nameCatGV
            // 
            this.nameCatGV.HeaderText = "Name";
            this.nameCatGV.Name = "nameCatGV";
            this.nameCatGV.ReadOnly = true;
            // 
            // statusCatGV
            // 
            this.statusCatGV.HeaderText = "Emplacement";
            this.statusCatGV.Name = "statusCatGV";
            this.statusCatGV.ReadOnly = true;
            // 
            // Categories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 425);
            this.Name = "Categories";
            this.Text = "Categories";
            this.Load += new System.EventHandler(this.Categories_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox catNameTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label catNameErrorLabel;
        private System.Windows.Forms.Label isactErrorLabel;
        private System.Windows.Forms.ComboBox activeDD;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn catIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameCatGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusCatGV;
    }
}