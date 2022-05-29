using System;
using System.Windows.Forms;

namespace Desafio_devcsharp
{
    public partial class form : Form
    {
        sqlQueryes queryes = new sqlQueryes();
        CnabInterpreter cnabInterpreter = new CnabInterpreter(); 
        public form()
        {
            InitializeComponent();
            ShowInTheGridViews();
        }

        private void UploadBtn_Click(object sender, EventArgs e)
        {
            FilePathFinder();
            cnabInterpreter.CnabParser(pathTb.Text);
            ShowInTheGridViews();
            MessageBox.Show("CNAB Uploaded.");
        }

        private void ShowInTheGridViews()
        {
           transactionsGridView.DataSource = queryes.selectAllFromTransactionsOrderByCPF();
           BalanceGridView.DataSource = queryes.selectCurrentBalanceBasedOnTransactions();
        }        

        public void FilePathFinder()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathTb.Text = openFileDialog.FileName;
            }
        }
        private void buttonMenu_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "HOME";
            LogoShow(true);
            UploadShow(false);
            TransactionsShow(false);
            BalanceShow(false);
        }

        private void buttonCnab_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "CNAB UPLOADER";
            UploadShow(true);
            LogoShow(false);
            TransactionsShow(false);
            BalanceShow(false);
        }

        private void buttonTransactionsList_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "TRANSACTIONS LIST";
            TransactionsShow(true);
            LogoShow(false);
            UploadShow(false);
            BalanceShow(false);
        }

        private void buttonBalance_Click(object sender, EventArgs e)
        {
            labelHeader.Text = "BALANCE LIST";
            BalanceShow(true);
            TransactionsShow(false);
            LogoShow(false);
            UploadShow(false);
        }

        private void BalanceShow (bool show)
        {
            BalanceGridView.Visible = show;
        }

        private void TransactionsShow(bool show)
        {
            transactionsGridView.Visible = show;
        }

        private void UploadShow(bool show)
        {
            pathLb.Visible = show;
            pathTb.Visible = show;
            UploadBtn.Visible = show;
        }
        private void LogoShow(bool show)
        {
            Logo.Visible = show;
        }
    }
}
