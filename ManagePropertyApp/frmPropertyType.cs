using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DAL;

namespace ManagePropertyApp
{
    public partial class frmPropertyType : Form
    {
        public frmPropertyType()
        {
            InitializeComponent();
        }


        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void frmPropertyType_Load(object sender, EventArgs e)
        {
            txtTypeID.Enabled = false;
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string UserLabel = "Admin";
            Form1 form = new Form1();
            form.User = UserLabel;
            this.Hide();
            form.Show();
          
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool Validate = false;

            PropertyTypes types = new PropertyTypes();

            if (string.IsNullOrEmpty(txtTypeDescr.Text))
            {
                errTypes.SetError(txtTypeDescr, "Enter a description.");
                Validate = false;
            }
            else
                Validate = true;

            if (Validate)
            {
                types.PropertyTypeDescr = txtTypeDescr.Text;


                int x = bll.InsertPropertyTypes(types);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added!");
                   
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvType.DataSource = bll.GetPropertyTypes();
        }
    }
}
 