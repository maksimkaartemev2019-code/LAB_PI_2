using System.Windows;
using LAB_PI_2.ViewModels;

namespace LAB_PI_2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        DataContext = new MainViewModel();
    }
}
