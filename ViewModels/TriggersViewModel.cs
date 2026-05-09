using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LAB_PI_2.ViewModels;

public sealed partial class TriggersViewModel : ObservableObject
{
    [ObservableProperty]
    private bool isImportant;

    [ObservableProperty]
    private bool isConfirmed;

    [ObservableProperty]
    private string status = "Черновик";

    [ObservableProperty]
    private int eventCount;

    [RelayCommand]
    private void ToggleImportant()
    {
        IsImportant = !IsImportant;
    }

    [RelayCommand]
    private void ToggleConfirmed()
    {
        IsConfirmed = !IsConfirmed;
    }

    [RelayCommand]
    private void ChangeStatus()
    {
        Status = Status == "Черновик" ? "Готово" : "Черновик";
    }

    [RelayCommand]
    private void CountEvent()
    {
        EventCount++;
    }
}
