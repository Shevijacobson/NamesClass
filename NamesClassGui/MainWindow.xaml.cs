using StudentsListDL;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using StudentsListBL;
using Entities;
namespace NamesClassGui
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {

            students = new StudentsListBL.StudentsListBL();
            SudentsArr = students.GetNamesStudents();
            BuildArrNames();
            DataContext = this;
            InitializeComponent();
        }
        public Student[] SudentsArr { get; set; }
        StudentsListBL.StudentsListBL students;
        public string[] NamesStudentsArr { get; set; }

        public void BuildArrNames()
        {
            NamesStudentsArr = new string[SudentsArr.Length];
            for (int i = 0; i < SudentsArr.Length; i++)
            {
                NamesStudentsArr[i]= SudentsArr[i].Name;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}