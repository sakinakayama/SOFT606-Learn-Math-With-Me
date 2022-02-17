using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnMathWithMe
{
    public partial class EditProfile : Form1
    {
        public EditProfile()
        {
            InitializeComponent();
        }

        public string FirstName
        {
            get { return txtFist.Text; }
            set { txtFist.Text = value; }
        }

        public string LastName
        {
            get { return txtLast.Text; }
            set { txtLast.Text = value; }
        }

        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }

        public string SchoolYear
        {
            get { return cmbYear.Text; }
            set { cmbYear.Text = value; }
        }

        public string Teacher
        {
            get { return cmbTeacher.Text; }
            set { cmbTeacher.Text = value; }
        }


        private void EditProfile_Load(object sender, EventArgs e)
        {
            labelUserName.Text = User.username;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkNameFormat();
                GameSetting gameSetting = new GameSetting();
                gameSetting.updateProfile(FirstName, LastName, Password, Convert.ToInt32(SchoolYear), Teacher);
            }
            catch (InvalidNameException exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    
        private void toolHome_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }

        public void checkNameFormat()
        {
            if (!FirstName.All(Char.IsLetter) || !LastName.All(Char.IsLetter))
            {
                throw new InvalidNameException("Invalid charactor in your name");
            }

            else if (FirstName.All(Char.IsNumber) || LastName.All(Char.IsNumber))
            {
                throw new InvalidNameException("Invalid charactor in your name");
            }

            else if (FirstName == "" || LastName == "" || Password == "" || SchoolYear == "" || Teacher == "")
            {
                throw new InvalidNameException("Please enter ALL information");
            }
        }
    }
}
