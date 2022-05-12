using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SiakadSederhana.Entitas;

namespace SiakadSederhana
{
    public partial class FormMataKuliah : Form
    {
        public static List<MataKuliah> ListMataKuliah = new List<MataKuliah>();

        private MataKuliah mataKuliahDiklik = null;

        public FormMataKuliah()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                MataKuliah newMataKuliah = new MataKuliah();
                newMataKuliah.KodeMataKuliah = "Kode MK " + i.ToString();
                newMataKuliah.NamaMataKuliah = "Nama MK " + i.ToString();
                newMataKuliah.JumlahSks = 2;

                ListMataKuliah.Add(newMataKuliah);
            }

            dataGridViewData.DataSource = ListMataKuliah;
        }

        private void dataGridViewData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;

            if (nilaiCell != null)
            {
                var isiCell = nilaiCell.ToString();

                mataKuliahDiklik = ListMataKuliah.Find(x => x.KodeMataKuliah == isiCell);
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListMataKuliah;
        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Tombol tambah diklik.");
            FormTambahMataKuliah formTambahMk = new FormTambahMataKuliah();
            formTambahMk.Show();
            formTambahMk.tambah = true;
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormTambahMataKuliah formTambahMk = new FormTambahMataKuliah();
            formTambahMk.mataKuliahDipilih = mataKuliahDiklik;
            formTambahMk.Show();
            formTambahMk.tambah = false;
        }

        private void FormMataKuliah_Load(object sender, EventArgs e)
        {

        }
    }
}