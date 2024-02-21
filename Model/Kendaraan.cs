using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDPBCA_Test.Model
{
    public class Kendaraan
    {
        public Guid Id { get; set; }
        public string Dealer { get; set; } = String.Empty;
        public string MerkKendaraan { get; set; } = String.Empty;
        public string ModelKendaraan { get; set; } = String.Empty;
        public string TipeKendaraan { get; set; } = String.Empty;
        public string WarnaKendaraan { get; set; } = String.Empty;
        public int HargaKendaraan { get; set; } = 0;
    }
}
