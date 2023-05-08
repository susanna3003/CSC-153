using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
* 4/24/2023
* CSC 153
* Susanna Quayle
* World Series Championships
*/

namespace WindowsUI
{
    public partial class worldSeriesChampForm : Form
    {
        public worldSeriesChampForm()
        {
            InitializeComponent();

            List<string> teamsList = new List<string>();
            Dictionary<string, int> teamWins = new Dictionary<string, int>();

            StreamReader readingTeamsFile;
            readingTeamsFile = File.OpenText(@"D:\SUSU\SPRING 2023\C#\MODULE 5\World_Series_Championships\Teams.txt");

            while (!readingTeamsFile.EndOfStream)
            {
                teamsList.Add(readingTeamsFile.ReadLine());
            }

            for (int i = 0; i < teamsList.Count; i++)
            {
                teamsListBox.Items.Add(teamsList[i]);
            }

            foreach (string team in teamsList)
            {
                teamWins.Add(team, 0);
            }

            StreamReader readingWinnerFile;
            readingWinnerFile = File.OpenText(@"D:\SUSU\SPRING 2023\C#\MODULE 5\World_Series_Championships\WorldSeriesWinners.txt");

            while (!readingWinnerFile.EndOfStream)
            {
                teamWins[readingWinnerFile.ReadLine()] += 1;
            }

        }

        private void teamsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
