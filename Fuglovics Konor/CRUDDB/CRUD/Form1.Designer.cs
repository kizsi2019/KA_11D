namespace CRUD
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
            this.BTNCreate = new System.Windows.Forms.Button();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.BTNRead = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SQL2 = new System.Windows.Forms.Button();
            this.SQL3 = new System.Windows.Forms.Button();
            this.SQL4 = new System.Windows.Forms.Button();
            this.SQL7 = new System.Windows.Forms.Button();
            this.SQL6 = new System.Windows.Forms.Button();
            this.SQL5 = new System.Windows.Forms.Button();
            this.SQL8 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCreate
            // 
            this.BTNCreate.Location = new System.Drawing.Point(27, 22);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.Size = new System.Drawing.Size(108, 24);
            this.BTNCreate.TabIndex = 0;
            this.BTNCreate.Text = "Create table";
            this.BTNCreate.UseVisualStyleBackColor = true;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // BTNInsert
            // 
            this.BTNInsert.Location = new System.Drawing.Point(27, 52);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(108, 24);
            this.BTNInsert.TabIndex = 1;
            this.BTNInsert.Text = "Insert data in table";
            this.BTNInsert.UseVisualStyleBackColor = true;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // BTNRead
            // 
            this.BTNRead.Location = new System.Drawing.Point(27, 82);
            this.BTNRead.Name = "BTNRead";
            this.BTNRead.Size = new System.Drawing.Size(108, 24);
            this.BTNRead.TabIndex = 2;
            this.BTNRead.Text = "Read data from table";
            this.BTNRead.UseVisualStyleBackColor = true;
            this.BTNRead.Click += new System.EventHandler(this.BTNRead_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(27, 112);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(108, 24);
            this.BTNUpdate.TabIndex = 3;
            this.BTNUpdate.Text = "Update table";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(27, 142);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(108, 24);
            this.BTNDelete.TabIndex = 4;
            this.BTNDelete.Text = "Delete record";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(141, 24);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(96, 20);
            this.TB1.TabIndex = 5;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(141, 84);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(96, 20);
            this.TB3.TabIndex = 8;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(141, 54);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(96, 20);
            this.TB2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(141, 112);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(420, 328);
            this.dataGridView1.TabIndex = 10;
            // 
            // SQL2
            // 
            this.SQL2.Location = new System.Drawing.Point(243, 22);
            this.SQL2.Name = "SQL2";
            this.SQL2.Size = new System.Drawing.Size(31, 24);
            this.SQL2.TabIndex = 11;
            this.SQL2.Text = "2";
            this.SQL2.UseVisualStyleBackColor = true;
            this.SQL2.Click += new System.EventHandler(this.button1_Click);
            // 
            // SQL3
            // 
            this.SQL3.Location = new System.Drawing.Point(280, 22);
            this.SQL3.Name = "SQL3";
            this.SQL3.Size = new System.Drawing.Size(31, 24);
            this.SQL3.TabIndex = 12;
            this.SQL3.Text = "3";
            this.SQL3.UseVisualStyleBackColor = true;
            this.SQL3.Click += new System.EventHandler(this.button2_Click);
            // 
            // SQL4
            // 
            this.SQL4.Location = new System.Drawing.Point(317, 22);
            this.SQL4.Name = "SQL4";
            this.SQL4.Size = new System.Drawing.Size(31, 24);
            this.SQL4.TabIndex = 13;
            this.SQL4.Text = "4";
            this.SQL4.UseVisualStyleBackColor = true;
            this.SQL4.Click += new System.EventHandler(this.button3_Click);
            // 
            // SQL7
            // 
            this.SQL7.Location = new System.Drawing.Point(317, 52);
            this.SQL7.Name = "SQL7";
            this.SQL7.Size = new System.Drawing.Size(31, 24);
            this.SQL7.TabIndex = 16;
            this.SQL7.Text = "7";
            this.SQL7.UseVisualStyleBackColor = true;
            this.SQL7.Click += new System.EventHandler(this.SQL7_Click);
            // 
            // SQL6
            // 
            this.SQL6.Location = new System.Drawing.Point(280, 52);
            this.SQL6.Name = "SQL6";
            this.SQL6.Size = new System.Drawing.Size(31, 24);
            this.SQL6.TabIndex = 15;
            this.SQL6.Text = "6";
            this.SQL6.UseVisualStyleBackColor = true;
            this.SQL6.Click += new System.EventHandler(this.button5_Click);
            // 
            // SQL5
            // 
            this.SQL5.Location = new System.Drawing.Point(243, 52);
            this.SQL5.Name = "SQL5";
            this.SQL5.Size = new System.Drawing.Size(31, 24);
            this.SQL5.TabIndex = 14;
            this.SQL5.Text = "5";
            this.SQL5.UseVisualStyleBackColor = true;
            this.SQL5.Click += new System.EventHandler(this.button6_Click);
            // 
            // SQL8
            // 
            this.SQL8.Location = new System.Drawing.Point(354, 52);
            this.SQL8.Name = "SQL8";
            this.SQL8.Size = new System.Drawing.Size(31, 24);
            this.SQL8.TabIndex = 17;
            this.SQL8.Text = "8";
            this.SQL8.UseVisualStyleBackColor = true;
            this.SQL8.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 452);
            this.Controls.Add(this.SQL8);
            this.Controls.Add(this.SQL7);
            this.Controls.Add(this.SQL6);
            this.Controls.Add(this.SQL5);
            this.Controls.Add(this.SQL4);
            this.Controls.Add(this.SQL3);
            this.Controls.Add(this.SQL2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNRead);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.BTNCreate);
            this.Name = "Form1";
            this.Text = "Crud műveletek";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCreate;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.Button BTNRead;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SQL2;
        private System.Windows.Forms.Button SQL3;
        private System.Windows.Forms.Button SQL4;
        private System.Windows.Forms.Button SQL7;
        private System.Windows.Forms.Button SQL6;
        private System.Windows.Forms.Button SQL5;
        private System.Windows.Forms.Button SQL8;
    }
}

