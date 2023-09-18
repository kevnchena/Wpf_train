using System.Windows;
using System;
using System.Collections.Generic;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> primes = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int n = Convert.ToInt32(textbox1.Text);
            MessageBox.Show($"您所輸入的值為{n}");
            for (int i = 2; i<=n; i++)
            {
                if (isPrime(i)) { primes.Add(i); }
            }
        }

        private bool isPrime(int i)
        {
            Console.WriteLine("判斷");
            return true;
        }
    }
}
