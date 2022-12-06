using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using csharp_oop_shop_3.Custom_Exception;

namespace CS_Shop_3
{
    public class Caramella : Prodotto
    {
        private string gusto;
        private int numeroKcalorie;

        public Caramella (string name, string description, double prezzo, double IVA, string gusto, int numeroKcalorie): base(name, description, prezzo, IVA)
        {
            if (gusto == "" || gusto == null)
            {
                throw new ParameterCannotBeEmptyException("gusto","Gusto non può essere vuoto");
            }
            this.gusto = gusto;
            if (numeroKcalorie <0)
            {
                throw new CannotBeNegativeException("numeroKcalorie", "Numero calorie non può essere negativo");
            }
            this.numeroKcalorie = numeroKcalorie;
        }

        public string GetGusto()
        {
            return this.gusto;
        }

        public double GetNumeroKcalorie()
        {
            return this.numeroKcalorie;
        }

        public override string ToString()
        {
            string stringaProdotto = "";
            stringaProdotto = "------ " +base.GetName() + " -----\n";
            stringaProdotto += base.GetDescription();
            stringaProdotto += "\nIl gusto della caramella è: " + this.GetGusto();
            stringaProdotto += "\n\nIl codice del prodotto è: " + base.GetCodice();
            stringaProdotto += "\nIl prezzo senza IVA del prodotto è: " + this.StampaPrezzoBase();
            stringaProdotto += "\nIl prezzo comprensivo di IVA è: " + this.StampaPrezzoIVA();
            stringaProdotto += "\nL'IVA del prodotto è al: " + base.GetIVA() + "%\n\n";
            stringaProdotto += "\nIl codice NomeEsteso è: " + this.GetNomeEsteso();
            return stringaProdotto;
        }
    }
}
