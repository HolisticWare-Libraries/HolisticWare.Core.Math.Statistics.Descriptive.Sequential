using Xunit.Runners.Maui;

namespace Tests.UnitTests.DeviceTests.MAUI.Shinny.XUnit;


public static class MauiProgram
{
    public static MauiApp CreateMauiApp() => MauiApp
        .CreateBuilder()
        .ConfigureTests(new TestOptions
        {
            Assemblies =
            {
                    typeof(MauiProgram).Assembly
            }
        })
        .UseVisualRunner()
        .Build();
}

