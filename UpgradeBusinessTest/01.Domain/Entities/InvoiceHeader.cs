using System;
using System.Collections.Generic;

namespace UpgradeBusinessTest._01.Domain.Entities
{
    public  class InvoiceHeader
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string ClientId { get; set; }
        public Client Client { get; set; }
        public List<InvoiceDetail> Details { get; set; } = new List<InvoiceDetail>();
    }
}
