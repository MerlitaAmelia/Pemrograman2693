using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OOPdanCollection.ClassInduk;
namespace OOPdanCollection.ClassAnak

{
    public class KaryawanTetap : Karyawan
    {
        public int GajiBulanan { get; set; }
        

        public override int Gaji() => GajiBulanan;

    }
}
