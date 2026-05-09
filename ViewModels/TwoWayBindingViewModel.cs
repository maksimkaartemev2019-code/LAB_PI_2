using System.Windows.Controls;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LAB_PI_2.ViewModels;

public sealed partial class TwoWayBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string liveText = "Меняется сразу";

    [ObservableProperty]
    private string lostFocusText = "Меняется после потери фокуса";

    [ObservableProperty]
    private string explicitText = "Ждет команду";

    [ObservableProperty]
    private double volume = 42;

    [ObservableProperty]
    private string summary = "Измените поля, чтобы увидеть TwoWay и UpdateSourceTrigger.";

    [RelayCommand]
    private void ApplyExplicit(TextBox? textBox)
    {
        textBox?.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
        Summary = $"Explicit обновлен командой: {ExplicitText}";
    }

    [RelayCommand]
    private void Describe()
    {
        Summary = $"Live='{LiveText}', LostFocus='{LostFocusText}', Explicit='{ExplicitText}', Slider={Volume:0}";
    }
}
