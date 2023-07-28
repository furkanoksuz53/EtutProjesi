using Etut.DataAccess;
using Etut.DataAccess.Entities;
using EtutProject.Crud;
using EtutProject.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Etut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd.MM.yyyy";
            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd.MM.yyyy";
            numericUpDown1.Maximum = 12;
        }
        Student currentStudent = new Student();
        int studentId;
        int teacherId;
        int branchId;

        private void Form1_Load(object sender, EventArgs e)
        {
            StudentCombobox();
            TeacherCombobox();
            BranchCombobox();
            GetEtuts();
        }

        private void BranchCombobox()
        {

            cbxBranch.Items.Clear();
            comboBox1.Items.Clear();
            using (var dbContext = new EtutContext())
            {
                var branchRepo = new GenericRepository<DataAccess.Entities.Branch>(dbContext);
                var branches = branchRepo.GetAll();
                foreach (var branch in branches)
                {
                    cbxBranch.Items.Add(branch.Name);
                    comboBox1.Items.Add(branch.Name);
                }
            }
        }
        public void StudentCombobox()
        {
            cbxStudent.Items.Clear();
            using (var dbContext = new EtutContext())
            {
                var studentRepo = new GenericRepository<Student>(dbContext);
                var students = studentRepo.GetAll();
                foreach (var student in students)
                {
                    cbxStudent.Items.Add(student.Name + " " + student.Surname);
                }
            }
        }
        public void TeacherCombobox()
        {
            cbxTeacher.Items.Clear();
            using (var dbContext = new EtutContext())
            {
                var teacherRepo = new GenericRepository<Teacher>(dbContext);
                var teachers = teacherRepo.GetAll();
                foreach (var teacher in teachers)
                {
                    cbxTeacher.Items.Add(teacher.Name + " " + teacher.Surname);
                }
            }
        }


        private void cbxStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            studentId = Convert.ToInt32(cbxStudent.SelectedIndex.ToString());
            using (var dbContext = new EtutContext())
            {
                var studentRepo = new GenericRepository<Student>(dbContext);
                var students = studentRepo.GetAll();
                currentStudent = students.ElementAt(studentId);
                studentId = currentStudent.StudentId;

            }

        }

        private void cbxTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            teacherId = Convert.ToInt32(cbxTeacher.SelectedIndex.ToString());
            using (var dbContext = new EtutContext())
            {
                var repo = new GenericRepository<Teacher>(dbContext);
                var teachers = repo.GetAll();
                Teacher teacher = teachers.ElementAt(teacherId);
                teacherId = teacher.TeacherId;

                var branchRepo = new GenericRepository<DataAccess.Entities.Branch>(dbContext);
                var branches = branchRepo.GetAll();
                var branch = branches.Where(b => b.BranchId == teacherId).FirstOrDefault();
                cbxBranch.Items.Clear();
                cbxBranch.Items.Add(branch.Name);
            }

        }

        private void cbxBranch_SelectedIndexChanged(object sender, EventArgs e)
        {
            string branchName = cbxBranch.Text;
            using (var dbContext = new EtutContext())
            {
                var repo = new GenericRepository<DataAccess.Entities.Branch>(dbContext);
                var branches = repo.GetAll();
                DataAccess.Entities.Branch branch = branches.Where(b => b.Name.ToLower() == branchName.ToLower()).FirstOrDefault();
                branchId = branch.BranchId;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess.Entities.Etut etut = new DataAccess.Entities.Etut();
            if (teacherId > 0)
            {
                etut.TeacherId = teacherId;
            }
            else
            {
                MessageBox.Show("Lütfen Öðretmen Seçiniz");
            }
            if (studentId > 0)
            {
                etut.StudentId = studentId;
            }
            else
            {
                MessageBox.Show("Lütfen Öðrenci Seçiniz");
            }
            if (branchId > 0)
            {
                etut.BranchId = branchId;
            }
            else
            {
                MessageBox.Show("Lütfen Branþ Seçiniz");
            }
            if (dateTimePicker1.Value != null)
            {
                etut.Date = DateOnly.Parse(dateTimePicker1.Value.ToString("dd.MM.yyyy"));
            }
            else
            {
                MessageBox.Show("Lütfen Tarih Seçiniz");
            }
            if (maskedTextBox1.Text.Length > 0)
            {
                etut.Time = TimeSpan.Parse(maskedTextBox1.Text);
            }
            else
            {
                MessageBox.Show("Lütfen Saat Seçiniz");
            }
            using (var dbContext = new EtutContext())
            {
                var etutRepo = new GenericRepository<DataAccess.Entities.Etut>(dbContext);
                etutRepo.Add(etut);
                etutRepo.SaveChanges();
            }
            MessageBox.Show("Eklendi");

            GetEtuts();

        }

        public void GetEtuts()
        {
            using (var dbContext = new EtutContext())
            {
                var etutRepo = new GenericRepository<EtutDTO>(dbContext);
                var etuts = etutRepo.GetEtutDetails();
                dataGridView1.DataSource = etuts;
            }
        }

        private void btnStudentImagePicker_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Resim Dosyalarý|*.jpg;*.jpeg;*.png;*.gif";

            DialogResult result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox1.ImageLocation = openFileDialog.FileName;
                label12.Text = openFileDialog.FileName;
            }
        }

        DataAccess.Entities.Etut etutToUpd = new DataAccess.Entities.Etut();
        Student studentToUpd = new Student();
        Teacher teacherToUpd = new Teacher();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];

                string id = row.Cells[0].Value.ToString();
                try
                {
                    using (var dbContext = new EtutContext())
                    {
                        var etutRepo = new GenericRepository<DataAccess.Entities.Etut>(dbContext);
                        etutToUpd = etutRepo.GetById(Convert.ToInt32(id));


                        var teacherRepo = new GenericRepository<Teacher>(dbContext);
                        teacherToUpd = teacherRepo.GetById(etutToUpd.TeacherId);


                        var studentRepo = new GenericRepository<Student>(dbContext);
                        studentToUpd = studentRepo.GetById(etutToUpd.StudentId);

                        lblStudent.Text = $"{studentToUpd.Name} {studentToUpd.Surname}";
                        lblTeacher.Text = $"{teacherToUpd.Name} {teacherToUpd.Surname}";

                        dateTimePicker2.Value = DateTime.Parse(etutToUpd.Date.ToString());
                        maskedTextBox2.Text = etutToUpd.Time.ToString();
                        checkBox1.Checked = etutToUpd.Statu;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                etutToUpd.Date = DateOnly.Parse(dateTimePicker2.Value.ToString("dd.MM.yyyy"));
                etutToUpd.Time = TimeSpan.Parse(maskedTextBox2.Text);
                etutToUpd.Statu = checkBox1.Checked ? true : false;
                using (var dbContext = new EtutContext())
                {
                    var etutRepo = new GenericRepository<DataAccess.Entities.Etut>(dbContext);
                    etutRepo.Update(etutToUpd);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Güncellendi");

                GetEtuts();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            Student studentToAdd = new Student();
            try
            {
                using (var dbContext = new EtutContext())
                {
                    studentToAdd.Name = tbxStudentName.Text;
                    studentToAdd.Surname = tbxStudentSurname.Text;
                    studentToAdd.Phone = maskedTextBoxPhone.Text;
                    studentToAdd.Class = numericUpDown1.Value.ToString();
                    studentToAdd.Mail = tbxMail.Text;
                    studentToAdd.ImagePath = label12.Text;
                    var repo = new GenericRepository<Student>(dbContext);
                    repo.Add(studentToAdd);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Eklendi");

                StudentCombobox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher teacherToAdd = new Teacher();
            try
            {
                string branchName = comboBox1.SelectedItem.ToString();

                using (var dbContext = new EtutContext())
                {
                    var repo = new GenericRepository<DataAccess.Entities.Branch>(dbContext);
                    var branches = repo.GetAll();
                    DataAccess.Entities.Branch? branch = branches.Where(b => b.Name.ToLower() == branchName.ToLower()).FirstOrDefault();
                    int id = branch.BranchId;

                    teacherToAdd.Name = textBox1.Text;
                    teacherToAdd.Surname = textBox2.Text;
                    teacherToAdd.BranchId = id;

                    var repoTeacher = new GenericRepository<Teacher>(dbContext);
                    repoTeacher.Add(teacherToAdd);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Eklendi");

                TeacherCombobox();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DataAccess.Entities.Branch branchToAdd = new DataAccess.Entities.Branch();
            try
            {
                using (var dbContext = new EtutContext())
                {
                    branchToAdd.Name = textBoxBranchName.Text.Trim();

                    var repo = new GenericRepository<DataAccess.Entities.Branch>(dbContext);
                    var branches = repo.GetAll();
                    var bran = branches.Where(b => b.Name.ToLower() == textBoxBranchName.Text.Trim().ToLower()).FirstOrDefault();
                    if(bran != null)
                    {
                        repo.Add(branchToAdd);
                        dbContext.SaveChanges();
                        MessageBox.Show("Eklendi");
                        BranchCombobox();
                    }
                    else
                    {
                        MessageBox.Show("Branþ Zaten Mevcut");
                    }
                    
                }
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}