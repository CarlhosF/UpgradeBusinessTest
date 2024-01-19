using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpgradeBusinessTest._01.Domain.Entities;
using UpgradeBusinessTest._02.Core.Helpers;
using UpgradeBusinessTest._02.Core.Interfaces;

namespace UpgradeBusinessTest._05.Views.Invoices
{
    public partial class InvoiceGestor : Form
    {
        private readonly IGenericRepository<Client> _customerRepository;
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<InvoiceHeader> _invoiceRepository;

        public InvoiceGestor(IGenericRepository<Client> customerRepository
            , IGenericRepository<Product> productRepository
            , IGenericRepository<InvoiceHeader> invoiceRepository

            )
        {
            InitializeComponent();
            _customerRepository = customerRepository;
            _productRepository = productRepository;
            _invoiceRepository = invoiceRepository;
        }

        #region EventMethods
        private void InvoiceGestor_Load(object sender, EventArgs e)
        {
            ClenFields();
        }
        private async void BtnBuscarCliente_Click(object sender, EventArgs e)
        {
            var customer = await GetCustomerFromTextBox();
            if (customer == null) return;
            txBNombre.Text = customer.CardName;
            txBDireccion.Text = customer.Addres;
            TxBIdCliente.Text = customer.CardCode;
            return;
        }
        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            var customer = await GetCustomerFromTextBox();
            if (customer == null) goto theEnd;
            if (!MessageBoxHelper.ShowConfirmation($"¿Esta seguro que desea eliminar el cliente \"{customer.CardName}\"?", "Confirmación")) goto theEnd;
            var isSucces=await _customerRepository.Delete(customer.CardCode, MessageBoxHelper.ShowAlert);
            if(isSucces) MessageBoxHelper.ShowAlert($"El cliente con el id  {customer.CardCode} fue eliminado", "Información");
            txBNombre.Text = string.Empty;
            txBDireccion.Text = string.Empty;
            TxBIdCliente.Text = string.Empty;
        theEnd:
            return;

        }
        private async void BtnModificar_Click(object sender, EventArgs e)
        {
            var customer = await GetCustomerFromTextBox();
            if (customer == null) goto theEnd;
            if (!MessageBoxHelper.ShowConfirmation("¿Esta seguro que desea actualiza la informacion del cliente?", "Confirmación")) goto theEnd;
            customer.CardName = txBNombre.Text;
            customer.Addres = txBDireccion.Text;
            await _customerRepository.Update(customer, MessageBoxHelper.ShowAlert);
            MessageBoxHelper.ShowAlert($"La información del cliente ha sido actualizada", "Información");
        theEnd:
            return;
        }
        private async void txBCodArt_Leave(object sender, EventArgs e)
        {
            var itemcode = txBCodArt.Text;
            BtnAgregarLinea.Enabled = false;
            if (!int.TryParse(txtCantidad.Text, out int qty)) qty = 1;
            var item = await _productRepository.GetByIdAsyng(itemcode);
            if (item == null)
            {
                txBPrice.Text = "0";
                txBTotalLine.Text = "0";
                txBDescArt.Text = "--";
                txtCantidad.Text = qty.ToString();
            }
            else
            {
                BtnAgregarLinea.Enabled = true;
                txBPrice.Text = item.UnitPrice.ToString();
                txBTotalLine.Text = (item.UnitPrice * qty).ToString();
                txBDescArt.Text = item.ItemName;
                txtCantidad.Text = qty.ToString();
            }
        }
        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCantidad.Text, out int qty)) qty = 1;
            if (qty == 0) qty = 1;
            if (!decimal.TryParse(txBPrice.Text, out decimal unitPrice)) unitPrice = 0;
            txBTotalLine.Text = (unitPrice * qty).ToString();
            txtCantidad.Text = qty.ToString();
        }
        private void BtnAgregarLinea_Click(object sender, EventArgs e)
        {
            dtLineas.Rows.Add(txBCodArt.Text, txBDescArt.Text, txtCantidad.Text, txBPrice.Text, txBTotalLine.Text);
            RefreshTotal();
            BtnQuitarLinea.Enabled = true;
            BtnAgregarLinea.Enabled = false;
            txBCodArt.Text = string.Empty;
            txBPrice.Text = "0";
            txBTotalLine.Text = "0";
            txBDescArt.Text = "--";
        }
        private void BtnQuitarLinea_Click(object sender, EventArgs e)
        {
            if (dtLineas.SelectedRows.Count == 0) return;
            DataGridViewRow filaSeleccionada = dtLineas.SelectedRows[0];
            if (filaSeleccionada.Cells[0].Value == null) return;
            dtLineas.Rows.Remove(filaSeleccionada);
            if (dtLineas.Rows.Count == 1) BtnQuitarLinea.Enabled = false;

            RefreshTotal();

        }
        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            var invoice = new InvoiceHeader();
            var clientExist = await _customerRepository.GetAllAsyng(p => p.CardCode.Equals(TxBIdCliente.Text));
            if (clientExist.Count == 0) await _customerRepository.Create(new Client() { Addres = txBDireccion.Text, CardCode = TxBIdCliente.Text, CardName = txBNombre.Text, CreationDate = DateTime.Now });
            invoice.ClientId = TxBIdCliente.Text;
            invoice.Date=DateTime.Now;
            invoice.Details = GetDetailsFromDataGridView();
            await _invoiceRepository.Create(invoice, MessageBoxHelper.ShowAlert);
            ClenFields();
        }
        #endregion





        #region privateMethod
        public List<InvoiceDetail> GetDetailsFromDataGridView()
        {
            List<InvoiceDetail> invoiceDetails = new();
            foreach (DataGridViewRow fila in dtLineas.Rows)
            {
                if (fila != null && fila.Cells.Count >= 5)
                {
                    if (fila.Cells[0].Value == null) continue;
                    string productId = fila.Cells[0].Value?.ToString();
                    int quantity = Convert.ToInt32(fila.Cells[2].Value);
                    decimal unitPrice = Convert.ToDecimal(fila.Cells[3].Value);
                    decimal totalLine = Convert.ToDecimal(fila.Cells[4].Value);
                    InvoiceDetail invoiceDetail = new()
                    {
                        ProductId = productId,
                        Quantity = quantity,
                        UnitPrice = unitPrice,
                        TotalLine = totalLine
                    };
                    invoiceDetails.Add(invoiceDetail);
                }
            }
            return invoiceDetails;
        }
        private async Task<Client?> GetCustomerFromTextBox()
        {
            var idCliente = TxBIdCliente.Text;
            if (string.IsNullOrEmpty(idCliente) || idCliente.Length < 3)
            {
                MessageBoxHelper.ShowAlert("El id del cliente esta vacio o no tiene por lo menos 3 caracteres, Escriba el id del cliente que desea buscar", "Información");
                return null;
            }
            var resultBD = await _customerRepository.GetAllAsyng(p => p.CardCode.Contains(idCliente) || p.CardCode.Equals(idCliente));
            if (resultBD.Count == 0)
            {
                MessageBoxHelper.ShowAlert($"No existe el cliente con el id  {idCliente}", "Información");
                return null;
            }

            return resultBD.First();
        }
        private void RefreshTotal()
        {
            decimal sumaTotal = 0;
            foreach (DataGridViewRow fila in dtLineas.Rows)
            {
                if (fila != null && fila.Cells.Count >= 5 && fila.Cells[4].Value != null) sumaTotal += Convert.ToDecimal(fila.Cells[4].Value);
            }
            txBTotalInv.Text = sumaTotal.ToString();
        }
        private void ClenFields()
        {
            dtLineas.Rows.Clear();
            txBCodArt.Text = string.Empty;
            txBPrice.Text = "0";
            txBTotalLine.Text = "0";
            txBDescArt.Text = "--";
            txtCantidad.Text = "1";
            TxBIdCliente.Text = string.Empty;
            txBNombre.Text = string.Empty;
            txBDireccion.Text = string.Empty;
        }

        #endregion

    }
}
