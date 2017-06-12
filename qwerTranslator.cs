using System;
using System.Text;
using System.IO;
using System.Linq;

namespace qwerTranslator
{
    public class Program
	{
		public static void Main(string[] args)
		{
			char[] qwertyKeyboardForEncoding = {'1', '2', '3', '4', '5', '6', '7', '8', '9', '0', 'q', 'w', 'e', 'r', 't', 'y', 'u', 'i', 'o', 'p', 'a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'z', 'x', 'c', 'v', 'b', 'n', 'm', '1', ')', 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L', 'Z', 'X', 'C', 'V', 'B', 'N', 'M', '1'};
			char[] qwertyKeyboardForDecoding = {'m', 'n', 'b', 'v', 'c', 'x', 'z', 'l', 'k', 'j', 'h', 'g', 'f', 'd', 's', 'a', 'p', 'o', 'i', 'u', 'y', 't', 'r', 'e', 'w', 'q', '0', '9', '8', '7', '6', '5', '4', '3', '2', '1', 'm', 'M', 'N', 'B', 'V', 'C', 'X', 'Z', 'L', 'K', 'J', 'H', 'G', 'F', 'D', 'S', 'A', 'P', 'O', 'I', 'U', 'Y', 'T', 'R', 'E', 'W', 'Q', '0', '!', 'M'};
			int number;
			while (true){
				Console.WriteLine("Press E for encoder, press D for decoder, press Q to quit, press H for help.");
				Console.Write(">>");
				char[] choices = {'E', 'e', 'D', 'd', 'Q', 'q', 'H', 'h'};
				char choice = Console.ReadKey().KeyChar;
				Console.WriteLine();
				if(!choices.Contains(choice)) Console.WriteLine("{0} is not a valid choice.", choice);
				if(choice == 'E' || choice == 'e'){
					Console.WriteLine("Type you want to encode");
					char[] charactersToBeEncoded = Console.ReadLine().ToCharArray();
					int length = charactersToBeEncoded.Length;
					int i = 0;
					char[] encodedCharacters = new char[length];
					foreach(char cTBE in charactersToBeEncoded){
						if (cTBE == ' ') encodedCharacters[i] = cTBE;
						if (cTBE != ' '){
						int results = Array.IndexOf(qwertyKeyboardForEncoding, cTBE);
						results++;
						encodedCharacters[i] = qwertyKeyboardForEncoding[results];
						}
						i++;
					}
					foreach (char c in encodedCharacters) Console.Write(c);
					Console.WriteLine();
				}
				if(choice == 'D' || choice == 'd'){
					Console.WriteLine("Type what you want to decode");
					char[] charactersToBeDecoded = Console.ReadLine().ToCharArray();
					int length = charactersToBeDecoded.Length;
					int i = 0;
					char[] decodedCharacters = new char[length];
					foreach(char cTBD in charactersToBeDecoded){
						if (cTBD == ' ') decodedCharacters[i] = cTBD;
						if (cTBD != ' '){
						int results = Array.IndexOf(qwertyKeyboardForDecoding, cTBD);
						results++;
						decodedCharacters[i] = qwertyKeyboardForDecoding[results];
						}
						i++;
					}
					foreach (char c in decodedCharacters) Console.Write(c);
					Console.WriteLine();
				}
				if(choice == 'H' || choice == 'h') Console.WriteLine("This program is a translator for move-over-to-the-right-one-on-the-keyboard-languange, I.E. a -> s, 0 -> q, U -> I \nThis incoder/decoder only supports numbers, english letters and capital letters and will translate ) to Q or 0 to q");
				if(choice == 'Q' || choice == 'q') Environment.Exit(0);
			}
			Console.ReadKey();
		}
	}
}