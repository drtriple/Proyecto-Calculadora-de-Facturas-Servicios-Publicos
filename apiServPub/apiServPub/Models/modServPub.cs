using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace apiServPub.Models
{
	public class modServPub
	{
        #region Atributos
        public int intEstrato;
        public int intkKw;
        public int intkM3;
        public int intklTel;
        public float fltvrDolar;
        public float fltvrKw;
        public float fltvrM3;
        public float fltvrTel;
        public float fltvrTEnergia;
        public float fltvrTAgua;
        public float fltvrTTelef;
        public float fltvrImpCons;
        public float fltvrAPag;
        public string strError;
        #endregion

        #region Propiedades
        public int Estrato
        {
            get { return intEstrato; }
            set { intEstrato = value; }
        }
        public int kKw
        {
            get { return intkKw; }
            set { intkKw = value; }
        }
        public int kM3
        {
            get { return intkM3; }
            set { intkM3 = value; }
        }
        public int klTel
        {
            get { return intklTel; }
            set { intklTel = value; }
        }
        public float vrDolar
        {
            get { return fltvrDolar; }
            set { fltvrDolar = value; }
        }
        public float vrKw
        {
            get { return fltvrKw; }
            set { fltvrKw = value; }
        }
        public float vrM3
        {
            get { return fltvrM3; }
            set { fltvrM3 = value; }
        }
        public float vrTel
        {
            get { return fltvrTel; }
            set { fltvrTel = value; }
        }
        public float vrTEnergia
        {
            get { return fltvrTEnergia; }
            set { fltvrTEnergia = value; }
        }
        public float vrTAgua
        {
            get { return fltvrTAgua; }
            set { fltvrTAgua = value; }
        }
        public float vrTTelef
        {
            get { return fltvrTTelef; }
            set { fltvrTTelef = value; }
        }
        public float vrImpCons
        {
            get { return fltvrImpCons; }
            set { fltvrImpCons = value; }
        }
        public float vrAPag
        {
            get { return fltvrAPag; }
            set { fltvrAPag = value; }
        }
        public string Error
        {
            get { return strError; }
            set { strError = value; }
        }
        #endregion

    }
}