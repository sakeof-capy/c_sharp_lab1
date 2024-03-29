﻿using System;
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
using Lab1.ViewModels;

namespace Lab1.Views
{
    /// <summary>
    /// Interaction logic for DateAnalyzerView.xaml
    /// </summary>
    public partial class DateAnalyzerView : UserControl
    {
        private DateAnalyzerViewModel _vModel;
        public DateAnalyzerView()
        {
            InitializeComponent();
            DataContext = _vModel = new DateAnalyzerViewModel();
        }
    }
}
