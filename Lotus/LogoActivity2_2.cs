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
//荷饮食界面
namespace Lotus
{
    [Activity(Label = "LogoActivity2")]
    public class LogoActivity2_2 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.food_list);
            var lotus_food = FindViewById<LinearLayout>(Resource.Id.LotusFood);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_food.StartAnimation(in_animation);

           
            //返回键功能
            ImageButton btn_back2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack2_2);
            btn_back2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_food.StartAnimation(out_animation);
                this.OnBackPressed();
            };

          

        }
        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_food = FindViewById<LinearLayout>(Resource.Id.LotusFood);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_food.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}