namespace Main
{
    partial class FormEditP
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
            this.btBuscar = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.btGuardar = new System.Windows.Forms.Button();
            this.lbProd = new System.Windows.Forms.ListBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.tbStock = new System.Windows.Forms.TextBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese ID de producto";
            // 
            // tbIdProd
            // 
            this.tbIdProd.Location = new System.Drawing.Point(241, 28);
            this.tbIdProd.Name = "tbIdProd";
            this.tbIdProd.Size = new System.Drawing.Size(126, 20);
            this.tbIdProd.TabIndex = 1;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(266, 54);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(81, 23);
            this.btBuscar.TabIndex = 2;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(8, 106);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(146, 20);
            this.tbName.TabIndex = 3;
            // 
            // btGuardar
            // 
            this.btGuardar.ForeColor = System.Drawing.Color.Blue;
            this.btGuardar.Location = new System.Drawing.Point(219, 132);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(87, 23);
            this.btGuardar.TabIndex = 4;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // lbProd
            // 
            this.lbProd.FormattingEnabled = true;
            this.lbProd.Location = new System.Drawing.Point(8, 83);
            this.lbProd.Name = "lbProd";
            this.lbProd.Size = new System.Drawing.Size(602, 17);
            this.lbProd.TabIndex = 5;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(160, 106);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(146, 20);
            this.tbDesc.TabIndex = 6;
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(312, 106);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(146, 20);
            this.tbPrecio.TabIndex = 7;
            // 
            // tbStock
            // 
            this.tbStock.Location = new System.Drawing.Point(464, 106);
            this.tbStock.Name = "tbStock";
            this.tbStock.Size = new System.Drawing.Size(146, 20);
            this.tbStock.TabIndex = 8;
            // 
            // btVolver
            // 
            this.btVolver.ForeColor = System.Drawing.Color.Red;
            this.btVolver.Location = new System.Drawing.Point(312, 132);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(85, 23);
            this.btVolver.TabIndex = 10;
            this.btVolver.Text = "Volver al menu";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // FormEditP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 161);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.tbStock);
            this.Controls.Add(this.tbPrecio);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.lbProd);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.tbIdProd);
            this.Controls.Add(this.label1);
            this.Name = "FormEditP";
            this.Text = "Editar producto";
            this.Load += new System.EventHandler(this.FormEditP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIdProd;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.ListBox lbProd;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.TextBox tbStock;
        private System.Windows.Forms.Button btVolver;
    }
}