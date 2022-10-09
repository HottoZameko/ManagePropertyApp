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
    public partial class frmSuburb : Form
    {
        public frmSuburb()
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

        private void frmSuburb_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;

            cmbCity.DataSource = bll.GetCities();
            cmbCity.DisplayMember = "CityDescription";
            cmbCity.ValueMember = "CityID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            bool validate = false;

            Suburbs suburbs = new Suburbs();


            if (string.IsNullOrEmpty(txtDescr.Text))
            {
                errSuburb.SetError(txtDescr, "Enter description");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtCode.Text))
            {
                errSuburb.SetError(txtCode, "Enter a postal code");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                suburbs.SurbubDescription = txtDescr.Text;
                suburbs.PostalCode = int.Parse(txtCode.Text);
                suburbs.CityID = int.Parse(cmbCity.SelectedValue.ToString());

                int x = bll.InsertSuburbs(suburbs);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added!");
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvSuburb.DataSource = bll.GetSuburns();
        }
    }
}
