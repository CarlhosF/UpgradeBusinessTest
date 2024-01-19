using System;
using System.Linq;
using System.Windows.Forms;
using UpgradeBusinessTest._01.Domain.Entities;
using UpgradeBusinessTest._02.Core.Dto;
using UpgradeBusinessTest._02.Core.Interfaces;

namespace UpgradeBusinessTest._05.Views.Invoices
{
    public partial class ViewClientesAndInvoices : Form
    {
        private readonly IGenericRepository<Client> clientRepository;
        private readonly IGenericRepository<InvoiceHeader> invoiceRepository;

        public ViewClientesAndInvoices(IGenericRepository<Client> clientRepository, IGenericRepository<InvoiceHeader> invoiceRepository)
        {
            InitializeComponent();
            this.clientRepository = clientRepository;
            this.invoiceRepository = invoiceRepository;
        }

        private async void ViewClientesAndInvoices_Load(object sender, EventArgs e)
        {
            dtClientes.DataSource = await clientRepository.GetAllAsyng();
            var allinvs = await invoiceRepository.GetAllAsyng(null, "Details");
            var invs = allinvs.Select(p => new InvioceDto() { Cliente = p.ClientId, Fecha = p.Date, Id = p.Id, TotalFac = p.Details.Sum(p => p.TotalLine) }).ToList();
            dtFacturas.DataSource = invs;
        }
    }
}

