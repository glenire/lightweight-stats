using LightweightStats.HttpServices.Services;
using Microsoft.AspNetCore.Components.WebView.Maui;
using MudBlazor.Services;

namespace Lightweight_Stats;

public static class MauiProgram
{
	public static string Base = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2" : "http://localhost";
	public static string APIUrl = $"{Base}:44391/";

	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
			});

		builder.Services.AddMauiBlazorWebView();

		builder.Services.AddHttpClient<ClubService>(client =>
		{
			client.BaseAddress = new Uri(APIUrl);
		});

		builder.Services.AddMudServices();

		return builder.Build();
	}
}
