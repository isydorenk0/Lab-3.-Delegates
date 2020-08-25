using System;

namespace LabC
{
    public static class Error
    {
        public static void Show(string value)
        {
            Console.WriteLine($"{value} is wrong value!");
        }
        public static void ShowAlreadyExists(string value)
        {
            Console.WriteLine($"{value} already exists!");
        }
        public static void ShowOutOfRange(int index)
        {
            Console.WriteLine($"{index} out of range!");
        }
    }
}