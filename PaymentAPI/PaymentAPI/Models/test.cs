using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PaymentAPI.Models
{
    public class test
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = "";
        [Column(TypeName = "nvarchar(100)")]
        public string SurName { get; set; } = "";

        [Column(TypeName = "nvarchar(100)")]
        public string SecurityCode { get; set; } = "";
    }
}
