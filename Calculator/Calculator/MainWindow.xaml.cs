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
            TextBlock screen = new TextBlock();

            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
                
            }
            mainGrid.RowDefinitions[0].Height = new GridLength(2.0, GridUnitType.Star);
            
            for (int i = 0; i < 10; i++)
            {
                Button btn = new Button();
                String btnName = "btn" + i.ToString();
                btn.Name = btnName;
                btn.Content = i;
                
                mainGrid.Children.Add(btn);
                btn.SetValue(Grid.RowProperty, 3 - (i/3));
                btn.SetValue(Grid.ColumnProperty, 3 - (i%3));
            }
        }
    }
}
