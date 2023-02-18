using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Mvvm;

namespace Students.ViewModel.Controls
{
    public class StudentInfoNode : BindableBase
    {
        #region View Bindings
        private string _surname;
        public string Surname
        {
            get => _surname;
            set => SetProperty(ref _surname, value);
        }
        private string _name;
        public string Name
        {
            get => _name;
            set => SetProperty(ref _name, value);
        }
        private int _math;
        public int Math
        {
            get => _math;
            set => SetProperty(ref _math, value);

        }
        private int _physics;
        public int Physics
        {
            get => _physics;
            set => SetProperty(ref _physics, value);
        }
        private int _chemistry;
        public int Chemistry
        {
            get => _chemistry;
            set => SetProperty(ref _chemistry, value);
        }
        private int _informatics;
        public int Informatics
        {
            get => _informatics;
            set => SetProperty(ref _informatics, value);
        }

        private double _averageScore;
        public double AverageScore   // добавить то, что будет сигнализировать вью о том, что свойство изменилось
        {
            get => _averageScore;
            set => SetProperty(ref _averageScore, value);
        } 

        #endregion

        #region Commands
        public DelegateCommand StudentInfo { get; set; }
        #endregion

        #region Constructor
        public StudentInfoNode()
        {
            StudentInfo = new DelegateCommand(StudentInformation);
            
        }

        public StudentInfoNode(StudentInfoNode student)
        {
            StudentInfo = new DelegateCommand(StudentInformation);
            Surname = student.Surname;
            Name = student.Name;
            Math = student.Math;
            Physics= student.Physics;
            Chemistry = student.Chemistry;
            Informatics = student.Informatics;
        }


        #endregion

        #region Events

        public event Action<StudentInfoNode> ShowStudentEvent;

        #endregion

        #region Methods

        // Переписать через лямбду если останется одно действие
        public void StudentInformation()
        {
            ShowStudentEvent?.Invoke(this);
        }
        public void СalculatedAverageScore()
        {
            AverageScore =(_math + _physics + _chemistry + _informatics) / 4.0;
        }
        #endregion

    }
}
