namespace WinFormsApp3
{
    partial class frmComputeSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            firstNameLabel = new Label();
            lastNameLabel = new Label();
            departmentLabel = new Label();
            jobTitleLabel = new Label();
            firstNameTextBox = new TextBox();
            lastNameTextBox = new TextBox();
            departmentTextBox = new TextBox();
            jobTitleTextBox = new TextBox();
            ratePerHourTextBox = new TextBox();
            ratePerHourLabel = new Label();
            totalHoursWorkedTextBox = new TextBox();
            totalHoursWorkedLabel = new Label();
            computeSalaryButton = new Button();
            firstNameLabel2 = new Label();
            lastNameLabel2 = new Label();
            basicSalaryLabel3 = new Label();
            firstNameLabelOutput = new Label();
            lastNameLabelOutput = new Label();
            basicSalaryLabelOutput = new Label();
            SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.Location = new Point(12, 21);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new Size(64, 15);
            firstNameLabel.TabIndex = 0;
            firstNameLabel.Text = "First Name";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new Point(269, 21);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new Size(63, 15);
            lastNameLabel.TabIndex = 1;
            lastNameLabel.Text = "Last Name";
            // 
            // departmentLabel
            // 
            departmentLabel.AutoSize = true;
            departmentLabel.Location = new Point(12, 126);
            departmentLabel.Name = "departmentLabel";
            departmentLabel.Size = new Size(70, 15);
            departmentLabel.TabIndex = 2;
            departmentLabel.Text = "Department";
            // 
            // jobTitleLabel
            // 
            jobTitleLabel.AutoSize = true;
            jobTitleLabel.Location = new Point(269, 126);
            jobTitleLabel.Name = "jobTitleLabel";
            jobTitleLabel.Size = new Size(51, 15);
            jobTitleLabel.TabIndex = 3;
            jobTitleLabel.Text = "Job Title";
            // 
            // firstNameTextBox
            // 
            firstNameTextBox.Location = new Point(12, 39);
            firstNameTextBox.Name = "firstNameTextBox";
            firstNameTextBox.Size = new Size(235, 23);
            firstNameTextBox.TabIndex = 4;
            // 
            // lastNameTextBox
            // 
            lastNameTextBox.Location = new Point(269, 39);
            lastNameTextBox.Name = "lastNameTextBox";
            lastNameTextBox.Size = new Size(235, 23);
            lastNameTextBox.TabIndex = 5;
            // 
            // departmentTextBox
            // 
            departmentTextBox.Location = new Point(12, 144);
            departmentTextBox.Name = "departmentTextBox";
            departmentTextBox.Size = new Size(235, 23);
            departmentTextBox.TabIndex = 6;
            // 
            // jobTitleTextBox
            // 
            jobTitleTextBox.Location = new Point(269, 144);
            jobTitleTextBox.Name = "jobTitleTextBox";
            jobTitleTextBox.Size = new Size(235, 23);
            jobTitleTextBox.TabIndex = 7;
            // 
            // ratePerHourTextBox
            // 
            ratePerHourTextBox.Location = new Point(12, 257);
            ratePerHourTextBox.Name = "ratePerHourTextBox";
            ratePerHourTextBox.Size = new Size(235, 23);
            ratePerHourTextBox.TabIndex = 9;
            // 
            // ratePerHourLabel
            // 
            ratePerHourLabel.AutoSize = true;
            ratePerHourLabel.Location = new Point(12, 239);
            ratePerHourLabel.Name = "ratePerHourLabel";
            ratePerHourLabel.Size = new Size(78, 15);
            ratePerHourLabel.TabIndex = 8;
            ratePerHourLabel.Text = "Rate per hour";
            // 
            // totalHoursWorkedTextBox
            // 
            totalHoursWorkedTextBox.Location = new Point(269, 257);
            totalHoursWorkedTextBox.Name = "totalHoursWorkedTextBox";
            totalHoursWorkedTextBox.Size = new Size(235, 23);
            totalHoursWorkedTextBox.TabIndex = 11;
            // 
            // totalHoursWorkedLabel
            // 
            totalHoursWorkedLabel.AutoSize = true;
            totalHoursWorkedLabel.Location = new Point(269, 239);
            totalHoursWorkedLabel.Name = "totalHoursWorkedLabel";
            totalHoursWorkedLabel.Size = new Size(78, 15);
            totalHoursWorkedLabel.TabIndex = 10;
            totalHoursWorkedLabel.Text = "Rate per hour";
            // 
            // computeSalaryButton
            // 
            computeSalaryButton.BackColor = Color.Sienna;
            computeSalaryButton.ForeColor = SystemColors.ButtonHighlight;
            computeSalaryButton.Location = new Point(189, 301);
            computeSalaryButton.Name = "computeSalaryButton";
            computeSalaryButton.Size = new Size(131, 37);
            computeSalaryButton.TabIndex = 12;
            computeSalaryButton.Text = "Compute Salary";
            computeSalaryButton.UseVisualStyleBackColor = false;
            computeSalaryButton.Click += computeSalaryButton_Click;
            // 
            // firstNameLabel2
            // 
            firstNameLabel2.AutoSize = true;
            firstNameLabel2.Location = new Point(103, 360);
            firstNameLabel2.Name = "firstNameLabel2";
            firstNameLabel2.Size = new Size(70, 15);
            firstNameLabel2.TabIndex = 13;
            firstNameLabel2.Text = "First Name: ";
            // 
            // lastNameLabel2
            // 
            lastNameLabel2.AutoSize = true;
            lastNameLabel2.Location = new Point(103, 394);
            lastNameLabel2.Name = "lastNameLabel2";
            lastNameLabel2.Size = new Size(69, 15);
            lastNameLabel2.TabIndex = 14;
            lastNameLabel2.Text = "Last Name: ";
            // 
            // basicSalaryLabel3
            // 
            basicSalaryLabel3.AutoSize = true;
            basicSalaryLabel3.Location = new Point(178, 440);
            basicSalaryLabel3.Name = "basicSalaryLabel3";
            basicSalaryLabel3.Size = new Size(74, 15);
            basicSalaryLabel3.TabIndex = 15;
            basicSalaryLabel3.Text = "Basic Salary: ";
            // 
            // firstNameLabelOutput
            // 
            firstNameLabelOutput.AutoSize = true;
            firstNameLabelOutput.BackColor = Color.SeaShell;
            firstNameLabelOutput.Location = new Point(178, 360);
            firstNameLabelOutput.Name = "firstNameLabelOutput";
            firstNameLabelOutput.Size = new Size(0, 15);
            firstNameLabelOutput.TabIndex = 16;
            // 
            // lastNameLabelOutput
            // 
            lastNameLabelOutput.AutoSize = true;
            lastNameLabelOutput.BackColor = Color.SeaShell;
            lastNameLabelOutput.Location = new Point(178, 394);
            lastNameLabelOutput.Name = "lastNameLabelOutput";
            lastNameLabelOutput.Size = new Size(0, 15);
            lastNameLabelOutput.TabIndex = 17;
            // 
            // basicSalaryLabelOutput
            // 
            basicSalaryLabelOutput.AutoSize = true;
            basicSalaryLabelOutput.BackColor = Color.SeaShell;
            basicSalaryLabelOutput.Location = new Point(258, 440);
            basicSalaryLabelOutput.Name = "basicSalaryLabelOutput";
            basicSalaryLabelOutput.Size = new Size(0, 15);
            basicSalaryLabelOutput.TabIndex = 18;
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.BlanchedAlmond;
            ClientSize = new Size(525, 550);
            Controls.Add(basicSalaryLabelOutput);
            Controls.Add(lastNameLabelOutput);
            Controls.Add(firstNameLabelOutput);
            Controls.Add(basicSalaryLabel3);
            Controls.Add(lastNameLabel2);
            Controls.Add(firstNameLabel2);
            Controls.Add(computeSalaryButton);
            Controls.Add(totalHoursWorkedTextBox);
            Controls.Add(totalHoursWorkedLabel);
            Controls.Add(ratePerHourTextBox);
            Controls.Add(ratePerHourLabel);
            Controls.Add(jobTitleTextBox);
            Controls.Add(departmentTextBox);
            Controls.Add(lastNameTextBox);
            Controls.Add(firstNameTextBox);
            Controls.Add(jobTitleLabel);
            Controls.Add(departmentLabel);
            Controls.Add(lastNameLabel);
            Controls.Add(firstNameLabel);
            Name = "frmComputeSalary";
            Text = "Employee Salary Calculator";
            ResumeLayout(false);
            PerformLayout();
            CenterToScreen();
        }

        #endregion

        private Label firstNameLabel;
        private Label lastNameLabel;
        private Label departmentLabel;
        private Label jobTitleLabel;
        private TextBox firstNameTextBox;
        private TextBox lastNameTextBox;
        private TextBox departmentTextBox;
        private TextBox jobTitleTextBox;
        private TextBox ratePerHourTextBox;
        private Label ratePerHourLabel;
        private TextBox totalHoursWorkedTextBox;
        private Label totalHoursWorkedLabel;
        private Button computeSalaryButton;
        private Label firstNameLabel2;
        private Label lastNameLabel2;
        private Label basicSalaryLabel3;
        private Label firstNameLabelOutput;
        private Label lastNameLabelOutput;
        private Label basicSalaryLabelOutput;
    }
}
