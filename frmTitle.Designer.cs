namespace ClienteExamen
{
    partial class frmTitle
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRoyaltiper = new System.Windows.Forms.TextBox();
            this.txtAu_ord = new System.Windows.Forms.TextBox();
            this.txtTitle_id = new System.Windows.Forms.TextBox();
            this.txtAu_id = new System.Windows.Forms.TextBox();
            this.dgvDatos = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cmbCriterio = new System.Windows.Forms.ComboBox();
            this.btnSalirA = new System.Windows.Forms.Button();
            this.btnRegresarA = new System.Windows.Forms.Button();
            this.txtTextoTI = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla Title";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(454, 113);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 2;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(168, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Au_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Title_id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Au_ord";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Royaltiper";
            // 
            // txtRoyaltiper
            // 
            this.txtRoyaltiper.Location = new System.Drawing.Point(249, 212);
            this.txtRoyaltiper.Name = "txtRoyaltiper";
            this.txtRoyaltiper.Size = new System.Drawing.Size(100, 20);
            this.txtRoyaltiper.TabIndex = 7;
            // 
            // txtAu_ord
            // 
            this.txtAu_ord.Location = new System.Drawing.Point(249, 181);
            this.txtAu_ord.Name = "txtAu_ord";
            this.txtAu_ord.Size = new System.Drawing.Size(100, 20);
            this.txtAu_ord.TabIndex = 8;
            // 
            // txtTitle_id
            // 
            this.txtTitle_id.Location = new System.Drawing.Point(249, 155);
            this.txtTitle_id.Name = "txtTitle_id";
            this.txtTitle_id.Size = new System.Drawing.Size(100, 20);
            this.txtTitle_id.TabIndex = 9;
            // 
            // txtAu_id
            // 
            this.txtAu_id.Location = new System.Drawing.Point(249, 116);
            this.txtAu_id.Name = "txtAu_id";
            this.txtAu_id.Size = new System.Drawing.Size(100, 20);
            this.txtAu_id.TabIndex = 10;
            // 
            // dgvDatos
            // 
            this.dgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatos.Location = new System.Drawing.Point(171, 289);
            this.dgvDatos.Name = "dgvDatos";
            this.dgvDatos.Size = new System.Drawing.Size(568, 207);
            this.dgvDatos.TabIndex = 11;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(303, 248);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 12;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(454, 155);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 13;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(454, 189);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 14;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(454, 248);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cmbCriterio
            // 
            this.cmbCriterio.FormattingEnabled = true;
            this.cmbCriterio.Items.AddRange(new object[] {
            "Nombre",
            "Id del autor"});
            this.cmbCriterio.Location = new System.Drawing.Point(687, 248);
            this.cmbCriterio.Name = "cmbCriterio";
            this.cmbCriterio.Size = new System.Drawing.Size(121, 21);
            this.cmbCriterio.TabIndex = 16;
            // 
            // btnSalirA
            // 
            this.btnSalirA.Location = new System.Drawing.Point(711, 114);
            this.btnSalirA.Name = "btnSalirA";
            this.btnSalirA.Size = new System.Drawing.Size(75, 23);
            this.btnSalirA.TabIndex = 17;
            this.btnSalirA.Text = "salir";
            this.btnSalirA.UseVisualStyleBackColor = true;
            this.btnSalirA.Click += new System.EventHandler(this.btnSalirA_Click);
            // 
            // btnRegresarA
            // 
            this.btnRegresarA.Location = new System.Drawing.Point(711, 181);
            this.btnRegresarA.Name = "btnRegresarA";
            this.btnRegresarA.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarA.TabIndex = 18;
            this.btnRegresarA.Text = "Regresar";
            this.btnRegresarA.UseVisualStyleBackColor = true;
            this.btnRegresarA.Click += new System.EventHandler(this.btnRegresarA_Click);
            // 
            // txtTextoTI
            // 
            this.txtTextoTI.Location = new System.Drawing.Point(564, 250);
            this.txtTextoTI.Name = "txtTextoTI";
            this.txtTextoTI.Size = new System.Drawing.Size(100, 20);
            this.txtTextoTI.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(564, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Texto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(687, 230);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Criterio";
            // 
            // frmTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 521);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTextoTI);
            this.Controls.Add(this.btnRegresarA);
            this.Controls.Add(this.btnSalirA);
            this.Controls.Add(this.cmbCriterio);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvDatos);
            this.Controls.Add(this.txtAu_id);
            this.Controls.Add(this.txtTitle_id);
            this.Controls.Add(this.txtAu_ord);
            this.Controls.Add(this.txtRoyaltiper);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "frmTitle";
            this.Text = "frmTitle";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoyaltiper;
        private System.Windows.Forms.TextBox txtAu_ord;
        private System.Windows.Forms.TextBox txtTitle_id;
        private System.Windows.Forms.TextBox txtAu_id;
        private System.Windows.Forms.DataGridView dgvDatos;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cmbCriterio;
        private System.Windows.Forms.Button btnSalirA;
        private System.Windows.Forms.Button btnRegresarA;
        private System.Windows.Forms.TextBox txtTextoTI;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}