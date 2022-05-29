namespace PilasYColasWF
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.filaTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pilaTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.filaList = new System.Windows.Forms.ListBox();
            this.pilaList = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar a la fila";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(51, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Agregar a la pila";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guardar elementos en pilas o colas";
            // 
            // filaTxt
            // 
            this.filaTxt.Location = new System.Drawing.Point(183, 75);
            this.filaTxt.Name = "filaTxt";
            this.filaTxt.Size = new System.Drawing.Size(100, 23);
            this.filaTxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Fila";
            // 
            // pilaTxt
            // 
            this.pilaTxt.Location = new System.Drawing.Point(183, 123);
            this.pilaTxt.Name = "pilaTxt";
            this.pilaTxt.Size = new System.Drawing.Size(100, 23);
            this.pilaTxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pila";
            // 
            // filaList
            // 
            this.filaList.FormattingEnabled = true;
            this.filaList.ItemHeight = 15;
            this.filaList.Location = new System.Drawing.Point(51, 237);
            this.filaList.Name = "filaList";
            this.filaList.Size = new System.Drawing.Size(121, 154);
            this.filaList.TabIndex = 7;
            // 
            // pilaList
            // 
            this.pilaList.FormattingEnabled = true;
            this.pilaList.ItemHeight = 15;
            this.pilaList.Location = new System.Drawing.Point(219, 237);
            this.pilaList.Name = "pilaList";
            this.pilaList.Size = new System.Drawing.Size(120, 154);
            this.pilaList.TabIndex = 8;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(51, 397);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Eliminar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(231, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.pilaList);
            this.Controls.Add(this.filaList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pilaTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.filaTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Button button2;
        private Label label1;
        private TextBox filaTxt;
        private Label label2;
        private TextBox pilaTxt;
        private Label label3;
        private ListBox filaList;
        private ListBox pilaList;
        private Button button3;
        private Button button4;
    }
}