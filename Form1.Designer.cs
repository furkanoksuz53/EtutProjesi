namespace Etut
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            groupBox1 = new GroupBox();
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            cbxBranch = new ComboBox();
            cbxTeacher = new ComboBox();
            cbxStudent = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            maskedTextBoxPhone = new MaskedTextBox();
            numericUpDown1 = new NumericUpDown();
            btnAddStudent = new Button();
            label12 = new Label();
            btnStudentImagePicker = new Button();
            tbxStudentName = new TextBox();
            tbxStudentSurname = new TextBox();
            tbxMail = new TextBox();
            label9 = new Label();
            label6 = new Label();
            label11 = new Label();
            label10 = new Label();
            label8 = new Label();
            label7 = new Label();
            dataGridView1 = new DataGridView();
            etutIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            teacherNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            timeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statuDataGridViewCheckBoxColumn = new DataGridViewCheckBoxColumn();
            etutDTOBindingSource = new BindingSource(components);
            groupBox4 = new GroupBox();
            btnUpdate = new Button();
            lblTeacher = new Label();
            lblStudent = new Label();
            checkBox1 = new CheckBox();
            maskedTextBox2 = new MaskedTextBox();
            label14 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label16 = new Label();
            label18 = new Label();
            label17 = new Label();
            label20 = new Label();
            groupBox5 = new GroupBox();
            textBoxBranchName = new TextBox();
            label21 = new Label();
            button3 = new Button();
            groupBox3 = new GroupBox();
            button2 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            label15 = new Label();
            label19 = new Label();
            label13 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)etutDTOBindingSource).BeginInit();
            groupBox4.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(cbxBranch);
            groupBox1.Controls.Add(cbxTeacher);
            groupBox1.Controls.Add(cbxStudent);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 222);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Etüt Ekle";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(97, 135);
            maskedTextBox1.Mask = "00:00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(188, 27);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.ValidatingType = typeof(DateTime);
            // 
            // button1
            // 
            button1.Location = new Point(97, 172);
            button1.Name = "button1";
            button1.Size = new Size(188, 29);
            button1.TabIndex = 3;
            button1.Text = "Etüt Ekle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(97, 108);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(188, 27);
            dateTimePicker1.TabIndex = 2;
            // 
            // cbxBranch
            // 
            cbxBranch.FormattingEnabled = true;
            cbxBranch.Location = new Point(97, 79);
            cbxBranch.Name = "cbxBranch";
            cbxBranch.Size = new Size(188, 28);
            cbxBranch.TabIndex = 1;
            cbxBranch.SelectedIndexChanged += cbxBranch_SelectedIndexChanged;
            // 
            // cbxTeacher
            // 
            cbxTeacher.FormattingEnabled = true;
            cbxTeacher.Location = new Point(97, 53);
            cbxTeacher.Name = "cbxTeacher";
            cbxTeacher.Size = new Size(188, 28);
            cbxTeacher.TabIndex = 1;
            cbxTeacher.SelectedIndexChanged += cbxTeacher_SelectedIndexChanged;
            // 
            // cbxStudent
            // 
            cbxStudent.FormattingEnabled = true;
            cbxStudent.Location = new Point(97, 26);
            cbxStudent.Name = "cbxStudent";
            cbxStudent.Size = new Size(188, 28);
            cbxStudent.TabIndex = 1;
            cbxStudent.SelectedIndexChanged += cbxStudent_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 138);
            label5.Name = "label5";
            label5.Size = new Size(45, 20);
            label5.TabIndex = 0;
            label5.Text = "Saat :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 113);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
            label4.TabIndex = 0;
            label4.Text = "Tarih :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 82);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 0;
            label3.Text = "Branş :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 56);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 0;
            label2.Text = "Öğretmen :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 29);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Öğrenci :";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(pictureBox1);
            groupBox2.Controls.Add(maskedTextBoxPhone);
            groupBox2.Controls.Add(numericUpDown1);
            groupBox2.Controls.Add(btnAddStudent);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btnStudentImagePicker);
            groupBox2.Controls.Add(tbxStudentName);
            groupBox2.Controls.Add(tbxStudentSurname);
            groupBox2.Controls.Add(tbxMail);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Location = new Point(896, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(231, 334);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Öğrenci Ekle";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(81, 225);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(70, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // maskedTextBoxPhone
            // 
            maskedTextBoxPhone.Location = new Point(81, 126);
            maskedTextBoxPhone.Mask = "(999) 000-0000";
            maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            maskedTextBoxPhone.Size = new Size(144, 27);
            maskedTextBoxPhone.TabIndex = 6;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(81, 92);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(144, 27);
            numericUpDown1.TabIndex = 5;
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(81, 293);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(144, 29);
            btnAddStudent.TabIndex = 4;
            btnAddStudent.Text = "Ekle";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(6, 297);
            label12.Name = "label12";
            label12.Size = new Size(0, 20);
            label12.TabIndex = 3;
            label12.Visible = false;
            // 
            // btnStudentImagePicker
            // 
            btnStudentImagePicker.Location = new Point(81, 193);
            btnStudentImagePicker.Name = "btnStudentImagePicker";
            btnStudentImagePicker.Size = new Size(144, 29);
            btnStudentImagePicker.TabIndex = 2;
            btnStudentImagePicker.Text = "Resim Seç";
            btnStudentImagePicker.UseVisualStyleBackColor = true;
            btnStudentImagePicker.Click += btnStudentImagePicker_Click;
            // 
            // tbxStudentName
            // 
            tbxStudentName.Location = new Point(81, 27);
            tbxStudentName.Name = "tbxStudentName";
            tbxStudentName.Size = new Size(144, 27);
            tbxStudentName.TabIndex = 1;
            // 
            // tbxStudentSurname
            // 
            tbxStudentSurname.Location = new Point(81, 60);
            tbxStudentSurname.Name = "tbxStudentSurname";
            tbxStudentSurname.Size = new Size(144, 27);
            tbxStudentSurname.TabIndex = 1;
            // 
            // tbxMail
            // 
            tbxMail.Location = new Point(81, 159);
            tbxMail.Name = "tbxMail";
            tbxMail.Size = new Size(144, 27);
            tbxMail.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(30, 95);
            label9.Name = "label9";
            label9.Size = new Size(45, 20);
            label9.TabIndex = 0;
            label9.Text = "Sınıf :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 27);
            label6.Name = "label6";
            label6.Size = new Size(35, 20);
            label6.TabIndex = 0;
            label6.Text = "Ad :";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(19, 197);
            label11.Name = "label11";
            label11.Size = new Size(56, 20);
            label11.TabIndex = 0;
            label11.Text = "Resim :";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 162);
            label10.Name = "label10";
            label10.Size = new Size(45, 20);
            label10.TabIndex = 0;
            label10.Text = "Mail :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 128);
            label8.Name = "label8";
            label8.Size = new Size(65, 20);
            label8.TabIndex = 0;
            label8.Text = "Telefon :";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(18, 61);
            label7.Name = "label7";
            label7.Size = new Size(57, 20);
            label7.TabIndex = 0;
            label7.Text = "Soyad :";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { etutIdDataGridViewTextBoxColumn, studentNameDataGridViewTextBoxColumn, teacherNameDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, timeDataGridViewTextBoxColumn, statuDataGridViewCheckBoxColumn });
            dataGridView1.DataSource = etutDTOBindingSource;
            dataGridView1.Location = new Point(12, 240);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(878, 275);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // etutIdDataGridViewTextBoxColumn
            // 
            etutIdDataGridViewTextBoxColumn.DataPropertyName = "EtutId";
            etutIdDataGridViewTextBoxColumn.HeaderText = "EtutId";
            etutIdDataGridViewTextBoxColumn.MinimumWidth = 6;
            etutIdDataGridViewTextBoxColumn.Name = "etutIdDataGridViewTextBoxColumn";
            etutIdDataGridViewTextBoxColumn.ReadOnly = true;
            etutIdDataGridViewTextBoxColumn.Width = 125;
            // 
            // studentNameDataGridViewTextBoxColumn
            // 
            studentNameDataGridViewTextBoxColumn.DataPropertyName = "StudentName";
            studentNameDataGridViewTextBoxColumn.HeaderText = "StudentName";
            studentNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            studentNameDataGridViewTextBoxColumn.Name = "studentNameDataGridViewTextBoxColumn";
            studentNameDataGridViewTextBoxColumn.ReadOnly = true;
            studentNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // teacherNameDataGridViewTextBoxColumn
            // 
            teacherNameDataGridViewTextBoxColumn.DataPropertyName = "TeacherName";
            teacherNameDataGridViewTextBoxColumn.HeaderText = "TeacherName";
            teacherNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            teacherNameDataGridViewTextBoxColumn.Name = "teacherNameDataGridViewTextBoxColumn";
            teacherNameDataGridViewTextBoxColumn.ReadOnly = true;
            teacherNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.ReadOnly = true;
            dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // timeDataGridViewTextBoxColumn
            // 
            timeDataGridViewTextBoxColumn.DataPropertyName = "Time";
            timeDataGridViewTextBoxColumn.HeaderText = "Time";
            timeDataGridViewTextBoxColumn.MinimumWidth = 6;
            timeDataGridViewTextBoxColumn.Name = "timeDataGridViewTextBoxColumn";
            timeDataGridViewTextBoxColumn.ReadOnly = true;
            timeDataGridViewTextBoxColumn.Width = 125;
            // 
            // statuDataGridViewCheckBoxColumn
            // 
            statuDataGridViewCheckBoxColumn.DataPropertyName = "Statu";
            statuDataGridViewCheckBoxColumn.HeaderText = "Statu";
            statuDataGridViewCheckBoxColumn.MinimumWidth = 6;
            statuDataGridViewCheckBoxColumn.Name = "statuDataGridViewCheckBoxColumn";
            statuDataGridViewCheckBoxColumn.ReadOnly = true;
            statuDataGridViewCheckBoxColumn.Width = 125;
            // 
            // etutDTOBindingSource
            // 
            etutDTOBindingSource.DataSource = typeof(EtutProject.DataAccess.Entities.EtutDTO);
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnUpdate);
            groupBox4.Controls.Add(lblTeacher);
            groupBox4.Controls.Add(lblStudent);
            groupBox4.Controls.Add(checkBox1);
            groupBox4.Controls.Add(maskedTextBox2);
            groupBox4.Controls.Add(label14);
            groupBox4.Controls.Add(dateTimePicker2);
            groupBox4.Controls.Add(label16);
            groupBox4.Controls.Add(label18);
            groupBox4.Controls.Add(label17);
            groupBox4.Controls.Add(label20);
            groupBox4.Location = new Point(311, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(324, 222);
            groupBox4.TabIndex = 3;
            groupBox4.TabStop = false;
            groupBox4.Text = "Etüt Düzenle";
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(96, 176);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(190, 29);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // lblTeacher
            // 
            lblTeacher.AutoSize = true;
            lblTeacher.Location = new Point(96, 59);
            lblTeacher.Name = "lblTeacher";
            lblTeacher.Size = new Size(0, 20);
            lblTeacher.TabIndex = 6;
            // 
            // lblStudent
            // 
            lblStudent.AutoSize = true;
            lblStudent.Location = new Point(96, 30);
            lblStudent.Name = "lblStudent";
            lblStudent.Size = new Size(0, 20);
            lblStudent.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(98, 146);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(18, 17);
            checkBox1.TabIndex = 5;
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // maskedTextBox2
            // 
            maskedTextBox2.Location = new Point(98, 112);
            maskedTextBox2.Mask = "00:00";
            maskedTextBox2.Name = "maskedTextBox2";
            maskedTextBox2.Size = new Size(47, 27);
            maskedTextBox2.TabIndex = 4;
            maskedTextBox2.ValidatingType = typeof(DateTime);
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(22, 29);
            label14.Name = "label14";
            label14.Size = new Size(68, 20);
            label14.TabIndex = 0;
            label14.Text = "Öğrenci :";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(98, 85);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(214, 27);
            dateTimePicker2.TabIndex = 2;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(7, 56);
            label16.Name = "label16";
            label16.Size = new Size(83, 20);
            label16.TabIndex = 0;
            label16.Text = "Öğretmen :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(43, 90);
            label18.Name = "label18";
            label18.Size = new Size(47, 20);
            label18.TabIndex = 0;
            label18.Text = "Tarih :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(27, 146);
            label17.Name = "label17";
            label17.Size = new Size(61, 20);
            label17.TabIndex = 0;
            label17.Text = "Durum :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(43, 115);
            label20.Name = "label20";
            label20.Size = new Size(45, 20);
            label20.TabIndex = 0;
            label20.Text = "Saat :";
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(textBoxBranchName);
            groupBox5.Controls.Add(label21);
            groupBox5.Controls.Add(button3);
            groupBox5.Location = new Point(896, 352);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(231, 163);
            groupBox5.TabIndex = 4;
            groupBox5.TabStop = false;
            groupBox5.Text = "Branş Ekle";
            // 
            // textBoxBranchName
            // 
            textBoxBranchName.Location = new Point(60, 37);
            textBoxBranchName.Name = "textBoxBranchName";
            textBoxBranchName.Size = new Size(165, 27);
            textBoxBranchName.TabIndex = 1;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(20, 41);
            label21.Name = "label21";
            label21.Size = new Size(35, 20);
            label21.TabIndex = 0;
            label21.Text = "Ad :";
            // 
            // button3
            // 
            button3.Location = new Point(60, 80);
            button3.Name = "button3";
            button3.Size = new Size(165, 29);
            button3.TabIndex = 4;
            button3.Text = "Ekle";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(textBox1);
            groupBox3.Controls.Add(textBox2);
            groupBox3.Controls.Add(comboBox1);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(641, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(249, 222);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "Öğretmen Ekle";
            // 
            // button2
            // 
            button2.Location = new Point(72, 137);
            button2.Name = "button2";
            button2.Size = new Size(171, 29);
            button2.TabIndex = 4;
            button2.Text = "Ekle";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(73, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(170, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(73, 61);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(170, 27);
            textBox2.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(72, 97);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(170, 28);
            comboBox1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(32, 28);
            label15.Name = "label15";
            label15.Size = new Size(35, 20);
            label15.TabIndex = 0;
            label15.Text = "Ad :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(10, 62);
            label19.Name = "label19";
            label19.Size = new Size(57, 20);
            label19.TabIndex = 0;
            label19.Text = "Soyad :";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 100);
            label13.Name = "label13";
            label13.Size = new Size(52, 20);
            label13.TabIndex = 0;
            label13.Text = "Branş :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1138, 527);
            Controls.Add(groupBox3);
            Controls.Add(groupBox5);
            Controls.Add(groupBox4);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.WindowText;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)etutDTOBindingSource).EndInit();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox cbxStudent;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private ComboBox cbxBranch;
        private ComboBox cbxTeacher;
        private MaskedTextBox maskedTextBox1;
        private Label label5;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private DataGridView dataGridView1;
        private TextBox tbxStudentSurname;
        private TextBox tbxStudentName;
        private Label label9;
        private Label label11;
        private Label label10;
        private Label label8;
        private BindingSource etutDTOBindingSource;
        private Button btnStudentImagePicker;
        private Button btnAddStudent;
        private MaskedTextBox maskedTextBoxPhone;
        private NumericUpDown numericUpDown1;
        private TextBox tbxMail;
        private DataGridViewTextBoxColumn etutIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn studentNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn teacherNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn timeDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn statuDataGridViewCheckBoxColumn;
        private GroupBox groupBox4;
        private MaskedTextBox maskedTextBox2;
        private Label label14;
        private DateTimePicker dateTimePicker2;
        private Label label16;
        private Label label18;
        private Label label20;
        private CheckBox checkBox1;
        private Label label17;
        private Label lblTeacher;
        private Label lblStudent;
        private Button btnUpdate;
        private GroupBox groupBox5;
        private TextBox textBoxBranchName;
        private Label label21;
        private Button button3;
        private GroupBox groupBox3;
        private Button button2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Label label15;
        private Label label19;
        private Label label13;
        private PictureBox pictureBox1;
        private Label label12;
    }
}