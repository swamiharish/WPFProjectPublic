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
    /// Interaction logic for Template.xaml
    /// </summary>
    public partial class Template : Window
    {
        public Person Person { get; set; }
        public Template()
        {
            InitializeComponent();
           // this.DataContext = new Person { Name = "John Doe" };
           Person = new Person { Name = "John Doe" };
            this.DataContext = this;
        }
    }


    public class Person
    {
        public string Name { get; set; }
        
    }
}
