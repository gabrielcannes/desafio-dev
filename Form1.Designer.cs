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
            this.UploadBtn = new System.Windows.Forms.Button();
            this.pathLb = new System.Windows.Forms.Label();
            this.pathTb = new System.Windows.Forms.TextBox();
            this.transactionsGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BalanceGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // UploadBtn
            // 
            this.UploadBtn.Location = new System.Drawing.Point(714, 7);
            this.UploadBtn.Margin = new System.Windows.Forms.Padding(4);
            this.UploadBtn.Name = "UploadBtn";
            this.UploadBtn.Size = new System.Drawing.Size(197, 39);
            this.UploadBtn.TabIndex = 0;
            this.UploadBtn.Text = "Upload CNAB";
            this.UploadBtn.UseVisualStyleBackColor = true;
            this.UploadBtn.Click += new System.EventHandler(this.UploadBtn_Click);
            // 
            // pathLb
            // 
            this.pathLb.AutoSize = true;
            this.pathLb.Location = new System.Drawing.Point(32, 13);
            this.pathLb.Name = "pathLb";
            this.pathLb.Size = new System.Drawing.Size(88, 25);
            this.pathLb.TabIndex = 1;
            this.pathLb.Text = "File Path";
            // 
            // pathTb
            // 
            this.pathTb.AccessibleRole = System.Windows.Forms.AccessibleRole.ListItem;
            this.pathTb.Location = new System.Drawing.Point(126, 11);
            this.pathTb.Name = "pathTb";
            this.pathTb.Size = new System.Drawing.Size(581, 30);
            this.pathTb.TabIndex = 3;
            // 
            // transactionsGridView
            // 
            this.transactionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.transactionsGridView.Location = new System.Drawing.Point(8, 53);
            this.transactionsGridView.Name = "transactionsGridView";
            this.transactionsGridView.RowHeadersWidth = 62;
            this.transactionsGridView.RowTemplate.Height = 28;
            this.transactionsGridView.Size = new System.Drawing.Size(1010, 440);
            this.transactionsGridView.TabIndex = 4;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1034, 537);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.UploadBtn);
            this.tabPage1.Controls.Add(this.transactionsGridView);
            this.tabPage1.Controls.Add(this.pathLb);
            this.tabPage1.Controls.Add(this.pathTb);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1026, 499);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "CNAB Uploader";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.BalanceGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1026, 499);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Total Balance";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BalanceGridView
            // 
            this.BalanceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BalanceGridView.Location = new System.Drawing.Point(8, 38);
            this.BalanceGridView.Name = "BalanceGridView";
            this.BalanceGridView.RowHeadersWidth = 62;
            this.BalanceGridView.RowTemplate.Height = 28;
            this.BalanceGridView.Size = new System.Drawing.Size(1010, 431);
            this.BalanceGridView.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Total Balance Order By CPF:";
            // 
            // form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1037, 550);
            this.Controls.Add(this.tabControl1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "form";
            this.Text = "CNAB Uploader";
            ((System.ComponentModel.ISupportInitialize)(this.transactionsGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BalanceGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UploadBtn;
        private System.Windows.Forms.Label pathLb;
        private System.Windows.Forms.TextBox pathTb;
        private System.Windows.Forms.DataGridView transactionsGridView;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BalanceGridView;
    }
}

