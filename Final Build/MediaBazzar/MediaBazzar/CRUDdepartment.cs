using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazzar
{
    public partial class CRUDdepartment : Form
    {
        private Wrappers wrp;
        public CRUDdepartment()
        {
            InitializeComponent();
            wrp = new Wrappers();
            UpdateListbox();

        }
        public void UpdateListbox()
        {
            lbxDepartment.Items.Clear();
            List<Object> departmentList = wrp.DM.GetListObj();
            foreach (var item in departmentList)
            {
                if (item != null)
                {
                    lbxDepartment.Items.Add(item);
                }
            }
        }

        private void btnAddStock_Click(object sender, EventArgs e)
        {
            try
            {
                wrp.DM.AddObj(new Department(tbxAddDep.Text));
                UpdateListbox();
                tbxAddDep.Text = string.Empty;
                MessageBox.Show("Department have been added!");
            }
            catch
            {
                MessageBox.Show("Can't add new department");
            }
        }

        private void lbxDepartment_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                Department department = (Department)lbxDepartment.SelectedItem;
                tbxUpName.Text = department.Name;
            }
            catch
            {
                MessageBox.Show("Please select a department!");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Department department = (Department)lbxDepartment.SelectedItem;
            wrp.DM.UpdateDepartment(department, tbxUpName.Text);
            UpdateListbox();
            MessageBox.Show("Department name have been update!");
        }

        private void btnRmv_Click(object sender, EventArgs e)
        {
            try
            {
                int newID = Convert.ToInt32(tbxRmvID.Text);
                wrp.DM.RemoveObj(newID);
                tbxRmvID.Text = string.Empty;
                UpdateListbox();
                MessageBox.Show("Department have been removed!");
            }
            catch
            {
                MessageBox.Show("Please insert department ID!");
            }
        }
    }
}
