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
//荷游戏 2界面
namespace Lotus
{
    [Activity(Label = "LogoActivity4_2")]
    public class LogoActivity4_2 : Activity     
    {
        //定义诗词字符串
        string[] poems =new string[]{
                             "采莲曲 \n荷叶罗裙一色裁，\n芙蓉向脸两边开。\n乱入池中看不见，\n闻歌始觉有人来。",
                              "小池\n泉眼无声溪细流，\n树荫照水爱晴柔。\n小荷才露尖尖角，\n早有蜻蜓立上头。",
                              "晓出净慈寺送林子方\n毕竟西湖六月中， \n风光不与四时同。\n接天莲叶无穷碧， \n映日荷花别样红。",
                              "折荷有赠\n涉江玩秋水，\n爱此红蕖鲜。\n攀荷弄其珠，\n荡漾不成圆。\n佳人彩云里，\n欲赠隔远天。\n相思无因见，\n怅望凉风前。",
                              "芙 蓉\n刺茎澹荡碧， \n花片参差红。 \n吴歌秋水冷， \n湘庙夜云空。 \n浓艳香露里， \n美人清镜中。 \n南楼未归容， \n一夕练塘东。",
                              "莲花坞\n日日采莲去，\n洲长多暮归。\n开篙莫溅水，\n畏湿红莲衣。",
                              "如梦令\n常记溪亭日暮，\n沉醉不知归路。\n兴尽晚归舟，\n误入藕花深处。\n争渡，争渡，\n惊起一滩鸥鹭。",
                              "苏幕遮\n    燎沉香，消溽暑。鸟雀呼晴，侵晓窥檐语。叶上初阳干宿雨，水面清圆，一一风荷举。\n    故乡遥，何日去？家住吴门，久作长安旅。五月渔郎相忆否？小楫轻舟，梦入芙蓉浦。",
                              "望海潮\n    东南形胜，三吴都会，钱塘自古繁华。烟柳画桥，风帘翠幕，参差十万人家。云树绕堤沙。怒涛卷霜雪，天堑无涯。市列珠玑，户盈罗绮竞豪奢。\n    重湖叠巘清嘉。有三秋桂子，十里荷花。羌管弄晴，菱歌泛夜，嬉嬉钓叟莲娃。千骑拥高牙。乘醉听箫鼓，吟赏烟霞。异日图将好景，归去凤池夸。",
                      "荷花媚 荷花\n    霞苞电荷碧。天然地、别是风流标格。重重青盖下，千娇照水，好红红白白。\n    每怅望、明月清风夜，甚低不语，妖邪无力。终须放、船儿去，清香深处住，看伊颜色。",
                      "一剪梅\n    红藕香残玉簟秋，轻解罗裳，独上兰舟。云中谁寄锦书来？雁字回时，月满西楼。\n    花自飘零水自流。一种相思，两处闲愁。此情无计可消除，才下眉头，却上心头。",
                      "蝶恋花\n    越女采莲秋水畔。窄袖轻罗，暗露双金钏。照影摘花花似面。芳心只共丝争乱。\n    鸂鶒滩头风浪晚。雾重烟轻，不见来时伴。隐隐歌声归棹远。离愁引著江南岸。",
                      "爱莲说\n    水陆草木之花，可爱者甚蕃。晋陶渊明独爱菊。自李唐来，世人甚爱牡丹。予独爱莲之出淤泥而不染，濯清涟而不妖，中通外直，不蔓不枝，香远益清，亭亭净植，可远观而不可亵玩焉。\n    予谓菊，花之隐逸者也；牡丹，花之富贵者也；莲，花之君子者也。噫！菊之爱，陶后鲜有闻；莲之爱，同予者何人？牡丹之爱，宜乎众矣！"


        };
        //定义做专业字符串
        string[] author = new string[]{
            "王昌龄",
            "杨万里",
            "杨万里",
            "李白",
            "温庭筠",
            "王维",
            "李清照",
            "周邦彦",
            "柳永",
            "苏轼",
            "李清照",
            "欧阳修",
            "周敦颐"


        };

                
          
        protected override void OnCreate(Bundle bundle)
        {
    

            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.game2);
            var lotus_game2 = FindViewById<LinearLayout>(Resource.Id.LayoutGame2);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_game2.StartAnimation(in_animation);
            //返回键功能
            ImageButton btn_back4_2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack4_2);
            btn_back4_2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_game2.StartAnimation(out_animation);
                this.OnBackPressed();
            };
           
            //游戏逻辑
            var text_frame = FindViewById<LinearLayout>(Resource.Id.Game2_textlayout);
            var text_poem = FindViewById<TextView>(Resource.Id.game2_text);
            var buttonOK = FindViewById<Button>(Resource.Id.button_ok);
            var edit_text = FindViewById<EditText>(Resource.Id.text_input);
            var tip = FindViewById<TextView>(Resource.Id.tip_text);
            //动画效果
            var anim_text = AnimationUtils.LoadAnimation(this, Resource.Animation.game2_in);
            int i = 0;
            int count=0;
            int flag = 0;  //记录游戏状体，0为结束，1表示进行中
            buttonOK.Click += (sender, e) =>
                {
                    if(flag==0)
                    {
                        flag=1;
                        text_poem.Text = poems[i];
                        text_poem.StartAnimation(anim_text);
                        buttonOK.Text = "确定";
                        text_frame.SetBackgroundResource(Resource.Drawable.nezha_1);
                        tip.Text = "猜中" + count.ToString() + "个";
                       
                    }               
                    else
                    {
                        if(edit_text.Text==author[i])
                        {
                            i++;
                            if (i == 13)
                            {
                                tip.Text = "完胜";
                                i = 0;      //各计数复位
                                flag = 0;
                                count=0;
                                buttonOK.Text = "again";
                                text_frame.SetBackgroundResource(Resource.Drawable.nezha);
                            }
                            else
                            {
                                text_poem.Text = poems[i];
                                text_poem.StartAnimation(anim_text);
                                count++;
                                tip.Text = "猜中" + count.ToString() + "个";
                            }
                            
                        }
                        else
                        {
                            i = 0;                //各计数复位
                            count = 0;
                            flag = 0;
                            tip.Text = "失败";
                            buttonOK.Text="Replay";
                            text_frame.SetBackgroundResource(Resource.Drawable.nezha);
                        }
                    }
                };
            
        }

        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_game2= FindViewById<LinearLayout>(Resource.Id.LayoutGame2);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_game2.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}