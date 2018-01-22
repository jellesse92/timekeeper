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

namespace inTime
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {

            Console.Write("hi");
            TimeKeeper.FileController fc = new TimeKeeper.FileController();
            TimeKeeper.Activity newAct = new TimeKeeper.Activity();
            newAct.name = "Jasmine Activity";
            newAct.category = "Lazy Time";
            fc.writeActivity(newAct);
            newAct.name = "Another Activity";

            fc.writeActivity(newAct);
            Console.ReadLine();
            InitializeComponent();
            
        }

        private void createNew_Click(object sender, RoutedEventArgs e)
        {

        }

        private void startActivity_Click(object sender, RoutedEventArgs e)
        {

        }

        private void endActivity_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Console.WriteLine(e.AddedItems[0].GetType());
        }
    }
}
