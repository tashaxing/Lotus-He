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
//����Ϸ����
namespace Lotus
{
    [Activity(Label = "LogoActivity4")]
    public class LogoActivity4 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.Logolayout4);
            var lotus_game = FindViewById<LinearLayout>(Resource.Id.LotusGame);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_game.StartAnimation(in_animation);
            //���ؼ�����
            ImageButton btn_back4 = FindViewById<ImageButton>(Resource.Id.imageButtonBack4);
            btn_back4.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_game.StartAnimation(out_animation);
                this.OnBackPressed();
            };
            //������Ϸҳ��
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
        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_game = FindViewById<LinearLayout>(Resource.Id.LotusGame);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_game.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); 


        }
    }
}