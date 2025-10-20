namespace MEDSOFT
{
    partial class AddEditPatientForm
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
            txtFullName = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dtpDob = new DateTimePicker();
            cmbGender = new ComboBox();
            btnSave = new Button();
            btnCancel = new Button();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            txtPNumber = new TextBox();
            txtMail = new TextBox();
            SuspendLayout();
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(208, 97);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(190, 23);
            txtFullName.TabIndex = 0;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(208, 226);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(190, 23);
            txtPhone.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(208, 271);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(190, 23);
            txtAddress.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 100);
            label1.Name = "label1";
            label1.Size = new Size(156, 15);
            label1.TabIndex = 5;
            label1.Text = "პაციენტის სახელი გვარი";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(37, 149);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 6;
            label2.Text = "დაბ. თარიღი";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 188);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 7;
            label3.Text = "სქესი";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 234);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 8;
            label4.Text = "მობ. ნომერი";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 274);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 9;
            label5.Text = "მისამართი";
            // 
            // dtpDob
            // 
            dtpDob.Location = new Point(208, 143);
            dtpDob.Name = "dtpDob";
            dtpDob.Size = new Size(190, 23);
            dtpDob.TabIndex = 10;
            // 
            // cmbGender
            // 
            cmbGender.FormattingEnabled = true;
            cmbGender.Location = new Point(208, 185);
            cmbGender.Name = "cmbGender";
            cmbGender.Size = new Size(190, 23);
            cmbGender.TabIndex = 11;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(127, 387);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "შენახვა";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(251, 387);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "გაუქმება";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = Color.Red;
            label6.Location = new Point(190, 100);
            label6.Name = "label6";
            label6.Size = new Size(12, 15);
            label6.TabIndex = 14;
            label6.Text = "*";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.Red;
            label7.Location = new Point(127, 151);
            label7.Name = "label7";
            label7.Size = new Size(12, 15);
            label7.TabIndex = 14;
            label7.Text = "*";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(83, 188);
            label8.Name = "label8";
            label8.Size = new Size(12, 15);
            label8.TabIndex = 14;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(37, 317);
            label9.Name = "label9";
            label9.Size = new Size(71, 15);
            label9.TabIndex = 15;
            label9.Text = "ელ ფოსტა";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(37, 354);
            label10.Name = "label10";
            label10.Size = new Size(101, 15);
            label10.TabIndex = 16;
            label10.Text = "პირადი ნომერი";
            // 
            // txtPNumber
            // 
            txtPNumber.Location = new Point(208, 346);
            txtPNumber.Name = "txtPNumber";
            txtPNumber.Size = new Size(190, 23);
            txtPNumber.TabIndex = 4;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(208, 309);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(190, 23);
            txtMail.TabIndex = 4;
            // 
            // AddEditPatientForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(433, 450);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(cmbGender);
            Controls.Add(dtpDob);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMail);
            Controls.Add(txtPNumber);
            Controls.Add(txtAddress);
            Controls.Add(txtPhone);
            Controls.Add(txtFullName);
            Name = "AddEditPatientForm";
            Text = "AddEditPatientForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullName;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DateTimePicker dtpDob;
        private ComboBox cmbGender;
        private Button btnSave;
        private Button btnCancel;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox txtPNumber;
        private TextBox txtMail;
    }
}