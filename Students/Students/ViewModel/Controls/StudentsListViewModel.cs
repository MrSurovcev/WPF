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
    public class StudentsListViewModel : BindableBase
    {
        #region View Bindings

        private ObservableCollection<StudentInfoNode> _studentList;
        public ObservableCollection<StudentInfoNode> StudentList
        {
            get => _studentList;
            set => SetProperty(ref _studentList, value);
        }



        #endregion

        #region Commands
        public DelegateCommand Add { get; set; }
        public DelegateCommand Delete { get; set; }
        
        #endregion

        #region Constructor
        public StudentsListViewModel()
        {
            _studentList = new ObservableCollection<StudentInfoNode>();
            Add = new DelegateCommand(AddStudent);
            
        }
        #endregion

        #region Events

        public event Action<StudentInfoNode> ChangeToStudent;
        public event Action<StudentInfoNode> SwitchControl;
        #endregion

        #region Methods

        public void AddStudent()
        {
            StudentInfoNode newStudent = new StudentInfoNode();
            newStudent.ShowStudentEvent += RaiseChangeControl;
            SwitchControl?.Invoke(newStudent);
            

            //StudentList.Add(newStudent);
        }

        public void RaiseChangeControl(StudentInfoNode student) 
        {
            ChangeToStudent?.Invoke(student);
        }

        #endregion
    }    
}
