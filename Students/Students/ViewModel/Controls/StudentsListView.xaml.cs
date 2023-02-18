using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Students.ViewModel.Controls
{
    /// <summary>
    /// Логика взаимодействия для StudentsList.xaml
    /// </summary>
    public partial class StudentsListView : UserControl
    {
        public StudentsListView()
        {
            InitializeComponent();
            DataContext= new StudentsListViewModel();
        }
        public StudentsListViewModel GetDataContext() => (StudentsListViewModel)DataContext;
    }
}
