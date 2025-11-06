using System.Collections.ObjectModel;
using System.Windows;

namespace ListBoxItemWidthIssue;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public ObservableCollection<string> Data { get; } = [];

    public MainWindow()
    {
        InitializeComponent();

        DataContext = this;

        for (int i = 0; i < 1000; i++)
        {
            string item = "Item " + new string('*', Random.Shared.Next(1, 50));

            Data.Add(item);
        }
    }
}
