namespace Balança_3400
{
    partial class Balança
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
            this.portBalanca = new System.IO.Ports.SerialPort(this.components);
            this.btnConectar = new System.Windows.Forms.Button();
            this.cbConectar = new System.Windows.Forms.ComboBox();
            this.txtLer = new System.Windows.Forms.TextBox();
            this.btnLer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // portBalanca
            // 
            this.portBalanca.DataBits = 7;
            this.portBalanca.DiscardNull = true;
            this.portBalanca.DtrEnable = true;
            this.portBalanca.PortName = "COM6";
            // 
            // btnConectar
            // 
            this.btnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectar.Location = new System.Drawing.Point(40, 40);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(96, 23);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // cbConectar
            // 
            this.cbConectar.FormattingEnabled = true;
            this.cbConectar.Location = new System.Drawing.Point(142, 42);
            this.cbConectar.Name = "cbConectar";
            this.cbConectar.Size = new System.Drawing.Size(121, 21);
            this.cbConectar.TabIndex = 1;
            // 
            // txtLer
            // 
            this.txtLer.Location = new System.Drawing.Point(142, 78);
            this.txtLer.Multiline = true;
            this.txtLer.Name = "txtLer";
            this.txtLer.Size = new System.Drawing.Size(121, 23);
            this.txtLer.TabIndex = 2;
            // 
            // btnLer
            // 
            this.btnLer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLer.Location = new System.Drawing.Point(40, 78);
            this.btnLer.Name = "btnLer";
            this.btnLer.Size = new System.Drawing.Size(96, 23);
            this.btnLer.TabIndex = 3;
            this.btnLer.Text = "Ler peso";
            this.btnLer.UseVisualStyleBackColor = true;
            this.btnLer.Click += new System.EventHandler(this.btnLer_Click);
            // 
            // Balança
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 127);
            this.Controls.Add(this.btnLer);
            this.Controls.Add(this.txtLer);
            this.Controls.Add(this.cbConectar);
            this.Controls.Add(this.btnConectar);
            this.Name = "Balança";
            this.Text = "Balança";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.ComboBox cbConectar;
        private System.Windows.Forms.TextBox txtLer;
        private System.Windows.Forms.Button btnLer;
        private System.IO.Ports.SerialPort portBalanca;
    }
}

