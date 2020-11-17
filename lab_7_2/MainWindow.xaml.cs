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

        public static Boolean IsNumeric(string columns, string rows)
        {
            bool result;
            string value1 = columns.Trim(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
            string value2 = rows.Trim(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
            if (value1 == "" && value2== "")
            {
                result = true;
            }
            else
            {
                result = false;
            }
            return result;
        }
        MyMatrix newmatrix;
        MyMatrix deritativematrix;

        private void PrintBaseMatrix()
        {
            if (newmatrix.rows == newmatrix.columns)
            {
                BaseMatrix.Text = "Порядок базовой матрицы: " + newmatrix.columns;
            }
            else
            {
                BaseMatrix.Text = "Порядок базовой матрицы: " + newmatrix.rows + " x " + newmatrix.columns;
            }
            BaseMatrix.Text += "\n\n";

            for (int i = 0; i < newmatrix.rows; i++)
            {
                for (int k = 0; k < newmatrix.columns; k++)
                {
                     BaseMatrix.Text += String.Format("{0,5}", newmatrix.array[i, k]);
                }
                BaseMatrix.Text += "\n";
            }
        }
        private void DerivativeMatrix()
        {
            if (deritativematrix.rows == deritativematrix.columns)
            {
                Matrix.Text = "Порядок производной матрицы: " + deritativematrix.columns;
            }
            else
            {
                Matrix.Text = "Порядок производной матрицы: " + deritativematrix.rows + " x " + deritativematrix.columns;
            }
            Matrix.Text += "\n\n";
            for (int i = 0; i < deritativematrix.rows; i++)
            {
                for (int k = 0; k < deritativematrix.columns; k++)
                {
                    Matrix.Text += String.Format("{0,5}", deritativematrix.array[i, k]);
                }
                Matrix.Text += "\n";
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumeric(Convert.ToString(Columns.Text), Convert.ToString(Rows.Text)) == false)
            {
                MessageBox.Show("Некорректный тип данных. Вводите только числовые значения");
            }
            else
            {
                if (Convert.ToString(Columns.Text) == "" || Convert.ToString(Rows.Text) == "")
                {
                    MessageBox.Show("Проверьте введенные данные");
                }
                else
                {
                    if (Convert.ToInt32(Columns.Text) <= 0 || Convert.ToInt32(Rows.Text) <= 0)
                    {
                        MessageBox.Show("Количество столбцов и строк должно быть больше нуля.");
                    }
                    else
                    {
                        newmatrix = new MyMatrix(Convert.ToInt32(Rows.Text), Convert.ToInt32(Columns.Text));
                        PrintBaseMatrix();
                        Matrix.Text = "";
                    }
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(BaseMatrix.Text) == "")
            {
                MessageBox.Show("Невозможно создать производную матрицу, если нет базовой");
            }
            else
            {
                if (Convert.ToString(Columns.Text) == "" || Convert.ToString(Rows.Text) == "")
                {
                    MessageBox.Show("Проверьте введенные данные");
                }
                else
                {
                    if (IsNumeric(Convert.ToString(Columns.Text), Convert.ToString(Rows.Text)) == false)
                    {
                        MessageBox.Show("Некорректный тип данных. Вводите только числовые значения");
                    }
                    else
                    {
                        if (Convert.ToInt32(Columns.Text) <= 0 || Convert.ToInt32(Rows.Text) <= 0)
                        {
                            MessageBox.Show("Количество столбцов и строк должно быть больше нуля.");
                        }
                        else
                        {
                            deritativematrix = new MyMatrix(Convert.ToInt32(Rows.Text), Convert.ToInt32(Columns.Text));
                            deritativematrix.ResizeArray(newmatrix, Convert.ToInt32(Rows.Text), Convert.ToInt32(Columns.Text));

                            DerivativeMatrix();
                        }
                    }
                }
            }
        }


        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (Convert.ToString(BaseMatrix.Text) == "")
            {
                MessageBox.Show("Невозможно заполнить несуществующую матрицу. Сперва создайте базовую");
            }
            else
            {
                Random rand = new Random();
                for (int i=0; i<newmatrix.rows; i++)
                {
                    for (int k=0; k<newmatrix.columns;k++)
                    {
                        newmatrix.array[i,k] = rand.Next(0, 10);
                    }
                }
                PrintBaseMatrix();
            }
        }
    }
}
