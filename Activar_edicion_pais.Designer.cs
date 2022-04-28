namespace panalbase
{
    partial class Activar_edicion_pais
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
            this.TBuser = new System.Windows.Forms.TextBox();
            this.TBpass = new System.Windows.Forms.TextBox();
            this.Brealizado = new System.Windows.Forms.Button();
            this.Bvolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TBuser
            // 
            this.TBuser.Location = new System.Drawing.Point(68, 50);
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(100, 20);
            this.TBuser.TabIndex = 0;
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(68, 106);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(100, 20);
            this.TBpass.TabIndex = 1;
            // 
            // Brealizado
            // 
            this.Brealizado.BackColor = System.Drawing.Color.Orange;
            this.Brealizado.Location = new System.Drawing.Point(152, 191);
            this.Brealizado.Name = "Brealizado";
            this.Brealizado.Size = new System.Drawing.Size(87, 46);
            this.Brealizado.TabIndex = 2;
            this.Brealizado.Text = "realizado";
            this.Brealizado.UseVisualStyleBackColor = false;
            this.Brealizado.Click += new System.EventHandler(this.Brealizado_Click);
            // 
            // Bvolver
            // 
            this.Bvolver.BackColor = System.Drawing.Color.Orange;
            this.Bvolver.Location = new System.Drawing.Point(29, 191);
            this.Bvolver.Name = "Bvolver";
            this.Bvolver.Size = new System.Drawing.Size(99, 46);
            this.Bvolver.TabIndex = 3;
            this.Bvolver.Text = "regresar";
            this.Bvolver.UseVisualStyleBackColor = false;
            this.Bvolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "usuario de administrador";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "contraseña";
            // 
            // Activar_edicion_pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bvolver);
            this.Controls.Add(this.Brealizado);
            this.Controls.Add(this.TBpass);
            this.Controls.Add(this.TBuser);
            this.Name = "Activar_edicion_pais";
            this.Text = "Activar_edicion_pais";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBuser;
        private System.Windows.Forms.TextBox TBpass;
        private System.Windows.Forms.Button Brealizado;
        private System.Windows.Forms.Button Bvolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}