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
//荷品牌 跑车界面
namespace Lotus
{
    [Activity(Label = "LogoActivity3_1")]
    public class LogoActivity3_1 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.layout3_1);
            var lotus_car= FindViewById<LinearLayout>(Resource.Id.carlayout);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_car.StartAnimation(in_animation);
            //返回键功能
            ImageButton btn_back3_1 = FindViewById<ImageButton>(Resource.Id.imageButtonBack3_1);
            btn_back3_1.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_car.StartAnimation(out_animation);
                this.OnBackPressed();
            };
        }

        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_car= FindViewById<LinearLayout>(Resource.Id.carlayout);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_car.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}