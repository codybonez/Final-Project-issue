namespace Final_Project
{
    partial class NewPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPerson));
            lblDOB = new Label();
            lbl_Age = new Label();
            lblName = new Label();
            btnComplete = new Button();
            txtDOB = new TextBox();
            txtAge = new TextBox();
            txtName = new TextBox();
            txt_Age = new TextBox();
            txt_DOB = new TextBox();
            btnSave = new Button();
            lbl_Name = new Label();
            lbl_DOB = new Label();
            btnClear = new Button();
            SuspendLayout();
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(90, 187);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(99, 15);
            lblDOB.TabIndex = 13;
            lblDOB.Text = "*Insert DOB here*";
            // 
            // lbl_Age
            // 
            lbl_Age.AutoSize = true;
            lbl_Age.BackColor = Color.White;
            lbl_Age.Location = new Point(90, 107);
            lbl_Age.Name = "lbl_Age";
            lbl_Age.Size = new Size(94, 15);
            lbl_Age.TabIndex = 12;
            lbl_Age.Text = "*Insert age here*";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(90, 31);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 15);
            lblName.TabIndex = 11;
            lblName.Text = "*Insert name here*";
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(374, 31);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(208, 54);
            btnComplete.TabIndex = 10;
            btnComplete.Text = "Click here to complete registration";
            btnComplete.UseVisualStyleBackColor = true;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(15, 230);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(238, 23);
            txtDOB.TabIndex = 9;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(15, 139);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(238, 23);
            txtAge.TabIndex = 8;
            // 
            // txtName
            // 
            txtName.Location = new Point(15, 62);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 23);
            txtName.TabIndex = 7;
            // 
            // txt_Age
            // 
            txt_Age.Location = new Point(15, 139);
            txt_Age.Name = "txt_Age";
            txt_Age.Size = new Size(238, 23);
            txt_Age.TabIndex = 8;
            // 
            // txt_DOB
            // 
            txt_DOB.Location = new Point(15, 230);
            txt_DOB.Name = "txt_DOB";
            txt_DOB.Size = new Size(238, 23);
            txt_DOB.TabIndex = 9;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(374, 31);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(208, 54);
            btnSave.TabIndex = 10;
            btnSave.Text = "Click here to complete registration";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.BackColor = Color.White;
            lbl_Name.Location = new Point(90, 31);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(105, 15);
            lbl_Name.TabIndex = 11;
            lbl_Name.Text = "*Insert name here*";
            // 
            // lbl_DOB
            // 
            lbl_DOB.AutoSize = true;
            lbl_DOB.BackColor = Color.White;
            lbl_DOB.Location = new Point(90, 187);
            lbl_DOB.Name = "lbl_DOB";
            lbl_DOB.Size = new Size(99, 15);
            lbl_DOB.TabIndex = 13;
            lbl_DOB.Text = "*Insert DOB here*";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(374, 138);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(208, 64);
            btnClear.TabIndex = 14;
            btnClear.Text = "Clear Form";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // NewPerson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.DarkSlateGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClear);
            Controls.Add(lbl_DOB);
            Controls.Add(lblDOB);
            Controls.Add(lbl_Age);
            Controls.Add(lbl_Name);
            Controls.Add(btnSave);
            Controls.Add(lblName);
            Controls.Add(txt_DOB);
            Controls.Add(btnComplete);
            Controls.Add(txt_Age);
            Controls.Add(txtDOB);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "NewPerson";
            Text = "Register ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDOB;
        private Label lbl_Age;
        private Label lblName;
        private Button btnComplete;
        private TextBox txtDOB;
        private TextBox txtAge;
        private TextBox txtName;
        private TextBox txt_Age;
        private TextBox txt_DOB;
        private Button btnSave;
        private Label lbl_Name;
        private Label lbl_DOB;
        private Button btnClear;
    }
}