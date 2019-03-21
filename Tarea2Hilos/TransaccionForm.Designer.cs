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
            this.DGV_Automaticos = new System.Windows.Forms.DataGridView();
            this.DGV_Manuales = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DGV_Cola = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Automaticos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Manuales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cola)).BeginInit();
            this.SuspendLayout();
            // 
            // B_AbrirArchivo
            // 
            this.B_AbrirArchivo.Location = new System.Drawing.Point(22, 12);
            this.B_AbrirArchivo.Name = "B_AbrirArchivo";
            this.B_AbrirArchivo.Size = new System.Drawing.Size(172, 67);
            this.B_AbrirArchivo.TabIndex = 0;
            this.B_AbrirArchivo.Text = "Abrir Archivo Precargado";
            this.B_AbrirArchivo.UseVisualStyleBackColor = true;
            this.B_AbrirArchivo.Click += new System.EventHandler(this.B_AbrirArchivo_Click);
            // 
            // DGV_Automaticos
            // 
            this.DGV_Automaticos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Automaticos.Location = new System.Drawing.Point(22, 148);
            this.DGV_Automaticos.Name = "DGV_Automaticos";
            this.DGV_Automaticos.RowTemplate.Height = 28;
            this.DGV_Automaticos.Size = new System.Drawing.Size(584, 213);
            this.DGV_Automaticos.TabIndex = 10;
            // 
            // DGV_Manuales
            // 
            this.DGV_Manuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Manuales.Location = new System.Drawing.Point(667, 148);
            this.DGV_Manuales.Name = "DGV_Manuales";
            this.DGV_Manuales.RowTemplate.Height = 28;
            this.DGV_Manuales.Size = new System.Drawing.Size(569, 213);
            this.DGV_Manuales.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(188, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Automóviles Automáticos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(842, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(168, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Automóviles Manuales";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Cola de Transacciones";
            // 
            // DGV_Cola
            // 
            this.DGV_Cola.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Cola.Location = new System.Drawing.Point(22, 411);
            this.DGV_Cola.Name = "DGV_Cola";
            this.DGV_Cola.RowTemplate.Height = 28;
            this.DGV_Cola.Size = new System.Drawing.Size(704, 213);
            this.DGV_Cola.TabIndex = 15;
            // 
            // TransaccionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 636);
            this.Controls.Add(this.DGV_Cola);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DGV_Manuales);
            this.Controls.Add(this.DGV_Automaticos);
            this.Controls.Add(this.B_AbrirArchivo);
            this.Name = "TransaccionForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Automaticos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Manuales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Cola)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button B_AbrirArchivo;
        private System.Windows.Forms.DataGridView DGV_Automaticos;
        private System.Windows.Forms.DataGridView DGV_Manuales;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DGV_Cola;
    }
}

