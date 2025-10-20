namespace MEDSOFT
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            dataGridView1 = new DataGridView();
            AddBtn = new Button();
            EditBtn = new Button();
            DeleteBtn = new Button();
            ID = new DataGridViewTextBoxColumn();
            FullName = new DataGridViewTextBoxColumn();
            Dob = new DataGridViewTextBoxColumn();
            GenderName = new DataGridViewTextBoxColumn();
            Phone = new DataGridViewTextBoxColumn();
            Address = new DataGridViewTextBoxColumn();
            EMail = new DataGridViewTextBoxColumn();
            PNumber = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, FullName, Dob, GenderName, Phone, Address, EMail, PNumber });
            dataGridView1.Location = new Point(135, 139);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1134, 206);
            dataGridView1.TabIndex = 0;
            // 
            // AddBtn
            // 
            AddBtn.Image = (Image)resources.GetObject("AddBtn.Image");
            AddBtn.ImageAlign = ContentAlignment.TopLeft;
            AddBtn.Location = new Point(135, 74);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(102, 30);
            AddBtn.TabIndex = 1;
            AddBtn.Text = "      დამატება";
            AddBtn.UseVisualStyleBackColor = true;
            AddBtn.Click += AddBtn_Click;
            // 
            // EditBtn
            // 
            EditBtn.Image = Properties.Resources.Screenshot_3;
            EditBtn.ImageAlign = ContentAlignment.MiddleLeft;
            EditBtn.Location = new Point(243, 74);
            EditBtn.Name = "EditBtn";
            EditBtn.Size = new Size(138, 30);
            EditBtn.TabIndex = 2;
            EditBtn.Text = "რედაქტირება";
            EditBtn.UseVisualStyleBackColor = true;
            EditBtn.Click += EditBtn_Click;
            // 
            // DeleteBtn
            // 
            DeleteBtn.Image = Properties.Resources.Screenshot_4;
            DeleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            DeleteBtn.Location = new Point(387, 74);
            DeleteBtn.Name = "DeleteBtn";
            DeleteBtn.Size = new Size(105, 30);
            DeleteBtn.TabIndex = 3;
            DeleteBtn.Text = "წაშლა";
            DeleteBtn.UseVisualStyleBackColor = true;
            DeleteBtn.Click += DeleteBtn_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.ReadOnly = true;
            ID.Width = 50;
            // 
            // FullName
            // 
            FullName.DataPropertyName = "FullName";
            FullName.HeaderText = "პაციენტის გვარი სახელი";
            FullName.MinimumWidth = 20;
            FullName.Name = "FullName";
            FullName.Width = 200;
            // 
            // Dob
            // 
            Dob.DataPropertyName = "Dob";
            Dob.HeaderText = "დაბ. თარიღი";
            Dob.Name = "Dob";
            Dob.Width = 120;
            // 
            // GenderName
            // 
            GenderName.DataPropertyName = "GenderName";
            GenderName.HeaderText = "სქესი";
            GenderName.Name = "GenderName";
            GenderName.Width = 120;
            // 
            // Phone
            // 
            Phone.DataPropertyName = "Phone";
            Phone.HeaderText = "მობ. ნომერი";
            Phone.Name = "Phone";
            Phone.Width = 150;
            // 
            // Address
            // 
            Address.DataPropertyName = "Address";
            Address.HeaderText = "მისამართი";
            Address.Name = "Address";
            Address.Width = 150;
            // 
            // EMail
            // 
            EMail.DataPropertyName = "EMail";
            EMail.HeaderText = "ელ. ფოსტა";
            EMail.Name = "EMail";
            EMail.Width = 150;
            // 
            // PNumber
            // 
            PNumber.DataPropertyName = "PNumber";
            PNumber.HeaderText = "პირადი ნომერი";
            PNumber.Name = "PNumber";
            PNumber.Width = 150;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1404, 543);
            Controls.Add(DeleteBtn);
            Controls.Add(EditBtn);
            Controls.Add(AddBtn);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddBtn;
        private Button EditBtn;
        private Button DeleteBtn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn FullName;
        private DataGridViewTextBoxColumn Dob;
        private DataGridViewTextBoxColumn GenderName;
        private DataGridViewTextBoxColumn Phone;
        private DataGridViewTextBoxColumn Address;
        private DataGridViewTextBoxColumn EMail;
        private DataGridViewTextBoxColumn PNumber;
    }
}
