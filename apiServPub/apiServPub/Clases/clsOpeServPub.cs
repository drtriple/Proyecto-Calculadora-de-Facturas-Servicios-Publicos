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
        public static float subTot { get; set; } = 0;

        #region Propiedades
        public modServPub pModSP { get; set; }
        #endregion

        

        #region Metodos Privados
        private bool Validar()
        {
            if (pModSP.Estrato < 1 || pModSP.Estrato > 6)
            {
                pModSP.Error = "El estrato ingreso no es válido.";
                return false;
            }
            if (pModSP.kKw < 0)
            {
                pModSP.Error = "La cantidad de kiloWaitos ingresada no es válido.";
                return false;
            }
            if (pModSP.kM3 < 0)
            {
                pModSP.Error = "La cantidad de metros cubicos ingresada no es válido.";
                return false;
            }
            if (pModSP.klTel < 0)
            {
                pModSP.Error = "La cantidad de impulsos telefonicos ingresada no es válido.";
                return false;
            }
            if (pModSP.vrDolar <= 0)
            {
                pModSP.Error = "La propiedad Dolar ingresada no es válido.";
                return false;
            }
            return true;
        }

        private void HallarConsumo()
        {
            int cE, cA, cT;
            float vrCd = pModSP.vrDolar / 100;
            switch (pModSP.Estrato)
            {
                case 1:
                case 2:
                    cE = 170; cA = 105; cT = 5;
                    break;
                case 3:
                case 4:
                    cE = 195; cA = 130; cT = 10;
                    break;
                default:
                    cE = 220; cA = 155; cT = 15;
                    break;
            }
            pModSP.vrKw = cE * vrCd * pModSP.kKw;
            pModSP.vrM3 = cA * vrCd * pModSP.kM3;
            pModSP.vrTel = cT * vrCd * pModSP.klTel;
            subTot = pModSP.vrKw + pModSP.vrM3 + pModSP.vrTel;
            pModSP.vrImpCons = subTot * 3f / 100;
        }

        private void HallarFijo()
        {
            float cE, cA, cT;
            switch (pModSP.Estrato)
            {
                case 1:
                    cE = 2.92f; cA = 2.15f; cT = 1.81f;
                    break;
                case 2:
                case 3:
                    cE = 3.66f; cA = 2.91f; cT = 2.37f;
                    break;
                case 4:
                case 5:
                    cE = 4.9f; cA = 4.34f; cT = 3.68f;
                    break;
                default:
                    cE = 6.13f; cA = 5.35f; cT = 4.79f;
                    break;
            }
            pModSP.vrTEnergia = (pModSP.kKw > 0) ? cE * pModSP.vrDolar : 0;
            pModSP.vrTAgua = (pModSP.kM3 > 0) ? cA * pModSP.vrDolar : 0;
            pModSP.vrTTelef = (pModSP.klTel > 0) ? cT * pModSP.vrDolar : 0;
            subTot += pModSP.vrTEnergia + pModSP.vrTAgua + pModSP.vrTTelef;
        }
        #endregion

        public void Facturar()
        {
            if (!Validar())
            {
                return;
            }
            subTot = 0;
            HallarConsumo();
            HallarFijo();
            pModSP.vrAPag = subTot + pModSP.vrImpCons;

        }
    }
}