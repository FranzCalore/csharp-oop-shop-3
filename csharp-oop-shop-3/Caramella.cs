using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Shop_2
{
    public class Caramella : Prodotto
    {
        private string gusto;
        private int numeroKcalorie;

        public Caramella (string name, string description, double prezzo, double IVA, string gusto, int numeroKcalorie): base(name, description, prezzo, IVA)
        {
            this.gusto = gusto;
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

        public override void StampaProdotto()
        {
            Console.WriteLine("------ " + this.GetName() + " -----");
            Console.WriteLine();
            Console.WriteLine(this.GetDescription());
            Console.WriteLine("Il gusto della caramella è: " + this.GetGusto());
            Console.WriteLine("La caramella ha: " + this.GetNumeroKcalorie() + "Kcal");
            Console.WriteLine("Il codice del prodotto è: " + this.GetCodice());
            Console.WriteLine("Il prezzo senza IVA del prodotto è: " + this.StampaPrezzoBase());
            Console.WriteLine("Il prezzo comprensivo di IVA è: " + this.StampaPrezzoIVA());
            Console.WriteLine("L'IVA del prodotto è al: " + this.GetIVA() + "%");
            Console.WriteLine();
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine();
        }
    }
}
