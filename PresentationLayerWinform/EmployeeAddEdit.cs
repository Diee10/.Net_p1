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
    public partial class EmployeeAddEdit : Form
    {
        Employee employee;
        private IBLEmployees _ble;

        public EmployeeAddEdit(Employee emp, IBLEmployees ble)
        {
            this.employee = emp;
            _ble = ble;
            InitializeComponent();
        }

        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {
            if(this.employee != null)
            {
                this.nameInput.Text = this.employee.Name;
                this.dateInput.Text = this.employee.StartDate.ToString();
                if(this.employee.GetType().Equals("PartTimeEmployee"))
                {
                    this.SalaryOrHourlyIput.Text = ((PartTimeEmployee)this.employee).HourlyRate.ToString();
                    this.fulltime.Select();
                }
                else
                {
                    this.SalaryOrHourlyIput.Text = ((FullTimeEmployee)this.employee).Salary.ToString();
                    this.parttime.Select();
                }
            }
        }


        private void cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (this.fulltime.Checked)
            {
                if (this.employee == null)
                {
                    this.employee = new FullTimeEmployee();
                    ((FullTimeEmployee)this.employee).Salary = int.Parse(this.SalaryOrHourlyIput.Text);
                }
            }
            else
            {
                if (this.employee == null)
                {
                    this.employee = new PartTimeEmployee();
                    ((PartTimeEmployee)this.employee).HourlyRate = int.Parse(this.SalaryOrHourlyIput.Text);
                }
            }
            this.employee.Name = this.nameInput.Text;
            this.employee.StartDate = DateTime.Parse(this.dateInput.Text);
            _ble.AddEmployee(this.employee);
            this.Close();
        }
    }
}
