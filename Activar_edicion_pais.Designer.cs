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
            this.TBuser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TBuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TBuser.Location = new System.Drawing.Point(71, 61);
            this.TBuser.Name = "TBuser";
            this.TBuser.Size = new System.Drawing.Size(100, 14);
            this.TBuser.TabIndex = 0;
            // 
            // TBpass
            // 
            this.TBpass.Location = new System.Drawing.Point(71, 106);
            this.TBpass.Name = "TBpass";
            this.TBpass.Size = new System.Drawing.Size(100, 20);
            this.TBpass.TabIndex = 1;
            // 
            // Brealizado
            // 
            this.Brealizado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.Brealizado.FlatAppearance.BorderSize = 0;
            this.Brealizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Brealizado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Brealizado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Brealizado.Location = new System.Drawing.Point(160, 191);
            this.Brealizado.Name = "Brealizado";
            this.Brealizado.Size = new System.Drawing.Size(96, 46);
            this.Brealizado.TabIndex = 2;
            this.Brealizado.Text = "Realizado";
            this.Brealizado.UseVisualStyleBackColor = false;
            this.Brealizado.Click += new System.EventHandler(this.Brealizado_Click);
            // 
            // Bvolver
            // 
            this.Bvolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(205)))), ((int)(((byte)(170)))), ((int)(((byte)(78)))));
            this.Bvolver.FlatAppearance.BorderSize = 0;
            this.Bvolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bvolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bvolver.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Bvolver.Location = new System.Drawing.Point(29, 191);
            this.Bvolver.Name = "Bvolver";
            this.Bvolver.Size = new System.Drawing.Size(99, 46);
            this.Bvolver.TabIndex = 3;
            this.Bvolver.Text = "Regresar";
            this.Bvolver.UseVisualStyleBackColor = false;
            this.Bvolver.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Usuario de Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Contraseña";
            // 
            // Activar_edicion_pais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
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