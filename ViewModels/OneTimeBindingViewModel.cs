using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LAB_PI_2.ViewModels;

public sealed partial class OneTimeBindingViewModel : ObservableObject
{
    [ObservableProperty]
    private string courseTitle = "Привязка создана при загрузке";

    [ObservableProperty]
    private int version = 1;

    [ObservableProperty]
    private string commandResult = "Нажмите кнопку и сравните OneTime с OneWay.";

    [RelayCommand]
    private void ChangeSource()
    {
        Version++;
        CourseTitle = $"Источник изменен командой, версия {Version}";
        CommandResult = "OneWay обновился, OneTime оставил первое значение.";
    }
}
