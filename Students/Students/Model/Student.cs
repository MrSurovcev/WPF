using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Model
{
    internal class Student
    {
        private double _averageScore;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int MathEstimation { get; set; }
        public int PhysicsEstimation { get; set; }
        public int ChemistryEstimation { get; set; }
        public int InformaticsEstimation { get; set; }

        public double AverageScore
        {
            get { return _averageScore = ReturnAverageScore(); }
  
        }

        public Student(string name, string surname, int mathEstimation, int  physicsEstimation, int chemistryEstimation, int informaticsEstimation)
        {
            Name = name;
            Surname = surname;
            MathEstimation = mathEstimation;
            PhysicsEstimation = physicsEstimation;
            ChemistryEstimation = chemistryEstimation;
            InformaticsEstimation = informaticsEstimation;

        }
        public double ReturnAverageScore()
        {
            return (MathEstimation + PhysicsEstimation + ChemistryEstimation + InformaticsEstimation) / 4;
        }
    }
}
