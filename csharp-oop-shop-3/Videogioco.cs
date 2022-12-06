using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using csharp_oop_shop_3.Custom_Exception;

namespace CS_Shop_3
{

    public class Videogioco : Prodotto
    {
        private string studioDiSviluppo;
        private bool soloDigitale;
        private bool guidaStrategica;


        public Videogioco(string name, string description, double prezzo, double IVA, string studioDiSviluppo, bool soloDigitale=false, bool guidaStrategica = false) : base(name, description, prezzo, IVA)
        {
            if (studioDiSviluppo==null || studioDiSviluppo == "")
            {
                throw new ParameterCannotBeEmptyException("studioDiSviluppo", "Un gioco deve avere uno studio di sviluppo");
            }
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

        public override string ToString()
        {
            string stringaProdotto = "";
            stringaProdotto = "------ " + base.GetName() + " -----\n";
            stringaProdotto += base.GetDescription();
            stringaProdotto += "\nSviluppato da: " + this.GetStudioDiSviluppo();
            stringaProdotto += "\nGuida Strategica Inclusa: " + this.YesOrNot(this.guidaStrategica);
            stringaProdotto += "\n\nIl codice del prodotto è: " + base.GetCodice();
            stringaProdotto += "\nIl prezzo senza IVA del prodotto è: " + this.StampaPrezzoBase();
            stringaProdotto += "\nIl prezzo comprensivo di IVA è: " + this.StampaPrezzoIVA();
            stringaProdotto += "\nL'IVA del prodotto è al: " + base.GetIVA() + "%\n\n";
            stringaProdotto += "\nIl codice NomeEsteso è: " + this.GetNomeEsteso();
            return stringaProdotto;
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
