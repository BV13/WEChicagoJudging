namespace WE2017Awards
{
    partial class Form1
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
            this.dgv_awards = new System.Windows.Forms.DataGridView();
            this.cbo_Award = new System.Windows.Forms.ComboBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.group_AddAward = new System.Windows.Forms.GroupBox();
            this.btn_OpenSearchForm = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_ResetFields = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_GeneratePresentation = new System.Windows.Forms.Button();
            this.btn_GenerateReport = new System.Windows.Forms.Button();
            this.lbl_Message = new System.Windows.Forms.Label();
            this.btn_GeneratePhotoList = new System.Windows.Forms.Button();
            this.btn_GenerateAwardsHTML = new System.Windows.Forms.Button();
            this.btn_GenerateAwardCounts = new System.Windows.Forms.Button();
            this.btn_outputPriorities = new System.Windows.Forms.Button();
            this.lbl_DB = new System.Windows.Forms.Label();
            this.lbl_database = new System.Windows.Forms.Label();
            this.btn_combineDBs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_awards)).BeginInit();
            this.group_AddAward.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_awards
            // 
            this.dgv_awards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_awards.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_awards.Location = new System.Drawing.Point(42, 82);
            this.dgv_awards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_awards.Name = "dgv_awards";
            this.dgv_awards.Size = new System.Drawing.Size(1386, 417);
            this.dgv_awards.TabIndex = 5;
            this.dgv_awards.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_awards_CellContentClick);
            // 
            // cbo_Award
            // 
            this.cbo_Award.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cbo_Award.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbo_Award.FormattingEnabled = true;
            this.cbo_Award.Location = new System.Drawing.Point(24, 157);
            this.cbo_Award.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Award.Name = "cbo_Award";
            this.cbo_Award.Size = new System.Drawing.Size(442, 32);
            this.cbo_Award.TabIndex = 4;
            this.cbo_Award.SelectedIndexChanged += new System.EventHandler(this.cbo_Award_SelectedIndexChanged);
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Location = new System.Drawing.Point(24, 75);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(216, 31);
            this.txt_FirstName.TabIndex = 1;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Location = new System.Drawing.Point(302, 74);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(322, 31);
            this.txt_LastName.TabIndex = 2;
            // 
            // txt_Title
            // 
            this.txt_Title.Location = new System.Drawing.Point(666, 74);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(600, 31);
            this.txt_Title.TabIndex = 3;
            // 
            // group_AddAward
            // 
            this.group_AddAward.Controls.Add(this.btn_OpenSearchForm);
            this.group_AddAward.Controls.Add(this.btn_Save);
            this.group_AddAward.Controls.Add(this.btn_ResetFields);
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
            this.group_AddAward.Location = new System.Drawing.Point(42, 508);
            this.group_AddAward.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_AddAward.Name = "group_AddAward";
            this.group_AddAward.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.group_AddAward.Size = new System.Drawing.Size(1386, 220);
            this.group_AddAward.TabIndex = 7;
            this.group_AddAward.TabStop = false;
            this.group_AddAward.Text = "Add Award";
            // 
            // btn_OpenSearchForm
            // 
            this.btn_OpenSearchForm.Location = new System.Drawing.Point(915, 157);
            this.btn_OpenSearchForm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_OpenSearchForm.Name = "btn_OpenSearchForm";
            this.btn_OpenSearchForm.Size = new System.Drawing.Size(185, 42);
            this.btn_OpenSearchForm.TabIndex = 12;
            this.btn_OpenSearchForm.Text = "Search Awards";
            this.btn_OpenSearchForm.UseVisualStyleBackColor = true;
            this.btn_OpenSearchForm.Click += new System.EventHandler(this.btn_OpenSearchForm_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(524, 155);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(156, 42);
            this.btn_Save.TabIndex = 5;
            this.btn_Save.Text = "Save Entry";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_ResetFields
            // 
            this.btn_ResetFields.Location = new System.Drawing.Point(729, 157);
            this.btn_ResetFields.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_ResetFields.Name = "btn_ResetFields";
            this.btn_ResetFields.Size = new System.Drawing.Size(154, 42);
            this.btn_ResetFields.TabIndex = 11;
            this.btn_ResetFields.Text = "Reset Fields";
            this.btn_ResetFields.UseVisualStyleBackColor = true;
            this.btn_ResetFields.Click += new System.EventHandler(this.btn_ResetFields_Click);
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
            this.label3.Location = new System.Drawing.Point(297, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(666, 42);
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
            // txt_Year
            // 
            this.txt_Year.Enabled = false;
            this.txt_Year.Font = new System.Drawing.Font("Book Antiqua", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Year.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txt_Year.Location = new System.Drawing.Point(50, 14);
            this.txt_Year.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(19, 35);
            this.txt_Year.TabIndex = 4;
            this.txt_Year.Visible = false;
            this.txt_Year.LostFocus += new System.EventHandler(this.txt_Year_LostFocus);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Enabled = false;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(46, 46);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Show Year";
            this.label5.Visible = false;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_Exit.Location = new System.Drawing.Point(1321, 777);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(81, 42);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_GeneratePresentation
            // 
            this.btn_GeneratePresentation.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GeneratePresentation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GeneratePresentation.Location = new System.Drawing.Point(729, 777);
            this.btn_GeneratePresentation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GeneratePresentation.Name = "btn_GeneratePresentation";
            this.btn_GeneratePresentation.Size = new System.Drawing.Size(276, 42);
            this.btn_GeneratePresentation.TabIndex = 14;
            this.btn_GeneratePresentation.Text = "Create Awards Presentation";
            this.btn_GeneratePresentation.UseVisualStyleBackColor = true;
            this.btn_GeneratePresentation.Click += new System.EventHandler(this.btn_GeneratePresentation_Click);
            // 
            // btn_GenerateReport
            // 
            this.btn_GenerateReport.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateReport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GenerateReport.Location = new System.Drawing.Point(26, 777);
            this.btn_GenerateReport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GenerateReport.Name = "btn_GenerateReport";
            this.btn_GenerateReport.Size = new System.Drawing.Size(190, 42);
            this.btn_GenerateReport.TabIndex = 15;
            this.btn_GenerateReport.Text = "Save Awards List";
            this.btn_GenerateReport.UseVisualStyleBackColor = true;
            this.btn_GenerateReport.Click += new System.EventHandler(this.btn_GenerateReport_Click);
            // 
            // lbl_Message
            // 
            this.lbl_Message.AutoSize = true;
            this.lbl_Message.Font = new System.Drawing.Font("Book Antiqua", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.lbl_Message.Location = new System.Drawing.Point(660, 34);
            this.lbl_Message.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Message.Name = "lbl_Message";
            this.lbl_Message.Size = new System.Drawing.Size(0, 35);
            this.lbl_Message.TabIndex = 16;
            this.lbl_Message.Visible = false;
            // 
            // btn_GeneratePhotoList
            // 
            this.btn_GeneratePhotoList.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GeneratePhotoList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GeneratePhotoList.Location = new System.Drawing.Point(260, 777);
            this.btn_GeneratePhotoList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GeneratePhotoList.Name = "btn_GeneratePhotoList";
            this.btn_GeneratePhotoList.Size = new System.Drawing.Size(164, 42);
            this.btn_GeneratePhotoList.TabIndex = 17;
            this.btn_GeneratePhotoList.Text = "Save Photo List";
            this.btn_GeneratePhotoList.UseVisualStyleBackColor = true;
            this.btn_GeneratePhotoList.Click += new System.EventHandler(this.btn_GeneratePhotoList_Click);
            // 
            // btn_GenerateAwardsHTML
            // 
            this.btn_GenerateAwardsHTML.Enabled = false;
            this.btn_GenerateAwardsHTML.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateAwardsHTML.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GenerateAwardsHTML.Location = new System.Drawing.Point(1036, 777);
            this.btn_GenerateAwardsHTML.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GenerateAwardsHTML.Name = "btn_GenerateAwardsHTML";
            this.btn_GenerateAwardsHTML.Size = new System.Drawing.Size(226, 42);
            this.btn_GenerateAwardsHTML.TabIndex = 18;
            this.btn_GenerateAwardsHTML.Text = "Create Awards HTML";
            this.btn_GenerateAwardsHTML.UseVisualStyleBackColor = true;
            // 
            // btn_GenerateAwardCounts
            // 
            this.btn_GenerateAwardCounts.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GenerateAwardCounts.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_GenerateAwardCounts.Location = new System.Drawing.Point(480, 777);
            this.btn_GenerateAwardCounts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_GenerateAwardCounts.Name = "btn_GenerateAwardCounts";
            this.btn_GenerateAwardCounts.Size = new System.Drawing.Size(201, 42);
            this.btn_GenerateAwardCounts.TabIndex = 19;
            this.btn_GenerateAwardCounts.Text = "Save Award Counts";
            this.btn_GenerateAwardCounts.UseVisualStyleBackColor = true;
            this.btn_GenerateAwardCounts.Click += new System.EventHandler(this.btn_GenerateAwardCounts_Click);
            // 
            // btn_outputPriorities
            // 
            this.btn_outputPriorities.Location = new System.Drawing.Point(1269, 738);
            this.btn_outputPriorities.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_outputPriorities.Name = "btn_outputPriorities";
            this.btn_outputPriorities.Size = new System.Drawing.Size(39, 34);
            this.btn_outputPriorities.TabIndex = 20;
            this.btn_outputPriorities.Text = "output priorities";
            this.btn_outputPriorities.UseVisualStyleBackColor = true;
            this.btn_outputPriorities.Visible = false;
            this.btn_outputPriorities.Click += new System.EventHandler(this.btn_outputPriorities_Click);
            // 
            // lbl_DB
            // 
            this.lbl_DB.AutoSize = true;
            this.lbl_DB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DB.ForeColor = System.Drawing.Color.BlueViolet;
            this.lbl_DB.Location = new System.Drawing.Point(206, 53);
            this.lbl_DB.Name = "lbl_DB";
            this.lbl_DB.Size = new System.Drawing.Size(0, 22);
            this.lbl_DB.TabIndex = 21;
            // 
            // lbl_database
            // 
            this.lbl_database.AutoSize = true;
            this.lbl_database.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_database.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lbl_database.Location = new System.Drawing.Point(130, 46);
            this.lbl_database.Name = "lbl_database";
            this.lbl_database.Size = new System.Drawing.Size(97, 22);
            this.lbl_database.TabIndex = 22;
            this.lbl_database.Text = "Database: ";
            // 
            // btn_combineDBs
            // 
            this.btn_combineDBs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_combineDBs.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_combineDBs.Location = new System.Drawing.Point(1269, 34);
            this.btn_combineDBs.Name = "btn_combineDBs";
            this.btn_combineDBs.Size = new System.Drawing.Size(159, 33);
            this.btn_combineDBs.TabIndex = 23;
            this.btn_combineDBs.Text = "Combine db Files";
            this.btn_combineDBs.UseVisualStyleBackColor = true;
            this.btn_combineDBs.Click += new System.EventHandler(this.btn_combineDBs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1489, 894);
            this.Controls.Add(this.btn_combineDBs);
            this.Controls.Add(this.lbl_database);
            this.Controls.Add(this.lbl_DB);
            this.Controls.Add(this.btn_outputPriorities);
            this.Controls.Add(this.btn_GenerateAwardCounts);
            this.Controls.Add(this.btn_GenerateAwardsHTML);
            this.Controls.Add(this.btn_GeneratePhotoList);
            this.Controls.Add(this.lbl_Message);
            this.Controls.Add(this.btn_GenerateReport);
            this.Controls.Add(this.btn_GeneratePresentation);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.group_AddAward);
            this.Controls.Add(this.dgv_awards);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MMSI Awards";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_awards)).EndInit();
            this.group_AddAward.ResumeLayout(false);
            this.group_AddAward.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbo_Award;
        private System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.TextBox txt_LastName;
        private System.Windows.Forms.TextBox txt_Title;
        private System.Windows.Forms.GroupBox group_AddAward;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_ResetFields;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_GeneratePresentation;
        private System.Windows.Forms.Button btn_GenerateReport;
        private System.Windows.Forms.Label lbl_Message;
        private System.Windows.Forms.Button btn_GeneratePhotoList;
        private System.Windows.Forms.Button btn_GenerateAwardsHTML;
        private System.Windows.Forms.Button btn_GenerateAwardCounts;
        private System.Windows.Forms.DataGridView dgv_awards;
        private System.Windows.Forms.Button btn_outputPriorities;
        private System.Windows.Forms.Button btn_OpenSearchForm;
        private System.Windows.Forms.Label lbl_DB;
        private System.Windows.Forms.Label lbl_database;
        private System.Windows.Forms.Button btn_combineDBs;
    }
}

