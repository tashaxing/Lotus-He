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
//荷诗词界面
namespace Lotus
{
    [Activity(Label = "LogoActivity2")]
    public class LogoActivity2_1 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //加载界面
            SetContentView(Resource.Layout.poem_list);
            var lotus_poem = FindViewById<LinearLayout>(Resource.Id.LotusPoem);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_poem.StartAnimation(in_animation);

           
            //返回键功能
            ImageButton btn_back2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack2_2);
            btn_back2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_poem.StartAnimation(out_animation);
                this.OnBackPressed();
            };

            //点诗词按钮事件
            var poem_text = FindViewById<TextView>(Resource.Id.textPoem);   //诗词文字
            //var poem_text_block=FindViewById<ScrollView>(Resource.Id.text_poem_block);  //诗词块
           //诗
            var button_shi1 = FindViewById<Button>(Resource.Id.shi1);
            button_shi1.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "采莲曲 \n[唐]王昌龄\n荷叶罗裙一色裁，\n芙蓉向脸两边开。\n乱入池中看不见，\n闻歌始觉有人来。";
            };
            var button_shi2 = FindViewById<Button>(Resource.Id.shi2);
            button_shi2.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "西洲曲\n[南朝]乐府\n采莲南塘秋，\n莲花过人头。\n低头弄莲子，\n莲子清如水。";
            };
            var button_shi3 = FindViewById<Button>(Resource.Id.shi3);
            button_shi3.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "小池\n[宋]杨万里\n泉眼无声溪细流，\n树荫照水爱晴柔。\n小荷才露尖尖角，\n早有蜻蜓立上头。";
            };
            var button_shi4 = FindViewById<Button>(Resource.Id.shi4);
            button_shi4.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "折荷有赠\n[唐]李白\n涉江玩秋水，\n爱此红蕖鲜。\n攀荷弄其珠，\n荡漾不成圆。\n佳人彩云里，\n欲赠隔远天。\n相思无因见，\n怅望凉风前。";
            };
            var button_shi5 = FindViewById<Button>(Resource.Id.shi5);
            button_shi5.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "晓出净慈寺送林子方\n[宋]杨万里\n毕竟西湖六月中， \n风光不与四时同。\n接天莲叶无穷碧， \n映日荷花别样红。";
            };
            var button_shi6 = FindViewById<Button>(Resource.Id.shi6);
            button_shi6.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "古风\n[唐]李白\n碧荷生幽泉，\n朝日艳且鲜。\n秋花冒绿水，\n密叶罗青烟。\n秀色粉绝世，\n馨香谁为传？\n坐看飞霜满，\n凋此红芳年。\n结根未得所，\n愿托华池边。\n";
            };
            var button_shi7 = FindViewById<Button>(Resource.Id.shi7);
            button_shi7.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "江南\n[汉]佚名\n江南可采莲，\n莲叶何田田。\n鱼戏莲叶间，\n鱼戏莲叶东，\n鱼戏莲叶西，\n鱼戏莲叶南，\n鱼戏莲叶北。\n";
            };
            var button_shi8 = FindViewById<Button>(Resource.Id.shi8);
            button_shi8.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "芙 蓉\n[唐]温庭筠\n刺茎澹荡碧， \n花片参差红。 \n吴歌秋水冷， \n湘庙夜云空。 \n浓艳香露里， \n美人清镜中。 \n南楼未归容， \n一夕练塘东。";
            };
            var button_shi9 = FindViewById<Button>(Resource.Id.shi9);
            button_shi9.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "莲花坞\n[唐]王维\n日日采莲去，\n洲长多暮归。\n开篙莫溅水，\n畏湿红莲衣。";
            };
            var button_shi10 = FindViewById<Button>(Resource.Id.shi10);
            button_shi10.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "赠荷花\n[唐]李商隐\n世间花叶不相伦，\n花入金盆叶作尘。\n惟有绿荷红菡萏，\n卷舒开合任天真。\n此荷此叶常相映，\n翠减红衰愁杀人。";
            };
            //词
            var button_shi11 = FindViewById<Button>(Resource.Id.shi11);
            button_shi11.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "如梦令\n[宋]李清照\n常记溪亭日暮，\n沉醉不知归路。\n兴尽晚归舟，\n误入藕花深处。\n争渡，争渡，\n惊起一滩鸥鹭。";
            };
            var button_shi12 = FindViewById<Button>(Resource.Id.shi12);
            button_shi12.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "卜算子 荷花\n[宋]辛弃疾\n红粉靓梳妆，\n翠盖低风雨。\n占断人间六月凉，\n期月鸳鸯浦。\n根底藕丝长，\n花里莲心苦。\n只为风流有许愁，\n更衬佳人步。";
            };
            var button_shi13 = FindViewById<Button>(Resource.Id.shi13);
            button_shi13.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "苏幕遮\n[宋]周邦彦\n    燎沉香，消溽暑。鸟雀呼晴，侵晓窥檐语。叶上初阳干宿雨，水面清圆，一一风荷举。\n    故乡遥，何日去？家住吴门，久作长安旅。五月渔郎相忆否？小楫轻舟，梦入芙蓉浦。";
            };
            var button_shi14 = FindViewById<Button>(Resource.Id.shi14);
            button_shi14.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "望海潮\n[宋]柳永\n    东南形胜，三吴都会，钱塘自古繁华。烟柳画桥，风帘翠幕，参差十万人家。云树绕堤沙。怒涛卷霜雪，天堑无涯。市列珠玑，户盈罗绮竞豪奢。\n    重湖叠巘清嘉。有三秋桂子，十里荷花。羌管弄晴，菱歌泛夜，嬉嬉钓叟莲娃。千骑拥高牙。乘醉听箫鼓，吟赏烟霞。异日图将好景，归去凤池夸。";
            };
            var button_shi15 = FindViewById<Button>(Resource.Id.shi15);
            button_shi15.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "荷花媚 荷花\n[宋]苏轼\n    霞苞电荷碧。天然地、别是风流标格。重重青盖下，千娇照水，好红红白白。\n    每怅望、明月清风夜，甚低不语，妖邪无力。终须放、船儿去，清香深处住，看伊颜色。";
            };
            var button_shi16 = FindViewById<Button>(Resource.Id.shi16);
            button_shi16.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "一剪梅\n[宋]李清照\n    红藕香残玉簟秋，轻解罗裳，独上兰舟。云中谁寄锦书来？雁字回时，月满西楼。\n    花自飘零水自流。一种相思，两处闲愁。此情无计可消除，才下眉头，却上心头。";
            };
            var button_shi17 = FindViewById<Button>(Resource.Id.shi17);
            button_shi17.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "蝶恋花\n[宋]欧阳修\n    越女采莲秋水畔。窄袖轻罗，暗露双金钏。照影摘花花似面。芳心只共丝争乱。\n    鸂鶒滩头风浪晚。雾重烟轻，不见来时伴。隐隐歌声归棹远。离愁引著江南岸。";
            };
            var button_shi18 = FindViewById<Button>(Resource.Id.shi18);
            button_shi18.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "爱莲说\n[宋]周敦颐\n    水陆草木之花，可爱者甚蕃。晋陶渊明独爱菊。自李唐来，世人甚爱牡丹。予独爱莲之出淤泥而不染，濯清涟而不妖，中通外直，不蔓不枝，香远益清，亭亭净植，可远观而不可亵玩焉。\n    予谓菊，花之隐逸者也；牡丹，花之富贵者也；莲，花之君子者也。噫！菊之爱，陶后鲜有闻；莲之爱，同予者何人？牡丹之爱，宜乎众矣！";
            };
            var button_shi19 = FindViewById<Button>(Resource.Id.shi19);
            button_shi19.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "采桑子\n[宋]晏几道\n    湘妃浦口莲开尽，昨夜红稀。懒过前溪，闲舣扁舟看雁飞。\n    去年谢女池边醉，晚雨霏微，记得归时，旋折新荷盖舞衣。";
            };
            var button_shi20 = FindViewById<Button>(Resource.Id.shi20);
            button_shi20.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "踏莎行\n[宋]张先\n    衾凤犹温，笼鹦尚睡。宿妆稀淡眉成字。映花避月上行廊，珠裙褶褶轻垂地。\n    翠幕成波，新荷贴水。纷纷烟柳低还起。重墙绕院更重门，春风无路通深意。";
            };
            var button_shi21 = FindViewById<Button>(Resource.Id.shi21);
            button_shi21.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "鹧鸪天  莲\n[金]元好问\n    瘦绿愁红倚暮烟，露华凉冷洗婵娟。含情脉脉知谁怨，顾影依依定自怜。\n    风送雨、水连天，凌波无梦夜如年。何时北诸亭边月，狼藉秋香拂画船。";
            };
            var button_shi22 = FindViewById<Button>(Resource.Id.shi22);
            button_shi22.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "水调歌头\n[元]赵孟頫\n    江湖渺何许，归兴浩无边。忽闻数声水调，令我意悠然。莫笑盆池咫尺，移得风烟万倾，来傍小窗前。稀疏淡红翠，特地向人妍。\n    华峰头，花十丈，藕如船。哪知此中佳趣，别是小壶天。倒挽碧筒酾酒，醉卧绿云深处，云影自田田。梦中呼一叶，散发看书眠。";
            };
            var button_shi23 = FindViewById<Button>(Resource.Id.shi23);
            button_shi23.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "水仙子咏江南\n[元]张养浩\n 一江烟水照晴岚，两岸人家接画檐。芰荷丛一段秋光淡，看沙鸥舞再三，卷香风十里珠帘。画船儿天边至，酒旗儿风外飐，爱煞江南。";
            };
            var button_shi24 = FindViewById<Button>(Resource.Id.shi24);
            button_shi24.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "菩萨蛮\n[宋]魏夫人\n红楼斜倚连溪曲，\n楼前溪水凝寒玉。\n荡漾木兰船，\n船中人少年。\n荷花娇欲语，\n笑入鸳鸯浦。\n波上暝烟低，\n菱歌月下归。";
            };
            var button_shi25 = FindViewById<Button>(Resource.Id.shi25);
            button_shi25.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "采莲赋\n[南朝]梁元帝\n    紫茎兮文波，红莲兮芰荷。绿房兮翠盖，素实兮黄螺。 于是妖童媛女，荡舟心许，鷁首徐回，兼 传羽杯。櫂将移而藻挂，船欲动而萍开。尔其纤腰束素，迁延顾步。夏始春余，叶嫩花初。恐沾裳而浅笑，畏倾船而敛裾， 故以水溅兰桡，芦侵罗褠。菊泽未反，梧台迥见，荇湿沾衫，菱长绕钏。泛柏舟而容与，歌采莲于江渚。歌曰：“碧玉小家女，来嫁汝南王。莲花乱脸色，荷叶杂衣香。因持荐君子，愿袭芙蓉裳。”";
            };
            var button_shi26 = FindViewById<Button>(Resource.Id.shi26);
            button_shi26.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "三益塘芙蓉\n[元]萨都剌\n 斑帘十二卷轻碧，\n秋水芙蓉隔画栏。\n彩扇摇风霞透影，\n锦袍弄月酒生寒。\n游魂翠袖留江浦，\n仙掌红云湿露盘。\n只恐淮南霜信早，\n绛纱笼烛夜深看。";
            };
            var button_shi27 = FindViewById<Button>(Resource.Id.shi27);
            button_shi27.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //此处先开动画再变文字，貌似不合理，但是显示时正常的，不知道为何
                poem_text.Text = "钱氏池上芙蓉\n[明]文征明\n九月江南花事休，\n芙蓉宛转在中洲。\n美人笑隔盈盈水，\n落日还生渺渺愁。\n露洗玉盘金殿冷，\n风吹罗带锦城秋。\n相看未用伤迟暮，\n别有池塘一种幽。";
            };
        }
        //物理返回键事件
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_poem = FindViewById<LinearLayout>(Resource.Id.LotusPoem);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//后退动画
                lotus_poem.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}