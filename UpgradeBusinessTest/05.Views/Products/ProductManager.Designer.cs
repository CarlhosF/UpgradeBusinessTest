namespace UpgradeBusinessTest._05.Views.Products
{
    partial class ProductManager
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregarItem = new System.Windows.Forms.Button();
            this.sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            this.dtProductos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.BtnAgregarItem);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(844, 84);
            this.panel1.TabIndex = 0;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(152, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(101, 56);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // BtnAgregarItem
            // 
            this.BtnAgregarItem.Location = new System.Drawing.Point(29, 12);
            this.BtnAgregarItem.Name = "BtnAgregarItem";
            this.BtnAgregarItem.Size = new System.Drawing.Size(101, 56);
            this.BtnAgregarItem.TabIndex = 2;
            this.BtnAgregarItem.Text = "Agregar";
            this.BtnAgregarItem.UseVisualStyleBackColor = true;
            this.BtnAgregarItem.Click += new System.EventHandler(this.BtnAgregarItem_Click);
            // 
            // sqlCommand1
            // 
            this.sqlCommand1.CommandTimeout = 30;
            this.sqlCommand1.Connection = null;
            this.sqlCommand1.Notification = null;
            this.sqlCommand1.Transaction = null;
            // 
            // dtProductos
            // 
            this.dtProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtProductos.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtProductos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtProductos.Location = new System.Drawing.Point(0, 84);
            this.dtProductos.MultiSelect = false;
            this.dtProductos.Name = "dtProductos";
            this.dtProductos.ReadOnly = true;
            this.dtProductos.RowHeadersVisible = false;
            this.dtProductos.RowHeadersWidth = 51;
            this.dtProductos.RowTemplate.Height = 29;
            this.dtProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtProductos.Size = new System.Drawing.Size(844, 583);
            this.dtProductos.TabIndex = 1;
            this.dtProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtProductos_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(398, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestion de Productos, Doble click en el articulo para editar";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ProductManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UpgradeBusinessTest.Properties.Resources.C7;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(844, 667);
            this.Controls.Add(this.dtProductos);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductManager";
            this.Load += new System.EventHandler(this.ProductManager_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private System.Windows.Forms.DataGridView dtProductos;
        private System.Windows.Forms.Button BtnAgregarItem;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
    }
}