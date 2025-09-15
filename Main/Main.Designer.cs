namespace Main
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbWel = new System.Windows.Forms.Label();
            this.lblEle = new System.Windows.Forms.Label();
            this.btBusqId = new System.Windows.Forms.Button();
            this.btListarAllProd = new System.Windows.Forms.Button();
            this.btCrearProd = new System.Windows.Forms.Button();
            this.btEditarProd = new System.Windows.Forms.Button();
            this.btEliProd = new System.Windows.Forms.Button();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.btCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbWel
            // 
            this.lbWel.AutoSize = true;
            this.lbWel.Font = new System.Drawing.Font("Arial", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWel.Location = new System.Drawing.Point(72, 9);
            this.lbWel.Name = "lbWel";
            this.lbWel.Size = new System.Drawing.Size(116, 23);
            this.lbWel.TabIndex = 1;
            this.lbWel.Text = "Bienvenido";
            // 
            // lblEle
            // 
            this.lblEle.AutoSize = true;
            this.lblEle.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEle.Location = new System.Drawing.Point(62, 32);
            this.lblEle.Name = "lblEle";
            this.lblEle.Size = new System.Drawing.Size(131, 16);
            this.lblEle.TabIndex = 2;
            this.lblEle.Text = "Elija una operacion";
            // 
            // btBusqId
            // 
            this.btBusqId.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBusqId.Location = new System.Drawing.Point(23, 51);
            this.btBusqId.Name = "btBusqId";
            this.btBusqId.Size = new System.Drawing.Size(98, 23);
            this.btBusqId.TabIndex = 3;
            this.btBusqId.Text = "Buscar producto";
            this.btBusqId.UseVisualStyleBackColor = true;
            this.btBusqId.Click += new System.EventHandler(this.btBusqId_Click);
            // 
            // btListarAllProd
            // 
            this.btListarAllProd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btListarAllProd.Location = new System.Drawing.Point(132, 51);
            this.btListarAllProd.Name = "btListarAllProd";
            this.btListarAllProd.Size = new System.Drawing.Size(98, 23);
            this.btListarAllProd.TabIndex = 4;
            this.btListarAllProd.Text = "Listar productos";
            this.btListarAllProd.UseVisualStyleBackColor = true;
            this.btListarAllProd.Click += new System.EventHandler(this.btListarAllProd_Click);
            // 
            // btCrearProd
            // 
            this.btCrearProd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCrearProd.Location = new System.Drawing.Point(23, 92);
            this.btCrearProd.Name = "btCrearProd";
            this.btCrearProd.Size = new System.Drawing.Size(98, 23);
            this.btCrearProd.TabIndex = 5;
            this.btCrearProd.Text = "Crear producto";
            this.btCrearProd.UseVisualStyleBackColor = true;
            this.btCrearProd.Click += new System.EventHandler(this.btCrearProd_Click);
            // 
            // btEditarProd
            // 
            this.btEditarProd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEditarProd.Location = new System.Drawing.Point(132, 92);
            this.btEditarProd.Name = "btEditarProd";
            this.btEditarProd.Size = new System.Drawing.Size(98, 23);
            this.btEditarProd.TabIndex = 6;
            this.btEditarProd.Text = "Editar producto";
            this.btEditarProd.UseVisualStyleBackColor = true;
            this.btEditarProd.Click += new System.EventHandler(this.btEditarProd_Click);
            // 
            // btEliProd
            // 
            this.btEliProd.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btEliProd.ForeColor = System.Drawing.Color.Red;
            this.btEliProd.Location = new System.Drawing.Point(23, 132);
            this.btEliProd.Name = "btEliProd";
            this.btEliProd.Size = new System.Drawing.Size(98, 23);
            this.btEliProd.TabIndex = 7;
            this.btEliProd.Text = "Eliminar producto";
            this.btEliProd.UseVisualStyleBackColor = true;
            this.btEliProd.Click += new System.EventHandler(this.btEliProd_Click);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // btCerrar
            // 
            this.btCerrar.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCerrar.ForeColor = System.Drawing.Color.Red;
            this.btCerrar.Location = new System.Drawing.Point(132, 132);
            this.btCerrar.Name = "btCerrar";
            this.btCerrar.Size = new System.Drawing.Size(98, 23);
            this.btCerrar.TabIndex = 8;
            this.btCerrar.Text = "Cerrar programa";
            this.btCerrar.UseVisualStyleBackColor = true;
            this.btCerrar.Click += new System.EventHandler(this.btCerrar_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 172);
            this.Controls.Add(this.btCerrar);
            this.Controls.Add(this.btEliProd);
            this.Controls.Add(this.btEditarProd);
            this.Controls.Add(this.btCrearProd);
            this.Controls.Add(this.btListarAllProd);
            this.Controls.Add(this.btBusqId);
            this.Controls.Add(this.lblEle);
            this.Controls.Add(this.lbWel);
            this.Name = "Main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWel;
        private System.Windows.Forms.Label lblEle;
        private System.Windows.Forms.Button btBusqId;
        private System.Windows.Forms.Button btListarAllProd;
        private System.Windows.Forms.Button btCrearProd;
        private System.Windows.Forms.Button btEditarProd;
        private System.Windows.Forms.Button btEliProd;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button btCerrar;
    }
}

