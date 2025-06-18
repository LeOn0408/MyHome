namespace MyHomeWeb.Service
{
    public class PluginService
    {
        private readonly string _pluginsPath;
        private readonly ILogger<PluginService> _logger;

        public PluginService(IWebHostEnvironment env, ILogger<PluginService> logger)
        {
            _pluginsPath = Path.Combine(env.ContentRootPath, "Plugins");
            Directory.CreateDirectory(_pluginsPath);
            _logger = logger;
        }
    }
}
