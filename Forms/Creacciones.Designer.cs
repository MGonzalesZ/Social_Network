namespace panalbase
{
    partial class Creacciones
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
            this.btnCerrarC = new System.Windows.Forms.Button();
            this.panelReactC = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnCerrarC
            // 
            this.btnCerrarC.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnCerrarC.FlatAppearance.BorderSize = 0;
            this.btnCerrarC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarC.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCerrarC.Location = new System.Drawing.Point(13, 321);
            this.btnCerrarC.Name = "btnCerrarC";
            this.btnCerrarC.Size = new System.Drawing.Size(202, 34);
            this.btnCerrarC.TabIndex = 3;
            this.btnCerrarC.Text = "CERRAR";
            this.btnCerrarC.UseVisualStyleBackColor = false;
            this.btnCerrarC.Click += new System.EventHandler(this.btnCerrarC_Click);
            // 
            // panelReactC
            // 
            this.panelReactC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(144)))));
            this.panelReactC.Location = new System.Drawing.Point(12, 12);
            this.panelReactC.Name = "panelReactC";
            this.panelReactC.Size = new System.Drawing.Size(203, 303);
            this.panelReactC.TabIndex = 2;
            // 
            // Creacciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(227, 363);
            this.Controls.Add(this.btnCerrarC);
            this.Controls.Add(this.panelReactC);
            this.Name = "Creacciones";
            this.Text = "Creacciones";
            this.Load += new System.EventHandler(this.Creacciones_Load);
            this.Shown += new System.EventHandler(this.Creacciones_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCerrarC;
        private System.Windows.Forms.Panel panelReactC;
    }
}