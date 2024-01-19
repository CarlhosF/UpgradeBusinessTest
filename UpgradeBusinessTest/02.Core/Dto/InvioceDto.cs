using System;

namespace UpgradeBusinessTest._02.Core.Dto
{
    public  class InvioceDto
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string Cliente { get; set; }
        public decimal TotalFac { get; set; }
    }
}
