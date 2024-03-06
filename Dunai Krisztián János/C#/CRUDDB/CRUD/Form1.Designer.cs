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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCreate
            // 
            this.BTNCreate.Location = new System.Drawing.Point(42, 42);
            this.BTNCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.Size = new System.Drawing.Size(162, 62);
            this.BTNCreate.TabIndex = 0;
            this.BTNCreate.Text = "Create table";
            this.BTNCreate.UseVisualStyleBackColor = true;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // BTNInsert
            // 
            this.BTNInsert.Location = new System.Drawing.Point(42, 160);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(162, 62);
            this.BTNInsert.TabIndex = 1;
            this.BTNInsert.Text = "Insert data in table";
            this.BTNInsert.UseVisualStyleBackColor = true;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // BTNRead
            // 
            this.BTNRead.Location = new System.Drawing.Point(42, 269);
            this.BTNRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNRead.Name = "BTNRead";
            this.BTNRead.Size = new System.Drawing.Size(162, 62);
            this.BTNRead.TabIndex = 2;
            this.BTNRead.Text = "Read data from table";
            this.BTNRead.UseVisualStyleBackColor = true;
            this.BTNRead.Click += new System.EventHandler(this.BTNRead_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.Location = new System.Drawing.Point(42, 369);
            this.BTNUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(162, 62);
            this.BTNUpdate.TabIndex = 3;
            this.BTNUpdate.Text = "Update table";
            this.BTNUpdate.UseVisualStyleBackColor = true;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.Location = new System.Drawing.Point(42, 477);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(162, 62);
            this.BTNDelete.TabIndex = 4;
            this.BTNDelete.Text = "Delete record";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // TB1
            // 
            this.TB1.Location = new System.Drawing.Point(309, 58);
            this.TB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(142, 26);
            this.TB1.TabIndex = 5;
            // 
            // TB3
            // 
            this.TB3.Location = new System.Drawing.Point(309, 286);
            this.TB3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(142, 26);
            this.TB3.TabIndex = 8;
            // 
            // TB2
            // 
            this.TB2.Location = new System.Drawing.Point(309, 177);
            this.TB2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(142, 26);
            this.TB2.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(568, 218);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(600, 426);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNRead);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.BTNCreate);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
    }
}

