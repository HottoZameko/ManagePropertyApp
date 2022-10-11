using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagePropertyApp
{
    public partial class Form1 : Form
    {
        public static DataTable dt = null;
        public string User { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPropertyType_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "ADMIN")
            {
                frmPropertyType frm = new frmPropertyType();
                this.Hide();
                frm.Show();
            }

        }

        private void btnProperty_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "ADMIN" || lblUser.Text.ToUpper() == "AGENT")
            {
                frmProperty property = new frmProperty();
                this.Hide();
                property.Show();
            }
        }

        private void btnProvince_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "ADMIN")
            {
                frmProvince province = new frmProvince();
                this.Hide();
                province.Show();
            }
        }

        private void btnCity_Click(object sender, EventArgs e)
        {if (lblUser.Text.ToUpper() == "ADMIN")
            {
                frmCities cities = new frmCities();
                this.Hide();
                cities.Show();
            }
        }

        private void btnSuburb_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "ADMIN")
            {
                frmSuburb suburb = new frmSuburb();
                this.Hide();
                suburb.Show();
            }
        }

        private void btnAgency_Click(object sender, EventArgs e)
        {
            if(lblUser.Text.ToUpper() == "AGENT" || lblUser.Text.ToUpper() == "ADMIN")
            {
                frmAgency agency = new frmAgency();
                this.Hide();
                agency.Show();
            }
            
        }

        private void btnAgent_Click(object sender, EventArgs e)
        {
            if(lblUser.Text.ToUpper() == "AGENT")
            {
                frmAgent agent = new frmAgent();
                this.Hide();
                agent.Show();
            }
            
        }

        private void btnTenant_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "TENANT")
            {
                frmTenant tenant = new frmTenant();
                this.Hide();
                tenant.Show();
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "AGENT" || lblUser.Text.ToUpper() == "ADMIN")
            {
                frmPropertyAgent propertyAgent = new frmPropertyAgent();
                this.Hide();
                propertyAgent.Show();
            }
        }

        private void btnRental_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "TENANT")
            {
                frmRental rental = new frmRental();
                this.Hide();
                rental.Show();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "ADMIN")
            {
                frmReports frm = new frmReports();
                this.Hide();
                frm.Show();
            }
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            if (lblUser.Text.ToUpper() == "ADMIN")
            {
                frmAdmin admin = new frmAdmin();
                this.Hide();
                admin.Show();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadLabel();
        }
        public void LoadLabel()
        {
            lblUser.Text = User;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide();
        }
    }
}
