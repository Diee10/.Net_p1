using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;
using Shared.Entities;

namespace PresentationLayerWinform
{
    public partial class EmployeeList : Form
    {
        public EmployeeList()
        {
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {
   

            
            
            IBLEmployees _ble = new BLEmployees(new DALEmployeesMongo());
            List<Employee> employeeList = _ble.GetAllEmployees();

            listBox1.DataSource = employeeList;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(272, 238);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            // 
            // EmployeeList
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.listBox1);
            this.Name = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.ResumeLayout(false);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           // throw new Exception();
        }
    }
}