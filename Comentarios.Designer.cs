
namespace panalbase
{
    partial class Comentarios
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
            this.txtComentarios = new System.Windows.Forms.TextBox();
            this.btnComentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtComentarios
            // 
            this.txtComentarios.Location = new System.Drawing.Point(29, 31);
            this.txtComentarios.Name = "txtComentarios";
            this.txtComentarios.Size = new System.Drawing.Size(627, 20);
            this.txtComentarios.TabIndex = 0;
            // 
            // btnComentar
            // 
            this.btnComentar.BackColor = System.Drawing.Color.Orange;
            this.btnComentar.Location = new System.Drawing.Point(29, 82);
            this.btnComentar.Name = "btnComentar";
            this.btnComentar.Size = new System.Drawing.Size(103, 48);
            this.btnComentar.TabIndex = 1;
            this.btnComentar.Text = "Comentar";
            this.btnComentar.UseVisualStyleBackColor = false;
            this.btnComentar.Click += new System.EventHandler(this.btnComentar_Click);
            // 
            // Comentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnComentar);
            this.Controls.Add(this.txtComentarios);
            this.Name = "Comentarios";
            this.Text = "Comentarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtComentarios;
        private System.Windows.Forms.Button btnComentar;
    }
}