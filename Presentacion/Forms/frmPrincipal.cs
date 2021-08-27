using System;
using System.Windows.Forms;
using CapaModeloNegocio;
using MaterialSkin;
using MaterialSkin.Controls;
using CapaEntidades;
using CapaEntidades.Cannom;
using Presentacion.Forms;
using Presentacion.Forms.FormReport;

namespace Presentacion
{
    public partial class frmPrincipal : MaterialForm
    {
        private string IdEmpleado;
        private string Idsuplidor;
        private string IdEntradadeleche;
        private string IdProducto;
        private string IdUsuario;

        private bool Editar = false;
        private bool EditarSulidor = false;
        private bool EditarEntrada = false;
        private bool EditarProducto = false;

        private bool EditarUsuario = false;
        public frmPrincipal()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme
                (Primary.Blue400, Primary.Blue500,Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE);
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            Refrescar();
            PuestosValues();
            RefrescarSuplidor();
            GetombreUsuarioInicio();
            RefrescarEntrdas();
            ValoresCombosTabEntrada();
            RefreshValoresTabProducto();
            ValueComboRoles();
            RefrescarUsuarios();
            DetectedTypeUserByRole();
            DatosVentas();
        }
        #region Login
        private void GetombreUsuarioInicio()
        {
            lblNombreUser.Text = UserLoginChache.Nombre + " " + UserLoginChache.Apellido;
            if (UserLoginChache.Role == 1)
                lblRole.Text = "Administrador";
        }
        private void DetectedTypeUserByRole()
        {
            if (UserLoginChache.Role == RolesUsers.Comprador)
            {
                TabsContent.TabPages.Remove(Usuarios);
                TabsContent.TabPages.Remove(Inicio);
                TabsContent.TabPages.Remove(Empleado);
                TabsContent.TabPages.Remove(Ventas);
                TabsContent.TabPages.Remove(Productos);

            }
            if (UserLoginChache.Role == RolesUsers.Administrador)
            {
                MaterialMessageBox.Show("Usuario Admininitrador", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (UserLoginChache.Role == RolesUsers.Vendedor)
            {
                TabsContent.TabPages.Remove(Usuarios);
                TabsContent.TabPages.Remove(Inicio);
                TabsContent.TabPages.Remove(Empleado);
                TabsContent.TabPages.Remove(Entrada);
                TabsContent.TabPages.Remove(suplidor);
            }
        }
        #endregion

        #region Tab de Empleado
        private void Refrescar()
        {
            N_Empleado NegocioEmpleado = new N_Empleado();
            DataGrid.DataSource = NegocioEmpleado.ListaEmpleados();
            ValoresCombosTabEntrada();
        }
        private void PuestosValues()
        {
            N_Puestos puestos = new N_Puestos();
            comboPuesto.DataSource = puestos.ListaPuestos();
            comboPuesto.DisplayMember = "nombrePuesto";
            comboPuesto.ValueMember = "IdPuestos";
        }
        private void LimpiarCampos()
        {
            txtDepartamento.Clear();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            radioMasculino.Checked = false;
            radioFemenino.Checked = false;
        }
        private void BuscarEmpleado(string valor)
        {
            N_Empleado n_Empleado = new N_Empleado();
            DataGrid.DataSource = n_Empleado.BuscarempeladosPorNombre(valor);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Editar == false)
            {
                if (
                    string.IsNullOrEmpty(txtNombre.Text) ||
                    string.IsNullOrEmpty(txtDireccion.Text) ||
                    string.IsNullOrEmpty(txtDepartamento.Text)||
                    string.IsNullOrEmpty(txtApellido.Text))
                {
                    MaterialMessageBox.Show("Hay campos vacios debe llenarlos antes de guradar");
                }
                else
                {
                    int sexo = 0;
                    if (radioFemenino.Checked)
                    {
                        sexo = 2;
                    }
                    if (radioMasculino.Checked)
                    {
                        sexo = 1;
                    }
                    if (sexo == 0)
                    {
                        MaterialMessageBox.Show("Debe seleccionar un sexo");
                    }
                    else
                    {
                        E_Empleado empleado = new E_Empleado
                        {
                            Nombre = txtNombre.Text.Trim(),
                            Direccion = txtDireccion.Text.Trim(),
                            Departamento = txtDepartamento.Text.Trim(),
                            Sexo = sexo,
                            Puesto = Convert.ToInt32(comboPuesto.SelectedValue),
                            Apellido = txtApellido.Text.Trim()
                         
                        };
                        N_Empleado n_Empleado = new N_Empleado();
                        n_Empleado.InsertarEmpleado(empleado);
                        Refrescar();
                        LimpiarCampos();
                    }
                }
            }
            if (Editar == true)
            {
                int sexo = 0;
                if (radioFemenino.Checked)
                {
                    sexo = 2;
                }
                if (radioMasculino.Checked)
                {
                    sexo = 1;
                }
                if (sexo == 0)
                {
                    MaterialMessageBox.Show("Debe seleccionar un sexo");
                }
                else
                {
                    E_Empleado empleado = new E_Empleado
                    {
                        Idempleado = int.Parse(DataGrid.Rows[DataGrid.CurrentRow.Index].Cells[0].Value.ToString()),
                        Nombre = txtNombre.Text.Trim(),
                        Direccion = txtDireccion.Text.Trim(),
                        Departamento = txtDepartamento.Text.Trim(),
                        Sexo = sexo,
                        Puesto = Convert.ToInt32(comboPuesto.SelectedValue),
                        Apellido = txtApellido.Text.Trim()
                    };
                    N_Empleado n_Empleado = new N_Empleado();
                    n_Empleado.ActualizarEmpleado(empleado);
                    LimpiarCampos();
                    RefrescarEntrdas();
                    Editar = false;
                }
                Refrescar();
            }
        }
        private void materialButton13_Click(object sender, EventArgs e)
        {
            ReporteVEntas reporteVEntas = new ReporteVEntas();

            reporteVEntas.Show();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(DataGrid.SelectedRows.Count > 0)
            {
                E_Empleado empleado = new E_Empleado
                {
                    Idempleado = Convert.ToInt32(DataGrid.Rows[DataGrid.CurrentRow.Index].Cells[0].Value.ToString())
                };
                N_Empleado empleado1 = new N_Empleado();
                empleado1.EliminarEmpleado(empleado);
            }
            if (DataGrid.Rows.Count == 0)
            {
                MaterialMessageBox.Show("No hay campos para eliminar");
            }
            Refrescar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Editar = true;
            if (DataGrid.Rows.Count == 0)
            {
                MaterialMessageBox.Show("No hay datos por lo que no puedes editar nada");
            }
            if(DataGrid.SelectedRows.Count > 0)
            {
                IdEmpleado = DataGrid.CurrentRow.Cells[0].Value.ToString();
                txtNombre.Text = DataGrid.CurrentRow.Cells[1].Value.ToString();
                txtApellido.Text = DataGrid.CurrentRow.Cells[2].Value.ToString();
                txtDireccion.Text = DataGrid.CurrentRow.Cells[3].Value.ToString();
                txtDepartamento.Text = DataGrid.CurrentRow.Cells[6].Value.ToString();

                string sexo = DataGrid.CurrentRow.Cells[4].Value.ToString();
                if(sexo == "Femenino")
                {
                    radioFemenino.Checked = true;
                }
                else
                {
                    radioMasculino.Checked = true;
                }
                MaterialMessageBox.Show("Esta editando la fila seleccionada");
            }
        }
        #endregion

        #region Tab de suplidor

        private void RefrescarSuplidor()
        {
            N_Suplidor suplidor = new N_Suplidor();

            dataGridSuplidor.DataSource = suplidor.ListaSuplidores();
        }
        private void BuscarSuplidor(string valor)
        {
            N_Suplidor suplidor = new N_Suplidor();
            dataGridSuplidor.DataSource = dataGridSuplidor.DataSource = suplidor.BuscarSuplidor(valor);

        }
        private void tetBuscarSuplidor_TextChanged(object sender, EventArgs e)
        {
            BuscarSuplidor(tetBuscarSuplidor.Text);
        }
        private void btnEmpleadoGuardar_Click(object sender, EventArgs e)
        {
            if (EditarSulidor == false)
            {
                if (string.IsNullOrEmpty(txtApellidoSupli.Text)
                    || string.IsNullOrEmpty(txtDireccionSupli.Text)
                    || string.IsNullOrEmpty(txtNombreSupli.Text)
                    || string.IsNullOrEmpty(txtTelSupli.Text))
                {
                    MaterialMessageBox.Show("Hay campos vacios debe llenarlos para guardar");
                }
                else
                {
                    E_Suplidor suplidor = new E_Suplidor
                    {
                        Nombre = txtNombreSupli.Text.Trim(),
                        Apellido = txtApellidoSupli.Text.Trim(),
                        Direccion = txtDireccionSupli.Text.Trim(),
                        NumeroTel = txtTelSupli.Text.Trim()
                    };
                    N_Suplidor suplidor1 = new N_Suplidor();
                    suplidor1.InsertarSuplidor(suplidor);
                    RefrescarSuplidor();
                    RefrescarEntrdas();
                    ValoresCombosTabEntrada();
                }
                
            }
            if(EditarSulidor == true)
            {
                if (string.IsNullOrEmpty(txtApellidoSupli.Text)
                    || string.IsNullOrEmpty(txtDireccionSupli.Text)
                    || string.IsNullOrEmpty(txtNombreSupli.Text)
                    || string.IsNullOrEmpty(txtTelSupli.Text))
                {
                    MaterialMessageBox.Show("Hay campos vacios debe llenarlos para guardar");
                }
                else
                {
                    E_Suplidor suplidor = new E_Suplidor
                    {
                        Idsuplidor = Convert.ToInt32(dataGridSuplidor.Rows[dataGridSuplidor.CurrentRow.Index].Cells[0].Value.ToString()),
                        Nombre = txtNombreSupli.Text.Trim(),
                        Apellido = txtApellidoSupli.Text.Trim(),
                        Direccion = txtDireccionSupli.Text.Trim(),
                        NumeroTel = txtTelSupli.Text.Trim()
                    };
                    N_Suplidor suplidor1 = new N_Suplidor();
                    suplidor1.ActualizarSuplidor(suplidor);
                    RefrescarSuplidor();
                    RefrescarEntrdas();
                }
            }
        }

        private void btnEmpleadoEditar_Click(object sender, EventArgs e)
        {
            if(dataGridSuplidor.Rows.Count == 0)
            {
                MaterialMessageBox.Show("No hay registros por editar");
            }
            else
            {
                EditarSulidor = true;
                Idsuplidor = dataGridSuplidor.CurrentRow.Cells[0].Value.ToString();

                txtNombreSupli.Text = dataGridSuplidor.CurrentRow.Cells[1].Value.ToString();
                txtApellidoSupli.Text = dataGridSuplidor.CurrentRow.Cells[2].Value.ToString();
                txtDireccionSupli.Text = dataGridSuplidor.CurrentRow.Cells[3].Value.ToString();
                txtTelSupli.Text = dataGridSuplidor.CurrentRow.Cells[4].Value.ToString();
            }
        }

        private void btnEmpleadoEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridSuplidor.SelectedRows.Count > 0)
            {
                E_Suplidor suplidor = new E_Suplidor()
                {
                    Idsuplidor = Convert.ToInt32(dataGridSuplidor.CurrentRow.Cells[0].Value.ToString())
                };
                N_Suplidor NSuplidor = new N_Suplidor();
                NSuplidor.EliminarSuplidor(suplidor);
            }
            RefrescarSuplidor();
        }
        #endregion

        #region Tab Entrada

        private void RefrescarEntrdas()
        {
            N_EntradaDeLeche entradaDeLeche = new N_EntradaDeLeche();

            DataGridEntradasDELeche.DataSource = entradaDeLeche.ListaEntradasDeLeche();
        }
        private void BuscarEntradasDeLecheBySuplidor(string valor)
        {
            N_EntradaDeLeche entradaDeLeche = new N_EntradaDeLeche();
            DataGridEntradasDELeche.DataSource = entradaDeLeche.BuscarEntradasPorSuplidor(valor);

        }
        private void tetBuscarEntrada_TextChanged(object sender, EventArgs e)
        {
            BuscarEntradasDeLecheBySuplidor(tetBuscarEntrada.Text);
        }

        private void BuscarFactura( string valor)
        {
            N_InsertOrdenElementos Orden = new N_InsertOrdenElementos();
            DataGridListadoVentas.DataSource = Orden.BuscarVentasPorCodigo(valor);
        }
        public void DatosVentas()
        {
            N_InsertOrdenElementos Orden = new N_InsertOrdenElementos();

            DataGridListadoVentas.DataSource = Orden.ListadoVentas();
        }
        private void ValoresCombosTabEntrada()
        {
            N_Empleado empleado = new N_Empleado();
            N_Suplidor suplidor = new N_Suplidor();
            N_EstadosDeLeche estadosDeLeche = new N_EstadosDeLeche();

            ComboSuplodires.DataSource = suplidor.ValoresComboboxSuplido();
            comboRecolector.DataSource = empleado.ValoresComboRecolector();
            comboEstado.DataSource = estadosDeLeche.ListaEstados();

            ComboSuplodires.DisplayMember = "Nombres";
            ComboSuplodires.ValueMember = "IdSuplidor";
            comboRecolector.DisplayMember = "Nombre";
            comboRecolector.ValueMember = "IdEmpleado";
            comboEstado.DisplayMember = "Descripcion";
            comboEstado.ValueMember = "IdEstado";
        }
        private void materialTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (EditarEntrada == false)
            {
                if (string.IsNullOrEmpty(comboRecolector.Text)
                    || string.IsNullOrEmpty(comboEstado.Text)
                    || string.IsNullOrEmpty(txtCantidadEntrada.Text)
                    || string.IsNullOrEmpty(ComboSuplodires.Text))
                {
                    MaterialMessageBox.Show("Hay campos vacios debe llnearlos todos");
                }
                else
                {
                    E_EntradaDeLeche entradaDeLeche1 = new E_EntradaDeLeche
                    {
                        Idsuplidor = Convert.ToInt32(ComboSuplodires.SelectedValue),
                        Idestado = Convert.ToInt32(comboEstado.SelectedValue),
                        Fechaentrada = txtDate.Value.ToString("yyyy/MM/dd"),
                        Recolector = Convert.ToInt32(comboRecolector.SelectedValue),
                        Cantidadbotellas = Convert.ToDecimal(txtCantidadEntrada.Text),
                        PrecioPorbotella = Convert.ToInt32(txtPrecioBotella.Text)
                    };
                    N_EntradaDeLeche entradaDeLeche = new N_EntradaDeLeche();
                    entradaDeLeche.InsertarEntrada(entradaDeLeche1);

                    Refrescar();
                    RefrescarEntrdas();
                }
            }
            if(EditarEntrada == true)
            {
                if (string.IsNullOrEmpty(txtCantidadEntrada.Text))
                {
                    MaterialMessageBox.Show("Debe llenar el campo de cantidad");
                }
                else
                {
                    E_EntradaDeLeche entradaDeLeche1 = new E_EntradaDeLeche
                    {
                        Identrada = Convert.ToInt32(DataGridEntradasDELeche.Rows[DataGridEntradasDELeche.CurrentRow.Index].Cells[0].Value.ToString()),
                        Idsuplidor = Convert.ToInt32(ComboSuplodires.SelectedValue),
                        Idestado = Convert.ToInt32(comboEstado.SelectedValue),
                        Fechaentrada = txtDate.Value.ToString("yyyy/MM/dd"),
                        Recolector = Convert.ToInt32(comboRecolector.SelectedValue),
                        Cantidadbotellas = Convert.ToDecimal(txtCantidadEntrada.Text),
                        PrecioPorbotella = Convert.ToDecimal(txtPrecioBotella.Text)
                    };
                    N_EntradaDeLeche entradaDeLeche = new N_EntradaDeLeche();
                    entradaDeLeche.EditarEntradaDeLeche(entradaDeLeche1);
                    Refrescar();
                    RefrescarEntrdas();
                    MaterialMessageBox.Show("Editado correctamente");
                    EditarEntrada = false;
                }
            }
        }

        private void btnEliminarEntradaDeLeche_Click(object sender, EventArgs e)
        {
            if(DataGridEntradasDELeche.SelectedRows.Count > 0)
            {
                E_EntradaDeLeche e_Entrada = new E_EntradaDeLeche()
                {
                    Identrada = Convert.ToInt32(DataGridEntradasDELeche.CurrentRow.Cells[0].Value.ToString())
                };
                N_EntradaDeLeche n_EntradaDeLeche = new N_EntradaDeLeche();
                n_EntradaDeLeche.EliminsrEntrada(e_Entrada);
                RefrescarEntrdas();
                Refrescar();
            }
        }
        private void btnEditarEntrada_Click(object sender, EventArgs e)
        {
            if(DataGridEntradasDELeche.SelectedRows.Count == 0)
            {
                MaterialMessageBox.Show("No hay datos para eliminar");
            }
            if (DataGridEntradasDELeche.SelectedRows.Count > 0)
            {
                EditarEntrada = true;
                IdEntradadeleche = DataGridEntradasDELeche.CurrentRow.Cells[0].Value.ToString();
                ComboSuplodires.DisplayMember = DataGridEntradasDELeche.CurrentRow.Cells[1].Value.ToString();
                comboRecolector.DisplayMember = DataGridEntradasDELeche.CurrentRow.Cells[2].Value.ToString();
                txtCantidadEntrada.Text = DataGridEntradasDELeche.CurrentRow.Cells[3].Value.ToString();
                txtPrecioBotella.Text = DataGridEntradasDELeche.CurrentRow.Cells[4].Value.ToString();
                comboEstado.DisplayMember = DataGridEntradasDELeche.CurrentRow.Cells[5].Value.ToString();
                MaterialMessageBox.Show("Esta en modo editar de la fila selecionada");
            }
        }
        #endregion

        #region TabProducto

        private void RefreshValoresTabProducto()
        {
            N_Producto producto = new N_Producto();

            DataGridProductos.DataSource = producto.ListadoProductos();
        }
        private void BuscarProducto(string producto)
        {
            N_Producto Nproducto = new N_Producto();
            DataGridProductos.DataSource = Nproducto.BuscarProductoPorNombre(producto);
        }

        private void materialButton11_Click(object sender, EventArgs e)
        {
            if (EditarProducto == false)
            {
                if (string.IsNullOrEmpty(txtProductoDescripcion.Text)
                    || string.IsNullOrEmpty(txtNombreProducto.Text)
                    || string.IsNullOrEmpty(txtProductoPrecio.Text))
                {
                    MaterialMessageBox.Show("Hay campos vacios debe llenarlos todos");
                }
                else
                {
                    N_Producto n_Producto = new N_Producto();
                    E_Producto Eproducto = new E_Producto
                    {
                        Nombre = txtNombreProducto.Text.Trim(),
                        Descipcion = txtProductoDescripcion.Text.Trim(),
                        Precio = decimal.Parse(txtProductoPrecio.Text.Trim())
                    };
                    n_Producto.InsertarPorducto(Eproducto);

                    RefreshValoresTabProducto();
                    
                }
            }
            if(EditarProducto == true)
            {
                if (string.IsNullOrEmpty(txtProductoDescripcion.Text)
                   || string.IsNullOrEmpty(txtNombreProducto.Text)
                   || string.IsNullOrEmpty(txtProductoPrecio.Text))
                {
                    MaterialMessageBox.Show("Hay campos vacios debe llenarlos todos");
                }
                else
                {
                    N_Producto Producto = new N_Producto();
                    E_Producto Eproducto = new E_Producto
                    {
                        IdProducto = int.Parse(DataGridProductos.CurrentRow.Cells[0].Value.ToString()),
                        Nombre = txtNombreProducto.Text.Trim(),
                        Descipcion = txtProductoDescripcion.Text.Trim(),
                        Precio = decimal.Parse(txtProductoPrecio.Text.Trim())
                    };
                    Producto.ActualizarProducto(Eproducto);
                    RefreshValoresTabProducto();
                    EditarProducto = false;
                    MaterialMessageBox.Show("Editado correctamente");
                }
            }
        }


        private void BtnELiminarProducto_Click(object sender, EventArgs e)
        {
            if (DataGridProductos.SelectedRows.Count > 0)
            {
                E_Producto producto = new E_Producto()
                {
                    IdProducto = Convert.ToInt32(DataGridProductos.CurrentRow.Cells[0].Value.ToString())
                };
                N_Producto n_Producto = new N_Producto();
                n_Producto.EliminarProducto(producto);
                RefreshValoresTabProducto();
                Refrescar();
            }
        }


        private void btnEditarProducto_Click(object sender, EventArgs e)
        {
            EditarProducto = true;

            if (DataGridProductos.Rows.Count == 0)
            {
                MaterialMessageBox.Show("No hay datos por lo que no puedes editar nada");
            }
            if (DataGridProductos.SelectedRows.Count > 0)
            {
                IdProducto = DataGridProductos.CurrentRow.Cells[0].Value.ToString();
                txtNombreProducto.Text = DataGridProductos.CurrentRow.Cells[1].Value.ToString();
                txtProductoDescripcion.Text = DataGridProductos.CurrentRow.Cells[2].Value.ToString();
                txtProductoPrecio.Text = DataGridProductos.CurrentRow.Cells[3].Value.ToString();
                MaterialMessageBox.Show("Esta editando la fila seleccionada");
            }
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            BuscarProducto(txtBuscarProducto.Text);
        }

        private void txtBuscarEmpleado_TextChanged(object sender, EventArgs e)
        {
            BuscarEmpleado(txtBuscarEmpleado.Text);
        }
        #endregion

        #region TabUsuarios


        private void ValueComboRoles()
        {
            N_Usuario usuario = new N_Usuario();

            txtComboRole.DataSource = usuario.ValoresComboRoles();

            txtComboRole.DisplayMember = "RoleName";
            txtComboRole.ValueMember = "RoleId";
        }
        private void RefrescarUsuarios()
        {
            N_Usuario usuario = new N_Usuario();
            DatagridUsuarios.DataSource = usuario.ListaUsuario();
        }


        private void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            if(EditarUsuario == false) 
            {
                if (string.IsNullOrEmpty(txtUsuarioLogin.Text)
                    || string.IsNullOrEmpty(txtNombreUsuario.Text)
                    || string.IsNullOrEmpty(txtContrasenaUsuario.Text)
                    || string.IsNullOrEmpty(txtApellidoUsuario.Text))
                {
                    MaterialMessageBox.Show("No debe dejar campos vacios", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }

                else
                {
                    E_Usuario usuario = new E_Usuario
                    {
                        Firstname = txtNombreUsuario.Text.Trim(),
                        Lastname = txtApellidoUsuario.Text.Trim(),
                        Password = txtContrasenaUsuario.Text.Trim(),
                        RoleID = Convert.ToInt32(txtComboRole.SelectedValue),
                        Loginname = txtUsuarioLogin.Text.Trim()
                    };

                    N_Usuario n_Usuario = new N_Usuario();

                    n_Usuario.InsertarUsuario(usuario);

                    RefrescarUsuarios();
                    Refrescar();
                }
            }
            if(EditarUsuario == true)
            {
                E_Usuario usuario = new E_Usuario
                {
                    //Idempleado = int.Parse(DataGrid.Rows[DataGrid.CurrentRow.Index].Cells[0].Value.ToString()),

                    Iduruario = int.Parse(DatagridUsuarios.Rows[DatagridUsuarios.CurrentRow.Index].Cells[0].Value.ToString()),
                    Firstname = txtNombreUsuario.Text.Trim(),
                    Lastname = txtApellidoUsuario.Text.Trim(),
                    Password = txtContrasenaUsuario.Text.Trim(),
                    RoleID = Convert.ToInt32(txtComboRole.SelectedValue),
                    Loginname = txtUsuarioLogin.Text.Trim()
                };

                N_Usuario Usuario = new N_Usuario();

                Usuario.ActualizarUsuario(usuario);

                RefrescarUsuarios();
                EditarUsuario = false;
                MaterialMessageBox.Show("Editado correctamente");
            }
        }

        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            EditarUsuario = true;
            if (DatagridUsuarios.Rows.Count == 0)
            {
                MaterialMessageBox.Show("No hay datos por lo que no puedes editar nada");
            }
            if (DatagridUsuarios.SelectedRows.Count > 0)
            {
                IdUsuario = DatagridUsuarios.CurrentRow.Cells[0].Value.ToString();
                txtNombreUsuario.Text = DatagridUsuarios.CurrentRow.Cells[3].Value.ToString();
                txtUsuarioLogin.Text = DatagridUsuarios.CurrentRow.Cells[1].Value.ToString();
                txtContrasenaUsuario.Text = DatagridUsuarios.CurrentRow.Cells[2].Value.ToString();
                MaterialMessageBox.Show("Esta editando la fila seleccionada");

            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (DatagridUsuarios.SelectedRows.Count > 0)
            {
                if (MaterialMessageBox.Show("Esta seguro que quiere Eliminar este Usuario ", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    E_Usuario usuario = new E_Usuario
                    {
                        Iduruario = Convert.ToInt32(DatagridUsuarios.Rows[DatagridUsuarios.CurrentRow.Index].Cells[0].Value.ToString())
                    };
                    N_Usuario n_Usuario = new N_Usuario();
                    n_Usuario.EliminarUsuario(usuario);
                    RefrescarUsuarios();
                }
                RefrescarUsuarios();
            }
            if (DataGrid.Rows.Count == 0)
            {
                MaterialMessageBox.Show("No hay campos para eliminar");
            }
            RefrescarUsuarios();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            if (MaterialMessageBox.Show("Esta seguro que quiere cerrar sesion", "Advertencia",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #endregion

        #region TabVentas

        private void materialButton8_Click(object sender, EventArgs e)
        {
            frmveentass frmVentas = new frmveentass();
            frmVentas.ShowDialog();
        }

        #endregion

        private void txtBuscarFactura_TextChanged(object sender, EventArgs e)
        {
            BuscarFactura(txtBuscarFactura.Text);
        }

        private void materialButton15_Click(object sender, EventArgs e)
        {
            frmReportVentas frmReportVentas = new frmReportVentas();

            frmReportVentas.ShowDialog();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            frmReportEmpleados frmReportEmpleados = new frmReportEmpleados();

            frmReportEmpleados.ShowDialog();
        }

        private void materialButton16_Click(object sender, EventArgs e)
        {
            frmReportProducto frmReportProducto = new frmReportProducto();

            frmReportProducto.ShowDialog();
        }

        private void materialButton14_Click(object sender, EventArgs e)
        {
            frmReportSuplidores frmReportSuplidores = new frmReportSuplidores();
            frmReportSuplidores.ShowDialog();
        }
    }
}