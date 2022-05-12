using SiakadSederhana.Entitas;
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
    public partial class FormMahasiswa : Form
    {
        public static List<Mahasiswa> ListMahasiswa = new List<Mahasiswa>();

        private Mahasiswa mahasiswaDiklik = null;

        public FormMahasiswa()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Mahasiswa newMahasiswa = new Mahasiswa();
                newMahasiswa.Nim = "123456789" + i.ToString();
                newMahasiswa.Nama = "Nama ke-" + i.ToString();
                newMahasiswa.JenisKelamin = true;
                newMahasiswa.Angkatan = 2020;

                ListMahasiswa.Add(newMahasiswa);
            }
            dataGridViewData.DataSource = ListMahasiswa;
        }
        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;

            if (nilaiCell != null)
            {
                var isiCell = nilaiCell.ToString();

                mahasiswaDiklik = ListMahasiswa.Find(x => x.Nim == isiCell);

            }
        }
        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahMahasiswa formTambahMhs = new FormTambahMahasiswa();
            formTambahMhs.Show();
            formTambahMhs.tambah = true;
            
        }
        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormTambahMahasiswa formTambahMhs = new FormTambahMahasiswa();
            formTambahMhs.mahasiswaDipilih = mahasiswaDiklik;
            formTambahMhs.Show();
            formTambahMhs.tambah = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListMahasiswa;
        }

        private void FormMahasiswa_Load(object sender, EventArgs e)
        {

        }
    }
}