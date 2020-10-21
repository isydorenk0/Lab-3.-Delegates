using System;

namespace WindowsFormsApplication1
{
    public delegate string FormatDelegate(string text);
    public class SMSFormat
    {        
        public static string FormatDefault(string message)
        {
            return message + Environment.NewLine;
        }
        public static string FormatTimeStarts(string message)
        {
            return $"[{DateTime.Now}]{message + Environment.NewLine}";
        }
        public static string FormatTimeEnds(string message)
        {
            return $"{message}[{DateTime.Now}]{Environment.NewLine}";
        }
        public static string FormatCustom(string message)
        {
            return "*custom*" + message + Environment.NewLine;
        }
        public static string FormatUpperCase(string message)
        {
            return message.ToUpper() + Environment.NewLine;
        }
        public static string FormatLowerCase(string message)
        {
            return message.ToLower() + Environment.NewLine;
        }
    }
}
