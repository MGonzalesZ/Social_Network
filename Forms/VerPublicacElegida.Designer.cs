namespace panalbase
{
    partial class VerPublicacElegida
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelPublic = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LabelFecha = new System.Windows.Forms.Label();
            this.pictureBoxPublSel = new System.Windows.Forms.PictureBox();
            this.btnEditar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPublSel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "PUBLICACION";
            // 
            // LabelPublic
            // 
            this.LabelPublic.AutoSize = true;
            this.LabelPublic.Location = new System.Drawing.Point(19, 49);
            this.LabelPublic.Name = "LabelPublic";
            this.LabelPublic.Size = new System.Drawing.Size(0, 13);
            this.LabelPublic.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // LabelFecha
            // 
            this.LabelFecha.AutoSize = true;
            this.LabelFecha.Location = new System.Drawing.Point(441, 14);
            this.LabelFecha.Name = "LabelFecha";
            this.LabelFecha.Size = new System.Drawing.Size(0, 13);
            this.LabelFecha.TabIndex = 3;
            // 
            // pictureBoxPublSel
            // 
            this.pictureBoxPublSel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxPublSel.Location = new System.Drawing.Point(12, 39);
            this.pictureBoxPublSel.Name = "pictureBoxPublSel";
            this.pictureBoxPublSel.Size = new System.Drawing.Size(508, 281);
            this.pictureBoxPublSel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPublSel.TabIndex = 4;
            this.pictureBoxPublSel.TabStop = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEditar.Location = new System.Drawing.Point(205, 336);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(133, 56);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // VerPublicacElegida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(536, 400);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.pictureBoxPublSel);
            this.Controls.Add(this.LabelFecha);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LabelPublic);
            this.Controls.Add(this.label1);
            this.Name = "VerPublicacElegida";
            this.Text = "VerPublicacElegida";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPublSel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label LabelPublic;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label LabelFecha;
        public System.Windows.Forms.PictureBox pictureBoxPublSel;
        private System.Windows.Forms.Button btnEditar;
    }
}