using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Contagem_Regressiva
{
    class clsDadosConfiguracao
    {

        private string strTitulo;
        private string strSubTitulo;
        private Font objFonteTitulo;
        private string strImagemFundo;
        private enModoTela objModoTela;
        private Boolean bolLetraPreta;
        private int intIndiceMonitor;
        private int intTempo;
        private string strIniciarEm;
        private Boolean bolIniciarAutomatico;
        private Boolean bolFecharAutomatico;
        private Font objFonteNumero;


        public void Salvar(string strArquivo)
        {

            if (File.Exists (strArquivo) == true)
            {
                File.Delete(strArquivo);
            }
            JsonSerializer serializer = new JsonSerializer();
            serializer.Converters.Add(new JavaScriptDateTimeConverter());
            serializer.NullValueHandling = NullValueHandling.Ignore;

            using (StreamWriter sw = new StreamWriter(strArquivo))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, this);
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

        public string SubTitulo
        {
            get
            {
                return strSubTitulo;
            }

            set
            {
                strSubTitulo = value;
            }
        }

        public Font FonteTitulo
        {
            get
            {
                return objFonteTitulo;
            }

            set
            {
                objFonteTitulo = value;
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

        public enModoTela ModoTela
        {
            get
            {
                return objModoTela;
            }

            set
            {
                objModoTela = value;
            }
        }

        public bool LetraPreta
        {
            get
            {
                return bolLetraPreta;
            }

            set
            {
                bolLetraPreta = value;
            }
        }

        public int IndiceMonitor
        {
            get
            {
                return intIndiceMonitor;
            }

            set
            {
                intIndiceMonitor = value;
            }
        }

        public int Tempo
        {
            get
            {
                return intTempo;
            }

            set
            {
                intTempo = value;
            }
        }

        public string IniciarEm
        {
            get
            {
                return strIniciarEm;
            }

            set
            {
                strIniciarEm = value;
            }
        }

        public bool IniciarAutomatico
        {
            get
            {
                return bolIniciarAutomatico;
            }

            set
            {
                bolIniciarAutomatico = value;
            }
        }

        public bool FecharAutomatico
        {
            get
            {
                return bolFecharAutomatico;
            }

            set
            {
                bolFecharAutomatico = value;
            }
        }

        public Font FonteNumero
        {
            get
            {
                return objFonteNumero;
            }

            set
            {
                objFonteNumero = value;
            }
        }
    }
}
