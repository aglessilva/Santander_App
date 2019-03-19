namespace Tombamento.Relatorio
{
    partial class frmGridContrato
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
            this.GridViewListagem = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListagem)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewListagem
            // 
            this.GridViewListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewListagem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridViewListagem.Location = new System.Drawing.Point(0, 0);
            this.GridViewListagem.Name = "GridViewListagem";
            this.GridViewListagem.Size = new System.Drawing.Size(1256, 464);
            this.GridViewListagem.TabIndex = 0;
            // 
            // frmGridContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1256, 464);
            this.Controls.Add(this.GridViewListagem);
            this.Name = "frmGridContrato";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lista de contratos com erros";
            this.Load += new System.EventHandler(this.frmGridContrato_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridViewListagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewListagem;

    }
}