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
//荷游戏界面
namespace Lotus
{
    [Activity(Label = "LogoActivity4")]
    public class LogoActivity4 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.Logolayout4);
            var lotus_game = FindViewById<LinearLayout>(Resource.Id.LotusGame);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_game.StartAnimation(in_animation);
            //返回键功能
            ImageButton btn_back4 = FindViewById<ImageButton>(Resource.Id.imageButtonBack4);
            btn_back4.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_game.StartAnimation(out_animation);
                this.OnBackPressed();
            };
            //进入游戏页面
            Button btn_game1 = FindViewById<Button>(Resource.Id.game1_button);
            btn_game1.Click += (sender, e) =>
            {
                var Logo4_activity1 = new Intent(this, typeof(LogoActivity4_1));
                StartActivity(Logo4_activity1);
            };
            Button btn_game2 = FindViewById<Button>(Resource.Id.game2_button);
            btn_game2.Click += (sender, e) =>
            {
                var Logo4_activity2 = new Intent(this, typeof(LogoActivity4_2));
                StartActivity(Logo4_activity2);
            };
            
        }
        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_game = FindViewById<LinearLayout>(Resource.Id.LotusGame);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_game.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); 


        }
    }
}