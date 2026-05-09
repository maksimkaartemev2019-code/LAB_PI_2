using System.Windows.Input;
using LAB_PI_2.Infrastructure;

namespace LAB_PI_2.ViewModels;

public sealed class OneTimeBindingViewModel : ObservableObject
{
    private string courseTitle = "Привязка создана при загрузке";
    private int version = 1;
    private string commandResult = "Нажмите кнопку и сравните OneTime с OneWay.";

    public OneTimeBindingViewModel()
    {
        ChangeSourceCommand = new RelayCommand(_ =>
        {
            Version++;
            CourseTitle = $"Источник изменен командой, версия {Version}";
            CommandResult = "OneWay обновился, OneTime оставил первое значение.";
        });
    }

    public string CourseTitle
    {
        get => courseTitle;
        set => SetProperty(ref courseTitle, value);
    }

    public int Version
    {
        get => version;
        set => SetProperty(ref version, value);
    }

    public string CommandResult
    {
        get => commandResult;
        set => SetProperty(ref commandResult, value);
    }

    public ICommand ChangeSourceCommand { get; }
}
