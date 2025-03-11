namespace Final_Project
{
    partial class NewPersonForm
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtName = new TextBox();
            txtAge = new TextBox();
            txtDOB = new TextBox();
            btnComplete = new Button();
            lblName = new Label();
            lblAge = new Label();
            lblDOB = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(0, 64);
            txtName.Name = "txtName";
            txtName.Size = new Size(238, 23);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(3, 141);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(238, 23);
            txtAge.TabIndex = 1;
            txtAge.TextChanged += txtAge_TextChanged;
            // 
            // txtDOB
            // 
            txtDOB.Location = new Point(3, 232);
            txtDOB.Name = "txtDOB";
            txtDOB.Size = new Size(238, 23);
            txtDOB.TabIndex = 2;
            txtDOB.TextChanged += txtDOB_TextChanged;
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(362, 33);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(208, 54);
            btnComplete.TabIndex = 3;
            btnComplete.Text = "Click here to complete registration";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += button1_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(78, 33);
            lblName.Name = "lblName";
            lblName.Size = new Size(105, 15);
            lblName.TabIndex = 4;
            lblName.Text = "*Insert name here*";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(78, 109);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(94, 15);
            lblAge.TabIndex = 5;
            lblAge.Text = "*Insert age here*";
            // 
            // lblDOB
            // 
            lblDOB.AutoSize = true;
            lblDOB.Location = new Point(78, 189);
            lblDOB.Name = "lblDOB";
            lblDOB.Size = new Size(99, 15);
            lblDOB.TabIndex = 6;
            lblDOB.Text = "*Insert DOB here*";
            // 
            // NewPersonForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(784, 441);
            Controls.Add(lblDOB);
            Controls.Add(lblAge);
            Controls.Add(lblName);
            Controls.Add(btnComplete);
            Controls.Add(txtDOB);
            Controls.Add(txtAge);
            Controls.Add(txtName);
            Name = "NewPersonForm";
            Load += UI_Load;
            Controls.SetChildIndex(txtName, 0);
            Controls.SetChildIndex(txtAge, 0);
            Controls.SetChildIndex(txtDOB, 0);
            Controls.SetChildIndex(btnComplete, 0);
            Controls.SetChildIndex(lblName, 0);
            Controls.SetChildIndex(lblAge, 0);
            Controls.SetChildIndex(lblDOB, 0);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtAge;
        private TextBox txtDOB;
        private Button btnComplete;
        private Label lblName;
        private Label lblAge;
        private Label lblDOB;
    }
}
