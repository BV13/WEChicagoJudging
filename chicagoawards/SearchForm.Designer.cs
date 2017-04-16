namespace WE2017Awards
{
    partial class SearchForm
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
            this.btn_Search = new System.Windows.Forms.Button();
            this.txt_Title = new System.Windows.Forms.TextBox();
            this.txt_LastName = new System.Windows.Forms.TextBox();
            this.txt_FirstName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.group_SearchForAward = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.dgv_SearchResults = new System.Windows.Forms.DataGridView();
            this.group_SearchForAward.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Search
            // 
            this.btn_Search.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Search.Location = new System.Drawing.Point(527, 649);
            this.btn_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(156, 42);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // txt_Title
            // 
            this.txt_Title.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Title.Location = new System.Drawing.Point(17, 202);
            this.txt_Title.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Title.Name = "txt_Title";
            this.txt_Title.Size = new System.Drawing.Size(710, 32);
            this.txt_Title.TabIndex = 8;
            // 
            // txt_LastName
            // 
            this.txt_LastName.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_LastName.Location = new System.Drawing.Point(405, 104);
            this.txt_LastName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_LastName.Name = "txt_LastName";
            this.txt_LastName.Size = new System.Drawing.Size(322, 32);
            this.txt_LastName.TabIndex = 7;
            // 
            // txt_FirstName
            // 
            this.txt_FirstName.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FirstName.Location = new System.Drawing.Point(17, 104);
            this.txt_FirstName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_FirstName.Name = "txt_FirstName";
            this.txt_FirstName.Size = new System.Drawing.Size(288, 32);
            this.txt_FirstName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(14, 75);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(402, 75);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 173);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Title";
            // 
            // group_SearchForAward
            // 
            this.group_SearchForAward.Controls.Add(this.label1);
            this.group_SearchForAward.Controls.Add(this.label4);
            this.group_SearchForAward.Controls.Add(this.label3);
            this.group_SearchForAward.Controls.Add(this.label2);
            this.group_SearchForAward.Controls.Add(this.txt_Title);
            this.group_SearchForAward.Controls.Add(this.txt_LastName);
            this.group_SearchForAward.Controls.Add(this.txt_FirstName);
            this.group_SearchForAward.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.group_SearchForAward.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.group_SearchForAward.Location = new System.Drawing.Point(346, 348);
            this.group_SearchForAward.Name = "group_SearchForAward";
            this.group_SearchForAward.Size = new System.Drawing.Size(747, 267);
            this.group_SearchForAward.TabIndex = 14;
            this.group_SearchForAward.TabStop = false;
            this.group_SearchForAward.Text = "Search for Award";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Enter any combination";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Font = new System.Drawing.Font("Book Antiqua", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Location = new System.Drawing.Point(733, 649);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(156, 42);
            this.btn_Cancel.TabIndex = 15;
            this.btn_Cancel.Text = "Exit";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // dgv_SearchResults
            // 
            this.dgv_SearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_SearchResults.GridColor = System.Drawing.SystemColors.Highlight;
            this.dgv_SearchResults.Location = new System.Drawing.Point(49, 30);
            this.dgv_SearchResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgv_SearchResults.Name = "dgv_SearchResults";
            this.dgv_SearchResults.Size = new System.Drawing.Size(1386, 287);
            this.dgv_SearchResults.TabIndex = 16;
            this.dgv_SearchResults.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SearchResults_CellContentClick);
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1522, 719);
            this.Controls.Add(this.dgv_SearchResults);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.group_SearchForAward);
            this.Controls.Add(this.btn_Search);
            this.Name = "SearchForm";
            this.Text = "Search";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.group_SearchForAward.ResumeLayout(false);
            this.group_SearchForAward.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SearchResults)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btn_Search;
        public System.Windows.Forms.TextBox txt_Title;
        public System.Windows.Forms.TextBox txt_LastName;
        public System.Windows.Forms.TextBox txt_FirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_SearchForAward;
        public System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_SearchResults;
    }
}