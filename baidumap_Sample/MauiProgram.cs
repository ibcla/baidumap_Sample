using baidumap_Sample.Handlers;
using baidumap_Sample.Views;

namespace baidumap_Sample;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});
		builder.ConfigureMauiHandlers(Handlers =>
		{
#if ANDROID
			Handlers.AddHandler(typeof(MapVIew), typeof(BaiduMapViewHandler));
#endif
		});


        return builder.Build();
	}
}
