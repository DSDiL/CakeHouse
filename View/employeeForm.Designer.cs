
namespace CakeHouse.View
{
    partial class employeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.close = new System.Windows.Forms.Label();
            this.empNaneLabel = new System.Windows.Forms.Label();
            this.adminLabel = new System.Windows.Forms.Label();
            this.salaryLabel = new System.Windows.Forms.Label();
            this.positionLabel = new System.Windows.Forms.Label();
            this.empIdLabel = new System.Windows.Forms.Label();
            this.empId = new System.Windows.Forms.Label();
            this.position = new System.Windows.Forms.TextBox();
            this.salary = new System.Windows.Forms.TextBox();
            this.empName = new System.Windows.Forms.TextBox();
            this.admin = new System.Windows.Forms.ComboBox();
            this.employeeTable = new System.Windows.Forms.DataGridView();
            this.deleteEmpBtn = new System.Windows.Forms.Button();
            this.editEmpBtn = new System.Windows.Forms.Button();
            this.addEmpBtn = new System.Windows.Forms.Button();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).BeginInit();
            this.SuspendLayout();
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.Location = new System.Drawing.Point(1145, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(49, 20);
            this.close.TabIndex = 14;
            this.close.Text = "close";
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // empNaneLabel
            // 
            this.empNaneLabel.AutoSize = true;
            this.empNaneLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empNaneLabel.Location = new System.Drawing.Point(47, 165);
            this.empNaneLabel.Name = "empNaneLabel";
            this.empNaneLabel.Size = new System.Drawing.Size(179, 29);
            this.empNaneLabel.TabIndex = 15;
            this.empNaneLabel.Text = "Employe Name";
            // 
            // adminLabel
            // 
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.Location = new System.Drawing.Point(47, 373);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(153, 29);
            this.adminLabel.TabIndex = 16;
            this.adminLabel.Text = "Admin Status";
            // 
            // salaryLabel
            // 
            this.salaryLabel.AutoSize = true;
            this.salaryLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLabel.Location = new System.Drawing.Point(47, 305);
            this.salaryLabel.Name = "salaryLabel";
            this.salaryLabel.Size = new System.Drawing.Size(80, 29);
            this.salaryLabel.TabIndex = 17;
            this.salaryLabel.Text = "Salary";
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionLabel.Location = new System.Drawing.Point(47, 236);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(100, 29);
            this.positionLabel.TabIndex = 18;
            this.positionLabel.Text = "Position";
            // 
            // empIdLabel
            // 
            this.empIdLabel.AutoSize = true;
            this.empIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empIdLabel.Location = new System.Drawing.Point(47, 92);
            this.empIdLabel.Name = "empIdLabel";
            this.empIdLabel.Size = new System.Drawing.Size(151, 29);
            this.empIdLabel.TabIndex = 19;
            this.empIdLabel.Text = "Employee ID";
            // 
            // empId
            // 
            this.empId.AutoSize = true;
            this.empId.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empId.Location = new System.Drawing.Point(275, 92);
            this.empId.Name = "empId";
            this.empId.Size = new System.Drawing.Size(21, 29);
            this.empId.TabIndex = 20;
            this.empId.Text = "-";
            // 
            // position
            // 
            this.position.BackColor = System.Drawing.SystemColors.ControlLight;
            this.position.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.position.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.position.Location = new System.Drawing.Point(280, 236);
            this.position.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(260, 27);
            this.position.TabIndex = 21;
            // 
            // salary
            // 
            this.salary.BackColor = System.Drawing.SystemColors.ControlLight;
            this.salary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salary.Location = new System.Drawing.Point(280, 305);
            this.salary.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(260, 27);
            this.salary.TabIndex = 22;
            // 
            // empName
            // 
            this.empName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.empName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empName.Location = new System.Drawing.Point(280, 165);
            this.empName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empName.Name = "empName";
            this.empName.Size = new System.Drawing.Size(260, 27);
            this.empName.TabIndex = 23;
            // 
            // admin
            // 
            this.admin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.admin.FormattingEnabled = true;
            this.admin.Items.AddRange(new object[] {
            "Admin",
            "Employee"});
            this.admin.Location = new System.Drawing.Point(280, 373);
            this.admin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.admin.Name = "admin";
            this.admin.Size = new System.Drawing.Size(259, 24);
            this.admin.TabIndex = 24;
            // 
            // employeeTable
            // 
            this.employeeTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.employeeTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.employeeTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeTable.Location = new System.Drawing.Point(585, 90);
            this.employeeTable.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.employeeTable.Name = "employeeTable";
            this.employeeTable.RowHeadersWidth = 51;
            this.employeeTable.Size = new System.Drawing.Size(573, 462);
            this.employeeTable.TabIndex = 25;
            this.employeeTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeTable_CellContentClick);
            // 
            // deleteEmpBtn
            // 
            this.deleteEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteEmpBtn.Location = new System.Drawing.Point(400, 508);
            this.deleteEmpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteEmpBtn.Name = "deleteEmpBtn";
            this.deleteEmpBtn.Size = new System.Drawing.Size(133, 43);
            this.deleteEmpBtn.TabIndex = 28;
            this.deleteEmpBtn.Text = "DELETE";
            this.deleteEmpBtn.UseVisualStyleBackColor = true;
            this.deleteEmpBtn.Click += new System.EventHandler(this.deleteEmpBtn_Click_1);
            // 
            // editEmpBtn
            // 
            this.editEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editEmpBtn.Location = new System.Drawing.Point(227, 508);
            this.editEmpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.editEmpBtn.Name = "editEmpBtn";
            this.editEmpBtn.Size = new System.Drawing.Size(133, 43);
            this.editEmpBtn.TabIndex = 27;
            this.editEmpBtn.Text = "EDIT";
            this.editEmpBtn.UseVisualStyleBackColor = true;
            this.editEmpBtn.Click += new System.EventHandler(this.editEmpBtn_Click);
            // 
            // addEmpBtn
            // 
            this.addEmpBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addEmpBtn.Location = new System.Drawing.Point(60, 508);
            this.addEmpBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addEmpBtn.Name = "addEmpBtn";
            this.addEmpBtn.Size = new System.Drawing.Size(133, 43);
            this.addEmpBtn.TabIndex = 26;
            this.addEmpBtn.Text = "ADD";
            this.addEmpBtn.UseVisualStyleBackColor = true;
            this.addEmpBtn.Click += new System.EventHandler(this.addEmpBtn_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(47, 441);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 29);
            this.passwordLabel.TabIndex = 29;
            this.passwordLabel.Text = "Password";
            // 
            // password
            // 
            this.password.Cursor = System.Windows.Forms.Cursors.Hand;
            this.password.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.password.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(280, 434);
            this.password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.password.Name = "password";
            this.password.Size = new System.Drawing.Size(260, 36);
            this.password.TabIndex = 31;
            this.password.Text = "Generate";
            this.password.UseVisualStyleBackColor = true;
            this.password.Click += new System.EventHandler(this.password_Click);
            // 
            // employeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1200, 615);
            this.Controls.Add(this.password);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.deleteEmpBtn);
            this.Controls.Add(this.editEmpBtn);
            this.Controls.Add(this.addEmpBtn);
            this.Controls.Add(this.employeeTable);
            this.Controls.Add(this.admin);
            this.Controls.Add(this.empName);
            this.Controls.Add(this.salary);
            this.Controls.Add(this.position);
            this.Controls.Add(this.empId);
            this.Controls.Add(this.empIdLabel);
            this.Controls.Add(this.positionLabel);
            this.Controls.Add(this.salaryLabel);
            this.Controls.Add(this.adminLabel);
            this.Controls.Add(this.empNaneLabel);
            this.Controls.Add(this.close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "employeeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "employeeForm";
            this.Load += new System.EventHandler(this.employeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label close;
        private System.Windows.Forms.Label empNaneLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Label salaryLabel;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.Label empIdLabel;
        private System.Windows.Forms.Label empId;
        private System.Windows.Forms.TextBox position;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox empName;
        private System.Windows.Forms.ComboBox admin;
        private System.Windows.Forms.DataGridView employeeTable;
        private System.Windows.Forms.Button deleteEmpBtn;
        private System.Windows.Forms.Button editEmpBtn;
        private System.Windows.Forms.Button addEmpBtn;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Button password;
    }
}