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
using BLL;
using DAL;
using System.IO;

namespace ManagePropertyApp
{
    public partial class frmProperty : Form
    {
        public frmProperty()
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

        private void frmProperty_Load(object sender, EventArgs e)
        {
            txtID.Enabled = false;

            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Not-Available");

            cmbType.DataSource = bll.GetPropertyTypes();
            cmbType.DisplayMember = "PropertyTypeDescription";
            cmbType.ValueMember = "PropertyTypeID";

            cmbSuburb.DataSource = bll.GetSuburns();
            cmbSuburb.DisplayMember = "SurbubDescription";
            cmbSuburb.ValueMember = "SurbubID";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fld = new OpenFileDialog();
                {
                    string fileName = fld.FileName;
                    if (fld.ShowDialog() == DialogResult.OK)
                    {
                        picImage.Image = Image.FromFile(fld.FileName);
                    }
                }
            }
            catch (System.OutOfMemoryException)
            {
                MessageBox.Show("Select pictures only.");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Property prop = new Property();
            bool validate = false;

            MemoryStream ms = new MemoryStream();
            picImage.Image.Save(ms, picImage.Image.RawFormat);


            if (string.IsNullOrEmpty(txtDescr.Text))
            {
                errProperty.SetError(txtDescr, "Enter property description");
                validate = false;
            }
            else if (string.IsNullOrEmpty(txtPrice.Text) || (!Regex.IsMatch(txtPrice.Text, @"^\d{0,8}(\.\d{1,4})?$")))
            {
                errProperty.SetError(txtPrice, "Invalid price.");
                validate = false;
            }
            else
                validate = true;
            if (validate)
            {
                prop.Description = txtDescr.Text;
                prop.Price = int.Parse(txtPrice.Text);
                prop.Image = ms.ToArray();
                prop.PropertyTypeID = int.Parse(cmbType.SelectedValue.ToString());
                prop.Status = cmbStatus.SelectedItem.ToString();
                prop.SuburbID = int.Parse(cmbSuburb.SelectedValue.ToString());

                int x = bll.InsertProperties(prop);
                if (x > 0)
                {
                    MessageBox.Show(x + " added Successfully.");

                    errProperty.Clear();
                }
            }
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            dgvProperty.DataSource = bll.GetProperties();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Property prop = new Property();


                prop.PropertyID = int.Parse(txtID.Text);
                prop.PropertyTypeID = int.Parse(cmbType.SelectedValue.ToString());
                prop.Price = int.Parse(txtPrice.Text);
                prop.Status = cmbStatus.SelectedItem.ToString();

                int x = bll.UpdateProperties(prop);

                if (x > 0)
                {
                    MessageBox.Show(x + " Property has been UPDATED.");
                    

                }
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Choose a column to update");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                Property prop = new Property();
                prop.PropertyID = int.Parse(txtID.Text);

                int x = bll.DeleteProperties(prop);

                if (x > 0)
                {
                    MessageBox.Show(x + "DELETED.");
                   
                    txtDescr.Clear();
                    txtPrice.Clear();
                    picImage.Image = null;
                }
            }
            catch (System.Data.SqlClient.SqlException)
            {
                MessageBox.Show("Information in use!!");
            }
            catch (System.FormatException)
            {
                MessageBox.Show("Choose a column you want to delete");
            }
        }

        private void dgvProperty_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvProperty.SelectedRows.Count > 0)
            {
                txtID.Text = dgvProperty.SelectedRows[0].Cells["PropertyID"].Value.ToString();
                txtDescr.Text = dgvProperty.SelectedRows[0].Cells["Description"].Value.ToString();
                txtPrice.Text = dgvProperty.SelectedRows[0].Cells["Price"].Value.ToString();
                MemoryStream ms = new MemoryStream((byte[])dgvProperty.SelectedRows[0].Cells["Image"].Value);
                picImage.Image = Image.FromStream(ms);
                cmbType.Text = dgvProperty.SelectedRows[0].Cells["PropertyTypeDescription"].Value.ToString();
                cmbStatus.Text = dgvProperty.SelectedRows[0].Cells["Status"].Value.ToString();
                cmbSuburb.Text = dgvProperty.SelectedRows[0].Cells["SurbubDescription"].Value.ToString();
            }
        }
    }
}
