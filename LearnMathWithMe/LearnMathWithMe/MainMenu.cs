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
    public partial class MainMenu : Form1 //Inherite
    {
        public static String selected = "";
       
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            labelUserName.Text = User.fName + " !!";
        }

        private void btnAddition_Click(object sender, EventArgs e)
        {
            selected = btnAddition.Text;
            this.Hide();
            MathTemplate mathTemplate = new MathTemplate();   
            mathTemplate.Show();    
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            selected = btnSubtraction.Text;
            this.Hide();
            MathTemplate mathTemplate = new MathTemplate();
            mathTemplate.Show();      
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            selected = btnMultiplication.Text;
            this.Hide();
            MathTemplate mathTemplate = new MathTemplate();
            mathTemplate.Show();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            selected = btnDivision.Text;
            this.Hide();
            MathTemplate mathTemplate = new MathTemplate();
            mathTemplate.Show();      
        }

        private void loginUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditProfile editProfile = new EditProfile();
            editProfile.Show();         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameHistory gameHistory = new GameHistory();
            gameHistory.Show();
            
        }

        private void signOut_Click(object sender, EventArgs e)
        {
           if(MessageBox.Show("Are you OK to sign out?", "Sign out", MessageBoxButtons.YesNo) == DialogResult.Yes)
           {
                MessageBox.Show("Good bye, " + User.fName + " !!");
                this.Close();                
            }

           else
            {
                this.Show();
            }
        }
    }
}
