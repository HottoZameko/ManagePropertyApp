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
    public partial class frmPropertyAgent : Form
    {
        public frmPropertyAgent()
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

        private void frmPropertyAgent_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;

            cmbAgent.DataSource = bll.GetAgent();
            cmbAgent.DisplayMember = "Name";
            cmbAgent.ValueMember = "AgentID";

            cmbProperty.DataSource = bll.GetProperties();
            cmbProperty.DisplayMember = "Description";
            cmbProperty.ValueMember = "PropertyID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            PropertyAgent property = new PropertyAgent();

            property.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
            property.AgentID = int.Parse(cmbAgent.SelectedValue.ToString());
            property.Date = dtpDate.Value.ToString();

            int x = bll.InsertPropertyAgent(property);

            if (x > 0)
            {
                MessageBox.Show(x + "Added.");

            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvPropertyAgent.DataSource = bll.GetPropertyAgent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                PropertyAgent property = new PropertyAgent();

                property.PropertyAgentID = int.Parse(txtID.Text);

                property.PropertyID = int.Parse(cmbProperty.SelectedValue.ToString());
                property.AgentID = int.Parse(cmbProperty.SelectedValue.ToString());
                property.Date = dtpDate.Value.ToString();

                int x = bll.UpdatePropertyAgent(property);

                if(x > 0)
                {
                    MessageBox.Show(x + " Updated");
                    txtID.Clear();
                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Choose a column you want to Update");
            }
        }

        private void dgvPropertyAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPropertyAgent.SelectedRows.Count > 0)
            {
                txtID.Text = dgvPropertyAgent.SelectedRows[0].Cells["PropertyAgentID"].Value.ToString();
                cmbProperty.Text = dgvPropertyAgent.SelectedRows[0].Cells["Description"].Value.ToString();
                cmbAgent.Text = dgvPropertyAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                dtpDate.Text = dgvPropertyAgent.SelectedRows[0].Cells["Date"].Value.ToString();
            }
        }
    }
}
