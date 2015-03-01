/*
 * 软件：荷Lotus
 * 作者：踏莎行
 * 时间：2014年5月27日
 * 版本：1.0
 */
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Views.Animations;
using Android.Media;
using Android.Provider;
namespace Lotus
{
    
    [Activity(Label = "荷Lotus", Icon = "@drawable/icon")]

    public class MainActivity : Activity
    {
        private long lasttime = 0;  //记录返回退出的时间
        ImageButton btnBack, btnSetting; //返回和设置按钮
        Gallery gallery;  //首页图片展示区
        ImageButton btnLogo1, btnLogo2, btnLogo3, btnLogo4;  //四个导航按钮
        MediaPlayer idPlayer;
        int sound = 0;//0表示刚开有音乐
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        
            //载入动画
            var main_page = FindViewById<LinearLayout>(Resource.Id.linearLayoutMain);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            main_page.StartAnimation(in_animation);

            //// 播放背景音乐
            
            idPlayer = MediaPlayer.Create(this, Resource.Raw.music);
            idPlayer.Start();

            //开关背景音乐
            var button_sound = FindViewById<ImageButton>(Resource.Id.imageButtonSound);
            button_sound.Click += delegate
            {
                if(sound==0)
                {
                    idPlayer.Pause();
                    sound = 1;
                    button_sound.SetBackgroundResource(Resource.Drawable.sound_off);
                    Toast.MakeText(this, "背景音乐已关闭", ToastLength.Short).Show();
                }
                else
                {
                    idPlayer.Start();
                    sound = 0;
                    button_sound.SetBackgroundResource(Resource.Drawable.sound_on);
                    Toast.MakeText(this, "背景音乐已打开", ToastLength.Short).Show();
                }
            };

            //返回按钮盒设置按钮功能
            btnBack = FindViewById<ImageButton>(Resource.Id.imageButtonBack);
            btnSetting = FindViewById<ImageButton>(Resource.Id.imageButtonSetting);
            //加载setting界面
            btnSetting.Click += delegate
            {
                var setting_activity = new Intent(this, typeof(SettingActivity));
                StartActivity(setting_activity);
            };

            //text载入动画
            var text_in = AnimationUtils.LoadAnimation(this, Resource.Animation.maintext_in);
            btnBack.Click += delegate
            {

                //base.OnBackPressed();  //标志着返回键被按下了,写base还是this？有待斟酌
                if (SystemClock.CurrentThreadTimeMillis() - lasttime > 25)
                {
                    Toast.MakeText(this, "再按一次退出哦∩_∩", ToastLength.Short).Show();
                    lasttime = SystemClock.CurrentThreadTimeMillis();


                }
                else
                {
                    idPlayer.Stop();  //退出记得关闭音乐啊 ，否则程序关闭了还在放
                    idPlayer.Release();  //释放资源
                    this.Finish();
                }
            };


            //中间字符带对象
            var textBless = FindViewById<TextView>(Resource.Id.text_bless);
            //四个圆形按钮导航
            btnLogo1 = FindViewById<ImageButton>(Resource.Id.imageButton1);  //荷家族
            btnLogo1.Click += delegate
            {
               
                var Logo_activity1 = new Intent(this, typeof(LogoActivity1));
                StartActivity(Logo_activity1);
            };
            btnLogo2 = FindViewById<ImageButton>(Resource.Id.imageButton2);  //荷文化
            btnLogo2.Click += delegate
            {
                
                var Logo_activity2 = new Intent(this, typeof(LogoActivity2));
                StartActivity(Logo_activity2);
            };
            btnLogo3 = FindViewById<ImageButton>(Resource.Id.imageButton3);  //荷品牌
            btnLogo3.Click += delegate
            {
             
                var Logo_activity3 = new Intent(this, typeof(LogoActivity3));
                StartActivity(Logo_activity3);
            };
            btnLogo4 = FindViewById<ImageButton>(Resource.Id.imageButton4);  //荷游戏
            btnLogo4.Click += delegate
            {

                var Logo_activity4 = new Intent(this, typeof(LogoActivity4));
                StartActivity(Logo_activity4);
            };

            //gallery图片切换
            gallery = FindViewById<Gallery>(Resource.Id.galleryShow);
            gallery.Adapter = new ImageAdapter(this);
            gallery.SetSelection(2);   //初始化程序后默认显示第三张图片
            gallery.ItemClick+= delegate(object sender, Android.Widget.AdapterView.ItemClickEventArgs args)   //可以这里用的是长按响应
            {
                //根据按的图片不同显示不同的“惊喜”，注意C#里面必须要有default
                switch(args.Position)
                {
                    case 0:
                        textBless.Text = "莲，亭亭玉立的水中仙子；莲，散发着淡淡清香的花中君子。";
                        textBless.StartAnimation(text_in);
                        break;
                    case 1:
                        textBless.Text = "莲，你那孤傲高洁的花，宽大平和的叶，一脉相承的茎，深扎淤泥的根";
                        textBless.StartAnimation(text_in);
                        break;
                    case 2:
                        textBless.Text = "莲，你以求真慕美之意，怜爱济世之情，超然物外之神，优雅风情之态，谱写了一曲真善美的颂歌。";
                        textBless.StartAnimation(text_in);
                        break;
                    case 3:
                        textBless.Text = "莲，你端庄典雅，含蓄深沉；你豁然大度，光明磊落；你清新隽永，雅趣怡然";
                        textBless.StartAnimation(text_in);
                        break;
                    case 4:
                        textBless.StartAnimation(text_in);
                        textBless.Text = "莲，你有友善宽厚的温柔情怀。你善良温厚，谦逊益群，携众而生，择善而从，欣然共处。";
                        break;
                    default:
                        break;
                }
             
            };


        }

        ////音乐回调
        //public void OnCompletion(MediaPlayer player)
        //{
        //    player.Stop();
        //    player.Release();
        //}

        //双击返回键退出
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {

                if (SystemClock.CurrentThreadTimeMillis() - lasttime > 20)
                {
                    Toast.MakeText(this, "再按一次退出哦∩_∩", ToastLength.Short).Show();
                    lasttime = SystemClock.CurrentThreadTimeMillis();


                }
                else
                {
                    idPlayer.Stop();  //退出记得关闭音乐啊 ，否则程序关闭了还在放
                    idPlayer.Release();  //释放资源
                    this.Finish();
                }
                return true;
            }
            else
                return base.OnKeyDown(keyCode, e);


        }
      
       
    }

    //定义一个galleryadapter的的类
    public class ImageAdapter : BaseAdapter
    {
        Context context;

        public ImageAdapter(Context c)
        {
            context = c;
        }

        public override int Count { get { return thumbIds.Length; } }

        public override Java.Lang.Object GetItem(int position)
        {
            return null;
        }

        public override long GetItemId(int position)
        {
            return 0;
        }

        // create a new ImageView for each item referenced by the Adapter
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            ImageView i = new ImageView(context);

            i.SetImageResource(thumbIds[position]);
            i.LayoutParameters = new Gallery.LayoutParams(400, 240);
            i.SetScaleType(ImageView.ScaleType.FitXy);
            return i;
        }

        // references to our images
        int[] thumbIds = {
            Resource.Drawable.mainpic1,
            Resource.Drawable.mainpic2,
            Resource.Drawable.mainpic3,
            Resource.Drawable.mainpic4,
            Resource.Drawable.mainpic5
             };
    }
    
}

