namespace LAB_PI_2.ViewModels;

public sealed class MainViewModel
{
    public DefaultBindingViewModel DefaultBinding { get; } = new();
    public TwoWayBindingViewModel TwoWayBinding { get; } = new();
    public OneTimeBindingViewModel OneTimeBinding { get; } = new();
    public OneWayBindingViewModel OneWayBinding { get; } = new();
    public TriggersViewModel Triggers { get; } = new();
}
