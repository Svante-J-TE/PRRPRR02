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

namespace AstrologyFinder
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            int rowAmount = 3;
            int columnAmount = 3;
            for (int i = 0; i < rowAmount; i++)
            {
                mainGrid.RowDefinitions.Add(new RowDefinition());
            }
            for (int i = 0; i < columnAmount; i++)
            {
                mainGrid.ColumnDefinitions.Add(new ColumnDefinition());

            }
            var inputLabel = new TextBlock();
            inputLabel.Text = "Input your birth day and month (ex. 2/10)";
            inputLabel.VerticalAlignment = VerticalAlignment.Center;
            inputLabel.HorizontalAlignment = HorizontalAlignment.Center;
            inputLabel.TextWrapping = TextWrapping.Wrap;
            inputLabel.FontSize = 25;
            inputLabel.SetValue(Grid.RowProperty, 0);
            inputLabel.SetValue(Grid.ColumnProperty, 1);

            var birthdayInput = new TextBox();
            birthdayInput.BorderBrush = Brushes.Blue;
            birthdayInput.VerticalAlignment = VerticalAlignment.Center;
            birthdayInput.FontSize = 40;
            birthdayInput.SetValue(Grid.RowProperty, 1);
            birthdayInput.SetValue(Grid.ColumnProperty, 1);

            var dayBox = new ComboBox();
            dayBox.SetValue(Grid.RowProperty, 2);
            dayBox.SetValue(Grid.ColumnProperty, 2);
            dayBox.ItemsSource = new List<string> { "Item1", "Item2", "Item3" };

            var submitBtn = new Button();
            submitBtn.Content = "Submit";
            submitBtn.FontSize = 25;
            submitBtn.SetValue(Grid.RowProperty, 2);
            submitBtn.SetValue(Grid.ColumnProperty, 1);
            submitBtn.Width = 150;
            submitBtn.Height = 75;

            /*
            var imageLeft = new Image();
            imageLeft.Source = new BitmapImage(new Uri(@"./signs.png", UriKind.Relative));
            imageLeft.SetValue(Grid.RowProperty, 0);
            imageLeft.SetValue(Grid.ColumnProperty, 0);
            imageLeft.SetValue(Grid.RowSpanProperty, 2);

            var imageRigth = new Image();
            imageRigth.Source = new BitmapImage(new Uri("D:\\Documents\\GitHub\\PRRPRR02\\AstrologyFinder\\signs.png"));
            imageRigth.SetValue(Grid.RowProperty, 0);
            imageRigth.SetValue(Grid.ColumnProperty, 2);
            imageRigth.SetValue(Grid.RowSpanProperty, 2);
            */

            mainGrid.Children.Add(birthdayInput);
            mainGrid.Children.Add(inputLabel);
            mainGrid.Children.Add(submitBtn);
            /*
            mainGrid.Children.Add(imageLeft);
            mainGrid.Children.Add(imageRigth);
            */
            mainGrid.Children.Add(dayBox);
        }
    }
}
