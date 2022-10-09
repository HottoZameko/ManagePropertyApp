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
    public partial class frmReports : Form
    {
        public frmReports()
        {
            InitializeComponent();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void frmReports_Load(object sender, EventArgs e)
        {
            cmbUser.Items.Add("Tenant");
            cmbUser.Items.Add("Admin");
            cmbUser.Items.Add("Agent");
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm = new Form1();
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.RentalsThatAreOver();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Price p = new Price();

            p.price = double.Parse(txtPrice.Text);

            dgvReports.DataSource = bll.GetPriceSearch(p);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.RentalsAndAgents();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.PropertiesAndTypes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.MaxAgent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            dgvReports.DataSource = bll.CityProvinceSuburb();
        }

        private void cmbUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbUser.SelectedItem.ToString() == "Admin")
            {
                dgvReports.DataSource = bll.GetAdmin();
            }
            else if (cmbUser.SelectedItem.ToString() == "Agent")
            {
                dgvReports.DataSource = bll.GetAgent();
            }
            else if (cmbUser.SelectedItem.ToString() == "Tenant")
            {
                dgvReports.DataSource = bll.GetTenant();
            }
        }
    }
}
