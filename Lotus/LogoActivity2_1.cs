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
//��ʫ�ʽ���
namespace Lotus
{
    [Activity(Label = "LogoActivity2")]
    public class LogoActivity2_1 : Activity     
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            //���ؽ���
            SetContentView(Resource.Layout.poem_list);
            var lotus_poem = FindViewById<LinearLayout>(Resource.Id.LotusPoem);
            var in_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_in);
            lotus_poem.StartAnimation(in_animation);

           
            //���ؼ�����
            ImageButton btn_back2 = FindViewById<ImageButton>(Resource.Id.imageButtonBack2_2);
            btn_back2.Click += delegate
            {
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_poem.StartAnimation(out_animation);
                this.OnBackPressed();
            };

            //��ʫ�ʰ�ť�¼�
            var poem_text = FindViewById<TextView>(Resource.Id.textPoem);   //ʫ������
            //var poem_text_block=FindViewById<ScrollView>(Resource.Id.text_poem_block);  //ʫ�ʿ�
           //ʫ
            var button_shi1 = FindViewById<Button>(Resource.Id.shi1);
            button_shi1.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������ \n[��]������\n��Ҷ��ȹһɫ�ã�\nܽ���������߿���\n������п�������\n�Ÿ�ʼ����������";
            };
            var button_shi2 = FindViewById<Button>(Resource.Id.shi2);
            button_shi2.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������\n[�ϳ�]�ָ�\n���������\n��������ͷ��\n��ͷŪ���ӣ�\n��������ˮ��";
            };
            var button_shi3 = FindViewById<Button>(Resource.Id.shi3);
            button_shi3.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "С��\n[��]������\nȪ������Ϫϸ����\n������ˮ�����ᡣ\nС�ɲ�¶���ǣ�\n������������ͷ��";
            };
            var button_shi4 = FindViewById<Button>(Resource.Id.shi4);
            button_shi4.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "�ۺ�����\n[��]���\n�潭����ˮ��\n���˺�ޡ�ʡ�\n�ʺ�Ū���飬\n��������Բ��\n���˲����\n������Զ�졣\n��˼�������\n��������ǰ��";
            };
            var button_shi5 = FindViewById<Button>(Resource.Id.shi5);
            button_shi5.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "���������������ӷ�\n[��]������\n�Ͼ����������У� \n��ⲻ����ʱͬ��\n������Ҷ����̣� \nӳ�պɻ������졣";
            };
            var button_shi6 = FindViewById<Button>(Resource.Id.shi6);
            button_shi6.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "�ŷ�\n[��]���\n�̺�����Ȫ��\n���������ʡ�\n�ﻨð��ˮ��\n��Ҷ�����̡�\n��ɫ�۾�����\nܰ��˭Ϊ����\n������˪����\n��˺췼�ꡣ\n���δ������\nԸ�л��رߡ�\n";
            };
            var button_shi7 = FindViewById<Button>(Resource.Id.shi7);
            button_shi7.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "����\n[��]����\n���Ͽɲ�����\n��Ҷ�����\n��Ϸ��Ҷ�䣬\n��Ϸ��Ҷ����\n��Ϸ��Ҷ����\n��Ϸ��Ҷ�ϣ�\n��Ϸ��Ҷ����\n";
            };
            var button_shi8 = FindViewById<Button>(Resource.Id.shi8);
            button_shi8.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "ܽ ��\n[��]��ͥ��\n�̾�壵��̣� \n��Ƭ�β�졣 \n�����ˮ�䣬 \n����ҹ�ƿա� \nŨ����¶� \n�����徵�С� \n��¥δ���ݣ� \nһϦ��������";
            };
            var button_shi9 = FindViewById<Button>(Resource.Id.shi9);
            button_shi9.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������\n[��]��ά\n���ղ���ȥ��\n�޳���ĺ�顣\n����Ī��ˮ��\nηʪ�����¡�";
            };
            var button_shi10 = FindViewById<Button>(Resource.Id.shi10);
            button_shi10.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "���ɻ�\n[��]������\n���仨Ҷ�����ף�\n�������Ҷ������\nΩ���̺ɺ����̣�\n���濪�������档\n�˺ɴ�Ҷ����ӳ��\n�����˥��ɱ�ˡ�";
            };
            //��
            var button_shi11 = FindViewById<Button>(Resource.Id.shi11);
            button_shi11.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������\n[��]������\n����Ϫͤ��ĺ��\n����֪��·��\n�˾�����ۣ�\n����ź�����\n���ɣ����ɣ�\n����һ̲Ÿ�ء�";
            };
            var button_shi12 = FindViewById<Button>(Resource.Id.shi12);
            button_shi12.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������ �ɻ�\n[��]������\n�������ױ��\n��ǵͷ��ꡣ\nռ���˼���������\n����ԧ���֡�\n����ź˿����\n�������Ŀࡣ\nֻΪ��������\n���ļ��˲���";
            };
            var button_shi13 = FindViewById<Button>(Resource.Id.shi13);
            button_shi13.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "��Ļ��\n[��]�ܰ���\n    �ǳ��㣬�������ȸ���磬���������Ҷ�ϳ��������꣬ˮ����Բ��һһ��ɾ١�\n    ����ң������ȥ����ס���ţ����������á��������������С����ۣ�����ܽ���֡�";
            };
            var button_shi14 = FindViewById<Button>(Resource.Id.shi14);
            button_shi14.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������\n[��]����\n    ������ʤ�����ⶼ�ᣬǮ���Թŷ������������ţ�������Ļ���β�ʮ���˼ҡ������Ƶ�ɳ��ŭ�ξ�˪ѩ����ǵ���ġ��������ᣬ��ӯ��精����ݡ�\n    �غ����t��Ρ���������ӣ�ʮ��ɻ���Ǽ��Ū�磬��跺ҹ�����ҵ������ޡ�ǧ��ӵ��������������ģ�������ϼ������ͼ���þ�����ȥ��ؿ䡣";
            };
            var button_shi15 = FindViewById<Button>(Resource.Id.shi15);
            button_shi15.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "�ɻ��� �ɻ�\n[��]����\n    ϼ����ɱ̡���Ȼ�ء����Ƿ��������������£�ǧ����ˮ���ú��װס�\n    ÿ�������������ҹ�����Ͳ����а����������š�����ȥ�������ס��������ɫ��";
            };
            var button_shi16 = FindViewById<Button>(Resource.Id.shi16);
            button_shi16.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "һ��÷\n[��]������\n    ��ź��������������ѣ��������ۡ�����˭�Ľ����������ֻ�ʱ��������¥��\n    ����Ʈ��ˮ������һ����˼�������г�����޼ƿ�����������üͷ��ȴ����ͷ��";
            };
            var button_shi17 = FindViewById<Button>(Resource.Id.shi17);
            button_shi17.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������\n[��]ŷ����\n    ԽŮ������ˮ�ϡ�խ�����ޣ���¶˫���ˡ���Ӱժ�������档����ֻ��˿���ҡ�\n    ����̲ͷ�������������ᣬ������ʱ�顣������������Զ������������ϰ���";
            };
            var button_shi18 = FindViewById<Button>(Resource.Id.shi18);
            button_shi18.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "����˵\n[��]�ܶ���\n    ˮ½��ľ֮�����ɰ�����ެ������Ԩ�������ա�������������������ĵ�����������֮���������Ⱦ�����������������ͨ��ֱ��������֦����Զ���壬ͤͤ��ֲ����Զ�۶����������ɡ�\n    ��ν�գ���֮������Ҳ��ĵ������֮������Ҳ��������֮������Ҳ���棡��֮�����պ������ţ���֮����ͬ���ߺ��ˣ�ĵ��֮�����˺����ӣ�";
            };
            var button_shi19 = FindViewById<Button>(Resource.Id.shi19);
            button_shi19.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "��ɣ��\n[��]�̼���\n    �����ֿ�����������ҹ��ϡ������ǰϪ���������ۿ���ɡ�\n    ȥ��лŮ�ر���������΢���ǵù�ʱ�������ºɸ����¡�";
            };
            var button_shi20 = FindViewById<Button>(Resource.Id.shi20);
            button_shi20.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "̤ɯ��\n[��]����\n    �������£�������˯����ױϡ��ü���֡�ӳ�����������ȣ���ȹ�����ᴹ�ء�\n    ��Ļ�ɲ����º���ˮ���׷������ͻ�����ǽ��Ժ�����ţ�������·ͨ���⡣";
            };
            var button_shi21 = FindViewById<Button>(Resource.Id.shi21);
            button_shi21.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "�����  ��\n[��]Ԫ����\n    ���̳����ĺ�̣�¶������ϴ濾ꡣ��������֪˭Թ����Ӱ������������\n    �����ꡢˮ���죬�貨����ҹ���ꡣ��ʱ����ͤ���£��ǽ������������";
            };
            var button_shi22 = FindViewById<Button>(Resource.Id.shi22);
            button_shi22.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "ˮ����ͷ\n[Ԫ]�����\\n    ������������˺��ޱߡ���������ˮ������������Ȼ��ĪЦ�����ߣ��Ƶ÷������㣬����С��ǰ��ϡ�赭��䣬�ص���������\n    ����ͷ����ʮ�ɣ�ź�紬����֪���м�Ȥ������С���졣�����Ͳ���ƣ��������������Ӱ��������к�һҶ��ɢ�������ߡ�";
            };
            var button_shi23 = FindViewById<Button>(Resource.Id.shi23);
            button_shi23.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "ˮ����ӽ����\n[Ԫ]������\n һ����ˮ����ᰣ������˼ҽӻ��ܡ����ɴ�һ����⵭����ɳŸ�������������ʮ�������������������������������s����ɷ���ϡ�";
            };
            var button_shi24 = FindViewById<Button>(Resource.Id.shi24);
            button_shi24.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������\n[��]κ����\n��¥б����Ϫ����\n¥ǰϪˮ������\n����ľ������\n���������ꡣ\n�ɻ������\nЦ��ԧ���֡�\n�������̵ͣ�\n������¹顣";
            };
            var button_shi25 = FindViewById<Button>(Resource.Id.shi25);
            button_shi25.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������\n[�ϳ�]��Ԫ��\n    �Ͼ����Ĳ������������ɡ��̷����ǣ���ʵ����ݡ� ������ͯ��Ů�����������^����أ��� ���𱭡������ƶ���ң���������Ƽ���������������أ�Ǩ�ӹ˲�����ʼ���࣬Ҷ�ۻ�������մ�Ѷ�ǳЦ��η�㴬�����գ� ����ˮ�����㣬«����ѐ������δ������̨�ļ�����ʪմ�����ⳤ���ˡ������۶����룬������ڽ�価���Ի��������С��Ů����������������������ɫ����Ҷ�����㡣��ּ����ӣ�ԸϮܽ���ѡ���";
            };
            var button_shi26 = FindViewById<Button>(Resource.Id.shi26);
            button_shi26.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "������ܽ��\n[Ԫ]������\n ����ʮ������̣�\n��ˮܽ�ظ�������\n����ҡ��ϼ͸Ӱ��\n����Ū�¾�������\n�λ���������֣�\n���ƺ���ʪ¶�̡�\nֻ�ֻ���˪���磬\n�ɴ����ҹ���";
            };
            var button_shi27 = FindViewById<Button>(Resource.Id.shi27);
            button_shi27.Click += delegate
            {
                var block_anim = AnimationUtils.LoadAnimation(this, Resource.Animation.poem_change);
                poem_text.StartAnimation(block_anim);   //�˴��ȿ������ٱ����֣�ò�Ʋ�����������ʾʱ�����ģ���֪��Ϊ��
                poem_text.Text = "Ǯ�ϳ���ܽ��\n[��]������\n���½��ϻ����ݣ�\nܽ����ת�����ޡ�\n����Ц��ӯӯˮ��\n���ջ�������\n¶ϴ���̽���䣬\n�紵�޴������\n�࿴δ���˳�ĺ��\n���г���һ���ġ�";
            };
        }
        //�����ؼ��¼�
        public override bool OnKeyDown(Keycode keyCode, KeyEvent e)
        {
            if (keyCode == Keycode.Back && e.Action == KeyEventActions.Down)
            {
                var lotus_poem = FindViewById<LinearLayout>(Resource.Id.LotusPoem);
                var out_animation = AnimationUtils.LoadAnimation(this, Resource.Animation.zoom_out);//���˶���
                lotus_poem.StartAnimation(out_animation);
                this.OnBackPressed();

                return true;
            }
            else
                return this.OnKeyDown(keyCode, e); ;


        }
    }
}