using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Microsoft.Win32;

namespace PortableInstaller;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TargetExecutableBrowseButton_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFileDialog
        {
            Title = "Select Target Executable...",
            Filter = "Executable files (*.exe)|*.exe"
        };

        if (dialog.ShowDialog() == true)
        {
            TargetExecutableInput.Text = dialog.FileName;            
        }
    }

    private void UseParentDirectoryCheckBox_OnChecked(object sender, RoutedEventArgs e)
    {
        ParentDirectoryInput.IsEnabled = true;
        ParentDirectoryBrowseButton.IsEnabled = true;
    }

    private void UseParentDirectoryCheckBox_OnUnchecked(object sender, RoutedEventArgs e)
    {
        ParentDirectoryInput.IsEnabled = false;
        ParentDirectoryBrowseButton.IsEnabled = false;
    }

    private void ParentDirectoryBrowseButton_OnClick(object sender, RoutedEventArgs e)
    {
        var dialog = new OpenFolderDialog
        {
            Title = "Select Parent Directory...",
            InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        };

        if (dialog.ShowDialog() == true)
        {
            ParentDirectoryInput.Text = dialog.FolderName;
        }
    }

    private void InstallButton_OnClick(object sender, RoutedEventArgs e)
    {
        throw new NotImplementedException();
    }
}