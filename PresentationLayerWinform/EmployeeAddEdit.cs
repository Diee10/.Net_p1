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
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;

namespace PresentationLayerWinform
{
    public partial class EmployeeAddEdit : Form
    {
        Employee employee;

        private static IBLEmployees blHandler;

        private static void SetupDependencies()
        {
            IUnityContainer container = new UnityContainer();
            container.LoadConfiguration();

            blHandler = container.Resolve<IBLEmployees>();

        }

        public EmployeeAddEdit(Employee emp, IBLEmployees ble)
        {
            this.employee = emp;
            SetupDependencies();
            InitializeComponent();
        }

        private void EmployeeAddEdit_Load(object sender, EventArgs e)
        {
            if(this.employee != null)
            {
                this.nameInput.Text = this.employee.Name;
                this.dateInput.Value = this.employee.StartDate;
                if(this.employee is PartTimeEmployee)
                {
                    this.SalaryOrHourlyIput.Text = ((PartTimeEmployee)this.employee).HourlyRate.ToString();
                    this.parttime.Select();
                    SalaryOrHourly.Text = "Hourly Rate";
                }
                else
                {
                    this.SalaryOrHourlyIput.Text = ((FullTimeEmployee)this.employee).Salary.ToString();
                    this.fulltime.Select();
                    SalaryOrHourly.Text = "Salary";
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
            this.employee.StartDate = this.dateInput.Value;
            blHandler.AddEmployee(this.employee);
            this.Close();
        }
    }
}
