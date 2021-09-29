using ErrObserver.Rgx;
using ErrObserver.TextBoxMethods;
using ErrObserver.Validation;
using System;
using System.Collections.Generic;
using System.IO;
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

        inputStatus inputStatus;

        public MainWindow()
        {
            InitializeComponent();

            inputStatus = new inputStatus(); //assign all attributes to false
            
            this.sslOptions.ItemsSource = sslOptionsList;
            this.sslOptions.SelectedIndex = 1;
        }

        private void validTextBoxesInput(object sender, KeyEventArgs e)
        {
            var TextBox = sender as TextBox;
            var result = default(bool);
            var text = TextBox.Text;
            var name = TextBox.Name;
            switch (name)
            {
                case "emailAddr":
                    result = ValidationCl.checkEmailAddr(ref text);
                    inputStatus.EmailAddr = result;
                    TextBoxes.setUpCorrectColor(ref result, TextBox);
                    break;
                case "To":
                    result = ValidationCl.checkEmailAddr(ref text);
                    inputStatus.To = result;
                    TextBoxes.setUpCorrectColor(ref result, TextBox);
                    break;
                case "smtpNumber":
                    result = ValidationCl.checkSMTPPort(ref text);
                    inputStatus.SmtpNumber = result;
                    TextBoxes.setUpCorrectColor(ref result, TextBox);
                    break;
                case "extenstion":
                    result = ValidationCl.checkExtension(ref text);
                    inputStatus.Extension = result;
                    TextBoxes.setUpCorrectColor(ref result, TextBox);
                    break;
                case "smtpHost":
                    result = ValidationCl.checkSMTPHost(ref text);
                    inputStatus.SmtpHost = result;
                    TextBoxes.setUpCorrectColor(ref result, TextBox);
                    break;
            }
        }
        
        private void textBoxClickController(object sender, EventArgs e)
        {
            var TextBox = sender as TextBox;
            var name = TextBox.Name;
            switch (name)
            {
                case "filepath":
                    
                    break;
                case "emailTestBtn":
                    break;
            }
        }

        private void btnController(object sender, EventArgs e)
        {
            var button = sender as Button;
            var name = button.Name;
            switch (name)
            {
                case "addBtn":
                    var path = this.dirPath.Text;
                    var length = path.Length;
                    if (length > 0 && Directory.Exists(path))
                        this.filepathList.Items.Add(path);
                    else
                        MessageBox.Show("Brak poprawnej ścieżki lub katalog nie istnieje", "Informacja", MessageBoxButton.OK, MessageBoxImage.Information);
                    break;
                case "emailTestBtn":
                    if (inputStatus.isAllValuesinitialised() == true)
                        MessageBox.Show("OK");
                    else
                        MessageBox.Show("Nie wszystko zostało wypełnione poprawnie", "INFORMACJA", MessageBoxButton.OK, MessageBoxImage.Hand);
                    break;
            }
        }
    }
}
