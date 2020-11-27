using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static List<string> mathOperatorList = new List<string>()
        {
            "+", "-", "X", "/", "^", "√", "EXP"
        };
        static List<string> inputList = new List<string>();
        static string inputString = "";
        static TextBlock outputScreen = new TextBlock
        {
            Text = "0",
            FontSize = 100,
            HorizontalAlignment = HorizontalAlignment.Right,
            Background = Brushes.Black,
            Foreground = Brushes.White
        };
        TextBlock inputScreen = new TextBlock
        {
            Text = "",
            FontSize = 100,
            Background = Brushes.Black,
            Foreground = Brushes.White
        };

        public MainWindow()
        {
            InitializeComponent();

            var expressionModel = new ExpressionModel();

            expressionModel.MyProperty = 1;

            for (int i = 0; i < 7; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < 5; i++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());

            }
            //mainGrid.RowDefinitions[0].Height = new GridLength(2.0, GridUnitType.Star);
            mainGrid.Children.Add(inputScreen);
            inputScreen.SetValue(Grid.RowProperty, 0);
            inputScreen.SetValue(Grid.ColumnProperty, 0);
            inputScreen.SetValue(Grid.ColumnSpanProperty, 5);
            mainGrid.Children.Add(outputScreen);
            outputScreen.SetValue(Grid.RowProperty, 1);
            outputScreen.SetValue(Grid.ColumnProperty, 0);
            outputScreen.SetValue(Grid.ColumnSpanProperty, 5);




            var button = new Button();
            button.Content = "1";

            string[,] buttonContent = new string[,]
            {
                {"^", "√", "(", ")", "Exit"},
                {"7", "8", "9", "DEL", "AC"},
                {"4", "5", "6", "X", "/"},
                {"1", "2", "3", "+", "-"},
                {"0", ".", "EXP", "(-)", "EXE"}
            };

            for (int i = 0; i < buttonContent.GetLength(0); i++)
            {
                for (int j = 0; j < buttonContent.GetLength(1); j++)
                {
                    Button btn = new Button
                    {
                        Content = buttonContent[i, j],
                    };
                    btn.SetValue(Grid.RowProperty, i + 2);
                    btn.SetValue(Grid.ColumnProperty, j);
                    btn.Click += new RoutedEventHandler(Button_Clicked);
                    mainGrid.Children.Add(btn);
                }
            }



        }

        public void Button_Clicked(object sender, RoutedEventArgs e)
        {

            if (e.Source is Button button)
            {
                inputScreen.Text = "";

                if (button.Content.ToString() == "DEL")
                {
                    if (checkLength() == true)
                    {
                        inputList.RemoveAt(inputList.Count - 1);
                    }
                }
                else if (button.Content.ToString() == "AC")
                {
                    inputList.Clear();
                }
                else if (button.Content.ToString() == "EXE")
                {
                    if (checkLength() == true)
                    {
                        testMethod();
                        //outputScreen.Text += testMethod();
                    }
                }
                else if (button.Content.ToString() == "Exit")
                {
                    Application.Current.Shutdown();
                }
                else if (mathOperatorList.Contains(button.Content.ToString()))
                {
                    if (mathOperatorList.Contains(inputList[inputList.Count - 1]))
                    {
                        //dont add operator, "+/" or "-*" is not valid
                    }
                    else
                    {
                        inputList.Add(button.Content.ToString());
                        inputString += button.Content.ToString();
                    }
                }
                else
                {
                    inputList.Add(button.Content.ToString());
                    inputString += button.Content.ToString();
                }
                for (int i = 0; i < inputList.Count; i++)
                {
                    inputScreen.Text += inputList[i];
                }
            }
        }

        public bool checkLength()
        {
            int length = inputList.Count - 1;
            if (inputList.Count == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public double prepareCalc()
        {
            double output = 0;
            List<double> numberList = new List<double>();
            List<string> mathOpList = new List<string>();
            for (int i = 0; i < inputList.Count; i++)
            {
                if (IsNumber(inputList[i]) == true)
                {
                    numberList.Add(Convert.ToDouble(inputList[i]));
                    mathOpList.Add("");
                }
                else
                {
                    numberList.Add(double.NaN);
                    mathOpList.Add(inputList[i]);
                }
            }
            calculate(numberList, mathOpList);
            return output;
        }
        public void calculate(List<double> one, List<string> two)
        {
            int amount;
            if (one.Count >= two.Count)
            {
                amount = one.Count;
            }
            else
            {
                amount = two.Count;
            }
            for (int i = 0; i < amount; i++)
            {
                //varanan lista läggs till för att få uträkningen som ska calcyleras med siffror och annat
            }
        }

        public static bool IsNumber(string num)
        {
            return num.All(char.IsDigit);
        }

        public void testMethod()
        {
            double jointNumber = Convert.ToDouble(outputScreen.Text);
            var primaryCalculations = inputString.Split('X', '/');
            var secondaryCalculations = inputString.Split('+', '-');
            List<double> temp = new List<double>();
            List<double> calcs = new List<double>();

            if (inputString.Contains("X"))
            {
                for (int i = 0; i < secondaryCalculations.Length; i++)
                {
                    if (secondaryCalculations[i].Contains("X"))
                    {
                        var tmp = secondaryCalculations[i].Split('X');
                        for (int j = 0; j < tmp.Length; j++)
                        {
                            temp.Add(Convert.ToDouble(tmp[j]));
                        }
                        calcs.Add(temp[0] * temp[1]);
                    }
                }
                //jointNumber = (Convert.ToDouble(primaryCalculations[0]) * Convert.ToDouble(primaryCalculations[1]));
            }
            if (inputString.Contains("/"))
            {
                for (int i = 0; i < secondaryCalculations.Length; i++)
                {
                    if (secondaryCalculations[i].Contains("/"))
                    {
                        var tmp = secondaryCalculations[i].Split('/');
                        for (int j = 0; j < tmp.Length; j++)
                        {
                            temp.Add(Convert.ToDouble(tmp[j]));
                        }
                        calcs.Add(temp[0] / temp[1]);
                    }
                }
                //jointNumber = (Convert.ToDouble(primaryCalculations[0]) / Convert.ToDouble(primaryCalculations[1]));
            }
            if (inputString.Contains("+"))
            {
                for (int i = 0; i < primaryCalculations.Length; i++)
                {
                    if (primaryCalculations[i].Contains("+"))
                    {
                        var tmp = primaryCalculations[i].Split('+');
                        for (int j = 0; j < tmp.Length; j++)
                        {
                            temp.Add(Convert.ToDouble(tmp[j]));
                        }
                        calcs.Add(temp[0] + temp[1]);
                    }
                }
                //jointNumber = (Convert.ToDouble(secondaryCalculations[0]) + Convert.ToDouble(secondaryCalculations[1]));
            }
            if (inputString.Contains("-"))
            {
                for (int i = 0; i < primaryCalculations.Length; i++)
                {
                    if (primaryCalculations[i].Contains("-"))
                    {
                        var tmp = primaryCalculations[i].Split('-');
                        for (int j = 0; j < tmp.Length; j++)
                        {
                            temp.Add(Convert.ToDouble(tmp[j]));
                        }
                        calcs.Add(temp[0] - temp[1]);
                    }
                }
                //jointNumber = (Convert.ToDouble(secondaryCalculations[0]) - Convert.ToDouble(secondaryCalculations[1]));
            }
            for (int i = 0; i < calcs.Count; i++)
            {
                jointNumber += calcs[i];
            }
            //problem is that numbers that already been multiplied is added or subtracted in next step
            outputScreen.Text = jointNumber.ToString();
            inputString = "";
        }

    }
}

