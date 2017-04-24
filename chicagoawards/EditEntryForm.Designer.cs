namespace WE2017Awards
{
    partial class EditEntryForm
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
            this.group_AddAward = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_table = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.cbo_Award = new System.Windows.Forms.ComboBox();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.group_AddAward.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_AddAward
            // 
            this.group_AddAward.Controls.Add(this.label6);
            this.group_AddAward.Controls.Add(this.txt_table);
            this.group_AddAward.Controls.Add(this.label5);
            this.group_AddAward.Controls.Add(this.txt_ID);
            this.group_AddAward.Controls.Add(this.label4);
            this.group_AddAward.Controls.Add(this.label3);
            this.group_AddAward.Controls.Add(this.label2);
            this.group_AddAward.Controls.Add(this.label1);
            this.group_AddAward.Controls.Add(this.txt_Title);
            this.group_AddAward.Controls.Add(this.txt_LastName);
            this.group_AddAward.Controls.Add(this.txt_FirstName);
            this.group_AddAward.Controls.Add(this.cbo_Award);
            this.group_AddAward.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_AddAward.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.group_AddAward.Location = new System.Drawing.Point(13, 50);
            this.group_AddAward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_AddAward.Name = "group_AddAward";
            this.group_AddAward.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_AddAward.Size = new System.Drawing.Size(1292, 220);
            this.group_AddAward.TabIndex = 8;
            this.group_AddAward.TabStop = false;
            this.group_AddAward.Text = "Edit Entry";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1032, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "Table";
            // 
            // txt_table
            // 
            this.txt_table.Location = new System.Drawing.Point(1036, 158);
            this.txt_table.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_table.Name = "txt_table";
            this.txt_table.Size = new System.Drawing.Size(91, 31);
            this.txt_table.TabIndex = 14;
            this.txt_table.TextChanged += new System.EventHandler(this.txt_table_TextChanged);
            this.txt_table.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_table_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(504, 125);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(291, 24);
            this.label5.TabIndex = 13;
            this.label5.Text = "ID (will automatically update)";
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(508, 158);
            this.txt_ID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(403, 31);
            this.txt_ID.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(612, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 125);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "Award";
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(616, 75);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(600, 31);
            this.txt_Title.TabIndex = 3;
            this.txt_Title.TextChanged += new System.EventHandler(this.txt_Title_TextChanged);
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(265, 75);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(322, 31);
            this.txt_LastName.TabIndex = 2;
            this.txt_LastName.TextChanged += new System.EventHandler(this.txt_LastName_TextChanged);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(24, 75);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(216, 31);
            this.txt_FirstName.TabIndex = 1;
            this.txt_FirstName.TextChanged += new System.EventHandler(this.txt_FirstName_TextChanged);
            // 
            // cbo_Award
            // 
            this.cbo_Award.FormattingEnabled = true;
            this.cbo_Award.Location = new System.Drawing.Point(24, 157);
            this.cbo_Award.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Award.Name = "cbo_Award";
            this.cbo_Award.Size = new System.Drawing.Size(442, 32);
            this.cbo_Award.TabIndex = 4;
            this.cbo_Award.SelectedIndexChanged += new System.EventHandler(this.cbo_Award_SelectedIndexChanged);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(706, 294);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(118, 42);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Enabled = false;
            this.btn_Save.Location = new System.Drawing.Point(420, 294);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(156, 42);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save Edits";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // EditEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1326, 369);
            this.Controls.Add(this.group_AddAward);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.btn_Cancel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "EditEntryForm";
            this.Text = "Edit Selected Entry";
            this.Load += new System.EventHandler(this.EditEntryForm_Load);
            this.group_AddAward.ResumeLayout(false);
            this.group_AddAward.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox group_AddAward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Cancel;
        public System.Windows.Forms.TextBox txt_Title;
        public System.Windows.Forms.TextBox txt_LastName;
        public System.Windows.Forms.TextBox txt_FirstName;
        public System.Windows.Forms.ComboBox cbo_Award;
        public System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txt_table;
    }
}