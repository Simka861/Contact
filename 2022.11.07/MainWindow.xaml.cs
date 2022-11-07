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

namespace _2022._11._07
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SaveBut_Click(object sender, RoutedEventArgs e)
        {
            if(FirstName_textBox.Text != ""&& LastName_textBox.Text != "" && Phone_textBox.Text != "" && Email_textBox.Text != "" && Phone_textBox.Text.Length >= 7)
            {
             
          
                listView1.Items.Add(FirstName_textBox.Text+ " " + LastName_textBox.Text+ " (" + comboBox1.Text + ") " + Phone_textBox.Text + " " + Email_textBox.Text );
            } 
        }


        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            listView1.
        }
    }
}
