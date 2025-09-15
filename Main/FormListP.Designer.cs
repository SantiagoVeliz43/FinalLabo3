namespace Main
{
    partial class FormListP
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
            this.lbListaProd = new System.Windows.Forms.ListBox();
            this.btVolver = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListaProd
            // 
            this.lbListaProd.FormattingEnabled = true;
            this.lbListaProd.Location = new System.Drawing.Point(12, 12);
            this.lbListaProd.Name = "lbListaProd";
            this.lbListaProd.Size = new System.Drawing.Size(489, 303);
            this.lbListaProd.TabIndex = 0;
            // 
            // btVolver
            // 
            this.btVolver.ForeColor = System.Drawing.Color.Red;
            this.btVolver.Location = new System.Drawing.Point(213, 321);
            this.btVolver.Name = "btVolver";
            this.btVolver.Size = new System.Drawing.Size(86, 23);
            this.btVolver.TabIndex = 1;
            this.btVolver.Text = "Volver al menu";
            this.btVolver.UseVisualStyleBackColor = true;
            this.btVolver.Click += new System.EventHandler(this.btVolver_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(507, 215);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(8, 8);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormListP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 353);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btVolver);
            this.Controls.Add(this.lbListaProd);
            this.Name = "FormListP";
            this.Text = "Lista de productos";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListaProd;
        private System.Windows.Forms.Button btVolver;
        private System.Windows.Forms.Button button2;
    }
}