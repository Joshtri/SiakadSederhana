using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiakadSederhana.Entitas
{
    public class Mahasiswa
    {
        public string Nim { get; set; } //Key
        public string Nama { get; set; }
        public bool JenisKelamin { get; set; }
        public int Angkatan { get; set; }
    }
}