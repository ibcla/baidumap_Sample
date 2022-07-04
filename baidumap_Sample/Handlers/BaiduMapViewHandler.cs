using baidumap_Sample.Views;
#if ANDROID
using Com.Baidu.Mapapi;
using Com.Baidu.Mapapi.Map;
#endif
using Microsoft.Maui.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baidumap_Sample.Handlers
{
#if ANDROID
    public class BaiduMapViewHandler : ViewHandler<MapVIew, Com.Baidu.Mapapi.Map.MapView>
    {
        public static PropertyMapper Mapper = new PropertyMapper<MapVIew>();
        public BaiduMapViewHandler() : base(Mapper)
        {

        }

        protected override MapView CreatePlatformView()
        {
            //是否同意隐私政策
            SDKInitializer.SetAgreePrivacy(Context, true);

            //在使用SDK各组件之前初始化context信息，传入ApplicationContext
            SDKInitializer.Initialize(Context);

            BaiduMapOptions options = new BaiduMapOptions();

            var _view = new MapView(Context, options);

            var _Map = _view.Map;
            _Map.MyLocationEnabled = true;

            // _Map.SetOnMapClickListener(new OnMapClickListener());
            return _view;
        }
    }
#endif
}
