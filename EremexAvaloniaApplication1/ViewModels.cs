using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;

namespace EremexAvaloniaApplication1;

public class MainViewModel : ObservableObject
{
    public ObservableCollection<PaneViewModelBase> Panes { get; } = new();
}

public partial class PaneViewModelBase : ObservableObject
{
    [ObservableProperty] private string? header;
}

public class DockPanePaneViewModel : PaneViewModelBase { }

public class DocumentPaneViewModel : PaneViewModelBase { }
