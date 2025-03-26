// Operaciones del servicio
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using apiServPub.Models;

namespace apiServPub.Clases
{
	public class clsOpeServPub
	{
		#region Atributos
		public modServPub VpModSP;
        #endregion

        #region Propiedades
        public modServPub pModSP
        {
            get { return VpModSP; }
            set { VpModSP = value; }
        }
        #endregion

        #region Metodos Privados
        private bool Validar() {
            if (pModSP.intEstrato < 1 || pModSP.intEstrato > 6) {
                pModSP.strError = "El estrato ingreso no es válido.";
                return false;
            }
            if (pModSP.intkKw < 0)
            {
                pModSP.strError = "La propiedad kKw ingresada no es válido.";
                return false;
            }
            if (pModSP.intkM3 < 0)
            {
                pModSP.strError = "La propiedad KM3 ingresada no es válido.";
                return false;
            }
            if (pModSP.intklTel < 0)
            {
                pModSP.strError = "La propiedad Tel ingresada no es válido.";
                return false;
            }
            if (pModSP.fltvrDolar < 0)
            {
                pModSP.strError = "La propiedad Dolar ingresada no es válido.";
                return false;
            }
            return true;
        }
        #endregion
    }
}