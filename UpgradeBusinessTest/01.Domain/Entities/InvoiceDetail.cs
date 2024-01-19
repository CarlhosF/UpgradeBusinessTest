using System.ComponentModel.DataAnnotations.Schema;

namespace UpgradeBusinessTest._01.Domain.Entities
{
    public class InvoiceDetail
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public string ProductId { get; set; }
        public Product Product { get; set; }
        [ForeignKey("Invoice")]
        public int InvoiceId { get; set; }
        public InvoiceHeader Invoice { get; set; }

        public decimal TotalLine { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

    }
}
