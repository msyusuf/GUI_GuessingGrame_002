partial class GuessForm
{
   /// <summary>
   /// Required designer variable.
   /// </summary>
   private System.ComponentModel.IContainer components = null;

   /// <summary>
   /// Clean up any resources being used.
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
   /// Required method for Designer support - do not modify
   /// the contents of this method with the code editor.
   /// </summary>
   private void InitializeComponent()
   {
            this.displayLabel = new System.Windows.Forms.Label();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.newGameButton = new System.Windows.Forms.Button();
            this.outputLabel = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblGuess = new System.Windows.Forms.Label();
            this.lblUserGuess = new System.Windows.Forms.Label();
            this.btnNumGuesses = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lblDisplayRand = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // displayLabel
            // 
            this.displayLabel.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.displayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayLabel.Location = new System.Drawing.Point(29, 24);
            this.displayLabel.Name = "displayLabel";
            this.displayLabel.Size = new System.Drawing.Size(226, 56);
            this.displayLabel.TabIndex = 0;
            this.displayLabel.Text = "I have a number between 1 and 1000. Can you guess the number?";
            // 
            // inputTextBox
            // 
            this.inputTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.inputTextBox.Location = new System.Drawing.Point(143, 102);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.ReadOnly = true;
            this.inputTextBox.Size = new System.Drawing.Size(44, 20);
            this.inputTextBox.TabIndex = 1;
            this.inputTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputTextBox_KeyDown);
            // 
            // newGameButton
            // 
            this.newGameButton.Location = new System.Drawing.Point(279, 24);
            this.newGameButton.Name = "newGameButton";
            this.newGameButton.Size = new System.Drawing.Size(84, 28);
            this.newGameButton.TabIndex = 2;
            this.newGameButton.Text = "&New Game";
            this.newGameButton.Click += new System.EventHandler(this.newGameButton_Click);
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(29, 330);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 16);
            this.outputLabel.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit.Location = new System.Drawing.Point(279, 58);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(84, 24);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblGuess
            // 
            this.lblGuess.AutoSize = true;
            this.lblGuess.Location = new System.Drawing.Point(34, 303);
            this.lblGuess.Name = "lblGuess";
            this.lblGuess.Size = new System.Drawing.Size(106, 13);
            this.lblGuess.TabIndex = 5;
            this.lblGuess.Text = "Number of Guesses: ";
            // 
            // lblUserGuess
            // 
            this.lblUserGuess.AutoSize = true;
            this.lblUserGuess.Location = new System.Drawing.Point(34, 108);
            this.lblUserGuess.Name = "lblUserGuess";
            this.lblUserGuess.Size = new System.Drawing.Size(77, 13);
            this.lblUserGuess.TabIndex = 6;
            this.lblUserGuess.Text = "Enter a Guess:";
            // 
            // btnNumGuesses
            // 
            this.btnNumGuesses.Location = new System.Drawing.Point(143, 300);
            this.btnNumGuesses.Name = "btnNumGuesses";
            this.btnNumGuesses.ReadOnly = true;
            this.btnNumGuesses.Size = new System.Drawing.Size(44, 20);
            this.btnNumGuesses.TabIndex = 7;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(37, 142);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(230, 138);
            this.richTextBox1.TabIndex = 8;
            this.richTextBox1.Text = "";
            // 
            // lblDisplayRand
            // 
            this.lblDisplayRand.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblDisplayRand.Enabled = false;
            this.lblDisplayRand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayRand.ForeColor = System.Drawing.Color.Red;
            this.lblDisplayRand.Location = new System.Drawing.Point(218, 102);
            this.lblDisplayRand.Name = "lblDisplayRand";
            this.lblDisplayRand.Size = new System.Drawing.Size(44, 20);
            this.lblDisplayRand.TabIndex = 9;
            this.lblDisplayRand.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GuessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.CancelButton = this.btnExit;
            this.ClientSize = new System.Drawing.Size(383, 379);
            this.Controls.Add(this.lblDisplayRand);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnNumGuesses);
            this.Controls.Add(this.lblUserGuess);
            this.Controls.Add(this.lblGuess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.newGameButton);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.displayLabel);
            this.Name = "GuessForm";
            this.Text = "Guessing Game";
            this.ResumeLayout(false);
            this.PerformLayout();

   }

   #endregion

   private System.Windows.Forms.Label displayLabel;
   private System.Windows.Forms.TextBox inputTextBox;
   private System.Windows.Forms.Button newGameButton;
   private System.Windows.Forms.Label outputLabel;
    private System.Windows.Forms.Button btnExit;
    private System.Windows.Forms.Label lblGuess;
    private System.Windows.Forms.Label lblUserGuess;
    private System.Windows.Forms.TextBox btnNumGuesses;
    private System.Windows.Forms.RichTextBox richTextBox1;
    private System.Windows.Forms.Label lblDisplayRand;
}
