using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using UpgradeBusinessTest._01.Domain.Entities;
using UpgradeBusinessTest._02.Core.Helpers;
using UpgradeBusinessTest._02.Core.Interfaces;

namespace UpgradeBusinessTest._05.Views.Products
{
    public partial class ProductManager : Form
    {
        private readonly IGenericRepository<Product> productRepository;

        public ProductManager(IGenericRepository<Product> productRepository)
        {
            InitializeComponent();
            this.productRepository = productRepository;
        }


        private async void ProductManager_Load(object sender, EventArgs e)
        {
            await ReloadData();
        }

        private void BtnAgregarItem_Click(object sender, EventArgs e)
        {
            ProductDetail productDetailForm = new ProductDetail("Crear producto");
            productDetailForm.AceptarClick += ProductDetail_AceptarClick;
            productDetailForm.ShowDialog();
        }
        private async void ProductDetail_AceptarClick(object sender, ProductDetailEventArgs e)
        {
            string? itemCode = e.ItemCode;
            string? itemName = e.ItemName;
            decimal? unitPrice = e.UnitPrice1;

            bool? isCreate = e.IsCreate;

            if (isCreate == null || itemCode == null || itemName == null || unitPrice == null) { MessageBoxHelper.ShowAlert("No se pudo obtener la informacion del producto", "Alerta"); return; }

            if (isCreate.Value)
            {
                await productRepository.Create(new Product() { ItemCode = itemCode, ItemName = itemName, UnitPrice = unitPrice.Value }, MessageBoxHelper.ShowAlert);
            }
            else
            {
                await productRepository.Update(new Product() { ItemCode = itemCode, ItemName = itemName, UnitPrice = unitPrice.Value }, MessageBoxHelper.ShowAlert);
            }
            await ReloadData();

        }

        private async Task ReloadData()
        {
            var products = await productRepository.GetAllAsyng();
            dtProductos.DataSource = products;
        }

        private void dtProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow filaSeleccionada = dtProductos.Rows[rowIndex];
                if (filaSeleccionada.Cells[0].Value.ToString() == null) return;
                var itemcode = filaSeleccionada.Cells[0].Value.ToString();
                var itemName = filaSeleccionada.Cells[1].Value.ToString();
                var unitPrice = decimal.Parse(filaSeleccionada.Cells[2].Value.ToString());
                ProductDetail productDetailForm = new ProductDetail(itemcode, itemName, unitPrice, "Actualizar producto");
                productDetailForm.AceptarClick += ProductDetail_AceptarClick;
                productDetailForm.ShowDialog();
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtProductos.SelectedRows.Count == 0) return;
            DataGridViewRow filaSeleccionada = dtProductos.SelectedRows[0];
            if (filaSeleccionada.Cells[0].Value.ToString() == null) return;
            var itemCode = filaSeleccionada.Cells[0].Value.ToString();
            await productRepository.Delete(itemCode, MessageBoxHelper.ShowAlert);
            if (dtProductos.Rows.Count == 1) btnEliminar.Enabled = false;
            await ReloadData();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
