namespace LinkedListWF
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.AddFirstBtn = new System.Windows.Forms.Button();
            this.AddLastBtn = new System.Windows.Forms.Button();
            this.AverifyBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.RemoveTxt = new System.Windows.Forms.TextBox();
            this.MoveLastTxt = new System.Windows.Forms.TextBox();
            this.VerifyTxt = new System.Windows.Forms.TextBox();
            this.Addtxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 269);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(257, 169);
            this.listBox1.TabIndex = 0;
            // 
            // AddFirstBtn
            // 
            this.AddFirstBtn.Location = new System.Drawing.Point(18, 52);
            this.AddFirstBtn.Name = "AddFirstBtn";
            this.AddFirstBtn.Size = new System.Drawing.Size(75, 23);
            this.AddFirstBtn.TabIndex = 1;
            this.AddFirstBtn.Text = "Add first";
            this.AddFirstBtn.UseVisualStyleBackColor = true;
            this.AddFirstBtn.Click += new System.EventHandler(this.AddFirstBtn_Click);
            // 
            // AddLastBtn
            // 
            this.AddLastBtn.Location = new System.Drawing.Point(20, 88);
            this.AddLastBtn.Name = "AddLastBtn";
            this.AddLastBtn.Size = new System.Drawing.Size(75, 23);
            this.AddLastBtn.TabIndex = 2;
            this.AddLastBtn.Text = "Add last";
            this.AddLastBtn.UseVisualStyleBackColor = true;
            this.AddLastBtn.Click += new System.EventHandler(this.AddLastBtn_Click);
            // 
            // AverifyBtn
            // 
            this.AverifyBtn.Location = new System.Drawing.Point(21, 127);
            this.AverifyBtn.Name = "AverifyBtn";
            this.AverifyBtn.Size = new System.Drawing.Size(75, 23);
            this.AverifyBtn.TabIndex = 3;
            this.AverifyBtn.Text = "Verify";
            this.AverifyBtn.UseVisualStyleBackColor = true;
            this.AverifyBtn.Click += new System.EventHandler(this.AverifyBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Location = new System.Drawing.Point(21, 211);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(75, 23);
            this.RemoveBtn.TabIndex = 4;
            this.RemoveBtn.Text = "Remove";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Move last";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // RemoveTxt
            // 
            this.RemoveTxt.Location = new System.Drawing.Point(124, 211);
            this.RemoveTxt.Name = "RemoveTxt";
            this.RemoveTxt.Size = new System.Drawing.Size(100, 23);
            this.RemoveTxt.TabIndex = 6;
            // 
            // MoveLastTxt
            // 
            this.MoveLastTxt.Location = new System.Drawing.Point(124, 170);
            this.MoveLastTxt.Name = "MoveLastTxt";
            this.MoveLastTxt.Size = new System.Drawing.Size(100, 23);
            this.MoveLastTxt.TabIndex = 7;
            // 
            // VerifyTxt
            // 
            this.VerifyTxt.Location = new System.Drawing.Point(124, 128);
            this.VerifyTxt.Name = "VerifyTxt";
            this.VerifyTxt.Size = new System.Drawing.Size(100, 23);
            this.VerifyTxt.TabIndex = 8;
            // 
            // Addtxt
            // 
            this.Addtxt.Location = new System.Drawing.Point(128, 76);
            this.Addtxt.Name = "Addtxt";
            this.Addtxt.Size = new System.Drawing.Size(100, 23);
            this.Addtxt.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(322, 450);
            this.Controls.Add(this.Addtxt);
            this.Controls.Add(this.VerifyTxt);
            this.Controls.Add(this.MoveLastTxt);
            this.Controls.Add(this.RemoveTxt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AverifyBtn);
            this.Controls.Add(this.AddLastBtn);
            this.Controls.Add(this.AddFirstBtn);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private Button AddFirstBtn;
        private Button AddLastBtn;
        private Button AverifyBtn;
        private Button RemoveBtn;
        private Button button1;
        private TextBox RemoveTxt;
        private TextBox MoveLastTxt;
        private TextBox VerifyTxt;
        private TextBox Addtxt;
    }
}