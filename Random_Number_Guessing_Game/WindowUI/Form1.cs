using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 3/1/2023
* CSC 153
* Susanna Quayle
* Random Number Guessing Game
*/

namespace WindowUI
{
    public partial class randomNumForm : Form
    {
        public randomNumForm()
        {
            InitializeComponent();
        }

        Random rand = new Random();

        int count = 0, randomNum = 0, userGuess = 0;
        //randomNum = rand.Next(1, 100) + 1;
        private void guessButton_Click(object sender, EventArgs e)
        {
            // import random num
            Random rand = new Random();

            // declare variables
            //int count = 0, randomNum = 0, userGuess = 0;
            bool correctGuess = false;

            // create random num
            //randomNum = rand.Next(1, 100) + 1;

           
            userGuess = int.Parse(userGuessTextBox.Text);
            if (userGuess > randomNum)
            {
                resultLabel.Text = ("Guess is too high, try again!");
                count++;
                userGuessTextBox.Clear();
            }
            else if (userGuess < randomNum)
            {
                resultLabel.Text = ("Guess is too low, try again!");
                count++;
                userGuessTextBox.Clear();
            }
            else
            {
                resultLabel.Text = ("You got it! And it only took you " + count + " tries!");
                correctGuess = true;
            }


        }

        private void randomNumForm_Load(object sender, EventArgs e)
        {
            randomNum = rand.Next(1, 100) + 1;
        }
    }
}
