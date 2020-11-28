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
        Calculate calculate = new Calculate();

        static List<string> mathOperatorList = new List<string>()
        {
            "+", "-", "X", "/", "^", "√", "EXP"
        };
        static List<string> inputList = new List<string>();
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
            inputScreen.Text = "";
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
                }
                else if (button.Content.ToString() == "Exit")
                {
                    Application.Current.Shutdown();
                }
                else if(button.Content.ToString() == "EXE" && inputList.Any())
                {
                    testMethod();
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

        
        

        public static bool IsNumber(string num)
        {
            return num.All(char.IsDigit);
        }

        public void testMethod()
        {
            string function = "";
            for (int i = 0; i < inputList.Count; i++)
            {
                function += inputList[i];
            }
            var primaryCalculations = function.Split('X', '/');
            var secondaryCalculations = function.Split('+', '-');
            List<double> finalFunction = new List<double>();
            List<double> temp = new List<double>();

            double jointNumber = Convert.ToDouble(outputScreen.Text);
            List<double> calcs = new List<double>();
            

            
            
            //For calculating multiplication
            finalCalcPrep(function, "X", secondaryCalculations, finalFunction);
            //For calculating multiplication
            finalCalcPrep(function, "/", secondaryCalculations, finalFunction);
            //For calculating multiplication
            finalCalcPrep(function, "+", primaryCalculations, finalFunction);
            //For calculating multiplication
            finalCalcPrep(function, "-", primaryCalculations, finalFunction);
            //Final calculation
            outputScreen.Text = calculate.addNumbers(finalFunction).ToString();
            finalFunction.Clear();

            //problem is that numbers that already been multiplied is added or subtracted in next step
        }

        public void finalCalcPrep(string function, string op, string[] splitFunction, List<double> finalFunction)
        {
            List<double> temp = new List<double>();
            if (function.Contains(op))
            {
                for (int i = 0; i < splitFunction.Length; i++)
                {
                    if (splitFunction[i].Contains(op))
                    {
                        var tmp = splitFunction[i].Split(op);
                        for (int j = 0; j < tmp.Length; j++)
                        {
                            temp.Add(Convert.ToDouble(tmp[j]));
                        }
                        switch (op)
                        {
                            case "X":
                                finalFunction.Add(temp[0] * temp[1]);
                                break;
                            case "/":
                                finalFunction.Add(temp[0] / temp[1]);
                                break;
                            case "+":
                                finalFunction.Add(temp[0] + temp[1]);
                                break;
                            case "-":
                                finalFunction.Add(temp[0] - temp[1]);
                                break;
                        }
                        temp.Clear();
                    }
                }
            }

        }

    }
}

