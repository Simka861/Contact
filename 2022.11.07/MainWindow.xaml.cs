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
            if (FirstName_textBox.Text != "" && LastName_textBox.Text != "" && Phone_textBox.Text != "" && Email_textBox.Text != "" && Phone_textBox.Text.Length >= 7)
            {


                listView1.Items.Add(FirstName_textBox.Text + " " + LastName_textBox.Text + " (" + comboBox1.Text + ") " + Phone_textBox.Text + " " + Email_textBox.Text);
            }
            
              listView1.Items.Add("Marry " + "Georgy "+  "(911) " + "9875634 " + "rejsd@mail.com");
            listView1.Items.Add("Tom " + "Marvolo " + "(544) " + "9999999 " + "LordVolondemort@mail.com");
            listView1.Items.Add("Harry " + "Potter " + "(921) " + "1234567 " + "the_boy_who_survived@gmail.com");
      }

        private void DeleteBut_Click(object sender, RoutedEventArgs e)
        {
            if (listView1.SelectedIndex == -1) return;
            listView1.Items.RemoveAt(listView1.SelectedIndex);
            
        }

        private void EditBut_Click(object sender, RoutedEventArgs e)
        {
            if (listView1.SelectedIndex == -1) return;
            string str = listView1.SelectedItem.ToString();
            string end = " ";
            string str_2 = str;
            int indexOfSubstring = str.IndexOf(end);

            string FirstName_str = str.Substring(0, str.Length - (str.Length - indexOfSubstring));
            FirstName_textBox.Text = FirstName_str;

            //    LastName
            int start = indexOfSubstring + 1;
            str_2 = str.Substring(start);
            indexOfSubstring = str_2.IndexOf(end);
            string LastName = str_2.Substring(0, str_2.Length - (str_2.Length - indexOfSubstring));
            LastName_textBox.Text = LastName;
            LabelName.Content = FirstName_str + " " + LastName;


            //  ComboBox
            start = indexOfSubstring + 1;
            str_2 = str_2.Substring(start);
            indexOfSubstring = str_2.IndexOf(end);
            string ComnoBoxs = str_2.Substring(1, str_2.Length - (str_2.Length - indexOfSubstring) - 2);
            comboBox1.Text = ComnoBoxs;

            // Phone_textBox
            start = indexOfSubstring + 1;
            str_2 = str_2.Substring(start);
            indexOfSubstring = str_2.IndexOf(end);
            string Phones = str_2.Substring(0, str_2.Length - (str_2.Length - indexOfSubstring));
            Phone_textBox.Text = Phones;
            LabelPhone.Content = "(" + ComnoBoxs + ") " + Phones;

            //Email_textBox
            start = indexOfSubstring + 1;
            str_2 = str_2.Substring(start);
            indexOfSubstring = str_2.IndexOf(end);
            Email_textBox.Text = str_2;
            LabelEmail.Content = str_2;

            listView1.Items.RemoveAt(listView1.SelectedIndex);

        }

        private void CanselBut_Click(object sender, RoutedEventArgs e)
        {
            FirstName_textBox.Text = "";
            LastName_textBox.Text = "";
            Phone_textBox.Text = "";
            Email_textBox.Text = "";
            comboBox1.Text = "";
        }
    }
}
