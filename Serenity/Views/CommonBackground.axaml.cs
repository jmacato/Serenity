using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace Serenity.Views;

public partial class CommonBackground : UserControl
{
    public CommonBackground()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}