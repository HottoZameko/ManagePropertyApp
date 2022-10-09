using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace ManagePropertyApp
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (txtRole.Text.ToUpper() == "ADMIN")
            {
                DataTable dt = bll.AdminLogin(txtEmail.Text, txtPassword.Text);

                if (dt.Rows.Count > 0)
                {
                    Form1 form = new Form1();
                    form.User = txtRole.Text;
                    form.Show();
                    this.Hide();
                    
                }
                else
                    lblInvalid.Visible = true;
            }

            if (txtRole.Text.ToUpper() == "AGENT")
            {
                DataTable dt = bll.AgentLogin(txtEmail.Text, txtPassword.Text);

                if (dt.Rows.Count > 0)
                {
                    Form1 form = new Form1();
                    form.User = txtRole.Text;
                    form.Show();
                    this.Hide();
                }
                else
                    lblInvalid.Visible = true;
            
            }
            if (txtRole.Text.ToUpper() == "TENANT")
            {
                DataTable dt = bll.TenantLogin(txtEmail.Text, txtPassword.Text);

                if (dt.Rows.Count > 0)
                {
                    Form1 form = new Form1();
                    form.User = txtRole.Text;
                    form.Show();
                    this.Hide();
                }
                else
                    lblInvalid.Visible = true;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
