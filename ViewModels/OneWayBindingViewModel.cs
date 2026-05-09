using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LAB_PI_2.ViewModels;

public sealed partial class OneWayBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string sourceMessage = "Данные идут из ViewModel в интерфейс";

    [ObservableProperty]
    private double temperature = 21;

    [ObservableProperty]
    private bool isAvailable = true;

    [ObservableProperty]
    private int changesCount;

    [RelayCommand]
    private void ChangeSource()
    {
        ChangesCount++;
        Temperature = 18 + ChangesCount * 3;
        IsAvailable = !IsAvailable;
        SourceMessage = $"Источник обновлен командой #{ChangesCount}";
    }
}
