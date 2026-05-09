using System.Windows.Input;
using LAB_PI_2.Infrastructure;

namespace LAB_PI_2.ViewModels;

public sealed class OneWayBindingViewModel : ObservableObject
{
    private string sourceMessage = "Данные идут из ViewModel в интерфейс";
    private double temperature = 21;
    private bool isAvailable = true;
    private int changesCount;

    public OneWayBindingViewModel()
    {
        ChangeSourceCommand = new RelayCommand(_ =>
        {
            ChangesCount++;
            Temperature = 18 + ChangesCount * 3;
            IsAvailable = !IsAvailable;
            SourceMessage = $"Источник обновлен командой #{ChangesCount}";
        });
    }

    public string SourceMessage
    {
        get => sourceMessage;
        set => SetProperty(ref sourceMessage, value);
    }

    public double Temperature
    {
        get => temperature;
        set => SetProperty(ref temperature, value);
    }

    public bool IsAvailable
    {
        get => isAvailable;
        set => SetProperty(ref isAvailable, value);
    }

    public int ChangesCount
    {
        get => changesCount;
        set => SetProperty(ref changesCount, value);
    }

    public ICommand ChangeSourceCommand { get; }
}
