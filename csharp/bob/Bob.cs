using System;
using System.Linq;
using System.Text.RegularExpressions;

public static class Bob
{
    public static string Response(string statement)
    {
        Regex regular = new Regex(@"[a-z0-9]");
        Regex yell = new Regex(@"[A-Z]");
        Regex noAlphabet = new Regex(@"[0-9(){};:]");
        Regex question = new Regex(@"[\?]\z");
        Regex exclamation = new Regex(@"[\!]\z");
        Regex special = new Regex(@"[%!@#$%^&*()?/>.<,:;'\|}{_~`+=-][\?]\z");
        if (regular.IsMatch(statement.Trim()) || special.IsMatch(statement) && question.IsMatch(statement.Trim())) return "Sure.";
        else if (yell.IsMatch(statement.Trim()) && question.IsMatch(statement.Trim())) return "Calm down, I know what I'm doing!";
        else if (yell.IsMatch(statement.Trim()) || exclamation.IsMatch(statement.Trim())) return "Whoa, chill out!";
        else return "Whatever.";
    }
}