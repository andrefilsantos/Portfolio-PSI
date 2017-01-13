using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubeVideoAndréTomás
{
    class Morada
    {
        private string _rua;
        private string _localidade;
        private string _codPost;
         
        public Morada(string rua, string localidade, string codPost)
        {
            _rua = rua;
            _localidade = localidade;
            _codPost = codPost;
        }
        
        public override string ToString()
        {
            return " Rua: " + _rua + " | Localidade: " + _localidade + " | Codigo Postal: " + _codPost;
        }

        #region Properties

        public string Rua
        {
            get
            {
                return _rua;
            }
            set
            {
                _rua = value;
            }
        }

        public string Localidade
        {
            get
            {
                return _localidade;
            }
            set
            {
                _localidade = value;
            }
        }

        public string CodigoPostal
        {
            get
            {
                return _codPost;
            }
            set
            {
                _codPost = value;
            }
        }

        #endregion
    };
}
