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
//����ʳ����
namespace Lotus
{
    [Activity(Label = "LogoActivity2")]
    public class LogoActivity2_2 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.food_list);
            var lotus_food = FindViewById<LinearLayout>(Resource.Id.LotusFood);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_food.StartAnimation(in_animation);

           
            //���ؼ�����
            ImageButton btn_back2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack2_2);
            btn_back2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_food.StartAnimation(out_animation);
                this.OnBackPressed();
            };

          

        }
        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_food = FindViewById<LinearLayout>(Resource.Id.LotusFood);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_food.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}