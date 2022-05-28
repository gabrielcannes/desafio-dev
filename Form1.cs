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
    }
}
