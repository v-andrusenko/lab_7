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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (IsNumeric(Convert.ToString(Columns.Text), Convert.ToString(Rows.Text)) == false)
            {
                MessageBox.Show("Некорректный тип данных. Вводите только числовые значения");
            }
            else
            {
                int columns = Convert.ToInt32(Columns.Text);
                int rows = Convert.ToInt32(Rows.Text);
                if (columns <= 0 || rows <= 0)
                {
                    MessageBox.Show("Количество столбцов и строк должно быть больше нуля.");
                }
                else
                {
                    MyMatrix newmatrix = new MyMatrix(rows, columns);
                    if (newmatrix.rows==newmatrix.columns)
                    {
                        BaseMatrix.Text = "Порядок базовой матрицы: " + newmatrix.columns + "\n\n";
                    }
                    else
                    {
                        BaseMatrix.Text = "Порядок базовой матрицы: " + newmatrix.rows + " x " + newmatrix.columns + "\n\n";
                    }
                    
                    for (int i = 0; i < newmatrix.rows; i++)
                    {
                        for (int k=0; k < newmatrix.columns;k++)
                        {
                            if (k==(newmatrix.columns-1))
                            {
                                BaseMatrix.Text += newmatrix.array[i, k].ToString() + "\n";
                            }
                            else
                            {
                                BaseMatrix.Text += newmatrix.array[i, k].ToString() + "  ";
                            }

                        }
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
                if (IsNumeric(Convert.ToString(Columns.Text), Convert.ToString(Rows.Text)) == false)
                {
                    MessageBox.Show("Некорректный тип данных. Вводите только числовые значения");
                }
                else
                {
                    int columns = Convert.ToInt32(Columns.Text);
                    int rows = Convert.ToInt32(Rows.Text);
                    if (columns <= 0 || rows <= 0)
                    {
                        MessageBox.Show("Количество столбцов и строк должно быть больше нуля.");
                    }
                    else
                    {
                        MyMatrix newmatrix = new MyMatrix(rows, columns);
                        if (newmatrix.rows == newmatrix.columns)
                        {
                            Matrix.Text = "Порядок производной матрицы: " + newmatrix.columns + "\n\n";
                        }
                        else
                        {
                            Matrix.Text = "Порядок производной матрицы: " + newmatrix.rows + " x " + newmatrix.columns + "\n\n";
                        }

                        for (int i = 0; i < newmatrix.rows; i++)
                        {
                            for (int k = 0; k < newmatrix.columns; k++)
                            {
                                if (k == (newmatrix.columns - 1))
                                {
                                    Matrix.Text += newmatrix.array[i, k].ToString() + "\n";
                                }
                                else
                                {
                                    Matrix.Text += newmatrix.array[i, k].ToString() + "  ";
                                }

                            }
                        }
                    }
                }
            }
        }
    }
}
