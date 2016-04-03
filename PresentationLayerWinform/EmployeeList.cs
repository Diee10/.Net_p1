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
        private IBLEmployees _ble;

        public EmployeeList()
        {
            _ble = new BLEmployees(new DALEmployeesMongo());
            InitializeComponent();
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

            this.listBox1.SelectedIndexChanged -= new System.EventHandler(this.listBox1_SelectionChangeCommited);
            List<Employee> employeeList = _ble.GetAllEmployees();

            listBox1.DataSource = employeeList;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";

            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectionChangeCommited);
        }

        private void InitializeComponent()
        {
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.nuevo = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            this.eliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 13);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(239, 238);
            this.listBox1.TabIndex = 0;
            // 
            // nuevo
            // 
            this.nuevo.Location = new System.Drawing.Point(13, 268);
            this.nuevo.Name = "nuevo";
            this.nuevo.Size = new System.Drawing.Size(75, 23);
            this.nuevo.TabIndex = 1;
            this.nuevo.Text = "New";
            this.nuevo.UseVisualStyleBackColor = true;
            this.nuevo.Click += new System.EventHandler(this.nuevo_Click);
            // 
            // modificar
            // 
            this.modificar.Location = new System.Drawing.Point(95, 268);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(75, 23);
            this.modificar.TabIndex = 2;
            this.modificar.Text = "Update";
            this.modificar.UseVisualStyleBackColor = true;
            this.modificar.Click += new System.EventHandler(this.modificar_Click);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(177, 268);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 3;
            this.eliminar.Text = "Delete";
            this.eliminar.UseVisualStyleBackColor = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // EmployeeList
            // 
            this.ClientSize = new System.Drawing.Size(268, 298);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.modificar);
            this.Controls.Add(this.nuevo);
            this.Controls.Add(this.listBox1);
            this.Name = "EmployeeList";
            this.Load += new System.EventHandler(this.EmployeeList_Load);
            this.ResumeLayout(false);

        }

        private void listBox1_SelectionChangeCommited(object sender, EventArgs e)
        {

            //EmployeeAddEdit viewEdit = new EmployeeAddEdit((Employee)listBox1.SelectedItem));
            //viewEdit.Show();
            //throw new Exception("algo "+ ((Employee)listBox1.SelectedItem).Name);
             
        }

        private void eliminar_Click(object sender, EventArgs e)
        {
            Employee selectedEmp = (Employee)listBox1.SelectedItem;
            if(selectedEmp == null)
            {
                throw new Exception("Error, no seleccio empleado a eliminar");
            }
            else
            {
                _ble.DeleteEmployee(selectedEmp.Id);
                EmployeeList_Load(sender, e);
            }
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            EmployeeAddEdit viewEdit = new EmployeeAddEdit(null, _ble);
            viewEdit.Show();
            var self = this;
            viewEdit.FormClosing += (s, evt)=>{
                List<Employee> employeeList = _ble.GetAllEmployees();
                listBox1.DataSource = employeeList;
            };
        }


        private void modificar_Click(object sender, EventArgs e)
        {
            EmployeeAddEdit viewEdit = new EmployeeAddEdit((Employee)listBox1.SelectedItem, _ble);
            viewEdit.Show();
        }
    }
}