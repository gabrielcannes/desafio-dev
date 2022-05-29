using System;
using System.Data;
using System.Data.SqlClient;

namespace Desafio_devcsharp
{
    public class sqlQueryes
    {
        string connectionString = "Data Source=localhost\\sqlexpress;Initial Catalog=financestransactions;Integrated Security=True";
        public DataTable selectAllFromTransactionsOrderByCPF()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand("SELECT * FROM transactions t order by cpf", connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public DataTable selectCurrentBalanceBasedOnTransactions()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            SqlCommand command = new SqlCommand(
                "SELECT t.storeowner, t.storename, t.cpf, SUM(value) as totalbalance " +
                "FROM transactions t " +
                "GROUP BY  t.storeowner, t.storename, t.cpf; ",
                connection);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        public void InsertCnabIntoDataBase(TransactionInfo transactionInfo)
        {
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                String sql = "INSERT INTO transactions(type,date,value,cpf,card,time,storeowner,storename)" +
                    "VALUES (" +
                    "'"   + transactionInfo.type + "'" + ","
                    + "'" + transactionInfo.date + "'" + ","
                          + transactionInfo.value + ","
                    + "'" + transactionInfo.cpf + "'" + ","
                    + "'" + transactionInfo.card + "'" + ","
                    + "'" + transactionInfo.time + "'" + ","
                    + "'" + transactionInfo.storeOwner + "'" + ","
                    + "'" + transactionInfo.storeName + "'" +
                    ")";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
