namespace UpgradeBusinessTest._05.Views.Invoices
{
    partial class ViewClientesAndInvoices
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtClientes = new System.Windows.Forms.DataGridView();
            this.dtFacturas = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // dtClientes
            // 
            this.dtClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtClientes.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtClientes.Location = new System.Drawing.Point(23, 65);
            this.dtClientes.MultiSelect = false;
            this.dtClientes.Name = "dtClientes";
            this.dtClientes.ReadOnly = true;
            this.dtClientes.RowHeadersVisible = false;
            this.dtClientes.RowHeadersWidth = 51;
            this.dtClientes.RowTemplate.Height = 29;
            this.dtClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtClientes.Size = new System.Drawing.Size(793, 171);
            this.dtClientes.TabIndex = 2;
            // 
            // dtFacturas
            // 
            this.dtFacturas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtFacturas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtFacturas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtFacturas.Location = new System.Drawing.Point(23, 370);
            this.dtFacturas.MultiSelect = false;
            this.dtFacturas.Name = "dtFacturas";
            this.dtFacturas.ReadOnly = true;
            this.dtFacturas.RowHeadersVisible = false;
            this.dtFacturas.RowHeadersWidth = 51;
            this.dtFacturas.RowTemplate.Height = 29;
            this.dtFacturas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtFacturas.Size = new System.Drawing.Size(793, 202);
            this.dtFacturas.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(384, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(384, 347);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Facturas";
            // 
            // ViewClientesAndInvoices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UpgradeBusinessTest.Properties.Resources.C7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(844, 667);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFacturas);
            this.Controls.Add(this.dtClientes);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewClientesAndInvoices";
            this.Text = "Clientes y FAc";
            this.Load += new System.EventHandler(this.ViewClientesAndInvoices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtClientes;
        private System.Windows.Forms.DataGridView dtFacturas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}