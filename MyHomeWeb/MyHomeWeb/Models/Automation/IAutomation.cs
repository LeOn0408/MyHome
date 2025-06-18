namespace MyHomeWeb.Models.Automation;

public interface IAutomation
{
    string Name { get; }
    string Description { get; }
    Task ExecuteAsync(IServiceProvider serviceProvider, CancellationToken cancellationToken = default);
}
