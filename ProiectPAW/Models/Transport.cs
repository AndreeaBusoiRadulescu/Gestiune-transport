using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Transport :ICloneable
    {
        public int Id { get; set; } //primary key
        public Masina Masina { get; set; }
        public Sofer Sofer { get; set; }
        public String DenumireIncarcatura { get; set; }
        public Oras Oras { get; set; }

        public Transport()
        {
            this.Masina = null;
            this.Sofer = null;
            this.DenumireIncarcatura = "";
            this.Oras = Oras.NESELECTAT;
        }

        public Transport(Masina masina, Sofer sofer, String denumire, Oras oras)
        {
            this.Masina = masina;
            this.Sofer = sofer;
            this.DenumireIncarcatura = denumire;
            this.Oras = oras;
        }

        public object Clone()
        {
            throw new NotImplementedException();
        }

    }
}
