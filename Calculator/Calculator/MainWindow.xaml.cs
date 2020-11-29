using System;
using System.Collections.Generic;
using System.Globalization;
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
        Calculate calculate = new Calculate();

        static List<string> mathOperatorList = new List<string>()
        {
            "+", "-", "X", "/", "^", "√", "EXP"
        };
        static List<string> inputList = new List<string>();
        static TextBlock outputScreen = new TextBlock
        {
            FontSize = 70,
            HorizontalAlignment = HorizontalAlignment.Right,
            Foreground = Brushes.White
        };
        TextBlock inputScreen = new TextBlock
        {
            Text = "",
            FontSize = 70,
            Foreground = Brushes.White
        };

        static Viewbox inputView = new Viewbox
        {
            HorizontalAlignment = HorizontalAlignment.Left
        };
        static Viewbox outputView = new Viewbox
        {
            HorizontalAlignment = HorizontalAlignment.Right
        };

        public MainWindow()
        {
            InitializeComponent();

            int rowAmount = 7;
            int columnAmount = 5;
            for (int i = 0; i < rowAmount; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < columnAmount; i++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());

            }
            mainGrid.Children.Add(inputView);
            mainGrid.Children.Add(outputView);

            inputView.Child = inputScreen;
            outputView.Child = outputScreen;

            inputView.SetValue(Grid.RowProperty, 0);
            inputView.SetValue(Grid.ColumnProperty, 0);
            inputView.SetValue(Grid.ColumnSpanProperty, 5);
            outputView.SetValue(Grid.RowProperty, 1);
            outputView.SetValue(Grid.ColumnProperty, 0);
            outputView.SetValue(Grid.ColumnSpanProperty, 5);

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
            inputScreen.Text = null;
            if (e.Source is Button button)
            {
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
                    outputScreen.Text = null;
                }
                else if (button.Content.ToString() == "Exit")
                {
                    Application.Current.Shutdown();
                }
                else if (button.Content.ToString() == "EXE" && inputList.Any())
                {
                    functionProcessing();
                }
                else if (mathOperatorList.Contains(button.Content.ToString()))
                {
                    if (!(!inputList.Any() || mathOperatorList.Contains(inputList[inputList.Count - 1])))
                    {
                        inputList.Add(button.Content.ToString());
                        //dont add operator, "+/" or "-*"because it is not valid
                    }
                }
                else
                {
                    if (button.Content.ToString() != "EXE")
                    {
                        inputList.Add(button.Content.ToString());
                    }
                }
            }
            for (int i = 0; i < inputList.Count; i++)
            {
                inputScreen.Text += inputList[i];
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
        public void functionProcessing()
        {
            string function = "";
            for (int i = 0; i < inputList.Count; i++)
            {
                function += inputList[i];
            }

            List<double> finalFunction = new List<double>();
            List<double> listOfNumbers = getNumbers(function);
            List<string> listOfOperators = getOperators(function);

            for (int i = 0; i < listOfOperators.Count; i++)
            {
                switch (listOfOperators[i])
                {
                    case "X":
                        finalFunction.Add(listOfNumbers[i] * listOfNumbers[i + 1]);
                        break;
                    case "/":
                        finalFunction.Add(listOfNumbers[i] / listOfNumbers[i + 1]);
                        break;
                    case "+":
                        finalFunction.Add(listOfNumbers[i] + listOfNumbers[i + 1]);
                        break;
                    case "-":
                        //addition with a negative number results in subtraction
                        finalFunction.Add(listOfNumbers[i] + listOfNumbers[i + 1]);
                        break;
                }
            }

            //Final calculation
            
            outputScreen.Text = Math.Round(calculate.addNumbers(finalFunction), 8).ToString(); //problem is that numbers that already been multiplied is added or subtracted in next step
            finalFunction.Clear();
            inputList.Clear();
        }
        public List<double> getNumbers(string function)
        {
            var numbers = function.Split('+', 'X', '/');
            List<double> listOfNumbers = new List<double>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i].Contains('-'))
                {
                    var temp = numbers[i].Split('-');
                    listOfNumbers.Add(double.Parse(temp[0], CultureInfo.InvariantCulture));
                    for (int j = 0; j < temp.Length - 1; j++)
                    {
                        listOfNumbers.Add(double.Parse(temp[j + 1], CultureInfo.InvariantCulture) * (-1));
                    }
                }
                else
                {
                    listOfNumbers.Add(double.Parse(numbers[i], CultureInfo.InvariantCulture));
                }
            }
            return listOfNumbers;
        }
        public List<string> getOperators(string function)
        {
            var mathOperators = function.Split('0', '1', '2', '3', '4', '5', '6', '7', '8', '9', '.');
            List<string> listOfOperators = new List<string>();
            for (int i = 0; i < mathOperators.Length; i++)
            {
                if (mathOperators[i] != "")
                {
                    listOfOperators.Add(mathOperators[i]);
                }
            }
            return listOfOperators;
        }
    }
}

