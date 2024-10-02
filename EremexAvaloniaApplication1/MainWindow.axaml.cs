using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using DynamicData;
using Eremex.AvaloniaUI.Controls.Common;

namespace EremexAvaloniaApplication1;

public partial class MainWindow : MxWindow
{
    public MainWindow()
    {
        var viewModel = new MainViewModel();
        viewModel.Panes.AddRange(new PaneViewModelBase[]
        {
            new DockPanePaneViewModel() { Header = "Pane1" },
            new DockPanePaneViewModel() { Header = "Pane2" },
            new DockPanePaneViewModel() { Header = "Pane3" },
            new DocumentPaneViewModel() { Header = "Doc1" },
            new DocumentPaneViewModel() { Header = "Doc2" }
        });
        DataContext = viewModel;
        
        InitializeComponent();
    }
}