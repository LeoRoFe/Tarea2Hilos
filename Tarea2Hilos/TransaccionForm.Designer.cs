namespace Tarea2Hilos
{
    partial class TransaccionForm
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
            this.B_AbrirArchivo = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CB_Trasmision = new System.Windows.Forms.ComboBox();
            this.CB_Transaccion = new System.Windows.Forms.ComboBox();
            this.Num_Monto = new System.Windows.Forms.NumericUpDown();
            this.CB_Marca = new System.Windows.Forms.ComboBox();
            this.B_AgregaTransaccion = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Num_Monto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // B_AbrirArchivo
            // 
            this.B_AbrirArchivo.Location = new System.Drawing.Point(472, 30);
            this.B_AbrirArchivo.Name = "B_AbrirArchivo";
            this.B_AbrirArchivo.Size = new System.Drawing.Size(172, 67);
            this.B_AbrirArchivo.TabIndex = 0;
            this.B_AbrirArchivo.Text = "Abrir Archivo";
            this.B_AbrirArchivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tipo de Transmisión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tipo de Transacción";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Monto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Marca";
            // 
            // CB_Trasmision
            // 
            this.CB_Trasmision.AutoCompleteCustomSource.AddRange(new string[] {
            "A",
            "M"});
            this.CB_Trasmision.FormattingEnabled = true;
            this.CB_Trasmision.Location = new System.Drawing.Point(218, 30);
            this.CB_Trasmision.Name = "CB_Trasmision";
            this.CB_Trasmision.Size = new System.Drawing.Size(121, 28);
            this.CB_Trasmision.TabIndex = 5;
            // 
            // CB_Transaccion
            // 
            this.CB_Transaccion.AutoCompleteCustomSource.AddRange(new string[] {
            "V",
            "C"});
            this.CB_Transaccion.FormattingEnabled = true;
            this.CB_Transaccion.Location = new System.Drawing.Point(218, 93);
            this.CB_Transaccion.Name = "CB_Transaccion";
            this.CB_Transaccion.Size = new System.Drawing.Size(121, 28);
            this.CB_Transaccion.TabIndex = 6;
            // 
            // Num_Monto
            // 
            this.Num_Monto.Location = new System.Drawing.Point(218, 164);
            this.Num_Monto.Name = "Num_Monto";
            this.Num_Monto.Size = new System.Drawing.Size(120, 26);
            this.Num_Monto.TabIndex = 7;
            // 
            // CB_Marca
            // 
            this.CB_Marca.AutoCompleteCustomSource.AddRange(new string[] {
            "Abarth",
            "Alfa Romeo",
            "Aston Martin",
            "Audi",
            "Bentley",
            "BMW",
            "Cadillac",
            "Caterham",
            "Chevrolet",
            "Citroen",
            "Dacia",
            "Ferrari",
            "Fiat",
            "Ford",
            "Honda",
            "Infiniti",
            "Isuzu",
            "Iveco",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lada",
            "Lamborghini",
            "Lancia",
            "Land Rover",
            "Lexus",
            "Lotus",
            "Maserati",
            "Mazda",
            "Opel",
            "Peugeot",
            "Piaggio",
            "Porsche",
            "Renault",
            "Rolls-Royce",
            "Seat",
            "Skoda",
            "Smart",
            "SsangYong",
            "Subaru",
            "Suzuki",
            "Tata",
            "Tesla",
            "Toyota",
            "Volkswagen",
            "Volvo"});
            this.CB_Marca.FormattingEnabled = true;
            this.CB_Marca.Location = new System.Drawing.Point(218, 234);
            this.CB_Marca.Name = "CB_Marca";
            this.CB_Marca.Size = new System.Drawing.Size(121, 28);
            this.CB_Marca.TabIndex = 8;
            // 
            // B_AgregaTransaccion
            // 
            this.B_AgregaTransaccion.Location = new System.Drawing.Point(27, 294);
            this.B_AgregaTransaccion.Name = "B_AgregaTransaccion";
            this.B_AgregaTransaccion.Size = new System.Drawing.Size(320, 67);
            this.B_AgregaTransaccion.TabIndex = 9;
            this.B_AgregaTransaccion.Text = "Añadir Transacción";
            this.B_AgregaTransaccion.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 148);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(723, 213);
            this.dataGridView1.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 530);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.B_AgregaTransaccion);
            this.Controls.Add(this.CB_Marca);
            this.Controls.Add(this.Num_Monto);
            this.Controls.Add(this.CB_Transaccion);
            this.Controls.Add(this.CB_Trasmision);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_AbrirArchivo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Num_Monto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_AbrirArchivo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CB_Trasmision;
        private System.Windows.Forms.ComboBox CB_Transaccion;
        private System.Windows.Forms.NumericUpDown Num_Monto;
        private System.Windows.Forms.ComboBox CB_Marca;
        private System.Windows.Forms.Button B_AgregaTransaccion;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

