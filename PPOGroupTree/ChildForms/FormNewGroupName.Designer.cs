namespace PPOGroupTree
{
    partial class FormNewGroupName
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
            this.btnCreateGroup = new System.Windows.Forms.Button();
            this.edtGroupName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCreateGroup
            // 
            this.btnCreateGroup.Location = new System.Drawing.Point(9, 83);
            this.btnCreateGroup.Name = "btnCreateGroup";
            this.btnCreateGroup.Size = new System.Drawing.Size(178, 56);
            this.btnCreateGroup.TabIndex = 0;
            this.btnCreateGroup.Text = "Create";
            this.btnCreateGroup.UseVisualStyleBackColor = true;
            this.btnCreateGroup.Click += new System.EventHandler(this.btnCreateGroup_Click);
            // 
            // edtGroupName
            // 
            this.edtGroupName.Location = new System.Drawing.Point(9, 44);
            this.edtGroupName.Name = "edtGroupName";
            this.edtGroupName.Size = new System.Drawing.Size(178, 20);
            this.edtGroupName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input new group name";
            // 
            // FormNewGroupName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 151);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.edtGroupName);
            this.Controls.Add(this.btnCreateGroup);
            this.Name = "FormNewGroupName";
            this.Text = "New Group";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormNewGroupName_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGroup;
        private System.Windows.Forms.TextBox edtGroupName;
        private System.Windows.Forms.Label label1;
    }
}