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
        public MainWindow()
        {
            TextBlock screen = new TextBlock
            {
                Text = "hej hej detta är ett test",
                FontSize = 100
            };
            

            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
                mainGrid.RowDefinitions.Add(new RowDefinition());
            }
            mainGrid.RowDefinitions[0].Height = new GridLength(2.0, GridUnitType.Star);
            mainGrid.Children.Add(screen);
            screen.SetValue(Grid.RowProperty, 0);
            screen.SetValue(Grid.ColumnProperty, 0);
            screen.SetValue(Grid.ColumnSpanProperty, 5);
            
            
            for (int i = 0; i < 10; i++)
            {
                String btnName = "btn" + i.ToString();
                Button btn = new Button
                {
                    Name = btnName,
                    Content = i
                };


                mainGrid.Children.Add(btn);
                btn.SetValue(Grid.RowProperty, 4 - i/3);
                btn.SetValue(Grid.ColumnProperty, 0 + i % 3);
                /*if(btn.Content.ToString() == "0")
                {
                    btn.SetValue(Grid.RowProperty, 4);
                    btn.SetValue(Grid.ColumnProperty, 2);
                }
                else
                {
                    btn.SetValue(Grid.RowProperty, 3 + i/3);
                    btn.SetValue(Grid.ColumnProperty, 3 + i%3);
                }*/

            }
        }
    }
}
