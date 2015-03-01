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
//���Ļ�����
namespace Lotus
{
    [Activity(Label = "LogoActivity2")]
    public class LogoActivity2 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.Logolayout2);
            var lotus_culture = FindViewById<LinearLayout>(Resource.Id.LotusCulture);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_culture.StartAnimation(in_animation);

           
            //���ؼ�����
            ImageButton btn_back2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack2);
            btn_back2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_culture.StartAnimation(out_animation);
                this.OnBackPressed();
            };

          //�ɻ�ʫ��
           var btn_poem = FindViewById<Button>(Resource.Id.buttonPoem);
            btn_poem.Click += delegate
            {
                var Logo2_activity1 = new Intent(this, typeof(LogoActivity2_1));
                StartActivity(Logo2_activity1);
            };

           //�ɻ���ʳ
            var btn_food = FindViewById<Button>(Resource.Id.buttonFood);
            btn_food.Click += delegate
            {
                var Logo2_activity2 = new Intent(this, typeof(LogoActivity2_2));
                StartActivity(Logo2_activity2);
            };

        }
        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_culture = FindViewById<LinearLayout>(Resource.Id.LotusCulture);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_culture.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}