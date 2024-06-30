using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test.Tests;

namespace Test
{
    public class Person 
    {
        public string PersonName { get; set; }
        public int PersonWeight { get; set; }
        public int PersonHeight { get; set; }
        public int PersonAge { get; set; }
        public int PersonVision { get; set; }
        public int PersonSmoke { get; set; }
        public List<string> PersonBadHabits { get; set; } = new List<string>()
        {
            "Алкоголизм (alcoholism)",
            "Бессонница (insonnia)",
            "Травмы (injury)",
            "Насморк (cold)",
            "Бронхит (bronchitis)",
            "Вирусы (virus)",
            "Аллергия (allergy)",
            "Ангина (quinsy",
            "Бессонница (insonnia)",
            "Hapkonanna (narconanta)",
            "Курит (smoke)"
        };
                
        public Person(string Name,int Weight, int Height, int Age, int Vision, int Smoke, List<string> Habits) 
        {
            PersonName = Name;
            PersonWeight = Weight;
            PersonHeight = Height;
            PersonAge = Age;
            PersonVision = Vision;
            PersonSmoke = Smoke;
            PersonBadHabits = Habits;

        }
    }
}
