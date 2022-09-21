using System.Text.RegularExpressions;

namespace Assignment2;

public static class Extensions
{
     public static Boolean IsSecure(this Uri uri) => uri.Scheme.Equals("https"); 

     public static int WordCount(this String str){   
        int i = 0; 
        var regex = new Regex(@"\p{L}+");
        foreach (var word in regex.Split(str)) i++;
        return i-1; 
     }
}