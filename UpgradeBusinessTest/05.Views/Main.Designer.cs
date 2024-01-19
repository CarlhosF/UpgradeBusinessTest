namespace UpgradeBusinessTest._05.Views
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LeftPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnListas = new System.Windows.Forms.Button();
            this.btnGestionarItems = new System.Windows.Forms.Button();
            this.BtnInvoice = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Body = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.LeftPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LeftPanel
            // 
            this.LeftPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LeftPanel.BackgroundImage = global::UpgradeBusinessTest.Properties.Resources.background1;
            this.LeftPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPanel.Controls.Add(this.label2);
            this.LeftPanel.Controls.Add(this.label1);
            this.LeftPanel.Controls.Add(this.btnListas);
            this.LeftPanel.Controls.Add(this.btnGestionarItems);
            this.LeftPanel.Controls.Add(this.BtnInvoice);
            this.LeftPanel.Controls.Add(this.pictureBox1);
            this.LeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftPanel.Name = "LeftPanel";
            this.LeftPanel.Size = new System.Drawing.Size(313, 664);
            this.LeftPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 571);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Desarrollado por: Carlhos Figueroa";
            // 
            // btnListas
            // 
            this.btnListas.Location = new System.Drawing.Point(61, 431);
            this.btnListas.Name = "btnListas";
            this.btnListas.Size = new System.Drawing.Size(156, 50);
            this.btnListas.TabIndex = 4;
            this.btnListas.Text = "Ver Clientes y Facturas";
            this.btnListas.UseVisualStyleBackColor = true;
            this.btnListas.Click += new System.EventHandler(this.btnListas_Click);
            // 
            // btnGestionarItems
            // 
            this.btnGestionarItems.Location = new System.Drawing.Point(61, 350);
            this.btnGestionarItems.Name = "btnGestionarItems";
            this.btnGestionarItems.Size = new System.Drawing.Size(156, 50);
            this.btnGestionarItems.TabIndex = 3;
            this.btnGestionarItems.Text = "Gestion de Productos";
            this.btnGestionarItems.UseVisualStyleBackColor = true;
            this.btnGestionarItems.Click += new System.EventHandler(this.btnGestionarItems_Click);
            // 
            // BtnInvoice
            // 
            this.BtnInvoice.Location = new System.Drawing.Point(61, 273);
            this.BtnInvoice.Name = "BtnInvoice";
            this.BtnInvoice.Size = new System.Drawing.Size(156, 50);
            this.BtnInvoice.TabIndex = 2;
            this.BtnInvoice.Text = "Crear Facturas";
            this.BtnInvoice.UseVisualStyleBackColor = true;
            this.BtnInvoice.Click += new System.EventHandler(this.BtnInvoice_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.BackgroundImage = global::UpgradeBusinessTest.Properties.Resources.UB;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(43, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 189);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Body
            // 
            this.Body.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Body.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Body.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Body.Location = new System.Drawing.Point(313, 0);
            this.Body.Name = "Body";
            this.Body.Size = new System.Drawing.Size(844, 664);
            this.Body.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 601);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "19-Enero-2024";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 664);
            this.Controls.Add(this.Body);
            this.Controls.Add(this.LeftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Carlhos Prueba C#";
            this.Load += new System.EventHandler(this.Main_Load);
            this.LeftPanel.ResumeLayout(false);
            this.LeftPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel LeftPanel;
        private System.Windows.Forms.Panel Body;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnInvoice;
        private System.Windows.Forms.Button btnGestionarItems;
        private System.Windows.Forms.Button btnListas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}