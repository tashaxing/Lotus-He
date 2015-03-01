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
//����Ϸ 2����
namespace Lotus
{
    [Activity(Label = "LogoActivity4_2")]
    public class LogoActivity4_2 : Activity     
    {
        //����ʫ���ַ���
        string[] poems =new string[]{
                             "������ \n��Ҷ��ȹһɫ�ã�\nܽ���������߿���\n������п�������\n�Ÿ�ʼ����������",
                              "С��\nȪ������Ϫϸ����\n������ˮ�����ᡣ\nС�ɲ�¶���ǣ�\n������������ͷ��",
                              "���������������ӷ�\n�Ͼ����������У� \n��ⲻ����ʱͬ��\n������Ҷ����̣� \nӳ�պɻ������졣",
                              "�ۺ�����\n�潭����ˮ��\n���˺�ޡ�ʡ�\n�ʺ�Ū���飬\n��������Բ��\n���˲����\n������Զ�졣\n��˼�������\n��������ǰ��",
                              "ܽ ��\n�̾�壵��̣� \n��Ƭ�β�졣 \n�����ˮ�䣬 \n����ҹ�ƿա� \nŨ����¶� \n�����徵�С� \n��¥δ���ݣ� \nһϦ��������",
                              "������\n���ղ���ȥ��\n�޳���ĺ�顣\n����Ī��ˮ��\nηʪ�����¡�",
                              "������\n����Ϫͤ��ĺ��\n����֪��·��\n�˾�����ۣ�\n����ź�����\n���ɣ����ɣ�\n����һ̲Ÿ�ء�",
                              "��Ļ��\n    �ǳ��㣬�������ȸ���磬���������Ҷ�ϳ��������꣬ˮ����Բ��һһ��ɾ١�\n    ����ң������ȥ����ס���ţ����������á��������������С����ۣ�����ܽ���֡�",
                              "������\n    ������ʤ�����ⶼ�ᣬǮ���Թŷ������������ţ�������Ļ���β�ʮ���˼ҡ������Ƶ�ɳ��ŭ�ξ�˪ѩ����ǵ���ġ��������ᣬ��ӯ��精����ݡ�\n    �غ����t��Ρ���������ӣ�ʮ��ɻ���Ǽ��Ū�磬��跺ҹ�����ҵ������ޡ�ǧ��ӵ��������������ģ�������ϼ������ͼ���þ�����ȥ��ؿ䡣",
                      "�ɻ��� �ɻ�\n    ϼ����ɱ̡���Ȼ�ء����Ƿ��������������£�ǧ����ˮ���ú��װס�\n    ÿ�������������ҹ�����Ͳ����а����������š�����ȥ�������ס��������ɫ��",
                      "һ��÷\n    ��ź��������������ѣ��������ۡ�����˭�Ľ����������ֻ�ʱ��������¥��\n    ����Ʈ��ˮ������һ����˼�������г�����޼ƿ�����������üͷ��ȴ����ͷ��",
                      "������\n    ԽŮ������ˮ�ϡ�խ�����ޣ���¶˫���ˡ���Ӱժ�������档����ֻ��˿���ҡ�\n    ����̲ͷ�������������ᣬ������ʱ�顣������������Զ������������ϰ���",
                      "����˵\n    ˮ½��ľ֮�����ɰ�����ެ������Ԩ�������ա�������������������ĵ�����������֮���������Ⱦ�����������������ͨ��ֱ��������֦����Զ���壬ͤͤ��ֲ����Զ�۶����������ɡ�\n    ��ν�գ���֮������Ҳ��ĵ������֮������Ҳ��������֮������Ҳ���棡��֮�����պ������ţ���֮����ͬ���ߺ��ˣ�ĵ��֮�����˺����ӣ�"


        };
        //������רҵ�ַ���
        string[] author = new string[]{
            "������",
            "������",
            "������",
            "���",
            "��ͥ��",
            "��ά",
            "������",
            "�ܰ���",
            "����",
            "����",
            "������",
            "ŷ����",
            "�ܶ���"


        };

                
          
        protected override void OnCreate(Bundle bundle)
        {
    

            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.game2);
            var lotus_game2 = FindViewById<LinearLayout>(Resource.Id.LayoutGame2);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_game2.StartAnimation(in_animation);
            //���ؼ�����
            ImageButton btn_back4_2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack4_2);
            btn_back4_2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_game2.StartAnimation(out_animation);
                this.OnBackPressed();
            };
           
            //��Ϸ�߼�
            var text_frame = FindViewById<LinearLayout>(Resource.Id.Game2_textlayout);
            var text_poem = FindViewById<TextView>(Resource.Id.game2_text);
            var buttonOK = FindViewById<Button>(Resource.Id.button_ok);
            var edit_text = FindViewById<EditText>(Resource.Id.text_input);
            var tip = FindViewById<TextView>(Resource.Id.tip_text);
            //����Ч��
            var anim_text = AnimationUtils.LoadAnimation(this, Resource.Animation.game2_in);
            int i = 0;
            int count=0;
            int flag = 0;  //��¼��Ϸ״�壬0Ϊ������1��ʾ������
            buttonOK.Click += (sender, e) =>
                {
                    if(flag==0)
                    {
                        flag=1;
                        text_poem.Text = poems[i];
                        text_poem.StartAnimation(anim_text);
                        buttonOK.Text = "ȷ��";
                        text_frame.SetBackgroundResource(Resource.Drawable.nezha_1);
                        tip.Text = "����" + count.ToString() + "��";
                       
                    }               
                    else
                    {
                        if(edit_text.Text==author[i])
                        {
                            i++;
                            if (i == 13)
                            {
                                tip.Text = "��ʤ";
                                i = 0;      //��������λ
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
                                tip.Text = "����" + count.ToString() + "��";
                            }
                            
                        }
                        else
                        {
                            i = 0;                //��������λ
                            count = 0;
                            flag = 0;
                            tip.Text = "ʧ��";
                            buttonOK.Text="Replay";
                            text_frame.SetBackgroundResource(Resource.Drawable.nezha);
                        }
                    }
                };
            
        }

        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_game2= FindViewById<LinearLayout>(Resource.Id.LayoutGame2);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_game2.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}