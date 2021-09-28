using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        if(input == null || input == "") return "";
        
        char [] arr = input.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);

        
        
    }
}