Name of the App: Sudoku Solver Playground by Firas GHRIBI
Description : A playground App that demonstrate how the algorithm can solve a sudoku puzzle.
-------------------------------------

WARNING :
 
BUILT USING MACBOOK PRO 16" , M1 MAX WITH ARM 64 architecture, MACOS SONOMA 14.1.1
VM Software : Parallel Desktop Software
VM OS : Windows 11 Professionnel version 23H2, ARM Processor.

-------------------------------------

Folder Structure:
- exec: Contains the executable file of the app.
- source: Contains the source code of the app.
- playground: Contains different Sudoku difficulties and scenarios ready for testing and playing with.

Input Format:
- 9x9 matrix as referred to in the text file: please see the file => /playground/playground.txt
- The user chooses to paste the Sudoku in the format as in the file : please see the file => /playground/playground.txt
- The user can also import directly the .txt file that contains the sudoku.

Testing : 
- The app run various test to check the validity of the sudoku.
	+ To test unsolvable sudoku puzzle : refer to ( /playground/unsolvable.txt )
	+ To test length error test : refer to ( /playground/lengthError.txt )
	+ To test invalid characters error test : refer to ( /playground/charError.txt )


Messages : 
- The app will display a message in various scenarios : in failure or success.

Output : 
- The app will display the solved sudoku in output box.

Saving : 
- The user can choose the export the solved sudoku in .txt format.


--------------------------------------
Valid Sudoku Matrix puzzle : 

Number 0 is the number that should be filled and found by the algorithm.
Numbers from 1 to 9 are considered valid numbers.

Example of Sudoku Puzzle:


- Valid format for a sudoku to be solved.

0 0 0 0 4 0 0 0 0
9 0 0 0 2 6 8 0 1
0 0 0 8 9 0 0 0 0
7 0 2 9 0 3 5 0 0
0 0 1 6 8 0 0 4 2 
0 0 0 0 0 0 1 0 0
2 0 0 4 7 9 0 0 0
8 5 0 0 0 0 7 0 4
0 0 6 5 0 0 2 0 0

- The same sudoku above after it was solved.

1 8 7 3 4 5 9 2 6
9 3 4 7 2 6 8 5 1
6 2 5 8 9 1 4 7 3
7 4 2 9 1 3 5 6 8
5 9 1 6 8 7 3 4 2
3 6 8 2 5 4 1 9 7
2 1 3 4 7 9 6 8 5
8 5 9 1 6 2 7 3 4
4 7 6 5 3 8 2 1 9


--------------------------------------

How to use ? :

The app has a unique and user friendly UI. it's very easy to manipulate and to keep focus on both the input and the output that's why it's called playground.
The user can at the same time try different combination for fun and test various combinations and scenarios by himself without loosing focus on the input, output and the message success or failure.

To use the app, you need to follow these 3 easy steps :

1. First, start by importing the sudoku in .txt format by clicking on import button or copy/paste the sudoku in the input box. 
( you can refer to the folder /playground ) and choose a sudoku to test.

2. Click on Solve button.

3. Save the solved sudoku in the output box by clicking on save button.

--------------------------------------
NOTE : The UX/UI , code can be optimized in the future.
--------------------------------------
Have fun.

