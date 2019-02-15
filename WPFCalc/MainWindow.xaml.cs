using System;
using System.Collections.Generic;
using System.Linq;
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

namespace WPFCalc
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string leftOper;
        private string rightOper;
        private string oper;
        private string result;

        public MainWindow()
        {
            InitializeComponent();

            disblayTextBlock.Text = "0";
        }

        #region numButtons

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            if(leftOper==null)
            {
                leftOper = 1.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if(oper!=null)
            {
                rightOper = 1.ToString();
                disblayTextBlock.Text = leftOper+oper+rightOper;
            }
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 2.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 2.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 3.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 3.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        private void button4_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 4.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 4.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 5.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 5.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 6.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 6.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 7.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 7.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 8.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 8.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper == null)
            {
                leftOper = 9.ToString();
                disblayTextBlock.Text = leftOper;
            }
            else if (oper != null)
            {
                rightOper = 9.ToString();
                disblayTextBlock.Text = leftOper + oper + rightOper;
            }
        }

        #endregion

        #region operButtons

        private void buttonPlus_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper != null)
            {
                oper = "+";
                disblayTextBlock.Text = leftOper + oper;
            }
        }

        private void buttonMinus_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper != null)
            {
                oper = "-";
                disblayTextBlock.Text = leftOper + oper;
            }
        }

        private void buttonMulty_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper != null)
            {
                oper = "*";
                disblayTextBlock.Text = leftOper + oper;
            }
        }

        private void buttonDiv_Click(object sender, RoutedEventArgs e)
        {
            if (leftOper != null)
            {
                oper = @"/";
                disblayTextBlock.Text = leftOper + oper;
            }
        }




        #endregion

        #region Control Buttons

        private void buttonClear_Click(object sender, RoutedEventArgs e)
        {
            leftOper = null;
            rightOper = null;
            oper = null;

            disblayTextBlock.Text = "0";
        }

        private void buttonResult_Click(object sender, RoutedEventArgs e)
        {
            if ((leftOper != null) && (oper != null) && (rightOper != null))
            {
                switch (oper)
                {
                    case "+":
                        result = leftOper + oper + rightOper + "=" + $"{Int64.Parse(leftOper) + Int64.Parse(rightOper)}";
                        break;
                    case "-":
                        result = leftOper + oper + rightOper + "=" + $"{Int64.Parse(leftOper) - Int64.Parse(rightOper)}";
                        break;
                    case "*":
                        result = leftOper + oper + rightOper + "=" + $"{Int64.Parse(leftOper) * Int64.Parse(rightOper)}";
                        break;
                    case @"/":
                        result = leftOper + oper + rightOper + "=" + $"{Double.Parse(leftOper) / Double.Parse(rightOper)}";
                        break;
                }

                if(result!=null)
                {
                    disblayTextBlock.Text = result;
                    result = null;
                    leftOper = null;
                    rightOper = null;
                    oper = null;
                }
            }
        }

        #endregion
    }
}
