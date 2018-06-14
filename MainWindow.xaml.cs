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

namespace euler3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            long start =  600851475143;

            long pf = 775121;
            Console.WriteLine(start % pf);
            Console.WriteLine("Square root: " + Math.Sqrt(start));
            //start = (long)Math.Sqrt((double)start);
            
            Console.WriteLine("Largest prime factor: " + getPrimeFactor(start));
        }

        public long getPrimeFactor(long n) {
            //create an array - this trick sets the initial values to true
            bool[] A = Enumerable.Repeat(true, ((int)Math.Sqrt((double)n))).ToArray();

            //sieve to set non-primes to false
            for(int i = 2; i < A.Length; i++)
            {
                if (A[i])
                {
                    for (int j = i * i; j < A.Length && j > 0; j = j + i)
                    {
                        A[j] = false;
                    }
                }
            }
            Console.WriteLine("Length " + A.Length);
            for (int i = A.Length - 1; i > 1; i--)
            {
                if (A[i] && n%i==0)
                {
                    return i;
                }
            }

            return 1;
        }
    }
}
