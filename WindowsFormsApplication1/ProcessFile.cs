using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public static class ProcessFile
    {
        public static List<Message> ProcessMessages(string path, int count, int skip)
        {
            var file = File.ReadAllLines(path).Skip(skip).Take(count);
            var messages = new List<Message>();
            foreach (var line in file)
            {
                var columns = line.Split(';');
                var message = new Message(columns[0], columns[1], columns[2], DateTime.Parse(columns[3]));
                messages.Add(message);
            };            
            return messages;
        }
    }
}

