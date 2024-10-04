namespace GUI
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
            label1 = new Label();
            label2 = new Label();
            lastName = new TextBox();
            firstName = new TextBox();
            label3 = new Label();
            midName = new TextBox();
            nothing = new Label();
            label5 = new Label();
            buttMale = new RadioButton();
            buttFemale = new RadioButton();
            label6 = new Label();
            cbDay = new ComboBox();
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            label7 = new Label();
            cbProgram = new ComboBox();
            buttRegister = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button2 = new Button();
            openFileDialog1 = new OpenFileDialog();
            folderBrowserDialog1 = new FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 20);
            label1.Name = "label1";
            label1.Size = new Size(322, 28);
            label1.TabIndex = 0;
            label1.Text = "Student Registration Form";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(25, 71);
            label2.Name = "label2";
            label2.Size = new Size(98, 18);
            label2.TabIndex = 1;
            label2.Text = "Last name *";
            // 
            // lastName
            // 
            lastName.Location = new Point(25, 99);
            lastName.Name = "lastName";
            lastName.Size = new Size(389, 26);
            lastName.TabIndex = 2;
            lastName.TextChanged += lastName_TextChanged;
            // 
            // firstName
            // 
            firstName.Location = new Point(25, 177);
            firstName.Name = "firstName";
            firstName.Size = new Size(389, 26);
            firstName.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(25, 149);
            label3.Name = "label3";
            label3.Size = new Size(101, 18);
            label3.TabIndex = 3;
            label3.Text = "First name *";
            // 
            // midName
            // 
            midName.Location = new Point(25, 255);
            midName.Name = "midName";
            midName.Size = new Size(389, 26);
            midName.TabIndex = 6;
            // 
            // nothing
            // 
            nothing.AutoSize = true;
            nothing.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nothing.Location = new Point(25, 227);
            nothing.Name = "nothing";
            nothing.Size = new Size(116, 18);
            nothing.TabIndex = 5;
            nothing.Text = "Middle name *";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(25, 299);
            label5.Name = "label5";
            label5.Size = new Size(76, 18);
            label5.TabIndex = 7;
            label5.Text = "Gender *";
            // 
            // buttMale
            // 
            buttMale.AutoSize = true;
            buttMale.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttMale.Location = new Point(117, 299);
            buttMale.Name = "buttMale";
            buttMale.Size = new Size(59, 22);
            buttMale.TabIndex = 8;
            buttMale.TabStop = true;
            buttMale.Text = "Male";
            buttMale.UseVisualStyleBackColor = true;
            // 
            // buttFemale
            // 
            buttFemale.AutoSize = true;
            buttFemale.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttFemale.Location = new Point(195, 299);
            buttFemale.Name = "buttFemale";
            buttFemale.Size = new Size(76, 22);
            buttFemale.TabIndex = 9;
            buttFemale.TabStop = true;
            buttFemale.Text = "Female";
            buttFemale.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(25, 333);
            label6.Name = "label6";
            label6.Size = new Size(116, 18);
            label6.TabIndex = 11;
            label6.Text = "Date of birth *";
            // 
            // cbDay
            // 
            cbDay.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbDay.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31" });
            cbDay.Location = new Point(25, 352);
            cbDay.Name = "cbDay";
            cbDay.Size = new Size(85, 26);
            cbDay.TabIndex = 13;
            cbDay.Text = "Day";
            // 
            // cbMonth
            // 
            cbMonth.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "January", "February", "March ", "April", "May", "June", "July", "August", "September", "October ", "November", "December" });
            cbMonth.Location = new Point(117, 352);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(116, 26);
            cbMonth.TabIndex = 14;
            cbMonth.Text = "Month";
            // 
            // cbYear
            // 
            cbYear.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbYear.FormattingEnabled = true;
            cbYear.Items.AddRange(new object[] { "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997", "1998", "1999", "2000", "2001", "2002", "2003", "2004", "2005", "2006", "2007", "2008", "2009", "2010", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024" });
            cbYear.Location = new Point(241, 352);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(134, 26);
            cbYear.TabIndex = 15;
            cbYear.Text = "Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(25, 394);
            label7.Name = "label7";
            label7.Size = new Size(151, 18);
            label7.TabIndex = 16;
            label7.Text = "Program to Apply *";
            // 
            // cbProgram
            // 
            cbProgram.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cbProgram.FormattingEnabled = true;
            cbProgram.Items.AddRange(new object[] { "Bachelor of Architecture (B.Arch.)", "Bachelor of Arts (B.A.)", "Bachelor of Business (B.B.)", "Bachelor of Business Administration (B.B.A.)", "Bachelor of Science in Business (B.S.B.)", "Bachelor of Canon Law (B.C.L.)", "Bachelor of Computer Science (B.C.S.)", "Bachelor of Science in Computer Science (B.S.C.S.)", "Bachelor of Criminal Justice (B.C.J.)", "Bachelor of Science in Criminal Justice (B.S.C.J.)", "Bachelor of Divinity (B.D.)", "Bachelor of Education (B.Ed.)", "Bachelor of Science in Education (B.S.Ed.)", "Bachelor of Wireless Engineering (B.W.E.)", "Bachelor of Engineering (B.E./B.Eng.)", "Bachelor of Science in Engineering (B.S.E./B.S.EN.)", "Bachelor of Science in Aerospace Engineering (B.S.A.E.)", "Bachelor of Science in Agricultural Engineering (B.S.A.E.)", "Bachelor of Science in Biological Systems (B.S.B.S.)", "Bachelor of Science in Biosystems and Agricultural Engineering (B.S.B.A.E.)", "Bachelor of Science in Biological Engineering (B.S.B.E.)", "Bachelor of Biomedical Engineering (B.B.m.E.)", "Bachelor of Science in Biomedical Engineering (B.S.B.E./B.S.B.M.E.)", "Bachelor of Science in Chemical Engineering (B.S.Ch.E.)", "Bachelor of Science in Chemical and Biomolecular Engineering (B.S.Ch.B.E.)", "Bachelor of Science in Chemical and Materials Engineering (B.S.C.M.E.)", "Bachelor of Civil Engineering (B.C.E.)", "Bachelor of Science in Civil Engineering (B.S.C.E.)", "Bachelor of Science in Civil and Infrastructure Engineering (B.S.-C.I.E.)", "Bachelor of Computer Engineering (B.Comp.E.)", "Bachelor of Science in Computer Engineering (B.S.C.E./B.S.Cmp.E.)", "Bachelor of Science in Computer Science and Engineering (B.S.C.S.E.)", "Bachelor of Science in Electrical and Computer Engineering (B.S.E.C.E.)", "Bachelor of Electrical Engineering (B.E.E.)", "Bachelor of Science in Electrical Engineering (B.S.E.E.)", "Bachelor of Science in Engineering Management (B.S.E.Mgt.)", "Bachelor of Science in Environmental Engineering (B.S.En.E./B.S.Env.E.)", "Bachelor of Fiber Engineering (B.F.E.)", "Bachelor of Science in Industrial Engineering (B.S.I.E.)", "Bachelor of Science in Manufacturing Engineering (B.S.Mfg.E.)", "Bachelor of Science in Manufacturing Systems Engineering (B.S.M.S.E.)", "Bachelor of Science in Materials Science and Engineering (B.S.M.S.E.)", "Bachelor of Science in Materials Engineering (B.S.MA.E.)", "Bachelor of Mechanical Engineering (B.M.E.)", "Bachelor of Science in Mechanical Engineering (B.S.M.E.)", "Bachelor of Science in Metallurgical Engineering (B.S.Mt.E.)", "Bachelor of Science in Mining Engineering (B.S.MI.E.)", "Bachelor of Science in Systems (B.S.-SYST.)", "Bachelor of Software Engineering (B.S.W.E.)", "Bachelor of Science in Software Engineering (B.S.S.E.)", "Bachelor of Systems Engineering (B.S.E.)", "Bachelor of Science in Systems Engineering (B.S.S.E.)", "Bachelor of Engineering Technology (B.E.T.)", "Bachelor of Science in Engineering Technology (B.S.E.T.)", "Bachelor of Science in Civil Engineering Technology (B.S.C.E.T./B.S.Civ.E.T.)", "Bachelor of Science in Computer Engineering Technology (B.S.C.E.T.)", "Bachelor of Science in Construction Engineering Technology (B.S.Con.E.T.)", "Bachelor of Science in Drafting Design Technology (B.S.D.D.T.)", "Bachelor of Science in Electrical/Electronics Technology (B.S.E.T.)", "Bachelor of Science in Electrical Engineering Technology (B.S.E.E.T.)", "Bachelor of Science in Electro-Mechanical Engineering Technology (B.S.E.M.E.T.)", "Bachelor of Science in Mechanical Engineering Technology (B.S.M.E.T.)", "Bachelor of Fine Arts (B.F.A.)", "Bachelor of Forestry (B.F.)", "Bachelor of Science in Forest Research (B.S.For.Res.)", "Bachelor of Hebrew Letters (B.H.L.)", "Bachelor of Journalism (B.J.)", "Bachelor of Laws (LL.B.)", "Bachelor of Liberal Studies (B.L.S.)", "Bachelor of Literature (B.Lit.)", "Bachelor of Marine Science (B.M.S.)", "Bachelor of Music (B.M.)", "Bachelor of Nursing (B.N.)", "Bachelor of Science in Nursing (B.S.N.)", "Bachelor of Pharmacy (B.Pharm.)", "Bachelor of Philosophy (B.Phil.)", "Bachelor of Religious Education (B.R.E.)", "Bachelor of Science (B.S.)", "Bachelor of Science in Chemistry (B.S.Ch.)", "Bachelor of Technology (B.T./B.Tech.)" });
            cbProgram.Location = new Point(25, 413);
            cbProgram.Name = "cbProgram";
            cbProgram.Size = new Size(389, 26);
            cbProgram.TabIndex = 17;
            cbProgram.Text = "-Select Program-";
            // 
            // buttRegister
            // 
            buttRegister.BackColor = SystemColors.ControlDark;
            buttRegister.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttRegister.ForeColor = SystemColors.ButtonHighlight;
            buttRegister.Location = new Point(25, 456);
            buttRegister.Name = "buttRegister";
            buttRegister.Size = new Size(209, 38);
            buttRegister.TabIndex = 18;
            buttRegister.Text = "Register Student";
            buttRegister.UseVisualStyleBackColor = false;
            buttRegister.Click += buttRegister_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ButtonHighlight;
            pictureBox1.Location = new Point(13, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(251, 221);
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDark;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(455, -20);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 577);
            panel1.TabIndex = 20;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Font = new Font("Tahoma", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(37, 343);
            button2.Name = "button2";
            button2.Size = new Size(209, 38);
            button2.TabIndex = 20;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(731, 553);
            Controls.Add(panel1);
            Controls.Add(buttRegister);
            Controls.Add(cbProgram);
            Controls.Add(label7);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Controls.Add(cbDay);
            Controls.Add(label6);
            Controls.Add(buttFemale);
            Controls.Add(buttMale);
            Controls.Add(label5);
            Controls.Add(midName);
            Controls.Add(nothing);
            Controls.Add(firstName);
            Controls.Add(label3);
            Controls.Add(lastName);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Tahoma", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Student Register Form";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private TextBox lastName;
        private TextBox firstName;
        private Label label3;
        private TextBox midName;
        private Label nothing;
        private Label label5;
        private RadioButton buttMale;
        private RadioButton buttFemale;
        private Label label6;
        private ComboBox cbDay;
        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Label label7;
        private ComboBox cbProgram;
        private Button buttRegister;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button2;
        private OpenFileDialog openFileDialog1;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}
