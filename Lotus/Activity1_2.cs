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
//�ɼ��� ˯������
namespace Lotus
{
    [Activity(Label = "LogoActivity1_2")]
    public class LogoActivity1_2 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.Logolayout1_2);
            var lotus_family2 = FindViewById<LinearLayout>(Resource.Id.LotusFamily2);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_family2.StartAnimation(in_animation);
            //���ؼ�����
            ImageButton btn_back1_2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack1_2);
            btn_back1_2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_family2.StartAnimation(out_animation);
                this.OnBackPressed();
            };
        }

        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_family2 = FindViewById<LinearLayout>(Resource.Id.LotusFamily2);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_family2.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}