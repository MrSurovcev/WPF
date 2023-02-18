using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using Prism.Commands;
using Prism.Mvvm;
using Students.ViewModel.Controls;


namespace Students.ViewModel
{
    public class MainViewModel:BindableBase
    {
        #region View Bindings
        // Связь контрола и вьюшки 
        private List<UserControl> _contentList;

        private object _visibleContent;
        public object VisibleContent
        {
            get { return _visibleContent; }
            set
            {
                SetProperty(ref _visibleContent, value);
            }
        }

        #endregion

        #region Commands
        // Кнопки MainWindow
        public DelegateCommand Download { get; set; } // Кнопка Загрузить - Пока не реализую
        public DelegateCommand Save { get; set; } // Кнопка Сохранить - пока не реализую
        public DelegateCommand Exit { get; set; } // Кнопка Выйти

        #endregion

        #region Constructor
        public MainViewModel(Action<bool> closeAction)
        {
            Exit = new DelegateCommand(() => closeAction(false));

            _contentList = new List<UserControl>();

            // Создал связь с первым контролом
            StudentsListView studentList = new StudentsListView();
            StudentsListViewModel studentListVM = studentList.GetDataContext();
            studentListVM.ChangeToStudent += ChangeToStudent;
            _contentList.Add(studentList);

            //Создал связь со вторым контролом
            StudentInfoView studentInfo = new StudentInfoView();
            StudentInfoViewModel studentInfoVM = studentInfo.GetDataContext();
            studentInfoVM.ChangeToList += ChangeToList;
            _contentList.Add(studentInfo);

            VisibleContent = _contentList[0];

        }
        #endregion

        #region Events



        #endregion

        #region Methods

        private void ChangeContent(int num) { VisibleContent = _contentList[num]; }

        private void ChangeToStudent(StudentInfoNode student)
        {
            VisibleContent = _contentList[1];
            StudentInfoViewModel studentInfoVM = ((StudentInfoView)VisibleContent).GetDataContext();
            studentInfoVM.Student = student;
        }

        private void ChangeToList()
        {
            VisibleContent = _contentList[0];
        }

        #endregion





    }
}
