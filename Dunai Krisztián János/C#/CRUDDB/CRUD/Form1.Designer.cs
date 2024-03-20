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
            this.btn8 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCreate
            // 
            this.BTNCreate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTNCreate.Location = new System.Drawing.Point(42, 42);
            this.BTNCreate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.Size = new System.Drawing.Size(162, 62);
            this.BTNCreate.TabIndex = 0;
            this.BTNCreate.Text = "Create table";
            this.BTNCreate.UseVisualStyleBackColor = false;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // BTNInsert
            // 
            this.BTNInsert.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTNInsert.Location = new System.Drawing.Point(42, 160);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(162, 62);
            this.BTNInsert.TabIndex = 1;
            this.BTNInsert.Text = "Insert data in table";
            this.BTNInsert.UseVisualStyleBackColor = false;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // BTNRead
            // 
            this.BTNRead.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTNRead.Location = new System.Drawing.Point(42, 269);
            this.BTNRead.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNRead.Name = "BTNRead";
            this.BTNRead.Size = new System.Drawing.Size(162, 62);
            this.BTNRead.TabIndex = 2;
            this.BTNRead.Text = "Read data from table";
            this.BTNRead.UseVisualStyleBackColor = false;
            this.BTNRead.Click += new System.EventHandler(this.BTNRead_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTNUpdate.Location = new System.Drawing.Point(42, 369);
            this.BTNUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(162, 62);
            this.BTNUpdate.TabIndex = 3;
            this.BTNUpdate.Text = "Update table";
            this.BTNUpdate.UseVisualStyleBackColor = false;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BTNDelete.Location = new System.Drawing.Point(42, 477);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(162, 62);
            this.BTNDelete.TabIndex = 4;
            this.BTNDelete.Text = "Delete record";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TB1.Location = new System.Drawing.Point(309, 58);
            this.TB1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(142, 26);
            this.TB1.TabIndex = 5;
            // 
            // TB3
            // 
            this.TB3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.TB3.Location = new System.Drawing.Point(309, 286);
            this.TB3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(142, 26);
            this.TB3.TabIndex = 8;
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.SystemColors.MenuBar;
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
            // btn8
            // 
            this.btn8.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn8.Location = new System.Drawing.Point(1096, 58);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(72, 48);
            this.btn8.TabIndex = 11;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = false;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn2.Location = new System.Drawing.Point(568, 58);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(83, 46);
            this.btn2.TabIndex = 12;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn3.Location = new System.Drawing.Point(658, 58);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(86, 47);
            this.btn3.TabIndex = 13;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn4.Location = new System.Drawing.Point(750, 58);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(82, 47);
            this.btn4.TabIndex = 14;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn5.Location = new System.Drawing.Point(838, 58);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(81, 47);
            this.btn5.TabIndex = 15;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn6.Location = new System.Drawing.Point(925, 59);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(80, 46);
            this.btn6.TabIndex = 16;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = false;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btn7
            // 
            this.btn7.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btn7.Location = new System.Drawing.Point(1011, 58);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(79, 46);
            this.btn7.TabIndex = 17;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = false;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn8);
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
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
    }
}

