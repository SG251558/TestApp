using System;

class Utils
{
    static string[] UnitPlace = {
        "", "one ", "two ", "three " , "four", "five ", "six ", "seven ", "eight ", "nine ",  "ten ",
        "eleven ", "twelve ", "thirteen ", "fourteen ", "fifteen ", "sixteen ", "seventeen ", "eighteen ",
        "nineteen "
    };

    static string[] TensPlace ={
        "", "" , "twenty " , "thirty " , "forty ", "fifty ", "sixty ", "seventy ", "eighty ", "ninty "
    };

    static string[] MorePlace ={
        "arab ","crore ", "lakh " , "thousand ", "hundred "
    };

    static string getString(int num, string place)
    {
        string returnStr = "";
        if (n > 19)
        {
            returnStr = TensPlace[num / 10] + " ";
            returnStr += UnitPlace[num % 10] + " ";
        }
        else
        {
            returnStr += UnitPlace[num] + " ";
        }
        if (num != 0)
        {
            returnStr += place;
        }
        return returnStr;
    }

    public static string NumberToString(long number)
    {
        string str = number.ToString();
        if (str.IndexOf('.') > 0)
        {
            return "please enter whole number";
        }
        string returnStr = "";

        returnStr += getString((int)number / 1000000000, MorePlace[0]);

        returnStr += getString((int)((number / 10000000) % 100), MorePlace[1]);

        returnStr += getString((int)((number / 100000) % 100), MorePlace[2]);

        returnStr += getString((int)((number / 1000) % 100), MorePlace[3]);
        returnStr += getString((int)((number / 100) % 10), MorePlace[4]);

        returnStr += getString((int)number % 100, "");

        return returnStr;
    }
}
class ConvertToWord
{

    static void Main(string[] args)
    {
        Console.Write("Please enter whole number - ");
        string inputString = Console.ReadLine();

        long inputNumber = Convert.ToInt64(inputString);

        string outPutString = Utils.NumberToString(inputNumber);

        Console.WriteLine(outPutString);

        Console.ReadLine();

    }
}


