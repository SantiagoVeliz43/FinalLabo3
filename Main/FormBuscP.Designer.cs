namespace Main
{
    partial class FormBuscP
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
            this.btBuscID = new System.Windows.Forms.Button();
            this.txbIngresoID = new System.Windows.Forms.TextBox();
            this.lbMostrarPrID = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btBuscID
            // 
            this.btBuscID.Location = new System.Drawing.Point(26, 62);
            this.btBuscID.Name = "btBuscID";
            this.btBuscID.Size = new System.Drawing.Size(177, 23);
            this.btBuscID.TabIndex = 0;
            this.btBuscID.Text = "Buscar";
            this.btBuscID.UseVisualStyleBackColor = true;
            this.btBuscID.Click += new System.EventHandler(this.btBuscID_Click);
            // 
            // txbIngresoID
            // 
            this.txbIngresoID.Location = new System.Drawing.Point(26, 36);
            this.txbIngresoID.Name = "txbIngresoID";
            this.txbIngresoID.Size = new System.Drawing.Size(177, 20);
            this.txbIngresoID.TabIndex = 1;
            // 
            // lbMostrarPrID
            // 
            this.lbMostrarPrID.FormattingEnabled = true;
            this.lbMostrarPrID.Location = new System.Drawing.Point(26, 91);
            this.lbMostrarPrID.Name = "lbMostrarPrID";
            this.lbMostrarPrID.Size = new System.Drawing.Size(177, 95);
            this.lbMostrarPrID.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese ID de producto";
            // 
            // btVolver
            // 
            this.btVolver.ForeColor = System.Drawing.Color.Red;
            this.btVolver.Location = new System.Drawing.Point(72, 192);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(88, 23);
            this.btVolver.TabIndex = 4;
            this.btVolver.Text = "Volver al menu";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // FormBuscP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(228, 232);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbMostrarPrID);
            this.Controls.Add(this.txbIngresoID);
            this.Controls.Add(this.btBuscID);
            this.Name = "FormBuscP";
            this.Text = "Buscar producto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btBuscID;
        private System.Windows.Forms.TextBox txbIngresoID;
        private System.Windows.Forms.ListBox lbMostrarPrID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btVolver;
    }
}