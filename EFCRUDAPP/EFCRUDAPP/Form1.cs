using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFCRUDAPP
{
    public partial class Form1 : Form
    {
        Customer model = new Customer();

        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clear();
        }
        void Clear()
        {
            txtFirstname.Text = txtLastName.Text = txtCity.Text = txtAddress.Text = "";
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
            model.CustomerId = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Clear();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            model.FirstName = txtFirstname.Text.Trim();
            model.FirstName = txtFirstname.Text.Trim();
            model.FirstName = txtFirstname.Text.Trim();
            using (DBEntities db = new DBEntities())
            {

            }
        }
    }
}
