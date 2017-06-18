namespace PPOGroupTree
{
    partial class FormUpdateStudent
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
            this.edtRole = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.edtAvarta = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.edtRate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.edtMidN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.edtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.edtSurN = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edtRole
            // 
            this.edtRole.FormattingEnabled = true;
            this.edtRole.Items.AddRange(new object[] {
            "student",
            "head"});
            this.edtRole.Location = new System.Drawing.Point(77, 153);
            this.edtRole.Name = "edtRole";
            this.edtRole.Size = new System.Drawing.Size(105, 21);
            this.edtRole.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Role";
            // 
            // edtAvarta
            // 
            this.edtAvarta.Location = new System.Drawing.Point(77, 127);
            this.edtAvarta.Name = "edtAvarta";
            this.edtAvarta.Size = new System.Drawing.Size(105, 20);
            this.edtAvarta.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Avarta";
            // 
            // edtRate
            // 
            this.edtRate.Location = new System.Drawing.Point(77, 101);
            this.edtRate.Name = "edtRate";
            this.edtRate.Size = new System.Drawing.Size(105, 20);
            this.edtRate.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rating";
            // 
            // edtMidN
            // 
            this.edtMidN.Location = new System.Drawing.Point(77, 63);
            this.edtMidN.Name = "edtMidN";
            this.edtMidN.Size = new System.Drawing.Size(105, 20);
            this.edtMidN.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "MidName";
            // 
            // edtName
            // 
            this.edtName.Location = new System.Drawing.Point(77, 38);
            this.edtName.Name = "edtName";
            this.edtName.Size = new System.Drawing.Size(105, 20);
            this.edtName.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "label1";
            // 
            // edtSurN
            // 
            this.edtSurN.Location = new System.Drawing.Point(77, 12);
            this.edtSurN.Name = "edtSurN";
            this.edtSurN.Size = new System.Drawing.Size(105, 20);
            this.edtSurN.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "SurName";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(200, 12);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(91, 162);
            this.btnSubmit.TabIndex = 17;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // FormUpdateStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 183);
            this.Controls.Add(this.btnSubmit);
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
            this.Name = "FormUpdateStudent";
            this.Text = "Modify Student";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormUpdateStudent_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox edtRole;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox edtAvarta;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox edtRate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox edtMidN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox edtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox edtSurN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubmit;
    }
}