namespace StockManagement
{
    partial class PurchaseInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.purchasDD = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.barecodeTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.prodTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.quantityTxt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.priceTxt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.proIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pupGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalGv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteGV = new System.Windows.Forms.DataGridViewButtonColumn();
            this.addcardBtn = new System.Windows.Forms.Button();
            this.grossLabel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.reeeeeee = new System.Windows.Forms.Label();
            this.suplierErrorLabel = new System.Windows.Forms.Label();
            this.barecodeErrorLabel = new System.Windows.Forms.Label();
            this.qutityErrorLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.totaLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel5.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
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
            this.leftPanel.Controls.Add(this.totaLabel);
            this.leftPanel.Controls.Add(this.label7);
            this.leftPanel.Controls.Add(this.addcardBtn);
            this.leftPanel.Controls.Add(this.priceTxt);
            this.leftPanel.Controls.Add(this.label6);
            this.leftPanel.Controls.Add(this.quantityTxt);
            this.leftPanel.Controls.Add(this.prodTxt);
            this.leftPanel.Controls.Add(this.barecodeTxt);
            this.leftPanel.Controls.Add(this.purchasDD);
            this.leftPanel.Controls.Add(this.label5);
            this.leftPanel.Controls.Add(this.label4);
            this.leftPanel.Controls.Add(this.label3);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Controls.Add(this.suplierErrorLabel);
            this.leftPanel.Controls.Add(this.barecodeErrorLabel);
            this.leftPanel.Controls.Add(this.qutityErrorLabel);
            this.leftPanel.Size = new System.Drawing.Size(165, 552);
            this.leftPanel.Controls.SetChildIndex(this.panel4, 0);
            this.leftPanel.Controls.SetChildIndex(this.qutityErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.barecodeErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.suplierErrorLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label3, 0);
            this.leftPanel.Controls.SetChildIndex(this.label4, 0);
            this.leftPanel.Controls.SetChildIndex(this.label5, 0);
            this.leftPanel.Controls.SetChildIndex(this.purchasDD, 0);
            this.leftPanel.Controls.SetChildIndex(this.barecodeTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.prodTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.quantityTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.label6, 0);
            this.leftPanel.Controls.SetChildIndex(this.priceTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.addcardBtn, 0);
            this.leftPanel.Controls.SetChildIndex(this.label7, 0);
            this.leftPanel.Controls.SetChildIndex(this.totaLabel, 0);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(0, 49);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.panel5);
            this.rightPanel.Controls.Add(this.dataGridView1);
            this.rightPanel.Size = new System.Drawing.Size(909, 552);
            this.rightPanel.Controls.SetChildIndex(this.panel3, 0);
            this.rightPanel.Controls.SetChildIndex(this.dataGridView1, 0);
            this.rightPanel.Controls.SetChildIndex(this.panel5, 0);
            // 
            // userLabel
            // 
            this.userLabel.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Select Supplier";
            // 
            // purchasDD
            // 
            this.purchasDD.FormattingEnabled = true;
            this.purchasDD.Location = new System.Drawing.Point(1, 184);
            this.purchasDD.Name = "purchasDD";
            this.purchasDD.Size = new System.Drawing.Size(161, 23);
            this.purchasDD.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Barecode";
            // 
            // barecodeTxt
            // 
            this.barecodeTxt.Location = new System.Drawing.Point(4, 234);
            this.barecodeTxt.MaxLength = 100;
            this.barecodeTxt.Name = "barecodeTxt";
            this.barecodeTxt.Size = new System.Drawing.Size(157, 23);
            this.barecodeTxt.TabIndex = 1;
            this.barecodeTxt.TextChanged += new System.EventHandler(this.barecodeTxt_TextChanged);
            this.barecodeTxt.Validating += new System.ComponentModel.CancelEventHandler(this.barecodeTxt_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Select Products";
            // 
            // prodTxt
            // 
            this.prodTxt.Location = new System.Drawing.Point(1, 278);
            this.prodTxt.Name = "prodTxt";
            this.prodTxt.Size = new System.Drawing.Size(157, 23);
            this.prodTxt.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 346);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 1;
            this.label5.Text = "Select Quantity";
            // 
            // quantityTxt
            // 
            this.quantityTxt.Location = new System.Drawing.Point(0, 363);
            this.quantityTxt.Name = "quantityTxt";
            this.quantityTxt.Size = new System.Drawing.Size(157, 23);
            this.quantityTxt.TabIndex = 4;
            this.quantityTxt.TextChanged += new System.EventHandler(this.quantityTxt_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 15);
            this.label6.TabIndex = 4;
            this.label6.Text = "Per Unit";
            // 
            // priceTxt
            // 
            this.priceTxt.Location = new System.Drawing.Point(0, 320);
            this.priceTxt.MaxLength = 50;
            this.priceTxt.Name = "priceTxt";
            this.priceTxt.Size = new System.Drawing.Size(157, 23);
            this.priceTxt.TabIndex = 3;
            this.priceTxt.TextChanged += new System.EventHandler(this.priceTxt_TextChanged);
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
            this.proIDGV,
            this.proGV,
            this.quantityGV,
            this.pupGV,
            this.totalGv,
            this.deleteGV});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 152);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(909, 252);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // proIDGV
            // 
            this.proIDGV.HeaderText = "Product ID";
            this.proIDGV.Name = "proIDGV";
            this.proIDGV.ReadOnly = true;
            this.proIDGV.Visible = false;
            // 
            // proGV
            // 
            this.proGV.HeaderText = "Product Name";
            this.proGV.Name = "proGV";
            this.proGV.ReadOnly = true;
            // 
            // quantityGV
            // 
            this.quantityGV.HeaderText = "Quantity";
            this.quantityGV.Name = "quantityGV";
            this.quantityGV.ReadOnly = true;
            // 
            // pupGV
            // 
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.pupGV.DefaultCellStyle = dataGridViewCellStyle1;
            this.pupGV.HeaderText = "Per UNit";
            this.pupGV.Name = "pupGV";
            this.pupGV.ReadOnly = true;
            // 
            // totalGv
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.totalGv.DefaultCellStyle = dataGridViewCellStyle2;
            this.totalGv.HeaderText = "Total Amount";
            this.totalGv.Name = "totalGv";
            this.totalGv.ReadOnly = true;
            // 
            // deleteGV
            // 
            this.deleteGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.deleteGV.HeaderText = "Action";
            this.deleteGV.Name = "deleteGV";
            this.deleteGV.ReadOnly = true;
            this.deleteGV.Text = "DELETE";
            this.deleteGV.UseColumnTextForButtonValue = true;
            // 
            // addcardBtn
            // 
            this.addcardBtn.FlatAppearance.BorderSize = 2;
            this.addcardBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcardBtn.Location = new System.Drawing.Point(69, 392);
            this.addcardBtn.Name = "addcardBtn";
            this.addcardBtn.Size = new System.Drawing.Size(87, 32);
            this.addcardBtn.TabIndex = 6;
            this.addcardBtn.Text = "ADD TO CARD";
            this.addcardBtn.UseVisualStyleBackColor = true;
            this.addcardBtn.Click += new System.EventHandler(this.addcardBtn_Click);
            // 
            // grossLabel
            // 
            this.grossLabel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grossLabel.Location = new System.Drawing.Point(457, 0);
            this.grossLabel.Name = "grossLabel";
            this.grossLabel.Size = new System.Drawing.Size(254, 89);
            this.grossLabel.TabIndex = 0;
            this.grossLabel.Text = "00";
            this.grossLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.tableLayoutPanel2);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 404);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(909, 148);
            this.panel5.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.reeeeeee, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.grossLabel, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(909, 148);
            this.tableLayoutPanel2.TabIndex = 8;
            // 
            // reeeeeee
            // 
            this.reeeeeee.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reeeeeee.Location = new System.Drawing.Point(3, 0);
            this.reeeeeee.Name = "reeeeeee";
            this.reeeeeee.Size = new System.Drawing.Size(448, 90);
            this.reeeeeee.TabIndex = 8;
            this.reeeeeee.Text = "Gross T:";
            this.reeeeeee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // suplierErrorLabel
            // 
            this.suplierErrorLabel.AutoSize = true;
            this.suplierErrorLabel.Location = new System.Drawing.Point(144, 166);
            this.suplierErrorLabel.Name = "suplierErrorLabel";
            this.suplierErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.suplierErrorLabel.TabIndex = 7;
            this.suplierErrorLabel.Text = "*";
            // 
            // barecodeErrorLabel
            // 
            this.barecodeErrorLabel.AutoSize = true;
            this.barecodeErrorLabel.Location = new System.Drawing.Point(147, 216);
            this.barecodeErrorLabel.Name = "barecodeErrorLabel";
            this.barecodeErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.barecodeErrorLabel.TabIndex = 8;
            this.barecodeErrorLabel.Text = "*";
            // 
            // qutityErrorLabel
            // 
            this.qutityErrorLabel.AutoSize = true;
            this.qutityErrorLabel.Location = new System.Drawing.Point(144, 345);
            this.qutityErrorLabel.Name = "qutityErrorLabel";
            this.qutityErrorLabel.Size = new System.Drawing.Size(12, 15);
            this.qutityErrorLabel.TabIndex = 9;
            this.qutityErrorLabel.Text = "*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 423);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Total Amount";
            // 
            // totaLabel
            // 
            this.totaLabel.AutoSize = true;
            this.totaLabel.Location = new System.Drawing.Point(105, 454);
            this.totaLabel.Name = "totaLabel";
            this.totaLabel.Size = new System.Drawing.Size(28, 15);
            this.totaLabel.TabIndex = 12;
            this.totaLabel.Text = "0.00";
            // 
            // PurchaseInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1074, 552);
            this.Name = "PurchaseInvoice";
            this.Text = "PurchaseInvoice";
            this.Load += new System.EventHandler(this.PurchaseInvoice_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel5.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox purchasDD;
        private System.Windows.Forms.TextBox priceTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quantityTxt;
        private System.Windows.Forms.TextBox prodTxt;
        private System.Windows.Forms.TextBox barecodeTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button addcardBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label grossLabel;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label suplierErrorLabel;
        private System.Windows.Forms.Label barecodeErrorLabel;
        private System.Windows.Forms.Label qutityErrorLabel;
        private System.Windows.Forms.Label reeeeeee;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label totaLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn proIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn proGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn pupGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalGv;
        private System.Windows.Forms.DataGridViewButtonColumn deleteGV;
    }
}