using System;
using System.Drawing;
using System.Windows.Forms;

public partial class GuessForm : Form
{
    int secret = 0;
    // int lastGuess = 0;
    // bool firstGuess = true;
    int count = 0;
    Random randomNumber;

    // default constructor
    public GuessForm()
    {
        InitializeComponent();
    } // end constructor

    // randomly generate secret number (1-1000)
    private void GenerateSecret()
    {
        randomNumber = new Random();
        secret = randomNumber.Next(1000) + 1;
        lblDisplayRand.Text = secret.ToString();
    } // end method GenerateSecret

    
    private void inputTextBox_KeyDown(object sender, KeyEventArgs e)
    {
        // allow user to press enter in textbox
        if (e.KeyCode == Keys.Enter)
        {
            count++;
            int userGuess = Convert.ToInt32(inputTextBox.Text);
            if (userGuess < secret)
            {
                // outputLabel.Text = "Too Low, Guess a bit higher";
                richTextBox1.Text += userGuess.ToString() + " - Too low, guess a bit higher\r\n";
            }
            else if (userGuess > secret)
            {
                // outputLabel.Text = "Too High, Guess a bit lower";
                richTextBox1.Text += userGuess.ToString() + " - Too high, guess a bit lower\r\n";
            }
            else
            {
                if (count > 10)
                {
                    BackColor = Color.LightSalmon;
                    outputLabel.Text = "You have guessed the number, but you could do better.";
                    newGameButton.Enabled = true;
                    inputTextBox.ReadOnly = true;
                }
                else
                {
                    BackColor = Color.LightBlue;
                    outputLabel.Text = "Congratulations, You have guessed the number.";
                    newGameButton.Enabled = true;
                    inputTextBox.ReadOnly = true;
                }
            }
            btnNumGuesses.Text = Convert.ToString(count);

            // clear guess
            inputTextBox.SelectAll();
            // lastGuess = userGuess;
        } // end if
    } // end method inputTextBox_KeyDown

    private void newGameButton_Click(object sender, EventArgs e)
    {
      

        GenerateSecret();

        newGameButton.Enabled = false;
        inputTextBox.ReadOnly = false;
        BackColor = Color.FromName("Control");
        outputLabel.Text = "";

        inputTextBox.Clear();
        richTextBox1.Clear();
        inputTextBox.Focus();
        outputLabel.Text = "New Game in Progress...";

    }

    private void btnExit_Click(object sender, EventArgs e)
    {
        Close();
    }

} // end class GuessForm
