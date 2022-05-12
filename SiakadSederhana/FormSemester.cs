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
    public partial class FormSemester : Form
    {
        public static List<Semester> ListSemester = new List<Semester>();

        private Semester semesterDiklik = null;
        public FormSemester()
        {
            InitializeComponent();

            for (int i = 0; i < 10; i++)
            {
                Semester newSemester = new Semester();
                newSemester.IdSemester = "Id Semester" + i.ToString();
                newSemester.NamaSemester = "Nama Semester" + i.ToString();

                ListSemester.Add(newSemester);

            }
            dataGridViewData.DataSource = ListSemester;
        }
        private void dataGridViewData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var nilaiCell = dataGridViewData.Rows[e.RowIndex].Cells[0].Value;

            if (nilaiCell != null)
            {
                var isiCell = nilaiCell.ToString();

                semesterDiklik = ListSemester.Find(x => x.IdSemester == isiCell);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonTambah_Click(object sender, EventArgs e)
        {
            FormTambahSemester formTambahSemester = new FormTambahSemester();
            formTambahSemester.Show();
            formTambahSemester.tambah = true;
           
        }

        private void buttonUbah_Click(object sender, EventArgs e)
        {
            FormTambahSemester formTambahSemester = new FormTambahSemester();
            formTambahSemester.semesterDipilih = semesterDiklik;
            formTambahSemester.Show();
            formTambahSemester.tambah = false;
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            dataGridViewData.DataSource = null;
            dataGridViewData.DataSource = ListSemester;
        }
    }
}
