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
    public partial class frmAgent : Form
    {
        public frmAgent()
        {
            InitializeComponent();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            string UserLabel = "Agent";
            Form1 form = new Form1();
            form.User = UserLabel;
            this.Hide();
            form.Show();
        }

        BusinessLogicLayer bll = new BusinessLogicLayer();
        private void frmAgent_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Not-Available");

            cmbAgency.DataSource = bll.GetAgencies();
            cmbAgency.DisplayMember = "AgencyName";
            cmbAgency.ValueMember = "AgencyID";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool validate = false;
            Agent agent = new Agent();

            if (string.IsNullOrEmpty(txtName.Text))
            {
                errAgent.SetError(txtName, "Enter name.");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtSurname.Text))
            {
                errAgent.SetError(txtSurname, "Enter Surname!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtEmail.Text) || (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$")))
            {
                errAgent.SetError(txtEmail, "Enter a valid Email!");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPassword.Text) || (!Regex.IsMatch(txtPassword.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$")))
            {
                errAgent.SetError(txtPassword, "Your password Should be 8 characters long including: letters, special characters, numbers");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPhone.Text) || (!Regex.IsMatch(txtPhone.Text, @"^(\+27|0)[6-8][0-9]{8}$")))
            {
                errAgent.SetError(txtPhone, "Enter valid phone number!");
                validate = false;
            }
            else
                validate = true;

            if (validate)
            {
                agent.Name = txtName.Text;
                agent.Surname = txtSurname.Text;
                agent.Email = txtEmail.Text;
                agent.Password = txtPassword.Text;
                agent.Phone = int.Parse(txtPhone.Text);
                agent.Status = cmbStatus.SelectedItem.ToString();
                agent.AgencyID = int.Parse(cmbAgency.SelectedValue.ToString());

                int x = bll.InsertAgent(agent);

                if (x > 0)
                {
                    MessageBox.Show(x + " Added.");

                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvAgent.DataSource = bll.GetAgent();
            cmbAgency.DataSource = bll.GetAgencies();
            cmbAgency.DisplayMember = "AgencyName";
            cmbAgency.ValueMember = "AgencyID";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Agent agent = new Agent();

                agent.AgentID = int.Parse(txtID.Text);
                agent.Email = txtEmail.Text;
                agent.Phone = int.Parse(txtPhone.Text);
                agent.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.UpdateAgent(agent);

                if (x > 0)
                {
                    MessageBox.Show(x + " Updated.");

                    dgvAgent.DataSource = bll.GetAgent();
                }
            }catch (System.FormatException)
            {
                MessageBox.Show("Select Column");
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Information in use");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                Agent agent = new Agent();

                agent.AgentID = int.Parse(txtID.Text);

                int x = bll.DeleteAgent(agent);

                if (x > 0)
                {
                    MessageBox.Show(x + " DELETED.");

                    dgvAgent.DataSource = bll.GetAgent();

                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Information in use!!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Select Column");
            }
        }

        private void dgvAgent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvAgent.SelectedRows.Count > 0)
            {
                txtID.Text = dgvAgent.SelectedRows[0].Cells["AgentID"].Value.ToString();
                txtName.Text = dgvAgent.SelectedRows[0].Cells["Name"].Value.ToString();
                txtSurname.Text = dgvAgent.SelectedRows[0].Cells["Surname"].Value.ToString();
                txtEmail.Text = dgvAgent.SelectedRows[0].Cells["Email"].Value.ToString();
                txtPassword.Text = dgvAgent.SelectedRows[0].Cells["Password"].Value.ToString();
                txtPhone.Text = dgvAgent.SelectedRows[0].Cells["Phone"].Value.ToString();
                cmbStatus.Text = dgvAgent.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbAgency.Text = dgvAgent.SelectedRows[0].Cells["AgencyName"].Value.ToString();
            }
        }
    }
}
