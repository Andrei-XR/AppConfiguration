
namespace AppConfiguration
{
    partial class FrmMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnOpenConfigs = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnOpenConfigs
            // 
            this.BtnOpenConfigs.Location = new System.Drawing.Point(58, 12);
            this.BtnOpenConfigs.Name = "BtnOpenConfigs";
            this.BtnOpenConfigs.Size = new System.Drawing.Size(139, 39);
            this.BtnOpenConfigs.TabIndex = 0;
            this.BtnOpenConfigs.Text = "Open Configurations";
            this.BtnOpenConfigs.UseVisualStyleBackColor = true;
            this.BtnOpenConfigs.Click += new System.EventHandler(this.BtnOpenConfigs_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 68);
            this.Controls.Add(this.BtnOpenConfigs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnOpenConfigs;
    }
}

