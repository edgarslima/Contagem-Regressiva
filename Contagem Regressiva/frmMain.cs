using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace Contagem_Regressiva
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private Font fontNumero;
        private Font fontTitulo;
        private frmScreen objFrmScreen;
        private string strImagemFundo;
        private clsDadosConfiguracao objConfiguracao;
        private int intIndiceMonitor;

        private void Carregar()
        {
            List<System.Windows.Forms.Screen> monitores = ScreenProperties.getAllScreens();

            foreach (System.Windows.Forms.Screen item in monitores)
            {
                cbMonitor.Items.Add(item.DeviceName);
            }
            if (intIndiceMonitor >= 0 && cbMonitor.Items.Count > 1)
            {
                cbMonitor.SelectedIndex = intIndiceMonitor;
            }
            if (monitores.Count == 1)
            {
                cbMonitor.SelectedItem = monitores[0].DeviceName;
            }
    

            if (fontNumero == null)
            {
                fontNumero = new Font("Bernard MT Condensed", 250, FontStyle.Bold);
            }
            tbFonteNumero.Text = fontNumero.Name.ToString() + ", " + fontNumero.Size.ToString() + ", " + fontNumero.Style.ToString();

            if (fontTitulo == null)
            {
                fontTitulo = new Font("Bernard MT Condensed", 26, FontStyle.Bold);
            }
            tbFonteTitulo.Text = fontTitulo.Name.ToString() + ", " + fontTitulo.Size.ToString() + ", " + fontTitulo.Style.ToString();


        }

        private void CarregaConfiguracao()
        {
            string strArquivo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            strArquivo += "\\config_contagem_regressiva.json";
            if (File.Exists(strArquivo) == false)
            {
                return;
            }
            string json = File.ReadAllText(strArquivo);
            objConfiguracao = JsonConvert.DeserializeObject<clsDadosConfiguracao>(json);

            tbTitulo.Text = objConfiguracao.Titulo;
            tbSubtitulo.Text = objConfiguracao.SubTitulo;
            fontTitulo = objConfiguracao.FonteTitulo;
            strImagemFundo = objConfiguracao.ImagemFundo;
            tbImagemFundo.Text = strImagemFundo;
            if (objConfiguracao.IndiceMonitor >= 0)
            {
                intIndiceMonitor = objConfiguracao.IndiceMonitor ;
            }
            if (objConfiguracao.ModoTela == enModoTela.Claro)
            {
                rbModoClaro.Checked = true;
            }else if (objConfiguracao.ModoTela == enModoTela.Escuro)
            {
                rbModoEscuro.Checked = true;
            }else if (objConfiguracao.ModoTela == enModoTela.Imagem)
            {
                rbModoImagem.Checked = true;
            }
            ckLetraPreta.Checked = objConfiguracao.LetraPreta;
            numTempo.Value = objConfiguracao.Tempo;
            tbIniciarEm.Text = objConfiguracao.IniciarEm;
            ckIniciarAutomatico.Checked = objConfiguracao.IniciarAutomatico;
            ckFecharAutomatico.Checked = objConfiguracao.FecharAutomatico;
            fontNumero = objConfiguracao.FonteNumero;


            /*
                    private int intTempo;
                    private string strIniciarEm;
                    private Boolean bolIniciarAutomatico;
                    private Boolean bolFecharAutomatico;
                    private Font objFonteNumero;

    */
        }

        private void cbFechar_Click(object sender, EventArgs e)
        {
            objFrmScreen.Close();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            CarregaConfiguracao();
            Carregar();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            IniciarForm();
        }

        private void IniciarForm(Boolean bolInicioAutomatico = false, int pIntSegundos = 0, Boolean bolPreview = false)
        {
            int intSegundos = 0;
            if (bolInicioAutomatico == false)
            {
                intSegundos = (int)numTempo.Value * 60;
            }
            else
            {
                if (pIntSegundos <= 0)
                {
                    intSegundos = (int)numTempo.Value * 60;
                }
                else
                {
                    intSegundos = pIntSegundos;
                }
                
            }
            if (Application.OpenForms.OfType<frmScreen>().Count() > 0)
            {
                return;
            }

            if (rbModoImagem.Checked == true && File.Exists(strImagemFundo) == false)
            {
                MessageBox.Show("Escolha uma imagem de fundo.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            objFrmScreen = new frmScreen();
            objFrmScreen.DeviceName = cbMonitor.SelectedText;
            objFrmScreen.FontNumero = fontNumero;
            objFrmScreen.FechaAutomatico = ckFecharAutomatico.Checked;
            objFrmScreen.TempoTotal = intSegundos;
            if (rbModoClaro.Checked == true)
            {
                objFrmScreen.ModoTela = enModoTela.Claro;
            }
            else if (rbModoEscuro.Checked == true)
            {
                objFrmScreen.ModoTela = enModoTela.Escuro;
            }
            else if (rbModoImagem.Checked == true)
            {
                objFrmScreen.ModoTela = enModoTela.Imagem;
            }
            objFrmScreen.ImagemFundo = strImagemFundo;
            objFrmScreen.LetrasPreta = ckLetraPreta.Checked;
            objFrmScreen.Titulo = tbTitulo.Text.Trim();
            objFrmScreen.Subtitulo = tbSubtitulo.Text.Trim() + " ";
            objFrmScreen.FontTitulo = fontTitulo;

            objFrmScreen.Start();

            if (bolPreview == true)
            {
                objFrmScreen.Location = Screen.PrimaryScreen.WorkingArea.Location;
                objFrmScreen.ControlBox = true;

            }
            else
            {
                objFrmScreen.Location = Screen.AllScreens[cbMonitor.SelectedIndex].WorkingArea.Location;
            }
            objFrmScreen.Show();
        }

        private void btnFonteNumero_Click(object sender, EventArgs e)
        {
            fontDialogEscolha.Font = fontNumero;
            fontDialogEscolha.ShowDialog(this);
            fontNumero = fontDialogEscolha.Font;
            tbFonteNumero.Text = fontNumero.Name.ToString() + ", " + fontNumero.Size.ToString() + ", " + fontNumero.Style.ToString();

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timerAutomatizar_Tick(object sender, EventArgs e)
        {
            if (Application.OpenForms.OfType<frmScreen>().Count() == 0)
            {
                btnIniciar.Enabled = true;
                btnFechar.Enabled = false;
            }
            else
            {
                btnIniciar.Enabled = false;
                btnFechar.Enabled = true;
            }
            if (ckIniciarAutomatico.Checked == true)
            {
                DateTime horaParametro = DateTime.ParseExact(tbIniciarEm.Text, "HH:mm", null);
                DateTime horaAtual = DateTime.Now;

                if (horaAtual >= horaParametro.AddMinutes((int)numTempo.Value * -1))
                {
                    TimeSpan span = horaParametro.Subtract(horaAtual);
                    IniciarForm(true, span.Seconds + ((span.Minutes) * 60));
                    ckIniciarAutomatico.Checked = false;
                }

            }
        }

        private void rbModoImagem_CheckedChanged(object sender, EventArgs e)
        {
            panelCorLetra.Enabled = rbModoImagem.Checked;
        }

        private void bntImagemFundo_Click(object sender, EventArgs e)
        {
            DialogResult arquivoSelecionado = openDialogImagem.ShowDialog();
            if (arquivoSelecionado == DialogResult.OK)
            {
                strImagemFundo = (string)openDialogImagem.FileNames[0];

                tbImagemFundo.Text = strImagemFundo;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            IniciarForm(true, 180, true);
        }

        private void btnFonteTitulo_Click(object sender, EventArgs e)
        {
            fontDialogEscolha.Font = fontTitulo;
            fontDialogEscolha.ShowDialog(this);
            fontTitulo = fontDialogEscolha.Font;
            tbFonteTitulo.Text = fontTitulo.Name.ToString() + ", " + fontTitulo.Size.ToString() + ", " + fontTitulo.Style.ToString();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            string strArquivo = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            strArquivo += "\\config_contagem_regressiva.json";

            clsDadosConfiguracao objConfig = new clsDadosConfiguracao();
            objConfig.Titulo = tbTitulo.Text;
            objConfig.SubTitulo = tbSubtitulo.Text;
            objConfig.FonteTitulo = fontTitulo;
            objConfig.ImagemFundo = strImagemFundo;
            if (rbModoEscuro.Checked == true)
            {
                objConfig.ModoTela = enModoTela.Escuro;
            }
            else if (rbModoClaro.Checked == true)
            {
                objConfig.ModoTela = enModoTela.Claro;
            }
            else if (rbModoImagem.Checked == true)
            {
                objConfig.ModoTela = enModoTela.Imagem;
            }

            objConfig.LetraPreta = ckLetraPreta.Checked;
            objConfig.IndiceMonitor = cbMonitor.SelectedIndex;
            objConfig.Tempo = (int)numTempo.Value;
            objConfig.IniciarEm = tbIniciarEm.Text;
            objConfig.IniciarAutomatico = ckIniciarAutomatico.Checked;
            objConfig.FecharAutomatico = ckFecharAutomatico.Checked;
            objConfig.FonteNumero = fontNumero;

            objConfig.Salvar(strArquivo);
            MessageBox.Show(String.Format( "Configuração salva com sucesso. \n Local: \n [{0}]" , strArquivo), "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            frmAbout objFrmAbout = new frmAbout();
            objFrmAbout.ShowDialog(this);

        }
    }
}
