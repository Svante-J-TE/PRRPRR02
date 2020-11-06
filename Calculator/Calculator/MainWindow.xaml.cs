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
            Button btnOne = new Button();
            Button btnTwo = new Button();
            Button btnThree = new Button();
            Button btnFour = new Button();
            Button btnFive = new Button();
            Button btnSix = new Button();
            Button btnSeven = new Button();
            Button btnEigth = new Button();
            Button btnNine = new Button();
            Button btnZero = new Button();

            InitializeComponent();
            for (int i = 0; i < 5; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());
            }
            
            mainGrid.Children.Add(new Button());
            mainGrid.Children.Add(new Button());
            mainGrid.Children.Add(new Button());
            mainGrid.Children.Add(new Button());
            mainGrid.Children[5].SetValue(Name = "test");


            
            
        }
    }
}
