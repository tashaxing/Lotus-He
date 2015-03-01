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
//荷家族 睡莲界面
namespace Lotus
{
    [Activity(Label = "LogoActivity1_2")]
    public class LogoActivity1_2 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.Logolayout1_2);
            var lotus_family2 = FindViewById<LinearLayout>(Resource.Id.LotusFamily2);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_family2.StartAnimation(in_animation);
            //返回键功能
            ImageButton btn_back1_2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack1_2);
            btn_back1_2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_family2.StartAnimation(out_animation);
                this.OnBackPressed();
            };
        }

        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_family2 = FindViewById<LinearLayout>(Resource.Id.LotusFamily2);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_family2.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}