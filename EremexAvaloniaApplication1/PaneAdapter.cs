using System;
using Avalonia.Markup.Xaml;
using Eremex.AvaloniaUI.Controls.Docking;

namespace EremexAvaloniaApplication1;

public class PaneAdapter : MarkupExtension, IDockManagerItemAdapter
{
    public void Adapt(DockManager dockManager, DockItemBase container, object item)
    {
        var target = dockManager.FindItem<DockGroup>(container is DocumentPane ? "documenthost" : "panehost"); 
        target?.Add(container);
    }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        return this;
    }
}