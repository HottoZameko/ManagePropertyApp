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
    public partial class frmProvince : Form
    {
        public frmProvince()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void button3_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void frmProvince_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Provinces province = new Provinces();

            if (string.IsNullOrEmpty(txtDescription.Text))
            {
                errorProvince.SetError(txtDescription, "Enter a province!!");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                province.Description = txtDescription.Text;

                int x = bll.InsertProvince(province);
                if (x > 0)
                {
                    MessageBox.Show(x + " Added.");
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvProvince.DataSource = bll.GetProvinces();
        }
    }
}
