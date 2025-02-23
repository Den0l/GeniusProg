﻿using System.Configuration;
using System.Data;
using System.Windows;

namespace GeniusProg
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

        private static string theme;

        public static string Theme
        {
            get { return theme; }
            set 
            { 
                theme = value;
                var dict = new ResourceDictionary { Source = new Uri($"pack://application:,,,/ThemesLibrary;component/Resources/{value}.xaml", UriKind.Absolute) };

                Current.Resources.MergedDictionaries.RemoveAt(0);
                Current.Resources.MergedDictionaries.Insert(0, dict);
            }
        }

        public App() 
        { 
            InitializeComponent();
        }
    }

}
