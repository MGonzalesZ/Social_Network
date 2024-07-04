namespace panalbase
{
    partial class Preacciones
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
            this.panelReactM = new System.Windows.Forms.Panel();
            this.btnCerrarM = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelReactM
            // 
            this.panelReactM.BackColor = System.Drawing.Color.GhostWhite;
            this.panelReactM.Location = new System.Drawing.Point(6, 7);
            this.panelReactM.Name = "panelReactM";
            this.panelReactM.Size = new System.Drawing.Size(215, 330);
            this.panelReactM.TabIndex = 0;
            // 
            // btnCerrarM
            // 
            this.btnCerrarM.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrarM.FlatAppearance.BorderSize = 0;
            this.btnCerrarM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarM.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarM.Location = new System.Drawing.Point(6, 343);
            this.btnCerrarM.Name = "btnCerrarM";
            this.btnCerrarM.Size = new System.Drawing.Size(215, 34);
            this.btnCerrarM.TabIndex = 1;
            this.btnCerrarM.Text = "CERRAR";
            this.btnCerrarM.UseVisualStyleBackColor = false;
            this.btnCerrarM.Click += new System.EventHandler(this.button1_Click);
            // 
            // Preacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(229, 381);
            this.Controls.Add(this.btnCerrarM);
            this.Controls.Add(this.panelReactM);
            this.Name = "Preacciones";
            this.Text = "Preacciones";
            this.Load += new System.EventHandler(this.Preacciones_Load);
            this.Shown += new System.EventHandler(this.Preacciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelReactM;
        private System.Windows.Forms.Button btnCerrarM;
    }
}