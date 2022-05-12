using SiakadSederhana.Entitas;
using System;
using System.Windows.Forms;

namespace SiakadSederhana
{
    public partial class FormTambahMataKuliah : Form
    {
        public MataKuliah mataKuliahDipilih = null;

        public bool tambah = false;

        public FormTambahMataKuliah()
        {
            InitializeComponent();
        }

        private void buttonSimpan_Click(object sender, EventArgs e)
        {
            if (tambah == true)
            {
                MataKuliah newMataKuliah = new MataKuliah();
                newMataKuliah.KodeMataKuliah = textBoxKodeMk.Text;
                newMataKuliah.NamaMataKuliah = textBoxNamaMk.Text;
                newMataKuliah.Deskripsi = textBoxDesripsiMk.Text;
                newMataKuliah.JumlahSks = int.Parse(textBoxJumlahSks.Text);

                FormMataKuliah.ListMataKuliah.Add(newMataKuliah);
                MessageBox.Show("Data telah ditambahkan.");

                this.Close();
            }
            else //Tambah == false
            {
                if (mataKuliahDipilih != null)
                {
                    var mataKiliahYangMauDiEdit = FormMataKuliah.ListMataKuliah.Find(x => x.KodeMataKuliah == mataKuliahDipilih.KodeMataKuliah);

                    if (mataKiliahYangMauDiEdit != null)
                    {
                        mataKiliahYangMauDiEdit.NamaMataKuliah = textBoxNamaMk.Text;
                        mataKiliahYangMauDiEdit.Deskripsi = textBoxDesripsiMk.Text;
                        mataKiliahYangMauDiEdit.JumlahSks = int.Parse(textBoxJumlahSks.Text);

                        MessageBox.Show("Data telah diubah.");

                        this.Close();
                    }
                }
            }
        }

        private void FormTambahMataKuliah_Shown(object sender, EventArgs e)
        {
            if (mataKuliahDipilih != null)
            {
                textBoxKodeMk.Text = mataKuliahDipilih.KodeMataKuliah;
                textBoxNamaMk.Text = mataKuliahDipilih.NamaMataKuliah;
                textBoxDesripsiMk.Text = mataKuliahDipilih.Deskripsi;
                textBoxJumlahSks.Text = mataKuliahDipilih.JumlahSks.ToString();
            }
        }

        private void FormTambahMataKuliah_Load(object sender, EventArgs e)
        {

        }
    }
}