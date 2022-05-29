namespace Desafio_devcsharp
{
    partial class form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            this.UploadBtn = new System.Windows.Forms.Button();
            this.pathLb = new System.Windows.Forms.Label();
            this.pathTb = new System.Windows.Forms.TextBox();
            this.transactionsGridView = new System.Windows.Forms.DataGridView();
            this.BalanceGridView = new System.Windows.Forms.DataGridView();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonBalance = new System.Windows.Forms.Button();
            this.buttonTransactionsList = new System.Windows.Forms.Button();
            this.buttonCnab = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.Logo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceGridView)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(22)))), ((int)(((byte)(39)))));
            this.UploadBtn.FlatAppearance.BorderSize = 0;
            this.UploadBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UploadBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.UploadBtn.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UploadBtn.Location = new System.Drawing.Point(963, 108);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(168, 39);
            this.UploadBtn.TabIndex = 0;
            this.UploadBtn.Text = "Upload CNAB";
            this.UploadBtn.UseVisualStyleBackColor = false;
            this.UploadBtn.Visible = false;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // pathLb
            // 
            this.pathLb.AutoSize = true;
            this.pathLb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pathLb.Location = new System.Drawing.Point(256, 115);
            this.pathLb.Name = "pathLb";
            this.pathLb.Size = new System.Drawing.Size(132, 36);
            this.pathLb.TabIndex = 1;
            this.pathLb.Text = "File Path";
            this.pathLb.Visible = false;
            // 
            // pathTb
            // 
            this.pathTb.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.pathTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.pathTb.Location = new System.Drawing.Point(354, 113);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(581, 41);
            this.pathTb.TabIndex = 3;
            this.pathTb.Visible = false;
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Location = new System.Drawing.Point(220, 80);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.RowHeadersWidth = 62;
            this.transactionsGridView.RowTemplate.Height = 28;
            this.transactionsGridView.Size = new System.Drawing.Size(937, 492);
            this.transactionsGridView.TabIndex = 4;
            this.transactionsGridView.Visible = false;
            // 
            // BalanceGridView
            // 
            this.BalanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalanceGridView.Location = new System.Drawing.Point(220, 80);
            this.BalanceGridView.Name = "BalanceGridView";
            this.BalanceGridView.RowHeadersWidth = 62;
            this.BalanceGridView.RowTemplate.Height = 28;
            this.BalanceGridView.Size = new System.Drawing.Size(937, 492);
            this.BalanceGridView.TabIndex = 5;
            this.BalanceGridView.Visible = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonBalance);
            this.panelMenu.Controls.Add(this.buttonTransactionsList);
            this.panelMenu.Controls.Add(this.buttonCnab);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 572);
            this.panelMenu.TabIndex = 6;
            // 
            // buttonBalance
            // 
            this.buttonBalance.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonBalance.FlatAppearance.BorderSize = 0;
            this.buttonBalance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBalance.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonBalance.Location = new System.Drawing.Point(0, 200);
            this.buttonBalance.Name = "buttonBalance";
            this.buttonBalance.Size = new System.Drawing.Size(220, 60);
            this.buttonBalance.TabIndex = 10;
            this.buttonBalance.Text = "Current Balance List";
            this.buttonBalance.UseVisualStyleBackColor = true;
            this.buttonBalance.Click += new System.EventHandler(this.buttonBalance_Click);
            // 
            // buttonTransactionsList
            // 
            this.buttonTransactionsList.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonTransactionsList.FlatAppearance.BorderSize = 0;
            this.buttonTransactionsList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTransactionsList.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonTransactionsList.Location = new System.Drawing.Point(0, 140);
            this.buttonTransactionsList.Name = "buttonTransactionsList";
            this.buttonTransactionsList.Size = new System.Drawing.Size(220, 60);
            this.buttonTransactionsList.TabIndex = 9;
            this.buttonTransactionsList.Text = "Transactions List";
            this.buttonTransactionsList.UseVisualStyleBackColor = true;
            this.buttonTransactionsList.Click += new System.EventHandler(this.buttonTransactionsList_Click);
            // 
            // buttonCnab
            // 
            this.buttonCnab.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonCnab.FlatAppearance.BorderSize = 0;
            this.buttonCnab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCnab.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonCnab.Location = new System.Drawing.Point(0, 80);
            this.buttonCnab.Name = "buttonCnab";
            this.buttonCnab.Size = new System.Drawing.Size(220, 60);
            this.buttonCnab.TabIndex = 8;
            this.buttonCnab.Text = "Upload CNAB";
            this.buttonCnab.UseVisualStyleBackColor = true;
            this.buttonCnab.Click += new System.EventHandler(this.buttonCnab_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.buttonMenu);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 80);
            this.panelLogo.TabIndex = 7;
            // 
            // buttonMenu
            // 
            this.buttonMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMenu.FlatAppearance.BorderSize = 0;
            this.buttonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonMenu.Location = new System.Drawing.Point(0, 0);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(220, 80);
            this.buttonMenu.TabIndex = 7;
            this.buttonMenu.Text = "MAIN MENU";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.buttonMenu_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panel1.Controls.Add(this.labelHeader);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(220, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(937, 80);
            this.panel1.TabIndex = 7;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.labelHeader.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelHeader.Location = new System.Drawing.Point(408, 21);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(140, 46);
            this.labelHeader.TabIndex = 0;
            this.labelHeader.Text = "HOME";
            // 
            // Logo
            // 
            this.Logo.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.Logo.FlatAppearance.BorderSize = 10;
            this.Logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(220, 80);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(937, 492);
            this.Logo.TabIndex = 8;
            this.Logo.UseVisualStyleBackColor = true;
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1157, 572);
            this.Controls.Add(this.Logo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.UploadBtn);
            this.Controls.Add(this.pathLb);
            this.Controls.Add(this.pathTb);
            this.Controls.Add(this.transactionsGridView);
            this.Controls.Add(this.BalanceGridView);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form";
            this.Text = "CNAB Uploader";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceGridView)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label pathLb;
        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.DataGridView transactionsGridView;
        private System.Windows.Forms.DataGridView BalanceGridView;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonBalance;
        private System.Windows.Forms.Button buttonTransactionsList;
        private System.Windows.Forms.Button buttonCnab;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button Logo;
    }
}

