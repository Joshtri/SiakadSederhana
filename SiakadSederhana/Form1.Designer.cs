
namespace SiakadSederhana
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonMahasiswa = new System.Windows.Forms.Button();
            this.buttonMataKuliah = new System.Windows.Forms.Button();
            this.buttonSemester = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonMahasiswa
            // 
            this.buttonMahasiswa.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMahasiswa.Location = new System.Drawing.Point(67, 101);
            this.buttonMahasiswa.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMahasiswa.Name = "buttonMahasiswa";
            this.buttonMahasiswa.Size = new System.Drawing.Size(212, 78);
            this.buttonMahasiswa.TabIndex = 0;
            this.buttonMahasiswa.Text = "Mahasiswa";
            this.buttonMahasiswa.UseVisualStyleBackColor = true;
            this.buttonMahasiswa.Click += new System.EventHandler(this.buttonMahasiswa_Click_1);
            // 
            // buttonMataKuliah
            // 
            this.buttonMataKuliah.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMataKuliah.Location = new System.Drawing.Point(314, 101);
            this.buttonMataKuliah.Margin = new System.Windows.Forms.Padding(2);
            this.buttonMataKuliah.Name = "buttonMataKuliah";
            this.buttonMataKuliah.Size = new System.Drawing.Size(212, 78);
            this.buttonMataKuliah.TabIndex = 1;
            this.buttonMataKuliah.Text = "Mata Kuliah";
            this.buttonMataKuliah.UseVisualStyleBackColor = true;
            this.buttonMataKuliah.Click += new System.EventHandler(this.buttonMataKuliah_Click);
            // 
            // buttonSemester
            // 
            this.buttonSemester.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSemester.Location = new System.Drawing.Point(575, 101);
            this.buttonSemester.Margin = new System.Windows.Forms.Padding(2);
            this.buttonSemester.Name = "buttonSemester";
            this.buttonSemester.Size = new System.Drawing.Size(212, 78);
            this.buttonSemester.TabIndex = 2;
            this.buttonSemester.Text = "Semester";
            this.buttonSemester.UseVisualStyleBackColor = true;
            this.buttonSemester.Click += new System.EventHandler(this.buttonSemester_Click_1);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(314, 219);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(212, 78);
            this.button4.TabIndex = 3;
            this.button4.Text = "Nilai";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 375);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSemester);
            this.Controls.Add(this.buttonMataKuliah);
            this.Controls.Add(this.buttonMahasiswa);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMahasiswa;
        private System.Windows.Forms.Button buttonMataKuliah;
        private System.Windows.Forms.Button buttonSemester;
        private System.Windows.Forms.Button button4;
    }
}

