
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
            this.btnCstMatUsados = new System.Windows.Forms.Button();
            this.btnCstInvFinal = new System.Windows.Forms.Button();
            this.btnCMatDisponible = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvSalidas = new System.Windows.Forms.DataGridView();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbEleccion = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalidas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvInventario
            // 
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvInventario.Location = new System.Drawing.Point(12, 108);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.Size = new System.Drawing.Size(416, 271);
            this.dgvInventario.TabIndex = 0;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // btnAgregarCompras
            // 
            this.btnAgregarCompras.Location = new System.Drawing.Point(112, 66);
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
            this.label1.Location = new System.Drawing.Point(286, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sistema de Inventario";
            // 
            // btnAgregarSalida
            // 
            this.btnAgregarSalida.Location = new System.Drawing.Point(614, 66);
            this.btnAgregarSalida.Name = "btnAgregarSalida";
            this.btnAgregarSalida.Size = new System.Drawing.Size(127, 36);
            this.btnAgregarSalida.TabIndex = 3;
            this.btnAgregarSalida.Text = "Agregar salida";
            this.btnAgregarSalida.UseVisualStyleBackColor = true;
            this.btnAgregarSalida.Click += new System.EventHandler(this.btnAgregarSalida_Click);
            // 
            // btnCstMatUsados
            // 
            this.btnCstMatUsados.Location = new System.Drawing.Point(729, 396);
            this.btnCstMatUsados.Name = "btnCstMatUsados";
            this.btnCstMatUsados.Size = new System.Drawing.Size(100, 43);
            this.btnCstMatUsados.TabIndex = 4;
            this.btnCstMatUsados.Text = "Costo Materiales Usados";
            this.btnCstMatUsados.UseVisualStyleBackColor = true;
            this.btnCstMatUsados.Click += new System.EventHandler(this.btnCstMatUsados_Click);
            // 
            // btnCstInvFinal
            // 
            this.btnCstInvFinal.Location = new System.Drawing.Point(623, 396);
            this.btnCstInvFinal.Name = "btnCstInvFinal";
            this.btnCstInvFinal.Size = new System.Drawing.Size(100, 43);
            this.btnCstInvFinal.TabIndex = 5;
            this.btnCstInvFinal.Text = "Costo Inventario Final";
            this.btnCstInvFinal.UseVisualStyleBackColor = true;
            this.btnCstInvFinal.Click += new System.EventHandler(this.btnCstInvFinal_Click);
            // 
            // btnCMatDisponible
            // 
            this.btnCMatDisponible.Location = new System.Drawing.Point(504, 396);
            this.btnCMatDisponible.Name = "btnCMatDisponible";
            this.btnCMatDisponible.Size = new System.Drawing.Size(113, 43);
            this.btnCMatDisponible.TabIndex = 6;
            this.btnCMatDisponible.Text = "Costo Materiales Disponibles";
            this.btnCMatDisponible.UseVisualStyleBackColor = true;
            this.btnCMatDisponible.Click += new System.EventHandler(this.btnCMatDisponible_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(493, 378);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 64);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Calculos";
            // 
            // dgvSalidas
            // 
            this.dgvSalidas.AllowUserToAddRows = false;
            this.dgvSalidas.AllowUserToDeleteRows = false;
            this.dgvSalidas.AllowUserToResizeColumns = false;
            this.dgvSalidas.AllowUserToResizeRows = false;
            this.dgvSalidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvSalidas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSalidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalidas.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvSalidas.Location = new System.Drawing.Point(464, 108);
            this.dgvSalidas.Name = "dgvSalidas";
            this.dgvSalidas.RowHeadersVisible = false;
            this.dgvSalidas.Size = new System.Drawing.Size(415, 271);
            this.dgvSalidas.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 411);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Elegir método:";
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Location = new System.Drawing.Point(229, 408);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.Size = new System.Drawing.Size(171, 21);
            this.cmbEleccion.TabIndex = 10;
            // 
            // FrmGestionInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 451);
            this.Controls.Add(this.cmbEleccion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvSalidas);
            this.Controls.Add(this.btnCMatDisponible);
            this.Controls.Add(this.btnCstInvFinal);
            this.Controls.Add(this.btnCstMatUsados);
            this.Controls.Add(this.btnAgregarSalida);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAgregarCompras);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmGestionInventario";
            this.Text = "Gestion";
            this.Load += new System.EventHandler(this.FrmGestionInventario_Load);
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
        private System.Windows.Forms.Button btnCstMatUsados;
        private System.Windows.Forms.Button btnCstInvFinal;
        private System.Windows.Forms.Button btnCMatDisponible;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSalidas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbEleccion;
    }
}