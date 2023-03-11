using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;

namespace Task._04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            /* verilmish ededin tek ve ya cut eded oldugunu yoxla */
            //l1:
            //    Console.Write("Eded daxil edin: ");
            //    int a;
            //    string number = Console.ReadLine();
            //    if (!int.TryParse(number, out a))
            //    {

            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (a % 2 == 0)
            //    {
            //        Console.WriteLine("cutdur");
            //    }
            //    else
            //        Console.WriteLine("tekdir");

            #endregion

            #region Task 2
            /* 2 eded verilib. Eger I eded II edede tam bolunurse o zaman cavabi cixart.
            Eks halda  "bolunmur" sozunu cap et */

            //    int b;
            //    int a;
            //    int sum;
            //l1:
            //    Console.Write("Eded daxil edin: ");
            //    if (!int.TryParse(Console.ReadLine(), out a))
            //    {

            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }
            //l2:
            //    if (!int.TryParse(Console.ReadLine(), out b))
            //    {

            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l2;
            //    }
            //    if (a % b == 0)
            //    {
            //        sum = a / b;
            //        Console.WriteLine(sum);
            //    }
            //    else
            //        Console.WriteLine("Bolunmur");
            #endregion

            #region Task 3
            /* Verilmish ededdin sonuncu reqemi 7 ile qurtarirmi? 
            Beli ve Xeyr cavabini yaz ekrana */

            //    int a;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out a))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }
            //    if (a % 10 == 7)
            //    {
            //        Console.WriteLine("beli");
            //    }
            //    else
            //        Console.WriteLine("xeyr");

            #endregion

            #region Task 4
            /* Verilmihs 2 reqemli ededin reqemleri eynidirmi?   
            Beli ve Xeyr cavabini yaz ekrana */

            //    int a;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out a))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (a > 10 && a < 99)
            //    {
            //        int number1 = a / 10;
            //        int number2 = a % 10;
            //        if (number1 == number2)
            //        {
            //            Console.WriteLine("Beli");
            //        }
            //        else
            //            Console.WriteLine("Xeyr");

            //    }
            #endregion

            #region Task 5
            /* Verilmish 2 reqemli ededdin reqemleri cemi cut ededdirse o zaman
            hemin 2 reqemli ededdin reqemlerinin hasilini ekrana cixart.*/

            //    int number;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    int sum = 0;
            //    int a1 = 0, a2 = 0;
            //    if (number < 10 || number >= 100)
            //    {
            //        Console.WriteLine("Iki reqemli eded daxil edin");
            //        goto l1;
            //    }
            //    else
            //    {
            //        a1 = number % 10;
            //        a2 = number / 10;
            //        sum = a1 + a2;
            //    }
            //    if (sum % 2 == 0)
            //    {
            //        int result = a1 * a2;
            //        Console.WriteLine(result);
            //    }
            //    else
            //    {
            //        Console.WriteLine("cut deyil");
            //    }
            #endregion

            #region Task 6

            /* Verilmish 3 reqemli ededdin I ve III reqemlerinin cemi II reqeme beraberdirmi?  
            Beli ve Xeyr cavabini yaz ekrana */

            //    int number;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (number < 100 || number >= 1000)
            //    {
            //        Console.WriteLine("Uc reqemli eded yazin");
            //        goto l1;

            //    }
            //    int sum = 0;
            //    int a1 = 0, a2 = 0, a3 = 0;
            //    if (true)
            //    {
            //        a1 = number / 100;
            //        a2 = (number / 10) % 10;
            //        a3 = number % 10;
            //        sum = a1 + a3;
            //        if (sum == a2)
            //        {
            //            Console.WriteLine("Beli");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Xeyr");
            //        }
            //    }
            #endregion

            #region Task 7

            /* Verilmish 3 reqemli ededdin reqemleri cemi I reqemin kvadratina beraberdirmi?  
            Beli ve Xeyr cavabini yaz ekrana */

            //    int number;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (number < 100 || number >= 1000)
            //    {
            //        Console.WriteLine("Uc reqemli eded yazin");
            //        goto l1;

            //    }
            //    int sum = 0;
            //    int a1 = 0, a2 = 0, a3 = 0;
            //    if (true)
            //    {
            //        a1 = number / 100;
            //        a2 = (number / 10) % 10;
            //        a3 = number % 10;
            //        sum = a1 + a2 + a3;

            //        if (sum == a1 * a1)
            //        {
            //            Console.WriteLine("Beli");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Xeyr");
            //        }
            //    }
            #endregion

            #region Task 8

            /* SWITCH operatoru ile yoxla.
               Verilmish ededdin sonuncu reqemi
               1 olarsa-"I gun" sozunu
               2 olarsa-"II gun" sozunu
               ...
               7 olarsa-"VI gun" sozunu yaz */


            //    int number;
            //l1:
            //    Console.Write("Include number: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Eded daxil edin");
            //        goto l1;
            //    }
            //    Console.WriteLine(number);
            //    int lastNumber = number % 10;

            //    switch (lastNumber)
            //    {
            //        case 1:
            //            Console.WriteLine("I gun");
            //            break;
            //        case 2:
            //            Console.WriteLine("II gun");
            //            break;
            //        case 3:
            //            Console.WriteLine("III gun");
            //            break;
            //        case 4:
            //            Console.WriteLine("IV gun");
            //            break;
            //        case 5:
            //            Console.WriteLine("V gun");
            //            break;
            //        case 6:
            //            Console.WriteLine("VI gun");
            //            break;
            //        case 7:
            //            Console.WriteLine("VII gun");
            //            break;

            //        default:
            //            Console.WriteLine("heftede 7 gun var");
            //            break;

            //    }
            #endregion

            #region Task 9

            /* SWITCH operatoru ile yoxla.
            Verilmish ededdin 1-ile 12 arasinda olugunu yoxla.(1 ve 12 ozude daxil olmaq sherti ile)
            Eger bu eded
            1 olarsa-"Yanvar" sozunu
            2 olarsa-"Fevral" sozunu
            ...
            12 olarsa-"Dekabr" sozunu yaz */


            //    int number;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (number < 1 || number >= 12)

            //    switch (number)
            //        {
            //            case 1:
            //                Console.WriteLine("Yanvar");
            //                break;
            //            case 2:
            //                Console.WriteLine("Fevral");
            //                break;
            //            case 3:
            //                Console.WriteLine("Mart");
            //                break;
            //            case 4:
            //                Console.WriteLine("Aprel");
            //                break;
            //            case 5:
            //                Console.WriteLine("May");
            //                break;
            //            case 6:
            //                Console.WriteLine("Iyun");
            //                break;
            //            case 7:
            //                Console.WriteLine("Iyul");
            //                break;
            //            case 8:
            //                Console.WriteLine("Avqust");
            //                break;
            //            case 9:
            //                Console.WriteLine("Sentyabr");
            //                break;
            //            case 10:
            //                Console.WriteLine("Oktyabr");
            //                break;
            //            case 11:
            //                Console.WriteLine("Noyabr");
            //                break;
            //            case 12:
            //                Console.WriteLine("Dekabr");
            //                break;

            //            default:
            //                Console.WriteLine("Ilde 12 ay var");
            //            goto l1;

            //     }
            #endregion

            #region Task 10

            /* IF operatoru ile yoxla.
            6 dene eded verilib.Bu ededlerden hansi en boyukdur.*/

            //int a = Help.IncludetInt();
            //int b = Help.IncludetInt();
            //int c = Help.IncludetInt();
            //int d = Help.IncludetInt();
            //int e = Help.IncludetInt();
            //int f = Help.IncludetInt();
            //int bigNumber = 0;
            //if (a > bigNumber)
            //    bigNumber = a;
            //if (b > bigNumber)
            //    bigNumber = b;
            //if (c > bigNumber)
            //    bigNumber = c;
            //if (d > bigNumber)
            //    bigNumber = d;
            //if (e > bigNumber)
            //    bigNumber = e;
            //if (f > bigNumber)
            //    bigNumber = f;
            //Console.WriteLine(bigNumber);

            #endregion

            #region Task 11

            /* Verilmish 6 reqemli ededin ilk 3 reqeminin cemi son 3 reqeminin cemine beraberdirse
            o zaman bu ededdin ilk 2 reqemini son 2 reqemine yapishdir.
            Neticenin ustune ortaya dushen 2 reqemini gel. */

            //int number = Help.IntAltireqemli();

            //Console.WriteLine(number);

            //int firstThree = (number / 100000) + ((number / 10000) % 10) + ((number / 1000) % 10);
            //int lastThree = ((number / 100) % 10) + ((number / 10) % 10) + (number % 10);

            //Console.WriteLine($"{firstThree}  {lastThree}");

            //if (firstThree == lastThree)
            //{
            //    int firstTwo = (number / 10000);
            //    int lastTwo = (number % 100);
            //    int middleTwo = (number / 100) % 100;
            //    int result = (firstTwo * 100 + lastTwo) + middleTwo;
            //    Console.WriteLine($"{firstTwo} * 100 + {lastTwo} + {middleTwo} = {result}");
            //}
            //else
            //{
            //    Console.WriteLine("Beraber deyil");
            //}

            #endregion

            #region Task 12

            /* Verilmihs 6 reqemli ededdin evveline ve axirina 8 artir.
            Alinan neticenin ilk 4 reqemi ile son 4 reqeminin yerini deyish
            Neticenin tek yerde dayanan reqemlerini 0 reqemi ile evez et. */

            //int number = Help.IntAltireqemli();
            //int newNumber = (number + 8000000) * 10 + 8;
            //Console.WriteLine(newNumber);
            //int firtFour = newNumber / 10000;
            //int lastFour = newNumber % 10000;
            //Console.WriteLine(firtFour);
            //Console.WriteLine(lastFour);
            //int result = lastFour * 10000 + firtFour;
            //Console.WriteLine(result);


            #endregion

            #region Task 13
            /* Verilmish 7 reqemli eded polindromdursa 
            o zaman onun daxilnde nece dene 0 reqemi oldugunu tap ? */

            //    int number;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (number < 1000000 || number >= 10000000)
            //    {
            //        Console.WriteLine("Yeddi reqemli eded yazin");
            //        goto l1;

            //    }
            //    Console.WriteLine(number);
            //    int a, b, c, a1, b1, c1, d;
            //    a = number / 1000000;
            //    b = number / 100000 % 10;
            //    c = number / 10000 % 10;
            //    d = number / 1000 % 10;
            //    a1 = number % 10;
            //    b1 = number % 100 / 10;
            //    c1 = number % 1000 / 100;

            //    if (a == a1 && b == b1 && c == c1)
            //    {
            //        Console.WriteLine("Bu eded POLINDROMDUR");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Bu eded polindrom DEYIL");
            //    }
            //    int abc = 0;

            //    if (a == 0)
            //    {
            //        abc++;
            //    }
            //    if (a1 == 0)
            //    {
            //        abc++;
            //    }

            //    if (b == 0)
            //    {
            //        abc++;
            //    }
            //    if (b1==0)
            //    {
            //        abc++;
            //    }

            //    if (c == 0)
            //    {
            //        abc++;
            //    }
            //    if (c1==0)
            //    {
            //        abc++;
            //    }

            //    if (d == 0)
            //    {
            //        abc++;

            //    }
            //    Console.WriteLine($"'0' reqwminin sayi - {abc}");
            #endregion

            #region Task 14
            /* Bir eded daxil et. Bu eded maksimum 8 reqemli ola biler
             * ( bu o demekdirki 1,2,3,4,5,6,7 reqemlide ola biler)
             Bu ededin evvelin 1 reqemini artir. */

            //    int number;
            //l1:
            //    Console.Write("Eded daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (number < 1 || number >= 100000000)
            //    {
            //        Console.WriteLine("Eded maksimum 8 reqemli olmalidir");
            //        goto l1;

            //    }

            //    int a = (int)Math.Pow(10, (int)Math.Log10(number));
            //    int firstNumber;
            //    int newNumber;
            //    if (true)
            //    {
            //        firstNumber = number / a;
            //        firstNumber++;
            //        newNumber = (number % a) + (firstNumber * a);
            //        Console.WriteLine(newNumber);
            //    }

            #endregion

            #region Task 15


            /* IF operatoru ile yoxla.
            Verilmish ededdin 1 - ile 365 arasinda olugunu yoxla(1 ve 365 ozude daxil olmaq sherti ile)
            Ededin ilin hansi ayina dushduyunu tap. Ve hemin ay ve gune uygun hansi burc oldugunu goster */

            //    int number;
            //l1:
            //    Console.Write("Ayin tarixini daxil edin: ");

            //    if (!int.TryParse(Console.ReadLine(), out number))
            //    {
            //        Console.WriteLine("Yalniz eded daxil edin");
            //        goto l1;
            //    }

            //    if (number < 1 || number >= 366)
            //    {
            //        Console.WriteLine("Eded minimum 1, maksimum 365 olmalidir");
            //        goto l1;

            //    }

            //    int ay = (number / 30) + 1;

            //    if (number <= 31)
            //    {
            //        Console.WriteLine("Yanvar ayi");
            //    }
            //    else if (number <= 59)
            //    {
            //        Console.WriteLine("Fevral ayi");
            //    }
            //    else if (number <= 90)
            //    {
            //        Console.WriteLine("Mart ayi");
            //    }
            //    else if (number <= 120)
            //    {
            //        Console.WriteLine("Aprel ayi");
            //    }
            //    else if (number <= 151)
            //    {
            //        Console.WriteLine("May ayi");
            //    }
            //    else if (number <= 181)
            //    {
            //        Console.WriteLine("Iyun ayi");
            //    }
            //    else if (number <= 212)
            //    {
            //        Console.WriteLine("Iyul ayi");
            //    }
            //    else if (number <= 243)
            //    {
            //        Console.WriteLine("Avqust ayi");
            //    }
            //    else if (number <= 273)
            //    {
            //        Console.WriteLine("Sentyabr ayi");
            //    }
            //    else if (number <= 304)
            //    {
            //        Console.WriteLine("Oktyabr ayi");
            //    }
            //    else if (number <= 334)
            //    {
            //        Console.WriteLine("Noyabr ayi");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Dekabr ayi");
            //    }

            //    if (ay == 1)
            //    {
            //        if (number <= 19)
            //            Console.WriteLine("Oxatan burcu");
            //        else
            //            Console.WriteLine("Oglaq burcu");
            //    }
            //    else if (ay == 2)
            //    {
            //        if (number <= 18) 
            //        Console.WriteLine("Oglaq burcu");
            //        else
            //            Console.WriteLine("Dolca burcu");
            //    }
            //    else if (ay == 3)
            //    {
            //        if(number <= 20)
            //            Console.WriteLine("Dolca burcu");
            //        else
            //            Console.WriteLine("Baliqlar burcu");
            //    }
            //    else if (ay == 4)
            //    {
            //        if (number <= 19)
            //            Console.WriteLine("Baliqlar burcu");
            //        else
            //            Console.WriteLine("Qoc burcu");
            //    }
            //    else if (ay == 5)
            //    {
            //        if (number <= 20)
            //            Console.WriteLine("Qoc burcu");
            //        else
            //            Console.WriteLine("Buga burcu");
            //    }
            //    else if (ay == 6)
            //    {
            //        if (number <= 20)
            //            Console.WriteLine("Buga burcu");
            //        else
            //            Console.WriteLine("Ekizler burcu");
            //    }
            //    else if (ay == 7)
            //    {
            //        if (number <= 22)
            //            Console.WriteLine("Ekizler burcu");
            //        else
            //            Console.WriteLine("Xerceng burcu");
            //    }
            //    else if (ay == 8)
            //    {
            //        if (number <= 22)
            //            Console.WriteLine("Xerceng burcu");
            //        else
            //            Console.WriteLine("Sir burcu");
            //    }
            //    else if (ay == 9)
            //    {
            //        if (number <= 22)
            //            Console.WriteLine("Sir burcu");
            //        else
            //            Console.WriteLine("Qiz burcu");
            //    }
            //    else if (ay == 10)
            //    {
            //        if (number <= 22)
            //            Console.WriteLine("Qiz burcu");
            //        else
            //            Console.WriteLine("Terezi burcu");
            //    }
            //    else if (ay == 11)
            //    {
            //        if (number <= 21)
            //            Console.WriteLine("Terezi burcu");
            //        else
            //            Console.WriteLine("Eqreb burcu");
            //    }
            //    else if (ay == 12)
            //    {
            //        if (number <= 21)
            //            Console.WriteLine("Eqreb burcu");
            //        else
            //            Console.WriteLine("Oxatan burcu");
            //    }

            #endregion
                       
        }
    }
}