using System.Linq;
using System.Security.Cryptography.X509Certificates;

public static class Program
{
    public static void Main()
    {
        string String = "kitab";
        string reverseWord = "";
        Stack<char> stack = new Stack<char>();
        foreach (char c in String)
        {
            stack.Push(c);
        }
        do
            reverseWord = reverseWord + stack.Pop();
        while (stack.Count > 0);
        Console.WriteLine(reverseWord);
    }
}
