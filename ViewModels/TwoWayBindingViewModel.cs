using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Input;
using LAB_PI_2.Infrastructure;

namespace LAB_PI_2.ViewModels;

public sealed class TwoWayBindingViewModel : ObservableObject
{
    private string liveText = "Меняется сразу";
    private string lostFocusText = "Меняется после потери фокуса";
    private string explicitText = "Ждет команду";
    private double volume = 42;
    private string summary = "Измените поля, чтобы увидеть TwoWay и UpdateSourceTrigger.";

    public TwoWayBindingViewModel()
    {
        ApplyExplicitCommand = new RelayCommand(parameter =>
        {
            if (parameter is TextBox textBox)
            {
                textBox.GetBindingExpression(TextBox.TextProperty)?.UpdateSource();
                Summary = $"Explicit обновлен командой: {ExplicitText}";
            }
        });
        DescribeCommand = new RelayCommand(_ => Summary = $"Live='{LiveText}', LostFocus='{LostFocusText}', Explicit='{ExplicitText}', Slider={Volume:0}");
    }

    public string LiveText
    {
        get => liveText;
        set => SetProperty(ref liveText, value);
    }

    public string LostFocusText
    {
        get => lostFocusText;
        set => SetProperty(ref lostFocusText, value);
    }

    public string ExplicitText
    {
        get => explicitText;
        set => SetProperty(ref explicitText, value);
    }

    public double Volume
    {
        get => volume;
        set => SetProperty(ref volume, value);
    }

    public string Summary
    {
        get => summary;
        set => SetProperty(ref summary, value);
    }

    public ICommand ApplyExplicitCommand { get; }
    public ICommand DescribeCommand { get; }
}
