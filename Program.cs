using System.Text;

namespace NumberSystemCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.Write("Enter the number to convert: ");
                int numberToConvert = int.Parse(Console.ReadLine());

                Console.Write("Enter the target number system: ");
                int targetBase = int.Parse(Console.ReadLine());

                string result = Converter(numberToConvert, targetBase);
                Console.WriteLine($"Converted number: {result}");

            ///Ez Way
            //static string Converter(int number, int targetBase)
            //{
            //    if (targetBase < 2 || targetBase > 36)
            //    {
            //        throw new ArgumentException("Invalid target base");
            //    }
            //    return Convert.ToString(number, targetBase);
            //} 


            ///Harder way
            static string Converter(int decimalNumber, int targetBase)
            {
                if (targetBase < 2 || targetBase > 36)
                {
                    throw new ArgumentException("Invalid target base");
                }

                StringBuilder result = new StringBuilder(); //za da si spestq pisane

                while (decimalNumber > 0)
                {
                    int remainder = decimalNumber % targetBase;
                    char digit;

                    switch (remainder)
                    {
                        case 0:
                            digit = '0';
                            break;
                        case 1:
                            digit = '1';
                            break;
                        case 2:
                            digit = '2';
                            break;
                        case 3:
                            digit = '3';
                            break;
                        case 4:
                            digit = '4';
                            break;
                        case 5:
                            digit = '5';
                            break;
                        case 6:
                            digit = '6';
                            break;
                        case 7:
                            digit = '7';
                            break;
                        case 8:
                            digit = '8';
                            break;
                        case 9:
                            digit = '9';
                            break;
                        default:
                            digit = (char)('A' + remainder - 10); //dobavqme ostatuka(reminder) - 10, kum A, zashoto tq e purvata bukva ot azbukata koqto se izpolzva za broini sistemi nad 9.
                            break;                                //sledovatelno ako broinata sistema e nad 9 programata shte pochne da izpolzva bukvi ot A do Z.
                    }

                    result.Insert(0, digit); //za da se doavbvqt cifrite v pravilniq red dokato se convertirat
                    decimalNumber /= targetBase;
                }

                return result.ToString(); //convertira chisloto ot result kum string i go dobavq kum string buildera koito na svoq strana biva izpolzvan kato output-a v program.
            }

        }
    }
}