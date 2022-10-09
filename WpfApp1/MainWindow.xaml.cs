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

namespace WpfApp1
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

        public int vibor = -1;

        private void Button_Slavs(object sender, RoutedEventArgs e)
        {
            Year.Visibility = Visibility.Collapsed;
            YearBox.Visibility = Visibility.Collapsed;
            Result.Visibility = Visibility.Visible;
            vibor = 1;
        }

        private void Button_Japan(object sender, RoutedEventArgs e)
        {
            Year.Visibility = Visibility.Visible;
            YearBox.Visibility = Visibility.Visible;
            Result.Visibility = Visibility.Visible;
            vibor = 2;
        }

        private void ComboBox_SelectionMonth(object sender, SelectionChangedEventArgs e)
        {

        }

        private string SerchInfoVostoc(int year)
        {
            string[] signs = { "Крыса", "Бык", "Тигр", "Кролик", "Дракон", "Змея", "Лошадь", "Овца", "Обезьяна", "Петух", "Собака", "Кабан" };

            int a;
            int sign = 0;
            if (year >= 1900)
            {
                a = 1899;
                while (a < year)
                {
                    for (int j = 0; j < 12 && a < year; j++)
                    {
                        a++;
                        sign = j;
                    }
                }
            }
            else if (year < 1900)
            {
                a = 1900;
                while (a > year)
                {
                    for (int j = 11; j >= 0 && a > year; j--)
                    {
                        a--;
                        sign = j;
                    }
                }
            }
            string horoJapan = "";
            switch (sign)
            {
                case 0:
                    horoJapan = "Крыса";
                    break;
                case 1:
                    horoJapan = "Бык";
                    break;
                case 2:
                    horoJapan = "Тигр";
                    break;
                case 3:
                    horoJapan = "Кролик";
                    break;
                case 4:
                    horoJapan = "Дракон";
                    break;
                case 5:
                    horoJapan = "Змея";
                    break;
                case 6:
                    horoJapan = "Лошадь";
                    break;
                case 7:
                    horoJapan = "Овца";
                    break;
                case 8:
                    horoJapan = "Обезьяна";
                    break;
                case 9:
                    horoJapan = "Петух";
                    break;
                case 10:
                    horoJapan = "Собака";
                    break;
                case 11:
                    horoJapan = "Кабан";
                    break;
            }
            return horoJapan;
        }

        private string SerchInfoSlaves(int month, int day)
        {
            string horoSlavs = "";
            if ((month == 12 && day >= 24 && day<=31) || (month == 1 && day <= 30))
            {
                horoSlavs = "Ваш покровитель - Мороз (Морозко, Трескун, Студенец)";
            }
            else if ((month == 1 && day == 31) || (month == 2 && day <= 28))
            {
                horoSlavs = "Ваш покровитель - Велес";
            }
            else if (month == 3 && day <= 31)
            {
                horoSlavs = "Ваш покровитель - Макошь";
            }
            else if (month == 4 && day <= 30)
            {
                horoSlavs = "Ваш покровитель - Жива";
            }
            else if (month == 5 && day <= 14)
            {
                horoSlavs = "Ваш покровитель - Ярила (Ярило)";
            }
            else if ((month == 5 && day >= 15 && day <= 31) || (month == 6 && day <= 2))
            {
                horoSlavs = "Ваш покровитель - Леля";
            }
            else if ((month == 6 && day >= 2 && day <= 12))
            {
                horoSlavs = "Ваш покровитель - Кострома";
            }
            else if ((month == 6 && day >= 13 && day <= 30) || (month == 7 && day <= 6))
            {
                horoSlavs = "Ваш покровитель - Додола";
            }
            else if (month == 7 && day == 24)
            {
                horoSlavs = "Ваш покровитель - Иван Купала";
            }
            else if (month == 7 && day >= 7 && day <= 31)
            {
                horoSlavs = "Ваш покровитель - Лада";
            }
            else if (month == 8 && day >= 1 && day <= 28)
            {
                horoSlavs = "Ваш покровитель - Перун";

            }
            else if ((month == 8 && day >= 29 && day <= 31) || (month == 9 && day <= 13))
            {
                horoSlavs = "Ваш покровитель - Сева";
            }
            else if (month == 9 && day >= 14 && day <= 27)
            {
                horoSlavs = "Ваш покровитель - Рожаница";
            }
            else if ((month == 9 && day >= 28 && day <= 30) || (month == 10 && day <= 15))
            {
                horoSlavs = "Ваш покровитель - Сварожник";
            }
            else if ((month == 10 && day >= 16 && day <= 31) || (month == 11 && day <= 8))
            {
                horoSlavs = "Ваш покровитель - Морена";

            }
            else if (month == 11 && day >= 9 && day <= 28)
            {
                horoSlavs = "Ваш покровитель - Зима";
            }
            else if ((month == 11 && day >= 29 && day <= 30) || (month == 12 && day <= 23))
            {
                horoSlavs = "Ваш покровитель - Карачун";
            }
            if (horoSlavs =="")
            {
                MessageBox.Show("День введен не корректно при определении славянского покровителя");
            }
            return horoSlavs;
        }

        private void Button_Result(object sender, RoutedEventArgs e)
        {
            if (Month.SelectedIndex == 0)
            {
                MessageBox.Show("Не выбран месяц");
                return;
            }
            int day = 0;
            try
            {
                day = Convert.ToInt32(Day.Text.ToString());
                if (day <= 31 && day > 0)
                { }
                else
                {
                    MessageBox.Show("Введена не корректная дата(день)");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Введена не корректная дата(день)");
                return;
            }
            switch (vibor)
            {
                case 1:
                    strResult.Text = SerchInfoSlaves(Month.SelectedIndex, day);
                    break;
                case 2:
                    int year = 0;
                    try
                    {
                        year = Convert.ToInt32(YearBox.Text.ToString());
                        if (year > 0)
                        { }
                        else
                        {
                            MessageBox.Show("Введен не корректый год");
                            return;
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Введен не корректый год");
                        return;
                    }
                    strResult.Text =SerchInfoVostoc(year);
                    break;
                default:
                    MessageBox.Show("Вам удалось не выбрать вид календаря");
                    break;
            }
        }

    }
}
