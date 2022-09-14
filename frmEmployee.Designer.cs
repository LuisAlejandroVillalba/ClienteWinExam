namespace ClienteExamen
{
    partial class frmEmployee
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
            this.txtEmp_id = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtMinit = new System.Windows.Forms.TextBox();
            this.txtIname = new System.Windows.Forms.TextBox();
            this.txtJob_id = new System.Windows.Forms.TextBox();
            this.txtPub_id = new System.Windows.Forms.TextBox();
            this.txtHireDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtJob_lvl = new System.Windows.Forms.TextBox();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.cbCriterioEm = new System.Windows.Forms.ComboBox();
            this.dgvEmploye = new System.Windows.Forms.DataGridView();
            this.btnSalirE = new System.Windows.Forms.Button();
            this.btnRegresarE = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTextoEm = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploye)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tabla Employee";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(429, 113);
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
            this.label2.Location = new System.Drawing.Point(74, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Emp_id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fname";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Minit";
            // 
            // txtEmp_id
            // 
            this.txtEmp_id.Location = new System.Drawing.Point(190, 86);
            this.txtEmp_id.Name = "txtEmp_id";
            this.txtEmp_id.Size = new System.Drawing.Size(100, 20);
            this.txtEmp_id.TabIndex = 6;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(190, 116);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 20);
            this.txtFname.TabIndex = 7;
            // 
            // txtMinit
            // 
            this.txtMinit.Location = new System.Drawing.Point(190, 143);
            this.txtMinit.Name = "txtMinit";
            this.txtMinit.Size = new System.Drawing.Size(100, 20);
            this.txtMinit.TabIndex = 8;
            // 
            // txtIname
            // 
            this.txtIname.Location = new System.Drawing.Point(190, 170);
            this.txtIname.Name = "txtIname";
            this.txtIname.Size = new System.Drawing.Size(100, 20);
            this.txtIname.TabIndex = 9;
            // 
            // txtJob_id
            // 
            this.txtJob_id.Location = new System.Drawing.Point(190, 197);
            this.txtJob_id.Name = "txtJob_id";
            this.txtJob_id.Size = new System.Drawing.Size(100, 20);
            this.txtJob_id.TabIndex = 10;
            // 
            // txtPub_id
            // 
            this.txtPub_id.Location = new System.Drawing.Point(190, 251);
            this.txtPub_id.Name = "txtPub_id";
            this.txtPub_id.Size = new System.Drawing.Size(100, 20);
            this.txtPub_id.TabIndex = 11;
            // 
            // txtHireDate
            // 
            this.txtHireDate.Location = new System.Drawing.Point(190, 278);
            this.txtHireDate.Name = "txtHireDate";
            this.txtHireDate.Size = new System.Drawing.Size(100, 20);
            this.txtHireDate.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(74, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Iname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(75, 200);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Job_id";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(76, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Pub_id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(79, 281);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "HireDate";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(75, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Job_lvl";
            // 
            // txtJob_lvl
            // 
            this.txtJob_lvl.Location = new System.Drawing.Point(190, 224);
            this.txtJob_lvl.Name = "txtJob_lvl";
            this.txtJob_lvl.Size = new System.Drawing.Size(100, 20);
            this.txtJob_lvl.TabIndex = 18;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(429, 177);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 19;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(429, 243);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 20;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(375, 324);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 21;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(644, 324);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // cbCriterioEm
            // 
            this.cbCriterioEm.FormattingEnabled = true;
            this.cbCriterioEm.Items.AddRange(new object[] {
            "Nombre",
            "Apellido"});
            this.cbCriterioEm.Location = new System.Drawing.Point(906, 326);
            this.cbCriterioEm.Name = "cbCriterioEm";
            this.cbCriterioEm.Size = new System.Drawing.Size(121, 21);
            this.cbCriterioEm.TabIndex = 23;
            // 
            // dgvEmploye
            // 
            this.dgvEmploye.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmploye.Location = new System.Drawing.Point(12, 378);
            this.dgvEmploye.Name = "dgvEmploye";
            this.dgvEmploye.Size = new System.Drawing.Size(1105, 268);
            this.dgvEmploye.TabIndex = 24;
            // 
            // btnSalirE
            // 
            this.btnSalirE.Location = new System.Drawing.Point(1002, 57);
            this.btnSalirE.Name = "btnSalirE";
            this.btnSalirE.Size = new System.Drawing.Size(75, 23);
            this.btnSalirE.TabIndex = 25;
            this.btnSalirE.Text = "salir";
            this.btnSalirE.UseVisualStyleBackColor = true;
            this.btnSalirE.Click += new System.EventHandler(this.btnSalirE_Click);
            // 
            // btnRegresarE
            // 
            this.btnRegresarE.Location = new System.Drawing.Point(1002, 177);
            this.btnRegresarE.Name = "btnRegresarE";
            this.btnRegresarE.Size = new System.Drawing.Size(75, 23);
            this.btnRegresarE.TabIndex = 26;
            this.btnRegresarE.Text = "Regresar";
            this.btnRegresarE.UseVisualStyleBackColor = true;
            this.btnRegresarE.Click += new System.EventHandler(this.btnRegresarE_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(906, 291);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Criterio";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(765, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "Texto";
            // 
            // txtTextoEm
            // 
            this.txtTextoEm.Location = new System.Drawing.Point(759, 326);
            this.txtTextoEm.Name = "txtTextoEm";
            this.txtTextoEm.Size = new System.Drawing.Size(100, 20);
            this.txtTextoEm.TabIndex = 29;
            // 
            // frmEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 658);
            this.Controls.Add(this.txtTextoEm);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRegresarE);
            this.Controls.Add(this.btnSalirE);
            this.Controls.Add(this.dgvEmploye);
            this.Controls.Add(this.cbCriterioEm);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.txtJob_lvl);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHireDate);
            this.Controls.Add(this.txtPub_id);
            this.Controls.Add(this.txtJob_id);
            this.Controls.Add(this.txtIname);
            this.Controls.Add(this.txtMinit);
            this.Controls.Add(this.txtFname);
            this.Controls.Add(this.txtEmp_id);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Name = "frmEmployee";
            this.Text = "frmEmployee";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmploye)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmp_id;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtMinit;
        private System.Windows.Forms.TextBox txtIname;
        private System.Windows.Forms.TextBox txtJob_id;
        private System.Windows.Forms.TextBox txtPub_id;
        private System.Windows.Forms.TextBox txtHireDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtJob_lvl;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox cbCriterioEm;
        private System.Windows.Forms.DataGridView dgvEmploye;
        private System.Windows.Forms.Button btnSalirE;
        private System.Windows.Forms.Button btnRegresarE;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTextoEm;
    }
}