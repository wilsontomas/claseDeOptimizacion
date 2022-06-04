namespace EstructuraWF
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tituloTxt = new System.Windows.Forms.TextBox();
            this.autorTxt = new System.Windows.Forms.TextBox();
            this.editorialTxt = new System.Windows.Forms.TextBox();
            this.categoriaTxt = new System.Windows.Forms.TextBox();
            this.anioTxt = new System.Windows.Forms.TextBox();
            this.guardar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Editorial";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 250);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "Anio";
            // 
            // tituloTxt
            // 
            this.tituloTxt.Location = new System.Drawing.Point(118, 63);
            this.tituloTxt.Name = "tituloTxt";
            this.tituloTxt.Size = new System.Drawing.Size(100, 23);
            this.tituloTxt.TabIndex = 5;
            // 
            // autorTxt
            // 
            this.autorTxt.Location = new System.Drawing.Point(118, 107);
            this.autorTxt.Name = "autorTxt";
            this.autorTxt.Size = new System.Drawing.Size(100, 23);
            this.autorTxt.TabIndex = 6;
            // 
            // editorialTxt
            // 
            this.editorialTxt.Location = new System.Drawing.Point(118, 153);
            this.editorialTxt.Name = "editorialTxt";
            this.editorialTxt.Size = new System.Drawing.Size(100, 23);
            this.editorialTxt.TabIndex = 7;
            // 
            // categoriaTxt
            // 
            this.categoriaTxt.Location = new System.Drawing.Point(118, 204);
            this.categoriaTxt.Name = "categoriaTxt";
            this.categoriaTxt.Size = new System.Drawing.Size(100, 23);
            this.categoriaTxt.TabIndex = 8;
            // 
            // anioTxt
            // 
            this.anioTxt.Location = new System.Drawing.Point(118, 242);
            this.anioTxt.Name = "anioTxt";
            this.anioTxt.Size = new System.Drawing.Size(100, 23);
            this.anioTxt.TabIndex = 9;
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(85, 294);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(75, 23);
            this.guardar.TabIndex = 10;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(274, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(340, 254);
            this.dataGridView1.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 352);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guardar);
            this.Controls.Add(this.anioTxt);
            this.Controls.Add(this.categoriaTxt);
            this.Controls.Add(this.editorialTxt);
            this.Controls.Add(this.autorTxt);
            this.Controls.Add(this.tituloTxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Titulo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tituloTxt;
        private TextBox autorTxt;
        private TextBox editorialTxt;
        private TextBox categoriaTxt;
        private TextBox anioTxt;
        private Button guardar;
        private DataGridView dataGridView1;
    }
}