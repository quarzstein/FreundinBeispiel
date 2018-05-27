namespace Freundin_State_Observ_Singelton
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnReden = new System.Windows.Forms.Button();
            this.BtnKuss = new System.Windows.Forms.Button();
            this.BtnAergern = new System.Windows.Forms.Button();
            this.LbStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnReden
            // 
            this.BtnReden.Location = new System.Drawing.Point(91, 69);
            this.BtnReden.Name = "BtnReden";
            this.BtnReden.Size = new System.Drawing.Size(100, 23);
            this.BtnReden.TabIndex = 0;
            this.BtnReden.Text = "Reden";
            this.BtnReden.UseVisualStyleBackColor = true;
            this.BtnReden.Click += new System.EventHandler(this.BtnReden_Click);
            // 
            // BtnKuss
            // 
            this.BtnKuss.Location = new System.Drawing.Point(91, 112);
            this.BtnKuss.Name = "BtnKuss";
            this.BtnKuss.Size = new System.Drawing.Size(100, 23);
            this.BtnKuss.TabIndex = 1;
            this.BtnKuss.Text = "Kuss geben";
            this.BtnKuss.UseVisualStyleBackColor = true;
            this.BtnKuss.Click += new System.EventHandler(this.BtnKuss_Click);
            // 
            // BtnAergern
            // 
            this.BtnAergern.Location = new System.Drawing.Point(91, 160);
            this.BtnAergern.Name = "BtnAergern";
            this.BtnAergern.Size = new System.Drawing.Size(100, 23);
            this.BtnAergern.TabIndex = 2;
            this.BtnAergern.Text = "Ärgern";
            this.BtnAergern.UseVisualStyleBackColor = true;
            this.BtnAergern.Click += new System.EventHandler(this.BtnAergern_Click);
            // 
            // LbStatus
            // 
            this.LbStatus.AutoSize = true;
            this.LbStatus.Location = new System.Drawing.Point(88, 24);
            this.LbStatus.Name = "LbStatus";
            this.LbStatus.Size = new System.Drawing.Size(48, 17);
            this.LbStatus.TabIndex = 3;
            this.LbStatus.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Controls.Add(this.LbStatus);
            this.Controls.Add(this.BtnAergern);
            this.Controls.Add(this.BtnKuss);
            this.Controls.Add(this.BtnReden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnReden;
        private System.Windows.Forms.Button BtnKuss;
        private System.Windows.Forms.Button BtnAergern;
        private System.Windows.Forms.Label LbStatus;
    }
}

