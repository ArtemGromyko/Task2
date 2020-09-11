using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class Mark
    {
        public string Subject { get; set; }
        public int Value { get; set; }
        public void ShowInfo()
        {
            Console.WriteLine("subject: " + Subject + " value: " + Value);
        }

    }
}
