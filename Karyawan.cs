using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPdanCollection.ClassInduk
{
    public abstract class Karyawan
    {
        public string Nama { get; set; }
        public string Nik { get; set; }
        public string jenis_karyawan { get; set; }

        public abstract int Gaji();

    }
}
