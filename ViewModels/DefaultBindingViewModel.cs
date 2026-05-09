using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LAB_PI_2.ViewModels;

public sealed partial class DefaultBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string userName = "Алексей";

    [ObservableProperty]
    private double progress = 35;

    [ObservableProperty]
    private bool notificationsEnabled = true;

    [ObservableProperty]
    private string selectedRole = "Разработчик";

    [ObservableProperty]
    private string commandResult = "Команда еще не выполнялась";

    public ObservableCollection<string> Roles { get; } = new() { "Разработчик", "Тестировщик", "Аналитик" };

    [RelayCommand]
    private void Apply()
    {
        CommandResult = $"Применено: {UserName}, {SelectedRole}, {Progress:0}%";
    }

    [RelayCommand]
    private void Reset()
    {
        UserName = "Алексей";
        Progress = 35;
        NotificationsEnabled = true;
        SelectedRole = Roles[0];
        CommandResult = "Значения сброшены командой";
    }
}
