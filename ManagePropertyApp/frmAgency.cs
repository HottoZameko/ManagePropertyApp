using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using DAL;
using BLL;

namespace ManagePropertyApp
{
    public partial class frmAgency : Form
    {
        public frmAgency()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnMenu_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.Show();
        }

        private void frmAgency_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;
            cmbSuburb.DataSource = bll.GetSuburns();
            cmbSuburb.DisplayMember = "SurbubDescription";
            cmbSuburb.ValueMember = "SurbubID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Agencies agencies = new Agencies();


            if (string.IsNullOrEmpty(txtName.Text))
            {
                errAgency.SetError(txtName, "Enter Name");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {

                agencies.AgencyName = txtName.Text;
                agencies.SurbubID = int.Parse(cmbSuburb.SelectedValue.ToString());

                int x = bll.InsertAgencies(agencies);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added!");
                    errAgency.Clear();
                    txtName.Clear();
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvAgency.DataSource = bll.GetAgencies();
        }
    }
}
