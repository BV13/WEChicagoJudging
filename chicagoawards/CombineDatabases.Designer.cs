﻿namespace WE2017Awards
{
    partial class CombineDatabases
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
            this.lbx_CombineDatabases = new System.Windows.Forms.ListBox();
            this.btn_AddDBsToCombine = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Combine = new System.Windows.Forms.Button();
            this.btn_ClearList = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_BrowseToOutput = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbx_CombineDatabases
            // 
            this.lbx_CombineDatabases.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbx_CombineDatabases.FormattingEnabled = true;
            this.lbx_CombineDatabases.ItemHeight = 20;
            this.lbx_CombineDatabases.Location = new System.Drawing.Point(40, 113);
            this.lbx_CombineDatabases.Name = "lbx_CombineDatabases";
            this.lbx_CombineDatabases.Size = new System.Drawing.Size(1077, 302);
            this.lbx_CombineDatabases.TabIndex = 0;
            // 
            // btn_AddDBsToCombine
            // 
            this.btn_AddDBsToCombine.Location = new System.Drawing.Point(40, 48);
            this.btn_AddDBsToCombine.Name = "btn_AddDBsToCombine";
            this.btn_AddDBsToCombine.Size = new System.Drawing.Size(182, 41);
            this.btn_AddDBsToCombine.TabIndex = 1;
            this.btn_AddDBsToCombine.Text = "Select Databases";
            this.btn_AddDBsToCombine.UseVisualStyleBackColor = true;
            this.btn_AddDBsToCombine.Click += new System.EventHandler(this.btn_AddDBsToCombine_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Location = new System.Drawing.Point(99, 638);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(113, 40);
            this.btn_Cancel.TabIndex = 2;
            this.btn_Cancel.Text = "Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Combine
            // 
            this.btn_Combine.Location = new System.Drawing.Point(915, 638);
            this.btn_Combine.Name = "btn_Combine";
            this.btn_Combine.Size = new System.Drawing.Size(189, 40);
            this.btn_Combine.TabIndex = 3;
            this.btn_Combine.Text = "Combine Databases";
            this.btn_Combine.UseVisualStyleBackColor = true;
            // 
            // btn_ClearList
            // 
            this.btn_ClearList.BackColor = System.Drawing.Color.LightCoral;
            this.btn_ClearList.Location = new System.Drawing.Point(963, 48);
            this.btn_ClearList.Name = "btn_ClearList";
            this.btn_ClearList.Size = new System.Drawing.Size(154, 41);
            this.btn_ClearList.TabIndex = 4;
            this.btn_ClearList.Text = "Clear List";
            this.btn_ClearList.UseVisualStyleBackColor = false;
            this.btn_ClearList.Click += new System.EventHandler(this.btn_ClearList_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(40, 498);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(982, 44);
            this.textBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 472);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "output database file (program will automatically switch to this new combined db)";
            // 
            // btn_BrowseToOutput
            // 
            this.btn_BrowseToOutput.Location = new System.Drawing.Point(1028, 498);
            this.btn_BrowseToOutput.Name = "btn_BrowseToOutput";
            this.btn_BrowseToOutput.Size = new System.Drawing.Size(89, 44);
            this.btn_BrowseToOutput.TabIndex = 7;
            this.btn_BrowseToOutput.Text = "Browse";
            this.btn_BrowseToOutput.UseVisualStyleBackColor = true;
            // 
            // CombineDatabases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 720);
            this.Controls.Add(this.btn_BrowseToOutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_ClearList);
            this.Controls.Add(this.btn_Combine);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_AddDBsToCombine);
            this.Controls.Add(this.lbx_CombineDatabases);
            this.Name = "CombineDatabases";
            this.Text = "Combine Databases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbx_CombineDatabases;
        private System.Windows.Forms.Button btn_AddDBsToCombine;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_Combine;
        private System.Windows.Forms.Button btn_ClearList;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_BrowseToOutput;
    }
}