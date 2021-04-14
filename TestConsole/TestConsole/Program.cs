using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Programs
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter the required string");
        string inputString = Console.ReadLine();
        bool validString = CheckString(inputString);
        Console.WriteLine(validString);
    }

    private static bool CheckString(string inputString)
    {
        Stack<char> collectionStack = new Stack<char>();

        bool isValid = true;

        for (int i = 0; i < inputString.Length; i++)
        {
            switch (inputString[i])
            {
                case '(':
                case '{':
                case '[':
                    // If the element is a openeing bracket, then add to the stack.
                    collectionStack.Push(inputString[i]);
                    break;

                case ')':
                    // If the stack has elements then remove the element using pop and continue to the next char else mark the string as invalid - the parenthesis are not matching
                    isValid = (collectionStack.Count > 0 && collectionStack.Pop() == '(');
                    break;

                case '}':
                    // If the stack has elements then remove the element using pop and continue to the next char else mark the string as invalid - the parenthesis are not matching
                    isValid = (collectionStack.Count > 0 && collectionStack.Pop() == '{');
                    break;

                case ']':
                    // If the stack has elements then remove the element using pop and continue to the next char else mark the string as invalid - the parenthesis are not matching
                    isValid = (collectionStack.Count > 0 && collectionStack.Pop() == '[');
                    break;

                default:
                    break;
            }

            if (!isValid) break;
        }

        return isValid && collectionStack.Count == 0;
    }
}
