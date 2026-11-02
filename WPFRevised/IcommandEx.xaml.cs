using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFRevised
{
    /// <summary>
    /// Interaction logic for IcommandEx.xaml
    /// </summary>
    public partial class IcommandEx : Window
    {
        public IcommandEx()
        {
            InitializeComponent();

            ICommand MyCommand= new MyCommand();
            //this.DataContext = MyCommand;
        }
    }


    public class MyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        public bool CanExecute(object parameter)
        {
            // You can add logic here to determine if the command can execute
            return true;
        }
        public void Execute(object parameter)
        {
            string input = parameter as string;
            MessageBox.Show($"You entered: {input}");
        }
    }
}
