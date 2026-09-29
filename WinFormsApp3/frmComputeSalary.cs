
using EmployeeNamespace;

namespace WinFormsApp3
{
    public partial class frmComputeSalary : Form
    {
        public frmComputeSalary()
        {
            InitializeComponent();
        }
        public void computeSalaryButton_Click(object sender, EventArgs e)
        {
            string fName = firstNameTextBox.Text;
            string lName = lastNameTextBox.Text;
            string department = departmentTextBox.Text;
            string jobTitle = jobTitleTextBox.Text;
            double ratePerHour = ratePerHourTextBox.Text != "" ? Convert.ToDouble(ratePerHourTextBox.Text) : 1.0;
            int totalHours = totalHoursWorkedTextBox.Text != "" ? Convert.ToInt32(totalHoursWorkedTextBox.Text) : 1;

            PartTimeEmployee part = new PartTimeEmployee(fName, lName, department, jobTitle);
            part.computeSalary(totalHours, ratePerHour);

            firstNameLabelOutput.Text = fName;
            lastNameLabelOutput.Text = lName;
            basicSalaryLabelOutput.Text = Convert.ToString(part.getSalary());

        }
    }
}
