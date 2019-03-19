using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Tombamento.Relatorio.Models;

namespace Tombamento.Relatorio
{
    public partial class frmGridContrato : Form
    {
        List<Finaceiro> lst = null;
        DataTable lstOcorrencia = null;
        EnumTabs _tipoDti;

        int _coluna = 0;
        public frmGridContrato(List<Finaceiro> _listagem, EnumTabs _tab, int col)
        {
            InitializeComponent();
            _tipoDti = _tab;
            lst = _listagem;
            this._coluna = col;
        }

        public frmGridContrato(DataTable _listagem, EnumTabs _tab, int col)
        {
            InitializeComponent();
            _tipoDti = _tab;
            lstOcorrencia = _listagem;
            this._coluna = col;
        }

        private void frmGridContrato_Load(object sender, EventArgs e)
        {
            this.GridViewListagem.DataSource = null;
            
            if (_tipoDti == EnumTabs.DtiFinanciro)
            {
                this.GridViewListagem.DataSource = lst;
                this.GridViewListagem.Columns.RemoveAt(0);
                this.GridViewListagem.Columns.Remove("DivergenciaFinanceiro");
            }

            if (_tipoDti == EnumTabs.DtiOcorrencia || _tipoDti == EnumTabs.DtiParcela)
            {
                this.GridViewListagem.DataSource = lstOcorrencia;
            }
           
            this.GridViewListagem.Rows[0].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.Black, ForeColor = Color.White, Font = new Font("Tahoma", 8, FontStyle.Bold) };
            this.GridViewListagem.Columns[(this._coluna-1)].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.Red, ForeColor = Color.White };
            this.GridViewListagem.Columns[this._coluna].DefaultCellStyle = new DataGridViewCellStyle() { BackColor = Color.Red, ForeColor = Color.White };
            this.GridViewListagem.FirstDisplayedScrollingColumnIndex = (this._coluna-1);
        }
    }
}
