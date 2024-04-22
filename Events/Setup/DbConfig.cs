namespace Events.Setup;

public static class DbConfig
{
    public static string GetConnString(IConfiguration configuration, string name)
    {
        var connectionString = Environment.GetEnvironmentVariable(name);

        if (connectionString != null)
        {
            return connectionString;
        }

        connectionString = configuration.GetConnectionString(name);
        return connectionString;
    }
}