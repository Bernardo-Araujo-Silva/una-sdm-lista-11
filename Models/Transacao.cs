namespace GlobalBankApi.Models
{
    public class Transacao
    {
        public int Id { get; set; }
        public int ContaId { get; set; }
        public string? Tipo { get; set; } // Deposito ou Saque
        public decimal Valor { get; set; }
        public DateTime DataTransacao { get; set; }
    }
}