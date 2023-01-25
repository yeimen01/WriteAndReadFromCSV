namespace WriteAndReadFromCSV
{
    partial class InitialForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pGeneral = new System.Windows.Forms.Panel();
            this.tabAcciones = new System.Windows.Forms.TabControl();
            this.Escribir = new System.Windows.Forms.TabPage();
            this.pHeader = new System.Windows.Forms.Panel();
            this.btnLimpiarDatos = new System.Windows.Forms.Button();
            this.txtRutaDeArchivo = new System.Windows.Forms.TextBox();
            this.btnCargarCSV = new System.Windows.Forms.Button();
            this.lblDetalle = new System.Windows.Forms.Label();
            this.txtNoDocDet = new System.Windows.Forms.MaskedTextBox();
            this.txtTipoDocDet = new System.Windows.Forms.MaskedTextBox();
            this.txtNoCtaDet = new System.Windows.Forms.MaskedTextBox();
            this.txtNoCta = new System.Windows.Forms.MaskedTextBox();
            this.txtRNC = new System.Windows.Forms.MaskedTextBox();
            this.txtPeriodoPago = new System.Windows.Forms.MaskedTextBox();
            this.txtFechaTransmision = new System.Windows.Forms.MaskedTextBox();
            this.lblMontDet = new System.Windows.Forms.Label();
            this.txtMontoDet = new System.Windows.Forms.TextBox();
            this.lblPago = new System.Windows.Forms.Label();
            this.btnBajarRegistro = new System.Windows.Forms.Button();
            this.lblNoDocDet = new System.Windows.Forms.Label();
            this.lblTipoDocDet = new System.Windows.Forms.Label();
            this.lblNoCtaDet = new System.Windows.Forms.Label();
            this.lblTipoRegistroDet = new System.Windows.Forms.Label();
            this.txtTipoRegistroDet = new System.Windows.Forms.TextBox();
            this.btnGenerarCSV = new System.Windows.Forms.Button();
            this.lblNoCta = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.txtMontoTotal = new System.Windows.Forms.TextBox();
            this.lblFechaTranmision = new System.Windows.Forms.Label();
            this.lblRNC = new System.Windows.Forms.Label();
            this.lblTipoRegistro = new System.Windows.Forms.Label();
            this.txtTipoRegistro = new System.Windows.Forms.TextBox();
            this.lblEncabezado = new System.Windows.Forms.Label();
            this.lblMontoDet = new System.Windows.Forms.Label();
            this.pDetail = new System.Windows.Forms.Panel();
            this.dgvDetalle = new System.Windows.Forms.DataGridView();
            this.lblPeriodoPago = new System.Windows.Forms.Label();
            this.pGeneral.SuspendLayout();
            this.tabAcciones.SuspendLayout();
            this.Escribir.SuspendLayout();
            this.pHeader.SuspendLayout();
            this.pDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // pGeneral
            // 
            this.pGeneral.Controls.Add(this.tabAcciones);
            this.pGeneral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pGeneral.Location = new System.Drawing.Point(0, 0);
            this.pGeneral.Name = "pGeneral";
            this.pGeneral.Size = new System.Drawing.Size(800, 521);
            this.pGeneral.TabIndex = 0;
            // 
            // tabAcciones
            // 
            this.tabAcciones.Controls.Add(this.Escribir);
            this.tabAcciones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabAcciones.Location = new System.Drawing.Point(0, 0);
            this.tabAcciones.Name = "tabAcciones";
            this.tabAcciones.SelectedIndex = 0;
            this.tabAcciones.Size = new System.Drawing.Size(800, 521);
            this.tabAcciones.TabIndex = 0;
            // 
            // Escribir
            // 
            this.Escribir.Controls.Add(this.pHeader);
            this.Escribir.Controls.Add(this.lblMontoDet);
            this.Escribir.Controls.Add(this.pDetail);
            this.Escribir.Controls.Add(this.lblPeriodoPago);
            this.Escribir.Location = new System.Drawing.Point(4, 24);
            this.Escribir.Name = "Escribir";
            this.Escribir.Padding = new System.Windows.Forms.Padding(3);
            this.Escribir.Size = new System.Drawing.Size(792, 493);
            this.Escribir.TabIndex = 0;
            this.Escribir.Text = "Escribir CSV";
            this.Escribir.UseVisualStyleBackColor = true;
            // 
            // pHeader
            // 
            this.pHeader.Controls.Add(this.btnLimpiarDatos);
            this.pHeader.Controls.Add(this.txtRutaDeArchivo);
            this.pHeader.Controls.Add(this.btnCargarCSV);
            this.pHeader.Controls.Add(this.lblDetalle);
            this.pHeader.Controls.Add(this.txtNoDocDet);
            this.pHeader.Controls.Add(this.txtTipoDocDet);
            this.pHeader.Controls.Add(this.txtNoCtaDet);
            this.pHeader.Controls.Add(this.txtNoCta);
            this.pHeader.Controls.Add(this.txtRNC);
            this.pHeader.Controls.Add(this.txtPeriodoPago);
            this.pHeader.Controls.Add(this.txtFechaTransmision);
            this.pHeader.Controls.Add(this.lblMontDet);
            this.pHeader.Controls.Add(this.txtMontoDet);
            this.pHeader.Controls.Add(this.lblPago);
            this.pHeader.Controls.Add(this.btnBajarRegistro);
            this.pHeader.Controls.Add(this.lblNoDocDet);
            this.pHeader.Controls.Add(this.lblTipoDocDet);
            this.pHeader.Controls.Add(this.lblNoCtaDet);
            this.pHeader.Controls.Add(this.lblTipoRegistroDet);
            this.pHeader.Controls.Add(this.txtTipoRegistroDet);
            this.pHeader.Controls.Add(this.btnGenerarCSV);
            this.pHeader.Controls.Add(this.lblNoCta);
            this.pHeader.Controls.Add(this.lblMontoTotal);
            this.pHeader.Controls.Add(this.txtMontoTotal);
            this.pHeader.Controls.Add(this.lblFechaTranmision);
            this.pHeader.Controls.Add(this.lblRNC);
            this.pHeader.Controls.Add(this.lblTipoRegistro);
            this.pHeader.Controls.Add(this.txtTipoRegistro);
            this.pHeader.Controls.Add(this.lblEncabezado);
            this.pHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pHeader.Location = new System.Drawing.Point(3, 3);
            this.pHeader.MaximumSize = new System.Drawing.Size(786, 247);
            this.pHeader.Name = "pHeader";
            this.pHeader.Size = new System.Drawing.Size(786, 247);
            this.pHeader.TabIndex = 40;
            // 
            // btnLimpiarDatos
            // 
            this.btnLimpiarDatos.Location = new System.Drawing.Point(595, 85);
            this.btnLimpiarDatos.Name = "btnLimpiarDatos";
            this.btnLimpiarDatos.Size = new System.Drawing.Size(93, 23);
            this.btnLimpiarDatos.TabIndex = 61;
            this.btnLimpiarDatos.Text = "Limpiar todo";
            this.btnLimpiarDatos.UseVisualStyleBackColor = true;
            this.btnLimpiarDatos.Click += new System.EventHandler(this.btnLimpiarDatos_Click);
            // 
            // txtRutaDeArchivo
            // 
            this.txtRutaDeArchivo.Location = new System.Drawing.Point(361, 22);
            this.txtRutaDeArchivo.Name = "txtRutaDeArchivo";
            this.txtRutaDeArchivo.ReadOnly = true;
            this.txtRutaDeArchivo.Size = new System.Drawing.Size(272, 23);
            this.txtRutaDeArchivo.TabIndex = 60;
            this.txtRutaDeArchivo.Visible = false;
            // 
            // btnCargarCSV
            // 
            this.btnCargarCSV.Location = new System.Drawing.Point(262, 22);
            this.btnCargarCSV.Name = "btnCargarCSV";
            this.btnCargarCSV.Size = new System.Drawing.Size(93, 23);
            this.btnCargarCSV.TabIndex = 59;
            this.btnCargarCSV.Text = "Cargar CSV";
            this.btnCargarCSV.UseVisualStyleBackColor = true;
            this.btnCargarCSV.Click += new System.EventHandler(this.btnCargarCSV_Click);
            // 
            // lblDetalle
            // 
            this.lblDetalle.AutoSize = true;
            this.lblDetalle.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDetalle.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDetalle.Location = new System.Drawing.Point(12, 156);
            this.lblDetalle.Name = "lblDetalle";
            this.lblDetalle.Size = new System.Drawing.Size(71, 25);
            this.lblDetalle.TabIndex = 58;
            this.lblDetalle.Text = "Detalle";
            // 
            // txtNoDocDet
            // 
            this.txtNoDocDet.Location = new System.Drawing.Point(521, 206);
            this.txtNoDocDet.Mask = "00000000000";
            this.txtNoDocDet.Name = "txtNoDocDet";
            this.txtNoDocDet.Size = new System.Drawing.Size(84, 23);
            this.txtNoDocDet.TabIndex = 9;
            this.txtNoDocDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoDocDet_KeyDown);
            // 
            // txtTipoDocDet
            // 
            this.txtTipoDocDet.Location = new System.Drawing.Point(396, 206);
            this.txtTipoDocDet.Mask = "L";
            this.txtTipoDocDet.Name = "txtTipoDocDet";
            this.txtTipoDocDet.Size = new System.Drawing.Size(24, 23);
            this.txtTipoDocDet.TabIndex = 8;
            this.txtTipoDocDet.TextChanged += new System.EventHandler(this.txtTipoDocDet_TextChanged);
            this.txtTipoDocDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtTipoDocDet_KeyDown);
            // 
            // txtNoCtaDet
            // 
            this.txtNoCtaDet.Location = new System.Drawing.Point(195, 206);
            this.txtNoCtaDet.Mask = "00000000000";
            this.txtNoCtaDet.Name = "txtNoCtaDet";
            this.txtNoCtaDet.Size = new System.Drawing.Size(84, 23);
            this.txtNoCtaDet.TabIndex = 7;
            this.txtNoCtaDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoCtaDet_KeyDown);
            // 
            // txtNoCta
            // 
            this.txtNoCta.Location = new System.Drawing.Point(483, 67);
            this.txtNoCta.Mask = "0000000000000";
            this.txtNoCta.Name = "txtNoCta";
            this.txtNoCta.Size = new System.Drawing.Size(95, 23);
            this.txtNoCta.TabIndex = 4;
            this.txtNoCta.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNoCta_KeyDown);
            // 
            // txtRNC
            // 
            this.txtRNC.Location = new System.Drawing.Point(90, 97);
            this.txtRNC.Mask = "000000000";
            this.txtRNC.Name = "txtRNC";
            this.txtRNC.Size = new System.Drawing.Size(73, 23);
            this.txtRNC.TabIndex = 1;
            this.txtRNC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRNC_KeyDown);
            // 
            // txtPeriodoPago
            // 
            this.txtPeriodoPago.Location = new System.Drawing.Point(313, 101);
            this.txtPeriodoPago.Mask = "00/00/0000";
            this.txtPeriodoPago.Name = "txtPeriodoPago";
            this.txtPeriodoPago.Size = new System.Drawing.Size(83, 23);
            this.txtPeriodoPago.TabIndex = 3;
            this.txtPeriodoPago.ValidatingType = typeof(System.DateTime);
            this.txtPeriodoPago.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPeriodoPago_KeyDown);
            // 
            // txtFechaTransmision
            // 
            this.txtFechaTransmision.Location = new System.Drawing.Point(313, 67);
            this.txtFechaTransmision.Mask = "00/00/0000";
            this.txtFechaTransmision.Name = "txtFechaTransmision";
            this.txtFechaTransmision.Size = new System.Drawing.Size(83, 23);
            this.txtFechaTransmision.TabIndex = 2;
            this.txtFechaTransmision.ValidatingType = typeof(System.DateTime);
            this.txtFechaTransmision.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtFechaTransmision_KeyDown);
            // 
            // lblMontDet
            // 
            this.lblMontDet.AutoSize = true;
            this.lblMontDet.Location = new System.Drawing.Point(607, 209);
            this.lblMontDet.Name = "lblMontDet";
            this.lblMontDet.Size = new System.Drawing.Size(43, 15);
            this.lblMontDet.TabIndex = 57;
            this.lblMontDet.Text = "Monto";
            // 
            // txtMontoDet
            // 
            this.txtMontoDet.Location = new System.Drawing.Point(651, 206);
            this.txtMontoDet.Name = "txtMontoDet";
            this.txtMontoDet.PlaceholderText = "1350";
            this.txtMontoDet.Size = new System.Drawing.Size(54, 23);
            this.txtMontoDet.TabIndex = 10;
            this.txtMontoDet.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontoDet_KeyDown);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(192, 104);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(78, 15);
            this.lblPago.TabIndex = 55;
            this.lblPago.Text = "Periodo Pago";
            // 
            // btnBajarRegistro
            // 
            this.btnBajarRegistro.Location = new System.Drawing.Point(713, 205);
            this.btnBajarRegistro.Name = "btnBajarRegistro";
            this.btnBajarRegistro.Size = new System.Drawing.Size(66, 23);
            this.btnBajarRegistro.TabIndex = 54;
            this.btnBajarRegistro.Text = "Insertar";
            this.btnBajarRegistro.UseVisualStyleBackColor = true;
            this.btnBajarRegistro.Click += new System.EventHandler(this.btnBajarRegistro_Click);
            // 
            // lblNoDocDet
            // 
            this.lblNoDocDet.AutoSize = true;
            this.lblNoDocDet.Location = new System.Drawing.Point(429, 209);
            this.lblNoDocDet.Name = "lblNoDocDet";
            this.lblNoDocDet.Size = new System.Drawing.Size(92, 15);
            this.lblNoDocDet.TabIndex = 53;
            this.lblNoDocDet.Text = "No. Documento";
            // 
            // lblTipoDocDet
            // 
            this.lblTipoDocDet.AutoSize = true;
            this.lblTipoDocDet.Location = new System.Drawing.Point(285, 209);
            this.lblTipoDocDet.Name = "lblTipoDocDet";
            this.lblTipoDocDet.Size = new System.Drawing.Size(111, 15);
            this.lblTipoDocDet.TabIndex = 52;
            this.lblTipoDocDet.Text = "Tipo de documento";
            // 
            // lblNoCtaDet
            // 
            this.lblNoCtaDet.AutoSize = true;
            this.lblNoCtaDet.Location = new System.Drawing.Point(125, 209);
            this.lblNoCtaDet.Name = "lblNoCtaDet";
            this.lblNoCtaDet.Size = new System.Drawing.Size(67, 15);
            this.lblNoCtaDet.TabIndex = 51;
            this.lblNoCtaDet.Text = "No. Cuenta";
            // 
            // lblTipoRegistroDet
            // 
            this.lblTipoRegistroDet.AutoSize = true;
            this.lblTipoRegistroDet.Location = new System.Drawing.Point(7, 209);
            this.lblTipoRegistroDet.Name = "lblTipoRegistroDet";
            this.lblTipoRegistroDet.Size = new System.Drawing.Size(89, 15);
            this.lblTipoRegistroDet.TabIndex = 49;
            this.lblTipoRegistroDet.Text = "Tipo de registro";
            // 
            // txtTipoRegistroDet
            // 
            this.txtTipoRegistroDet.Location = new System.Drawing.Point(96, 206);
            this.txtTipoRegistroDet.Name = "txtTipoRegistroDet";
            this.txtTipoRegistroDet.ReadOnly = true;
            this.txtTipoRegistroDet.Size = new System.Drawing.Size(24, 23);
            this.txtTipoRegistroDet.TabIndex = 6;
            // 
            // btnGenerarCSV
            // 
            this.btnGenerarCSV.Location = new System.Drawing.Point(142, 22);
            this.btnGenerarCSV.Name = "btnGenerarCSV";
            this.btnGenerarCSV.Size = new System.Drawing.Size(93, 23);
            this.btnGenerarCSV.TabIndex = 50;
            this.btnGenerarCSV.Text = "Generar CSV";
            this.btnGenerarCSV.UseVisualStyleBackColor = true;
            this.btnGenerarCSV.Click += new System.EventHandler(this.btnGenerarCSV_Click);
            // 
            // lblNoCta
            // 
            this.lblNoCta.AutoSize = true;
            this.lblNoCta.Location = new System.Drawing.Point(408, 70);
            this.lblNoCta.Name = "lblNoCta";
            this.lblNoCta.Size = new System.Drawing.Size(67, 15);
            this.lblNoCta.TabIndex = 47;
            this.lblNoCta.Text = "No. Cuenta";
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Location = new System.Drawing.Point(408, 105);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(71, 15);
            this.lblMontoTotal.TabIndex = 46;
            this.lblMontoTotal.Text = "Monto Total";
            // 
            // txtMontoTotal
            // 
            this.txtMontoTotal.Location = new System.Drawing.Point(483, 102);
            this.txtMontoTotal.Name = "txtMontoTotal";
            this.txtMontoTotal.PlaceholderText = "1600";
            this.txtMontoTotal.Size = new System.Drawing.Size(95, 23);
            this.txtMontoTotal.TabIndex = 5;
            this.txtMontoTotal.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMontoTotal_KeyDown);
            // 
            // lblFechaTranmision
            // 
            this.lblFechaTranmision.AutoSize = true;
            this.lblFechaTranmision.Location = new System.Drawing.Point(192, 70);
            this.lblFechaTranmision.Name = "lblFechaTranmision";
            this.lblFechaTranmision.Size = new System.Drawing.Size(119, 15);
            this.lblFechaTranmision.TabIndex = 44;
            this.lblFechaTranmision.Text = "Fecha de transmisión";
            // 
            // lblRNC
            // 
            this.lblRNC.AutoSize = true;
            this.lblRNC.Location = new System.Drawing.Point(12, 105);
            this.lblRNC.Name = "lblRNC";
            this.lblRNC.Size = new System.Drawing.Size(31, 15);
            this.lblRNC.TabIndex = 43;
            this.lblRNC.Text = "RNC";
            // 
            // lblTipoRegistro
            // 
            this.lblTipoRegistro.AutoSize = true;
            this.lblTipoRegistro.Location = new System.Drawing.Point(12, 70);
            this.lblTipoRegistro.Name = "lblTipoRegistro";
            this.lblTipoRegistro.Size = new System.Drawing.Size(76, 15);
            this.lblTipoRegistro.TabIndex = 42;
            this.lblTipoRegistro.Text = "Tipo Registro";
            // 
            // txtTipoRegistro
            // 
            this.txtTipoRegistro.Location = new System.Drawing.Point(90, 67);
            this.txtTipoRegistro.Name = "txtTipoRegistro";
            this.txtTipoRegistro.ReadOnly = true;
            this.txtTipoRegistro.Size = new System.Drawing.Size(24, 23);
            this.txtTipoRegistro.TabIndex = 0;
            // 
            // lblEncabezado
            // 
            this.lblEncabezado.AutoSize = true;
            this.lblEncabezado.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEncabezado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblEncabezado.Location = new System.Drawing.Point(12, 18);
            this.lblEncabezado.Name = "lblEncabezado";
            this.lblEncabezado.Size = new System.Drawing.Size(114, 25);
            this.lblEncabezado.TabIndex = 40;
            this.lblEncabezado.Text = "Encabezado";
            // 
            // lblMontoDet
            // 
            this.lblMontoDet.Location = new System.Drawing.Point(0, 0);
            this.lblMontoDet.Name = "lblMontoDet";
            this.lblMontoDet.Size = new System.Drawing.Size(100, 23);
            this.lblMontoDet.TabIndex = 24;
            // 
            // pDetail
            // 
            this.pDetail.Controls.Add(this.dgvDetalle);
            this.pDetail.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pDetail.Location = new System.Drawing.Point(3, 250);
            this.pDetail.Name = "pDetail";
            this.pDetail.Size = new System.Drawing.Size(786, 240);
            this.pDetail.TabIndex = 14;
            // 
            // dgvDetalle
            // 
            this.dgvDetalle.AllowUserToAddRows = false;
            this.dgvDetalle.AllowUserToDeleteRows = false;
            this.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetalle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDetalle.Location = new System.Drawing.Point(0, 0);
            this.dgvDetalle.Name = "dgvDetalle";
            this.dgvDetalle.ReadOnly = true;
            this.dgvDetalle.RowTemplate.Height = 25;
            this.dgvDetalle.Size = new System.Drawing.Size(786, 240);
            this.dgvDetalle.TabIndex = 0;
            this.dgvDetalle.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDetalle_CellDoubleClick);
            // 
            // lblPeriodoPago
            // 
            this.lblPeriodoPago.Location = new System.Drawing.Point(0, 0);
            this.lblPeriodoPago.Name = "lblPeriodoPago";
            this.lblPeriodoPago.Size = new System.Drawing.Size(100, 23);
            this.lblPeriodoPago.TabIndex = 26;
            // 
            // InitialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.pGeneral);
            this.Name = "InitialForm";
            this.Text = "WriteAndRead CSV";
            this.Load += new System.EventHandler(this.InitialForm_Load);
            this.pGeneral.ResumeLayout(false);
            this.tabAcciones.ResumeLayout(false);
            this.Escribir.ResumeLayout(false);
            this.pHeader.ResumeLayout(false);
            this.pHeader.PerformLayout();
            this.pDetail.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel pGeneral;
        private TabControl tabAcciones;
        private TabPage Escribir;
        private Label lblPeriodoPago;
        private Label lblMontoDet;
        private Panel pDetail;
        private DataGridView dgvDetalle;
        private Panel pHeader;
        private MaskedTextBox txtNoDocDet;
        private MaskedTextBox txtTipoDocDet;
        private MaskedTextBox txtNoCtaDet;
        private MaskedTextBox txtNoCta;
        private MaskedTextBox txtRNC;
        private MaskedTextBox txtPeriodoPago;
        private MaskedTextBox txtFechaTransmision;
        private Label lblMontDet;
        private TextBox txtMontoDet;
        private Label lblPago;
        private Button btnBajarRegistro;
        private Label lblNoDocDet;
        private Label lblTipoDocDet;
        private Label lblNoCtaDet;
        private Label lblTipoRegistroDet;
        private TextBox txtTipoRegistroDet;
        private Button btnGenerarCSV;
        private Label lblNoCta;
        private Label lblMontoTotal;
        private TextBox txtMontoTotal;
        private Label lblFechaTranmision;
        private Label lblRNC;
        private Label lblTipoRegistro;
        private TextBox txtTipoRegistro;
        private Label lblEncabezado;
        private Label lblDetalle;
        private Button btnCargarCSV;
        private TextBox txtRutaDeArchivo;
        private Button btnLimpiarDatos;
    }
}