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
    public partial class GameHistory : Form1
    {
        public GameHistory()
        {
            InitializeComponent();
        }

        private void GameHistory_Load(object sender, EventArgs e)
        {
            labelUserName.Text = User.fName;
            GameSetting gameSetting = new GameSetting();
            dgvGameHistory.DataSource = gameSetting.getGameHistory(User.username); //call method to get game history
        }

        private void toolHome_Click(object sender, EventArgs e)
        {
            this.Close();
            MainMenu mainMenu = new MainMenu();
            mainMenu.Show();
        }
    }
}
