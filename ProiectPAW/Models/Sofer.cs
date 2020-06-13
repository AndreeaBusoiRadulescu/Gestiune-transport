using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectPAW
{
    [Table("Soferi")]
    public class Sofer
    {
        public int Id { get; set; }
        public String NumeSofer { get; set; }
        public DateTime DataAngajare { get; set; }

        public Sofer() { }

        public Sofer(String numeSofer, DateTime dataAngajare)
        {
            this.NumeSofer = numeSofer;
            this.DataAngajare = dataAngajare;
        }

        // public virtual ICollection<Transport> Transports { get; set; }

        public override string ToString()
        {
            return NumeSofer;
        }

    }
}
