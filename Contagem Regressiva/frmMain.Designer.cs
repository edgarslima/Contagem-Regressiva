namespace Contagem_Regressiva
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.grpConfiguracoes = new System.Windows.Forms.GroupBox();
            this.btnFonteTitulo = new System.Windows.Forms.Button();
            this.tbFonteTitulo = new System.Windows.Forms.TextBox();
            this.laFonteTitulo = new System.Windows.Forms.Label();
            this.panelCorLetra = new System.Windows.Forms.Panel();
            this.ckLetraPreta = new System.Windows.Forms.CheckBox();
            this.bntImagemFundo = new System.Windows.Forms.Button();
            this.tbImagemFundo = new System.Windows.Forms.TextBox();
            this.laImagemFundo = new System.Windows.Forms.Label();
            this.btnFonteNumero = new System.Windows.Forms.Button();
            this.tbFonteNumero = new System.Windows.Forms.TextBox();
            this.laFonteNumero = new System.Windows.Forms.Label();
            this.ckFecharAutomatico = new System.Windows.Forms.CheckBox();
            this.ckIniciarAutomatico = new System.Windows.Forms.CheckBox();
            this.laIniciarEm = new System.Windows.Forms.Label();
            this.tbIniciarEm = new System.Windows.Forms.MaskedTextBox();
            this.laTempoMinutos = new System.Windows.Forms.Label();
            this.numTempo = new System.Windows.Forms.NumericUpDown();
            this.laTempo = new System.Windows.Forms.Label();
            this.rbModoImagem = new System.Windows.Forms.RadioButton();
            this.cbMonitor = new System.Windows.Forms.ComboBox();
            this.laMonitor = new System.Windows.Forms.Label();
            this.laModo = new System.Windows.Forms.Label();
            this.rbModoClaro = new System.Windows.Forms.RadioButton();
            this.rbModoEscuro = new System.Windows.Forms.RadioButton();
            this.tbSubtitulo = new System.Windows.Forms.TextBox();
            this.laSubtitulo = new System.Windows.Forms.Label();
            this.tbTitulo = new System.Windows.Forms.TextBox();
            this.laTitulo = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.fontDialogEscolha = new System.Windows.Forms.FontDialog();
            this.btnSair = new System.Windows.Forms.Button();
            this.timerAutomatizar = new System.Windows.Forms.Timer(this.components);
            this.openDialogImagem = new System.Windows.Forms.OpenFileDialog();
            this.btnPreview = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.grpConfiguracoes.SuspendLayout();
            this.panelCorLetra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpConfiguracoes
            // 
            this.grpConfiguracoes.Controls.Add(this.btnFonteTitulo);
            this.grpConfiguracoes.Controls.Add(this.tbFonteTitulo);
            this.grpConfiguracoes.Controls.Add(this.laFonteTitulo);
            this.grpConfiguracoes.Controls.Add(this.panelCorLetra);
            this.grpConfiguracoes.Controls.Add(this.bntImagemFundo);
            this.grpConfiguracoes.Controls.Add(this.tbImagemFundo);
            this.grpConfiguracoes.Controls.Add(this.laImagemFundo);
            this.grpConfiguracoes.Controls.Add(this.btnFonteNumero);
            this.grpConfiguracoes.Controls.Add(this.tbFonteNumero);
            this.grpConfiguracoes.Controls.Add(this.laFonteNumero);
            this.grpConfiguracoes.Controls.Add(this.ckFecharAutomatico);
            this.grpConfiguracoes.Controls.Add(this.ckIniciarAutomatico);
            this.grpConfiguracoes.Controls.Add(this.laIniciarEm);
            this.grpConfiguracoes.Controls.Add(this.tbIniciarEm);
            this.grpConfiguracoes.Controls.Add(this.laTempoMinutos);
            this.grpConfiguracoes.Controls.Add(this.numTempo);
            this.grpConfiguracoes.Controls.Add(this.laTempo);
            this.grpConfiguracoes.Controls.Add(this.rbModoImagem);
            this.grpConfiguracoes.Controls.Add(this.cbMonitor);
            this.grpConfiguracoes.Controls.Add(this.laMonitor);
            this.grpConfiguracoes.Controls.Add(this.laModo);
            this.grpConfiguracoes.Controls.Add(this.rbModoClaro);
            this.grpConfiguracoes.Controls.Add(this.rbModoEscuro);
            this.grpConfiguracoes.Controls.Add(this.tbSubtitulo);
            this.grpConfiguracoes.Controls.Add(this.laSubtitulo);
            this.grpConfiguracoes.Controls.Add(this.tbTitulo);
            this.grpConfiguracoes.Controls.Add(this.laTitulo);
            this.grpConfiguracoes.Location = new System.Drawing.Point(12, 12);
            this.grpConfiguracoes.Name = "grpConfiguracoes";
            this.grpConfiguracoes.Size = new System.Drawing.Size(513, 374);
            this.grpConfiguracoes.TabIndex = 0;
            this.grpConfiguracoes.TabStop = false;
            this.grpConfiguracoes.Text = "Configurações";
            // 
            // btnFonteTitulo
            // 
            this.btnFonteTitulo.Location = new System.Drawing.Point(478, 95);
            this.btnFonteTitulo.Name = "btnFonteTitulo";
            this.btnFonteTitulo.Size = new System.Drawing.Size(29, 20);
            this.btnFonteTitulo.TabIndex = 26;
            this.btnFonteTitulo.Text = "...";
            this.btnFonteTitulo.UseVisualStyleBackColor = true;
            this.btnFonteTitulo.Click += new System.EventHandler(this.btnFonteTitulo_Click);
            // 
            // tbFonteTitulo
            // 
            this.tbFonteTitulo.BackColor = System.Drawing.SystemColors.Control;
            this.tbFonteTitulo.Location = new System.Drawing.Point(97, 95);
            this.tbFonteTitulo.Name = "tbFonteTitulo";
            this.tbFonteTitulo.ReadOnly = true;
            this.tbFonteTitulo.Size = new System.Drawing.Size(375, 20);
            this.tbFonteTitulo.TabIndex = 25;
            // 
            // laFonteTitulo
            // 
            this.laFonteTitulo.AutoSize = true;
            this.laFonteTitulo.Location = new System.Drawing.Point(6, 98);
            this.laFonteTitulo.Name = "laFonteTitulo";
            this.laFonteTitulo.Size = new System.Drawing.Size(80, 13);
            this.laFonteTitulo.TabIndex = 24;
            this.laFonteTitulo.Text = "Fonte do Título";
            // 
            // panelCorLetra
            // 
            this.panelCorLetra.Controls.Add(this.ckLetraPreta);
            this.panelCorLetra.Enabled = false;
            this.panelCorLetra.Location = new System.Drawing.Point(266, 170);
            this.panelCorLetra.Name = "panelCorLetra";
            this.panelCorLetra.Size = new System.Drawing.Size(238, 29);
            this.panelCorLetra.TabIndex = 23;
            // 
            // ckLetraPreta
            // 
            this.ckLetraPreta.AutoSize = true;
            this.ckLetraPreta.Checked = true;
            this.ckLetraPreta.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckLetraPreta.Location = new System.Drawing.Point(3, 9);
            this.ckLetraPreta.Name = "ckLetraPreta";
            this.ckLetraPreta.Size = new System.Drawing.Size(78, 17);
            this.ckLetraPreta.TabIndex = 0;
            this.ckLetraPreta.Text = "Letra Preta";
            this.ckLetraPreta.UseVisualStyleBackColor = true;
            // 
            // bntImagemFundo
            // 
            this.bntImagemFundo.Location = new System.Drawing.Point(478, 121);
            this.bntImagemFundo.Name = "bntImagemFundo";
            this.bntImagemFundo.Size = new System.Drawing.Size(29, 20);
            this.bntImagemFundo.TabIndex = 22;
            this.bntImagemFundo.Text = "...";
            this.bntImagemFundo.UseVisualStyleBackColor = true;
            this.bntImagemFundo.Click += new System.EventHandler(this.bntImagemFundo_Click);
            // 
            // tbImagemFundo
            // 
            this.tbImagemFundo.BackColor = System.Drawing.SystemColors.Control;
            this.tbImagemFundo.Location = new System.Drawing.Point(97, 121);
            this.tbImagemFundo.Name = "tbImagemFundo";
            this.tbImagemFundo.ReadOnly = true;
            this.tbImagemFundo.Size = new System.Drawing.Size(375, 20);
            this.tbImagemFundo.TabIndex = 21;
            // 
            // laImagemFundo
            // 
            this.laImagemFundo.AutoSize = true;
            this.laImagemFundo.Location = new System.Drawing.Point(6, 124);
            this.laImagemFundo.Name = "laImagemFundo";
            this.laImagemFundo.Size = new System.Drawing.Size(92, 13);
            this.laImagemFundo.TabIndex = 20;
            this.laImagemFundo.Text = "Imagem de Fundo";
            // 
            // btnFonteNumero
            // 
            this.btnFonteNumero.Location = new System.Drawing.Point(478, 306);
            this.btnFonteNumero.Name = "btnFonteNumero";
            this.btnFonteNumero.Size = new System.Drawing.Size(29, 20);
            this.btnFonteNumero.TabIndex = 19;
            this.btnFonteNumero.Text = "...";
            this.btnFonteNumero.UseVisualStyleBackColor = true;
            this.btnFonteNumero.Click += new System.EventHandler(this.btnFonteNumero_Click);
            // 
            // tbFonteNumero
            // 
            this.tbFonteNumero.BackColor = System.Drawing.SystemColors.Control;
            this.tbFonteNumero.Location = new System.Drawing.Point(97, 306);
            this.tbFonteNumero.Name = "tbFonteNumero";
            this.tbFonteNumero.ReadOnly = true;
            this.tbFonteNumero.Size = new System.Drawing.Size(375, 20);
            this.tbFonteNumero.TabIndex = 18;
            // 
            // laFonteNumero
            // 
            this.laFonteNumero.AutoSize = true;
            this.laFonteNumero.Location = new System.Drawing.Point(6, 309);
            this.laFonteNumero.Name = "laFonteNumero";
            this.laFonteNumero.Size = new System.Drawing.Size(89, 13);
            this.laFonteNumero.TabIndex = 17;
            this.laFonteNumero.Text = "Fonte do Número";
            // 
            // ckFecharAutomatico
            // 
            this.ckFecharAutomatico.AutoSize = true;
            this.ckFecharAutomatico.Checked = true;
            this.ckFecharAutomatico.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ckFecharAutomatico.Location = new System.Drawing.Point(277, 282);
            this.ckFecharAutomatico.Name = "ckFecharAutomatico";
            this.ckFecharAutomatico.Size = new System.Drawing.Size(115, 17);
            this.ckFecharAutomatico.TabIndex = 16;
            this.ckFecharAutomatico.Text = "Fechar Automático";
            this.ckFecharAutomatico.UseVisualStyleBackColor = true;
            // 
            // ckIniciarAutomatico
            // 
            this.ckIniciarAutomatico.AutoSize = true;
            this.ckIniciarAutomatico.Location = new System.Drawing.Point(161, 282);
            this.ckIniciarAutomatico.Name = "ckIniciarAutomatico";
            this.ckIniciarAutomatico.Size = new System.Drawing.Size(110, 17);
            this.ckIniciarAutomatico.TabIndex = 15;
            this.ckIniciarAutomatico.Text = "Iniciar Automático";
            this.ckIniciarAutomatico.UseVisualStyleBackColor = true;
            // 
            // laIniciarEm
            // 
            this.laIniciarEm.AutoSize = true;
            this.laIniciarEm.Location = new System.Drawing.Point(6, 283);
            this.laIniciarEm.Name = "laIniciarEm";
            this.laIniciarEm.Size = new System.Drawing.Size(52, 13);
            this.laIniciarEm.TabIndex = 14;
            this.laIniciarEm.Text = "Iniciar em";
            // 
            // tbIniciarEm
            // 
            this.tbIniciarEm.Location = new System.Drawing.Point(97, 280);
            this.tbIniciarEm.Mask = "00:00";
            this.tbIniciarEm.Name = "tbIniciarEm";
            this.tbIniciarEm.Size = new System.Drawing.Size(58, 20);
            this.tbIniciarEm.TabIndex = 13;
            this.tbIniciarEm.Text = "1900";
            this.tbIniciarEm.ValidatingType = typeof(System.DateTime);
            // 
            // laTempoMinutos
            // 
            this.laTempoMinutos.AutoSize = true;
            this.laTempoMinutos.Location = new System.Drawing.Point(161, 256);
            this.laTempoMinutos.Name = "laTempoMinutos";
            this.laTempoMinutos.Size = new System.Drawing.Size(44, 13);
            this.laTempoMinutos.TabIndex = 12;
            this.laTempoMinutos.Text = "Minutos";
            // 
            // numTempo
            // 
            this.numTempo.Location = new System.Drawing.Point(97, 254);
            this.numTempo.Name = "numTempo";
            this.numTempo.Size = new System.Drawing.Size(58, 20);
            this.numTempo.TabIndex = 11;
            this.numTempo.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // laTempo
            // 
            this.laTempo.AutoSize = true;
            this.laTempo.Location = new System.Drawing.Point(6, 256);
            this.laTempo.Name = "laTempo";
            this.laTempo.Size = new System.Drawing.Size(40, 13);
            this.laTempo.TabIndex = 10;
            this.laTempo.Text = "Tempo";
            // 
            // rbModoImagem
            // 
            this.rbModoImagem.AutoSize = true;
            this.rbModoImagem.Location = new System.Drawing.Point(269, 147);
            this.rbModoImagem.Name = "rbModoImagem";
            this.rbModoImagem.Size = new System.Drawing.Size(110, 17);
            this.rbModoImagem.TabIndex = 9;
            this.rbModoImagem.Text = "Imagem de Fundo";
            this.rbModoImagem.UseVisualStyleBackColor = true;
            this.rbModoImagem.CheckedChanged += new System.EventHandler(this.rbModoImagem_CheckedChanged);
            // 
            // cbMonitor
            // 
            this.cbMonitor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMonitor.FormattingEnabled = true;
            this.cbMonitor.Location = new System.Drawing.Point(97, 210);
            this.cbMonitor.Name = "cbMonitor";
            this.cbMonitor.Size = new System.Drawing.Size(410, 21);
            this.cbMonitor.TabIndex = 8;
            // 
            // laMonitor
            // 
            this.laMonitor.AutoSize = true;
            this.laMonitor.Location = new System.Drawing.Point(6, 213);
            this.laMonitor.Name = "laMonitor";
            this.laMonitor.Size = new System.Drawing.Size(42, 13);
            this.laMonitor.TabIndex = 7;
            this.laMonitor.Text = "Monitor";
            // 
            // laModo
            // 
            this.laModo.AutoSize = true;
            this.laModo.Location = new System.Drawing.Point(6, 149);
            this.laModo.Name = "laModo";
            this.laModo.Size = new System.Drawing.Size(34, 13);
            this.laModo.TabIndex = 6;
            this.laModo.Text = "Modo";
            // 
            // rbModoClaro
            // 
            this.rbModoClaro.AutoSize = true;
            this.rbModoClaro.Location = new System.Drawing.Point(183, 147);
            this.rbModoClaro.Name = "rbModoClaro";
            this.rbModoClaro.Size = new System.Drawing.Size(49, 17);
            this.rbModoClaro.TabIndex = 5;
            this.rbModoClaro.Text = "Claro";
            this.rbModoClaro.UseVisualStyleBackColor = true;
            // 
            // rbModoEscuro
            // 
            this.rbModoEscuro.AutoSize = true;
            this.rbModoEscuro.Checked = true;
            this.rbModoEscuro.Location = new System.Drawing.Point(97, 147);
            this.rbModoEscuro.Name = "rbModoEscuro";
            this.rbModoEscuro.Size = new System.Drawing.Size(58, 17);
            this.rbModoEscuro.TabIndex = 4;
            this.rbModoEscuro.TabStop = true;
            this.rbModoEscuro.Text = "Escuro";
            this.rbModoEscuro.UseVisualStyleBackColor = true;
            // 
            // tbSubtitulo
            // 
            this.tbSubtitulo.Location = new System.Drawing.Point(97, 69);
            this.tbSubtitulo.Name = "tbSubtitulo";
            this.tbSubtitulo.Size = new System.Drawing.Size(410, 20);
            this.tbSubtitulo.TabIndex = 3;
            this.tbSubtitulo.Text = "Valter Reggiani";
            // 
            // laSubtitulo
            // 
            this.laSubtitulo.AutoSize = true;
            this.laSubtitulo.Location = new System.Drawing.Point(6, 72);
            this.laSubtitulo.Name = "laSubtitulo";
            this.laSubtitulo.Size = new System.Drawing.Size(50, 13);
            this.laSubtitulo.TabIndex = 2;
            this.laSubtitulo.Text = "Subtítulo";
            // 
            // tbTitulo
            // 
            this.tbTitulo.Location = new System.Drawing.Point(97, 43);
            this.tbTitulo.Name = "tbTitulo";
            this.tbTitulo.Size = new System.Drawing.Size(410, 20);
            this.tbTitulo.TabIndex = 1;
            this.tbTitulo.Text = "O Evangelho odiado pelos evangélicos (Lucas 4.16-30)";
            // 
            // laTitulo
            // 
            this.laTitulo.AutoSize = true;
            this.laTitulo.Location = new System.Drawing.Point(6, 46);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(33, 13);
            this.laTitulo.TabIndex = 0;
            this.laTitulo.Text = "Titulo";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(450, 392);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "&Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Enabled = false;
            this.btnFechar.Location = new System.Drawing.Point(369, 392);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 1;
            this.btnFechar.Text = "&Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.cbFechar_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(12, 392);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(75, 23);
            this.btnAbout.TabIndex = 2;
            this.btnAbout.Text = "So&bre";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(207, 392);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "&Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // timerAutomatizar
            // 
            this.timerAutomatizar.Enabled = true;
            this.timerAutomatizar.Interval = 1000;
            this.timerAutomatizar.Tick += new System.EventHandler(this.timerAutomatizar_Tick);
            // 
            // openDialogImagem
            // 
            this.openDialogImagem.FileName = "openFileDialog1";
            this.openDialogImagem.Filter = "\"Imagem de Fundo|*.png;*.jpg;*.gif;*.bmp\"";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(288, 392);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(75, 23);
            this.btnPreview.TabIndex = 4;
            this.btnPreview.Text = "&Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(126, 392);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 427);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.grpConfiguracoes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contagem Regressiva - Beta 0.0.1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grpConfiguracoes.ResumeLayout(false);
            this.grpConfiguracoes.PerformLayout();
            this.panelCorLetra.ResumeLayout(false);
            this.panelCorLetra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numTempo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpConfiguracoes;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox tbSubtitulo;
        private System.Windows.Forms.Label laSubtitulo;
        private System.Windows.Forms.TextBox tbTitulo;
        private System.Windows.Forms.Label laTitulo;
        private System.Windows.Forms.Label laModo;
        private System.Windows.Forms.RadioButton rbModoClaro;
        private System.Windows.Forms.RadioButton rbModoEscuro;
        private System.Windows.Forms.ComboBox cbMonitor;
        private System.Windows.Forms.Label laMonitor;
        private System.Windows.Forms.RadioButton rbModoImagem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.CheckBox ckIniciarAutomatico;
        private System.Windows.Forms.Label laIniciarEm;
        private System.Windows.Forms.MaskedTextBox tbIniciarEm;
        private System.Windows.Forms.Label laTempoMinutos;
        private System.Windows.Forms.NumericUpDown numTempo;
        private System.Windows.Forms.Label laTempo;
        private System.Windows.Forms.CheckBox ckFecharAutomatico;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnFonteNumero;
        private System.Windows.Forms.TextBox tbFonteNumero;
        private System.Windows.Forms.Label laFonteNumero;
        private System.Windows.Forms.FontDialog fontDialogEscolha;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Timer timerAutomatizar;
        private System.Windows.Forms.Button bntImagemFundo;
        private System.Windows.Forms.TextBox tbImagemFundo;
        private System.Windows.Forms.Label laImagemFundo;
        private System.Windows.Forms.Panel panelCorLetra;
        private System.Windows.Forms.CheckBox ckLetraPreta;
        private System.Windows.Forms.OpenFileDialog openDialogImagem;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Button btnFonteTitulo;
        private System.Windows.Forms.TextBox tbFonteTitulo;
        private System.Windows.Forms.Label laFonteTitulo;
        private System.Windows.Forms.Button btnSalvar;
    }
}

