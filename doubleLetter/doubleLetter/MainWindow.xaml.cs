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

namespace doubleLetter
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
            bool flag = false;
            int colvo = tb1.Text.Length;
            for(int i = 0; i < tb1.Text.Length; i++)
            { 
                if (i < colvo - 1)
                {
                    if(tb1.Text[i] == tb1.Text[i+1])
                    {
                        MessageBox.Show($"Найдены буквы: {tb1.Text[i]}{tb1.Text[i+1]}");
                    flag = true;
                    }
                    
                }
            }
            if ( !flag )
            {

                        MessageBox.Show($"НЕ Найдены буквы");
            }
        }
        private void Button_Click_Words(object sender, RoutedEventArgs e)
        {
            int count = 0;
            string[] text = tb2.Text.Split(' ');
            for (int i = 0;i < text.Length;i++)
            {
                if (text[i].Length > 1)
                {
                    count++;
                }
            }
            MessageBox.Show($"Cлов: {count}");
        }
    }
}
