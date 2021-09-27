using ErrObserver.Rgx;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace ErrObserver
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> sslOptionsList = new List<string> { "TAK", "NIE" };

        public MainWindow()
        {
            InitializeComponent();

            this.sslOptions.ItemsSource = sslOptionsList;
            this.sslOptions.SelectedIndex = 1;
        }

        private void emailAddr_KeyUp(object sender, KeyEventArgs e)
        {
            var result = default(bool);
            var textBox = sender as TextBox;
            var text = textBox.Text;

            result = ValidationCl.checkEmailAddr(ref text);
            if (result == false)
                textBox.Foreground = Brushes.Red;
            else
                textBox.Foreground = Brushes.Blue;
        }

        private void textBoxClickController(object sender, EventArgs e)
        {
            var TextBox = sender as TextBox;
            var name = TextBox.Name;
            switch (name)
            {
                case "filepath":
                    break;
            }
        }

        private void btnController(object sender, EventArgs e)
        {
            var button = sender as Button;
            var name = button.Name;
            switch(name)
            {
                case "addBtn":
                    var path = this.filepath.Text;
                    this.filepathList.Items.Add(path);
                    break;
            }    
        }
    }
}
