namespace Desafio_devcsharp
{
    public class CnabInterpreter
    {
        string plus = "+";
        string minus = "-";
        TransactionInfo transactionInfo = new TransactionInfo();
        sqlQueryes queryes = new sqlQueryes();
        public void CnabParser(string filePath)
        {
            string[] fileLines = System.IO.File.ReadAllLines(filePath);
            foreach (string line in fileLines)
            {
                GetCnabData(line);
                queryes.InsertCnabIntoDataBase(transactionInfo);
            }
        }

        public void GetCnabData(string line)
        {
            transactionInfo.type = getTransactionInfoTypeBasedOnTypeCode(line.Remove(1));
            line = line.Remove(0, 1);
            transactionInfo.date = line.Remove(8);
            line = line.Remove(0, 8);
            transactionInfo.value = ValueCalculation(line.Remove(10));
            line = line.Remove(0, 10);
            transactionInfo.cpf = line.Remove(11);
            line = line.Remove(0, 11);
            transactionInfo.card = line.Remove(12);
            line = line.Remove(0, 12);
            transactionInfo.time = line.Remove(6);
            line = line.Remove(0, 6);
            transactionInfo.storeOwner = line.Remove(14);
            line = line.Remove(0, 14);
            transactionInfo.storeName = line;
        }

        public string ValueCalculation(string StringValue)
        {
            float value = float.Parse(StringValue) / 100;
            string returnValue = value.ToString();
            returnValue = returnValue.Insert(0, transactionInfo.nature);
            return returnValue.Replace(',', '.');
        }



        public string getTransactionInfoTypeBasedOnTypeCode(string typeCode)
        {
            if (typeCode == "1")
            {
                transactionInfo.nature = plus;
                return "Débito";
            }
            else if (typeCode == "2")
            {
                transactionInfo.nature = minus;
                return "Boleto"; 
            }
            else if (typeCode == "3")
            {
                transactionInfo.nature = minus;
                return "Financiamento";
            }
            else if (typeCode == "4")
            {
                transactionInfo.nature = plus;
                return "Crédito";
            }
            else if (typeCode == "5")
            {
                transactionInfo.nature = plus;
                return "Recebimento Empréstimo";
            }
            else if (typeCode == "6")
            {
                transactionInfo.nature = plus;
                return "Vendas";
            }
            else if (typeCode == "7")
            {
                transactionInfo.nature = plus;
                return "Recebimento TED";
            }
            else if (typeCode == "8")
            {
                transactionInfo.nature = plus;
                return "Recebimento DOC";
            }
            else if (typeCode == "9")
            {
                transactionInfo.nature = minus;
                return "Aluguel";
            }
            else return "";
        }
    }
}
