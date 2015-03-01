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
//����Ϸ 1����
namespace Lotus
{
    [Activity(Label = "LogoActivity4_1")]
    public class LogoActivity4_1 : Activity     
    {

                
          
        protected override void OnCreate(Bundle bundle)
        {
    

            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.game1);
            var lotus_game1 = FindViewById<LinearLayout>(Resource.Id.LayoutGame1);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_game1.StartAnimation(in_animation);

            //���ؾŹ���
            var table = FindViewById<TableLayout>(Resource.Id.tablelayout);
            var in_jiugong = AnimationUtils.LoadAnimation(this, Resource.Animation.game2_in);
            table.StartAnimation(in_jiugong);
            //���ؼ�����
            ImageButton btn_back4_1 = FindViewById<ImageButton>(Resource.Id.imageButtonBack4_1);
            btn_back4_1.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_game1.StartAnimation(out_animation);
                this.OnBackPressed();
            };
           
            //��Ϸ�߼���ť�¼�
            var piece1 = FindViewById<Button>(Resource.Id.piecebutton1);
            var piece2 = FindViewById<Button>(Resource.Id.piecebutton2);
            var piece3 = FindViewById<Button>(Resource.Id.piecebutton3);
            var piece4 = FindViewById<Button>(Resource.Id.piecebutton4);
            var piece5 = FindViewById<Button>(Resource.Id.piecebutton5);
            var piece6 = FindViewById<Button>(Resource.Id.piecebutton6);
            var piece7 = FindViewById<Button>(Resource.Id.piecebutton7);
            var piece8 = FindViewById<Button>(Resource.Id.piecebutton8);
            var piece9 = FindViewById<Button>(Resource.Id.piecebutton9);

            var textTucao = FindViewById<TextView>(Resource.Id.text_tucao);
             
            //����
            var game1_in_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.game1_in);
                piece1.Click += delegate
                {
                    piece1.SetBackgroundResource(Resource.Drawable.game1_ali);
                    piece1.StartAnimation(game1_in_anim);
                    textTucao.Text = "�Ƶ��ԣ�дһ�д���Ҫ�����롣�����㵹�ǿ������氡ι";

                };
            
           
            
            piece2.Click += delegate
            {
                piece2.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece2.StartAnimation(game1_in_anim);
                textTucao.Text = "��Ƶ���һ��ͯ�ڣ�������������д��������룬�Ѿ������Ì�˿��������~";
            };
             
   
            piece3.Click += delegate
            {
                piece3.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece3.StartAnimation(game1_in_anim);
                textTucao.Text = "���ĵظ����㣬�����û���κμ�������������������ռ�����ɰ���";
            };
            
           
   
            
            piece4.Click += delegate
            {
                piece4.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece4.StartAnimation(game1_in_anim);
                textTucao.Text = "�����������̣���д�ĵ������bug�����Ǹ���־��Ϊȫջ����ʦ���ˣ�ps����Ȼ������������������д������˵������";
            };
            
           

            piece5.Click += delegate
            {
                piece5.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece5.StartAnimation(game1_in_anim);
                textTucao.Text = "���ȱ����Լ�����������Ū�����������㷨����ϧMD�и����ظ�����������㷨�Ҳ���дѽ������дѽ";
            };


            piece6.Click += delegate
            {
                piece6.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece6.StartAnimation(game1_in_anim);
                textTucao.Text = "������Ϸ����������ôˮ�ģ�������Ҫд���ߴ��ϵģ�but��������ؼ����Ǹ�APIû�鵽��xamarin�����ж�ӵ������������ǲ�����֮�ˣ����Ǿͳ��˴�ҿ�����������";
            };
            piece7.Click += delegate
            {
                piece7.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece7.StartAnimation(game1_in_anim);
                textTucao.Text = "��һ��д��׿����������C#д�������Щдjava�ģ���������Խ�а���������˵C#�ǳ�java�ģ�����ţ��Ų�������C++���㡣";
            };
            piece8.Click += delegate
            {
                piece8.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece8.StartAnimation(game1_in_anim);
                textTucao.Text = "����΢����Ͳ��ܰ�IDE��Сһ��ô����ôӷ�ף�������������ʲô����~";
            };
            piece9.Click += delegate
            {
                piece9.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece9.StartAnimation(game1_in_anim);
                textTucao.Text = "�оŹ����һ��У�Photoshop�Ĳ��㶨�������ȿȣ���Զ�ˣ��㵽�����������ǳ���Գ�������嶨λ��ι";
            };
        }

        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_game1= FindViewById<LinearLayout>(Resource.Id.LayoutGame1);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_game1.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}