using System;

namespace ClassObj
{
    public class People
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public long CCID { get; set; }
        public DateTime DayOfBirth { get; set; }
        
        // constructor - default
        public People()
        {
            
        }
        
        // constructor
        public People(string name, int age, long ccid, DateTime dayOfBirth)
        {
            Name = name;
            Age = age;
            CCID = ccid;
            DayOfBirth = dayOfBirth;
        }

        // method
        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"CCID: {CCID}");
            Console.WriteLine($"DayOfBirth: {DayOfBirth}");
        }

        public void Say(string text)
        {
            Console.WriteLine(text);
        }
    }
}