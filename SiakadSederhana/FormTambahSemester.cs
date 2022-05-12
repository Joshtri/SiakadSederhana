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
    public partial class FormTambahSemester : Form
    {
        public Semester semesterDipilih = null;

        public bool tambah = false;

        public FormTambahSemester()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tambah == true )
            {
                Semester newSemester = new Semester();
                newSemester.IdSemester = textBox1.Text;
                newSemester.NamaSemester = textBox2.Text;

                FormSemester.ListSemester.Add(newSemester);
                MessageBox.Show("Data telah ditambahkan");
                this.Close();
            }
            else
            {
                if (semesterDipilih != null)
                {
                    var semesterYangDiEdit = FormSemester.ListSemester.Find(x => x.IdSemester == semesterDipilih.IdSemester);

                    if (semesterYangDiEdit != null)
                    {
                        semesterYangDiEdit.NamaSemester = textBox2.Text;
                        MessageBox.Show("Data telah diubah");
                        this.Close();
                    }
                }
            }
        }

        private void FormTambahSemester_Shown(object sender, EventArgs e)
        {
            if (semesterDipilih != null)
            {
                textBox1.Text = semesterDipilih.IdSemester;
                textBox2.Text = semesterDipilih.NamaSemester;

            }
        }
    }
}
