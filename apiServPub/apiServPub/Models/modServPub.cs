using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
    public class modServPub
    {
        #region Constructor
        public modServPub()
        {
            Estrato = 0;
            kKw = 0;
            kM3 = 0;
            klTel = 0;
            vrDolar = 0;
            vrKw = 0;
            vrM3 = 0;
            vrTel = 0;
            vrTEnergia = 0;
            vrTAgua = 0;
            vrTTelef = 0;
            vrImpCons = 0;
            vrAPag = 0;
            Error = string.Empty;
        }
        #endregion		

        #region Propiedades
        public int Estrato { get; set; }
        public int kKw { get; set; }
        public int kM3 { get; set; }
        public int klTel { get; set; }
        public float vrDolar { get; set; }
        public float vrKw { get; set; }
        public float vrM3 { get; set; }
        public float vrTel { get; set; }
        public float vrTEnergia { get; set; }
        public float vrTAgua { get; set; }
        public float vrTTelef { get; set; }
        public float vrImpCons { get; set; }
        public float vrAPag { get; set; }
        public string Error { get; set; }
        #endregion

    }
}