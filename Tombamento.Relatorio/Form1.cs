using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Tombamento.Relatorio.BLL;
using Tombamento.Relatorio.Models;

namespace Tombamento.Relatorio
{
    public partial class frmResumo : Form
    {
        List<string> lstPonteiro = null;
        List<ContratoPonteiro> listRejeicao = null;
        List<ContratoPonteiro> listResumo = new List<ContratoPonteiro>();
        DTIFinanceiro _financeiro = null;
        DTIOcorrencia _ocorrencia = null;
        DTIParcela _parcela = null;
        List<Divergencia> lstColunas = null;
        Stopwatch stopwatch = new Stopwatch();

        public frmResumo()
        {
            InitializeComponent();
        }


        void SelecionarArquivo(int index = 0, EnumTabs tab = EnumTabs.Resumo)
        {
            openFileDialog1.Filter = "documento de texto|*.txt";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                switch (index)
                {
                    case 0:
                        {
                            txtPonteiro.Text = openFileDialog1.FileName;
                            break;
                        }
                    case 1:
                        {
                            txtRejeicao.Text = openFileDialog1.FileName;
                            break;
                        }
                    case 2:
                        {
                            txtDTIFinanceiro.Text = openFileDialog1.FileName;
                            break;
                        }
                    case 3:
                        {
                            txtOcorrencia.Text = openFileDialog1.FileName;
                            break;
                        }
                    case 4:
                        {
                            txtDTIParcelas.Text = openFileDialog1.FileName;
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }

            }

            ValidaCampo(tab);
        }

        string StatusProgressFilw(int _lengthFile)
        {
            string statusProgress = string.Empty;

            if (_lengthFile < 5)
               statusProgress = "Iniciando Leitura de arquivo...";

            if (_lengthFile > 5 && _lengthFile < 10)
                statusProgress = "Realizando analise do arquivo...";
            
            if (_lengthFile > 10 && _lengthFile < 35)
               statusProgress = "iniciando comparação de dados de origem e destino...";

            if (_lengthFile > 35 && _lengthFile < 50)
               statusProgress = "por favor aguarde mais alguns minutos...";

            if (_lengthFile > 50 && _lengthFile < 75)
               statusProgress= "gerando registros de dados divergentes...";

            if (_lengthFile > 75)
                statusProgress = "Finalizando divergências...";

            if (_lengthFile >= 93)
               statusProgress = "Aguarde a montagem do painel...";

            return statusProgress;
 
        }
       
        void ValidaCampo(EnumTabs tab)
        {
            switch (tab)
            {
                case EnumTabs.Resumo:
                    {
                        btnGerarResumo.Enabled = (!string.IsNullOrEmpty(txtPonteiro.Text) && !string.IsNullOrEmpty(txtRejeicao.Text));
                        break;
                    }
                case EnumTabs.DtiFinanciro:
                    {
                        if (!ValidaArquivo(txtDTIFinanceiro.Text).Equals("RELAT DTI13 FINAN UNIF"))
                        {
                            MessageBox.Show("O arquivo informado não é um DTI Financeiro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnGeraDTIFinanceiro.Enabled = false;
                            break;
                        }
                        btnGeraDTIFinanceiro.Enabled = !string.IsNullOrEmpty(txtDTIFinanceiro.Text);
                        break;
                    }
                case EnumTabs.DtiOcorrencia:
                    {
                        if (!ValidaArquivo(txtOcorrencia.Text).Equals("RELAT DTI13 OCORR UNIF"))
                        {
                            MessageBox.Show("O arquivo informado não é uma DTI de Ocorrência", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnGerarOcorrencia.Enabled = false;
                            break;
                        }
                        btnGerarOcorrencia.Enabled = !string.IsNullOrWhiteSpace(txtOcorrencia.Text);
                        break;
                    }
                case EnumTabs.DtiParcela:
                    {
                        if (!ValidaArquivo(txtDTIParcelas.Text).Equals("RELAT DTI13 PARCE UNIF"))
                        {
                            MessageBox.Show("O arquivo informado não é uma DTI de Parcelas", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            btnGerarParcelas.Enabled = false;
                            break;
                        }
                        btnGerarParcelas.Enabled = !string.IsNullOrWhiteSpace(txtDTIParcelas.Text);
                        break;
                    }
                default:
                    break;
            }
        }


        string ValidaArquivo(string _pathFile)
        {
            if (string.IsNullOrEmpty(_pathFile))
                return "";

            string arquivo = string.Empty;
            using (StreamReader texto = new StreamReader(_pathFile))
            {
                while (!texto.EndOfStream)
                {
                    arquivo = texto.ReadLine();
                    break;
                }
            }

            return arquivo;
        }

        private void btnPonteiro_Click(object sender, EventArgs e)
        {
            SelecionarArquivo();
        }

        private void btnRejeicoes_Click(object sender, EventArgs e)
        {
            SelecionarArquivo(1);
        }

        List<string> getPonteiro(bool consis = true)
        {
            List<string> lstPonteiro = new List<string>();
            using (StreamReader texto = new StreamReader(txtPonteiro.Text))
            {
                while (!texto.EndOfStream)
                {
                    if (consis)
                        lstPonteiro.Add(texto.ReadLine().Trim().Substring(2, 15));
                    else
                    {
                        lstPonteiro.Add(texto.ReadLine().Trim());
                        break;
                    }
                }
            };

            lstPonteiro = lstPonteiro.Distinct().ToList();
            return lstPonteiro;
        }

        List<ContratoPonteiro> getRejeicoes()
        {
            int index = 0;
            listRejeicao = new List<ContratoPonteiro>();
            using (StreamReader texto = new StreamReader(txtRejeicao.Text))
            {
                while (!texto.EndOfStream)
                {
                    if (index <= 2)
                    {
                        index++;
                        texto.ReadLine();
                        continue;
                    }

                    string[] str = texto.ReadLine().Split(';');

                    if (string.IsNullOrEmpty(str[0].Trim()))
                        continue;
                    ContratoPonteiro obj = new ContratoPonteiro()
                    {
                        Contrato = Regex.Replace(str[0].Trim(), @"[^0-9+,.$]+", ""),
                        Consistencia = string.IsNullOrEmpty(str[3].Trim()) ? str[4].Trim() + "-" + str[5].Trim() : str[3].Trim() + "-" + str[4].Trim() + "-" + str[5].Trim()
                    };
                    listRejeicao.Add(obj);
                }

            };

            return listRejeicao;
        }

        private void btnGerarResumo_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            lblper.Visible = !lblper.Visible;
            progressBar1.Visible = !progressBar1.Visible;
            reportViewer1.LocalReport.DataSources.Clear();
            listResumo.Clear();
            ReportDataSource rds = new ReportDataSource("DsResumo", listResumo.Distinct().AsEnumerable());
            reportViewer1.LocalReport.DataSources.Add(rds);

            lstPonteiro = getPonteiro();
            listRejeicao = getRejeicoes();
            progressBar1.Maximum = lstPonteiro.Count;
            tabControl1.Enabled = !tabControl1.Enabled;
            backgroundWorker1.RunWorkerAsync();

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            if (tabControl1.TabPages[0].Visible)
            {
                int item = 0;
                lstPonteiro.ForEach(x =>
                {
                    item++;
                    listResumo.AddRange(listRejeicao.Where(y => y.Contrato.Trim() == x.Trim()).GroupBy(k => k.Consistencia).Select(w => w.First()).ToList());
                    backgroundWorker1.ReportProgress(item);
                });

                reportViewer1.LocalReport.DataSources.Clear();
                ReportDataSource rds = new ReportDataSource("DsResumo", listResumo.AsEnumerable());
                reportViewer1.LocalReport.DataSources.Add(rds);
            }

            //#######################################   FINANCEIRO  ###############################################################

            if (tabControl1.TabPages[1].Visible)
            {
                _financeiro = new DTIFinanceiro();

                string _pathFile = txtDTIFinanceiro.Text;
                using (DbCom db = new DbCom())
                {
                    db.Configuration.AutoDetectChangesEnabled = false;
                    List<string> strContrato = new List<string>();

                    using (StreamReader texto = new StreamReader(_pathFile))
                    {
                        int index = 0, _count = 0, _countColumns = 0;
                        while (!texto.EndOfStream)
                        {
                            if (index++ < 3)
                            {
                                texto.ReadLine();
                                continue;
                            }

                            backgroundWorker1.ReportProgress(index);

                            if (texto == null)
                                break;

                            string[] linha = texto.ReadLine().Split(';');
                            strContrato.Clear();
                            Colunas.ColunasItem.ForEach(x => { strContrato.Add(linha[x].Trim()); });

                            int i = 0;
                            do
                            {
                                if (Colunas.excecao.Any(x => x == i))
                                {
                                    i += 2;
                                    continue;
                                }

                                if (i == 80 || i == 81)
                                {
                                    if (strContrato[i].Equals("00000000000") && strContrato[(i + 1)].Equals("99999999999"))
                                    {
                                        i += 2;
                                        continue;
                                    }
                                }

                                if (i == 82 || i == 83)
                                {
                                    if (strContrato[i].Equals("00000000") && strContrato[(i + 1)].Equals("99999999"))
                                    {
                                        i += 2;
                                        continue;
                                    }
                                }

                                if (i == 42 || i == 43 || i == 44 || i == 45)
                                {
                                    KeyValuePair<string, string> item = Colunas.PreencherPlanoCorrecaoIndexador().Find(x => x.Key == strContrato[i].Trim());

                                    if (strContrato[(i + 1)].Trim().Equals(item.Value))
                                    {
                                        i += 2;
                                        continue;
                                    }
                                    {
                                        ColunaDivergente obj = _financeiro.GetErro(i + 1, strContrato[0].Trim());
                                        db.ColunasDivergentes.Add(obj);
                                        _countColumns++;
                                    }
                                }
                                if (!strContrato[i + 1].Trim().Equals(strContrato[i].Trim()))
                                {
                                    if (Colunas.exc.Any(k => k == i))
                                    {
                                        bool comp = Regex.Replace(strContrato[i].Trim(), @"[^A-Za-z0-9$]+", " ").Trim().Equals(Regex.Replace(strContrato[i + 1].Trim(), @"[^A-Za-z0-9$]+", " ").Trim());

                                        if (comp)
                                        {
                                            i += 2;
                                            continue;
                                        }
                                        else
                                        {
                                            ColunaDivergente obj = _financeiro.GetErro(i + 1, strContrato[0].Trim());
                                            db.ColunasDivergentes.Add(obj);
                                            _countColumns++;
                                        }
                                    }
                                    else
                                    {
                                        ColunaDivergente obj = _financeiro.GetErro(i + 1, strContrato[0].Trim());
                                        db.ColunasDivergentes.Add(obj);
                                        _countColumns++;
                                    }
                                }

                                i += 2;
                            } while (i < strContrato.Count());

                            Finaceiro objF = _financeiro.CriaObjFinanceiro(strContrato.ToArray());
                            db.Financeiros.Add(objF);

                            if (_count++ >= 2000 || _countColumns >= 3000)
                            {
                                db.SaveChanges();
                                _count = _count >= 2000 ? 0 : _count;
                                _countColumns = _countColumns >= 3000 ? 0 : _countColumns;
                            }
                        }
                    }

                    if (db.ChangeTracker.HasChanges())
                        db.SaveChanges();

                    lstColunas = db.ColunasDivergentes.GroupBy(x => x.Indice).Select(g => new Divergencia() { Coluna = g.Key.ToString(), TotalErro = g.Count() }).ToList();
                }
            }

            //#######################################   OCORRENCIA  ###############################################################
            if (tabControl1.TabPages[2].Visible)
            {
                _ocorrencia = new DTIOcorrencia();
                string _pathFile = txtOcorrencia.Text;

                using (DbCom db = new DbCom())
                {
                    db.Configuration.AutoDetectChangesEnabled = false;
                    List<string> strContrato = new List<string>();

                    using (StreamReader texto = new StreamReader(_pathFile))
                    {
                        int index = 0, _count = 0, _countColumns = 0;
                        while (!texto.EndOfStream)
                        {
                            if (index++ < 3)
                            {
                                texto.ReadLine();
                                continue;
                            }

                            if (texto == null)
                                break;

                            backgroundWorker1.ReportProgress(index);

                            string[] linha = texto.ReadLine().Split(';');
                            strContrato.Clear();
                            Colunas.ColunasItemOcorrencia.ForEach(x => { strContrato.Add(linha[x].Trim()); });

                            int i = 0;
                            do
                            {
                                if (i == 18 )
                                {
                                    KeyValuePair<string, string> item = Colunas.PreencherPlanoCorrecaoIndexador().Find(x => x.Key == strContrato[i].Trim());

                                    if(item.Value == null)
                                    {
                                        i += 2;
                                        continue;
                                    }
                                    if (strContrato[(i + 1)].Trim().Equals(item.Value))
                                    {
                                        i += 2;
                                        continue;
                                    }
                                    {
                                        DivergenciaOcorrencia obj = _ocorrencia.GetErro(i + 1, strContrato[0].Trim());
                                        db.DivergenciasOcorrencias.Add(obj);
                                        _countColumns++;
                                    }
                                }
                                bool comp = Regex.Replace(strContrato[i].Trim(), @"[^A-Za-z0-9$]+", " ").Trim().Equals(Regex.Replace(strContrato[i + 1].Trim(), @"[^A-Za-z0-9$]+", " ").Trim());

                                if (comp)
                                {
                                    i += 2;
                                    continue;
                                }
                                else
                                {
                                    DivergenciaOcorrencia obj = _ocorrencia.GetErro(i + 1, strContrato[0].Trim());
                                    db.DivergenciasOcorrencias.Add(obj);
                                    _countColumns++;
                                }

                                i += 2;
                            } while (i < strContrato.Count());

                            Ocorrencia _objO = _ocorrencia.CriaObjOcorrencia(strContrato.ToArray());
                            db.Ocorrencias.Add(_objO);

                            if (_count++ >= 2000 || _countColumns >= 3000)
                            {
                                db.SaveChanges();
                                _count = _count >= 2000 ? 0 : _count;
                                _countColumns = _countColumns >= 3000 ? 0 : _countColumns;
                            }
                        }
                    }
                    if (db.ChangeTracker.HasChanges())
                        db.SaveChanges();
                   
                    lstColunas = db.DivergenciasOcorrencias.GroupBy(x => x.Indice).Select(g => new Divergencia() { Coluna = g.Key.ToString(), TotalErro = g.Count() }).ToList();
                }
            }

         //#######################################   PARCELAS  ###############################################################
            if (tabControl1.TabPages[3].Visible)
            {
                _parcela = new DTIParcela();
                string _pathFile = txtDTIParcelas.Text;
                List<Divergencia> lstDivergencia = new List<Divergencia>();

                using (DbCom db = new DbCom())
                {
                    db.Configuration.AutoDetectChangesEnabled = false;
                    List<string> strContrato = new List<string>();
                    string _contrato = string.Empty;

                    using (StreamReader texto = new StreamReader(_pathFile))
                    {
                        int index = 0, _count = 0, _countColunms = 0;
                        bool hasContrato = false;
                        while (!texto.EndOfStream)
                        {

                            if (index++ < 3)
                            {
                                texto.ReadLine();
                                continue;
                            }

                            if (texto == null)
                                break;

                            string[] linha = texto.ReadLine().Split(';');

                            if(string.IsNullOrWhiteSpace(_contrato))
                                _contrato = Regex.Replace(linha[0].Trim(), @"[^0-9$]+", "").Trim();
                            else
                            {
                                if (!_contrato.Equals(Regex.Replace(linha[0].Trim(), @"[^0-9$]+", "")))
                                {
                                    _contrato = Regex.Replace(linha[0].Trim(), @"[^0-9$]+", "");
                                    hasContrato = false;
                                }
                            }

                            backgroundWorker1.ReportProgress(index);

                            strContrato.Clear();
                            Colunas.ColunasParcelas.ForEach(x => { strContrato.Add(linha[x].Trim()); });

                            int i = 0;
                            do
                            {
                                if (i == 36)
                                {
                                    if(strContrato[i].Trim().Equals("00010101") && strContrato[(i+1)].Trim().Equals("00000000"))
                                    {
                                        i += 2;
                                        continue;
                                    }
                                }

                                if((i >= 2 && i <= 31) || (i >= 40 && i <= 50) || i == 56)
                                {
                                    long saidaOrigem;
                                    bool itemOritem = Int64.TryParse(strContrato[i].Trim(), out saidaOrigem);

                                    if(itemOritem)
                                    {
                                        long strDestino = !string.IsNullOrWhiteSpace(strContrato[(i + 1)].Trim()) ?  Convert.ToInt64(strContrato[(i + 1)].Trim()) : 0;
                                        bool ret = strDestino.Equals(saidaOrigem);

                                        if(!ret)
                                        {
                                            DivergenteParcela obj = _parcela.GetErro(i + 1, strContrato[0].Trim(), strContrato[2].Trim(), (!hasContrato ? 1 : 0));
                                            hasContrato = true;
                                            db.DivergenciasParcelas.Add(obj);
                                            _countColunms++;
                                        }
                                    }

                                    i += 2;
                                    continue;
                                }

                                bool comp = Regex.Replace(strContrato[i].Trim(), @"[^A-Za-z0-9$]+", "").Trim().Equals(Regex.Replace(strContrato[i + 1].Trim(), @"[^A-Za-z0-9$]+", "").Trim());

                                if (comp)
                                {
                                    i += 2;
                                    continue;
                                }
                                else
                                {
                                    DivergenteParcela obj = _parcela.GetErro(i + 1, strContrato[0].Trim(), strContrato[2].Trim(), (!hasContrato ? 1 : 0));
                                    hasContrato = true;
                                    db.DivergenciasParcelas.Add(obj);
                                    _countColunms++;
                                }


                                i += 2;
                            } while (i < strContrato.Count());

                            Parcela _objP = _parcela.CriaObjetoParcela(strContrato.ToArray());
                            db.Parcelas.Add(_objP);

                            if (_count++ >= 2000 || _countColunms >= 3000)
                            {
                                db.SaveChanges();
                                _countColunms = _countColunms >= 3000 ? 0 : _countColunms;
                                _count = _count >= 2000 ? 0 : _count;
                            }
                        }
                    }
                    if (db.ChangeTracker.HasChanges())
                        db.SaveChanges();
                   
                    lstColunas = db.DivergenciasParcelas.GroupBy(x => x.Indice).Select(g => new Divergencia() { Coluna = g.Key.ToString(), TotalErro = g.Count() }).ToList();
                    lstColunas.ForEach(s =>
                    {
                        int _coluna = Convert.ToInt32(s.Coluna);
                        s.TotalContrato = (int)db.DivergenciasParcelas.Where(w => w.Indice == _coluna).Count(g => g.CountContrato == 1);
                    });
                }
            }
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (tabControl1.TabPages[0].Visible)
            {
                progressBar1.Value = e.ProgressPercentage;
                lblper.Text = string.Format("{0:P2}", (double)e.ProgressPercentage / (double)(progressBar1.Maximum));
            }

            if (tabControl1.TabPages[1].Visible)
            {
                string tmp = string.Format("Tempo de Execução: {0}:{1}:{2}:{3} ms", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds);
                lblTimer.Text = tmp;

                progressBar2.Value = e.ProgressPercentage;
                lblDTIFian.Text = string.Format("{0:P2}", (double)e.ProgressPercentage / (double)(progressBar2.Maximum));
                int lengthFile = Convert.ToInt32(lblDTIFian.Text.Split(',')[0]);
               
                lblStatus.Text = StatusProgressFilw(lengthFile);
            }

            if (tabControl1.TabPages[2].Visible)
            {
                string tmp = string.Format("Tempo de Execução: {0}:{1}:{2}:{3} ms", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds);
                lblTimerOcorrencia.Text = tmp;

                progressBar3.Value = e.ProgressPercentage;
                lblPercOcorrencia.Text = string.Format("{0:P2}", (double)e.ProgressPercentage / (double)(progressBar3.Maximum));
                int lengthFile = Convert.ToInt32(lblPercOcorrencia.Text.Split(',')[0]);

                lblStatusOcorrencia.Text = StatusProgressFilw(lengthFile);
            }

            if (tabControl1.TabPages[3].Visible)
            {
                string tmp = string.Format("Tempo de Execução: {0}:{1}:{2}:{3} ms", stopwatch.Elapsed.Hours, stopwatch.Elapsed.Minutes, stopwatch.Elapsed.Seconds, stopwatch.Elapsed.Milliseconds);
                lblTimerParcelas.Text = tmp;

                progressBar4.Value = e.ProgressPercentage;
                lblPerceParcelas.Text = string.Format("{0:P2}", (double)e.ProgressPercentage / (double)(progressBar4.Maximum));
                int lengthFile = Convert.ToInt32(lblPerceParcelas.Text.Split(',')[0]);

                lblStatusPacelas.Text = StatusProgressFilw(lengthFile);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tabControl1.Enabled = !tabControl1.Enabled;
            if (tabControl1.TabPages[0].Visible)
            {
                var listGroup = listResumo.GroupBy(j => j.Consistencia).Select(g => new ContratoPonteiro { Consistencia = g.Key, TotalByContrato = g.Count() }).ToList();
                listGroup.Distinct().ToList().ForEach(x =>
                {
                    listResumo.Find(y => y.Consistencia.Trim() == x.Consistencia.Trim()).TotalByContrato = x.TotalByContrato;
                });

                progressBar1.Value = 0;
                progressBar1.Visible = !progressBar1.Visible;
                lblper.Visible = !lblper.Visible;
                lblTotaLinhas.Visible = !lblTotaLinhas.Visible;
                this.reportViewer1.RefreshReport();
            }

            if (tabControl1.TabPages[1].Visible)
            {
                stopwatch.Stop();
                PopulaButton(lstColunas, PnlBotton);
                progressBar2.Value = 0;
                lblStatus.Visible = !lblStatus.Visible;
                progressBar2.Visible = !progressBar2.Visible;
                lblDTIFian.Visible = !lblDTIFian.Visible;
            }

            if (tabControl1.TabPages[2].Visible)
            {
                stopwatch.Stop();
                PopulaButton(lstColunas, pnlButonnOcorrencia);
                progressBar3.Value = 0;
                lblStatusOcorrencia.Visible = !lblStatusOcorrencia.Visible;
                progressBar3.Visible = !progressBar3.Visible;
                lblPercOcorrencia.Visible = !lblPercOcorrencia.Visible;

                using (DbCom db = new DbCom())
                {
                    int[] _totalContrato = db.DivergenciasOcorrencias.GroupBy(n => n.Contrato).Select(g => g.Count()).ToArray();
                    lblTotalContratoOcorrencia.Text = "Total de Contratos: " + _totalContrato.Count();
                }
            }

            if (tabControl1.TabPages[3].Visible)
            {
                stopwatch.Stop();
                PopulaButton(lstColunas, pnlButttonParcelas);
                progressBar4.Value = 0;
                lblStatusPacelas.Visible = !lblStatusPacelas.Visible;
                progressBar4.Visible = !progressBar4.Visible;
                lblPerceParcelas.Visible = !lblPerceParcelas.Visible;
                lblTotalContratoParcelas.Visible = !lblTotalContratoParcelas.Visible;

                using (DbCom db = new DbCom())
                {
                    int _totalContrato = db.Parcelas.GroupBy(n => n.C0).Select(g => g.Count()).Count();
                    lblTotalContratoParcelas.Text = "Total de Contratos: " + _totalContrato;
                }
            }
        }

        private void btnFileDtiFinanceiro_Click(object sender, EventArgs e)
        {
            SelecionarArquivo(2, EnumTabs.DtiFinanciro);
        }

        void ResetaPainel(GroupBox _groupBox)
        {
            int index = 0;

            foreach (var itemi in _groupBox.Controls)
            {
                if (itemi.GetType() == typeof(Button))
                {
                    Button btn = (Button)itemi;
                    btn.Text = "-";
                    btn.ForeColor = Color.Black;
                    btn.Enabled = true;
                    index++;
                }
            }
        }

        void HabilitarCampo(EnumTabs _tab)
        {
            switch (_tab)
            {
                case EnumTabs.Resumo:
                    break;
                case EnumTabs.DtiFinanciro:
                    {
                        progressBar2.Visible = !progressBar2.Visible;
                        lblDTIFian.Visible = !lblDTIFian.Visible;
                        lblStatus.Visible = !lblStatus.Visible;
                        lblTotaLinhas.Visible = true;
                        lblTimer.Visible = true;
                        break;
                    }
                case EnumTabs.DtiContabil:
                    break;
                case EnumTabs.DtiOcorrencia:
                    {
                        progressBar3.Visible = !progressBar3.Visible;
                        lblPercOcorrencia.Visible = !lblPercOcorrencia.Visible;
                        lblStatusOcorrencia.Visible = !lblStatusOcorrencia.Visible;
                        lblTotalOcorrencia.Visible = true;
                        lblTimerOcorrencia.Visible = true;
                        break;
                    }
                case EnumTabs.DtiParcela:
                    {
                        progressBar4.Visible = !progressBar4.Visible;
                        lblPerceParcelas.Visible = !lblPerceParcelas.Visible;
                        lblStatusPacelas.Visible = !lblStatusPacelas.Visible;
                        lblTotalParcelas.Visible = true;
                        lblTimerParcelas.Visible = true;
                        break;
                    }
                default:
                    break;
            }

        }

        //################################ DTI FINANCEIRO ##########################################
        private void btnGeraDTIFinanceiro_Click(object sender, EventArgs e)
        {
            using (DbCom db = new DbCom())
            {
                if (db.Database.Exists())
                {
                    db.Database.ExecuteSqlCommand("DELETE FROM [TblColuna];");
                    db.Database.ExecuteSqlCommand("DELETE FROM [TblFinanceiro];");
                    ResetaPainel(this.PnlBotton);
                }
            }
            HabilitarCampo(EnumTabs.DtiFinanciro);
            tabControl1.Enabled = !tabControl1.Enabled;

            progressBar2.Maximum = Convert.ToInt32(File.ReadAllLines(txtDTIFinanceiro.Text).Count());
            lblTotaLinhas.Text = "Total de Contratos: " + (progressBar2.Maximum - 3).ToString();
            stopwatch.Reset();
            stopwatch.Start();
            
            backgroundWorker1.RunWorkerAsync();
        }

        void btn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PnlBotton.Enabled = false;
            groupBox2.Enabled = false;
            btnGeraDTIFinanceiro.Enabled = false;
            string _coluna = ((System.Windows.Forms.ButtonBase)(sender)).Text;
            _financeiro = new DTIFinanceiro();
            Finaceiro obj = _financeiro.CriaObjFinanceiro(Finaceiro.CabecalhaFin);

            List<Finaceiro> lstFinanceiro = PolulaColuas(Convert.ToInt32(_coluna.Split('-')[0]));
            lstFinanceiro.Insert(0, obj);
            Cursor.Current = Cursors.Default;
            frmGridContrato frm = new frmGridContrato(lstFinanceiro, EnumTabs.DtiFinanciro, Convert.ToInt32(_coluna.Split('-')[0]));
            frm.ShowDialog();
            btnGeraDTIFinanceiro.Enabled = true;
            groupBox2.Enabled = true;
            PnlBotton.Enabled = true;
        }

        List<Finaceiro> PolulaColuas(int _coluna)
        {
            using (DbCom db = new DbCom())
            {
                return db.Financeiros.Where(c => db.ColunasDivergentes.Any(g => g.Contrato == c.C0 && g.Indice == _coluna)).Take(100).ToList();
            }
        }

        void PopulaButton(List<Divergencia> lstConluas, GroupBox _groupBox)
        {
            
            int index = 0;
            ToolTip toolTipTxt;
            List<Button> lstButton = new List<Button>();

            foreach (var itemi in _groupBox.Controls)
            {
                if (itemi.GetType() == typeof(Button))
                {
                    Divergencia ec = lstConluas.ToList().Find(x => x.Coluna.Equals(index.ToString()));
                    Button btn = (Button)itemi;
                    btn.Name = "c" + Guid.NewGuid().ToString().Substring(0, 10) + index;
                    btn.TabIndex = index;

                    if (_groupBox == pnlButttonParcelas)
                        btn.Text = ec == null ? index.ToString() : index + " - " + ec.TotalErro.ToString() + " - " + ec.TotalContrato.ToString();
                    else
                        btn.Text = ec == null ? index.ToString() : index + " - " + ec.TotalErro.ToString();

                    if (ec != null)
                    {
                        toolTipTxt = new ToolTip();

                        if (tabControl1.TabPages[1].Visible)
                        {
                            btn.Click -= new EventHandler(btn_Click);
                            btn.Click += new EventHandler(btn_Click);
                            toolTipTxt.SetToolTip(btn, Finaceiro.CabecalhaFin[index]);
                        }

                        if (tabControl1.TabPages[2].Visible)
                        {
                            btn.Click -= new EventHandler(btnShowOcorrencias_Click);
                            btn.Click += new EventHandler(btnShowOcorrencias_Click);
                            toolTipTxt.SetToolTip(btn, Ocorrencia.cabecalhoOcorrencia[index]);
                        }

                        if (tabControl1.TabPages[3].Visible)
                        {
                            btn.Click -= new EventHandler(btnShowParcelas_Click);
                            btn.Click += new EventHandler(btnShowParcelas_Click);
                            toolTipTxt.SetToolTip(btn, Parcela.CabecalhoParcelas[index]);
                        }

                        btn.ForeColor = Color.Red;
                        btn.Enabled = true;
                    }
                    else
                    {
                        btn.Enabled = false;
                    }

                    index++;
                }
            }
        }

        private void frmResumo_Load(object sender, EventArgs e)
        {
            using (DbCom db = new DbCom())
            {
                if (db.Database.Exists())
                    db.Database.Delete();
            }
        }

        //################################ DTI OCORRENCIA ##########################################
        private void btnFileOcorrencia_Click(object sender, EventArgs e)
        {
            SelecionarArquivo(3, EnumTabs.DtiOcorrencia);


        }

        private void btnGerarOcorrencia_Click(object sender, EventArgs e)
        {
            using (DbCom db = new DbCom())
            {
                if (db.Database.Exists())
                {
                    db.Database.ExecuteSqlCommand("DELETE FROM [TblColunaOcorrencia];");
                    db.Database.ExecuteSqlCommand("DELETE FROM [TblOcorrencia];");
                    ResetaPainel(this.pnlButonnOcorrencia);
                }
            }
            HabilitarCampo(EnumTabs.DtiOcorrencia);
            tabControl1.Enabled = !tabControl1.Enabled;
            progressBar3.Maximum = Convert.ToInt32(File.ReadAllLines(txtOcorrencia.Text).Count());
            lblTotalOcorrencia.Text = "Total de Ocorrencias: " + (progressBar3.Maximum - 3).ToString();
            stopwatch.Reset();
            stopwatch.Start();
            backgroundWorker1.RunWorkerAsync();
        }

        private void btnShowOcorrencias_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            pnlButonnOcorrencia.Enabled = false;
            groupBox3.Enabled = false;
            btnGerarOcorrencia.Enabled = false;
            string _coluna = ((System.Windows.Forms.ButtonBase)(sender)).Text;
            _ocorrencia = new DTIOcorrencia();
            DataTable lstOcorrencia = PopulaColunasOcorrencia(Convert.ToInt32(_coluna.Split('-')[0]));
            Cursor.Current = Cursors.Default;
            frmGridContrato frm = new frmGridContrato(lstOcorrencia, EnumTabs.DtiOcorrencia, Convert.ToInt32(_coluna.Split('-')[0]));
            frm.ShowDialog();
            btnGerarOcorrencia.Enabled = true;
            groupBox3.Enabled = true;
            pnlButonnOcorrencia.Enabled = true;
        }

        DataTable PopulaColunasOcorrencia(int _coluna)
        {
            List<Ocorrencia> lstOcorrencia;
            using (DbCom db = new DbCom())
            {
                lstOcorrencia = db.Ocorrencias.Where(c => db.DivergenciasOcorrencias.Any(g => g.Contrato == c.C0 && g.Indice == _coluna)).Take(100).ToList();
            }

            Ocorrencia obj = _ocorrencia.CriaObjOcorrencia(Ocorrencia.cabecalhoOcorrencia);
            lstOcorrencia.Insert(0, obj);

            _ocorrencia = new DTIOcorrencia();
            return _ocorrencia.Filter(lstOcorrencia, _coluna); 
        }

        //################################ DTI PARCELAS ##########################################
        
        private void btnFileParcelas_Click(object sender, EventArgs e)
        {
            SelecionarArquivo(4, EnumTabs.DtiParcela);
        }

        private void btnGerarParcelas_Click(object sender, EventArgs e)
        {
            using (DbCom db = new DbCom())
            {
                if (db.Database.Exists())
                {
                    db.Database.ExecuteSqlCommand("DELETE FROM [TblColunaParcelas];");
                    db.Database.ExecuteSqlCommand("DELETE FROM [TblParcelas];");
                    ResetaPainel(this.pnlButttonParcelas);
                }
            }
            HabilitarCampo(EnumTabs.DtiParcela);
            tabControl1.Enabled = !tabControl1.Enabled;

            progressBar4.Maximum = Convert.ToInt32(File.ReadAllLines(txtDTIParcelas.Text).Count());
            lblTotalParcelas.Text = "Total de Parcelas: " + (progressBar4.Maximum - 3).ToString();
            stopwatch.Reset();
            stopwatch.Start();

            backgroundWorker1.RunWorkerAsync();
        }

        private void btnShowParcelas_Click(object sender, EventArgs e)
        {
            _parcela = new DTIParcela();
            Cursor.Current = Cursors.WaitCursor;
            pnlButttonParcelas.Enabled = !pnlButttonParcelas.Enabled;
            groupBox5.Enabled = !groupBox5.Enabled;
            btnGerarParcelas.Enabled = !btnGerarParcelas.Enabled;
            string _coluna = ((System.Windows.Forms.ButtonBase)(sender)).Text;
            _parcela = new DTIParcela();
            List<Parcela>  lstParcelas = _parcela.GetTop100(Convert.ToInt32(_coluna.Split('-')[0]));
            DataTable _dataTable = _parcela.Filter(lstParcelas);
            frmGridContrato frm = new frmGridContrato(_dataTable, EnumTabs.DtiParcela, Convert.ToInt32(_coluna.Split('-')[0]));
            Cursor.Current = Cursors.Default;
          
            frm.ShowDialog();
            pnlButttonParcelas.Enabled = !pnlButttonParcelas.Enabled;
            groupBox5.Enabled = !groupBox5.Enabled;
            btnGerarParcelas.Enabled = !btnGerarParcelas.Enabled;
        }

        private void frmResumo_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool ret = false;
           StringBuilder txtMessage = new StringBuilder();
            txtMessage.AppendLine("Os registros são temporariamente armazenados na ferramenta")
                .AppendLine("se optar por fechar, irá perder todos registros já carregados")
                .AppendLine()
                .AppendLine("Deseja proseguir e fechar o aplicativo ?");
            using (DbCom db = new DbCom())
            {
                ret = db.Database.Exists();
            }

            if(ret)
            {
                if(MessageBox.Show(txtMessage.ToString(), "Aviso de perda de dados", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.No )
                {
                    e.Cancel = true;
                }
            }
           
        }

        //DataTable PopulaColunasParcelas(int _coluna)
        //{
        //    List<Parcela> lstParcelas;
        //    using (DbCom db = new DbCom())
        //    {
        //        lstParcelas = db.Parcelas.Where(c => db.DivergenciasParcelas.Any(g => g.Contrato == c.C0 && g.Indice == _coluna)).Take(100).ToList();
        //    }

        //    Parcela obj = _parcela.CriaObjetoParcela(Parcela.CabecalhoParcelas);
        //    lstParcelas.Insert(0, obj);

        //    _parcela = new DTIParcela();
        //    return _parcela.Filter(lstParcelas, _coluna);
        //}





    }
}
