namespace LOG_IN.CS
{
    partial class TypeOfStudent
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
            this.cbStudenttype = new System.Windows.Forms.ComboBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnCancel = new System.Windows.Forms.Button();
            this.bnContinue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(11, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type of Student";
            // 
            // cbStudenttype
            // 
            this.cbStudenttype.FormattingEnabled = true;
            this.cbStudenttype.Items.AddRange(new object[] {
            "New Student",
            "Old Student",
            "Transferee"});
            this.cbStudenttype.Location = new System.Drawing.Point(102, 35);
            this.cbStudenttype.Name = "cbStudenttype";
            this.cbStudenttype.Size = new System.Drawing.Size(213, 21);
            this.cbStudenttype.TabIndex = 1;
            this.cbStudenttype.SelectedIndexChanged += new System.EventHandler(this.cbStudenttype_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(102, 75);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(213, 199);
            this.checkedListBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(22, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Requirements";
            // 
            // bnCancel
            // 
            this.bnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnCancel.Location = new System.Drawing.Point(240, 296);
            this.bnCancel.Name = "bnCancel";
            this.bnCancel.Size = new System.Drawing.Size(75, 23);
            this.bnCancel.TabIndex = 4;
            this.bnCancel.Text = "Cancel";
            this.bnCancel.UseVisualStyleBackColor = true;
            // 
            // bnContinue
            // 
            this.bnContinue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnContinue.Location = new System.Drawing.Point(159, 296);
            this.bnContinue.Name = "bnContinue";
            this.bnContinue.Size = new System.Drawing.Size(75, 23);
            this.bnContinue.TabIndex = 5;
            this.bnContinue.Text = "Continue";
            this.bnContinue.UseVisualStyleBackColor = true;
            this.bnContinue.Click += new System.EventHandler(this.bnContinue_Click);
            // 
            // TypeOfStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LOG_IN.CS.Properties.Resources.e;
            this.ClientSize = new System.Drawing.Size(334, 332);
            this.Controls.Add(this.bnContinue);
            this.Controls.Add(this.bnCancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.cbStudenttype);
            this.Controls.Add(this.label1);
            this.Name = "TypeOfStudent";
            this.Text = "TypeOfStudent";
            this.Load += new System.EventHandler(this.TypeOfStudent_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbStudenttype;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnCancel;
        private System.Windows.Forms.Button bnContinue;
    }
}