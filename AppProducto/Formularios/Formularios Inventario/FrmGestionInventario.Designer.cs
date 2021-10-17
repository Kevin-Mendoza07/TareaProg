
namespace AppProducto.Formularios.Formularios_Inventario
{
    partial class FrmGestionInventario
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
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.btnAgregarCompras = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregarSalida = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnCMatDisponible = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Location = new System.Drawing.Point(12, 108);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.Size = new System.Drawing.Size(398, 271);
            this.dgvInventario.TabIndex = 0;
            // 
            // btnAgregarCompras
            // 
            this.btnAgregarCompras.Location = new System.Drawing.Point(12, 56);
            this.btnAgregarCompras.Name = "btnAgregarCompras";
            this.btnAgregarCompras.Size = new System.Drawing.Size(111, 36);
            this.btnAgregarCompras.TabIndex = 1;
            this.btnAgregarCompras.Text = "Agregar compras";
            this.btnAgregarCompras.UseVisualStyleBackColor = true;
            this.btnAgregarCompras.Click += new System.EventHandler(this.btnAgregarCompras_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Inventario";
            // 
            // btnAgregarSalida
            // 
            this.btnAgregarSalida.Location = new System.Drawing.Point(425, 56);
            this.btnAgregarSalida.Name = "btnAgregarSalida";
            this.btnAgregarSalida.Size = new System.Drawing.Size(127, 36);
            this.btnAgregarSalida.TabIndex = 3;
            this.btnAgregarSalida.Text = "Agregar salida";
            this.btnAgregarSalida.UseVisualStyleBackColor = true;
            this.btnAgregarSalida.Click += new System.EventHandler(this.btnAgregarSalida_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(531, 396);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 43);
            this.button3.TabIndex = 4;
            this.button3.Text = "Costo Materiales Usados";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(425, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(100, 43);
            this.button4.TabIndex = 5;
            this.button4.Text = "Costo Inventario Final";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // btnCMatDisponible
            // 
            this.btnCMatDisponible.Location = new System.Drawing.Point(306, 396);
            this.btnCMatDisponible.Name = "btnCMatDisponible";
            this.btnCMatDisponible.Size = new System.Drawing.Size(113, 43);
            this.btnCMatDisponible.TabIndex = 6;
            this.btnCMatDisponible.Text = "Costo Materiales Disponibles";
            this.btnCMatDisponible.UseVisualStyleBackColor = true;
            this.btnCMatDisponible.Click += new System.EventHandler(this.btnCMatDisponible_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(293, 385);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 57);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculos";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.Location = new System.Drawing.Point(425, 108);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.Size = new System.Drawing.Size(401, 271);
            this.dgvSalidas.TabIndex = 8;
            // 
            // FrmGestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 451);
            this.Controls.Add(this.dgvSalidas);
            this.Controls.Add(this.btnCMatDisponible);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnAgregarSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarCompras);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGestionInventario";
            this.Text = "Gestion";
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.Button btnAgregarCompras;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregarSalida;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCMatDisponible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}