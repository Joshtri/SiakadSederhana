using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SiakadSederhana
{
    public partial class Form1 : Form
    {
        private FormMahasiswa formMhs = new FormMahasiswa();
        private FormMataKuliah formMk = new FormMataKuliah();
        private FormSemester formSemester = new FormSemester();
        private FormNilai formNilai = new FormNilai();

        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonMataKuliah_Click(object sender, EventArgs e)
        {
            formMk.Show();
        }

        private void buttonMahasiswa_Click_1(object sender, EventArgs e)
        {
            formMhs.Show();
        }

        
        private void buttonSemester_Click_1(object sender, EventArgs e)
        {
            formSemester.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            formNilai.Show();
        }
    }
}