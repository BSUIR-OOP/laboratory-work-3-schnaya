using Lab3.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Windows;

namespace Lab3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        LanguageList langList = new LanguageList();
        public MainWindow()
        {
            InitializeComponent();
            ChooseLanguage.Items.Add(new Assembler());
            ChooseLanguage.Items.Add(new Clang());
            ChooseLanguage.Items.Add(new CPlusPlus());
            ChooseLanguage.Items.Add(new SQLlang());
            ChooseLanguage.Items.Add(new Javalang());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Type type = ChooseLanguage.SelectedItem.GetType();
            Languages l = (Languages)Activator.CreateInstance(type);
            if (l != null)
            {
                l.Languagename = AddLanguagename.Text;
                l.YearOfCreation = Convert.ToInt32(AddYearOfCreation.Text);
                l.Type = AddType.Text;
            }
            languagesList.Add(t);
            ShowLanguages.Items.Clear();
            foreach (Languages lang in languagesList)
                ShowLanguages.Items.Add(tr.ShowInfo());
        }

        private void Serialize_Click(object sender, RoutedEventArgs e)
        {
            JsonSerializator s = new JsonSerializator();
            File.WriteAllText(FileToSerialize.Text, s.Serialize(langerstList));
        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {
            =languagesList.Remove(languagesList.Get(ShowLanguages.SelectedIndex));
            ShowLanguages.Items.Clear();
            foreach (Languages lang in languagesList)
                 ShowLanguages.Items.Add(tr.ShowInfo());
        }

        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            Languages l = languagesList.Get(ShowLanguages.SelectedIndex);
            l.Languagename = EditLanguagename.Text;
            l.YearOfCreation = Convert.ToInt32(EditYearOfCreation.Text);
            l.Type = EditType.Text;
            ShowLanguages.Items.Clear();
            foreach (Languages lang in languagesList)
                ShowLanguages.Items.Add(tr.ShowInfo());
        }

        private void Deserialize_Click(object sender, RoutedEventArgs e)
        {
            JsonSerializator s = new JsonSerializator();
            LanguagesList tmp = s.Deserialize(File.ReadAllText(FileToDeserialize.Text));
            foreach (Languages lang in tmp)
                =languagesList.Add(tr);
            ShowLanguages.Items.Clear();
            foreach (Languages lang in languagesList)
                ShowLanguages.Items.Add(tr.ShowInfo());
        }
    }
}
