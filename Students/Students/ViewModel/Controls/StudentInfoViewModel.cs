using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.ViewModel.Controls
{
    public class StudentInfoViewModel: BindableBase
    {
        #region View Bindings

        private StudentInfoNode _student;
        public StudentInfoNode Student
        {
            get => _student;
            set => SetProperty(ref _student, value);
        }


        #endregion

        #region Commands

        public DelegateCommand Сancel { get; set; }
        public DelegateCommand Save { get; set; }

        #endregion

        #region Constructor

        public StudentInfoViewModel()
        {
            Save = new DelegateCommand(() => SaveStudent());
            Сancel = new DelegateCommand(() => CancelStudent());
        }

        #endregion

        #region Events

        public event Action ChangeToList;
        

        #endregion

        #region Methods

        public void SaveStudent()
        {
            Student.СalculatedAverageScore();
            ChangeToList?.Invoke();
        }

        public void CancelStudent()
        {

            ChangeToList?.Invoke();
        }

        #endregion
    }

}
