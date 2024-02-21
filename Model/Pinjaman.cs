using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PDPBCA_Test.Model
{
    public class Pinjaman
    {
        public Guid Id { get; set; }
        public string Dealer { get; set; } = String.Empty;
        public int DownPayment { get; set; } = 0;
        public int LamaKredit { get; set; } = 0;
        public int Angsuran { get; set; } = 0;
    }
}
