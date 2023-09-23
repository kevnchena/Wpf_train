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
            //int n = Convert.ToInt32(textbox1.Text);
            //MessageBox.Show($"您所輸入的值為{n}");
            int number;
            
            bool success = int.TryParse(textbox1.Text, out number); //如果textbox1是可以轉換成數字 ， out給number

            if (!success)
            {
                MessageBox.Show("請輸入整數","輸入錯誤");
            }
            else if (number < 2)
            {
                MessageBox.Show($"輸入數值為{number}，請輸入大於2的整數", "輸入錯誤");
            }
            else
            {
                for (int i = 2; i <= number; i++)
                {
                    if (isPrime(i)) { primes.Add(i); }
                }
            }
            ListResult(primes, number);
        }

        private void ListResult(List<int> myPrimes, int n)
        {
            string primeLsit = $"小於等於{n}的質數為: ";
            string primeMulti = "";

            foreach (int p in myPrimes)
            {
                primeLsit += $"{p}  ";
                primeMulti += $"{p}的倍數為: ";
                int i = 1;
                while (i * p <= n)
                {
                    primeMulti += $"{i * p}  ";
                    i++;
                }
                primeMulti += "\n";
            }
            textblock.Text = primeLsit;
            textblock2.Text = primeMulti;
        }

        private bool isPrime(int p)
        {
            for(int i = 2; i < p; i++)
            {
                if (p % i == 0) return false;
            }
            return true;
        }
    }
}
