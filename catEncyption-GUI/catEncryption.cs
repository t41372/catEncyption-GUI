using System;
using System.Text;


/* Cat Encryption Core (CLI)
 * 
 * Tim Chiu
 * 
 * 2020.9.22 version 1.0
 */

namespace catEncyption_GUI
{
    public class catEncryption
    {

        public static void originalMain(string[] args)
        {


            string Meow = "Øp";
            string[] languageList = { "Øp", "Meow" };

            bool programIsRunning = true;

            while (programIsRunning)
            {
                Console.WriteLine("Cat Encoder Core. \nType \"encode\" to encode text. \nType \"decode\" to decode text. " +
                    "\nType \"language\" to set the language\nType \"info\" to get more information about this program. " +
                    "\nType \"exit\" to exit the program");


                string sourceText = Console.ReadLine();

                switch (sourceText)
                {

                    case "encode":
                        Console.WriteLine("encode text\n\n==============\n" +
                            "Please enter the text you want to encrypt");
                        Console.WriteLine(encrypt(Console.ReadLine(), Meow));
                        break;

                    case "decode":
                        Console.WriteLine("decode text\n\n==============\n");
                        Console.WriteLine(decode(Console.ReadLine(), Meow));
                        break;

                    case "language":
                        Console.WriteLine("Set Language.\n\n==============\n" +
                            "Current Language is " + Meow);
                        Meow = languageList[setLanguageInMainFunction()];
                        break;

                    case "info":
                        Console.WriteLine("More Information\n==============");
                        Console.WriteLine("This program is written by Tim Chiu.\n" +
                            "This program can help you encrypt any text into the form of \"ØpØp!! Øp!!!!\" or \"MeowMeow!! Meow!!!!\"\n" +
                            "==============\n ");
                        break;

                    case "exit":
                        Console.WriteLine("exit");
                        programIsRunning = false;
                        break;

                    default:
                        Console.WriteLine("NO VALID INPUT");
                        break;

                }

            }//program running while loop is end here

        }//main function stop here

        public static string encrypt(string sourceText, string meow)//encrypt text into Meow Meow code
        {
            string result = "";
            string Meow = meow;

            //original text -> base64
            byte[] cacheFromSourceText = System.Text.Encoding.Default.GetBytes(sourceText);
            char[] textInBase64 = Convert.ToBase64String(cacheFromSourceText).ToCharArray();


            //base64 -> ascii -> binary
            int[] textInAscii = new int[textInBase64.Length];
            string[] textInBinary = new string[textInBase64.Length];

            for (int index = 0; index < textInAscii.Length; index++)
            {
                textInAscii[index] = Convert.ToInt32(textInBase64[index]);// base64 -> ascii
                textInBinary[index] = Convert.ToString(textInAscii[index], 2);// ascii -> binary
                result = result + " " + textInBinary[index].Replace("1", Meow).Replace("0", "!");// binary -> Meow
            }

            return result;
        }

        public static string decode(string sourceText, string meow)//decode Meow Meow code to original string
        {
            
            //Meow to binary
            string[] textInBinary = sourceText.Replace(meow, "1").Replace("!", "0").Split(' ');// from Meow -> binary array

            //remove every empty room. If there are any room contains nothing, it will throw error while decoding base64 -> string
            textInBinary = deleteEmptyRoomInArray(textInBinary);


            //binary to ascii
            int[] textInAscii = new int[textInBinary.Length];
            string textInBase64 = "";
            char cache;

            try
            {
                for (int indx = 0; indx < textInBinary.Length; indx++)
                {
                    textInAscii[indx] = Convert.ToInt32(textInBinary[indx], 2);// binary -> 32bit number (ascii)
                    cache = (char)textInAscii[indx];// 32bit number (ascii) -> base64 array
                    textInBase64 += cache;//base64 array -> base64 string
                }
            } catch
            {
                throw new Exception("Message");
                // the source text may contain some ilegal characters like **, goog that cannot be decoded
            }
            



            //base64 text -> original text -> return
            return Encoding.Default.GetString(Convert.FromBase64String(textInBase64));
        }


        //! TOOL FUNCTIONS-==============
        private static void printer(string whoAmI, Array source, bool space, bool showRoomNumber)//print an array
        {
            Console.Write("\n" + whoAmI + ": ");

            for (int indx = 0; indx < source.Length; indx++)
            {
                if (showRoomNumber) Console.Write("[" + indx + "]");
                Console.Write(source.GetValue(indx));
                if (space) Console.Write(" ");
            }
            Console.WriteLine();
        }

        private static string[] deleteEmptyRoomInArray(string[] sourceArray)//delete any empty room in an string array
        {
            int leftIndx = 0;
            for (int rightIndx = 0; leftIndx < sourceArray.Length && rightIndx < sourceArray.Length; leftIndx++, rightIndx++)
            {
                while (sourceArray[rightIndx].Length < 1)//if a room is empty
                {
                    rightIndx++;//ignore that room
                }
                sourceArray[leftIndx] = sourceArray[rightIndx];
            }
            //remove the empty rooms at the end of the array
            Array.Resize(ref sourceArray, leftIndx);

            return sourceArray;
        }

        private static int setLanguageInMainFunction()
        {
            Console.WriteLine("Do you want to use Øp or Meow?\n" +
                "Type \"1\" for \"Øp\"\n" +
                "Type \"2\" for \"Meow\" ");

            int result = 1;

            try
            {
                result = int.Parse(Console.ReadLine());
            }
            catch (FormatException e)
            {
                Console.WriteLine("INVALID INPUT");
                setLanguageInMainFunction();
            }

            if (result != 1 && result != 2)
            {
                Console.WriteLine("INVALID INPUT");
                setLanguageInMainFunction();
            }


            return result;

        }




    }
}
