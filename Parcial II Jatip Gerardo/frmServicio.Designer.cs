
namespace Parcial_II_Jatip_Gerardo
{
    partial class frmServicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServicio));
            this.dgvServicio = new System.Windows.Forms.DataGridView();
            this.txtNombreServicio = new System.Windows.Forms.TextBox();
            this.txtPrecioServicio = new System.Windows.Forms.TextBox();
            this.txtCodigoServicio = new System.Windows.Forms.TextBox();
            this.btnAgregarServicio = new System.Windows.Forms.Button();
            this.btnEditarServicio = new System.Windows.Forms.Button();
            this.btnBorrarServicio = new System.Windows.Forms.Button();
            this.lblNombreServicio = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblBienvenidosServicio = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.reservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAMenúReservasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.irAMenúPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvServicio
            // 
            this.dgvServicio.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServicio.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgvServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicio.Location = new System.Drawing.Point(26, 81);
            this.dgvServicio.Name = "dgvServicio";
            this.dgvServicio.ReadOnly = true;
            this.dgvServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvServicio.Size = new System.Drawing.Size(530, 189);
            this.dgvServicio.TabIndex = 0;
            this.dgvServicio.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServicio_CellClick);
            // 
            // txtNombreServicio
            // 
            this.txtNombreServicio.Location = new System.Drawing.Point(161, 321);
            this.txtNombreServicio.Name = "txtNombreServicio";
            this.txtNombreServicio.Size = new System.Drawing.Size(259, 20);
            this.txtNombreServicio.TabIndex = 1;
            // 
            // txtPrecioServicio
            // 
            this.txtPrecioServicio.Location = new System.Drawing.Point(443, 321);
            this.txtPrecioServicio.Name = "txtPrecioServicio";
            this.txtPrecioServicio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecioServicio.TabIndex = 2;
            this.txtPrecioServicio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioServicio_KeyPress);
            // 
            // txtCodigoServicio
            // 
            this.txtCodigoServicio.Location = new System.Drawing.Point(41, 321);
            this.txtCodigoServicio.Name = "txtCodigoServicio";
            this.txtCodigoServicio.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoServicio.TabIndex = 3;
            // 
            // btnAgregarServicio
            // 
            this.btnAgregarServicio.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnAgregarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarServicio.Location = new System.Drawing.Point(103, 378);
            this.btnAgregarServicio.Name = "btnAgregarServicio";
            this.btnAgregarServicio.Size = new System.Drawing.Size(75, 43);
            this.btnAgregarServicio.TabIndex = 8;
            this.btnAgregarServicio.Text = "Agregar";
            this.btnAgregarServicio.UseVisualStyleBackColor = false;
            this.btnAgregarServicio.Click += new System.EventHandler(this.btnAgregarServicio_Click);
            // 
            // btnEditarServicio
            // 
            this.btnEditarServicio.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnEditarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarServicio.Location = new System.Drawing.Point(239, 378);
            this.btnEditarServicio.Name = "btnEditarServicio";
            this.btnEditarServicio.Size = new System.Drawing.Size(75, 43);
            this.btnEditarServicio.TabIndex = 9;
            this.btnEditarServicio.Text = "Editar";
            this.btnEditarServicio.UseVisualStyleBackColor = false;
            this.btnEditarServicio.Click += new System.EventHandler(this.btnEditarServicio_Click);
            // 
            // btnBorrarServicio
            // 
            this.btnBorrarServicio.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnBorrarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarServicio.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnBorrarServicio.Location = new System.Drawing.Point(386, 378);
            this.btnBorrarServicio.Name = "btnBorrarServicio";
            this.btnBorrarServicio.Size = new System.Drawing.Size(75, 43);
            this.btnBorrarServicio.TabIndex = 10;
            this.btnBorrarServicio.Text = "Borrar";
            this.btnBorrarServicio.UseVisualStyleBackColor = false;
            this.btnBorrarServicio.Click += new System.EventHandler(this.btnBorrarServicio_Click);
            // 
            // lblNombreServicio
            // 
            this.lblNombreServicio.AutoSize = true;
            this.lblNombreServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblNombreServicio.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreServicio.ForeColor = System.Drawing.Color.Magenta;
            this.lblNombreServicio.Location = new System.Drawing.Point(259, 301);
            this.lblNombreServicio.Name = "lblNombreServicio";
            this.lblNombreServicio.Size = new System.Drawing.Size(59, 17);
            this.lblNombreServicio.TabIndex = 12;
            this.lblNombreServicio.Text = "Nombre";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.BackColor = System.Drawing.Color.Transparent;
            this.lblPrecio.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecio.ForeColor = System.Drawing.Color.Magenta;
            this.lblPrecio.Location = new System.Drawing.Point(469, 301);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(49, 17);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.OldLace;
            this.lblCodigo.Font = new System.Drawing.Font("Yu Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodigo.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblCodigo.Location = new System.Drawing.Point(63, 301);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(53, 17);
            this.lblCodigo.TabIndex = 16;
            this.lblCodigo.Text = "Código";
            // 
            // lblBienvenidosServicio
            // 
            this.lblBienvenidosServicio.AutoSize = true;
            this.lblBienvenidosServicio.BackColor = System.Drawing.Color.Transparent;
            this.lblBienvenidosServicio.Font = new System.Drawing.Font("Cooper Black", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenidosServicio.ForeColor = System.Drawing.Color.Fuchsia;
            this.lblBienvenidosServicio.Location = new System.Drawing.Point(134, 45);
            this.lblBienvenidosServicio.Name = "lblBienvenidosServicio";
            this.lblBienvenidosServicio.Size = new System.Drawing.Size(324, 21);
            this.lblBienvenidosServicio.TabIndex = 19;
            this.lblBienvenidosServicio.Text = "Carga los Servicios que necesites";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // reservasToolStripMenuItem
            // 
            this.reservasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cargarDatosToolStripMenuItem,
            this.agregarToolStripMenuItem,
            this.borrarToolStripMenuItem});
            this.reservasToolStripMenuItem.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reservasToolStripMenuItem.Name = "reservasToolStripMenuItem";
            this.reservasToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.reservasToolStripMenuItem.Text = "Menú";
            // 
            // cargarDatosToolStripMenuItem
            // 
            this.cargarDatosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irAMenúReservasToolStripMenuItem});
            this.cargarDatosToolStripMenuItem.Name = "cargarDatosToolStripMenuItem";
            this.cargarDatosToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.cargarDatosToolStripMenuItem.Text = "Reservas";
            // 
            // irAMenúReservasToolStripMenuItem
            // 
            this.irAMenúReservasToolStripMenuItem.Name = "irAMenúReservasToolStripMenuItem";
            this.irAMenúReservasToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.irAMenúReservasToolStripMenuItem.Text = "Ir a Menú Reservas";
            this.irAMenúReservasToolStripMenuItem.Click += new System.EventHandler(this.irAMenúReservasToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.irAMenúPersonasToolStripMenuItem});
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.agregarToolStripMenuItem.Text = "Habitaciones";
            // 
            // irAMenúPersonasToolStripMenuItem
            // 
            this.irAMenúPersonasToolStripMenuItem.Name = "irAMenúPersonasToolStripMenuItem";
            this.irAMenúPersonasToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.irAMenúPersonasToolStripMenuItem.Text = "Ir a Menú Habitaciones";
            this.irAMenúPersonasToolStripMenuItem.Click += new System.EventHandler(this.irAMenúPersonasToolStripMenuItem_Click);
            // 
            // borrarToolStripMenuItem
            // 
            this.borrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
            this.borrarToolStripMenuItem.Name = "borrarToolStripMenuItem";
            this.borrarToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.borrarToolStripMenuItem.Text = "Programa";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmServicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 461);
            this.Controls.Add(this.lblBienvenidosServicio);
            this.Controls.Add(this.lblCodigo);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblNombreServicio);
            this.Controls.Add(this.btnBorrarServicio);
            this.Controls.Add(this.btnEditarServicio);
            this.Controls.Add(this.btnAgregarServicio);
            this.Controls.Add(this.txtCodigoServicio);
            this.Controls.Add(this.txtPrecioServicio);
            this.Controls.Add(this.txtNombreServicio);
            this.Controls.Add(this.dgvServicio);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmServicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ooking Servicios";
            this.Load += new System.EventHandler(this.frmServicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicio)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvServicio;
        private System.Windows.Forms.TextBox txtNombreServicio;
        private System.Windows.Forms.TextBox txtPrecioServicio;
        private System.Windows.Forms.TextBox txtCodigoServicio;
        private System.Windows.Forms.Button btnAgregarServicio;
        private System.Windows.Forms.Button btnEditarServicio;
        private System.Windows.Forms.Button btnBorrarServicio;
        private System.Windows.Forms.Label lblNombreServicio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblBienvenidosServicio;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem reservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMenúReservasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem irAMenúPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}