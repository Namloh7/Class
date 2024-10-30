using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ToDoClass;

namespace Zaci
{
    public class Pupil
    {
        public string Name;
        public string Surname;
        public string Class;
        public List<MathGrade> MathGrades;
        public List<EnglishGrade> EnglishGrades;
        public List<BiologyGrade> BiologyGrades;
        Random random = new Random();   

        public Pupil(string name, string surname, string className)
        {
            this.Name = name;
            this.Surname = surname;
            this.Class = className;
            
            MathGrades = new List<MathGrade>();     /*matika*/
            AddMathGrades();
            

            EnglishGrades = new List<EnglishGrade>();   /*ájina*/
            AddEnglishGrades();

            BiologyGrades = new List<BiologyGrade>();   /*ta píčovina*/
            AddBiologyGrades();
            
            PrintInfo();
        }
        public void PrintInfo() 
        {
            HelperClass.WriteLine("Name: " + Name);
            HelperClass.WriteLine("Surname: " + Surname);
            HelperClass.WriteLine("Class: " + Class);
            HelperClass.WriteLine("-----------------------------------");
            int i = 1;
            foreach (var o in MathGrades) 
            {
                HelperClass.WriteLine("Your math score number " + i + " is: " + o.Score);
                HelperClass.WriteLine("Weight of your math score: " + o.Weight);
                i++;
            }
            i = 1;
            HelperClass.WriteLine("-----------------------------------");
            foreach (var o in EnglishGrades)
            {
                HelperClass.WriteLine("Your english score number " + i + " is: " + o.Score);
                HelperClass.WriteLine("Weight of your math score: " + o.Weight);
                i++;
            }
            i = 1;
            HelperClass.WriteLine("-----------------------------------");
            foreach (var o in BiologyGrades)
            {
                HelperClass.WriteLine("Your biology score number " + i + " is: " + o.Score);
                HelperClass.WriteLine("Weight of your math score: " + o.Weight);
                i++; 
            }
            AllDiameter();
        }
        public void AddMathGrades() 
        {
            
            for (int i = 0; i <= random.Next(1,3); i++)    
            {
                var mathGrade = new MathGrade(random.Next(0, 100), random.Next(1, 10));   
                MathGrades.Add(mathGrade);
            }
        
        }
        public void AddBiologyGrades()
        {
            
            for (int i = 0; i <= random.Next(1, 3); i++)
            {
                var biologyGrade = new BiologyGrade(random.Next(0, 100), random.Next(1, 10));
                BiologyGrades.Add(biologyGrade);
            }

        }
        public void AddEnglishGrades()
        {
            
            for (int i = 0; i <= random.Next(1, 3); i++)
            {
                var englishGrade = new EnglishGrade(random.Next(0, 100), random.Next(1, 10));
                EnglishGrades.Add(englishGrade);
            }
        }
        public void AllDiameter() 
        {
            int number = 0;
            int i = 0;
            foreach(var o in MathGrades) 
            {
                number += o.Score * o.Weight;
                i = i + o.Weight;
                
                
            }
            foreach (var o in BiologyGrades)
            {
                number += o.Score * o.Weight;
                i = i + o.Weight;
                
                
            }
            foreach (var o in EnglishGrades)
            {
                number += o.Score * o.Weight;
                i = i + o.Weight;
                
            }
            Console.WriteLine("Your avarage score is: " + number / i);
            
        }
    }
}
