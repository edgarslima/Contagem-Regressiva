namespace Contagem_Regressiva
{
    partial class frmScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmScreen));
            this.laTimer = new System.Windows.Forms.Label();
            this.timerContagem = new System.Windows.Forms.Timer(this.components);
            this.pbImagemFundo = new System.Windows.Forms.PictureBox();
            this.laTitulo = new System.Windows.Forms.Label();
            this.laSubtitulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // laTimer
            // 
            this.laTimer.AutoSize = true;
            this.laTimer.Font = new System.Drawing.Font("Segoe UI", 105.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTimer.Location = new System.Drawing.Point(12, 243);
            this.laTimer.Name = "laTimer";
            this.laTimer.Size = new System.Drawing.Size(441, 187);
            this.laTimer.TabIndex = 0;
            this.laTimer.Text = "03:00";
            this.laTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerContagem
            // 
            this.timerContagem.Interval = 1000;
            this.timerContagem.Tick += new System.EventHandler(this.timerContagem_Tick);
            // 
            // pbImagemFundo
            // 
            this.pbImagemFundo.Image = ((System.Drawing.Image)(resources.GetObject("pbImagemFundo.Image")));
            this.pbImagemFundo.Location = new System.Drawing.Point(-1, -2);
            this.pbImagemFundo.Name = "pbImagemFundo";
            this.pbImagemFundo.Size = new System.Drawing.Size(722, 456);
            this.pbImagemFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImagemFundo.TabIndex = 1;
            this.pbImagemFundo.TabStop = false;
            // 
            // laTitulo
            // 
            this.laTitulo.AutoSize = true;
            this.laTitulo.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laTitulo.Location = new System.Drawing.Point(177, 9);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(1194, 47);
            this.laTitulo.TabIndex = 2;
            this.laTitulo.Text = "O Evangelho odiado pelos evangélicos (Lucas 4.16-30) - Valter Reggiani";
            this.laTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // laSubtitulo
            // 
            this.laSubtitulo.AutoSize = true;
            this.laSubtitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.laSubtitulo.Location = new System.Drawing.Point(177, 65);
            this.laSubtitulo.Name = "laSubtitulo";
            this.laSubtitulo.Size = new System.Drawing.Size(833, 32);
            this.laSubtitulo.TabIndex = 3;
            this.laSubtitulo.Text = "O Evangelho odiado pelos evangélicos (Lucas 4.16-30) - Valter Reggiani";
            this.laSubtitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 466);
            this.ControlBox = false;
            this.Controls.Add(this.laSubtitulo);
            this.Controls.Add(this.laTitulo);
            this.Controls.Add(this.laTimer);
            this.Controls.Add(this.pbImagemFundo);
            this.Name = "frmScreen";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmScreen_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.frmScreen_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbImagemFundo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label laTimer;
        private System.Windows.Forms.Timer timerContagem;
        private System.Windows.Forms.PictureBox pbImagemFundo;
        private System.Windows.Forms.Label laTitulo;
        private System.Windows.Forms.Label laSubtitulo;
    }
}