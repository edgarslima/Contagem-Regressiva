using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contagem_Regressiva
{



    public partial class frmScreen : Form
    {
        public frmScreen()
        {
            InitializeComponent();
        }

        private string strDeviceName;
        private Font fontNumero;
        private Font fontTitulo;
        private int tempoTotal;
        private Boolean bolFechaAutomatico;
        private enModoTela modoTela;
        private string strImagemFundo;
        private Boolean bolLetrasPreta;
        private string strTitulo;
        private string strSubtitulo;

        public string DeviceName
        {
            get
            {
                return strDeviceName;
            }

            set
            {
                strDeviceName = value;
            }
        }

        public Font FontNumero
        {
            get
            {
                return fontNumero;
            }

            set
            {
                fontNumero = value;
            }
        }

        public int TempoTotal
        {
            get
            {
                return tempoTotal;
            }

            set
            {
                tempoTotal = value;
            }
        }

        public bool FechaAutomatico
        {
            get
            {
                return bolFechaAutomatico;
            }

            set
            {
                bolFechaAutomatico = value;
            }
        }

        public enModoTela ModoTela
        {
            get
            {
                return modoTela;
            }

            set
            {
                modoTela = value;
            }
        }

        public string ImagemFundo
        {
            get
            {
                return strImagemFundo;
            }

            set
            {
                strImagemFundo = value;
            }
        }

        public bool LetrasPreta
        {
            get
            {
                return bolLetrasPreta;
            }

            set
            {
                bolLetrasPreta = value;
            }
        }

        public string Titulo
        {
            get
            {
                return strTitulo;
            }

            set
            {
                strTitulo = value;
            }
        }

        public string Subtitulo
        {
            get
            {
                return strSubtitulo;
            }

            set
            {
                strSubtitulo = value;
            }
        }

        public Font FontTitulo
        {
            get
            {
                return fontTitulo;
            }

            set
            {
                fontTitulo = value;
            }
        }

        private void MontaTela()
        {
            try
            {





                if (modoTela == enModoTela.Claro)
                {
                    this.BackColor = Color.White;
                    laTimer.ForeColor = Color.Black;
                    laTitulo.ForeColor = Color.Black;
                    laSubtitulo.ForeColor = Color.Black;
                }
                else if (modoTela == enModoTela.Escuro)
                {
                    this.BackColor = Color.Black;
                    laTimer.ForeColor = Color.White;
                    laTitulo.ForeColor = Color.White;
                    laSubtitulo.ForeColor = Color.White;
                }
                else if (modoTela == enModoTela.Imagem && bolLetrasPreta == true)
                {
                    this.BackColor = Color.White;
                    laTimer.ForeColor = Color.Black;
                    laTitulo.ForeColor = Color.Black;
                    laSubtitulo.ForeColor = Color.Black;
                }
                else if (modoTela == enModoTela.Imagem && bolLetrasPreta == false)
                {
                    this.BackColor = Color.Black;
                    laTimer.ForeColor = Color.White;
                    laTitulo.ForeColor = Color.White;
                    laSubtitulo.ForeColor = Color.White;
                }


                // Label Timer
                Font objFonte = fontNumero;
                laTimer.Font = objFonte;

                int alturaTotal = this.Height;  // ScreenProperties.getCurrentScreenHeight();
                int larguraTotal = this.Width; // ScreenProperties.getCurrentScreenWidth();

                int alturaLabelTimer = laTimer.Height;
                int larguraLabelTimer = laTimer.Width;

                int laTimerPosicaoX = (larguraTotal - larguraLabelTimer) / 2;
                int laTimerPosicaoY = (alturaTotal - alturaLabelTimer) / 2;

                laTimer.Location = new Point(laTimerPosicaoX, laTimerPosicaoY);
                laTimer.Parent = pbImagemFundo;
                laTimer.BackColor = Color.Transparent;

                pbImagemFundo.Location = new Point(0, 0);
                pbImagemFundo.Size = new Size(larguraTotal, alturaTotal);
                if (strImagemFundo != "" && modoTela == enModoTela.Imagem && strImagemFundo != null)
                {
                    pbImagemFundo.Image = Image.FromFile(strImagemFundo);
                }
                else
                {
                    pbImagemFundo.Image = null;
                }

                laTitulo.Parent = pbImagemFundo;
                laTitulo.BackColor = Color.Transparent;
                laTitulo.Location = new Point(larguraTotal - laTitulo.Width - 30, 80);
                laTitulo.Text = strTitulo;
                laTitulo.Font = fontTitulo;


                laSubtitulo.Parent = pbImagemFundo;
                laSubtitulo.BackColor = Color.Transparent;
                laSubtitulo.Location = new Point(larguraTotal - laSubtitulo.Width - 30, laTitulo.Height + 90);
                laSubtitulo.Text = strSubtitulo;
                laSubtitulo.Font = new Font(fontTitulo.FontFamily, (int)Math.Round(fontTitulo.Size * 0.69, 0), fontTitulo.Style);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + Environment.NewLine + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void Start()
        {
            try
            {
                timerContagem.Enabled = true;
                MontaTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + Environment.NewLine + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmScreen_Load(object sender, EventArgs e)
        {
            laTimer.Visible = false;
        }

        private void frmScreen_Paint(object sender, PaintEventArgs e)
        {
            MontaTela();
        }

        private void timerContagem_Tick(object sender, EventArgs e)
        {

            try
            {
                DateTime dt = new DateTime();
                if (tempoTotal >= 0)
                {
                    dt = dt.AddSeconds(tempoTotal);
                    string hora = dt.ToString("mm:ss");
                    laTimer.Text = hora;
                    laTimer.Visible = true;
                }
                else
                {
                    laTimer.Text = "00:00";
                    laTimer.Visible = true;
                }


                if (tempoTotal == -1)
                {
                    timerContagem.Enabled = false;
                    if (FechaAutomatico == true)
                    {
                        this.Close();
                    }
                }
                tempoTotal--;
                MontaTela();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + Environment.NewLine + ex.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmScreen_ResizeEnd(object sender, EventArgs e)
        {
            MontaTela();

        }
    }
}
