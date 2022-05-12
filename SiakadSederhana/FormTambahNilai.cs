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
    public partial class FormTambahNilai : Form
    {
        public Nilai nilaiDipilih = null;

        public bool tambah = false;
        public FormTambahNilai()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {

            if (tambah == true)
            {
                Nilai newNilai = new Nilai();
                newNilai.IdSemester = textBox1.Text;
                newNilai.KodeMataKuliah = textBox2.Text;
                newNilai.Nim = textBox3.Text;
                newNilai.NilaiAngka = double.Parse(textBox4.Text);
                newNilai.NilaiHuruf = textBox5.Text;

                FormNilai.ListNilai.Add(newNilai);
                MessageBox.Show("Data telah ditambahkan");
                this.Close();
            }
            else
            {
                if (nilaiDipilih != null)
                {
                    var nilaiYangDiEdit = FormNilai.ListNilai.Find(x => x.IdSemester == nilaiDipilih.IdSemester && x.KodeMataKuliah == nilaiDipilih.KodeMataKuliah && x.Nim == nilaiDipilih.Nim);

                    if (nilaiYangDiEdit != null)
                    {
                        nilaiYangDiEdit.IdSemester = textBox1.Text;
                        nilaiYangDiEdit.KodeMataKuliah = textBox2.Text;
                        nilaiYangDiEdit.Nim = textBox3.Text;
                        nilaiYangDiEdit.NilaiAngka = double.Parse(textBox4.Text);
                        nilaiYangDiEdit.NilaiHuruf = textBox5.Text;

                        MessageBox.Show("Data telah diubah");
                        Close();
                    }
                }
            }

        }

        private void FormTambahNilai_Shown(object sender, EventArgs e)
        {
            if (nilaiDipilih != null)
            {
                textBox1.Text = nilaiDipilih.IdSemester.ToString();
                textBox2.Text = nilaiDipilih.KodeMataKuliah.ToString();
                textBox3.Text = nilaiDipilih.Nim.ToString();
                textBox4.Text = nilaiDipilih.NilaiAngka.ToString();
                textBox5.Text = nilaiDipilih.NilaiHuruf.ToString();
            }
        }

        private void FormTambahNilai_Load(object sender, EventArgs e)
        {

        }
    }
}
