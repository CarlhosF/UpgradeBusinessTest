using System;
using System.Windows.Forms;
using UpgradeBusinessTest._05.Views.Invoices;
using UpgradeBusinessTest._05.Views.Products;

namespace UpgradeBusinessTest._05.Views
{
    public partial class Main : Form
    {
        public Main(InvoiceGestor invoiceGestor, ProductManager productManager,ViewClientesAndInvoices viewClientesAndInvoices)
        {
            InitializeComponent();
            InvoiceGestor = invoiceGestor;
            ProductManager = productManager;
            ViewClientesAndInvoices = viewClientesAndInvoices;
        }

        public InvoiceGestor InvoiceGestor { get; }
        public ProductManager ProductManager { get; }
        public ViewClientesAndInvoices ViewClientesAndInvoices { get; }

        private void Main_Load(object sender, EventArgs e)
        {
            ProductManager.TopLevel = false;
            ProductManager.FormBorderStyle = FormBorderStyle.None;
            Body.Controls.Add(ProductManager);

            InvoiceGestor.TopLevel = false;
            InvoiceGestor.FormBorderStyle = FormBorderStyle.None;
            Body.Controls.Add(InvoiceGestor);

            ViewClientesAndInvoices.TopLevel = false;
            ViewClientesAndInvoices.FormBorderStyle = FormBorderStyle.None;
            Body.Controls.Add(ViewClientesAndInvoices);

            ShowInvoiceGestore();
        }
        

        private void btnGestionarItems_Click(object sender, EventArgs e)
        {
            ShowProducManager();
        }

        private void BtnInvoice_Click(object sender, EventArgs e)
        {
            ShowInvoiceGestore();
        }

        private void btnListas_Click(object sender, EventArgs e)
        {
            ShowViewInv();
        }

        private void ShowInvoiceGestore()
        {
            InvoiceGestor.Show();
            ProductManager.Hide();
            ViewClientesAndInvoices.Hide();
        }
        private void ShowProducManager()
        {
            ProductManager.Hide();
            ProductManager.Show();
            ViewClientesAndInvoices.Hide();
        }
        private void ShowViewInv()
        {
            ProductManager.Hide();
            InvoiceGestor.Hide();
            ViewClientesAndInvoices.Show();
        }
    }
}
