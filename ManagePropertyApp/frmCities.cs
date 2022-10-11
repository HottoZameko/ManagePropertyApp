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
    public partial class frmCities : Form
    {
        public frmCities()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void btnMenu_Click(object sender, EventArgs e)
        {
            string UserLabel = "Admin";
            Form1 form = new Form1();
            form.User = UserLabel;
            this.Hide();
            form.Show();
        }

        private void frmCities_Load(object sender, EventArgs e)
        {
            

            cmbProvince.DataSource = bll.GetProvinces();
            cmbProvince.DisplayMember = "Description";
            cmbProvince.ValueMember = "ProvinceID";

            txtID.Enabled = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;

            Cities cities = new Cities();


            if (string.IsNullOrEmpty(txtDescr.Text))
            {
                errCity.SetError(txtDescr, "Enter a City");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                cities.CityDescr = txtDescr.Text;
                cities.ProvinceID = int.Parse(cmbProvince.SelectedValue.ToString());

                int x = bll.InsertCities(cities);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added!");
                    txtDescr.Clear();
                    errCity.Clear();
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvProvince.DataSource = bll.GetCities();
        }
    }
}
