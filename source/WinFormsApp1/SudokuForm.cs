namespace WinFormsApp1
{
    public partial class SudokuForm : Form
    {
        public SudokuForm()
        {
            InitializeComponent();
            label3.Text = "Click on import to load your file or paste your sudoku in the input box, then click on solve.";
            inputRichTextBox.TextChanged += InputRichTextBox_TextChanged;
            outputRichTextBox.TextChanged += OutputRichTextBox_TextChanged;
        }

        private void ImportButton_Click(object sender, EventArgs e)
         // this triggers the saving logic and import dialog to appear.
        {
            Stream st;
            OpenFileDialog d1 = new OpenFileDialog();
            if (d1.ShowDialog() == DialogResult.OK)
            {
                if ((st = d1.OpenFile()) != null)
                {
                    string file = d1.FileName;
                    String str = File.ReadAllText(file);
                    inputRichTextBox.Text = str;
                }
            }

        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            // transforming the string to array.
            int[][] sudoku = DataFrame.TransformStringTo2dArray(inputRichTextBox.Text);

            // checking if the sudoku is null and is not valid, if both conditions met, it stops and return an error message.
            // if not, the execution will continue.
            if (sudoku == null || !SudokuSolver.IsValidSudoku(sudoku))
            {
                label3.ForeColor = Color.Red;
                label3.Text = "The sudoku is invalid. Please check your sudoku file/input box or retry with another.";
                outputRichTextBox.Text = "";
                return;
            }

            // solving the sudoku.
            int[][] solution = SudokuSolver.SolveSudoku(sudoku);

            // if the solution is different from null, means it was solved by the solver and a success message appears.
            // and transform from 2D Array to string to push it to the text box
            // else no solution found and return an error message.
            if (solution != null)
            {
                label3.ForeColor = Color.Green;
                label3.Text = "Sudoku has been successfuly solved. Please click on save button to export the solved sudoku.";
                outputRichTextBox.Text = DataFrame.Transform2dArrayToString(solution);
            }
            else
            {
                outputRichTextBox.Text = "";
                label3.ForeColor = Color.Red;
                label3.Text = "No solution has been found for the sudoku. Please try again with another sudoku puzzle.";
            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
            // this triggers the saving logic and saving modal ( pop-up box ) to appear.
            // let the user save the sudoku into .txt file.
        {

            string sudokuString = outputRichTextBox.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt";
            saveFileDialog.Title = "Save solved sudoku";
            saveFileDialog.FileName = "solved_sudoku"; 

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {

                string filePath = saveFileDialog.FileName;

                try
                {
                    System.IO.File.WriteAllText(filePath, sudokuString);
                    MessageBox.Show("The output file has been successfuly saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("There has been an error while saving the file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void InputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            solveButton.Enabled = !string.IsNullOrEmpty(inputRichTextBox.Text);
        }

        private void OutputRichTextBox_TextChanged(object sender, EventArgs e)
        {
            saveButton.Enabled = !string.IsNullOrEmpty(outputRichTextBox.Text);
        }

    }
}
