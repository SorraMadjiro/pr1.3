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

namespace WpfApp18
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
            string fio = fiobox.Text;
            string mail = mailbox.Text;
            string tel = telbox.Text;
            string snils = snilsbox.Text;
            try
            {
                list.Items.Add($"ФИО:{fio}\nMail: {mail}\nТелефон:{tel}\nСнилс:{snils}");
            }
            catch
            {
                MessageBox.Show("ошибка");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string fio = fiobox.Text;
            string mail = mailbox.Text;
            try
            {
                var addr = new System.Net.Mail.MailAddress(mail);
                MessageBox.Show("Mail введен правельно");
            }
            catch 
            {
                MessageBox.Show("ошибка");
            }
            if (telbox.Text.Length==10)
            {
                MessageBox.Show("телефон введен правельно");
            }
            else
            {
                MessageBox.Show("ошибка");
            }
            if (snilsbox.Text.Length==11)
            {
                MessageBox.Show("снилс введен правельно");
            }
            else
            {
                MessageBox.Show("ошибка");
            }

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                string str = list.SelectedItem.ToString();
                list.Items.Remove(str);

            }
            catch
            {

                MessageBox.Show("ошибка");
            }
        }
    }
}
