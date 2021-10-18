
namespace AppProducto.Formularios.Formularios_Inventario
{
    partial class FrmAgregarSalidas
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
            this.lblFechaSalida = new System.Windows.Forms.Label();
            this.dtpFechaSalida = new System.Windows.Forms.DateTimePicker();
            this.lblUnidadesUtilizadas = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nudUnidUtilizadas = new System.Windows.Forms.NumericUpDown();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudCostoU = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidUtilizadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoU)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFechaSalida
            // 
            this.lblFechaSalida.AutoSize = true;
            this.lblFechaSalida.Location = new System.Drawing.Point(73, 29);
            this.lblFechaSalida.Name = "lblFechaSalida";
            this.lblFechaSalida.Size = new System.Drawing.Size(40, 13);
            this.lblFechaSalida.TabIndex = 0;
            this.lblFechaSalida.Text = "Fecha:";
            // 
            // dtpFechaSalida
            // 
            this.dtpFechaSalida.CustomFormat = "dd/mm/yyyy";
            this.dtpFechaSalida.Location = new System.Drawing.Point(149, 22);
            this.dtpFechaSalida.Name = "dtpFechaSalida";
            this.dtpFechaSalida.Size = new System.Drawing.Size(226, 20);
            this.dtpFechaSalida.TabIndex = 2;
            // 
            // lblUnidadesUtilizadas
            // 
            this.lblUnidadesUtilizadas.AutoSize = true;
            this.lblUnidadesUtilizadas.Location = new System.Drawing.Point(25, 121);
            this.lblUnidadesUtilizadas.Name = "lblUnidadesUtilizadas";
            this.lblUnidadesUtilizadas.Size = new System.Drawing.Size(104, 13);
            this.lblUnidadesUtilizadas.TabIndex = 3;
            this.lblUnidadesUtilizadas.Text = "Unidades utilizadas: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudCostoU);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudUnidUtilizadas);
            this.groupBox1.Controls.Add(this.lblFechaSalida);
            this.groupBox1.Controls.Add(this.lblUnidadesUtilizadas);
            this.groupBox1.Controls.Add(this.dtpFechaSalida);
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(441, 165);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los datos";
            // 
            // nudUnidUtilizadas
            // 
            this.nudUnidUtilizadas.Location = new System.Drawing.Point(149, 119);
            this.nudUnidUtilizadas.Name = "nudUnidUtilizadas";
            this.nudUnidUtilizadas.Size = new System.Drawing.Size(226, 20);
            this.nudUnidUtilizadas.TabIndex = 4;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(76, 206);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 39);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(282, 206);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(78, 39);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Costo unitario:";
            // 
            // nudCostoU
            // 
            this.nudCostoU.DecimalPlaces = 2;
            this.nudCostoU.Location = new System.Drawing.Point(149, 75);
            this.nudCostoU.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCostoU.Name = "nudCostoU";
            this.nudCostoU.Size = new System.Drawing.Size(226, 20);
            this.nudCostoU.TabIndex = 6;
            this.nudCostoU.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FrmAgregarSalidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 290);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmAgregarSalidas";
            this.Text = "Salidas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudUnidUtilizadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudCostoU)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblFechaSalida;
        private System.Windows.Forms.DateTimePicker dtpFechaSalida;
        private System.Windows.Forms.Label lblUnidadesUtilizadas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown nudUnidUtilizadas;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.NumericUpDown nudCostoU;
        private System.Windows.Forms.Label label1;
    }
}