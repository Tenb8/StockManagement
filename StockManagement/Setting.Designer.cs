namespace StockManagement
{
    partial class Setting
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
            this.label2 = new System.Windows.Forms.Label();
            this.serverTxt = new System.Windows.Forms.TextBox();
            this.databaseLabel = new System.Windows.Forms.Label();
            this.databaseTxt = new System.Windows.Forms.TextBox();
         //   this.userLabel = new System.Windows.Forms.Label();
            this.userIdTxt = new System.Windows.Forms.TextBox();
            this.pass = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.isCB = new System.Windows.Forms.CheckBox();
            this.savebtn = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.savebtn);
            this.leftPanel.Controls.Add(this.isCB);
            this.leftPanel.Controls.Add(this.passwordTxt);
            this.leftPanel.Controls.Add(this.userIdTxt);
            this.leftPanel.Controls.Add(this.databaseTxt);
            this.leftPanel.Controls.Add(this.pass);
        //    this.leftPanel.Controls.Add(this.userLabel);
            this.leftPanel.Controls.Add(this.serverTxt);
            this.leftPanel.Controls.Add(this.databaseLabel);
            this.leftPanel.Controls.Add(this.label2);
            this.leftPanel.Size = new System.Drawing.Size(240, 557);
            this.leftPanel.Controls.SetChildIndex(this.panel2, 0);
            this.leftPanel.Controls.SetChildIndex(this.label2, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.serverTxt, 0);
         //   this.leftPanel.Controls.SetChildIndex(this.userLabel, 0);
            this.leftPanel.Controls.SetChildIndex(this.userIdTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.pass, 0);
            this.leftPanel.Controls.SetChildIndex(this.databaseTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.userIdTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.passwordTxt, 0);
            this.leftPanel.Controls.SetChildIndex(this.isCB, 0);
            this.leftPanel.Controls.SetChildIndex(this.savebtn, 0);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(240, 100);
            // 
            // rightPanel
            // 
            this.rightPanel.Location = new System.Drawing.Point(240, 0);
            this.rightPanel.Size = new System.Drawing.Size(567, 557);
            this.rightPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightPanel_Paint);
            // 
            // userLabel
            // 
         //   this.userLabel.AutoSize = true;
         //   this.userLabel.Location = new System.Drawing.Point(5, 297);
         //   this.userLabel.TabIndex = 10;

           // this.userLabel.Name = "user ID";
          //  this.userLabel.Dock = System.Windows.Forms.DockStyle.None;
      //  this.userLabel.Location = new System.Drawing.Point(43, 13);
      //    this.userLabel.Size = new System.Drawing.Size(51, 28);
         //   this.userLabel.Click += new System.EventHandler(this.userLabel_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Server";
            this.databaseLabel.TabIndex = 1;
            // 
            // serverTxt
            // 
            this.serverTxt.Location = new System.Drawing.Point(106, 162);
            this.serverTxt.MaxLength = 50;
            this.serverTxt.Name = "serverTxt";
            this.serverTxt.Size = new System.Drawing.Size(100, 23);
            this.serverTxt.TabIndex = 2;
            // 
            // databaseLabel
            // 
            this.databaseLabel.AutoSize = true;
            this.databaseLabel.Location = new System.Drawing.Point(-1, 199);
            this.databaseLabel.Name = "databaseLabel";
            this.databaseLabel.Size = new System.Drawing.Size(55, 15);
            this.databaseLabel.TabIndex = 1;
            this.databaseLabel.Text = "Database";
            // 
            // databaseTxt
            // 
            this.databaseTxt.Location = new System.Drawing.Point(105, 191);
            this.databaseTxt.MaxLength = 50;
            this.databaseTxt.Name = "databaseTxt";
            this.databaseTxt.Size = new System.Drawing.Size(100, 23);
            this.databaseTxt.TabIndex = 2;
            this.databaseTxt.TextChanged += new System.EventHandler(this.databaseTxt_TextChanged);
            // 
            // userIdTxt
            // 
            this.userIdTxt.Location = new System.Drawing.Point(106, 126);
            this.userIdTxt.MaxLength = 50;
            this.userIdTxt.Name = "userIdTxt";
            this.userIdTxt.Size = new System.Drawing.Size(100, 23);
            this.userIdTxt.TabIndex = 2;
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(4, 294);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(58, 15);
            this.pass.TabIndex = 1;
            this.pass.Text = "passLabel";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(92, 294);
            this.passwordTxt.MaxLength = 30;
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(100, 23);
            this.passwordTxt.TabIndex = 2;
            this.passwordTxt.UseSystemPasswordChar = true;
            // 
            // isCB
            // 
            this.isCB.AutoSize = true;
            this.isCB.Location = new System.Drawing.Point(6, 384);
            this.isCB.Name = "isCB";
            this.isCB.Size = new System.Drawing.Size(115, 19);
            this.isCB.TabIndex = 3;
            this.isCB.Text = "Integred Security";
            this.isCB.UseVisualStyleBackColor = true;
            this.isCB.CheckedChanged += new System.EventHandler(this.isCB_CheckedChanged);
            // 
            // savebtn
            // 
            this.savebtn.FlatAppearance.BorderSize = 2;
            this.savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.savebtn.Location = new System.Drawing.Point(0, 420);
            this.savebtn.Name = "savebtn";
            this.savebtn.Size = new System.Drawing.Size(151, 34);
            this.savebtn.TabIndex = 4;
            this.savebtn.Text = "SAVE";
            this.savebtn.UseVisualStyleBackColor = true;
            this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 557);
            this.Name = "Setting";
            this.Text = "Setting";
            this.Load += new System.EventHandler(this.Setting_Load);
            this.leftPanel.ResumeLayout(false);
            this.leftPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button savebtn;
        private System.Windows.Forms.CheckBox isCB;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.TextBox userIdTxt;
        private System.Windows.Forms.TextBox databaseTxt;
        private System.Windows.Forms.Label pass;
       // protected new System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.TextBox serverTxt;
        private System.Windows.Forms.Label databaseLabel;
        private System.Windows.Forms.Label label2;
    }
}