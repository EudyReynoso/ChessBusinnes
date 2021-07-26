namespace Presentacion
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle271 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle272 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle273 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle274 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle275 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle276 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle277 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle278 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle279 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle280 = new System.Windows.Forms.DataGridViewCellStyle();
            this.TabsContent = new MaterialSkin.Controls.MaterialTabControl();
            this.Inicio = new System.Windows.Forms.TabPage();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.Empleado = new System.Windows.Forms.TabPage();
            this.DataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.comboPuesto = new MaterialSkin.Controls.MaterialComboBox();
            this.radioFemenino = new MaterialSkin.Controls.MaterialRadioButton();
            this.radioMasculino = new MaterialSkin.Controls.MaterialRadioButton();
            this.btnEditar = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtDepartamento = new MaterialSkin.Controls.MaterialTextBox();
            this.txtDireccion = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombre = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.Entrada = new System.Windows.Forms.TabPage();
            this.btnEditarEntrada = new MaterialSkin.Controls.MaterialButton();
            this.btnEliminarEntradaDeLeche = new MaterialSkin.Controls.MaterialButton();
            this.txtDate = new Bunifu.Framework.UI.BunifuDatepicker();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.txtCantidadEntrada = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel22 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel21 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel23 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel20 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel19 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel18 = new MaterialSkin.Controls.MaterialLabel();
            this.comboEstado = new MaterialSkin.Controls.MaterialComboBox();
            this.comboRecolector = new MaterialSkin.Controls.MaterialComboBox();
            this.ComboSuplodires = new MaterialSkin.Controls.MaterialComboBox();
            this.DataGridEntradasDELeche = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.suplidor = new System.Windows.Forms.TabPage();
            this.btnEmpleadoEditar = new MaterialSkin.Controls.MaterialButton();
            this.btnEmpleadoEliminar = new MaterialSkin.Controls.MaterialButton();
            this.btnEmpleadoGuardar = new MaterialSkin.Controls.MaterialButton();
            this.txtDireccionSupli = new MaterialSkin.Controls.MaterialMultiLineTextBox();
            this.txtTelSupli = new MaterialSkin.Controls.MaterialTextBox();
            this.txtApellidoSupli = new MaterialSkin.Controls.MaterialTextBox();
            this.txtNombreSupli = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel14 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel17 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel15 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel16 = new MaterialSkin.Controls.MaterialLabel();
            this.dataGridSuplidor = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.Creadores = new System.Windows.Forms.TabPage();
            this.TabsContent.SuspendLayout();
            this.Inicio.SuspendLayout();
            this.Empleado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.Entrada.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEntradasDELeche)).BeginInit();
            this.suplidor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuplidor)).BeginInit();
            this.SuspendLayout();
            // 
            // TabsContent
            // 
            this.TabsContent.Controls.Add(this.Inicio);
            this.TabsContent.Controls.Add(this.Empleado);
            this.TabsContent.Controls.Add(this.Entrada);
            this.TabsContent.Controls.Add(this.suplidor);
            this.TabsContent.Controls.Add(this.Creadores);
            this.TabsContent.Depth = 0;
            this.TabsContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabsContent.Location = new System.Drawing.Point(3, 64);
            this.TabsContent.MouseState = MaterialSkin.MouseState.HOVER;
            this.TabsContent.Multiline = true;
            this.TabsContent.Name = "TabsContent";
            this.TabsContent.SelectedIndex = 0;
            this.TabsContent.Size = new System.Drawing.Size(1145, 612);
            this.TabsContent.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabsContent.TabIndex = 0;
            // 
            // Inicio
            // 
            this.Inicio.BackColor = System.Drawing.Color.White;
            this.Inicio.Controls.Add(this.materialLabel6);
            this.Inicio.ImageKey = "(ninguno)";
            this.Inicio.Location = new System.Drawing.Point(4, 22);
            this.Inicio.Name = "Inicio";
            this.Inicio.Size = new System.Drawing.Size(1137, 586);
            this.Inicio.TabIndex = 5;
            this.Inicio.Text = "Inicio";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 34F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.FontType = MaterialSkin.MaterialSkinManager.fontType.H4;
            this.materialLabel6.Location = new System.Drawing.Point(422, 24);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(303, 41);
            this.materialLabel6.TabIndex = 0;
            this.materialLabel6.Text = "Sistema de registro ";
            // 
            // Empleado
            // 
            this.Empleado.BackColor = System.Drawing.Color.White;
            this.Empleado.Controls.Add(this.DataGrid);
            this.Empleado.Controls.Add(this.comboPuesto);
            this.Empleado.Controls.Add(this.radioFemenino);
            this.Empleado.Controls.Add(this.radioMasculino);
            this.Empleado.Controls.Add(this.btnEditar);
            this.Empleado.Controls.Add(this.btnEliminar);
            this.Empleado.Controls.Add(this.btnGuardar);
            this.Empleado.Controls.Add(this.txtDepartamento);
            this.Empleado.Controls.Add(this.txtDireccion);
            this.Empleado.Controls.Add(this.txtNombre);
            this.Empleado.Controls.Add(this.materialLabel12);
            this.Empleado.Controls.Add(this.materialLabel5);
            this.Empleado.Controls.Add(this.materialLabel4);
            this.Empleado.Controls.Add(this.materialLabel3);
            this.Empleado.Controls.Add(this.materialLabel2);
            this.Empleado.Controls.Add(this.materialLabel1);
            this.Empleado.ImageKey = "(ninguno)";
            this.Empleado.Location = new System.Drawing.Point(4, 22);
            this.Empleado.Name = "Empleado";
            this.Empleado.Padding = new System.Windows.Forms.Padding(3);
            this.Empleado.Size = new System.Drawing.Size(1137, 586);
            this.Empleado.TabIndex = 1;
            this.Empleado.Text = "Nuevo Empleado";
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToAddRows = false;
            this.DataGrid.AllowUserToDeleteRows = false;
            this.DataGrid.AllowUserToResizeColumns = false;
            this.DataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle271.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle271;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGrid.BackgroundColor = System.Drawing.Color.White;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle272.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle272.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle272.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle272.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle272.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle272.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle272.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle272;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle273.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle273.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle273.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle273.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle273.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle273.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle273.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle273;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DataGrid.DoubleBuffered = true;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.GridColor = System.Drawing.Color.White;
            this.DataGrid.HeaderBgColor = System.Drawing.Color.White;
            this.DataGrid.HeaderForeColor = System.Drawing.Color.Black;
            this.DataGrid.Location = new System.Drawing.Point(3, 337);
            this.DataGrid.MultiSelect = false;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.ReadOnly = true;
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle274.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle274.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle274.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle274.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle274.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle274.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle274.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle274;
            this.DataGrid.RowHeadersVisible = false;
            this.DataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(1131, 246);
            this.DataGrid.TabIndex = 9;
            // 
            // comboPuesto
            // 
            this.comboPuesto.AutoResize = false;
            this.comboPuesto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboPuesto.Depth = 0;
            this.comboPuesto.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboPuesto.DropDownHeight = 174;
            this.comboPuesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPuesto.DropDownWidth = 121;
            this.comboPuesto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboPuesto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboPuesto.FormattingEnabled = true;
            this.comboPuesto.IntegralHeight = false;
            this.comboPuesto.ItemHeight = 43;
            this.comboPuesto.Location = new System.Drawing.Point(567, 116);
            this.comboPuesto.MaxDropDownItems = 4;
            this.comboPuesto.MouseState = MaterialSkin.MouseState.OUT;
            this.comboPuesto.Name = "comboPuesto";
            this.comboPuesto.Size = new System.Drawing.Size(274, 49);
            this.comboPuesto.StartIndex = 0;
            this.comboPuesto.TabIndex = 6;
            // 
            // radioFemenino
            // 
            this.radioFemenino.AutoSize = true;
            this.radioFemenino.Depth = 0;
            this.radioFemenino.Location = new System.Drawing.Point(929, 108);
            this.radioFemenino.Margin = new System.Windows.Forms.Padding(0);
            this.radioFemenino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioFemenino.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioFemenino.Name = "radioFemenino";
            this.radioFemenino.Ripple = true;
            this.radioFemenino.Size = new System.Drawing.Size(105, 37);
            this.radioFemenino.TabIndex = 5;
            this.radioFemenino.TabStop = true;
            this.radioFemenino.Text = "Femenino";
            this.radioFemenino.UseVisualStyleBackColor = true;
            // 
            // radioMasculino
            // 
            this.radioMasculino.AutoSize = true;
            this.radioMasculino.Depth = 0;
            this.radioMasculino.Location = new System.Drawing.Point(929, 63);
            this.radioMasculino.Margin = new System.Windows.Forms.Padding(0);
            this.radioMasculino.MouseLocation = new System.Drawing.Point(-1, -1);
            this.radioMasculino.MouseState = MaterialSkin.MouseState.HOVER;
            this.radioMasculino.Name = "radioMasculino";
            this.radioMasculino.Ripple = true;
            this.radioMasculino.Size = new System.Drawing.Size(109, 37);
            this.radioMasculino.TabIndex = 5;
            this.radioMasculino.TabStop = true;
            this.radioMasculino.Text = "Masculino";
            this.radioMasculino.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.AutoSize = false;
            this.btnEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditar.BackColor = System.Drawing.Color.Yellow;
            this.btnEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditar.Depth = 0;
            this.btnEditar.HighEmphasis = true;
            this.btnEditar.Icon = null;
            this.btnEditar.Location = new System.Drawing.Point(629, 214);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(188, 61);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditar.UseAccentColor = false;
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSize = false;
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminar.BackColor = System.Drawing.Color.Yellow;
            this.btnEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminar.Depth = 0;
            this.btnEliminar.HighEmphasis = true;
            this.btnEliminar.Icon = null;
            this.btnEliminar.Location = new System.Drawing.Point(364, 214);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(188, 61);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminar.UseAccentColor = false;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.AutoSize = false;
            this.btnGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnGuardar.BackColor = System.Drawing.Color.Yellow;
            this.btnGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnGuardar.Depth = 0;
            this.btnGuardar.DrawShadows = false;
            this.btnGuardar.HighEmphasis = true;
            this.btnGuardar.Icon = null;
            this.btnGuardar.Location = new System.Drawing.Point(118, 214);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(189, 61);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnGuardar.UseAccentColor = false;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDepartamento.Depth = 0;
            this.txtDepartamento.DetectUrls = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDepartamento.LeadingIcon = null;
            this.txtDepartamento.Location = new System.Drawing.Point(567, 63);
            this.txtDepartamento.MaxLength = 60;
            this.txtDepartamento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDepartamento.Multiline = false;
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(274, 36);
            this.txtDepartamento.TabIndex = 2;
            this.txtDepartamento.Text = "";
            this.txtDepartamento.TrailingIcon = null;
            this.txtDepartamento.UseTallSize = false;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Depth = 0;
            this.txtDireccion.DetectUrls = false;
            this.txtDireccion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccion.LeadingIcon = null;
            this.txtDireccion.Location = new System.Drawing.Point(118, 116);
            this.txtDireccion.MaxLength = 60;
            this.txtDireccion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDireccion.Multiline = false;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(274, 36);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.Text = "";
            this.txtDireccion.TrailingIcon = null;
            this.txtDireccion.UseTallSize = false;
            // 
            // txtNombre
            // 
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombre.Depth = 0;
            this.txtNombre.DetectUrls = false;
            this.txtNombre.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombre.LeadingIcon = null;
            this.txtNombre.Location = new System.Drawing.Point(118, 63);
            this.txtNombre.MaxLength = 60;
            this.txtNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombre.Multiline = false;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(274, 36);
            this.txtNombre.TabIndex = 2;
            this.txtNombre.Text = "";
            this.txtNombre.TrailingIcon = null;
            this.txtNombre.UseTallSize = false;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel12.Location = new System.Drawing.Point(113, 15);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(248, 29);
            this.materialLabel12.TabIndex = 1;
            this.materialLabel12.Text = "Registro de empleados";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(435, 80);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(102, 19);
            this.materialLabel5.TabIndex = 1;
            this.materialLabel5.Text = "Departamento";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(487, 146);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(50, 19);
            this.materialLabel4.TabIndex = 1;
            this.materialLabel4.Text = "Puesto";
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(952, 25);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(36, 19);
            this.materialLabel3.TabIndex = 1;
            this.materialLabel3.Text = "Sexo";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(22, 133);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(67, 19);
            this.materialLabel2.TabIndex = 1;
            this.materialLabel2.Text = "Direccion";
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(32, 80);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(57, 19);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Text = "Nombre";
            // 
            // Entrada
            // 
            this.Entrada.BackColor = System.Drawing.Color.White;
            this.Entrada.Controls.Add(this.btnEditarEntrada);
            this.Entrada.Controls.Add(this.btnEliminarEntradaDeLeche);
            this.Entrada.Controls.Add(this.txtDate);
            this.Entrada.Controls.Add(this.materialButton3);
            this.Entrada.Controls.Add(this.txtCantidadEntrada);
            this.Entrada.Controls.Add(this.materialLabel22);
            this.Entrada.Controls.Add(this.materialLabel21);
            this.Entrada.Controls.Add(this.materialLabel23);
            this.Entrada.Controls.Add(this.materialLabel20);
            this.Entrada.Controls.Add(this.materialLabel19);
            this.Entrada.Controls.Add(this.materialLabel18);
            this.Entrada.Controls.Add(this.comboEstado);
            this.Entrada.Controls.Add(this.comboRecolector);
            this.Entrada.Controls.Add(this.ComboSuplodires);
            this.Entrada.Controls.Add(this.DataGridEntradasDELeche);
            this.Entrada.ImageKey = "(ninguno)";
            this.Entrada.Location = new System.Drawing.Point(4, 22);
            this.Entrada.Name = "Entrada";
            this.Entrada.Size = new System.Drawing.Size(1137, 586);
            this.Entrada.TabIndex = 2;
            this.Entrada.Text = "Entrada de Leche";
            // 
            // btnEditarEntrada
            // 
            this.btnEditarEntrada.AutoSize = false;
            this.btnEditarEntrada.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEditarEntrada.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEditarEntrada.Depth = 0;
            this.btnEditarEntrada.HighEmphasis = true;
            this.btnEditarEntrada.Icon = null;
            this.btnEditarEntrada.Location = new System.Drawing.Point(756, 265);
            this.btnEditarEntrada.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEditarEntrada.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEditarEntrada.Name = "btnEditarEntrada";
            this.btnEditarEntrada.Size = new System.Drawing.Size(160, 60);
            this.btnEditarEntrada.TabIndex = 21;
            this.btnEditarEntrada.Text = "Editar";
            this.btnEditarEntrada.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEditarEntrada.UseAccentColor = false;
            this.btnEditarEntrada.UseVisualStyleBackColor = true;
            this.btnEditarEntrada.Click += new System.EventHandler(this.btnEditarEntrada_Click);
            // 
            // btnEliminarEntradaDeLeche
            // 
            this.btnEliminarEntradaDeLeche.AutoSize = false;
            this.btnEliminarEntradaDeLeche.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarEntradaDeLeche.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEliminarEntradaDeLeche.Depth = 0;
            this.btnEliminarEntradaDeLeche.HighEmphasis = true;
            this.btnEliminarEntradaDeLeche.Icon = null;
            this.btnEliminarEntradaDeLeche.Location = new System.Drawing.Point(493, 265);
            this.btnEliminarEntradaDeLeche.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEliminarEntradaDeLeche.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEliminarEntradaDeLeche.Name = "btnEliminarEntradaDeLeche";
            this.btnEliminarEntradaDeLeche.Size = new System.Drawing.Size(175, 60);
            this.btnEliminarEntradaDeLeche.TabIndex = 20;
            this.btnEliminarEntradaDeLeche.Text = "eliminar";
            this.btnEliminarEntradaDeLeche.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEliminarEntradaDeLeche.UseAccentColor = false;
            this.btnEliminarEntradaDeLeche.UseVisualStyleBackColor = true;
            this.btnEliminarEntradaDeLeche.Click += new System.EventHandler(this.btnEliminarEntradaDeLeche_Click);
            // 
            // txtDate
            // 
            this.txtDate.BackColor = System.Drawing.Color.SeaGreen;
            this.txtDate.BorderRadius = 0;
            this.txtDate.ForeColor = System.Drawing.Color.White;
            this.txtDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtDate.FormatCustom = null;
            this.txtDate.Location = new System.Drawing.Point(613, 176);
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(303, 36);
            this.txtDate.TabIndex = 19;
            this.txtDate.Value = new System.DateTime(2021, 6, 24, 17, 15, 11, 351);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSize = false;
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(241, 265);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.Size = new System.Drawing.Size(181, 60);
            this.materialButton3.TabIndex = 18;
            this.materialButton3.Text = "Guardar";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // txtCantidadEntrada
            // 
            this.txtCantidadEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidadEntrada.Depth = 0;
            this.txtCantidadEntrada.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCantidadEntrada.LeadingIcon = null;
            this.txtCantidadEntrada.Location = new System.Drawing.Point(132, 176);
            this.txtCantidadEntrada.MaxLength = 50;
            this.txtCantidadEntrada.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCantidadEntrada.Multiline = false;
            this.txtCantidadEntrada.Name = "txtCantidadEntrada";
            this.txtCantidadEntrada.Size = new System.Drawing.Size(290, 50);
            this.txtCantidadEntrada.TabIndex = 12;
            this.txtCantidadEntrada.Text = "";
            this.txtCantidadEntrada.TrailingIcon = null;
            this.txtCantidadEntrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.materialTextBox1_KeyPress);
            // 
            // materialLabel22
            // 
            this.materialLabel22.AutoSize = true;
            this.materialLabel22.Depth = 0;
            this.materialLabel22.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel22.Location = new System.Drawing.Point(540, 191);
            this.materialLabel22.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel22.Name = "materialLabel22";
            this.materialLabel22.Size = new System.Drawing.Size(44, 19);
            this.materialLabel22.TabIndex = 11;
            this.materialLabel22.Text = "Fecha";
            // 
            // materialLabel21
            // 
            this.materialLabel21.AutoSize = true;
            this.materialLabel21.Depth = 0;
            this.materialLabel21.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel21.Location = new System.Drawing.Point(534, 94);
            this.materialLabel21.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel21.Name = "materialLabel21";
            this.materialLabel21.Size = new System.Drawing.Size(50, 19);
            this.materialLabel21.TabIndex = 11;
            this.materialLabel21.Text = "Estado";
            // 
            // materialLabel23
            // 
            this.materialLabel23.AutoSize = true;
            this.materialLabel23.Depth = 0;
            this.materialLabel23.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel23.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel23.Location = new System.Drawing.Point(127, 14);
            this.materialLabel23.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel23.Name = "materialLabel23";
            this.materialLabel23.Size = new System.Drawing.Size(188, 29);
            this.materialLabel23.TabIndex = 11;
            this.materialLabel23.Text = "Entrada de Leche";
            // 
            // materialLabel20
            // 
            this.materialLabel20.AutoSize = true;
            this.materialLabel20.Depth = 0;
            this.materialLabel20.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel20.Location = new System.Drawing.Point(39, 207);
            this.materialLabel20.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel20.Name = "materialLabel20";
            this.materialLabel20.Size = new System.Drawing.Size(65, 19);
            this.materialLabel20.TabIndex = 11;
            this.materialLabel20.Text = "Cantidad";
            // 
            // materialLabel19
            // 
            this.materialLabel19.AutoSize = true;
            this.materialLabel19.Depth = 0;
            this.materialLabel19.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel19.Location = new System.Drawing.Point(29, 149);
            this.materialLabel19.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel19.Name = "materialLabel19";
            this.materialLabel19.Size = new System.Drawing.Size(75, 19);
            this.materialLabel19.TabIndex = 11;
            this.materialLabel19.Text = "Recolector";
            // 
            // materialLabel18
            // 
            this.materialLabel18.AutoSize = true;
            this.materialLabel18.Depth = 0;
            this.materialLabel18.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel18.Location = new System.Drawing.Point(44, 93);
            this.materialLabel18.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel18.Name = "materialLabel18";
            this.materialLabel18.Size = new System.Drawing.Size(60, 19);
            this.materialLabel18.TabIndex = 11;
            this.materialLabel18.Text = "Suplidor";
            // 
            // comboEstado
            // 
            this.comboEstado.AutoResize = false;
            this.comboEstado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboEstado.Depth = 0;
            this.comboEstado.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboEstado.DropDownHeight = 174;
            this.comboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEstado.DropDownWidth = 121;
            this.comboEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboEstado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboEstado.FormattingEnabled = true;
            this.comboEstado.IntegralHeight = false;
            this.comboEstado.ItemHeight = 43;
            this.comboEstado.Location = new System.Drawing.Point(613, 64);
            this.comboEstado.MaxDropDownItems = 4;
            this.comboEstado.MouseState = MaterialSkin.MouseState.OUT;
            this.comboEstado.Name = "comboEstado";
            this.comboEstado.Size = new System.Drawing.Size(303, 49);
            this.comboEstado.StartIndex = 0;
            this.comboEstado.TabIndex = 9;
            // 
            // comboRecolector
            // 
            this.comboRecolector.AutoResize = false;
            this.comboRecolector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.comboRecolector.Depth = 0;
            this.comboRecolector.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboRecolector.DropDownHeight = 174;
            this.comboRecolector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecolector.DropDownWidth = 121;
            this.comboRecolector.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.comboRecolector.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.comboRecolector.FormattingEnabled = true;
            this.comboRecolector.IntegralHeight = false;
            this.comboRecolector.ItemHeight = 43;
            this.comboRecolector.Location = new System.Drawing.Point(132, 119);
            this.comboRecolector.MaxDropDownItems = 4;
            this.comboRecolector.MouseState = MaterialSkin.MouseState.OUT;
            this.comboRecolector.Name = "comboRecolector";
            this.comboRecolector.Size = new System.Drawing.Size(290, 49);
            this.comboRecolector.StartIndex = 0;
            this.comboRecolector.TabIndex = 9;
            // 
            // ComboSuplodires
            // 
            this.ComboSuplodires.AutoResize = false;
            this.ComboSuplodires.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ComboSuplodires.Depth = 0;
            this.ComboSuplodires.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.ComboSuplodires.DropDownHeight = 174;
            this.ComboSuplodires.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboSuplodires.DropDownWidth = 121;
            this.ComboSuplodires.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.ComboSuplodires.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ComboSuplodires.FormattingEnabled = true;
            this.ComboSuplodires.IntegralHeight = false;
            this.ComboSuplodires.ItemHeight = 43;
            this.ComboSuplodires.Location = new System.Drawing.Point(132, 64);
            this.ComboSuplodires.MaxDropDownItems = 4;
            this.ComboSuplodires.MouseState = MaterialSkin.MouseState.OUT;
            this.ComboSuplodires.Name = "ComboSuplodires";
            this.ComboSuplodires.Size = new System.Drawing.Size(290, 49);
            this.ComboSuplodires.StartIndex = 0;
            this.ComboSuplodires.TabIndex = 9;
            // 
            // DataGridEntradasDELeche
            // 
            this.DataGridEntradasDELeche.AllowUserToAddRows = false;
            this.DataGridEntradasDELeche.AllowUserToDeleteRows = false;
            dataGridViewCellStyle275.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridEntradasDELeche.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle275;
            this.DataGridEntradasDELeche.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridEntradasDELeche.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridEntradasDELeche.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.DataGridEntradasDELeche.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridEntradasDELeche.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle276.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle276.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle276.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle276.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle276.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle276.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle276.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridEntradasDELeche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle276;
            this.DataGridEntradasDELeche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle277.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle277.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle277.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle277.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle277.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle277.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle277.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridEntradasDELeche.DefaultCellStyle = dataGridViewCellStyle277;
            this.DataGridEntradasDELeche.DoubleBuffered = true;
            this.DataGridEntradasDELeche.EnableHeadersVisualStyles = false;
            this.DataGridEntradasDELeche.HeaderBgColor = System.Drawing.Color.White;
            this.DataGridEntradasDELeche.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.DataGridEntradasDELeche.Location = new System.Drawing.Point(0, 354);
            this.DataGridEntradasDELeche.MultiSelect = false;
            this.DataGridEntradasDELeche.Name = "DataGridEntradasDELeche";
            this.DataGridEntradasDELeche.ReadOnly = true;
            this.DataGridEntradasDELeche.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridEntradasDELeche.RowHeadersVisible = false;
            this.DataGridEntradasDELeche.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridEntradasDELeche.Size = new System.Drawing.Size(1137, 232);
            this.DataGridEntradasDELeche.TabIndex = 8;
            // 
            // suplidor
            // 
            this.suplidor.Controls.Add(this.btnEmpleadoEditar);
            this.suplidor.Controls.Add(this.btnEmpleadoEliminar);
            this.suplidor.Controls.Add(this.btnEmpleadoGuardar);
            this.suplidor.Controls.Add(this.txtDireccionSupli);
            this.suplidor.Controls.Add(this.txtTelSupli);
            this.suplidor.Controls.Add(this.txtApellidoSupli);
            this.suplidor.Controls.Add(this.txtNombreSupli);
            this.suplidor.Controls.Add(this.materialLabel14);
            this.suplidor.Controls.Add(this.materialLabel17);
            this.suplidor.Controls.Add(this.materialLabel15);
            this.suplidor.Controls.Add(this.materialLabel16);
            this.suplidor.Controls.Add(this.dataGridSuplidor);
            this.suplidor.Controls.Add(this.materialLabel13);
            this.suplidor.ImageKey = "(ninguno)";
            this.suplidor.Location = new System.Drawing.Point(4, 22);
            this.suplidor.Name = "suplidor";
            this.suplidor.Size = new System.Drawing.Size(1137, 586);
            this.suplidor.TabIndex = 4;
            this.suplidor.Text = "Nuevo Suplidor";
            this.suplidor.UseVisualStyleBackColor = true;
            // 
            // btnEmpleadoEditar
            // 
            this.btnEmpleadoEditar.AutoSize = false;
            this.btnEmpleadoEditar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleadoEditar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEmpleadoEditar.Depth = 0;
            this.btnEmpleadoEditar.HighEmphasis = true;
            this.btnEmpleadoEditar.Icon = null;
            this.btnEmpleadoEditar.Location = new System.Drawing.Point(742, 246);
            this.btnEmpleadoEditar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmpleadoEditar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleadoEditar.Name = "btnEmpleadoEditar";
            this.btnEmpleadoEditar.Size = new System.Drawing.Size(181, 60);
            this.btnEmpleadoEditar.TabIndex = 15;
            this.btnEmpleadoEditar.Text = "Editar";
            this.btnEmpleadoEditar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEmpleadoEditar.UseAccentColor = false;
            this.btnEmpleadoEditar.UseVisualStyleBackColor = true;
            this.btnEmpleadoEditar.Click += new System.EventHandler(this.btnEmpleadoEditar_Click);
            // 
            // btnEmpleadoEliminar
            // 
            this.btnEmpleadoEliminar.AutoSize = false;
            this.btnEmpleadoEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleadoEliminar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEmpleadoEliminar.Depth = 0;
            this.btnEmpleadoEliminar.HighEmphasis = true;
            this.btnEmpleadoEliminar.Icon = null;
            this.btnEmpleadoEliminar.Location = new System.Drawing.Point(493, 246);
            this.btnEmpleadoEliminar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmpleadoEliminar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleadoEliminar.Name = "btnEmpleadoEliminar";
            this.btnEmpleadoEliminar.Size = new System.Drawing.Size(181, 60);
            this.btnEmpleadoEliminar.TabIndex = 15;
            this.btnEmpleadoEliminar.Text = "Eliminar";
            this.btnEmpleadoEliminar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEmpleadoEliminar.UseAccentColor = false;
            this.btnEmpleadoEliminar.UseVisualStyleBackColor = true;
            this.btnEmpleadoEliminar.Click += new System.EventHandler(this.btnEmpleadoEliminar_Click);
            // 
            // btnEmpleadoGuardar
            // 
            this.btnEmpleadoGuardar.AutoSize = false;
            this.btnEmpleadoGuardar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEmpleadoGuardar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnEmpleadoGuardar.Depth = 0;
            this.btnEmpleadoGuardar.HighEmphasis = true;
            this.btnEmpleadoGuardar.Icon = null;
            this.btnEmpleadoGuardar.Location = new System.Drawing.Point(255, 246);
            this.btnEmpleadoGuardar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnEmpleadoGuardar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEmpleadoGuardar.Name = "btnEmpleadoGuardar";
            this.btnEmpleadoGuardar.Size = new System.Drawing.Size(181, 60);
            this.btnEmpleadoGuardar.TabIndex = 15;
            this.btnEmpleadoGuardar.Text = "Guardar";
            this.btnEmpleadoGuardar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnEmpleadoGuardar.UseAccentColor = false;
            this.btnEmpleadoGuardar.UseVisualStyleBackColor = true;
            this.btnEmpleadoGuardar.Click += new System.EventHandler(this.btnEmpleadoGuardar_Click);
            // 
            // txtDireccionSupli
            // 
            this.txtDireccionSupli.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txtDireccionSupli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionSupli.Depth = 0;
            this.txtDireccionSupli.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtDireccionSupli.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtDireccionSupli.Location = new System.Drawing.Point(588, 71);
            this.txtDireccionSupli.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtDireccionSupli.Name = "txtDireccionSupli";
            this.txtDireccionSupli.Size = new System.Drawing.Size(369, 86);
            this.txtDireccionSupli.TabIndex = 14;
            this.txtDireccionSupli.Text = "";
            // 
            // txtTelSupli
            // 
            this.txtTelSupli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelSupli.Depth = 0;
            this.txtTelSupli.DetectUrls = false;
            this.txtTelSupli.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTelSupli.LeadingIcon = null;
            this.txtTelSupli.Location = new System.Drawing.Point(116, 180);
            this.txtTelSupli.MaxLength = 60;
            this.txtTelSupli.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTelSupli.Multiline = false;
            this.txtTelSupli.Name = "txtTelSupli";
            this.txtTelSupli.Size = new System.Drawing.Size(274, 36);
            this.txtTelSupli.TabIndex = 12;
            this.txtTelSupli.Text = "";
            this.txtTelSupli.TrailingIcon = null;
            this.txtTelSupli.UseTallSize = false;
            // 
            // txtApellidoSupli
            // 
            this.txtApellidoSupli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtApellidoSupli.Depth = 0;
            this.txtApellidoSupli.DetectUrls = false;
            this.txtApellidoSupli.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtApellidoSupli.LeadingIcon = null;
            this.txtApellidoSupli.Location = new System.Drawing.Point(116, 124);
            this.txtApellidoSupli.MaxLength = 60;
            this.txtApellidoSupli.MouseState = MaterialSkin.MouseState.OUT;
            this.txtApellidoSupli.Multiline = false;
            this.txtApellidoSupli.Name = "txtApellidoSupli";
            this.txtApellidoSupli.Size = new System.Drawing.Size(274, 36);
            this.txtApellidoSupli.TabIndex = 12;
            this.txtApellidoSupli.Text = "";
            this.txtApellidoSupli.TrailingIcon = null;
            this.txtApellidoSupli.UseTallSize = false;
            // 
            // txtNombreSupli
            // 
            this.txtNombreSupli.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreSupli.Depth = 0;
            this.txtNombreSupli.DetectUrls = false;
            this.txtNombreSupli.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreSupli.LeadingIcon = null;
            this.txtNombreSupli.Location = new System.Drawing.Point(116, 71);
            this.txtNombreSupli.MaxLength = 60;
            this.txtNombreSupli.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreSupli.Multiline = false;
            this.txtNombreSupli.Name = "txtNombreSupli";
            this.txtNombreSupli.Size = new System.Drawing.Size(274, 36);
            this.txtNombreSupli.TabIndex = 13;
            this.txtNombreSupli.Text = "";
            this.txtNombreSupli.TrailingIcon = null;
            this.txtNombreSupli.UseTallSize = false;
            // 
            // materialLabel14
            // 
            this.materialLabel14.AutoSize = true;
            this.materialLabel14.Depth = 0;
            this.materialLabel14.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel14.Location = new System.Drawing.Point(495, 85);
            this.materialLabel14.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel14.Name = "materialLabel14";
            this.materialLabel14.Size = new System.Drawing.Size(67, 19);
            this.materialLabel14.TabIndex = 9;
            this.materialLabel14.Text = "Direccion";
            // 
            // materialLabel17
            // 
            this.materialLabel17.AutoSize = true;
            this.materialLabel17.Depth = 0;
            this.materialLabel17.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel17.Location = new System.Drawing.Point(29, 197);
            this.materialLabel17.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel17.Name = "materialLabel17";
            this.materialLabel17.Size = new System.Drawing.Size(64, 19);
            this.materialLabel17.TabIndex = 10;
            this.materialLabel17.Text = "Telefono";
            // 
            // materialLabel15
            // 
            this.materialLabel15.AutoSize = true;
            this.materialLabel15.Depth = 0;
            this.materialLabel15.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel15.Location = new System.Drawing.Point(29, 141);
            this.materialLabel15.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel15.Name = "materialLabel15";
            this.materialLabel15.Size = new System.Drawing.Size(58, 19);
            this.materialLabel15.TabIndex = 10;
            this.materialLabel15.Text = "Apellido";
            // 
            // materialLabel16
            // 
            this.materialLabel16.AutoSize = true;
            this.materialLabel16.Depth = 0;
            this.materialLabel16.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel16.Location = new System.Drawing.Point(30, 88);
            this.materialLabel16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel16.Name = "materialLabel16";
            this.materialLabel16.Size = new System.Drawing.Size(57, 19);
            this.materialLabel16.TabIndex = 11;
            this.materialLabel16.Text = "Nombre";
            // 
            // dataGridSuplidor
            // 
            this.dataGridSuplidor.AllowUserToAddRows = false;
            this.dataGridSuplidor.AllowUserToDeleteRows = false;
            dataGridViewCellStyle278.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridSuplidor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle278;
            this.dataGridSuplidor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSuplidor.BackgroundColor = System.Drawing.Color.White;
            this.dataGridSuplidor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridSuplidor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle279.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle279.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle279.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle279.ForeColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle279.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle279.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle279.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridSuplidor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle279;
            this.dataGridSuplidor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle280.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle280.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle280.Font = new System.Drawing.Font("Lato", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle280.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle280.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle280.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle280.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridSuplidor.DefaultCellStyle = dataGridViewCellStyle280;
            this.dataGridSuplidor.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridSuplidor.DoubleBuffered = true;
            this.dataGridSuplidor.EnableHeadersVisualStyles = false;
            this.dataGridSuplidor.HeaderBgColor = System.Drawing.Color.White;
            this.dataGridSuplidor.HeaderForeColor = System.Drawing.Color.SeaGreen;
            this.dataGridSuplidor.Location = new System.Drawing.Point(0, 351);
            this.dataGridSuplidor.MultiSelect = false;
            this.dataGridSuplidor.Name = "dataGridSuplidor";
            this.dataGridSuplidor.ReadOnly = true;
            this.dataGridSuplidor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridSuplidor.RowHeadersVisible = false;
            this.dataGridSuplidor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridSuplidor.Size = new System.Drawing.Size(1137, 235);
            this.dataGridSuplidor.TabIndex = 8;
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.FontType = MaterialSkin.MaterialSkinManager.fontType.H5;
            this.materialLabel13.Location = new System.Drawing.Point(33, 18);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(286, 29);
            this.materialLabel13.TabIndex = 0;
            this.materialLabel13.Text = "Registro de nuevo suplidor";
            // 
            // Creadores
            // 
            this.Creadores.ImageKey = "(ninguno)";
            this.Creadores.Location = new System.Drawing.Point(4, 22);
            this.Creadores.Name = "Creadores";
            this.Creadores.Size = new System.Drawing.Size(1137, 586);
            this.Creadores.TabIndex = 3;
            this.Creadores.Text = "Creadores";
            this.Creadores.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 679);
            this.Controls.Add(this.TabsContent);
            this.DrawerShowIconsWhenHidden = true;
            this.DrawerTabControl = this.TabsContent;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Queso Camilo";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.TabsContent.ResumeLayout(false);
            this.Inicio.ResumeLayout(false);
            this.Inicio.PerformLayout();
            this.Empleado.ResumeLayout(false);
            this.Empleado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.Entrada.ResumeLayout(false);
            this.Entrada.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridEntradasDELeche)).EndInit();
            this.suplidor.ResumeLayout(false);
            this.suplidor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSuplidor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl TabsContent;
        private System.Windows.Forms.TabPage Empleado;
        private System.Windows.Forms.TabPage Entrada;
        private System.Windows.Forms.TabPage suplidor;
        private System.Windows.Forms.TabPage Creadores;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private MaterialSkin.Controls.MaterialButton btnGuardar;
        private System.Windows.Forms.TabPage Inicio;
        private MaterialSkin.Controls.MaterialTextBox txtDepartamento;
        private MaterialSkin.Controls.MaterialTextBox txtDireccion;
        private MaterialSkin.Controls.MaterialTextBox txtNombre;
        private MaterialSkin.Controls.MaterialButton btnEditar;
        private MaterialSkin.Controls.MaterialButton btnEliminar;
        private MaterialSkin.Controls.MaterialRadioButton radioFemenino;
        private MaterialSkin.Controls.MaterialRadioButton radioMasculino;
        private MaterialSkin.Controls.MaterialComboBox comboPuesto;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialTextBox txtApellidoSupli;
        private MaterialSkin.Controls.MaterialTextBox txtNombreSupli;
        private MaterialSkin.Controls.MaterialLabel materialLabel14;
        private MaterialSkin.Controls.MaterialLabel materialLabel15;
        private MaterialSkin.Controls.MaterialLabel materialLabel16;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridSuplidor;
        private MaterialSkin.Controls.MaterialMultiLineTextBox txtDireccionSupli;
        private MaterialSkin.Controls.MaterialButton btnEmpleadoEditar;
        private MaterialSkin.Controls.MaterialButton btnEmpleadoEliminar;
        private MaterialSkin.Controls.MaterialButton btnEmpleadoGuardar;
        private MaterialSkin.Controls.MaterialTextBox txtTelSupli;
        private MaterialSkin.Controls.MaterialLabel materialLabel17;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridEntradasDELeche;
        private MaterialSkin.Controls.MaterialTextBox txtCantidadEntrada;
        private MaterialSkin.Controls.MaterialLabel materialLabel22;
        private MaterialSkin.Controls.MaterialLabel materialLabel21;
        private MaterialSkin.Controls.MaterialLabel materialLabel20;
        private MaterialSkin.Controls.MaterialLabel materialLabel19;
        private MaterialSkin.Controls.MaterialLabel materialLabel18;
        private MaterialSkin.Controls.MaterialComboBox comboEstado;
        private MaterialSkin.Controls.MaterialComboBox comboRecolector;
        private MaterialSkin.Controls.MaterialComboBox ComboSuplodires;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel23;
        private Bunifu.Framework.UI.BunifuDatepicker txtDate;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGrid;
        private MaterialSkin.Controls.MaterialButton btnEliminarEntradaDeLeche;
        private MaterialSkin.Controls.MaterialButton btnEditarEntrada;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
    }
}

