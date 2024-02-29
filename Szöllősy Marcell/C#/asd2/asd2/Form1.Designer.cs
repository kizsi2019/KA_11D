namespace asd2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnCreate = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            btnInsert = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(183, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox4
            // 
            textBox2.Location = new Point(183, 131);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // textBox5
            // 
            textBox3.Location = new Point(183, 78);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 3;
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(30, 27);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(75, 44);
            btnCreate.TabIndex = 5;
            btnCreate.Text = "Create Table";
            btnCreate.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(30, 242);
            button2.Name = "button2";
            button2.Size = new Size(75, 59);
            button2.TabIndex = 6;
            button2.Text = "Delete Record";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(30, 183);
            button3.Name = "button3";
            button3.Size = new Size(75, 53);
            button3.TabIndex = 7;
            button3.Text = "Update Table";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(30, 130);
            button4.Name = "button4";
            button4.Size = new Size(75, 47);
            button4.TabIndex = 8;
            button4.Text = "Read data from table";
            button4.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(30, 77);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(75, 47);
            btnInsert.TabIndex = 9;
            btnInsert.Text = "Insert data in Table";
            btnInsert.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 450);
            Controls.Add(btnInsert);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnCreate);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button btnCreate;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button btnInsert;
    }
}
