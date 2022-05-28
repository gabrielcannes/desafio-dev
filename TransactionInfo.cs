using System.Diagnostics.CodeAnalysis;

namespace Desafio_devcsharp
{
    [ExcludeFromCodeCoverage]
    public class TransactionInfo
    {
        public string Id { get; set; }
        public string type { get; set; }
        public string value { get; set; }
        public string cpf { get; set; }
        public string card { get; set; }
        public string time { get; set; }
        public string storeOwner { get; set; }
        public string storeName { get; set; } 
        public string date { get; set; }
        public string nature { get; set; }
    }
}
