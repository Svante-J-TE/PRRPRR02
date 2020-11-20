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
        static TextBlock outputScreen = new TextBlock
        {
            Text = "",
            FontSize = 100,

        };
        TextBlock inputScreen = new TextBlock
        {
            Text = "",
            FontSize = 100,
            //Background = Brushes.Black
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
                {"^", "√", "(", ")", "Quit"},
                {"7", "8", "9", "DEL", "AC"},
                {"4", "5", "6", "X", "/"},
                {"1", "2", "3", "+", "-"},
                {"0", ".", "EXP", "(-)", "EXE"}
            };

            for (int i = 0; i < buttonContent.GetLength(0); i++)
            {
                for (int j = 0; j < buttonContent.GetLength(1); j++)
                {
                    Button btn = new Button {
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
                inputScreen.Text += button.Content;
            }
        }
    }
}
