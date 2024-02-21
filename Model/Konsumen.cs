using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDPBCA_Test.Model
{
    public class Konsumen
    {
        public Guid Id { get; set; }
        public string NIK { get; set; } = String.Empty;
        public DateTime TanggalLahir { get; set; } = DateTime.Now;
        public string StatusPerkawinan { get; set; } = String.Empty;
        public string NamaPasangan { get; set; } = String.Empty;
    }
}
