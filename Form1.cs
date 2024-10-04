using System.Windows.Forms;

namespace GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"c:\";
            openFileDialog1.Filter = "Bitmaps |*.bmp|JPGs|*.jpg|GIFs|*.gif|All files|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.FileName = "";

            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != string.Empty)
                pictureBox1.Load(openFileDialog1.FileName);
            else
                return;
        }

        private void lastName_TextChanged(object sender, EventArgs e)
        {

        }
        private void Info(string ln, string fn)
        {
            MessageBox.Show($"Student Name: {fn} {ln}");
        }
        private void Info(string ln, string fn, string mn, string gender)
        {
            MessageBox.Show($"Student Name: {fn} {mn} {ln} /\nGender: {gender}");
        }
        private void Info(string ln, string fn, string mn, string gender, string program)
        {
            MessageBox.Show($"Student name: {fn} {mn} {ln} \nGender: {gender} \nProgram: {program}");
        }
        private void Info(string ln, string fn, string mn, string gender, string program, string month, string day, string year)
        {
            MessageBox.Show($"Student name: {fn} {mn} {ln} \nGender: {gender} \nDate of Birth: {month}/{day}/{year} \nProgram: {program} ");
        }
        private void buttRegister_Click(object sender, EventArgs e)
        {
            string ln = lastName.Text;
            string fn = firstName.Text;
            string mn = midName.Text;
            string gender = buttFemale.Checked ? "Female" : buttMale.Checked ? "Male" : "";
            string day = cbDay.SelectedItem?.ToString();
            string month =cbMonth.SelectedItem?.ToString();
            string year = cbYear.SelectedItem?.ToString();
            string program =cbProgram.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(ln) || string.IsNullOrEmpty(fn))
            {
                MessageBox.Show("Please fill in both Last Name and First Name.", "Error");
                return;
            }
            Info(ln, fn);
            Info(ln, fn, mn, gender);
            Info(ln, fn, mn, gender, program);
            Info(ln, fn,mn,gender,program,month, day, year);
            
        }
        
    }
}
