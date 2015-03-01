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
//荷家族界面
namespace Lotus
{
    [Activity(Label = "LogoActivity1")]
    public class LogoActivity1 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面,有动画效果
            SetContentView(Resource.Layout.Logolayout1);
            var lotus_family = FindViewById<LinearLayout>(Resource.Id.LotusFamily);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_family.StartAnimation(in_animation);

            //返回键功能
            ImageButton btn_back1 = FindViewById<ImageButton>(Resource.Id.imageButtonBack1);
            btn_back1.Click += delegate
            {
               
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_family.StartAnimation(out_animation);

                this.OnBackPressed();  //后退
            };

            //四个品种按键
            Button btn_button1 = FindViewById<Button>(Resource.Id.logo1_button1);
            btn_button1.Click += (sender, e) =>
            {
                var Logo1_activity1 = new Intent(this, typeof(LogoActivity1_1));
                StartActivity(Logo1_activity1);
            };
            Button btn_button2 = FindViewById<Button>(Resource.Id.logo1_button2);
            btn_button2.Click += (sender, e) =>
            {
                var Logo1_activity2 = new Intent(this, typeof(LogoActivity1_2));
                StartActivity(Logo1_activity2);
            };
            Button btn_button3 = FindViewById<Button>(Resource.Id.logo1_button3);
            btn_button3.Click += (sender, e) =>
            {
                var Logo1_activity3 = new Intent(this, typeof(LogoActivity1_3));
                StartActivity(Logo1_activity3);
            }; 

        }

        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_family = FindViewById<LinearLayout>(Resource.Id.LotusFamily);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_family.StartAnimation(out_animation);
                this.OnBackPressed();
               
                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}