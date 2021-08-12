using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;
using CapaModeloNegocio;
using CapaEntidades;

namespace Presentacion
{
    public partial class frmLogin : MaterialForm
    {
        public frmLogin()
        {
            InitializeComponent();
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue400, Primary.Blue500, Primary.LightBlue100, Accent.LightBlue200,
                TextShade.WHITE);
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
        }

        private void CheckContra_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.isPassword = false;

            if(CheckContra.Checked is false)
            {
                txtPassword.isPassword = true;
            }
        }
        private void MessErr(string meessage)
        {
            LabelError.Text = "          " + meessage;
            LabelError.Visible = true;
        }
        private void ClckBtnLogin(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUserName.Text))
                MessErr("Ingrese el usuario");
            if (string.IsNullOrEmpty(txtPassword.Text))
                MessErr("Ingrese la contraseña");

            else
            {
                N_Usuario usuario = new N_Usuario();
                E_Usuario e_Usuario = new E_Usuario
                {
                    Loginname = txtUserName.Text,
                    Password = txtPassword.Text
                };

                var ValidateUser = usuario.LoginVales(e_Usuario);

                if(ValidateUser == true)
                {
                    frmPrincipal frmPrincipal = new frmPrincipal();
                    frmPrincipal.Show();
                    this.Hide();
                }
                else
                {
                    MaterialMessageBox.Show("Usuario o contraseña incorrectos \n Por favor intentalo de nuevo");
                    txtPassword.Text = "";
                    txtUserName.Text = "";
                    txtUserName.Focus();
                }
            }
        }
    }
}
