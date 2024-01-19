using System;
using System.Windows.Forms;
using UpgradeBusinessTest._01.Domain.Entities;
using UpgradeBusinessTest._02.Core.Helpers;

namespace UpgradeBusinessTest._05.Views.Products
{
    public partial class ProductDetail : Form
    {
        public event EventHandler<ProductDetailEventArgs> AceptarClick;
        public ProductDetail(string itemCode, string itemName, decimal? unitPrice, string title)
        {
            InitializeComponent();

            ItemCode = itemCode;
            ItemName = itemName;
            UnitPrice1 = unitPrice;
            Title = title;
            IsCreate = false;
        }
        public ProductDetail(string title)
        {
            InitializeComponent();
            Title = title;
            IsCreate = true;
        }
        public ProductDetail()
        {
            InitializeComponent();
            IsCreate = true;
        }

        public bool IsCreate { get; }
        public string? ItemCode { get; }
        public string? ItemName { get; }
        public decimal? UnitPrice1 { get; }
        public string? Title { get; }

        private void ProductDetail_Load(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(ItemCode)) txbItemCode.Text = ItemCode;
            if(!string.IsNullOrEmpty(ItemName)) txbItemName.Text = ItemName;
            if(UnitPrice1 != null) UnitPrice.Text = UnitPrice1.ToString();
            this.Text = Title;
            if (!IsCreate) txbItemCode.ReadOnly = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {            
            if(!decimal.TryParse(UnitPrice.Text, out decimal price))
            {
                MessageBoxHelper.ShowAlert("El valor ingresado para el precio unitario no es valido","Alerta");
            }
            var args = new ProductDetailEventArgs
            {
                ItemCode = txbItemCode.Text,
                ItemName = txbItemName.Text,
                UnitPrice1 = price,
                Title = Title,
                IsCreate=IsCreate
            };
            AceptarClick?.Invoke(this, args);
            this.Close();
        }
    }

    public class ProductDetailEventArgs : EventArgs
    {
        public string? ItemCode { get; set; }
        public string? ItemName { get; set; }
        public decimal? UnitPrice1 { get; set; }
        public string? Title { get; set; }
        public bool? IsCreate { get; set; }

    }

}
