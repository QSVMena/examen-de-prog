namespace Examen_de_Programacion
{
    partial class Tabla
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
            this.textCuentas = new System.Windows.Forms.TextBox();
            this.btnAsignar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textColumna1 = new System.Windows.Forms.TextBox();
            this.textColumna2 = new System.Windows.Forms.TextBox();
            this.textColumna3 = new System.Windows.Forms.TextBox();
            this.Tablas = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSuma1 = new System.Windows.Forms.Button();
            this.btnResta1 = new System.Windows.Forms.Button();
            this.btnSuma2 = new System.Windows.Forms.Button();
            this.btnResta2 = new System.Windows.Forms.Button();
            this.textSuma1 = new System.Windows.Forms.TextBox();
            this.textResta1 = new System.Windows.Forms.TextBox();
            this.textSuma2 = new System.Windows.Forms.TextBox();
            this.textResta2 = new System.Windows.Forms.TextBox();
            this.btnsuma3 = new System.Windows.Forms.Button();
            this.btnResta3 = new System.Windows.Forms.Button();
            this.textSuma3 = new System.Windows.Forms.TextBox();
            this.textResta3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Tablas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cuentas";
            // 
            // textCuentas
            // 
            this.textCuentas.Location = new System.Drawing.Point(176, 26);
            this.textCuentas.Name = "textCuentas";
            this.textCuentas.Size = new System.Drawing.Size(333, 31);
            this.textCuentas.TabIndex = 1;
            this.textCuentas.Text = "t";
            // 
            // btnAsignar
            // 
            this.btnAsignar.Location = new System.Drawing.Point(186, 256);
            this.btnAsignar.Name = "btnAsignar";
            this.btnAsignar.Size = new System.Drawing.Size(112, 34);
            this.btnAsignar.TabIndex = 2;
            this.btnAsignar.Text = "Asignar";
            this.btnAsignar.UseVisualStyleBackColor = true;
            this.btnAsignar.Click += new System.EventHandler(this.btnAsignar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Columna3";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = " Columna2";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = " Columna1";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // textColumna1
            // 
            this.textColumna1.Location = new System.Drawing.Point(176, 79);
            this.textColumna1.Name = "textColumna1";
            this.textColumna1.Size = new System.Drawing.Size(150, 31);
            this.textColumna1.TabIndex = 6;
            // 
            // textColumna2
            // 
            this.textColumna2.Location = new System.Drawing.Point(176, 147);
            this.textColumna2.Name = "textColumna2";
            this.textColumna2.Size = new System.Drawing.Size(150, 31);
            this.textColumna2.TabIndex = 7;
            // 
            // textColumna3
            // 
            this.textColumna3.Location = new System.Drawing.Point(176, 204);
            this.textColumna3.Name = "textColumna3";
            this.textColumna3.Size = new System.Drawing.Size(150, 31);
            this.textColumna3.TabIndex = 8;
            // 
            // Tablas
            // 
            this.Tablas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Tablas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.Tablas.Location = new System.Drawing.Point(37, 345);
            this.Tablas.Name = "Tablas";
            this.Tablas.RowHeadersWidth = 62;
            this.Tablas.RowTemplate.Height = 33;
            this.Tablas.Size = new System.Drawing.Size(1164, 321);
            this.Tablas.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Descripcion";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.Width = 350;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "1";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "2";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.Width = 150;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "3";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Descrip Total";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Descripcion Neto";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // btnSuma1
            // 
            this.btnSuma1.Location = new System.Drawing.Point(378, 77);
            this.btnSuma1.Name = "btnSuma1";
            this.btnSuma1.Size = new System.Drawing.Size(112, 34);
            this.btnSuma1.TabIndex = 10;
            this.btnSuma1.Text = "Suma";
            this.btnSuma1.UseVisualStyleBackColor = true;
            this.btnSuma1.Click += new System.EventHandler(this.btnSumaTotal_Click);
            // 
            // btnResta1
            // 
            this.btnResta1.Location = new System.Drawing.Point(724, 79);
            this.btnResta1.Name = "btnResta1";
            this.btnResta1.Size = new System.Drawing.Size(112, 34);
            this.btnResta1.TabIndex = 11;
            this.btnResta1.Text = "Resta";
            this.btnResta1.UseVisualStyleBackColor = true;
            this.btnResta1.Click += new System.EventHandler(this.btnResta1_Click);
            // 
            // btnSuma2
            // 
            this.btnSuma2.Location = new System.Drawing.Point(378, 141);
            this.btnSuma2.Name = "btnSuma2";
            this.btnSuma2.Size = new System.Drawing.Size(112, 34);
            this.btnSuma2.TabIndex = 17;
            this.btnSuma2.Text = "Suma";
            this.btnSuma2.UseVisualStyleBackColor = true;
            this.btnSuma2.Click += new System.EventHandler(this.btnSuma2_Click);
            // 
            // btnResta2
            // 
            this.btnResta2.Location = new System.Drawing.Point(724, 150);
            this.btnResta2.Name = "btnResta2";
            this.btnResta2.Size = new System.Drawing.Size(112, 34);
            this.btnResta2.TabIndex = 18;
            this.btnResta2.Text = "Resta";
            this.btnResta2.UseVisualStyleBackColor = true;
            this.btnResta2.Click += new System.EventHandler(this.btnResta2_Click);
            // 
            // textSuma1
            // 
            this.textSuma1.Location = new System.Drawing.Point(534, 79);
            this.textSuma1.Name = "textSuma1";
            this.textSuma1.Size = new System.Drawing.Size(150, 31);
            this.textSuma1.TabIndex = 19;
            // 
            // textResta1
            // 
            this.textResta1.Location = new System.Drawing.Point(861, 82);
            this.textResta1.Name = "textResta1";
            this.textResta1.Size = new System.Drawing.Size(150, 31);
            this.textResta1.TabIndex = 20;
            // 
            // textSuma2
            // 
            this.textSuma2.Location = new System.Drawing.Point(534, 141);
            this.textSuma2.Name = "textSuma2";
            this.textSuma2.Size = new System.Drawing.Size(150, 31);
            this.textSuma2.TabIndex = 21;
            // 
            // textResta2
            // 
            this.textResta2.Location = new System.Drawing.Point(861, 141);
            this.textResta2.Name = "textResta2";
            this.textResta2.Size = new System.Drawing.Size(150, 31);
            this.textResta2.TabIndex = 22;
            // 
            // btnsuma3
            // 
            this.btnsuma3.Location = new System.Drawing.Point(378, 211);
            this.btnsuma3.Name = "btnsuma3";
            this.btnsuma3.Size = new System.Drawing.Size(112, 34);
            this.btnsuma3.TabIndex = 23;
            this.btnsuma3.Text = "Suma";
            this.btnsuma3.UseVisualStyleBackColor = true;
            this.btnsuma3.Click += new System.EventHandler(this.btnsuma3_Click);
            // 
            // btnResta3
            // 
            this.btnResta3.Location = new System.Drawing.Point(724, 216);
            this.btnResta3.Name = "btnResta3";
            this.btnResta3.Size = new System.Drawing.Size(112, 34);
            this.btnResta3.TabIndex = 24;
            this.btnResta3.Text = "Resta";
            this.btnResta3.UseVisualStyleBackColor = true;
            this.btnResta3.Click += new System.EventHandler(this.btnResta3_Click);
            // 
            // textSuma3
            // 
            this.textSuma3.Location = new System.Drawing.Point(534, 218);
            this.textSuma3.Name = "textSuma3";
            this.textSuma3.Size = new System.Drawing.Size(150, 31);
            this.textSuma3.TabIndex = 25;
            // 
            // textResta3
            // 
            this.textResta3.Location = new System.Drawing.Point(861, 219);
            this.textResta3.Name = "textResta3";
            this.textResta3.Size = new System.Drawing.Size(150, 31);
            this.textResta3.TabIndex = 26;
            // 
            // Tabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1316, 678);
            this.Controls.Add(this.textResta3);
            this.Controls.Add(this.textSuma3);
            this.Controls.Add(this.btnResta3);
            this.Controls.Add(this.btnsuma3);
            this.Controls.Add(this.textResta2);
            this.Controls.Add(this.textSuma2);
            this.Controls.Add(this.textResta1);
            this.Controls.Add(this.textSuma1);
            this.Controls.Add(this.btnResta2);
            this.Controls.Add(this.btnSuma2);
            this.Controls.Add(this.btnResta1);
            this.Controls.Add(this.btnSuma1);
            this.Controls.Add(this.Tablas);
            this.Controls.Add(this.textColumna3);
            this.Controls.Add(this.textColumna2);
            this.Controls.Add(this.textColumna1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAsignar);
            this.Controls.Add(this.textCuentas);
            this.Controls.Add(this.label1);
            this.Name = "Tabla";
            this.Text = "Estado de Resultado";
            this.Load += new System.EventHandler(this.Tabla_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Tablas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox textCuentas;
        private Button btnAsignar;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textColumna1;
        private TextBox textColumna2;
        private TextBox textColumna3;
        private DataGridView Tablas;
        private Button btnSuma1;
        private Button btnResta1;
        private Label label5;
        private Label label6;
        private TextBox textDescripTotal;
        private TextBox textDescripNeto;
        private Button btnSuma2;
        private Button btnResta2;
        private TextBox textSuma1;
        private TextBox textResta1;
        private TextBox textSuma2;
        private TextBox textResta2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button btnsuma3;
        private Button btnResta3;
        private TextBox textSuma3;
        private TextBox textResta3;
    }
}