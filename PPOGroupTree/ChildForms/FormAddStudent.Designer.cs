namespace PPOGroupTree
{
    partial class FormAddStudent
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
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.edtSurN = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtMidN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtAvarta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.edtRole = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(207, 10);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(89, 162);
            this.btnAddStudent.TabIndex = 0;
            this.btnAddStudent.Text = "Add";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "SurName";
            // 
            // edtSurN
            // 
            this.edtSurN.Location = new System.Drawing.Point(83, 10);
            this.edtSurN.Name = "edtSurN";
            this.edtSurN.Size = new System.Drawing.Size(105, 20);
            this.edtSurN.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(83, 36);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(105, 20);
            this.edtName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "MidName";
            // 
            // edtMidN
            // 
            this.edtMidN.Location = new System.Drawing.Point(83, 61);
            this.edtMidN.Name = "edtMidN";
            this.edtMidN.Size = new System.Drawing.Size(105, 20);
            this.edtMidN.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Rating";
            // 
            // edtRate
            // 
            this.edtRate.Location = new System.Drawing.Point(83, 99);
            this.edtRate.Name = "edtRate";
            this.edtRate.Size = new System.Drawing.Size(105, 20);
            this.edtRate.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Avarta";
            // 
            // edtAvarta
            // 
            this.edtAvarta.Location = new System.Drawing.Point(83, 125);
            this.edtAvarta.Name = "edtAvarta";
            this.edtAvarta.Size = new System.Drawing.Size(105, 20);
            this.edtAvarta.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "label1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(39, 154);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Role";
            // 
            // edtRole
            // 
            this.edtRole.FormattingEnabled = true;
            this.edtRole.Items.AddRange(new object[] {
            "student",
            "head"});
            this.edtRole.Location = new System.Drawing.Point(83, 151);
            this.edtRole.Name = "edtRole";
            this.edtRole.Size = new System.Drawing.Size(105, 21);
            this.edtRole.TabIndex = 3;
            // 
            // FormAddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 180);
            this.Controls.Add(this.edtRole);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.edtAvarta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.edtRate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.edtMidN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.edtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.edtSurN);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddStudent);
            this.Name = "FormAddStudent";
            this.Text = "Create new student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtSurN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtMidN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtAvarta;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox edtRole;
    }
}