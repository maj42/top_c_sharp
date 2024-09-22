using System.ComponentModel;
using System.Globalization;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace homework_17_20._09_WPF_
{
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private string result = "";
        private string current = "0";
        internal bool clear = false;
        internal bool clearRes = false;
        internal char sign = ' ';
        public decimal PreviousNum { get; set; }
        public decimal CurrentNum { get; set; }

        public string Result
        {
            get { return result; }
            set
            {
                if (clearRes == true)
                {
                    result = " ";
                    clearRes = false;
                }

                if (value == " ") result = " ";
                else if (value == "+" || value == "-" || value == "*" || value == "/")
                {
                    string temp = result;
                    result = " ";
                    result += temp;
                }
                else result += value;
                
                OnPropertyChanged("Result");
            }
        }

        public string Current {
            get { return current; }
            set 
            {
                if (clear == true)
                {
                    current = "";
                    clear = false;
                }
                if (current == "0") current = "";
                if (value == "") current = "0";
                if (value == "." && current == "") current = "0";
                if (value == "del")
                {
                    if (current != "0" && current != "") current = current.Remove(current.Length - 1);
                    if (current == "") current = "0";
                }
                else current += value;
                OnPropertyChanged("Current");
            }
        }
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void currClear()
        {
            PreviousNum = Decimal.Parse(Current, CultureInfo.InvariantCulture);
            Result = Current;
            clear = true;
        }

        public void checkSign(char sign)
        {
            if (Result.Length <= 2) return;
            if ((Result[Result.Length - 2] == '+') ||
               (Result[Result.Length - 2] == '-') ||
               (Result[Result.Length - 2] == '*') ||
               (Result[Result.Length - 2] == '/')) Result = sign.ToString();
            Result = $" {sign} ";
        }

        private void buttCE_Click(object sender, RoutedEventArgs e)
        {
            Current = "";
        }

        private void buttC_Click(object sender, RoutedEventArgs e)
        {
            Current = "";
            Result = " ";
            PreviousNum = 0;
        }

        private void buttDel_Click(object sender, RoutedEventArgs e)
        {
            Current = "del";
        }

        private void buttDiv_Click(object sender, RoutedEventArgs e)
        {
            currClear();
            checkSign('/');
            sign = '/';
        }

        private void butt7_Click(object sender, RoutedEventArgs e)
        {
            Current = "7";
        }

        private void butt8_Click(object sender, RoutedEventArgs e)
        {
            Current = "8";
        }

        private void butt9_Click(object sender, RoutedEventArgs e)
        {
            Current = "9";
        }

        private void buttMult_Click(object sender, RoutedEventArgs e)
        {
            currClear();
            checkSign('*');
            sign = '*';
        }

        private void butt4_Click(object sender, RoutedEventArgs e)
        {
            Current = "4";
        }

        private void butt5_Click(object sender, RoutedEventArgs e)
        {
            Current = "5";
        }

        private void butt6_Click(object sender, RoutedEventArgs e)
        {
            Current = "6";
        }

        private void buttMin_Click(object sender, RoutedEventArgs e)
        {
            currClear();
            checkSign('-');
            sign = '-';
        }

        private void butt1_Click(object sender, RoutedEventArgs e)
        {
            Current = "1";
        }

        private void butt2_Click(object sender, RoutedEventArgs e)
        {
            Current = "2";
        }

        private void butt3_Click(object sender, RoutedEventArgs e)
        {
            Current = "3";
        }

        private void buttPlus_Click(object sender, RoutedEventArgs e)
        {
            currClear();
            checkSign('+');
            sign = '+';
        }

        private void buttDot_Click(object sender, RoutedEventArgs e)
        {
            if (!Current.Contains('.')) Current = ".";
        }

        private void butt0_Click(object sender, RoutedEventArgs e)
        {
            Current = "0";
        }

        private void buttEq_Click(object sender, RoutedEventArgs e)
        {
            CurrentNum = Decimal.Parse(Current, CultureInfo.InvariantCulture);
            try
            {
                checked
                {
                    switch (sign)
                    {
                        case '+':
                            clear = true;
                            Current = (PreviousNum + CurrentNum).ToString(CultureInfo.InvariantCulture);
                            break;
                        case '-':
                            clear = true;
                            Current = (PreviousNum - CurrentNum).ToString(CultureInfo.InvariantCulture);
                            break;
                        case '*':
                            clear = true;
                            Current = (PreviousNum * CurrentNum).ToString(CultureInfo.InvariantCulture);
                            break;
                        case '/':
                            clear = true;
                            Current = (PreviousNum / CurrentNum).ToString(CultureInfo.InvariantCulture);
                            break;
                    }
                }
            }
            catch (DivideByZeroException)
            {
                Current = "Cannot divide by zero";
            }

            catch (OverflowException)
            {
                Current = "Number is too big";
            }

            sign = ' ';
            clear = true;
            clearRes = true;
            Result = " ";
            PreviousNum = 0;
        }
    }
}