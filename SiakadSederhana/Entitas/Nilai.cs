using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiakadSederhana.Entitas
{
    public class Nilai
    {
        public string IdSemester { get; set; } //Key
        public string KodeMataKuliah { get; set; } //Key
        public string Nim { get; set; } //Key
        public double NilaiAngka { get; set; }
        public string NilaiHuruf { get; set; }
    }
}
