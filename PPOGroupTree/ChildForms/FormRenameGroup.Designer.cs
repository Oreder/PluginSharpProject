namespace PPOGroupTree
{
    partial class FormRenameGroup
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
            this.label1 = new System.Windows.Forms.Label();
            this.edtGroupName = new System.Windows.Forms.TextBox();
            this.btnSubmitChanged = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit group name";
            // 
            // edtGroupName
            // 
            this.edtGroupName.Location = new System.Drawing.Point(15, 47);
            this.edtGroupName.Name = "edtGroupName";
            this.edtGroupName.Size = new System.Drawing.Size(135, 20);
            this.edtGroupName.TabIndex = 1;
            // 
            // btnSubmitChanged
            // 
            this.btnSubmitChanged.Location = new System.Drawing.Point(12, 81);
            this.btnSubmitChanged.Name = "btnSubmitChanged";
            this.btnSubmitChanged.Size = new System.Drawing.Size(135, 42);
            this.btnSubmitChanged.TabIndex = 2;
            this.btnSubmitChanged.Text = "Submit";
            this.btnSubmitChanged.UseVisualStyleBackColor = true;
            this.btnSubmitChanged.Click += new System.EventHandler(this.btnSubmitChanged_Click);
            // 
            // FormRenameGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(168, 135);
            this.Controls.Add(this.btnSubmitChanged);
            this.Controls.Add(this.edtGroupName);
            this.Controls.Add(this.label1);
            this.Name = "FormRenameGroup";
            this.Text = "Edit group name..";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRenameGroup_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox edtGroupName;
        private System.Windows.Forms.Button btnSubmitChanged;
    }
}