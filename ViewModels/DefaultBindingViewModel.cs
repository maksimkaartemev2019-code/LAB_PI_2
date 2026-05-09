using System.Collections.ObjectModel;
using System.Windows.Input;
using LAB_PI_2.Infrastructure;

namespace LAB_PI_2.ViewModels;

public sealed class DefaultBindingViewModel : ObservableObject
{
    private string userName = "Алексей";
    private double progress = 35;
    private bool notificationsEnabled = true;
    private string selectedRole = "Разработчик";
    private string commandResult = "Команда еще не выполнялась";

    public DefaultBindingViewModel()
    {
        ApplyCommand = new RelayCommand(_ => CommandResult = $"Применено: {UserName}, {SelectedRole}, {Progress:0}%");
        ResetCommand = new RelayCommand(_ =>
        {
            UserName = "Алексей";
            Progress = 35;
            NotificationsEnabled = true;
            SelectedRole = Roles[0];
            CommandResult = "Значения сброшены командой";
        });
    }

    public ObservableCollection<string> Roles { get; } = new() { "Разработчик", "Тестировщик", "Аналитик" };

    public string UserName
    {
        get => userName;
        set => SetProperty(ref userName, value);
    }

    public double Progress
    {
        get => progress;
        set => SetProperty(ref progress, value);
    }

    public bool NotificationsEnabled
    {
        get => notificationsEnabled;
        set => SetProperty(ref notificationsEnabled, value);
    }

    public string SelectedRole
    {
        get => selectedRole;
        set => SetProperty(ref selectedRole, value);
    }

    public string CommandResult
    {
        get => commandResult;
        set => SetProperty(ref commandResult, value);
    }

    public ICommand ApplyCommand { get; }
    public ICommand ResetCommand { get; }
}
