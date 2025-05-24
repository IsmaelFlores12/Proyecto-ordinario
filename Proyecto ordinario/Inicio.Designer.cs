namespace Proyecto_ordinario
{
    partial class Inicio
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
            this.dgDatos = new System.Windows.Forms.DataGridView();
            this.BtnImportar = new System.Windows.Forms.Button();
            this.BtnExportar = new System.Windows.Forms.Button();
            this.BtnMostrar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbEliminar = new System.Windows.Forms.TextBox();
            this.btnInsertar = new System.Windows.Forms.Button();
            this.txbId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbMarca = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbAnio = new System.Windows.Forms.TextBox();
            this.TxbModelo = new System.Windows.Forms.Label();
            this.txbModel = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbEstado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txbPrecio = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbColor = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbxIDactualizar = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgDatos
            // 
            this.dgDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDatos.Location = new System.Drawing.Point(12, 12);
            this.dgDatos.Name = "dgDatos";
            this.dgDatos.RowHeadersWidth = 51;
            this.dgDatos.RowTemplate.Height = 24;
            this.dgDatos.Size = new System.Drawing.Size(827, 503);
            this.dgDatos.TabIndex = 0;
            // 
            // BtnImportar
            // 
            this.BtnImportar.Location = new System.Drawing.Point(20, 538);
            this.BtnImportar.Name = "BtnImportar";
            this.BtnImportar.Size = new System.Drawing.Size(191, 68);
            this.BtnImportar.TabIndex = 1;
            this.BtnImportar.Text = "Importar";
            this.BtnImportar.UseVisualStyleBackColor = true;
            this.BtnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // BtnExportar
            // 
            this.BtnExportar.Location = new System.Drawing.Point(217, 540);
            this.BtnExportar.Name = "BtnExportar";
            this.BtnExportar.Size = new System.Drawing.Size(191, 66);
            this.BtnExportar.TabIndex = 2;
            this.BtnExportar.Text = "Exportar";
            this.BtnExportar.UseVisualStyleBackColor = true;
            this.BtnExportar.Click += new System.EventHandler(this.BtnExportar_Click);
            // 
            // BtnMostrar
            // 
            this.BtnMostrar.Location = new System.Drawing.Point(428, 541);
            this.BtnMostrar.Name = "BtnMostrar";
            this.BtnMostrar.Size = new System.Drawing.Size(228, 65);
            this.BtnMostrar.TabIndex = 3;
            this.BtnMostrar.Text = "Mostrar";
            this.BtnMostrar.UseVisualStyleBackColor = true;
            this.BtnMostrar.Click += new System.EventHandler(this.BtnMostrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(863, 16);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(182, 59);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1090, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // txbEliminar
            // 
            this.txbEliminar.Location = new System.Drawing.Point(1051, 53);
            this.txbEliminar.Name = "txbEliminar";
            this.txbEliminar.Size = new System.Drawing.Size(100, 22);
            this.txbEliminar.TabIndex = 6;
            // 
            // btnInsertar
            // 
            this.btnInsertar.Location = new System.Drawing.Point(863, 98);
            this.btnInsertar.Name = "btnInsertar";
            this.btnInsertar.Size = new System.Drawing.Size(136, 59);
            this.btnInsertar.TabIndex = 7;
            this.btnInsertar.Text = "Insertar";
            this.btnInsertar.UseVisualStyleBackColor = true;
            this.btnInsertar.Click += new System.EventHandler(this.btnInsertar_Click);
            // 
            // txbId
            // 
            this.txbId.Location = new System.Drawing.Point(883, 188);
            this.txbId.Name = "txbId";
            this.txbId.Size = new System.Drawing.Size(100, 22);
            this.txbId.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(922, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 16);
            this.label2.TabIndex = 10;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(911, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 12;
            this.label3.Text = "Marca";
            // 
            // txbMarca
            // 
            this.txbMarca.Location = new System.Drawing.Point(883, 232);
            this.txbMarca.Name = "txbMarca";
            this.txbMarca.Size = new System.Drawing.Size(100, 22);
            this.txbMarca.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(911, 305);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "año";
            // 
            // txbAnio
            // 
            this.txbAnio.Location = new System.Drawing.Point(883, 324);
            this.txbAnio.Name = "txbAnio";
            this.txbAnio.Size = new System.Drawing.Size(100, 22);
            this.txbAnio.TabIndex = 15;
            // 
            // TxbModelo
            // 
            this.TxbModelo.AutoSize = true;
            this.TxbModelo.Location = new System.Drawing.Point(911, 257);
            this.TxbModelo.Name = "TxbModelo";
            this.TxbModelo.Size = new System.Drawing.Size(53, 16);
            this.TxbModelo.TabIndex = 14;
            this.TxbModelo.Text = "modelo";
            // 
            // txbModel
            // 
            this.txbModel.Location = new System.Drawing.Point(883, 276);
            this.txbModel.Name = "txbModel";
            this.txbModel.Size = new System.Drawing.Size(100, 22);
            this.txbModel.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(911, 447);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "estado";
            // 
            // txbEstado
            // 
            this.txbEstado.Location = new System.Drawing.Point(883, 466);
            this.txbEstado.Name = "txbEstado";
            this.txbEstado.Size = new System.Drawing.Size(100, 22);
            this.txbEstado.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(911, 399);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "precio";
            // 
            // txbPrecio
            // 
            this.txbPrecio.Location = new System.Drawing.Point(883, 418);
            this.txbPrecio.Name = "txbPrecio";
            this.txbPrecio.Size = new System.Drawing.Size(100, 22);
            this.txbPrecio.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(911, 355);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "color";
            // 
            // txbColor
            // 
            this.txbColor.Location = new System.Drawing.Point(883, 374);
            this.txbColor.Name = "txbColor";
            this.txbColor.Size = new System.Drawing.Size(100, 22);
            this.txbColor.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(987, 169);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(198, 16);
            this.label8.TabIndex = 23;
            this.label8.Text = "Inserta ID que deseas actualizar";
            // 
            // tbxIDactualizar
            // 
            this.tbxIDactualizar.Location = new System.Drawing.Point(1036, 188);
            this.tbxIDactualizar.Name = "tbxIDactualizar";
            this.tbxIDactualizar.Size = new System.Drawing.Size(100, 22);
            this.tbxIDactualizar.TabIndex = 24;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(1025, 98);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(136, 59);
            this.btnActualizar.TabIndex = 25;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1198, 676);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.tbxIDactualizar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txbEstado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txbPrecio);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txbColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txbAnio);
            this.Controls.Add(this.TxbModelo);
            this.Controls.Add(this.txbModel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMarca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbId);
            this.Controls.Add(this.btnInsertar);
            this.Controls.Add(this.txbEliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.BtnMostrar);
            this.Controls.Add(this.BtnExportar);
            this.Controls.Add(this.BtnImportar);
            this.Controls.Add(this.dgDatos);
            this.Name = "Inicio";
            this.Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)(this.dgDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgDatos;
        private System.Windows.Forms.Button BtnImportar;
        private System.Windows.Forms.Button BtnExportar;
        private System.Windows.Forms.Button BtnMostrar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbEliminar;
        private System.Windows.Forms.Button btnInsertar;
        private System.Windows.Forms.TextBox txbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbMarca;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbAnio;
        private System.Windows.Forms.Label TxbModelo;
        private System.Windows.Forms.TextBox txbModel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbEstado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbPrecio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbxIDactualizar;
        private System.Windows.Forms.Button btnActualizar;
    }
}