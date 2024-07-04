namespace panalbase
{
    partial class frmElegirChat
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnIrChat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(229)))), ((int)(((byte)(144)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(606, 220);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnIrChat
            // 
            this.btnIrChat.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnIrChat.FlatAppearance.BorderSize = 0;
            this.btnIrChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIrChat.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnIrChat.Location = new System.Drawing.Point(485, 238);
            this.btnIrChat.Name = "btnIrChat";
            this.btnIrChat.Size = new System.Drawing.Size(133, 36);
            this.btnIrChat.TabIndex = 1;
            this.btnIrChat.Text = "Enviar mensaje";
            this.btnIrChat.UseVisualStyleBackColor = false;
            this.btnIrChat.Click += new System.EventHandler(this.btnIrChat_Click);
            // 
            // frmElegirChat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(196)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(632, 290);
            this.Controls.Add(this.btnIrChat);
            this.Controls.Add(this.dataGridView1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "frmElegirChat";
            this.Text = "frmElegirChat";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnIrChat;
    }
}