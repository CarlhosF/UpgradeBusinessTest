namespace UpgradeBusinessTest._05.Views.Invoices
{
    partial class InvoiceGestor
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
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxBIdCliente = new System.Windows.Forms.TextBox();
            this.txBNombre = new System.Windows.Forms.TextBox();
            this.txBDireccion = new System.Windows.Forms.TextBox();
            this.dtLineas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BtnBuscarCliente = new System.Windows.Forms.Button();
            this.txBCodArt = new System.Windows.Forms.TextBox();
            this.txBDescArt = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txBPrice = new System.Windows.Forms.TextBox();
            this.txBTotalLine = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BtnAgregarLinea = new System.Windows.Forms.Button();
            this.BtnQuitarLinea = new System.Windows.Forms.Button();
            this.txBTotalInv = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtLineas)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(11, 12);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(94, 29);
            this.BtnGuardar.TabIndex = 0;
            this.BtnGuardar.Text = "Guardar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // BtnModificar
            // 
            this.BtnModificar.Location = new System.Drawing.Point(111, 12);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(94, 29);
            this.BtnModificar.TabIndex = 1;
            this.BtnModificar.Text = "Modificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Location = new System.Drawing.Point(211, 12);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(94, 29);
            this.BtnEliminar.TabIndex = 2;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(55, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Id Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(55, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion";
            // 
            // TxBIdCliente
            // 
            this.TxBIdCliente.Location = new System.Drawing.Point(133, 70);
            this.TxBIdCliente.Name = "TxBIdCliente";
            this.TxBIdCliente.Size = new System.Drawing.Size(125, 27);
            this.TxBIdCliente.TabIndex = 6;
            // 
            // txBNombre
            // 
            this.txBNombre.Location = new System.Drawing.Point(133, 105);
            this.txBNombre.Name = "txBNombre";
            this.txBNombre.Size = new System.Drawing.Size(552, 27);
            this.txBNombre.TabIndex = 7;
            // 
            // txBDireccion
            // 
            this.txBDireccion.Location = new System.Drawing.Point(133, 144);
            this.txBDireccion.Multiline = true;
            this.txBDireccion.Name = "txBDireccion";
            this.txBDireccion.Size = new System.Drawing.Size(552, 141);
            this.txBDireccion.TabIndex = 8;
            // 
            // dtLineas
            // 
            this.dtLineas.AllowUserToDeleteRows = false;
            this.dtLineas.AllowUserToOrderColumns = true;
            this.dtLineas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtLineas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtLineas.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtLineas.CausesValidation = false;
            this.dtLineas.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dtLineas.ColumnHeadersHeight = 29;
            this.dtLineas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Descripcion,
            this.Cantidad,
            this.PrecioUnitario,
            this.PrecioTotal});
            this.dtLineas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dtLineas.Location = new System.Drawing.Point(55, 396);
            this.dtLineas.MultiSelect = false;
            this.dtLineas.Name = "dtLineas";
            this.dtLineas.ReadOnly = true;
            this.dtLineas.RowHeadersVisible = false;
            this.dtLineas.RowHeadersWidth = 51;
            this.dtLineas.RowTemplate.Height = 29;
            this.dtLineas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtLineas.ShowCellErrors = false;
            this.dtLineas.ShowCellToolTips = false;
            this.dtLineas.ShowEditingIcon = false;
            this.dtLineas.ShowRowErrors = false;
            this.dtLineas.Size = new System.Drawing.Size(630, 170);
            this.dtLineas.TabIndex = 9;
            // 
            // Codigo
            // 
            this.Codigo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Codigo.FillWeight = 1.263516F;
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Codigo.Width = 125;
            // 
            // Descripcion
            // 
            this.Descripcion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Descripcion.FillWeight = 295.4546F;
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.MinimumWidth = 6;
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.ReadOnly = true;
            this.Descripcion.Width = 227;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Cantidad.FillWeight = 100.5287F;
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 90;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioUnitario.FillWeight = 22.61999F;
            this.PrecioUnitario.HeaderText = "Precio U.";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.ReadOnly = true;
            this.PrecioUnitario.Width = 90;
            // 
            // PrecioTotal
            // 
            this.PrecioTotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.PrecioTotal.FillWeight = 5.133239F;
            this.PrecioTotal.HeaderText = "Total Fila";
            this.PrecioTotal.MinimumWidth = 6;
            this.PrecioTotal.Name = "PrecioTotal";
            this.PrecioTotal.ReadOnly = true;
            this.PrecioTotal.Width = 90;
            // 
            // BtnBuscarCliente
            // 
            this.BtnBuscarCliente.Location = new System.Drawing.Point(264, 70);
            this.BtnBuscarCliente.Name = "BtnBuscarCliente";
            this.BtnBuscarCliente.Size = new System.Drawing.Size(94, 29);
            this.BtnBuscarCliente.TabIndex = 10;
            this.BtnBuscarCliente.Text = "Buscar";
            this.BtnBuscarCliente.UseVisualStyleBackColor = true;
            this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
            // 
            // txBCodArt
            // 
            this.txBCodArt.Location = new System.Drawing.Point(55, 363);
            this.txBCodArt.Name = "txBCodArt";
            this.txBCodArt.Size = new System.Drawing.Size(125, 27);
            this.txBCodArt.TabIndex = 11;
            this.txBCodArt.Leave += new System.EventHandler(this.txBCodArt_Leave);
            // 
            // txBDescArt
            // 
            this.txBDescArt.Location = new System.Drawing.Point(186, 363);
            this.txBDescArt.Name = "txBDescArt";
            this.txBDescArt.ReadOnly = true;
            this.txBDescArt.Size = new System.Drawing.Size(221, 27);
            this.txBDescArt.TabIndex = 12;
            this.txBDescArt.Text = "--";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(413, 363);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(92, 27);
            this.txtCantidad.TabIndex = 13;
            this.txtCantidad.Text = "1";
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            this.txtCantidad.Leave += new System.EventHandler(this.txtCantidad_Leave);
            // 
            // txBPrice
            // 
            this.txBPrice.Location = new System.Drawing.Point(511, 363);
            this.txBPrice.Name = "txBPrice";
            this.txBPrice.ReadOnly = true;
            this.txBPrice.Size = new System.Drawing.Size(69, 27);
            this.txBPrice.TabIndex = 14;
            this.txBPrice.Text = "0";
            // 
            // txBTotalLine
            // 
            this.txBTotalLine.Location = new System.Drawing.Point(586, 363);
            this.txBTotalLine.Name = "txBTotalLine";
            this.txBTotalLine.ReadOnly = true;
            this.txBTotalLine.Size = new System.Drawing.Size(99, 27);
            this.txBTotalLine.TabIndex = 15;
            this.txBTotalLine.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(74, 340);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Cod. Art.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(413, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Cantidad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 340);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Precio U.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(602, 340);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Total Linea";
            // 
            // BtnAgregarLinea
            // 
            this.BtnAgregarLinea.Enabled = false;
            this.BtnAgregarLinea.Location = new System.Drawing.Point(691, 363);
            this.BtnAgregarLinea.Name = "BtnAgregarLinea";
            this.BtnAgregarLinea.Size = new System.Drawing.Size(120, 29);
            this.BtnAgregarLinea.TabIndex = 21;
            this.BtnAgregarLinea.Text = "Agregar Fila";
            this.BtnAgregarLinea.UseVisualStyleBackColor = true;
            this.BtnAgregarLinea.Click += new System.EventHandler(this.BtnAgregarLinea_Click);
            // 
            // BtnQuitarLinea
            // 
            this.BtnQuitarLinea.Enabled = false;
            this.BtnQuitarLinea.Location = new System.Drawing.Point(691, 398);
            this.BtnQuitarLinea.Name = "BtnQuitarLinea";
            this.BtnQuitarLinea.Size = new System.Drawing.Size(120, 29);
            this.BtnQuitarLinea.TabIndex = 22;
            this.BtnQuitarLinea.Text = "Quitar Fila";
            this.BtnQuitarLinea.UseVisualStyleBackColor = true;
            this.BtnQuitarLinea.Click += new System.EventHandler(this.BtnQuitarLinea_Click);
            // 
            // txBTotalInv
            // 
            this.txBTotalInv.Location = new System.Drawing.Point(560, 605);
            this.txBTotalInv.Name = "txBTotalInv";
            this.txBTotalInv.ReadOnly = true;
            this.txBTotalInv.Size = new System.Drawing.Size(125, 27);
            this.txBTotalInv.TabIndex = 23;
            this.txBTotalInv.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(508, 608);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Total";
            // 
            // InvoiceGestor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackgroundImage = global::UpgradeBusinessTest.Properties.Resources.C71;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(844, 667);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txBTotalInv);
            this.Controls.Add(this.BtnQuitarLinea);
            this.Controls.Add(this.BtnAgregarLinea);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txBTotalLine);
            this.Controls.Add(this.txBPrice);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txBDescArt);
            this.Controls.Add(this.txBCodArt);
            this.Controls.Add(this.BtnBuscarCliente);
            this.Controls.Add(this.dtLineas);
            this.Controls.Add(this.txBDireccion);
            this.Controls.Add(this.txBNombre);
            this.Controls.Add(this.TxBIdCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnGuardar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "InvoiceGestor";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Invoice Gestor";
            this.Load += new System.EventHandler(this.InvoiceGestor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtLineas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnGuardar;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxBIdCliente;
        private System.Windows.Forms.TextBox txBNombre;
        private System.Windows.Forms.TextBox txBDireccion;
        private System.Windows.Forms.DataGridView dtLineas;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.TextBox txBCodArt;
        private System.Windows.Forms.TextBox txBDescArt;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txBPrice;
        private System.Windows.Forms.TextBox txBTotalLine;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnAgregarLinea;
        private System.Windows.Forms.Button BtnQuitarLinea;
        private System.Windows.Forms.TextBox txBTotalInv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioTotal;
    }
}