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

namespace SimpleCRUDDepartment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtDepartment.Text.Trim() == "")
                MessageBox.Show("Please Fill the input Department");
            else
            {
                Department department = new Department();
                department.DepartmentName = txtDepartment.Text;
                BLL.DepartmentBLL.addDepartment(department);
                MessageBox.Show("NEW Departmet Inserted With SuccessFully");
                txtDepartment.Text = "";
            }
        }
    }
}
