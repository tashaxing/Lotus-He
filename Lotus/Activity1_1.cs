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
//�ɼ��� ��������
namespace Lotus
{
    [Activity(Label = "LogoActivity1_1")]
    public class LogoActivity1_1 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.Logolayout1_1);
            var lotus_family1 = FindViewById<LinearLayout>(Resource.Id.LotusFamily1);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_family1.StartAnimation(in_animation);
            //���ؼ�����
            ImageButton btn_back1_1 = FindViewById<ImageButton>(Resource.Id.imageButtonBack1_1);
            btn_back1_1.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_family1.StartAnimation(out_animation);
                this.OnBackPressed();
            };
        }

        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_family1 = FindViewById<LinearLayout>(Resource.Id.LotusFamily1);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_family1.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}