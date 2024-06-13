namespace CROOD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTNCreate = new System.Windows.Forms.Button();
            this.BTNInsert = new System.Windows.Forms.Button();
            this.BTNRead = new System.Windows.Forms.Button();
            this.BTNUpdate = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.TB2 = new System.Windows.Forms.TextBox();
            this.TB3 = new System.Windows.Forms.TextBox();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.TB1 = new System.Windows.Forms.TextBox();
            this.BTN8 = new System.Windows.Forms.Button();
            this.BTN2 = new System.Windows.Forms.Button();
            this.BTN3 = new System.Windows.Forms.Button();
            this.BTN4 = new System.Windows.Forms.Button();
            this.BTN5 = new System.Windows.Forms.Button();
            this.BTN6 = new System.Windows.Forms.Button();
            this.BTN7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNCreate
            // 
            this.BTNCreate.BackColor = System.Drawing.Color.SeaShell;
            this.BTNCreate.Location = new System.Drawing.Point(7, 6);
            this.BTNCreate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNCreate.Name = "BTNCreate";
            this.BTNCreate.Size = new System.Drawing.Size(75, 38);
            this.BTNCreate.TabIndex = 0;
            this.BTNCreate.Text = "Create Table";
            this.BTNCreate.UseVisualStyleBackColor = false;
            this.BTNCreate.Click += new System.EventHandler(this.BTNCreate_Click);
            // 
            // BTNInsert
            // 
            this.BTNInsert.BackColor = System.Drawing.Color.Snow;
            this.BTNInsert.Location = new System.Drawing.Point(7, 48);
            this.BTNInsert.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNInsert.Name = "BTNInsert";
            this.BTNInsert.Size = new System.Drawing.Size(75, 38);
            this.BTNInsert.TabIndex = 1;
            this.BTNInsert.Text = "Insert Data In Table";
            this.BTNInsert.UseVisualStyleBackColor = false;
            this.BTNInsert.Click += new System.EventHandler(this.BTNInsert_Click);
            // 
            // BTNRead
            // 
            this.BTNRead.BackColor = System.Drawing.Color.Snow;
            this.BTNRead.Location = new System.Drawing.Point(7, 89);
            this.BTNRead.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNRead.Name = "BTNRead";
            this.BTNRead.Size = new System.Drawing.Size(75, 38);
            this.BTNRead.TabIndex = 2;
            this.BTNRead.Text = "Read Data From Table";
            this.BTNRead.UseVisualStyleBackColor = false;
            this.BTNRead.Click += new System.EventHandler(this.BTNRead_Click);
            // 
            // BTNUpdate
            // 
            this.BTNUpdate.BackColor = System.Drawing.Color.Snow;
            this.BTNUpdate.Location = new System.Drawing.Point(7, 130);
            this.BTNUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNUpdate.Name = "BTNUpdate";
            this.BTNUpdate.Size = new System.Drawing.Size(75, 38);
            this.BTNUpdate.TabIndex = 3;
            this.BTNUpdate.Text = "Update Table";
            this.BTNUpdate.UseVisualStyleBackColor = false;
            this.BTNUpdate.Click += new System.EventHandler(this.BTNUpdate_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.BackColor = System.Drawing.Color.Snow;
            this.BTNDelete.Location = new System.Drawing.Point(7, 171);
            this.BTNDelete.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(75, 38);
            this.BTNDelete.TabIndex = 4;
            this.BTNDelete.Text = "Delete Record";
            this.BTNDelete.UseVisualStyleBackColor = false;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // TB2
            // 
            this.TB2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB2.Location = new System.Drawing.Point(109, 59);
            this.TB2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB2.Name = "TB2";
            this.TB2.Size = new System.Drawing.Size(128, 20);
            this.TB2.TabIndex = 6;
            // 
            // TB3
            // 
            this.TB3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB3.Location = new System.Drawing.Point(109, 100);
            this.TB3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB3.Name = "TB3";
            this.TB3.Size = new System.Drawing.Size(128, 20);
            this.TB3.TabIndex = 7;
            // 
            // DGV
            // 
            this.DGV.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Location = new System.Drawing.Point(244, 65);
            this.DGV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DGV.Name = "DGV";
            this.DGV.RowHeadersWidth = 72;
            this.DGV.RowTemplate.Height = 31;
            this.DGV.Size = new System.Drawing.Size(357, 291);
            this.DGV.TabIndex = 8;
            // 
            // TB1
            // 
            this.TB1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TB1.Location = new System.Drawing.Point(109, 22);
            this.TB1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TB1.Name = "TB1";
            this.TB1.Size = new System.Drawing.Size(128, 20);
            this.TB1.TabIndex = 9;
            // 
            // BTN8
            // 
            this.BTN8.BackColor = System.Drawing.Color.LightCyan;
            this.BTN8.Location = new System.Drawing.Point(448, 6);
            this.BTN8.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN8.Name = "BTN8";
            this.BTN8.Size = new System.Drawing.Size(29, 21);
            this.BTN8.TabIndex = 10;
            this.BTN8.Text = "8";
            this.BTN8.UseVisualStyleBackColor = false;
            this.BTN8.Click += new System.EventHandler(this.button1_Click);
            // 
            // BTN2
            // 
            this.BTN2.BackColor = System.Drawing.Color.LightCyan;
            this.BTN2.Location = new System.Drawing.Point(255, 6);
            this.BTN2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN2.Name = "BTN2";
            this.BTN2.Size = new System.Drawing.Size(29, 21);
            this.BTN2.TabIndex = 11;
            this.BTN2.Text = "2";
            this.BTN2.UseVisualStyleBackColor = false;
            this.BTN2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BTN3
            // 
            this.BTN3.BackColor = System.Drawing.Color.LightCyan;
            this.BTN3.Location = new System.Drawing.Point(287, 6);
            this.BTN3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN3.Name = "BTN3";
            this.BTN3.Size = new System.Drawing.Size(29, 21);
            this.BTN3.TabIndex = 12;
            this.BTN3.Text = "3";
            this.BTN3.UseVisualStyleBackColor = false;
            this.BTN3.Click += new System.EventHandler(this.button3_Click);
            // 
            // BTN4
            // 
            this.BTN4.BackColor = System.Drawing.Color.LightCyan;
            this.BTN4.Location = new System.Drawing.Point(319, 6);
            this.BTN4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN4.Name = "BTN4";
            this.BTN4.Size = new System.Drawing.Size(29, 21);
            this.BTN4.TabIndex = 13;
            this.BTN4.Text = "4";
            this.BTN4.UseVisualStyleBackColor = false;
            this.BTN4.Click += new System.EventHandler(this.button4_Click);
            // 
            // BTN5
            // 
            this.BTN5.BackColor = System.Drawing.Color.LightCyan;
            this.BTN5.Location = new System.Drawing.Point(351, 6);
            this.BTN5.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN5.Name = "BTN5";
            this.BTN5.Size = new System.Drawing.Size(29, 21);
            this.BTN5.TabIndex = 14;
            this.BTN5.Text = "5";
            this.BTN5.UseVisualStyleBackColor = false;
            this.BTN5.Click += new System.EventHandler(this.button5_Click);
            // 
            // BTN6
            // 
            this.BTN6.BackColor = System.Drawing.Color.LightCyan;
            this.BTN6.Location = new System.Drawing.Point(383, 6);
            this.BTN6.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN6.Name = "BTN6";
            this.BTN6.Size = new System.Drawing.Size(29, 21);
            this.BTN6.TabIndex = 15;
            this.BTN6.Text = "6";
            this.BTN6.UseVisualStyleBackColor = false;
            this.BTN6.Click += new System.EventHandler(this.button6_Click);
            // 
            // BTN7
            // 
            this.BTN7.BackColor = System.Drawing.Color.LightCyan;
            this.BTN7.Location = new System.Drawing.Point(416, 6);
            this.BTN7.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BTN7.Name = "BTN7";
            this.BTN7.Size = new System.Drawing.Size(29, 21);
            this.BTN7.TabIndex = 16;
            this.BTN7.Text = "7";
            this.BTN7.UseVisualStyleBackColor = false;
            this.BTN7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(608, 363);
            this.Controls.Add(this.BTN7);
            this.Controls.Add(this.BTN6);
            this.Controls.Add(this.BTN5);
            this.Controls.Add(this.BTN4);
            this.Controls.Add(this.BTN3);
            this.Controls.Add(this.BTN2);
            this.Controls.Add(this.BTN8);
            this.Controls.Add(this.TB1);
            this.Controls.Add(this.DGV);
            this.Controls.Add(this.TB3);
            this.Controls.Add(this.TB2);
            this.Controls.Add(this.BTNDelete);
            this.Controls.Add(this.BTNUpdate);
            this.Controls.Add(this.BTNRead);
            this.Controls.Add(this.BTNInsert);
            this.Controls.Add(this.BTNCreate);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Toolbox";
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNCreate;
        private System.Windows.Forms.Button BTNInsert;
        private System.Windows.Forms.Button BTNRead;
        private System.Windows.Forms.Button BTNUpdate;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.TextBox TB2;
        private System.Windows.Forms.TextBox TB3;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.TextBox TB1;
        private System.Windows.Forms.Button BTN8;
        private System.Windows.Forms.Button BTN2;
        private System.Windows.Forms.Button BTN3;
        private System.Windows.Forms.Button BTN4;
        private System.Windows.Forms.Button BTN5;
        private System.Windows.Forms.Button BTN6;
        private System.Windows.Forms.Button BTN7;
    }
}

