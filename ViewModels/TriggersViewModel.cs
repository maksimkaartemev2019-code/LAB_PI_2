using System.Windows.Input;
using LAB_PI_2.Infrastructure;

namespace LAB_PI_2.ViewModels;

public sealed class TriggersViewModel : ObservableObject
{
    private bool isImportant;
    private bool isConfirmed;
    private string status = "Черновик";
    private int eventCount;

    public TriggersViewModel()
    {
        ToggleImportantCommand = new RelayCommand(_ => IsImportant = !IsImportant);
        ToggleConfirmedCommand = new RelayCommand(_ => IsConfirmed = !IsConfirmed);
        ChangeStatusCommand = new RelayCommand(_ => Status = Status == "Черновик" ? "Готово" : "Черновик");
        CountEventCommand = new RelayCommand(_ => EventCount++);
    }

    public bool IsImportant
    {
        get => isImportant;
        set => SetProperty(ref isImportant, value);
    }

    public bool IsConfirmed
    {
        get => isConfirmed;
        set => SetProperty(ref isConfirmed, value);
    }

    public string Status
    {
        get => status;
        set => SetProperty(ref status, value);
    }

    public int EventCount
    {
        get => eventCount;
        set => SetProperty(ref eventCount, value);
    }

    public ICommand ToggleImportantCommand { get; }
    public ICommand ToggleConfirmedCommand { get; }
    public ICommand ChangeStatusCommand { get; }
    public ICommand CountEventCommand { get; }
}
