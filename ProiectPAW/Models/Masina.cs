using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    public class Masina :IComparable
    {
        
        public int Id { get; set; }
        public String Denumire { get; set; }
        public String NumarMasina { get; set; }

        public Masina() { }

        public Masina(String denumire, String numarMasina)
        {
            this.Denumire = denumire;
            this.NumarMasina = numarMasina;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        //public virtual ICollection<Transport> Transports { get; set; }

        public override string ToString()
        {
            return Denumire;
        }
    }
}
