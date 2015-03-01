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
//荷家族 碗莲界面
namespace Lotus
{
    [Activity(Label = "LogoActivity1_1")]
    public class LogoActivity1_1 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.Logolayout1_1);
            var lotus_family1 = FindViewById<LinearLayout>(Resource.Id.LotusFamily1);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_family1.StartAnimation(in_animation);
            //返回键功能
            ImageButton btn_back1_1 = FindViewById<ImageButton>(Resource.Id.imageButtonBack1_1);
            btn_back1_1.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_family1.StartAnimation(out_animation);
                this.OnBackPressed();
            };
        }

        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_family1 = FindViewById<LinearLayout>(Resource.Id.LotusFamily1);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_family1.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}