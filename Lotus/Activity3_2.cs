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
//��Ʒ�� �鱦����
namespace Lotus
{
    [Activity(Label = "LogoActivity3_2")]
    public class LogoActivity3_2 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.layout3_2);
            var lotus_jewelry = FindViewById<LinearLayout>(Resource.Id.jewelrylayout);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_jewelry.StartAnimation(in_animation);
            //���ؼ�����
            ImageButton btn_back3_2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack3_2);
            btn_back3_2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_jewelry.StartAnimation(out_animation);
                this.OnBackPressed();
            };
        }

        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_jewelry= FindViewById<LinearLayout>(Resource.Id.jewelrylayout);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_jewelry.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}