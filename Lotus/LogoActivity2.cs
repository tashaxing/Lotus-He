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
//荷文化界面
namespace Lotus
{
    [Activity(Label = "LogoActivity2")]
    public class LogoActivity2 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.Logolayout2);
            var lotus_culture = FindViewById<LinearLayout>(Resource.Id.LotusCulture);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_culture.StartAnimation(in_animation);

           
            //返回键功能
            ImageButton btn_back2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack2);
            btn_back2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_culture.StartAnimation(out_animation);
                this.OnBackPressed();
            };

          //荷花诗词
           var btn_poem = FindViewById<Button>(Resource.Id.buttonPoem);
            btn_poem.Click += delegate
            {
                var Logo2_activity1 = new Intent(this, typeof(LogoActivity2_1));
                StartActivity(Logo2_activity1);
            };

           //荷花饮食
            var btn_food = FindViewById<Button>(Resource.Id.buttonFood);
            btn_food.Click += delegate
            {
                var Logo2_activity2 = new Intent(this, typeof(LogoActivity2_2));
                StartActivity(Logo2_activity2);
            };

        }
        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_culture = FindViewById<LinearLayout>(Resource.Id.LotusCulture);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_culture.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}