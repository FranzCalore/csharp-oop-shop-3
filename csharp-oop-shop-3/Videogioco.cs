using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CS_Shop_2
{

    public class Videogioco : Prodotto
    {
        private string studioDiSviluppo;
        private bool soloDigitale;
        private bool guidaStrategica;


        public Videogioco(string name, string description, double prezzo, double IVA, string studioDiSviluppo, bool soloDigitale=false, bool guidaStrategica = false) : base(name, description, prezzo, IVA)
        {
            this.studioDiSviluppo = studioDiSviluppo;
            this.soloDigitale = soloDigitale;
        }
        public string GetStudioDiSviluppo()
        {
            return this.studioDiSviluppo;
        }
        public bool GetSoloDigitale()
        {
            return this.soloDigitale;
        }
        public void GuidaStrategicaSìNo()
        {
            if (guidaStrategica)
            {
                this.guidaStrategica = false;
                this.SetPrezzo(this.GetPrezzo() - 30);
            }
            else
            {
                this.guidaStrategica = true;
                this.SetPrezzo(this.GetPrezzo() + 30);
            }
        }

        public override void StampaProdotto()
        {
            Console.WriteLine("------ " + this.GetName() + " -----");
            Console.WriteLine();
            Console.WriteLine(this.GetDescription());
            Console.WriteLine("Sviluppato da: " + this.GetStudioDiSviluppo());
            Console.WriteLine("Guida Strategica Inclusa: " + this.YesOrNot(this.guidaStrategica));
            Console.WriteLine("Il codice del prodotto è: " + this.GetCodice());
            Console.WriteLine("Il prezzo senza IVA del prodotto è: " + this.StampaPrezzoBase());
            Console.WriteLine("Il prezzo comprensivo di IVA è: " + this.StampaPrezzoIVA());
            Console.WriteLine("L'IVA del prodotto è al: " + this.GetIVA() + "%");
            Console.WriteLine();
            Console.WriteLine("Il codice NomeEsteso è: " + this.GetNomeEsteso());
            Console.WriteLine();
        }

        private string YesOrNot(bool boolean)
        {
            if (boolean)
            {
                return "Sì";
            }
                else
            {
                return "No";
            }
        }
    }


}
