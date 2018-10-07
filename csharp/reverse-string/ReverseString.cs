using System;
using System.Diagnostics;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if (input.Length == 0)
            return "";
        else
        {
            char [] inputChar = input.ToCharArray();
            char [] reversedString = new char[input.Length];
            for(int j=input.Length-1, i=0; j>=0; j--,i++)
            {
                Debug.WriteLine("j = " + j + " reversedString[j] = " + reversedString[j]);
                reversedString[j] = inputChar[i];
            }
            return new string(reversedString);
        }
    }
}