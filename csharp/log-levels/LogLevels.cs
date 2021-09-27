using System;

static class LogLine
{
    public static string Message(string logLine)
    {
        if(logLine != null && logLine.Length > 0)
        {
            string modifiedLogLine = logLine.Split(':')[1];
            string cleanLogLine = modifiedLogLine.Trim(' ', '\r', '\t', '\n');
            return cleanLogLine;
        }
        return logLine;
    }

    public static string LogLevel(string logLine)
    {
        if(logLine != null && logLine.Length > 0)
        {
            string modifiedLogLine = logLine.Split(':')[0];
            string cleanLogLine = modifiedLogLine.Trim('[', ']').ToLower();
            return cleanLogLine;
        }
        return logLine;
    }

    public static string Reformat(string logLine)
    {
        string cleanedMessage = Message(logLine);
        string cleanedLogLevel = LogLevel(logLine);
        return $"{cleanedMessage} ({cleanedLogLevel})";
    }
}
