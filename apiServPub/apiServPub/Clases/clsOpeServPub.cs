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
    }
}