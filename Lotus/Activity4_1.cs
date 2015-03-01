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
//荷游戏 1界面
namespace Lotus
{
    [Activity(Label = "LogoActivity4_1")]
    public class LogoActivity4_1 : Activity     
    {

                
          
        protected override void OnCreate(Bundle bundle)
        {
    

            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.game1);
            var lotus_game1 = FindViewById<LinearLayout>(Resource.Id.LayoutGame1);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_game1.StartAnimation(in_animation);

            //加载九宫格
            var table = FindViewById<TableLayout>(Resource.Id.tablelayout);
            var in_jiugong = AnimationUtils.LoadAnimation(this, Resource.Animation.game2_in);
            table.StartAnimation(in_jiugong);
            //返回键功能
            ImageButton btn_back4_1 = FindViewById<ImageButton>(Resource.Id.imageButtonBack4_1);
            btn_back4_1.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_game1.StartAnimation(out_animation);
                this.OnBackPressed();
            };
           
            //游戏逻辑按钮事件
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
             
            //动画
            var game1_in_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.game1_in);
                piece1.Click += delegate
                {
                    piece1.SetBackgroundResource(Resource.Drawable.game1_ali);
                    piece1.StartAnimation(game1_in_anim);
                    textTucao.Text = "破电脑，写一行代码要卡三秒。。。你倒是快点编译玩啊喂";

                };
            
           
            
            piece2.Click += delegate
            {
                piece2.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece2.StartAnimation(game1_in_anim);
                textTucao.Text = "苦逼的六一儿童节，我在宿舍连着写了两天代码，已经不能用屌丝来形容了~";
            };
             
   
            piece3.Click += delegate
            {
                piece3.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece3.StartAnimation(game1_in_anim);
                textTucao.Text = "悄悄地告诉你，这软件没有任何技术含量，光美工代码占了六成啊。";
            };
            
           
   
            
            piece4.Click += delegate
            {
                piece4.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece4.StartAnimation(game1_in_anim);
                textTucao.Text = "会美工，会编程，会写文档，会调bug，我是个立志成为全栈工程师的人，ps：虽然到现在我连快速排序都写不出的说。。。";
            };
            
           

            piece5.Click += delegate
            {
                piece5.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece5.StartAnimation(game1_in_anim);
                textTucao.Text = "极度鄙视自己啊，本来想弄个随机出题的算法，可惜MD有个不重复出随机数的算法我不会写呀，不会写呀";
            };


            piece6.Click += delegate
            {
                piece6.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece6.StartAnimation(game1_in_anim);
                textTucao.Text = "翻牌游戏本来不是这么水的，本来想要写个高大上的，but。。。最关键的那个API没查到，xamarin你是有多坑爹啊。。。于是不了了之了，于是就成了大家看到的这样子";
            };
            piece7.Click += delegate
            {
                piece7.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece7.StartAnimation(game1_in_anim);
                textTucao.Text = "第一次写安卓，而且是用C#写，相比那些写java的，满满的优越感啊，神马？你说C#是抄java的？你等着，信不信我拿C++砍你。";
            };
            piece8.Click += delegate
            {
                piece8.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece8.StartAnimation(game1_in_anim);
                textTucao.Text = "哎，微软你就不能把IDE做小一点么，这么臃肿，编译器都卡成什么样了~";
            };
            piece9.Click += delegate
            {
                piece9.SetBackgroundResource(Resource.Drawable.game1_ali);
                piece9.StartAnimation(game1_in_anim);
                textTucao.Text = "切九宫格？我会切，Photoshop四步搞定。。。咳咳，扯远了，你到底是美工还是程序猿啊，搞清定位啊喂";
            };
        }

        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_game1= FindViewById<LinearLayout>(Resource.Id.LayoutGame1);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_game1.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}