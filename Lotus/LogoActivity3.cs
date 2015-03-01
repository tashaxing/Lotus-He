using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.Views.Animations;
//荷品牌界面
namespace Lotus
{
    [Activity(Label = "LogoActivity3")]
    public class LogoActivity3 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.Logolayout3);
            var lotus_brand = FindViewById<LinearLayout>(Resource.Id.LotusBrand);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_brand.StartAnimation(in_animation);
            //返回键功能
            ImageButton btn_back3 = FindViewById<ImageButton>(Resource.Id.imageButtonBack3);
            btn_back3.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_brand.StartAnimation(out_animation);
                this.OnBackPressed();
            };

            //加载car界面
            Button btn_car = FindViewById<Button>(Resource.Id.car_button);
            btn_car.Click += (sender, e) =>
            {
                var Logo3_activity1 = new Intent(this, typeof(LogoActivity3_1));
                StartActivity(Logo3_activity1);
            };
            //加载jewelry界面
            Button btn_jewelry = FindViewById<Button>(Resource.Id.jewelry_button);
            btn_jewelry.Click += (sender, e) =>
            {
                var Logo3_activity2 = new Intent(this, typeof(LogoActivity3_2));
                StartActivity(Logo3_activity2);
            }; 

        }
        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_brand = FindViewById<LinearLayout>(Resource.Id.LotusBrand);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_brand.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}