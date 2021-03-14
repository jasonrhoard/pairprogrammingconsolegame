using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PairProjrcts
{
	class Program
	{


		int[] grid = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
		int error = 0;
		int GetMove()
		{
			Console.WriteLine("enter a number");
			int mv = Convert.ToInt32(Console.ReadLine());
			mv = mv - 1;    // offset grid relative to zero
			error = 0;
			if (mv == -1)
			{
				return (99);
			} // if quit
			else if (mv < -1 || mv > 8)
			{
				Console.WriteLine("You moved to: ");
				Console.WriteLine(mv + 1);
				Console.WriteLine("Move is out of range");
				Console.ReadLine();
				error = 1;
			} // if move out of range
			else if (grid[mv] == 0)
			{
				grid[mv] = 1;
			} // if grid[mv] == 0
			else
			{
				Console.WriteLine("You moved to: ");
				Console.WriteLine(mv + 1);
				Console.WriteLine("Sorry, this location is already taken!");
				Console.ReadLine();
				error = 1;
			} // else not empty square
			return (0);    // continue playing
		} // getMove
		void genMove()
		{
			Random rnd = new Random();
			int mv;
			double num;
			int goodMove = 0;
			while (error == 0 && goodMove == 0)
			{

				num = rnd.NextDouble() * 9.0;

				mv = (int)num;
				if (grid[mv] == 0)
				{
					grid[mv] = 2;
					goodMove = 1;
				} // if grid[mv] == 0
			} // while error == 0 && goodMove == 0
		} // genMove
		int evalGrid()
		{
			int rslt;
			rslt = 0;


			if (grid[0] == 1 && grid[1] == 1 && grid[2] == 1)
			{
				rslt = 1;
			} /* opponent won on row 1 */
			else if (grid[3] == 1 && grid[4] == 1 && grid[5] == 1)
			{
				rslt = 1;
			} /* opponent won on row 2 */
			else if (grid[6] == 1 && grid[7] == 1 && grid[8] == 1)
			{
				rslt = 1;
			} /* opponent won on row 3 */
			else if (grid[0] == 1 && grid[3] == 1 && grid[6] == 1)
			{
				rslt = 1;
			} /* opponent won on col 1 */
			else if (grid[1] == 1 && grid[4] == 1 && grid[7] == 1)
			{
				rslt = 1;
			} /* opponent won on col 2 */
			else if (grid[2] == 1 && grid[5] == 1 && grid[8] == 1)
			{
				rslt = 1;
			} /* opponent won on col 3 */
			else if (grid[0] == 1 && grid[4] == 1 && grid[8] == 1)
			{
				rslt = 1;
			} /* opponent won on right diagonal */
			else if (grid[2] == 1 && grid[4] == 1 && grid[6] == 1)
			{
				rslt = 1;
			} /* opponent won on left diagonal */
			//******************************************************
			// now evaluate my moves
			//******************************************************
			else if (grid[0] == 2 && grid[1] == 2 && grid[2] == 2)
			{
				rslt = 2;
			} /* opponent won on row 1 */
			else if (grid[3] == 2 && grid[4] == 2 && grid[5] == 2)
			{
				rslt = 2;
			} /* opponent won on row 2 */
			else if (grid[6] == 2 && grid[7] == 2 && grid[8] == 2)
			{
				rslt = 2;
			} /* opponent won on row 3 */
			else if (grid[0] == 2 && grid[3] == 2 && grid[6] == 2)
			{
				rslt = 2;
			} /* opponent won on col 1 */
			else if (grid[1] == 2 && grid[4] == 2 && grid[7] == 2)
			{
				rslt = 2;
			} /* opponent won on col 2 */
			else if (grid[2] == 2 && grid[5] == 2 && grid[8] == 2)
			{
				rslt = 2;
			} /* opponent won on col 3 */
			else if (grid[0] == 2 && grid[4] == 2 && grid[8] == 2)
			{
				rslt = 2;
			} /* opponent won on right diagonal */
			else if (grid[2] == 2 && grid[4] == 2 && grid[6] == 2)
			{
				rslt = 2;
			}
			/* opponent won on left diagonal */
			return (rslt);
			Console.ReadLine();
		} // evalGrid 
		int countGrid()
		{
			int count;
			int i;
			count = 0;
			i = 0;
			while (i < 9)
			{
				if (grid[i] != 0)
				{
					count = count + 1;
				} // if grid[i] != 0
				i = i + 1;
			} // while count < 9
			return (count);
		} // countGrid
		void putGrid()
		{
			int i;
			i = 0;
			while (i < 9)
			{
				if (grid[i] == 0)
				{
					Console.Write("- ");
				} // if grid[i] == 0
				if (grid[i] == 1)
				{
					Console.Write("X ");
				} // if grid[i] == 1
				if (grid[i] == 2)
				{
					Console.Write("O ");
				} // if grid[i] == 2
				i = i + 1;
				if (i == 3 || i == 6 || i == 9)
				{
					Console.WriteLine();
				} // if i == 3 || i == 6 || i == 9
			} // while i < 9
			Console.WriteLine();
		} // putGrid

		
	
		
		//---------------------------------------------------------------///

		public static void gameTitle()
		{
			Console.WriteLine("Welcome To Our World");
			Console.WriteLine("Press Enter To Get Your Credentials.");

			Console.ReadLine();
			Console.Clear();
			Credentials();
			



		}
		public static void Credentials()
		{
			string FirstName = "Admin";
			string PassWord = "Admin";

			Console.WriteLine("Enter Your first");
			FirstName = Console.ReadLine();

			Console.WriteLine("Enter Your PassWord");
			PassWord = Console.ReadLine();
			Console.Clear();

			if (FirstName == "Admin" && PassWord == "Admin")
			{
				First();
			}
			else if (FirstName != "Admin" && PassWord != "Admin")
			{
				Console.WriteLine("Please Enter the Valid Credetials");

				Console.WriteLine("Enter Your first");
				FirstName = Console.ReadLine();
				Console.WriteLine("Enter Your PassWord");
				PassWord = Console.ReadLine();
				Console.Clear();
				Help();
			}
			else if (FirstName == "Admin" && PassWord != "Admin")
			{
				Console.WriteLine("Please Enter the Valid Password");

				Console.WriteLine("Enter Your first");
				FirstName = Console.ReadLine();
				Console.WriteLine("Enter Your PassWord");
				PassWord = Console.ReadLine();
				Console.Clear();
				Help();
			}
			else if (FirstName != "Admin" && PassWord == "Admin")
			{
				Console.WriteLine("Please Enter the Valid FirstName");

				Console.WriteLine("Enter Your first");
				FirstName = Console.ReadLine();
				Console.WriteLine("Enter Your PassWord");
				PassWord = Console.ReadLine();
				Console.Clear();
				Help();
			}
			else
			{
				Help();
			}





		}

		public static void First()
		{
			string choice;

			Console.WriteLine("We recommend that you stay focus as you playing Please read before you type");
			Console.WriteLine("Please the instructions to be succesful ");
			Console.WriteLine("---------------------------------Please Select A Game To Start--------------------------------------------------");
			Console.WriteLine("1.unscramble words");
			Console.WriteLine("2. Tic Toc Toe");
			choice = Console.ReadLine().ToLower();
			Console.Clear();

			switch (choice)
			{
				case "1":
				case "words":
				case "unscramble":
					{
						JasonH();
						break;
					}

				case "2":
				case "Tic":
				case "Toc":
				case "Toe":
					{
						ArnoldM();
						break;
					}

				default:
					{

						Console.WriteLine("Please Select Valid Option");
						Console.WriteLine("press enter to continue.");
						Console.ReadLine();
						First();
						break;
					}
			}



		}
		public static void JasonH()
		{
			//Method that stars the game

			//Game introduction
			Console.WriteLine("Welcome to Order in the Court!\n" +
					"This is a game where you will unscramble words.\n" +
					"If you successfully unscramble all 13 words you will unlock the bonus game!\n" +
					"We will start with the one letter words:\n" +
					"\n" +
					"The first one letter word is: I \n" +
					"Please type your guess and press the enter key:");
			//string firstWord = I;
			string input = Console.ReadLine();
			while (input != "I")
			{
				Console.WriteLine("Please try again! Since it is a one letter word, the correct answer is the same letter: I \n" +
					"(HINT: Letters are case sensitive)");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"Now onto the next one letter word: a ");
			input = Console.ReadLine();
			while (input != "a")
			{
				Console.WriteLine("Please try again! Since it is a one letter word, the correct answer is the same letter: a");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"Now onto a two letter word: hO ");
			input = Console.ReadLine();
			while (input != "Oh")
			{
				Console.WriteLine("Please try again! Don't forget the letters are case sensitive: ho");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"Now onto a three letter word: nad ");
			input = Console.ReadLine();
			while (input != "and")
			{
				Console.WriteLine("Please try again: nad");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
			   "Now onto a three letter word: het ");
			input = Console.ReadLine();
			while (input != "the")
			{
				Console.WriteLine("Please try again! Don't forget the letters are case sensitive: het");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"Now for some four letter words. The first one is : ybab ");
			input = Console.ReadLine();
			while (input != "baby")
			{
				Console.WriteLine("Please try again: ybab");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"The next four letter word is : areh ");
			input = Console.ReadLine();
			while (input != "hear")
			{
				Console.WriteLine("Please try again: areh ");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"The last four letter word is : gegs  ");
			input = Console.ReadLine();
			while (input != "eggs")
			{
				Console.WriteLine("Please try again: gegs ");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"The first five letter word is : lubes  ");
			input = Console.ReadLine();
			while (input != "blues")
			{
				Console.WriteLine("Please try again: lubes ");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"The next five letter word is : aadls  ");
			input = Console.ReadLine();
			while (input != "salad")
			{
				Console.WriteLine("Please try again: aadls ");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"Now let's try a six letter word: edosst");
			input = Console.ReadLine();
			while (input != "tossed")
			{
				Console.WriteLine("Please try again: edosst");
				input = Console.ReadLine();
			}
			Console.WriteLine("Correct!\n" +
				"Now this is a six letter word with a special character: acilln'");
			input = Console.ReadLine();
			while (input != "callin'")
			{
				Console.WriteLine("Please try again: acilln'");
				input = Console.ReadLine();
			}
			Console.WriteLine("You got it! I hope that special character did not confuse you!\n" +
				"The last word has NINE LETTERS: delbmarcs ");
			input = Console.ReadLine();
			while (input != "scrambled")
			{
				Console.WriteLine("Please try again: delbmarcs ");
				input = Console.ReadLine();
			}
			Console.WriteLine("You got the last word!\n" +
				"BONUS ROUND!\n" +
				"Can you unscramble the words to write the opening line of a sit com televsion show theme song?\n" +
				"I  a  Oh  the  and  baby  hear  eggs  blues  salad  callin'  tossed  scrambled");
			input = Console.ReadLine();
			while (input != "Oh baby I hear the blues a callin' tossed salad and scrambled eggs")
			{
				Console.WriteLine(" \n" + "Remember that all the words are case sensitive. Here's a HINT:\n" +
					"Frasier\n" +
					"I  a  Oh  the  and  baby  hear  eggs  blue  salad  callin'  tossed  scrambled");
				input = Console.ReadLine();
			}
			youWon();
		}
		public static void ArnoldM()
		{
			Console.WriteLine("Welcome to Tic-Tac-Toe");
			Console.WriteLine("Legal moves are from 1 to 9");
			Console.WriteLine("To quit, enter move 0");
			Console.WriteLine("Good luck");
			Console.ReadLine();
			Console.Clear();
			
			
			Program g = new Program();
			int rslt = 0;
			while (rslt == 0)
			{
				int count = 0;
				int moveResult = 0;
				moveResult = g.GetMove();
				if (moveResult == 99)
				{
					break;
				}
				rslt = g.evalGrid();
				if (rslt == 1)
				{
					youWon();
					//Console.WriteLine("Congratulations, you won!");
					Console.ReadLine();

				}
				count = g.countGrid();
				if (count >= 9)
				{
					Console.WriteLine("Game is over");
					Console.ReadLine();
					rslt = 1;

				}
				else if (rslt == 0)
				{
					g.genMove();
				}
				if (rslt == 0)
				{
					rslt = g.evalGrid();
				}
				if (rslt == 2)
				{
					Console.Write("Computer won!");
					Console.ReadLine();
				}
				g.putGrid();
			}
		}
		public static void youWon()
		{
			Console.Clear();
			Console.WriteLine(" \n" +
				"You did it! Thanks for playing!\n" +
				"Press the Enter key to play the next game");
			Console.ReadKey();
			Console.Clear();
			gameTitle();
		}
		public static void gameofOver()
		{
			Console.Clear();
			Console.WriteLine("Better luck next time.");
			Console.WriteLine("Press enter to  try again");
			Console.ReadLine();
			Console.Clear();
			gameTitle();


		}
		public static void Help()
		{
			
			Console.WriteLine(" We are happy to have you back  to Arnold And Jason world you must have get the wrong credentials that ok \n" +
			"There are Two different game you will have the option to select\n one of you preference to start the game\n GoodLuck and Enjoy the game\n" +
			"You will be Asked to enter valid credentials to go to the next process\n Please use 'Admin' in both firstName and password");
			Console.WriteLine("-------------Seclect A Game Number To Start --------------------");
			Console.WriteLine("Please Enter To Continue!");
			Console.ReadLine();
			Credentials();
		}






		static void Main(string[] args)
        {

			gameTitle();


		}  
    } 
}