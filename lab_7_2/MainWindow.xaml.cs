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

namespace lab_7_2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int columns = Convert.ToInt32(Columns.Text);
            int rows = Convert.ToInt32(Rows.Text);
            if (columns <=0 || rows <=0)
            {
                MessageBox.Show("Количество столбцов и строк должно быть больше нуля.");
            }
            else
            {
                MyMatrix newmatrix = new MyMatrix(columns, rows);
            }
        }
    }
}
