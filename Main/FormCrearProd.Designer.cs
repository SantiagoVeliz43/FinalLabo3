namespace Main
{
    partial class FormCrearProd
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombreProd = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tbDescProd = new System.Windows.Forms.TextBox();
            this.tbPrecioProd = new System.Windows.Forms.TextBox();
            this.tbStockProd = new System.Windows.Forms.TextBox();
            this.btCrearProd = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cazabobos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Agregar nuevo producto";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbNombreProd
            // 
            this.tbNombreProd.Location = new System.Drawing.Point(22, 33);
            this.tbNombreProd.Name = "tbNombreProd";
            this.tbNombreProd.Size = new System.Drawing.Size(169, 20);
            this.tbNombreProd.TabIndex = 1;
            this.tbNombreProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tbDescProd
            // 
            this.tbDescProd.Location = new System.Drawing.Point(22, 71);
            this.tbDescProd.Name = "tbDescProd";
            this.tbDescProd.Size = new System.Drawing.Size(169, 20);
            this.tbDescProd.TabIndex = 3;
            this.tbDescProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbPrecioProd
            // 
            this.tbPrecioProd.Location = new System.Drawing.Point(22, 109);
            this.tbPrecioProd.Name = "tbPrecioProd";
            this.tbPrecioProd.Size = new System.Drawing.Size(169, 20);
            this.tbPrecioProd.TabIndex = 4;
            this.tbPrecioProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStockProd
            // 
            this.tbStockProd.Location = new System.Drawing.Point(22, 146);
            this.tbStockProd.Name = "tbStockProd";
            this.tbStockProd.Size = new System.Drawing.Size(169, 20);
            this.tbStockProd.TabIndex = 5;
            this.tbStockProd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btCrearProd
            // 
            this.btCrearProd.Location = new System.Drawing.Point(57, 172);
            this.btCrearProd.Name = "btCrearProd";
            this.btCrearProd.Size = new System.Drawing.Size(97, 23);
            this.btCrearProd.TabIndex = 6;
            this.btCrearProd.Text = "Agregar producto";
            this.btCrearProd.UseVisualStyleBackColor = true;
            this.btCrearProd.Click += new System.EventHandler(this.btCrearProd_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(57, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Volver al menu";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // cazabobos
            // 
            this.cazabobos.Enabled = false;
            this.cazabobos.Location = new System.Drawing.Point(-132, 189);
            this.cazabobos.Name = "cazabobos";
            this.cazabobos.Size = new System.Drawing.Size(169, 20);
            this.cazabobos.TabIndex = 8;
            this.cazabobos.TabStop = false;
            this.cazabobos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cazabobos.Visible = false;
            // 
            // FormCrearProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 236);
            this.Controls.Add(this.cazabobos);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btCrearProd);
            this.Controls.Add(this.tbStockProd);
            this.Controls.Add(this.tbPrecioProd);
            this.Controls.Add(this.tbDescProd);
            this.Controls.Add(this.tbNombreProd);
            this.Controls.Add(this.label1);
            this.Name = "FormCrearProd";
            this.Text = "Crear productos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombreProd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox tbDescProd;
        private System.Windows.Forms.TextBox tbPrecioProd;
        private System.Windows.Forms.TextBox tbStockProd;
        private System.Windows.Forms.Button btCrearProd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox cazabobos;
    }
}