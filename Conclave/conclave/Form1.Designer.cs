namespace conclave
{
    partial class Form1
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
            this.BtGerenciar = new System.Windows.Forms.Button();
            this.BtVotar = new System.Windows.Forms.Button();
            this.BtResultados = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtGerenciar
            // 
            this.BtGerenciar.Location = new System.Drawing.Point(12, 12);
            this.BtGerenciar.Name = "BtGerenciar";
            this.BtGerenciar.Size = new System.Drawing.Size(288, 106);
            this.BtGerenciar.TabIndex = 0;
            this.BtGerenciar.Text = "Gerenciar Papaveis";
            this.BtGerenciar.UseVisualStyleBackColor = true;
            this.BtGerenciar.Click += new System.EventHandler(this.BtGerenciar_Click);
            // 
            // BtVotar
            // 
            this.BtVotar.Location = new System.Drawing.Point(12, 124);
            this.BtVotar.Name = "BtVotar";
            this.BtVotar.Size = new System.Drawing.Size(288, 96);
            this.BtVotar.TabIndex = 1;
            this.BtVotar.Text = "Votar";
            this.BtVotar.UseVisualStyleBackColor = true;
            this.BtVotar.Click += new System.EventHandler(this.BtVotar_Click);
            // 
            // BtResultados
            // 
            this.BtResultados.Location = new System.Drawing.Point(12, 226);
            this.BtResultados.Name = "BtResultados";
            this.BtResultados.Size = new System.Drawing.Size(288, 113);
            this.BtResultados.TabIndex = 2;
            this.BtResultados.Text = "Resultados";
            this.BtResultados.UseVisualStyleBackColor = true;
            this.BtResultados.Click += new System.EventHandler(this.BtResultado_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(329, 370);
            this.Controls.Add(this.BtResultados);
            this.Controls.Add(this.BtVotar);
            this.Controls.Add(this.BtGerenciar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtGerenciar;
        private System.Windows.Forms.Button BtVotar;
        private System.Windows.Forms.Button BtResultados;
    }
}

