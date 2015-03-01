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
//设置界面
namespace Lotus
{
    [Activity(Label = "setting")]

    public class SettingActivity : Activity   
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.settinglayout);
            var lotus_setting = FindViewById<LinearLayout>(Resource.Id.lotus_setting);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_setting.StartAnimation(in_animation);
        
            //返回键功能
            ImageButton btn_back_setting = FindViewById<ImageButton>(Resource.Id.imageButtonBackSetting);
            btn_back_setting.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_setting.StartAnimation(out_animation);
                this.OnBackPressed();
            };
        }

        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_setting = FindViewById<LinearLayout>(Resource.Id.lotus_setting);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_setting.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}