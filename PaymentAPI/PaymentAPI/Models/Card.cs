using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class Card
    {
        [Key]
        public int id { get; set; }
        public String CardHolderName { get; set; }
        public String CardNumber { get; set; }
        public int cvc { get; set; }
        public int ExpiryMonth { get; set; }
        public int ExpiryYesr { get; set; }
    }
}
