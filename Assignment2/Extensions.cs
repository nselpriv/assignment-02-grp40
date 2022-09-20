namespace Assignment2;

public static class Extensions
{
     public static void IsSecure(this Uri uri) 
        {
            Console.WriteLine(uri.Scheme);
        }
}