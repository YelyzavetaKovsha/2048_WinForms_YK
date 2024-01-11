using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/******************************************************************
Name: 2048
Author: Yelyzaveta Kovsha
Date: 20.11.2023
Description: game 2048 written on C# with Windows Forms interface
******************************************************************/
namespace _2048_Winform
{
    public partial class Form1 : Form
    {

        private static int UpdateCounter = 0; // update counter used to avoid generating 2 numbers all the time
        private static int score = 0; // score counter
        private bool[,] combinedThisMove = new bool[4, 4]; // is combined this move? to avoid double fusion


        private const int CellSize = 100; // size of a cell
        private const int GridSize = 4;   // size of the table (4x4)

        private int[,] grid = new int[GridSize, GridSize]; // table 2048
        private Random random = new Random();


        public Form1()
        {
            this.KeyPreview = true; // Enable key preview
            InitializeComponent();
            InitializeGame();
            panelGame.Paint += new PaintEventHandler(panelGame_Paint);

        }

        // method for initializing the game
        private void InitializeGame()
        {
            // initilaze the table and add first 2 values
            AddAndUpdate();
            panelGame.Invalidate();
        }

        // prevents the keys to switch between buttons while playing
        private bool arrowKeyPressed = false;

        // method which prevents arrow keys to switch between the buttons
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            // Ignore movement keys when the game is paused
            if (isGamePaused)
            {
                return true;
            }

            switch (keyData)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    if (!arrowKeyPressed)
                    {
                        arrowKeyPressed = true;

                        if (MoveNumbers(keyData))
                        {
                            AddAndUpdate();
                            if (GameEnd()) Close();
                        }
                    }
                    return true;

                default:
                    return base.ProcessCmdKey(ref msg, keyData);
            }
        }

        // method which accepts only KeyUp events to avoid infinite movements on keydown
        protected override void OnKeyUp(KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Up:
                case Keys.Down:
                case Keys.Left:
                case Keys.Right:
                    arrowKeyPressed = false;
                    break;

                default:
                    base.OnKeyUp(e);
                    break;
            }
        }

       
        private bool isGamePaused = false; // game declared as not paused

        // method for calling other direction methods depending on the key pressed
        private bool MoveNumbers(Keys key)
        {
            if (isGamePaused)
            {
                return false; // Movement is disabled when the game is paused
            }

            combinedThisMove = new bool[GridSize, GridSize]; // avoiding double fusion

            switch (key)
            {
                case Keys.Up:
                    return MoveUp();

                case Keys.Down:
                    return MoveDown();

                case Keys.Left:
                    return MoveLeft();

                case Keys.Right:
                    return MoveRight();

                default:
                    // Display an error message for unsupported keys
                    MessageBox.Show("Unsupported key", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
            }
        }

        // method for moving up
        private bool MoveUp()
        {
            bool moved = false; // mark as not moved

            // outer loop for columns
            for (int i = 0; i < GridSize; i++)
            {
                // inner loop for columns
                for (int j = 1; j < GridSize; j++)
                {
                    // check if the current element is not zero
                    if (grid[i, j] != 0)
                    {
                        int k = j;

                        // move up until non-zero element or top of the grid is reached
                        while (k > 0 && grid[i, k - 1] == 0)
                        {
                            grid[i, k - 1] = grid[i, k];
                            grid[i, k] = 0;
                            k--;
                            moved = true; // mark as moved
                        }

                        // check is the element above can be combined with and if fusion was already made this move
                        if (k > 0 && !combinedThisMove[i, k - 1] && grid[i, k - 1] == grid[i, k])
                        {
                            // combine
                            grid[i, k - 1] *= 2;
                            score += grid[i, k - 1];
                            grid[i, k] = 0;
                            combinedThisMove[i, k - 1] = true; // mark as combined this move to avoid double fusion
                            moved = true; // mark as moved
                        }
                    }
                }
            }
            // return whether the grid moved or not
            return moved;
        }

        // method for moving down
        private bool MoveDown()
        {
            bool moved = false; // mark as not moved

            // outer loop for columns
            for (int i = 0; i < GridSize; i++)
            {
                // inner loop for rows (startting from the 3rd row)
                for (int j = GridSize - 2; j >= 0; j--)
                {
                    // check if the current element is not 0
                    if (grid[i, j] != 0)
                    {
                        int k = j;
                        // move down until reaching the bottom or another element
                        while (k < GridSize - 1 && grid[i, k + 1] == 0)
                        {
                            // move down
                            grid[i, k + 1] = grid[i, k];
                            grid[i, k] = 0;
                            k++;
                            moved = true; // mark as moved
                        }

                        // check if the element below can be combined with
                        if (k < GridSize - 1 && !combinedThisMove[i, k + 1] && grid[i, k + 1] == grid[i, k])
                        {
                            grid[i, k + 1] *= 2;
                            score += grid[i, k + 1];
                            grid[i, k] = 0;
                            combinedThisMove[i, k + 1] = true; // Mark as combined for this move (to avoid double fusion)
                            moved = true; // mark as moved
                        }
                    }
                }
            }

            // return whether the movement occured or not
            return moved;
        }

        // method for moving left
        private bool MoveLeft()
        {
            bool moved = false; // mark as not moved

            // outer loop for rows
            for (int j = 0; j < GridSize; j++)
            {
                // inner loop for columns from the 2nd
                for (int i = 1; i < GridSize; i++)
                {
                    // check if the element is not 0
                    if (grid[i, j] != 0)
                    {
                        int k = i;

                        // move left until the next tile or reaching the leftmost column
                        while (k > 0 && grid[k - 1, j] == 0)
                        {
                            grid[k - 1, j] = grid[k, j];
                            grid[k, j] = 0;
                            k--;
                            moved = true;
                        }

                        // check if the value to the left can be combined with
                        if (k > 0 && !combinedThisMove[k - 1, j] && grid[k - 1, j] == grid[k, j])
                        {
                            // combine
                            grid[k - 1, j] *= 2;
                            score += grid[k - 1, j];
                            grid[k, j] = 0;
                            combinedThisMove[k - 1, j] = true; // Mark as combined for this move
                            moved = true; // mark as moved
                        }
                    }
                }
            }

            return moved; // return whether the movement occured
        }

        // method for moving right
        private bool MoveRight()
        {
            // mark as not moved
            bool moved = false;

            // outer loop for rows
            for (int j = 0; j < GridSize; j++)
            {
                // inner loop for columns from the 3rd to last
                for (int i = GridSize - 2; i >= 0; i--)
                {
                    // check if the current element is not zero
                    if (grid[i, j] != 0)
                    {
                        int k = i;

                        // move right until the next tile or right most column
                        while (k < GridSize - 1 && grid[k + 1, j] == 0)
                        {
                            // Move right
                            grid[k + 1, j] = grid[k, j];
                            grid[k, j] = 0;
                            k++;
                            moved = true; // mark as moved
                        }

                        // check if the tile next to the right can be combined with
                        if (k < GridSize - 1 && !combinedThisMove[k + 1, j] && grid[k + 1, j] == grid[k, j])
                        {
                            // Combine
                            grid[k + 1, j] *= 2;
                            score += grid[k + 1, j];
                            grid[k, j] = 0;
                            combinedThisMove[k + 1, j] = true; // Mark as combined for this move
                            moved = true; // mark as moved
                        }
                    }
                }
            }

            return moved; // return whether the movement occured or not
        }






        // Generate numbers and update the table
        private void AddAndUpdate()
        {
            int numbersToGenerate = (UpdateCounter == 0) ? 2 : 1;
            int iterations = 0;

            // Find an empty cell to add a new number
            for (int k = 0; k < numbersToGenerate; k++)
            {
                int availableCells = GetAvailableCellCount();

                if (availableCells == 0)
                {
                    // No available cells to generate a new number
                    return;
                }

                int randomCellIndex = random.Next(availableCells);
                int count = -1;

                for (int i = 0; i < GridSize; i++)
                {
                    for (int j = 0; j < GridSize; j++)
                    {
                        if (grid[i, j] == 0)
                        {
                            count++;

                            if (count == randomCellIndex)
                            {
                                // Generate a random number (2 or 4) and place it in the empty cell
                                int randomNumber = (random.Next(2) + 1) * 2; 
                                grid[i, j] = randomNumber;
                                iterations++;
                            }
                        }
                    }
                }

                if (iterations > 100)
                {
                    // Break the loop if too many iterations occur
                    return;
                }
            }

            panelGame.Invalidate();
            UpdateCounter++;
            lblScoreVal.Text = score.ToString();
        }

        private int GetAvailableCellCount()
        {
            int count = 0;

            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        count++;
                    }
                }
            }

            return count;
        }

        // method for drawing the grid
        private void DrawGrid(Graphics g)
        {
            Pen boldPen = new Pen(Color.LightGray, 2);
            Pen borderPen = new Pen(Color.LightGray, 5);

            // draw vertical lines
            for (int i = 1; i < GridSize; i++)
            {
                g.DrawLine(boldPen, i * CellSize, 0, i * CellSize, GridSize * CellSize);
            }

            // draw horizontal lines
            for (int j = 1; j < GridSize; j++)
            {
                g.DrawLine(boldPen, 0, j * CellSize, GridSize * CellSize, j * CellSize);
            }


            g.DrawRectangle(borderPen, 0, 0, GridSize * CellSize, GridSize * CellSize);
        }

        // method for drawing the cells
        private void DrawCells(Graphics g)
        {
            // draw content of each cell
            for (int i = 0; i < GridSize; i++)
            {
                for (int j = 0; j < GridSize; j++)
                {
                    int cellValue = grid[i, j];

                    // Determine the color for the cell background
                    Color cellBackgroundColor = (cellValue == 0) ? Color.FromArgb(245, 245, 245) : GetColorForNumber(cellValue);

                    // fill the background with a color
                    Brush cellBackgroundBrush = new SolidBrush(cellBackgroundColor);

                    // define the coordinates and size of a cell
                    int x = i * CellSize + 1; // +1 to account for the grid line
                    int y = j * CellSize + 1; // +1 to account for the grid line
                    int width = CellSize - 2; // -2 to account for the grid line on both sides
                    int height = CellSize - 2; // -2 to account for the grid line on both sides

                    // draw a cell with the background color
                    g.FillRectangle(cellBackgroundBrush, x, y, width, height);

                    // draw the text in the center of the cell
                    if (cellValue != 0)
                    {
                        DrawCell(g, i * CellSize, j * CellSize, cellValue);
                    }
                }
            }
        }

        // method for drawing the tile
        private void DrawCell(Graphics g, int x, int y, int value)
        {
            // logic to attribute different color for different value
            Color cellColor = GetColorForNumber(value);

            // fill the cell depending on the value
            Brush brush = new SolidBrush(GetColorForNumber(value));
            g.FillRectangle(brush, x, y, CellSize, CellSize);

            // Dessiner le texte au centre de la cellule
            string text = value.ToString();
            Font font = new Font("Comic Sans MS", 30, FontStyle.Bold);
            SizeF textSize = g.MeasureString(text, font);
            float textX = x + (CellSize - textSize.Width) / 2;
            float textY = y + (CellSize - textSize.Height) / 2;
            g.DrawString(text, font, Brushes.Black, textX, textY);
        }
        private Color GetColorForNumber(int number)
        {
            // define a color for each number
            switch (number)
            {
                case 0: return Color.Red;
                case 2: return Color.FromArgb(238, 228, 218); 
                case 4: return Color.FromArgb(237, 224, 200); 
                case 8: return Color.FromArgb(242, 177, 121); 
                case 16: return Color.FromArgb(245, 149, 99); 
                case 32: return Color.FromArgb(246, 124, 95); 
                case 64: return Color.FromArgb(246, 94, 59);  
                case 128: return Color.FromArgb(237, 207, 114); 
                case 256: return Color.FromArgb(237, 204, 97);  
                case 512: return Color.FromArgb(237, 200, 80);  
                case 1024: return Color.FromArgb(237, 197, 63); 
                case 2048: return Color.FromArgb(237, 194, 46); 
                default: return Color.Gray; // color by default
            }
        }

        // logic for drawing the table and its content
        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White); // erase the draw zone

            // draw the table
            DrawGrid(g);

            // draw the content of each cell
            DrawCells(g);
        }

        private bool hasWon = false; // declare the game as not win yet

        // method for conditions of end of the game
        private bool GameEnd()
        {
            // Check if the user has already won
            if (hasWon)
            {
                // If yes, check for a loss
                if (!HasEmptyCells() && !CanCombineCells())
                {
                    // show the loss message 
                    lblLost.Visible = true;
                    btnNewGame.Visible = true;
                    btnExit.Visible = true;
                    pbBG.Visible = true;

                    // new game button
                    btnNewGame.Click += (sender, e) =>
                    {
                        // Restart the game
                        RestartGame();

                        // hide the message
                        lblLost.Visible = false;
                        btnNewGame.Visible = false;
                        btnExit.Visible = false;
                        pbBG.Visible = false;
                    };

                    // exit button
                    btnExit.Click += (sender, e) =>
                    {
                        // close the program without restarting
                        this.Close();
                    };

                    return false; // The game continues
                }

                // If the user has won, return false to continue the game without checking for 2048
                return false;
            }

            // Check for a win
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // a tile in the grid equals 2048
                    if (grid[i, j] == 2048)
                    {
                        // pause the game
                        isGamePaused = true;

                        // hide show the win message
                        pbBG.Visible = true;
                        lblWon.Visible = true;
                        btnNewGame.Visible = true;
                        btnContinue.Visible = true;
                        btnExit.Visible = true;
                        picFirework.Visible = true;

                        // new game button
                        btnNewGame.Click += (sender, e) =>
                        {
                            // Restart the game
                            RestartGame();

                            // hide the win message
                            lblLost.Visible = false;
                            btnNewGame.Visible = false;
                            btnExit.Visible = false;
                            pbBG.Visible = false;
                        };

                        // exit button
                        btnExit.Click += (sender, e) =>
                        {
                            // Close the form without restarting
                            this.Close();
                        };

                        btnContinue.Click += (sender, e) =>
                        {
                            // the game is declared as won
                            hasWon = true;

                            // hide the win message
                            lblWon.Visible = false;
                            btnNewGame.Visible = false;
                            btnExit.Visible = false;
                            btnContinue.Visible = false;
                            pbBG.Visible = false;
                            picFirework.Visible = false;

                            isGamePaused = false;
                        };
                    }
                }
            }

            // Check for a loss
            if (!HasEmptyCells() && !CanCombineCells())
            {
                // show the loss message
                lblLost.Visible = true;
                btnNewGame.Visible = true;
                btnExit.Visible = true;
                pbBG.Visible = true;

                // Display a message and ask the user if they want to restart
                btnNewGame.Click += (sender, e) =>
                {
                    // Restart the game
                    RestartGame();

                    // hide the loss message
                    lblLost.Visible = false;
                    btnNewGame.Visible = false;
                    btnExit.Visible = false;
                    pbBG.Visible = false;

                    isGamePaused = false;
                };

                // exit button
                btnExit.Click += (sender, e) =>
                {
                    // Close the form without restarting
                    this.Close();
                };

                return false; // The game continues
            }

            return false; // The game continues
        }

        // method for restarting the game
        private void RestartGame()
        {
            // Clear the existing table
            grid = new int[GridSize, GridSize];

            // Reset the game state and start a new game
            InitializeGame();
            lblLost.Visible = false;
            score = 0;

            panelGame.Invalidate();

            // Introduce a delay of 500 ms
            System.Threading.Thread.Sleep(500);

            // Reset the update counter
            UpdateCounter = 0;

            // Update the score label
            lblScore.Text = "Score: " + score.ToString();

            // Restart the application
            Application.Restart();
            Environment.Exit(0);
        }

        // method for checking if there's empty cells
        private bool HasEmptyCells()
        {
            // Check for empty cells by iterating through each cell
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] == 0)
                    {
                        return true; // There is an empty cell
                    }
                }
            }

            return false; // No empty cells
        }

        // method for checking if fusion is possible
        private bool CanCombineCells()
        {
            // Check for adjacent cells with the same value
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (grid[i, j] == grid[i, j + 1] || grid[j, i] == grid[j + 1, i])
                    {
                        return true; // There are adjacent cells with the same value
                    }
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (grid[i, j] == grid[i + 1, j])
                    {
                        return true; // There are adjacent cells with the same value
                    }
                }
            }

            return false; // No adjacent cells with the same value
        }


        private void lbl2048_Click(object sender, EventArgs e)
        {

        }

        private void lblRestartWon_Click(object sender, EventArgs e)
        {

        }

        // button Rules
        private void btnRules_Click(object sender, EventArgs e)
        {

            // the rule menu appears
            pbFull.Visible = true;
            lblRulesTitle.Visible = true;
            lblRules.Visible = true;
            btnOkRules.Visible = true;
            isGamePaused=true;      // pause the game


            lblRules.Text=     "1. Use arrow keys to move the tiles.\n" + "\n" +
                               "2. Tiles with the same number merge \n    when they touch.\n" + "\n" +
                               "3. Keep merging tiles to reach 2048!\n";
            

            
        }
        // button for hidding the rules
        private void btnOkRules_Click(object sender, EventArgs e)
        {
            // hide rules menu
            pbFull.Visible = false;
            lblRulesTitle.Visible = false;
            lblRules.Visible = false;
            btnOkRules.Visible = false;
            isGamePaused = false;       // game is not paused
        }

        // button for restarting the game
        private void btnRestart_Click(object sender, EventArgs e)
        {
            // restart menu appears
            pbFull.Visible= true;
            lblRestart.Visible = true;
            btnYesRestart.Visible = true;
            btnNoRestart.Visible = true;
            isGamePaused = true;        // game is paused
        }

        // "yes" button for restart
        private void btnYesRestart_Click(object sender, EventArgs e)
        {
            RestartGame();              // the program restarts
        }

        private void btnNoRestart_Click(object sender, EventArgs e)
        {
            // the restart menu disappears
            pbFull.Visible = false;
            lblRestart.Visible = false;
            btnYesRestart.Visible = false;
            btnNoRestart.Visible = false;
            isGamePaused = false;       // the game is not paused
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // pause button
        private void btnPause_Click(object sender, EventArgs e)
        {
            // pause menu appears
            pbBG.Visible = true;
            lblPause.Visible = true;
            btnResume.Visible = true;
            isGamePaused = true;        // game is paused
        }

        private void btnResume_Click(object sender, EventArgs e)
        {
            // the pause menu disappears
            pbBG.Visible = false;
            lblPause.Visible = false;
            btnResume.Visible = false;

            isGamePaused = false; // game not paused
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        

        
    }
}