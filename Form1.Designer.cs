namespace InsertionSort
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
            this.Nums = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.InsertNum = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Nums
            // 
            this.Nums.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Nums.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Nums.Cursor = System.Windows.Forms.Cursors.Default;
            this.Nums.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Nums.Font = new System.Drawing.Font("Yu Gothic", 20F, System.Drawing.FontStyle.Bold);
            this.Nums.ForeColor = System.Drawing.Color.Red;
            this.Nums.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Nums.Location = new System.Drawing.Point(696, 311);
            this.Nums.Name = "Nums";
            this.Nums.Size = new System.Drawing.Size(413, 93);
            this.Nums.TabIndex = 5;
            this.Nums.Text = "Enter the numbers you want to arrange";
            this.Nums.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Nums.UseMnemonic = false;
            this.Nums.Click += new System.EventHandler(this.Nums_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(696, 416);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 52);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(694, 478);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 41);
            this.label1.TabIndex = 7;
            this.label1.Text = "Numbers :  ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Blue;
            this.button1.Location = new System.Drawing.Point(701, 538);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(183, 99);
            this.button1.TabIndex = 9;
            this.button1.Text = "Ascending Order";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Tahoma", 16F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(926, 538);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(183, 99);
            this.button2.TabIndex = 10;
            this.button2.Text = "Descending Order";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // InsertNum
            // 
            this.InsertNum.Font = new System.Drawing.Font("Showcard Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.InsertNum.ForeColor = System.Drawing.Color.Blue;
            this.InsertNum.Location = new System.Drawing.Point(948, 416);
            this.InsertNum.Name = "InsertNum";
            this.InsertNum.Size = new System.Drawing.Size(161, 52);
            this.InsertNum.TabIndex = 11;
            this.InsertNum.Text = "Insert";
            this.InsertNum.UseVisualStyleBackColor = true;
            this.InsertNum.Click += new System.EventHandler(this.InsertNum_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1664, 848);
            this.Controls.Add(this.InsertNum);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Nums);
            this.Controls.Add(this.textBox1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Nums;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button InsertNum;
    }
}

