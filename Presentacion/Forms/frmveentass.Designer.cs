namespace Presentacion.Forms
{
    partial class frmveentass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridPorductVentas = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridDetallaFactura = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtDescuentoNormal = new MaterialSkin.Controls.MaterialTextBox();
            this.txtdDescuentoPorcentaje = new MaterialSkin.Controls.MaterialTextBox();
            this.txtTotalAlPagar = new MaterialSkin.Controls.MaterialTextBox();
            this.txtGeneralSubTotal = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.txtBuscarProducto = new System.Windows.Forms.TextBox();
            this.materialLabel50 = new MaterialSkin.Controls.MaterialLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new MaterialSkin.Controls.MaterialButton();
            this.btnImprimir = new MaterialSkin.Controls.MaterialButton();
            this.btnLimpiar = new MaterialSkin.Controls.MaterialButton();
            this.btnRegrescar = new MaterialSkin.Controls.MaterialButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.bunifuDatepicker1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.txtCantidadProducto = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.LabelPorducto = new MaterialSkin.Controls.MaterialLabel();
            this.printDocumentFac = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPorductVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetallaFactura)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridPorductVentas
            // 
            this.dataGridPorductVentas.AllowUserToAddRows = false;
            this.dataGridPorductVentas.AllowUserToDeleteRows = false;
            this.dataGridPorductVentas.AllowUserToResizeColumns = false;
            this.dataGridPorductVentas.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridPorductVentas.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridPorductVentas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridPorductVentas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridPorductVentas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridPorductVentas.CausesValidation = false;
            this.dataGridPorductVentas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPorductVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridPorductVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridPorductVentas.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridPorductVentas.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridPorductVentas.DoubleBuffered = false;
            this.dataGridPorductVentas.EnableHeadersVisualStyles = false;
            this.dataGridPorductVentas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridPorductVentas.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.dataGridPorductVentas.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridPorductVentas.Location = new System.Drawing.Point(644, 149);
            this.dataGridPorductVentas.MultiSelect = false;
            this.dataGridPorductVentas.Name = "dataGridPorductVentas";
            this.dataGridPorductVentas.ReadOnly = true;
            this.dataGridPorductVentas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridPorductVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridPorductVentas.RowHeadersVisible = false;
            this.dataGridPorductVentas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridPorductVentas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridPorductVentas.Size = new System.Drawing.Size(647, 271);
            this.dataGridPorductVentas.TabIndex = 51;
            // 
            // dataGridDetallaFactura
            // 
            this.dataGridDetallaFactura.AllowUserToAddRows = false;
            this.dataGridDetallaFactura.AllowUserToDeleteRows = false;
            this.dataGridDetallaFactura.AllowUserToResizeColumns = false;
            this.dataGridDetallaFactura.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridDetallaFactura.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridDetallaFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDetallaFactura.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridDetallaFactura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridDetallaFactura.CausesValidation = false;
            this.dataGridDetallaFactura.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDetallaFactura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridDetallaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetallaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Precio,
            this.Column2,
            this.Column3,
            this.IdProduct});
            this.dataGridDetallaFactura.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(208)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridDetallaFactura.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridDetallaFactura.DoubleBuffered = false;
            this.dataGridDetallaFactura.EnableHeadersVisualStyles = false;
            this.dataGridDetallaFactura.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.dataGridDetallaFactura.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.dataGridDetallaFactura.HeaderForeColor = System.Drawing.Color.White;
            this.dataGridDetallaFactura.Location = new System.Drawing.Point(6, 453);
            this.dataGridDetallaFactura.MultiSelect = false;
            this.dataGridDetallaFactura.Name = "dataGridDetallaFactura";
            this.dataGridDetallaFactura.ReadOnly = true;
            this.dataGridDetallaFactura.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridDetallaFactura.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridDetallaFactura.RowHeadersVisible = false;
            this.dataGridDetallaFactura.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridDetallaFactura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridDetallaFactura.Size = new System.Drawing.Size(584, 250);
            this.dataGridDetallaFactura.TabIndex = 51;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Cantidad";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "SubTotal";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // IdProduct
            // 
            this.IdProduct.HeaderText = "Column4";
            this.IdProduct.Name = "IdProduct";
            this.IdProduct.ReadOnly = true;
            this.IdProduct.Visible = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.txtDescuentoNormal);
            this.materialCard1.Controls.Add(this.txtdDescuentoPorcentaje);
            this.materialCard1.Controls.Add(this.txtTotalAlPagar);
            this.materialCard1.Controls.Add(this.txtGeneralSubTotal);
            this.materialCard1.Controls.Add(this.materialLabel4);
            this.materialCard1.Controls.Add(this.materialLabel5);
            this.materialCard1.Controls.Add(this.materialLabel3);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(816, 437);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(475, 240);
            this.materialCard1.TabIndex = 56;
            // 
            // txtDescuentoNormal
            // 
            this.txtDescuentoNormal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDescuentoNormal.Depth = 0;
            this.txtDescuentoNormal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDescuentoNormal.LeadingIcon = null;
            this.txtDescuentoNormal.Location = new System.Drawing.Point(301, 81);
            this.txtDescuentoNormal.MaxLength = 50;
            this.txtDescuentoNormal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescuentoNormal.Multiline = false;
            this.txtDescuentoNormal.Name = "txtDescuentoNormal";
            this.txtDescuentoNormal.ReadOnly = true;
            this.txtDescuentoNormal.Size = new System.Drawing.Size(166, 50);
            this.txtDescuentoNormal.TabIndex = 0;
            this.txtDescuentoNormal.Text = "";
            this.txtDescuentoNormal.TrailingIcon = null;
            this.txtDescuentoNormal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // txtdDescuentoPorcentaje
            // 
            this.txtdDescuentoPorcentaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtdDescuentoPorcentaje.Depth = 0;
            this.txtdDescuentoPorcentaje.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtdDescuentoPorcentaje.LeadingIcon = null;
            this.txtdDescuentoPorcentaje.Location = new System.Drawing.Point(157, 81);
            this.txtdDescuentoPorcentaje.MaxLength = 50;
            this.txtdDescuentoPorcentaje.MouseState = MaterialSkin.MouseState.OUT;
            this.txtdDescuentoPorcentaje.Multiline = false;
            this.txtdDescuentoPorcentaje.Name = "txtdDescuentoPorcentaje";
            this.txtdDescuentoPorcentaje.Size = new System.Drawing.Size(105, 50);
            this.txtdDescuentoPorcentaje.TabIndex = 0;
            this.txtdDescuentoPorcentaje.Text = "";
            this.txtdDescuentoPorcentaje.TrailingIcon = null;
            this.txtdDescuentoPorcentaje.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtdDescuentoPorcentaje_KeyUp);
            // 
            // txtTotalAlPagar
            // 
            this.txtTotalAlPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalAlPagar.Depth = 0;
            this.txtTotalAlPagar.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTotalAlPagar.LeadingIcon = null;
            this.txtTotalAlPagar.Location = new System.Drawing.Point(157, 151);
            this.txtTotalAlPagar.MaxLength = 50;
            this.txtTotalAlPagar.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTotalAlPagar.Multiline = false;
            this.txtTotalAlPagar.Name = "txtTotalAlPagar";
            this.txtTotalAlPagar.ReadOnly = true;
            this.txtTotalAlPagar.Size = new System.Drawing.Size(312, 50);
            this.txtTotalAlPagar.TabIndex = 0;
            this.txtTotalAlPagar.Text = "";
            this.txtTotalAlPagar.TrailingIcon = null;
            this.txtTotalAlPagar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // txtGeneralSubTotal
            // 
            this.txtGeneralSubTotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGeneralSubTotal.Depth = 0;
            this.txtGeneralSubTotal.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGeneralSubTotal.LeadingIcon = null;
            this.txtGeneralSubTotal.Location = new System.Drawing.Point(155, 10);
            this.txtGeneralSubTotal.MaxLength = 50;
            this.txtGeneralSubTotal.MouseState = MaterialSkin.MouseState.OUT;
            this.txtGeneralSubTotal.Multiline = false;
            this.txtGeneralSubTotal.Name = "txtGeneralSubTotal";
            this.txtGeneralSubTotal.ReadOnly = true;
            this.txtGeneralSubTotal.Size = new System.Drawing.Size(312, 50);
            this.txtGeneralSubTotal.TabIndex = 0;
            this.txtGeneralSubTotal.Text = "";
            this.txtGeneralSubTotal.TrailingIcon = null;
            this.txtGeneralSubTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel4.Location = new System.Drawing.Point(276, 92);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(19, 29);
            this.materialLabel4.TabIndex = 57;
            this.materialLabel4.Text = "%";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(29, 182);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(100, 19);
            this.materialLabel5.TabIndex = 57;
            this.materialLabel5.Text = "Tatal al pagar";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(53, 103);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(76, 19);
            this.materialLabel3.TabIndex = 57;
            this.materialLabel3.Text = "Descuento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(59, 41);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(70, 19);
            this.materialLabel2.TabIndex = 57;
            this.materialLabel2.Text = "Sub Total";
            // 
            // txtBuscarProducto
            // 
            this.txtBuscarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.txtBuscarProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBuscarProducto.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarProducto.Location = new System.Drawing.Point(975, 85);
            this.txtBuscarProducto.Name = "txtBuscarProducto";
            this.txtBuscarProducto.Size = new System.Drawing.Size(293, 28);
            this.txtBuscarProducto.TabIndex = 60;
            this.txtBuscarProducto.TextChanged += new System.EventHandler(this.txtBuscarProducto_TextChanged);
            // 
            // materialLabel50
            // 
            this.materialLabel50.AutoSize = true;
            this.materialLabel50.Depth = 0;
            this.materialLabel50.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel50.Location = new System.Drawing.Point(689, 94);
            this.materialLabel50.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel50.Name = "materialLabel50";
            this.materialLabel50.Size = new System.Drawing.Size(218, 19);
            this.materialLabel50.TabIndex = 57;
            this.materialLabel50.Text = "Buscar productos por nombres";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::Presentacion.Properties.Resources.Buscar;
            this.pictureBox8.Location = new System.Drawing.Point(943, 79);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 36);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 58;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Presentacion.Properties.Resources.forma;
            this.pictureBox9.Location = new System.Drawing.Point(925, 70);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(366, 50);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 59;
            this.pictureBox9.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = false;
            this.btnAgregar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAgregar.BackColor = System.Drawing.Color.Yellow;
            this.btnAgregar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnAgregar.Depth = 0;
            this.btnAgregar.HighEmphasis = true;
            this.btnAgregar.Icon = global::Presentacion.Properties.Resources.add_24px;
            this.btnAgregar.Location = new System.Drawing.Point(393, 330);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnAgregar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(170, 39);
            this.btnAgregar.TabIndex = 55;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnAgregar.UseAccentColor = false;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.AutoSize = false;
            this.btnImprimir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnImprimir.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnImprimir.Depth = 0;
            this.btnImprimir.HighEmphasis = true;
            this.btnImprimir.Icon = global::Presentacion.Properties.Resources.print_24px;
            this.btnImprimir.Location = new System.Drawing.Point(614, 518);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnImprimir.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(170, 39);
            this.btnImprimir.TabIndex = 52;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnImprimir.UseAccentColor = false;
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.AutoSize = false;
            this.btnLimpiar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLimpiar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnLimpiar.Depth = 0;
            this.btnLimpiar.HighEmphasis = true;
            this.btnLimpiar.Icon = global::Presentacion.Properties.Resources.clear;
            this.btnLimpiar.Location = new System.Drawing.Point(614, 453);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnLimpiar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(170, 39);
            this.btnLimpiar.TabIndex = 53;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnLimpiar.UseAccentColor = false;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnRegrescar
            // 
            this.btnRegrescar.AutoSize = false;
            this.btnRegrescar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegrescar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegrescar.Depth = 0;
            this.btnRegrescar.HighEmphasis = true;
            this.btnRegrescar.Icon = global::Presentacion.Properties.Resources.process_24px;
            this.btnRegrescar.Location = new System.Drawing.Point(75, 330);
            this.btnRegrescar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegrescar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegrescar.Name = "btnRegrescar";
            this.btnRegrescar.Size = new System.Drawing.Size(170, 39);
            this.btnRegrescar.TabIndex = 54;
            this.btnRegrescar.Text = "Refrescar";
            this.btnRegrescar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegrescar.UseAccentColor = false;
            this.btnRegrescar.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.materialLabel1.Location = new System.Drawing.Point(28, 415);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(170, 24);
            this.materialLabel1.TabIndex = 61;
            this.materialLabel1.Text = "Datos de la factura";
            // 
            // bunifuDatepicker1
            // 
            this.bunifuDatepicker1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(165)))), ((int)(((byte)(245)))));
            this.bunifuDatepicker1.BorderRadius = 0;
            this.bunifuDatepicker1.ForeColor = System.Drawing.Color.White;
            this.bunifuDatepicker1.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.bunifuDatepicker1.FormatCustom = null;
            this.bunifuDatepicker1.Location = new System.Drawing.Point(32, 162);
            this.bunifuDatepicker1.Name = "bunifuDatepicker1";
            this.bunifuDatepicker1.Size = new System.Drawing.Size(303, 36);
            this.bunifuDatepicker1.TabIndex = 62;
            this.bunifuDatepicker1.Value = new System.DateTime(2021, 8, 23, 12, 35, 17, 283);
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(29, 126);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(44, 19);
            this.materialLabel6.TabIndex = 57;
            this.materialLabel6.Text = "Fecha";
            // 
            // txtCantidadProducto
            // 
            this.txtCantidadProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadProducto.Depth = 0;
            this.txtCantidadProducto.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadProducto.LeadingIcon = null;
            this.txtCantidadProducto.Location = new System.Drawing.Point(377, 162);
            this.txtCantidadProducto.MaxLength = 50;
            this.txtCantidadProducto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidadProducto.Multiline = false;
            this.txtCantidadProducto.Name = "txtCantidadProducto";
            this.txtCantidadProducto.Size = new System.Drawing.Size(239, 50);
            this.txtCantidadProducto.TabIndex = 0;
            this.txtCantidadProducto.Text = "";
            this.txtCantidadProducto.TrailingIcon = null;
            this.txtCantidadProducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(374, 126);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(65, 19);
            this.materialLabel7.TabIndex = 57;
            this.materialLabel7.Text = "Cantidad";
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(393, 401);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(143, 19);
            this.materialLabel8.TabIndex = 57;
            this.materialLabel8.Text = "Prouctos agregados";
            // 
            // LabelPorducto
            // 
            this.LabelPorducto.AutoSize = true;
            this.LabelPorducto.Depth = 0;
            this.LabelPorducto.Font = new System.Drawing.Font("Roboto Medium", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.LabelPorducto.FontType = MaterialSkin.MaterialSkinManager.fontType.H6;
            this.LabelPorducto.Location = new System.Drawing.Point(551, 401);
            this.LabelPorducto.MouseState = MaterialSkin.MouseState.HOVER;
            this.LabelPorducto.Name = "LabelPorducto";
            this.LabelPorducto.Size = new System.Drawing.Size(12, 24);
            this.LabelPorducto.TabIndex = 57;
            this.LabelPorducto.Text = "0";
            // 
            // frmveentass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 720);
            this.Controls.Add(this.bunifuDatepicker1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.txtBuscarProducto);
            this.Controls.Add(this.txtCantidadProducto);
            this.Controls.Add(this.materialLabel50);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.materialCard1);
            this.Controls.Add(this.LabelPorducto);
            this.Controls.Add(this.materialLabel8);
            this.Controls.Add(this.materialLabel7);
            this.Controls.Add(this.materialLabel6);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnRegrescar);
            this.Controls.Add(this.dataGridDetallaFactura);
            this.Controls.Add(this.dataGridPorductVentas);
            this.Name = "frmveentass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Procesador de ventas";
            this.Load += new System.EventHandler(this.CargaDelFormualrioVentas);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridPorductVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetallaFactura)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridPorductVentas;
        private MaterialSkin.Controls.MaterialButton btnAgregar;
        private MaterialSkin.Controls.MaterialButton btnImprimir;
        private MaterialSkin.Controls.MaterialButton btnLimpiar;
        private MaterialSkin.Controls.MaterialButton btnRegrescar;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridDetallaFactura;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private System.Windows.Forms.TextBox txtBuscarProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel50;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private MaterialSkin.Controls.MaterialTextBox txtdDescuentoPorcentaje;
        private MaterialSkin.Controls.MaterialTextBox txtGeneralSubTotal;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialTextBox txtDescuentoNormal;
        private MaterialSkin.Controls.MaterialTextBox txtTotalAlPagar;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private Bunifu.Framework.UI.BunifuDatepicker bunifuDatepicker1;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private MaterialSkin.Controls.MaterialTextBox txtCantidadProducto;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel LabelPorducto;
        private System.Drawing.Printing.PrintDocument printDocumentFac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdProduct;
    }
}