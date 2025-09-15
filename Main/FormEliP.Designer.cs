namespace Main
{
    partial class FormEliP
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
            this.tbIdProd = new System.Windows.Forms.TextBox();
            this.lbProd = new System.Windows.Forms.ListBox();
            this.btBuscar = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese ID del producto a eliminar";
            // 
            // tbIdProd
            // 
            this.tbIdProd.Location = new System.Drawing.Point(193, 28);
            this.tbIdProd.Name = "tbIdProd";
            this.tbIdProd.Size = new System.Drawing.Size(100, 20);
            this.tbIdProd.TabIndex = 1;
            // 
            // lbProd
            // 
            this.lbProd.FormattingEnabled = true;
            this.lbProd.Location = new System.Drawing.Point(7, 83);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(486, 17);
            this.lbProd.TabIndex = 2;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(203, 54);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(75, 23);
            this.btBuscar.TabIndex = 3;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.ForeColor = System.Drawing.Color.Red;
            this.btEliminar.Location = new System.Drawing.Point(7, 106);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 23);
            this.btEliminar.TabIndex = 4;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btVolver
            // 
            this.btVolver.ForeColor = System.Drawing.Color.Red;
            this.btVolver.Location = new System.Drawing.Point(418, 106);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(75, 23);
            this.btVolver.TabIndex = 5;
            this.btVolver.Text = "Volver al menu";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // FormEliP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 141);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.tbIdProd);
            this.Controls.Add(this.label1);
            this.Name = "FormEliP";
            this.Text = "Eliminar producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdProd;
        private System.Windows.Forms.ListBox lbProd;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button btVolver;
    }
}