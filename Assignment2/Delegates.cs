namespace Assignment2;
using System.Linq; 

public class Delegates{

//decimal p = 0.0;

public delegate string charReverser(string word); 


charReverser c = word => reverse(word);


public static string reverse(string word)
{
    string reversed = "";
    foreach (var ch in word.Reverse().ToArray())
    {
    reversed+=ch;   
    }
    return reversed;
}


public delegate decimal decimalProduct(decimal number);

decimalProduct d = d => d*d;


public delegate bool numberChecker(int intNumber, string stringNumber);

numberChecker nc = (nb1,nb2) => checkmethod(nb1,nb2);

public static bool checkmethod(int intNumber, string stringNumber) => intNumber == int.Parse(stringNumber) ? true : false;  
}


