using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.IO;




namespace lab_7_1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public int arrayLength { get; set; }

        public ObservableCollection<IArrayDetails> InfoCollection { get; set; }
        public MainWindow()
        {

            InitializeComponent();
           
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        public static Boolean IsNumeric(string input)
        {
            bool result;
            string value = input.Trim(new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' });
            if (value == "")
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
            if (IsNumeric(Convert.ToString(LengthOfArray.Text)) == false)
            {
                MessageBox.Show("Некорректный тип введенных данных. Введите новое значение");
            }
            else
            {
                arrayLength = Convert.ToInt32(LengthOfArray.Text);
                if (arrayLength<=0)
                {
                    MessageBox.Show("Количество не может быть меньше или равно нулю");
                }
                else
                {
                    ArrayDetails newarray = new ArrayDetails(arrayLength);
                    newarray.Initialization();
                    MaxResult.Text = "[индекс " + Convert.ToString(newarray.imax) + "], " + Convert.ToString(newarray.max) ;
                    MinResult.Text = "[индекс " + Convert.ToString(newarray.imin) + "], " + Convert.ToString(newarray.min);
                    AverageResult.Text = Convert.ToString(newarray.averageValue);
                    SumResult.Text = Convert.ToString(newarray.sum);
                    string oddstr = "", arrstr = "";
                    for (int i=0;i<newarray.array.Length;i++)
                    {
                        if (i == (newarray.array.Length - 1))
                        {
                            arrstr += Convert.ToString(newarray.array[i]);
                        }
                        else
                        {
                            arrstr += Convert.ToString(newarray.array[i]) + ", ";
                        }
                    }
                    for (int k =0;k<newarray.odd.Length;k++)
                    {
                        if (k==(newarray.odd.Length-1))
                        {
                            oddstr += Convert.ToString(newarray.odd[k]);
                        }
                        else
                        {
                            oddstr += Convert.ToString(newarray.odd[k]) + ", ";
                        }
                    }
                    ArrayValues.Text = arrstr;
                    OddValues.Text = oddstr;
                }
            }
        }
    }
}
