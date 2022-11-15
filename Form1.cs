using MinecraftSlashBladeGenerator.Properties;

using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Runtime.InteropServices;

namespace MinecraftSlashBladeGenerator;

public partial class Form1 : Form {

  [DllImport("user32.dll")]
  private static extern int GetScrollPos(IntPtr hwnd, int nBar);

  public Form1() {
    InitializeComponent();
    textBox2.KeyPress += text_keypress;
    textBox3.KeyPress += text_keypress;
    textBox4.KeyPress += text_keypress;
    textBox5.KeyPress += text_keypress;
    textBox6.KeyPress += text_keypress;
    textBox7.KeyPress += text_keypress;
    textBox8.KeyPress += text_keypress;
    textBox23.KeyPress += text_keypress;
    textBox69.KeyPress += text_keypress;
  }

  private void text_keypress(object sender, KeyPressEventArgs e) {
    if (char.IsNumber(e.KeyChar) || e.KeyChar == '\r' || e.KeyChar == '\b') {
      return;
    }

    e.Handled = true;
  }

  private void Form1_Load(object sender, EventArgs e) {
    AutoScroll = true;
    ModelGrid.Rows.Add(440);
    SpecialAttackGrid.Rows.Add(162);
    SpecialEffectGrid.Rows.Add(70);
    EnchantmentGrid.Rows.Add(30);
    AddBladeName();
    AddBladeSource();
    AddSaName();
    AddSaSource();
    AddSeName();
    AddSeSource();
    AddEnchantmentName();
  }

  private void AddBladeName() {
    ModelGrid.Rows[0].Cells[0].Value = "自定义";
    ModelGrid.Rows[1].Cells[0].Value = "鄂门 ";
    ModelGrid.Rows[2].Cells[0].Value = "鄂门 (锈) ";
    ModelGrid.Rows[3].Cells[0].Value = "刚剑「胴田贯」";
    ModelGrid.Rows[4].Cells[0].Value = "狐月刀「黑狐」";
    ModelGrid.Rows[5].Cells[0].Value = "狐月刀「白狐」";
    ModelGrid.Rows[6].Cells[0].Value = "枯石大刀";
    ModelGrid.Rows[7].Cells[0].Value = "「千鹤」村正";
    ModelGrid.Rows[8].Cells[0].Value = "大蛇鄂门";
    ModelGrid.Rows[9].Cells[0].Value = "鄂门 (锈)";
    ModelGrid.Rows[10].Cells[0].Value = "鄂门";
    ModelGrid.Rows[11].Cells[0].Value = "锈刀";
    ModelGrid.Rows[12].Cells[0].Value = "散华";
    ModelGrid.Rows[13].Cells[0].Value = "魔剑「阎魔刀」";
    ModelGrid.Rows[14].Cells[0].Value = "折断的阎魔刀";
    ModelGrid.Rows[15].Cells[0].Value = "夜叉";
    ModelGrid.Rows[16].Cells[0].Value = "夜叉";
    ModelGrid.Rows[17].Cells[0].Value = "结月刀「付丧」";
    ModelGrid.Rows[18].Cells[0].Value = "木刀「铁刀木」";
    ModelGrid.Rows[19].Cells[0].Value = "名刀「金刚」露台";
    ModelGrid.Rows[20].Cells[0].Value = "宝刀「山吹」露台";
    ModelGrid.Rows[21].Cells[0].Value = "利刀「铁」露台";
    ModelGrid.Rows[22].Cells[0].Value = "「锐岩」露台";
    ModelGrid.Rows[23].Cells[0].Value = "「击柝」露台";
    ModelGrid.Rows[24].Cells[0].Value = "利刀「无名」红玉";
    ModelGrid.Rows[25].Cells[0].Value = "妖刀「红樱」";
    ModelGrid.Rows[26].Cells[0].Value = "妖刀「似蛭」";
    ModelGrid.Rows[27].Cells[0].Value = "炼狱刀「死念」";
    ModelGrid.Rows[28].Cells[0].Value = "血刀「似蛭」";
    ModelGrid.Rows[29].Cells[0].Value = "狱刀「似蛭」";
    ModelGrid.Rows[30].Cells[0].Value = "暗鸦";
    ModelGrid.Rows[31].Cells[0].Value = "雪鸦";
    ModelGrid.Rows[32].Cells[0].Value = "荧光";
    ModelGrid.Rows[33].Cells[0].Value = "冻樱刃「雪花苍月」";
    ModelGrid.Rows[34].Cells[0].Value = "明兽刃「阳牙冰狼」";
    ModelGrid.Rows[35].Cells[0].Value = "神威刀「虎杖丸」";
    ModelGrid.Rows[36].Cells[0].Value = "神威刀「阿贝」";
    ModelGrid.Rows[37].Cells[0].Value = "神威刀「坎那」";
    ModelGrid.Rows[38].Cells[0].Value = "神威刀「乌卡」";
    ModelGrid.Rows[39].Cells[0].Value = "无神「无刃」";
    ModelGrid.Rows[40].Cells[0].Value = "幻魔炼金拵";
    ModelGrid.Rows[41].Cells[0].Value = "「千鹤」村雨";
    ModelGrid.Rows[42].Cells[0].Value = "侍月刀「炎水薄斩」";
    ModelGrid.Rows[43].Cells[0].Value = "圣幸刀「绿乃雾」";
    ModelGrid.Rows[44].Cells[0].Value = "月光樱「吹雪一闪」";
    ModelGrid.Rows[45].Cells[0].Value = "洞爷湖";
    ModelGrid.Rows[46].Cells[0].Value = "「风来之剑」";
    ModelGrid.Rows[47].Cells[0].Value = "「风来之械刃」";
    ModelGrid.Rows[48].Cells[0].Value = "龙太刀「噬风者」";
    ModelGrid.Rows[49].Cells[0].Value = "龙太刀「西风」";
    ModelGrid.Rows[50].Cells[0].Value = "刀";
    ModelGrid.Rows[51].Cells[0].Value = "太刀";
    ModelGrid.Rows[52].Cells[0].Value = "大地之刃";
    ModelGrid.Rows[53].Cells[0].Value = "型月刀「空之境界」";
    ModelGrid.Rows[54].Cells[0].Value = "结月刀「因缘」";
    ModelGrid.Rows[55].Cells[0].Value = "大太刀「」";
    ModelGrid.Rows[56].Cells[0].Value = "无铭刀「木偶」";
    ModelGrid.Rows[57].Cells[0].Value = "无铭刀「竹光」";
    ModelGrid.Rows[58].Cells[0].Value = "名刀「银纸竹光」";
    ModelGrid.Rows[59].Cells[0].Value = "利刀「白鞘「」";
    ModelGrid.Rows[60].Cells[0].Value = "山樱「葵」";
    ModelGrid.Rows[61].Cells[0].Value = "山樱文月";
    ModelGrid.Rows[62].Cells[0].Value = "山樱叶月";
    ModelGrid.Rows[63].Cells[0].Value = "山樱睦月「松」";
    ModelGrid.Rows[64].Cells[0].Value = "山樱神无月「枫」";
    ModelGrid.Rows[65].Cells[0].Value = "山樱长月「菊」";
    ModelGrid.Rows[66].Cells[0].Value = "山樱「水无月」";
    ModelGrid.Rows[67].Cells[0].Value = "山樱弥生「樱」";
    ModelGrid.Rows[68].Cells[0].Value = "山樱皋月";
    ModelGrid.Rows[69].Cells[0].Value = "山樱霜月";
    ModelGrid.Rows[70].Cells[0].Value = "山樱「师走」";
    ModelGrid.Rows[71].Cells[0].Value = "山樱「神月」";
    ModelGrid.Rows[72].Cells[0].Value = "山樱如月「梅」";
    ModelGrid.Rows[73].Cells[0].Value = "山樱卯月";
    ModelGrid.Rows[74].Cells[0].Value = "伪物「葵」";
    ModelGrid.Rows[75].Cells[0].Value = "名刀「亡者」";
    ModelGrid.Rows[76].Cells[0].Value = "伪物「亡者」";
    ModelGrid.Rows[77].Cells[0].Value = "「镇魂曲」";
    ModelGrid.Rows[78].Cells[0].Value = "「隐者之竹光」";
    ModelGrid.Rows[79].Cells[0].Value = "上品「银纸竹光」";
    ModelGrid.Rows[80].Cells[0].Value = "「血纸竹光」";
    ModelGrid.Rows[81].Cells[0].Value = "不死斩「拜泪」";
    ModelGrid.Rows[82].Cells[0].Value = "名刀「揳丸」";
    ModelGrid.Rows[83].Cells[0].Value = "天云「无念」";
    ModelGrid.Rows[84].Cells[0].Value = "天云「残云」";
    ModelGrid.Rows[85].Cells[0].Value = "天云「速风」";
    ModelGrid.Rows[86].Cells[0].Value = "文始";
    ModelGrid.Rows[87].Cells[0].Value = "「千兆」";
    ModelGrid.Rows[88].Cells[0].Value = "名刀「观楼剑」";
    ModelGrid.Rows[89].Cells[0].Value = "「楼观剑」";
    ModelGrid.Rows[90].Cells[0].Value = "「白楼剑」";
    ModelGrid.Rows[91].Cells[0].Value = "狱界剑「楼观剑」";
    ModelGrid.Rows[92].Cells[0].Value = "狱界剑「白楼剑」";
    ModelGrid.Rows[93].Cells[0].Value = "伪物「白楼剑」";
    ModelGrid.Rows[94].Cells[0].Value = "伪物「观楼剑」";
    ModelGrid.Rows[95].Cells[0].Value = "「楼观旋风刃」";
    ModelGrid.Rows[96].Cells[0].Value = "「白楼旋风刃」";
    ModelGrid.Rows[97].Cells[0].Value = "纳米太刀";
    ModelGrid.Rows[98].Cells[0].Value = "量子太刀";
    ModelGrid.Rows[99].Cells[0].Value = "「樱剪」";
    ModelGrid.Rows[100].Cells[0].Value = "驱魔刃「樱」";
    ModelGrid.Rows[101].Cells[0].Value = "驱魔刃「杏」";
    ModelGrid.Rows[102].Cells[0].Value = "驱魔刃「雪影」";
    ModelGrid.Rows[103].Cells[0].Value = "邪魔刃「双」";
    ModelGrid.Rows[104].Cells[0].Value = "邪魔刃「修罗」";
    ModelGrid.Rows[105].Cells[0].Value = "名刀「将军木」";
    ModelGrid.Rows[106].Cells[0].Value = "利刀「苍梅」";
    ModelGrid.Rows[107].Cells[0].Value = "斑鸠之刃";
    ModelGrid.Rows[108].Cells[0].Value = "天云「寒齿」";
    ModelGrid.Rows[109].Cells[0].Value = "「梨木利亚」";
    ModelGrid.Rows[110].Cells[0].Value = "渝州「长清」";
    ModelGrid.Rows[111].Cells[0].Value = "无铭「影狐」";
    ModelGrid.Rows[112].Cells[0].Value = "「V.V.V.V.V.」";
    ModelGrid.Rows[113].Cells[0].Value = "「祭钢刃」";
    ModelGrid.Rows[114].Cells[0].Value = "日耀剑「光日」";
    ModelGrid.Rows[115].Cells[0].Value = "平庸「斗刀」";
    ModelGrid.Rows[116].Cells[0].Value = "名刀「斗刀」";
    ModelGrid.Rows[117].Cells[0].Value = "斗刀「孤独」";
    ModelGrid.Rows[118].Cells[0].Value = "「伊布之刃」";
    ModelGrid.Rows[119].Cells[0].Value = "自锻刀「神秘」";
    ModelGrid.Rows[120].Cells[0].Value = "自锻刀「虚空」";
    ModelGrid.Rows[121].Cells[0].Value = "朴素拵";
    ModelGrid.Rows[122].Cells[0].Value = "落英拵";
    ModelGrid.Rows[123].Cells[0].Value = "三雷拵";
    ModelGrid.Rows[124].Cells[0].Value = "神秘要塞日本刀";
    ModelGrid.Rows[125].Cells[0].Value = "虚空要塞日本刀";
    ModelGrid.Rows[126].Cells[0].Value = "风雷要塞日本刀";
    ModelGrid.Rows[127].Cells[0].Value = "血腥要塞日本刀";
    ModelGrid.Rows[128].Cells[0].Value = "「要塞」神秘";
    ModelGrid.Rows[129].Cells[0].Value = "「要塞」虚无";
    ModelGrid.Rows[130].Cells[0].Value = "「要塞」风雷";
    ModelGrid.Rows[131].Cells[0].Value = "「要塞」血红";
    ModelGrid.Rows[132].Cells[0].Value = "自锻刀「红钢」";
    ModelGrid.Rows[133].Cells[0].Value = "自锻刀「蓝钢」";
    ModelGrid.Rows[134].Cells[0].Value = "阿尔忒弥斯「影月」";
    ModelGrid.Rows[135].Cells[0].Value = "海格力斯「闪耀之星」";
    ModelGrid.Rows[136].Cells[0].Value = "尼尔「永恒旋转之枪」";
    ModelGrid.Rows[137].Cells[0].Value = "伊恩「永恒时光之轮 · 永劫根源魔枪」";
    ModelGrid.Rows[138].Cells[0].Value = "厄瑞波斯「永黯沉寂」";
    ModelGrid.Rows[139].Cells[0].Value = "柯罗诺斯「永境之主」";
    ModelGrid.Rows[140].Cells[0].Value = "普洛托革诺伊「始源」";
    ModelGrid.Rows[141].Cells[0].Value = "村雨丸";
    ModelGrid.Rows[142].Cells[0].Value = "村锖丸";
    ModelGrid.Rows[143].Cells[0].Value = "星云剑「雾鸦」";
    ModelGrid.Rows[144].Cells[0].Value = "妖刀「神狐」";
    ModelGrid.Rows[145].Cells[0].Value = "木鞘「「神狐」";
    ModelGrid.Rows[146].Cells[0].Value = "锈迹斑斑的刀";
    ModelGrid.Rows[147].Cells[0].Value = "木鞘「「刃条」";
    ModelGrid.Rows[148].Cells[0].Value = "御神刀「神狐」";
    ModelGrid.Rows[149].Cells[0].Value = "「魔刀千刃」";
    ModelGrid.Rows[150].Cells[0].Value = "狱刀「死念」赝";
    ModelGrid.Rows[151].Cells[0].Value = "炼狱刀「真红」";
    ModelGrid.Rows[152].Cells[0].Value = "小太刀「小金兔」";
    ModelGrid.Rows[153].Cells[0].Value = "小太刀「小鸟丸」";
    ModelGrid.Rows[154].Cells[0].Value = "小太刀「咲夜子」";
    ModelGrid.Rows[155].Cells[0].Value = "小太刀「落华」";
    ModelGrid.Rows[156].Cells[0].Value = "小太刀「」";
    ModelGrid.Rows[157].Cells[0].Value = "太刀「左伊多津万」";
    ModelGrid.Rows[158].Cells[0].Value = "「密陀僧」";
    ModelGrid.Rows[159].Cells[0].Value = "龙剑「行草俱利伽罗刻」";
    ModelGrid.Rows[160].Cells[0].Value = "曙色斩月";
    ModelGrid.Rows[161].Cells[0].Value = "落樱何思";
    ModelGrid.Rows[162].Cells[0].Value = "「鹿丸」";
    ModelGrid.Rows[163].Cells[0].Value = "「罗盘草」";
    ModelGrid.Rows[164].Cells[0].Value = "「暮雨」正宗";
    ModelGrid.Rows[165].Cells[0].Value = "一斥染「甚三红」";
    ModelGrid.Rows[166].Cells[0].Value = "太刀「花绀青伽罗」独钴";
    ModelGrid.Rows[167].Cells[0].Value = "炎刀「炽铁」露台";
    ModelGrid.Rows[168].Cells[0].Value = "利刀「钢叶」露台";
    ModelGrid.Rows[169].Cells[0].Value = "利刀「铁树」露台";
    ModelGrid.Rows[170].Cells[0].Value = "利刀「铁骑」露台";
    ModelGrid.Rows[171].Cells[0].Value = "宝刀「霜冻」露台";
    ModelGrid.Rows[172].Cells[0].Value = "名刀「玻璃」露台";
    ModelGrid.Rows[173].Cells[0].Value = "血色木偶";
    ModelGrid.Rows[174].Cells[0].Value = "美工刀";
    ModelGrid.Rows[175].Cells[0].Value = "青云";
    ModelGrid.Rows[176].Cells[0].Value = "水波折";
    ModelGrid.Rows[177].Cells[0].Value = "陨星杖";
    ModelGrid.Rows[178].Cells[0].Value = "轩辕剑";
    ModelGrid.Rows[179].Cells[0].Value = "黑刃";
    ModelGrid.Rows[180].Cells[0].Value = "八卦剑";
    ModelGrid.Rows[181].Cells[0].Value = "阴";
    ModelGrid.Rows[182].Cells[0].Value = "阳";
    ModelGrid.Rows[183].Cells[0].Value = "星流利刃";
    ModelGrid.Rows[184].Cells[0].Value = "洞虚幻刃";
    ModelGrid.Rows[185].Cells[0].Value = "锁狱镰";
    ModelGrid.Rows[186].Cells[0].Value = "静秘守卫";
    ModelGrid.Rows[187].Cells[0].Value = "撼地巨锤";
    ModelGrid.Rows[188].Cells[0].Value = "柮夭";
    ModelGrid.Rows[189].Cells[0].Value = "擒苍";
    ModelGrid.Rows[190].Cells[0].Value = "逐焰";
    ModelGrid.Rows[191].Cells[0].Value = "勤忙";
    ModelGrid.Rows[192].Cells[0].Value = "血月";
    ModelGrid.Rows[193].Cells[0].Value = "星典";
    ModelGrid.Rows[194].Cells[0].Value = "激光剑1";
    ModelGrid.Rows[195].Cells[0].Value = "激光剑2";
    ModelGrid.Rows[196].Cells[0].Value = "激光剑3";
    ModelGrid.Rows[197].Cells[0].Value = "锁魂";
    ModelGrid.Rows[198].Cells[0].Value = "神陨剑";
    ModelGrid.Rows[199].Cells[0].Value = "时之镰";
    ModelGrid.Rows[200].Cells[0].Value = "长空落日";
    ModelGrid.Rows[201].Cells[0].Value = "til的刀";
    ModelGrid.Rows[202].Cells[0].Value = "HTOD的刀";
    ModelGrid.Rows[203].Cells[0].Value = "XingKong的刀";
    ModelGrid.Rows[204].Cells[0].Value = "白刃";
    ModelGrid.Rows[205].Cells[0].Value = "血刃「栗山未来」";
    ModelGrid.Rows[206].Cells[0].Value = "月光紫「虚无之影」";
    ModelGrid.Rows[207].Cells[0].Value = "神钢刃「血腥革新」";
    ModelGrid.Rows[208].Cells[0].Value = "神钢刃「工艺复兴」";
    ModelGrid.Rows[209].Cells[0].Value = "灵钢刃「技术革新」";
    ModelGrid.Rows[210].Cells[0].Value = "灵钢刃「能量守恒」";
    ModelGrid.Rows[211].Cells[0].Value = "钢刃「源初」";
    ModelGrid.Rows[212].Cells[0].Value = "钢刃「纳米科技」";
    ModelGrid.Rows[213].Cells[0].Value = "钢刃「白狐」";
    ModelGrid.Rows[214].Cells[0].Value = "钢刃「黑狐」";
    ModelGrid.Rows[215].Cells[0].Value = "灵钢刃「仙狐」";
    ModelGrid.Rows[216].Cells[0].Value = "灵钢刃「灵狐」";
    ModelGrid.Rows[217].Cells[0].Value = "元素刀";
    ModelGrid.Rows[218].Cells[0].Value = "夜魔";
    ModelGrid.Rows[219].Cells[0].Value = "银灰";
    ModelGrid.Rows[220].Cells[0].Value = "无魂剑「」";
    ModelGrid.Rows[221].Cells[0].Value = "白金";
    ModelGrid.Rows[222].Cells[0].Value = "杀马人之刃";
    ModelGrid.Rows[223].Cells[0].Value = "拉普兰德";
    ModelGrid.Rows[224].Cells[0].Value = "拉普兰德「狼魂」";
    ModelGrid.Rows[225].Cells[0].Value = "管理员之刃「伪物」";
    ModelGrid.Rows[226].Cells[0].Value = "名刀「物理学圣剑」";
    ModelGrid.Rows[227].Cells[0].Value = "圣剑「银弹」";
    ModelGrid.Rows[228].Cells[0].Value = "铭刀「鱼音」";
    ModelGrid.Rows[229].Cells[0].Value = "铭刀「悭臾」";
    ModelGrid.Rows[230].Cells[0].Value = "铭刀「蟾宫」";
    ModelGrid.Rows[231].Cells[0].Value = "现世刀「斩月」";
    ModelGrid.Rows[232].Cells[0].Value = "星云剑「雾鸦」1";
    ModelGrid.Rows[233].Cells[0].Value = "星云剑「雾鸦」2";
    ModelGrid.Rows[234].Cells[0].Value = "星云剑「雾鸦」3";
    ModelGrid.Rows[235].Cells[0].Value = "星云剑「雾鸦」4";
    ModelGrid.Rows[236].Cells[0].Value = "星云剑「雾鸦」5";
    ModelGrid.Rows[237].Cells[0].Value = "星云剑「雾鸦」6";
    ModelGrid.Rows[238].Cells[0].Value = "星云剑「雾鸦」7";
    ModelGrid.Rows[239].Cells[0].Value = "星云剑「雾鸦」8";
    ModelGrid.Rows[240].Cells[0].Value = "星云剑「雾鸦」9";
    ModelGrid.Rows[241].Cells[0].Value = "星云剑「雾鸦」10";
    ModelGrid.Rows[242].Cells[0].Value = "星云剑「雾鸦」11";
    ModelGrid.Rows[243].Cells[0].Value = "星云剑「雾鸦」12";
    ModelGrid.Rows[244].Cells[0].Value = "星云剑「雾鸦」13";
    ModelGrid.Rows[245].Cells[0].Value = "星云剑「雾鸦」14";
    ModelGrid.Rows[246].Cells[0].Value = "星云剑「雾鸦」15";
    ModelGrid.Rows[247].Cells[0].Value = "星云剑「雾鸦」16";
    ModelGrid.Rows[248].Cells[0].Value = "星云剑「雾鸦」17";
    ModelGrid.Rows[249].Cells[0].Value = "";
    ModelGrid.Rows[250].Cells[0].Value = "原罪「暴怒」";
    ModelGrid.Rows[251].Cells[0].Value = "原罪「贪婪」";
    ModelGrid.Rows[252].Cells[0].Value = "原罪「傲慢」";
    ModelGrid.Rows[253].Cells[0].Value = "原罪「贪食」";
    ModelGrid.Rows[254].Cells[0].Value = "原罪「嫉妒」";
    ModelGrid.Rows[255].Cells[0].Value = "原罪「懒惰」";
    ModelGrid.Rows[256].Cells[0].Value = "原罪「色欲」";
    ModelGrid.Rows[257].Cells[0].Value = "原罪神「萨迈尔」";
    ModelGrid.Rows[258].Cells[0].Value = "原罪神「玛门」";
    ModelGrid.Rows[259].Cells[0].Value = "原罪神「路西法」";
    ModelGrid.Rows[260].Cells[0].Value = "原罪神「别西卜」";
    ModelGrid.Rows[261].Cells[0].Value = "原罪神「利维坦」";
    ModelGrid.Rows[262].Cells[0].Value = "原罪神「贝尔芬格」";
    ModelGrid.Rows[263].Cells[0].Value = "原罪神「阿斯莫德」";
    ModelGrid.Rows[264].Cells[0].Value = "「恶」";
    ModelGrid.Rows[265].Cells[0].Value = "「狱」";
    ModelGrid.Rows[266].Cells[0].Value = "狱刀「死念」赝 ";
    ModelGrid.Rows[267].Cells[0].Value = "炼狱刀「血腥」";
    ModelGrid.Rows[268].Cells[0].Value = "白兰剑「君」";
    ModelGrid.Rows[269].Cells[0].Value = "白の契约";
    ModelGrid.Rows[270].Cells[0].Value = "百兽剑王「巨狮」";
    ModelGrid.Rows[271].Cells[0].Value = "白の约定";
    ModelGrid.Rows[272].Cells[0].Value = "夜空之剑「阐释者」";
    ModelGrid.Rows[273].Cells[0].Value = "奉神刀「鹿」";
    ModelGrid.Rows[274].Cells[0].Value = "不可视之刃「风之影」· 风";
    ModelGrid.Rows[275].Cells[0].Value = "光剑「监视者」";
    ModelGrid.Rows[276].Cells[0].Value = "花之妖精「弥葵」· 花";
    ModelGrid.Rows[277].Cells[0].Value = "花天狂骨「花天」";
    ModelGrid.Rows[278].Cells[0].Value = "灾厄之源「劫」";
    ModelGrid.Rows[279].Cells[0].Value = "炎极必寒「极意」";
    ModelGrid.Rows[280].Cells[0].Value = "炎王「流刃若火」";
    ModelGrid.Rows[281].Cells[0].Value = "生机「绿萝」";
    ModelGrid.Rows[282].Cells[0].Value = "森森幽罗「青鬼」";
    ModelGrid.Rows[283].Cells[0].Value = "狗年专属「啸月」";
    ModelGrid.Rows[284].Cells[0].Value = "极寒刃「雪走」· 雪";
    ModelGrid.Rows[285].Cells[0].Value = "欺骗者「影月」· 月";
    ModelGrid.Rows[286].Cells[0].Value = "死神「幽之名」";
    ModelGrid.Rows[287].Cells[0].Value = "白「天锁斩月」";
    ModelGrid.Rows[288].Cells[0].Value = "31工-「紫龙息」";
    ModelGrid.Rows[289].Cells[0].Value = "31工-「金巴」";
    ModelGrid.Rows[290].Cells[0].Value = "工-「魔钢刃」";
    ModelGrid.Rows[291].Cells[0].Value = "工-「儊晓」";
    ModelGrid.Rows[292].Cells[0].Value = "工-「古一眉」";
    ModelGrid.Rows[293].Cells[0].Value = "黑快刀-「帝心」";
    ModelGrid.Rows[294].Cells[0].Value = "黑快刀-「银刃」";
    ModelGrid.Rows[295].Cells[0].Value = "幽狂-「赤浴血」";
    ModelGrid.Rows[296].Cells[0].Value = "炎王-「火红莲」";
    ModelGrid.Rows[297].Cells[0].Value = "宙雷大刀-「绿夜」";
    ModelGrid.Rows[298].Cells[0].Value = "质太刀-「舞纵」";
    ModelGrid.Rows[299].Cells[0].Value = "宇界起源-「翱」";
    ModelGrid.Rows[300].Cells[0].Value = "「村雨」壹";
    ModelGrid.Rows[301].Cells[0].Value = "「村雨」贰";
    ModelGrid.Rows[302].Cells[0].Value = "「村雨」叁";
    ModelGrid.Rows[303].Cells[0].Value = "「暗鸦」壹";
    ModelGrid.Rows[304].Cells[0].Value = "「暗鸦」贰";
    ModelGrid.Rows[305].Cells[0].Value = "「暗鸦」叁";
    ModelGrid.Rows[306].Cells[0].Value = "「暗鸦」肆";
    ModelGrid.Rows[307].Cells[0].Value = "「暗鸦」伍";
    ModelGrid.Rows[308].Cells[0].Value = "「暗鸦」陆";
    ModelGrid.Rows[309].Cells[0].Value = "「暗鸦」柒";
    ModelGrid.Rows[310].Cells[0].Value = "冻樱刃「雪花苍月」壹";
    ModelGrid.Rows[311].Cells[0].Value = "冻樱刃「雪花苍月」贰";
    ModelGrid.Rows[312].Cells[0].Value = "冻樱刃「雪花苍月」叁";
    ModelGrid.Rows[313].Cells[0].Value = "「荧光」壹";
    ModelGrid.Rows[314].Cells[0].Value = "「荧光」贰";
    ModelGrid.Rows[315].Cells[0].Value = "结月刀「付丧」壹";
    ModelGrid.Rows[316].Cells[0].Value = "结月刀「付丧」贰";
    ModelGrid.Rows[317].Cells[0].Value = "结月刀「付丧」叁";
    ModelGrid.Rows[318].Cells[0].Value = "结月刀「付丧」肆";
    ModelGrid.Rows[319].Cells[0].Value = "「剑圣之刃」壹";
    ModelGrid.Rows[320].Cells[0].Value = "「剑圣之刃」贰";
    ModelGrid.Rows[321].Cells[0].Value = "「剑圣之刃」叁";
    ModelGrid.Rows[322].Cells[0].Value = "「剑圣之刃」肆";
    ModelGrid.Rows[323].Cells[0].Value = "「剑圣之刃」伍";
    ModelGrid.Rows[324].Cells[0].Value = "「剑圣之刃」陆";
    ModelGrid.Rows[325].Cells[0].Value = "「剑圣之刃」柒";
    ModelGrid.Rows[326].Cells[0].Value = "「剑圣之刃」捌";
    ModelGrid.Rows[327].Cells[0].Value = "「剑圣之刃」玖";
    ModelGrid.Rows[328].Cells[0].Value = "「剑圣之刃」拾";
    ModelGrid.Rows[329].Cells[0].Value = "「剑圣之刃」拾壹";
    ModelGrid.Rows[330].Cells[0].Value = "「剑圣之刃」拾贰";
    ModelGrid.Rows[331].Cells[0].Value = "「剑圣之刃」拾叁";
    ModelGrid.Rows[332].Cells[0].Value = "明兽刃「阳牙冰狼」壹";
    ModelGrid.Rows[333].Cells[0].Value = "明兽刃「阳牙冰狼」贰";
    ModelGrid.Rows[334].Cells[0].Value = "明兽刃「阳牙冰狼」叁";
    ModelGrid.Rows[335].Cells[0].Value = "「千鹤」壹";
    ModelGrid.Rows[336].Cells[0].Value = "「千鹤」贰";
    ModelGrid.Rows[337].Cells[0].Value = "「千鹤」叁";
    ModelGrid.Rows[338].Cells[0].Value = "「千鹤」肆";
    ModelGrid.Rows[339].Cells[0].Value = "「黑刃」";
    ModelGrid.Rows[340].Cells[0].Value = "「白刃」";
    ModelGrid.Rows[341].Cells[0].Value = "「魔刃」";
    ModelGrid.Rows[342].Cells[0].Value = "「命刃」";
    ModelGrid.Rows[343].Cells[0].Value = "「隐月 · 刃」";
    ModelGrid.Rows[344].Cells[0].Value = "龙刃「猩红」";
    ModelGrid.Rows[345].Cells[0].Value = "紫刃「虚」";
    ModelGrid.Rows[346].Cells[0].Value = "次元之刃「伪」";
    ModelGrid.Rows[347].Cells[0].Value = "山樱「伪」";
    ModelGrid.Rows[348].Cells[0].Value = "荆棘之刃「虚」";
    ModelGrid.Rows[349].Cells[0].Value = "异界剑魂「」";
    ModelGrid.Rows[350].Cells[0].Value = "虚无之刃「」";
    ModelGrid.Rows[351].Cells[0].Value = "「灭」";
    ModelGrid.Rows[352].Cells[0].Value = "钻石剑「」";
    ModelGrid.Rows[353].Cells[0].Value = "铁剑「」";
    ModelGrid.Rows[354].Cells[0].Value = "石剑「」";
    ModelGrid.Rows[355].Cells[0].Value = "「黑瞳」";
    ModelGrid.Rows[356].Cells[0].Value = "";
    ModelGrid.Rows[357].Cells[0].Value = "";
    ModelGrid.Rows[358].Cells[0].Value = "龙一「黑色守望」";
    ModelGrid.Rows[359].Cells[0].Value = "龙一「文字」";
    ModelGrid.Rows[360].Cells[0].Value = "真 · 龙一「文字」";
    ModelGrid.Rows[361].Cells[0].Value = "龙一「战队超人」";
    ModelGrid.Rows[362].Cells[0].Value = "龙一「麻雀」";
    ModelGrid.Rows[363].Cells[0].Value = "龙一「青年」";
    ModelGrid.Rows[364].Cells[0].Value = "「不正经」冰之剑_火箭形";
    ModelGrid.Rows[365].Cells[0].Value = "「不正经」火之剑_火箭形";
    ModelGrid.Rows[366].Cells[0].Value = "「不正经」冰之剑_锋利形";
    ModelGrid.Rows[367].Cells[0].Value = "「不正经」火之剑_锋利形";
    ModelGrid.Rows[368].Cells[0].Value = "「不正经 · 觉醒」虚无剑";
    ModelGrid.Rows[369].Cells[0].Value = "「不正经 · 淘汰」村姑";
    ModelGrid.Rows[370].Cells[0].Value = "「不正经 · 淘汰」电棍";
    ModelGrid.Rows[371].Cells[0].Value = "塔耳塔洛斯「狱渊之锁」";
    ModelGrid.Rows[372].Cells[0].Value = "卡俄斯「溟濛万象」";
    ModelGrid.Rows[373].Cells[0].Value = "安托则斯「冥光万法」";
    ModelGrid.Rows[374].Cells[0].Value = "德雷格兰「圣契」";
    ModelGrid.Rows[375].Cells[0].Value = "阿尔忒弥斯「耀月」";
    ModelGrid.Rows[376].Cells[0].Value = "聚变之星 · 倪克斯「辰宿瞬变」";
    ModelGrid.Rows[377].Cells[0].Value = "宿命行星 · 阿南刻「天数裁定」";
    ModelGrid.Rows[378].Cells[0].Value = "柯罗诺斯「始源之枪」";
    ModelGrid.Rows[379].Cells[0].Value = "柯罗诺斯「万古琨矇」";
    ModelGrid.Rows[380].Cells[0].Value = "钢枪「云破」";
    ModelGrid.Rows[381].Cells[0].Value = "青瓷「伞」";
    ModelGrid.Rows[382].Cells[0].Value = "巴鲁蒙格「胧」";
    ModelGrid.Rows[383].Cells[0].Value = "元素刀「金」";
    ModelGrid.Rows[384].Cells[0].Value = "元素刀「木」";
    ModelGrid.Rows[385].Cells[0].Value = "元素刀「水」";
    ModelGrid.Rows[386].Cells[0].Value = "元素刀「火」";
    ModelGrid.Rows[387].Cells[0].Value = "元素刀「土」";
    ModelGrid.Rows[388].Cells[0].Value = "带鞘太刀";
    ModelGrid.Rows[389].Cells[0].Value = "拔刀剑";
    ModelGrid.Rows[390].Cells[0].Value = "无铭「打刀」";
    ModelGrid.Rows[391].Cells[0].Value = "模造刀「无魂」";
    ModelGrid.Rows[392].Cells[0].Value = "模造刀「武兴」";
    ModelGrid.Rows[393].Cells[0].Value = "无铭刀「简装」";
    ModelGrid.Rows[394].Cells[0].Value = "名刀「尚义」";
    ModelGrid.Rows[395].Cells[0].Value = "名刀「山城」";
    ModelGrid.Rows[396].Cells[0].Value = "名刀「江户」";
    ModelGrid.Rows[397].Cells[0].Value = "名刀「山上」";
    ModelGrid.Rows[398].Cells[0].Value = "名刀「浓州」";
    ModelGrid.Rows[399].Cells[0].Value = "自铭「起源」";
    ModelGrid.Rows[400].Cells[0].Value = "自铭「腰刀」";
    ModelGrid.Rows[401].Cells[0].Value = "自铭「止步」";
    ModelGrid.Rows[402].Cells[0].Value = "自铭「迷途」";
    ModelGrid.Rows[403].Cells[0].Value = "自铭「平凡」";
    ModelGrid.Rows[404].Cells[0].Value = "妖刀「孤独」";
    ModelGrid.Rows[405].Cells[0].Value = "直刀「忍者」";
    ModelGrid.Rows[406].Cells[0].Value = "无铭「虚无」";
    ModelGrid.Rows[407].Cells[0].Value = "名刀「金纸竹光」";
    ModelGrid.Rows[408].Cells[0].Value = "杰克的武士刀";
    ModelGrid.Rows[409].Cells[0].Value = "古老的锈刀";
    ModelGrid.Rows[410].Cells[0].Value = "幻刃「灵物」露台";
    ModelGrid.Rows[411].Cells[0].Value = "利刃「斩铁」露台";
    ModelGrid.Rows[412].Cells[0].Value = "幻刃「虚无」露台";
    ModelGrid.Rows[413].Cells[0].Value = "幻刃「玄绮」露台";
    ModelGrid.Rows[414].Cells[0].Value = "「碎玉」露台";
    ModelGrid.Rows[415].Cells[0].Value = "「断钢」露台";
    ModelGrid.Rows[416].Cells[0].Value = "「岫岩」露台";
    ModelGrid.Rows[417].Cells[0].Value = "「科幻」露台";
    ModelGrid.Rows[418].Cells[0].Value = "大刃「弦锷」露台";
    ModelGrid.Rows[419].Cells[0].Value = "赝刀「山吹」露台";
    ModelGrid.Rows[420].Cells[0].Value = "「伪金」露台";
    ModelGrid.Rows[421].Cells[0].Value = "太刀「凰雉」露台";
    ModelGrid.Rows[422].Cells[0].Value = "太刀「余烬」露台";
    ModelGrid.Rows[423].Cells[0].Value = "太刀「龙熙」露台";
    ModelGrid.Rows[424].Cells[0].Value = "太刀「赛菲」露台";
    ModelGrid.Rows[425].Cells[0].Value = "大名「鍪银」露台";
    ModelGrid.Rows[426].Cells[0].Value = "大名「逆银」露台";
    ModelGrid.Rows[427].Cells[0].Value = "异次元「管理者之刃」";
    ModelGrid.Rows[428].Cells[0].Value = "宇宙最强之刃「万物终结 · 无尽星空」";
    ModelGrid.Rows[429].Cells[0].Value = "棘羽「毕方」";
    ModelGrid.Rows[430].Cells[0].Value = "狐月刀「仙狐」";
    ModelGrid.Rows[431].Cells[0].Value = "狐月刀「灵狐」";
    ModelGrid.Rows[432].Cells[0].Value = "灵刃「狐月刀」";
    ModelGrid.Rows[433].Cells[0].Value = "寒鸦「死亡圣器」";
  }

  private void AddBladeSource() {
    for (int index = 0; index < 60; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "拔刀剑 (Slash Blade)";
    for (int index = 60; index < 134; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "最后的太刀匠人 v2.1.6";
    for (int index = 134; index < 141; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "尼格洛兹 (NegoreRouse)";
    ModelGrid.Rows[141].Cells[1].Value = "犬仕双刃 (Housamo)";
    ModelGrid.Rows[142].Cells[1].Value = "犬仕双刃 (Housamo)";
    ModelGrid.Rows[143].Cells[1].Value = "星云剑 (Innominandum)";
    for (int index = 144; index < 149; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "御神刀 (Kitsunekamuya)";
    ModelGrid.Rows[149].Cells[1].Value = "魔刀千刃 (Slashblade-Qian)";
    ModelGrid.Rows[150].Cells[1].Value = "炼狱刀 (ShinkuOfuda)";
    ModelGrid.Rows[151].Cells[1].Value = "炼狱刀 (ShinkuOfuda)";
    for (int index = 152; index < 173; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "暮色森林附属包 (Twilight Tsuki)";
    for (int index = 173; index < 205; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "仙剑阁 (Xian Jian Ge)";
    ModelGrid.Rows[205].Cells[1].Value = "境界的彼方 (Kyokai NoKanata)";
    ModelGrid.Rows[206].Cells[1].Value = "境界的彼方 (Kyokai NoKanata)";
    for (int index = 207; index < 217; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "更多电力装置 (More Electric Tools)";
    ModelGrid.Rows[217].Cells[1].Value = "元素时代 (Element Times)";
    for (int index = 218; index < 225; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "方舟拔刀 (Arknights Blade)";
    for (int index = 225; index < 232; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "遗忘之刃 (Lost Blade)";
    for (int index = 232; index < 249; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "星云剑 (Innominandum)";
    for (int index = 250; index < 266; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "炼金重铸计划-七宗罪";
    ModelGrid.Rows[266].Cells[1].Value = "炼狱刀「血腥」 (Blood Blade)";
    ModelGrid.Rows[267].Cells[1].Value = "炼狱刀「血腥」 (Blood Blade)";
    for (int index = 268; index < 288; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "万物皆可为兵刃 (Allweapon)";
    for (int index = 288; index < 300; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "魔法金属 (Mana Metal)";
    for (int index = 300; index < 339; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "炫彩之刃 (Bright Blade)";
    for (int index = 339; index < 356; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "伪刃 (Pseudo Edge)";
    for (int index = 356; index < 364; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "龙一文字 (RyuIchimonji)";
    for (int index = 364; index < 371; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "不正经的剑 (No Decent)";
    for (int index = 371; index < 380; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "尼格洛兹 (Negore Rouse)";
    for (int index = 383; index < 388; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "元素时代 (Element Times)";
    for (int index = 388; index < 427; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "最后的太刀匠人 (The Last Smith)";
    for (int index = 430; index < 433; ++index)
      ModelGrid.Rows[index].Cells[1].Value = "狐月刀改 (FoxBlade Extra)";
    ModelGrid.Rows[429].Cells[1].Value = "毕方 (Bird Blade)";
    ModelGrid.Rows[380].Cells[1].Value = "万刀背叛 (BladeAnti)";
    ModelGrid.Rows[381].Cells[1].Value = "万刀背叛 (BladeAnti)";
    ModelGrid.Rows[382].Cells[1].Value = "巴鲁蒙格 (Balmung)";
    ModelGrid.Rows[433].Cells[1].Value = "[M.R]寒鸦";
    for (int index = 0; index < 141; ++index)
      ModelGrid.Rows[index].Cells[1].Style.ForeColor = Color.Purple;
    for (int index = 141; index < 225; ++index)
      ModelGrid.Rows[index].Cells[1].Style.ForeColor = Color.Red;
    for (int index = 225; index < 427; ++index)
      ModelGrid.Rows[index].Cells[1].Style.ForeColor = Color.Navy;
    for (int index = 430; index < 433; ++index)
      ModelGrid.Rows[index].Cells[1].Style.ForeColor = Color.Purple;
  }

  private void AddSaName() {
    SpecialAttackGrid.Rows[0].Cells[0].Value = "无SA";
    SpecialAttackGrid.Rows[1].Cells[0].Value = "次元斩";
    SpecialAttackGrid.Rows[2].Cells[0].Value = "幻影刃";
    SpecialAttackGrid.Rows[3].Cells[0].Value = "幻影刃-重";
    SpecialAttackGrid.Rows[4].Cells[0].Value = "幻影刃-纵";
    SpecialAttackGrid.Rows[5].Cells[0].Value = "波刀龙胆";
    SpecialAttackGrid.Rows[6].Cells[0].Value = "元刃";
    SpecialAttackGrid.Rows[7].Cells[0].Value = "平突";
    SpecialAttackGrid.Rows[8].Cells[0].Value = "急袭幻影剑-衰破";
    SpecialAttackGrid.Rows[9].Cells[0].Value = "终焉樱";
    SpecialAttackGrid.Rows[10].Cells[0].Value = "急袭幻影剑 · 灼热地裂斩";
    SpecialAttackGrid.Rows[11].Cells[0].Value = "拔刀斩";
    SpecialAttackGrid.Rows[12].Cells[0].Value = "祈愿";
    SpecialAttackGrid.Rows[13].Cells[0].Value = "水岚";
    SpecialAttackGrid.Rows[14].Cells[0].Value = "影舞";
    SpecialAttackGrid.Rows[15].Cells[0].Value = "云轮";
    SpecialAttackGrid.Rows[16].Cells[0].Value = "急袭幻影剑";
    SpecialAttackGrid.Rows[17].Cells[0].Value = "旋刃";
    SpecialAttackGrid.Rows[18].Cells[0].Value = "烈风幻影剑";
    SpecialAttackGrid.Rows[19].Cells[0].Value = "人符「现世斩」";
    SpecialAttackGrid.Rows[20].Cells[0].Value = "新生";
    SpecialAttackGrid.Rows[21].Cells[0].Value = "樱花剑「闪闪散华」";
    SpecialAttackGrid.Rows[22].Cells[0].Value = "斩断迷惘";
    SpecialAttackGrid.Rows[23].Cells[0].Value = "悟入幻想";
    SpecialAttackGrid.Rows[24].Cells[0].Value = "心抄斩";
    SpecialAttackGrid.Rows[25].Cells[0].Value = "剑技";
    SpecialAttackGrid.Rows[26].Cells[0].Value = "居合";
    SpecialAttackGrid.Rows[27].Cells[0].Value = "强剑技";
    SpecialAttackGrid.Rows[28].Cells[0].Value = "头上花剪斩";
    SpecialAttackGrid.Rows[29].Cells[0].Value = "樱之流「空间震」";
    SpecialAttackGrid.Rows[30].Cells[0].Value = "樱之流「初传」";
    SpecialAttackGrid.Rows[31].Cells[0].Value = "樱之流「落樱」";
    SpecialAttackGrid.Rows[32].Cells[0].Value = "空间震";
    SpecialAttackGrid.Rows[33].Cells[0].Value = "空观剑「六根清净斩」";
    SpecialAttackGrid.Rows[34].Cells[0].Value = "断命剑「冥想斩」";
    SpecialAttackGrid.Rows[35].Cells[0].Value = "冰刀三尺";
    SpecialAttackGrid.Rows[36].Cells[0].Value = "漂头散寂";
    SpecialAttackGrid.Rows[37].Cells[0].Value = "陨星箭";
    SpecialAttackGrid.Rows[38].Cells[0].Value = "妖气";
    SpecialAttackGrid.Rows[39].Cells[0].Value = "神威";
    SpecialAttackGrid.Rows[40].Cells[0].Value = "千刃追月";
    SpecialAttackGrid.Rows[41].Cells[0].Value = "聚集祈愿";
    SpecialAttackGrid.Rows[42].Cells[0].Value = "水岚风暴";
    SpecialAttackGrid.Rows[43].Cells[0].Value = "影舞风暴";
    SpecialAttackGrid.Rows[44].Cells[0].Value = "云轮风暴";
    SpecialAttackGrid.Rows[45].Cells[0].Value = "弑敌残心斩";
    SpecialAttackGrid.Rows[46].Cells[0].Value = "新月冲斩";
    SpecialAttackGrid.Rows[47].Cells[0].Value = "月色微光流";
    SpecialAttackGrid.Rows[48].Cells[0].Value = "波刀月光";
    SpecialAttackGrid.Rows[49].Cells[0].Value = "随缘闪现";
    SpecialAttackGrid.Rows[50].Cells[0].Value = "月圆斩";
    SpecialAttackGrid.Rows[51].Cells[0].Value = "急救";
    SpecialAttackGrid.Rows[52].Cells[0].Value = "彩虹重击";
    SpecialAttackGrid.Rows[53].Cells[0].Value = "彩虹幻影刃";
    SpecialAttackGrid.Rows[54].Cells[0].Value = "急冻幻影刃";
    SpecialAttackGrid.Rows[55].Cells[0].Value = "炙热幻影刃";
    SpecialAttackGrid.Rows[56].Cells[0].Value = "护盾生成";
    SpecialAttackGrid.Rows[57].Cells[0].Value = "三相幻影刃";
    SpecialAttackGrid.Rows[58].Cells[0].Value = "血气方涛";
    SpecialAttackGrid.Rows[59].Cells[0].Value = "青茫熳天摇";
    SpecialAttackGrid.Rows[60].Cells[0].Value = "撼海潮涌";
    SpecialAttackGrid.Rows[61].Cells[0].Value = "群星坠落";
    SpecialAttackGrid.Rows[62].Cells[0].Value = "星辰斗转";
    SpecialAttackGrid.Rows[63].Cells[0].Value = "黑云逸陨";
    SpecialAttackGrid.Rows[64].Cells[0].Value = "八卦阵法";
    SpecialAttackGrid.Rows[65].Cells[0].Value = "流星若行";
    SpecialAttackGrid.Rows[66].Cells[0].Value = "黑洞吞噬";
    SpecialAttackGrid.Rows[67].Cells[0].Value = "邪恶凝视";
    SpecialAttackGrid.Rows[68].Cells[0].Value = "永恒守卫";
    SpecialAttackGrid.Rows[69].Cells[0].Value = "撼动山河";
    SpecialAttackGrid.Rows[70].Cells[0].Value = "红尘滚滚";
    SpecialAttackGrid.Rows[71].Cells[0].Value = "擒苍决";
    SpecialAttackGrid.Rows[72].Cells[0].Value = "烈火通体";
    SpecialAttackGrid.Rows[73].Cells[0].Value = "耕耘";
    SpecialAttackGrid.Rows[74].Cells[0].Value = "破锋";
    SpecialAttackGrid.Rows[75].Cells[0].Value = "流星斩";
    SpecialAttackGrid.Rows[76].Cells[0].Value = "球状闪电";
    SpecialAttackGrid.Rows[77].Cells[0].Value = "抹杀";
    SpecialAttackGrid.Rows[78].Cells[0].Value = "陨剑";
    SpecialAttackGrid.Rows[79].Cells[0].Value = "时之陷阱";
    SpecialAttackGrid.Rows[80].Cells[0].Value = "落日风暴";
    SpecialAttackGrid.Rows[81].Cells[0].Value = "星之彩";
    SpecialAttackGrid.Rows[82].Cells[0].Value = "终焉超新星爆";
    SpecialAttackGrid.Rows[83].Cells[0].Value = "龙吟";
    SpecialAttackGrid.Rows[84].Cells[0].Value = "横扫千军";
    SpecialAttackGrid.Rows[85].Cells[0].Value = "闪耀";
    SpecialAttackGrid.Rows[86].Cells[0].Value = "诅咒之血";
    SpecialAttackGrid.Rows[87].Cells[0].Value = "高能粒子流";
    SpecialAttackGrid.Rows[88].Cells[0].Value = "能级跃迁";
    SpecialAttackGrid.Rows[89].Cells[0].Value = "动量定理";
    SpecialAttackGrid.Rows[90].Cells[0].Value = "Hyper System,起动！";
    SpecialAttackGrid.Rows[91].Cells[0].Value = "高速幻影剑-γ";
    SpecialAttackGrid.Rows[92].Cells[0].Value = "真银斩";
    SpecialAttackGrid.Rows[93].Cells[0].Value = "狼魂";
    SpecialAttackGrid.Rows[94].Cells[0].Value = "数据抹除";
    SpecialAttackGrid.Rows[95].Cells[0].Value = "星落打";
    SpecialAttackGrid.Rows[96].Cells[0].Value = "圣耀";
    SpecialAttackGrid.Rows[97].Cells[0].Value = "治愈波动";
    SpecialAttackGrid.Rows[98].Cells[0].Value = "断魂龙啸";
    SpecialAttackGrid.Rows[99].Cells[0].Value = "月祈";
    SpecialAttackGrid.Rows[100].Cells[0].Value = "月牙天冲";
    SpecialAttackGrid.Rows[101].Cells[0].Value = "汲血割裂";
    SpecialAttackGrid.Rows[102].Cells[0].Value = "贪婪之握";
    SpecialAttackGrid.Rows[103].Cells[0].Value = "卓尔不凡";
    SpecialAttackGrid.Rows[104].Cells[0].Value = "饥饿吸取";
    SpecialAttackGrid.Rows[105].Cells[0].Value = "影刃乱舞";
    SpecialAttackGrid.Rows[106].Cells[0].Value = "天狱锁魂";
    SpecialAttackGrid.Rows[107].Cells[0].Value = "魅影突刺";
    SpecialAttackGrid.Rows[108].Cells[0].Value = "血弑";
    SpecialAttackGrid.Rows[109].Cells[0].Value = "追星剑";
    SpecialAttackGrid.Rows[110].Cells[0].Value = "风之棺";
    SpecialAttackGrid.Rows[111].Cells[0].Value = "炎极 · 抚斩";
    SpecialAttackGrid.Rows[112].Cells[0].Value = "幻影蝶";
    SpecialAttackGrid.Rows[113].Cells[0].Value = "百谷幻蝶";
    SpecialAttackGrid.Rows[114].Cells[0].Value = "裂地猛冲";
    SpecialAttackGrid.Rows[115].Cells[0].Value = "ほら！ほら！ほら！";
    SpecialAttackGrid.Rows[116].Cells[0].Value = "虹极斩";
    SpecialAttackGrid.Rows[117].Cells[0].Value = "一闪";
    SpecialAttackGrid.Rows[118].Cells[0].Value = "星爆气流斩";
    SpecialAttackGrid.Rows[119].Cells[0].Value = "冰魂雪魄";
    SpecialAttackGrid.Rows[120].Cells[0].Value = "白 · 月牙天冲";
    SpecialAttackGrid.Rows[121].Cells[0].Value = "随机大傻子！";
    SpecialAttackGrid.Rows[122].Cells[0].Value = "宗鬼";
    SpecialAttackGrid.Rows[123].Cells[0].Value = "魔爆斩";
    SpecialAttackGrid.Rows[124].Cells[0].Value = "隐息";
    SpecialAttackGrid.Rows[125].Cells[0].Value = "龙魂附体";
    SpecialAttackGrid.Rows[126].Cells[0].Value = "平移斩";
    SpecialAttackGrid.Rows[127].Cells[0].Value = "平移";
    SpecialAttackGrid.Rows[128].Cells[0].Value = "空间次元";
    SpecialAttackGrid.Rows[129].Cells[0].Value = "虚 · 平移斩";
    SpecialAttackGrid.Rows[130].Cells[0].Value = "「灭」";
    SpecialAttackGrid.Rows[131].Cells[0].Value = "虚无之触";
    SpecialAttackGrid.Rows[132].Cells[0].Value = "「黑穴」";
    SpecialAttackGrid.Rows[133].Cells[0].Value = "不正经之斩";
    SpecialAttackGrid.Rows[134].Cells[0].Value = "超级突刺";
    SpecialAttackGrid.Rows[135].Cells[0].Value = "虚无之斩";
    SpecialAttackGrid.Rows[136].Cells[0].Value = "「旋」虚无斩";
    SpecialAttackGrid.Rows[137].Cells[0].Value = "「淘汰」村姑娘娘斩";
    SpecialAttackGrid.Rows[138].Cells[0].Value = "裂霄";
    SpecialAttackGrid.Rows[139].Cells[0].Value = "华灵「蝶妄想」";
    SpecialAttackGrid.Rows[140].Cells[0].Value = "虚 ·「开辟千山的翠绿地平线」";
    SpecialAttackGrid.Rows[141].Cells[0].Value = "绝 ·「焚驱万海的拂晓水平线」";
    SpecialAttackGrid.Rows[142].Cells[0].Value = "极 ·「轰震星宿的环宇天界线」";
    SpecialAttackGrid.Rows[143].Cells[0].Value = "鱼 ·「脑子一热的咸鱼追踪线」";
    SpecialAttackGrid.Rows[144].Cells[0].Value = "剑 ·「六道残影的剑气幻想线」";
    SpecialAttackGrid.Rows[145].Cells[0].Value = "空 ·「织罗空间的维度平行线」";
    SpecialAttackGrid.Rows[146].Cells[0].Value = "元 ·「捏造次元的黑球次元线」";
    SpecialAttackGrid.Rows[147].Cells[0].Value = "刃 ·「虚物为实的幻影刀剑线」";
    SpecialAttackGrid.Rows[148].Cells[0].Value = "闪 ·「电光一闪的气象云平线」";
    SpecialAttackGrid.Rows[149].Cells[0].Value = "炫 ·「构成光觉的色系彩平线」";
    SpecialAttackGrid.Rows[150].Cells[0].Value = "政 ·「闲得蛋疼的弹幕球平线」";
    SpecialAttackGrid.Rows[151].Cells[0].Value = "次元斩 · 改";
    SpecialAttackGrid.Rows[152].Cells[0].Value = "平突 · 改";
    SpecialAttackGrid.Rows[153].Cells[0].Value = "终焉樱 · 散";
    SpecialAttackGrid.Rows[154].Cells[0].Value = "终焉 · 陨星键";
    SpecialAttackGrid.Rows[155].Cells[0].Value = "数据剪切";
    SpecialAttackGrid.Rows[156].Cells[0].Value = "开";
    SpecialAttackGrid.Rows[157].Cells[0].Value = "暗刺";
    SpecialAttackGrid.Rows[158].Cells[0].Value = "极意斩";
    SpecialAttackGrid.Rows[159].Cells[0].Value = "阿瓦达索命";
  }

  private void AddSaSource() {
    for (int index = 1; index < 19; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "拔刀剑 (Slash Blade)";
    }

    for (int index = 29; index < 33; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "最后的太刀匠人";
    }

    for (int index = 19; index < 29; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "心血结晶 (Heartwork)";
    }

    SpecialAttackGrid.Rows[33].Cells[1].Value = "妖忌双剑 (Hakugyokurou)";
    SpecialAttackGrid.Rows[34].Cells[1].Value = "妖忌双剑 (Hakugyokurou)";
    SpecialAttackGrid.Rows[35].Cells[1].Value = "犬仕双刃 (Housamo)";
    SpecialAttackGrid.Rows[36].Cells[1].Value = "犬仕双刃 (Housamo)";
    SpecialAttackGrid.Rows[37].Cells[1].Value = "星云剑 (Innominandum)";
    SpecialAttackGrid.Rows[38].Cells[1].Value = "御神刀 (Kitsunekamuya)";
    SpecialAttackGrid.Rows[39].Cells[1].Value = "御神刀 (Kitsunekamuya)";
    SpecialAttackGrid.Rows[40].Cells[1].Value = "魔刀千刃 (Slashblade-Qian)";
    for (int index = 41; index < 45; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "龙一文字 (RyuIchimonji)";
    }

    SpecialAttackGrid.Rows[45].Cells[1].Value = "炼狱刀 (ShinkuOfuda)";
    for (int index = 45; index < 58; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "暮色森林附属包";
    }

    for (int index = 58; index < 86; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "仙剑阁 (Xian Jian Ge)";
    }

    SpecialAttackGrid.Rows[86].Cells[1].Value = "境界的彼方 (KyokaiNoKanata)";
    for (int index = 87; index < 92; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "更多电力装置";
    }

    SpecialAttackGrid.Rows[92].Cells[1].Value = "方舟拔刀 (Arknights Blade)";
    SpecialAttackGrid.Rows[93].Cells[1].Value = "方舟拔刀 (Arknights Blade)";
    for (int index = 94; index < 101; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "遗忘之刃 (Lost Blade)";
    }

    for (int index = 101; index < 108; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "炼金重铸计划-七宗罪";
    }

    SpecialAttackGrid.Rows[108].Cells[1].Value = "炼狱刀「血腥」 (Blood Blade)";
    for (int index = 108; index < 122; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "万物皆可为兵刃 (Allweapon)";
    }

    SpecialAttackGrid.Rows[122].Cells[1].Value = "炫彩之刃 (Bright Blade)";
    for (int index = 123; index < 133; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "伪刃 (Pseudo Edge)";
    }

    for (int index = 133; index < 138; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "不正经的剑 (No Decent)";
    }

    SpecialAttackGrid.Rows[138].Cells[1].Value = "毕方 (Bird Blade)";
    for (int index = 139; index < 151; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Value = "迷之刀技 (AbbySA)";
    }

    SpecialAttackGrid.Rows[151].Cells[1].Value = "狐月刀改 (FoxBlade Extra)";
    SpecialAttackGrid.Rows[152].Cells[1].Value = "狐月刀改 (FoxBlade Extra)";
    SpecialAttackGrid.Rows[153].Cells[1].Value = "狐月刀改 (FoxBlade Extra)";
    SpecialAttackGrid.Rows[156].Cells[1].Value = "万刀背叛 (BladeAnti)";
    SpecialAttackGrid.Rows[157].Cells[1].Value = "万刀背叛 (BladeAnti)";
    SpecialAttackGrid.Rows[158].Cells[1].Value = "万刀背叛 (BladeAnti)";
    SpecialAttackGrid.Rows[159].Cells[1].Value = "[M.R]寒鸦 (Mist Raven)";
    SpecialAttackGrid.Rows[159].Cells[1].Style.ForeColor = Color.Purple;
    for (int index = 0; index < 33; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Style.ForeColor = Color.Purple;
    }

    for (int index = 33; index < 97; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Style.ForeColor = Color.Red;
    }

    for (int index = 97; index < 151; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Style.ForeColor = Color.Navy;
    }

    for (int index = 151; index < 154; ++index) {
      SpecialAttackGrid.Rows[index].Cells[1].Style.ForeColor = Color.Purple;
    }
  }

  private void AddSeName() {
    SpecialEffectGrid.Rows[0].Cells[1].Value = "无SE";
    SpecialEffectGrid.Rows[1].Cells[1].Value = "凋零性";
    SpecialEffectGrid.Rows[2].Cells[1].Value = "载器";
    SpecialEffectGrid.Rows[3].Cells[1].Value = "兽性";
    SpecialEffectGrid.Rows[4].Cells[1].Value = "HF量级";
    SpecialEffectGrid.Rows[5].Cells[1].Value = "玛娜强化";
    SpecialEffectGrid.Rows[6].Cells[1].Value = "玛娜池修复";
    SpecialEffectGrid.Rows[7].Cells[1].Value = "神谕";
    SpecialEffectGrid.Rows[8].Cells[1].Value = "爆裂性";
    SpecialEffectGrid.Rows[9].Cells[1].Value = "负向神力";
    SpecialEffectGrid.Rows[10].Cells[1].Value = "绝对神力";
    SpecialEffectGrid.Rows[11].Cells[1].Value = "回溯";
    SpecialEffectGrid.Rows[12].Cells[1].Value = "魔力修复";
    SpecialEffectGrid.Rows[13].Cells[1].Value = "极致锋利";
    SpecialEffectGrid.Rows[14].Cells[1].Value = "极致削弱";
    SpecialEffectGrid.Rows[15].Cells[1].Value = "「TLS」系统";
    SpecialEffectGrid.Rows[16].Cells[1].Value = "「极致妖力」";
    SpecialEffectGrid.Rows[17].Cells[1].Value = "神狐祝福";
    SpecialEffectGrid.Rows[18].Cells[1].Value = "幻影破魔矢";
    SpecialEffectGrid.Rows[19].Cells[1].Value = "神佑";
    SpecialEffectGrid.Rows[20].Cells[1].Value = "碎裂边缘";
    SpecialEffectGrid.Rows[21].Cells[1].Value = "神威";
    SpecialEffectGrid.Rows[22].Cells[1].Value = "爆裂性 · 破";
    SpecialEffectGrid.Rows[23].Cells[1].Value = "刃袭";
    SpecialEffectGrid.Rows[24].Cells[1].Value = "暮光闪闪";
    SpecialEffectGrid.Rows[25].Cells[1].Value = "血气剑术";
    SpecialEffectGrid.Rows[26].Cells[1].Value = "青钢剑影";
    SpecialEffectGrid.Rows[27].Cells[1].Value = "波折";
    SpecialEffectGrid.Rows[28].Cells[1].Value = "星锁";
    SpecialEffectGrid.Rows[29].Cells[1].Value = "庇护";
    SpecialEffectGrid.Rows[30].Cells[1].Value = "黑茫";
    SpecialEffectGrid.Rows[31].Cells[1].Value = "变化万千";
    SpecialEffectGrid.Rows[32].Cells[1].Value = "星之淬炼";
    SpecialEffectGrid.Rows[33].Cells[1].Value = "洞虚";
    SpecialEffectGrid.Rows[34].Cells[1].Value = "魂锁";
    SpecialEffectGrid.Rows[35].Cells[1].Value = "重铸";
    SpecialEffectGrid.Rows[36].Cells[1].Value = "动摇";
    SpecialEffectGrid.Rows[37].Cells[1].Value = "柮夭";
    SpecialEffectGrid.Rows[38].Cells[1].Value = "擒苍";
    SpecialEffectGrid.Rows[39].Cells[1].Value = "熔岩";
    SpecialEffectGrid.Rows[40].Cells[1].Value = "耕耘";
    SpecialEffectGrid.Rows[41].Cells[1].Value = "冷血";
    SpecialEffectGrid.Rows[42].Cells[1].Value = "落星";
    SpecialEffectGrid.Rows[43].Cells[1].Value = "杨永信附体";
    SpecialEffectGrid.Rows[44].Cells[1].Value = "斩";
    SpecialEffectGrid.Rows[45].Cells[1].Value = "重铸";
    SpecialEffectGrid.Rows[46].Cells[1].Value = "遮蔽";
    SpecialEffectGrid.Rows[47].Cells[1].Value = "风华";
    SpecialEffectGrid.Rows[48].Cells[1].Value = "流彩";
    SpecialEffectGrid.Rows[49].Cells[1].Value = "超新星之力";
    SpecialEffectGrid.Rows[50].Cells[1].Value = "龙吟";
    SpecialEffectGrid.Rows[51].Cells[1].Value = "锋利";
    SpecialEffectGrid.Rows[52].Cells[1].Value = "华光";
    SpecialEffectGrid.Rows[53].Cells[1].Value = "神劲 · 火矢";
    SpecialEffectGrid.Rows[54].Cells[1].Value = "神劲 · 烈波";
    SpecialEffectGrid.Rows[55].Cells[1].Value = "寸劲 · 箭矢";
    SpecialEffectGrid.Rows[56].Cells[1].Value = "死劲 · 灭咒";
    SpecialEffectGrid.Rows[57].Cells[1].Value = "罪罚";
    SpecialEffectGrid.Rows[58].Cells[1].Value = "束缚";
    SpecialEffectGrid.Rows[59].Cells[1].Value = "无餍";
    SpecialEffectGrid.Rows[60].Cells[1].Value = "压制";
    SpecialEffectGrid.Rows[61].Cells[1].Value = "怨忿";
    SpecialEffectGrid.Rows[62].Cells[1].Value = "饕餮";
    SpecialEffectGrid.Rows[63].Cells[1].Value = "鸩毒";
    SpecialEffectGrid.Rows[64].Cells[1].Value = "饮血";
    SpecialEffectGrid.Rows[65].Cells[1].Value = "坏血";
    SpecialEffectGrid.Rows[66].Cells[1].Value = "禁锢";
    SpecialEffectGrid.Rows[1].Cells[3].Value = "WitherEdge";
    SpecialEffectGrid.Rows[2].Cells[3].Value = "Limitter";
    SpecialEffectGrid.Rows[3].Cells[3].Value = "BlastEdge";
    SpecialEffectGrid.Rows[4].Cells[3].Value = "HFCustom";
    SpecialEffectGrid.Rows[5].Cells[3].Value = "ManaBurst";
    SpecialEffectGrid.Rows[6].Cells[3].Value = "ManaPoolRepair";
    SpecialEffectGrid.Rows[7].Cells[3].Value = "oracle";
    SpecialEffectGrid.Rows[8].Cells[3].Value = "burstDrive";
    SpecialEffectGrid.Rows[9].Cells[3].Value = "reversePower";
    SpecialEffectGrid.Rows[10].Cells[3].Value = "absolutePower";
    SpecialEffectGrid.Rows[11].Cells[3].Value = "back";
    SpecialEffectGrid.Rows[12].Cells[3].Value = "ManaRepair";
    SpecialEffectGrid.Rows[13].Cells[3].Value = "extreme_sharpness";
    SpecialEffectGrid.Rows[14].Cells[3].Value = "sap_slash";
    SpecialEffectGrid.Rows[15].Cells[3].Value = "technical_experimental_laser_system";
    SpecialEffectGrid.Rows[16].Cells[3].Value = "bewitched_sharpness";
    SpecialEffectGrid.Rows[17].Cells[3].Value = "HS_potion";
    SpecialEffectGrid.Rows[18].Cells[3].Value = "HS_advance";
    SpecialEffectGrid.Rows[19].Cells[3].Value = "SEGodFoxProtection";
    SpecialEffectGrid.Rows[20].Cells[3].Value = "SEBreakedge";
    SpecialEffectGrid.Rows[21].Cells[3].Value = "Kamui";
    SpecialEffectGrid.Rows[22].Cells[3].Value = "NeoBurstDrive";
    SpecialEffectGrid.Rows[23].Cells[3].Value = "SuburiKiai";
    SpecialEffectGrid.Rows[24].Cells[3].Value = "SETwilightSparkle";
    SpecialEffectGrid.Rows[25].Cells[3].Value = "bloodgas";
    SpecialEffectGrid.Rows[26].Cells[3].Value = "qingyunSE";
    SpecialEffectGrid.Rows[27].Cells[3].Value = "shueibozheSE";
    SpecialEffectGrid.Rows[28].Cells[3].Value = "yunxingzhangSE";
    SpecialEffectGrid.Rows[29].Cells[3].Value = "xuanyuanSE";
    SpecialEffectGrid.Rows[30].Cells[3].Value = "heirenSE";
    SpecialEffectGrid.Rows[31].Cells[3].Value = "baguaSE";
    SpecialEffectGrid.Rows[32].Cells[3].Value = "xinglioulirenSE";
    SpecialEffectGrid.Rows[33].Cells[3].Value = "voidswordSE";
    SpecialEffectGrid.Rows[34].Cells[3].Value = "suoyulianSE";
    SpecialEffectGrid.Rows[35].Cells[3].Value = "jingmisouweiSE";
    SpecialEffectGrid.Rows[36].Cells[3].Value = "handichueiSE";
    SpecialEffectGrid.Rows[37].Cells[3].Value = "zuoyaoSE";
    SpecialEffectGrid.Rows[38].Cells[3].Value = "qingcangSE";
    SpecialEffectGrid.Rows[39].Cells[3].Value = "zhuyanSE";
    SpecialEffectGrid.Rows[40].Cells[3].Value = "qinmangSE";
    SpecialEffectGrid.Rows[41].Cells[3].Value = "xueyeSE";
    SpecialEffectGrid.Rows[42].Cells[3].Value = "xingdianSE";
    SpecialEffectGrid.Rows[43].Cells[3].Value = "laserswordSE";
    SpecialEffectGrid.Rows[44].Cells[3].Value = "shuohunSE";
    SpecialEffectGrid.Rows[45].Cells[3].Value = "shenyunjianSE";
    SpecialEffectGrid.Rows[46].Cells[3].Value = "shizhilianSE";
    SpecialEffectGrid.Rows[47].Cells[3].Value = "changkongluorSE";
    SpecialEffectGrid.Rows[48].Cells[3].Value = "tilSE";
    SpecialEffectGrid.Rows[49].Cells[3].Value = "htodSE";
    SpecialEffectGrid.Rows[50].Cells[3].Value = "xingkongSE";
    SpecialEffectGrid.Rows[51].Cells[3].Value = "modaoqianrenSE";
    SpecialEffectGrid.Rows[52].Cells[3].Value = "bairenSE";
    SpecialEffectGrid.Rows[53].Cells[3].Value = "CraftRevSE";
    SpecialEffectGrid.Rows[54].Cells[3].Value = "BloodRevSE";
    SpecialEffectGrid.Rows[55].Cells[3].Value = "KineticSE";
    SpecialEffectGrid.Rows[56].Cells[3].Value = "MrbladeSE";
    SpecialEffectGrid.Rows[57].Cells[3].Value = "SEsaligia";
    SpecialEffectGrid.Rows[58].Cells[3].Value = "SEacedia";
    SpecialEffectGrid.Rows[59].Cells[3].Value = "SEavaritia";
    SpecialEffectGrid.Rows[60].Cells[3].Value = "SEsuperbia";
    SpecialEffectGrid.Rows[61].Cells[3].Value = "SEinvidia";
    SpecialEffectGrid.Rows[62].Cells[3].Value = "SEgula";
    SpecialEffectGrid.Rows[63].Cells[3].Value = "SEluxuria";
    SpecialEffectGrid.Rows[64].Cells[3].Value = "SEira";
    SpecialEffectGrid.Rows[65].Cells[3].Value = "SEsepticemia";
    SpecialEffectGrid.Rows[66].Cells[3].Value = "Purgatory";
  }

  private void AddSeSource() {
    for (int index = 1; index < 7; ++index) {
      SpecialEffectGrid.Rows[index].Cells[2].Value = "拔刀剑";
    }

    for (int index = 7; index < 12; ++index) {
      SpecialEffectGrid.Rows[index].Cells[2].Value = "尼格洛兹";
    }

    for (int index = 12; index < 17; ++index) {
      SpecialEffectGrid.Rows[index].Cells[2].Value = "最后的太刀匠人";
    }

    SpecialEffectGrid.Rows[17].Cells[2].Value = "狐月刀改";
    SpecialEffectGrid.Rows[18].Cells[2].Value = "狐月刀改";
    SpecialEffectGrid.Rows[19].Cells[2].Value = "御神刀「神狐」";
    SpecialEffectGrid.Rows[20].Cells[2].Value = "魔刀千刃";
    SpecialEffectGrid.Rows[21].Cells[2].Value = "龙一文字";
    SpecialEffectGrid.Rows[22].Cells[2].Value = "龙一文字";
    SpecialEffectGrid.Rows[23].Cells[2].Value = "炼狱刀";
    SpecialEffectGrid.Rows[24].Cells[2].Value = "暮色森林附属包";
    for (int index = 25; index < 53; ++index) {
      SpecialEffectGrid.Rows[index].Cells[2].Value = "仙剑阁";
    }

    for (int index = 53; index < 57; ++index) {
      SpecialEffectGrid.Rows[index].Cells[2].Value = "更多电力装置";
    }

    for (int index = 57; index < 65; ++index) {
      SpecialEffectGrid.Rows[index].Cells[2].Value = "炼金重铸计划-七宗罪";
    }

    SpecialEffectGrid.Rows[65].Cells[2].Value = "炼狱刀「血腥」";
    SpecialEffectGrid.Rows[66].Cells[2].Value = "尼格洛兹";
  }

  private void AddEnchantmentName() {
    EnchantmentGrid.Rows[0].Cells[1].Value = "保护";
    EnchantmentGrid.Rows[1].Cells[1].Value = "火焰保护";
    EnchantmentGrid.Rows[2].Cells[1].Value = "摔落保护";
    EnchantmentGrid.Rows[3].Cells[1].Value = "爆炸保护";
    EnchantmentGrid.Rows[4].Cells[1].Value = "弹射物保护";
    EnchantmentGrid.Rows[5].Cells[1].Value = "荆棘";
    EnchantmentGrid.Rows[6].Cells[1].Value = "水下呼吸";
    EnchantmentGrid.Rows[7].Cells[1].Value = "深海探索者";
    EnchantmentGrid.Rows[8].Cells[1].Value = "水下速掘";
    EnchantmentGrid.Rows[9].Cells[1].Value = "锋利";
    EnchantmentGrid.Rows[10].Cells[1].Value = "亡灵杀手";
    EnchantmentGrid.Rows[11].Cells[1].Value = "节肢杀手";
    EnchantmentGrid.Rows[12].Cells[1].Value = "击退";
    EnchantmentGrid.Rows[13].Cells[1].Value = "火焰附加";
    EnchantmentGrid.Rows[14].Cells[1].Value = "抢夺";
    EnchantmentGrid.Rows[15].Cells[1].Value = "效率";
    EnchantmentGrid.Rows[16].Cells[1].Value = "精准采集";
    EnchantmentGrid.Rows[17].Cells[1].Value = "耐久";
    EnchantmentGrid.Rows[18].Cells[1].Value = "时运";
    EnchantmentGrid.Rows[19].Cells[1].Value = "力量";
    EnchantmentGrid.Rows[20].Cells[1].Value = "冲击";
    EnchantmentGrid.Rows[21].Cells[1].Value = "火矢";
    EnchantmentGrid.Rows[22].Cells[1].Value = "无限";
    EnchantmentGrid.Rows[23].Cells[1].Value = "海之眷顾";
    EnchantmentGrid.Rows[24].Cells[1].Value = "饵钓";
    EnchantmentGrid.Rows[25].Cells[1].Value = "冰霜行者";
    EnchantmentGrid.Rows[26].Cells[1].Value = "经验修补";
    EnchantmentGrid.Rows[27].Cells[1].Value = "绑定诅咒";
    EnchantmentGrid.Rows[28].Cells[1].Value = "消失诅咒";
    EnchantmentGrid.Rows[29].Cells[1].Value = "横扫之刃";
    EnchantmentGrid.Rows[0].Cells[2].Value = "0";
    EnchantmentGrid.Rows[1].Cells[2].Value = "1";
    EnchantmentGrid.Rows[2].Cells[2].Value = "2";
    EnchantmentGrid.Rows[3].Cells[2].Value = "3";
    EnchantmentGrid.Rows[4].Cells[2].Value = "4";
    EnchantmentGrid.Rows[5].Cells[2].Value = "7";
    EnchantmentGrid.Rows[6].Cells[2].Value = "5";
    EnchantmentGrid.Rows[7].Cells[2].Value = "8";
    EnchantmentGrid.Rows[8].Cells[2].Value = "6";
    EnchantmentGrid.Rows[9].Cells[2].Value = "16";
    EnchantmentGrid.Rows[10].Cells[2].Value = "17";
    EnchantmentGrid.Rows[11].Cells[2].Value = "18";
    EnchantmentGrid.Rows[12].Cells[2].Value = "19";
    EnchantmentGrid.Rows[13].Cells[2].Value = "20";
    EnchantmentGrid.Rows[14].Cells[2].Value = "21";
    EnchantmentGrid.Rows[15].Cells[2].Value = "32";
    EnchantmentGrid.Rows[16].Cells[2].Value = "33";
    EnchantmentGrid.Rows[17].Cells[2].Value = "34";
    EnchantmentGrid.Rows[18].Cells[2].Value = "35";
    EnchantmentGrid.Rows[19].Cells[2].Value = "48";
    EnchantmentGrid.Rows[20].Cells[2].Value = "49";
    EnchantmentGrid.Rows[21].Cells[2].Value = "50";
    EnchantmentGrid.Rows[22].Cells[2].Value = "51";
    EnchantmentGrid.Rows[23].Cells[2].Value = "61";
    EnchantmentGrid.Rows[24].Cells[2].Value = "62";
    EnchantmentGrid.Rows[25].Cells[2].Value = "9";
    EnchantmentGrid.Rows[26].Cells[2].Value = "70";
    EnchantmentGrid.Rows[27].Cells[2].Value = "10";
    EnchantmentGrid.Rows[28].Cells[2].Value = "71";
    EnchantmentGrid.Rows[29].Cells[2].Value = "22";
  }

  private static void ClearText(Control ctrlTop) {
    if (ctrlTop.GetType() == typeof(TextBox)) {
      ctrlTop.Text = "";
    } else {
        foreach (Control control in (ArrangedElementCollection)ctrlTop.Controls) { 
          ClearText(control); 
        }
    }
  }

  private void ClearTextButtonClick(object sender, EventArgs e) => ClearText(this);

  private void buttonCheck2_Click(object sender, EventArgs e) {
    if (buttonCheck2.Checked) {
      AllArmorGroupBox.Text = "装备位置: 所有";
      ChestPlateGroupBox.Enabled = false;
      BootsGroupBox.Enabled = false;
      LeggingsGroupBox.Enabled = false;
      OffHandGroupBox.Enabled = false;
      MainHandGroupBox.Enabled = false;
    } else {
      AllArmorGroupBox.Text = "装备位置: 头盔";
      ChestPlateGroupBox.Enabled = true;
      BootsGroupBox.Enabled = true;
      LeggingsGroupBox.Enabled = true;
      OffHandGroupBox.Enabled = true;
      MainHandGroupBox.Enabled = true;
    }
  }

  private void SetSlot() {
    string str1 = ",AttributeName:";
    string str2 = "{Operation:0,Amount:";
    AllSlot = ",AttributeModifiers:[" + str2 + textBox21.Text +
              str1 + "\"generic.attackDamage\",Name:\"attackDamage\"}," +       
              str2 + textBox20.Text + str1 + "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + 
              str2 + textBox19.Text + str1 + "\"generic.maxHealth\",Name:\"maxHealth\"}," + 
              str2 + textBox18.Text + str1 + "\"generic.movementSpeed\",Name:\"movementSpeed\"}," +       
              str2 + textBox17.Text + str1 + "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 +       
              textBox16.Text + str1 + "\"generic.armor\",Name:\"armor\"}," + str2 + textBox15.Text + str1 +       
              "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox22.Text + str1 + "\"generic.luck\",Name:\"luck\"}]";
    SeparateSlot = ",AttributeModifiers:[" + str2 + textBox21.Text + ",Slot:head" + str1 +            
                   "\"generic.attackDamage\",Name:\"attackDamage\"}," + str2 + textBox20.Text + ",Slot:head" + str1 + 
                   "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + str2 + textBox19.Text +            
                   ",Slot:head" + str1 + "\"generic.maxHealth\",Name:\"maxHealth\"}," + str2 + textBox18.Text + ",Slot:head" + str1 +            
                   "\"generic.movementSpeed\",Name:\"movementSpeed\"}," + str2 + textBox17.Text + ",Slot:head" + str1 +
                   "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 + textBox16.Text + ",Slot:head" + str1 +            
                   "\"generic.armor\",Name:\"armor\"}," + str2 + textBox15.Text + ",Slot:head" + str1 +            
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox22.Text + ",Slot:head" + str1 +            
                   "\"generic.luck\",Name:\"luck\"}," + str2 + textBox32.Text + ",Slot:chest" + str1 +            
                   "\"generic.attackDamage\",Name:\"attackDamage\"}," + str2 + textBox31.Text + ",Slot:chest" + str1 +            
                   "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + str2 + textBox30.Text + ",Slot:chest" + str1 +            
                   "\"generic.maxHealth\",Name:\"maxHealth\"}," + str2 + textBox29.Text + ",Slot:chest" + str1 +            
                   "\"generic.movementSpeed\",Name:\"movementSpeed\"}," + str2 + textBox28.Text + ",Slot:chest" + str1 +            
                   "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 + textBox27.Text + ",Slot:chest" + str1 +            
                   "\"generic.armor\",Name:\"armor\"}," + str2 + textBox26.Text + ",Slot:chest" + str1 +            
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox24.Text + ",Slot:chest" + str1 +            
                   "\"generic.luck\",Name:\"luck\"}," + str2 + textBox41.Text + ",Slot:legs" + str1 +            
                   "\"generic.attackDamage\",Name:\"attackDamage\"}," + str2 + textBox40.Text + ",Slot:legs" + str1 +
                   "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + str2 + textBox39.Text + ",Slot:legs" + str1 + 
                   "\"generic.maxHealth\",Name:\"maxHealth\"}," + str2 + textBox38.Text + ",Slot:legs" + str1 +
                   "\"generic.movementSpeed\",Name:\"movementSpeed\"}," + str2 + textBox37.Text + ",Slot:legs" + str1 + 
                   "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 + textBox36.Text + ",Slot:legs" + str1 +
                   "\"generic.armor\",Name:\"armor\"}," + str2 + textBox35.Text + ",Slot:legs" + str1 +
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox33.Text + ",Slot:legs" + str1 +            
                   "\"generic.luck\",Name:\"luck\"}," + str2 + textBox50.Text + ",Slot:feet" + str1 +            
                   "\"generic.attackDamage\",Name:\"attackDamage\"}," + str2 + textBox49.Text + ",Slot:feet" + str1 +
                   "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + str2 + textBox48.Text + ",Slot:feet" + str1 +
                   "\"generic.maxHealth\",Name:\"maxHealth\"}," + str2 + textBox47.Text + ",Slot:feet" + str1 +
                   "\"generic.movementSpeed\",Name:\"movementSpeed\"}," + str2 + textBox46.Text + ",Slot:feet" + str1 + 
                   "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 + textBox45.Text + ",Slot:feet" + str1 +
                   "\"generic.armor\",Name:\"armor\"}," + str2 + textBox44.Text + ",Slot:feet" + str1 +
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox42.Text + ",Slot:feet" + str1 +           
                   "\"generic.luck\",Name:\"luck\"}," + str2 + textBox59.Text + ",Slot:mainhand" + str1 +
                   "\"generic.attackDamage\",Name:\"attackDamage\"}," + str2 + textBox58.Text + ",Slot:mainhand" + str1 +            
                   "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + str2 + textBox57.Text + ",Slot:mainhand" + str1 + 
                   "\"generic.maxHealth\",Name:\"maxHealth\"}," + str2 + textBox56.Text + ",Slot:mainhand" + str1 + 
                   "\"generic.movementSpeed\",Name:\"movementSpeed\"}," + str2 + textBox55.Text + ",Slot:mainhand" + str1 +            
                   "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 + textBox54.Text + ",Slot:mainhand" + str1 +            
                   "\"generic.armor\",Name:\"armor\"}," + str2 + textBox53.Text + ",Slot:mainhand" + str1 +
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox51.Text + ",Slot:mainhand" + str1 +            
                   "\"generic.luck\",Name:\"luck\"}," + str2 + textBox68.Text + ",Slot:offhand" + str1 +
                   "\"generic.attackDamage\",Name:\"attackDamage\"}," + str2 + textBox67.Text + ",Slot:offhand" + str1 +
                   "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + str2 + textBox66.Text + ",Slot:offhand" + str1 +
                   "\"generic.maxHealth\",Name:\"maxHealth\"}," + str2 + textBox65.Text + ",Slot:offhand" + str1 +
                   "\"generic.movementSpeed\",Name:\"movementSpeed\"}," + str2 + textBox64.Text + ",Slot:offhand" + str1 +            
                   "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 + textBox63.Text + ",Slot:offhand" + str1 +            
                   "\"generic.armor\",Name:\"armor\"}," + str2 + textBox62.Text + ",Slot:offhand" + str1 +
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox60.Text + ",Slot:offhand" +
                   str1 + "\"generic.luck\",Name:\"luck\"}]";
  }

  private void CommandOutputButtonClick(object sender, EventArgs e) {
    int index1 = ModelGrid.CurrentRow.Index;
    int index2 = SpecialAttackGrid.CurrentRow.Index;
    Color backColor = label77.BackColor;
    int num1 = backColor.R * 65536;
    backColor = label77.BackColor;
    int num2 = backColor.G * 256;
    int num3 = num1 + num2;
    backColor = label77.BackColor;
    int b = backColor.B;
    int num4 = num3 + b;
    int num5 = 1;
    int num6 = 2;
    int num7 = 4;
    int num8 = 8;
    int num9 = 16;
    int num10 = 32;
    string str1 = ModelGrid.Rows[index1].Cells[0].Value.ToString();
    string text1 = textBox2.Text;
    string text2 = textBox3.Text;
    string text3 = textBox4.Text;
    string text4 = textBox5.Text;
    string text5 = textBox4.Text;
    string text6 = textBox7.Text;
    string text7 = textBox8.Text;
    string str2 = textBox12.Text;
    string text8 = textBox13.Text;
    string text9 = textBox14.Text;
    string str3 = "";
    string str4 = "";
    string str5 = ModelGrid.CurrentRow.Cells[0].Value.ToString();
    string str6 = !checkBox1.Checked ? "1b" : "0b";
    string str7 = !checkBox2.Checked ? "0b" : "1b";
    string str8 = !checkBox4.Checked ? "0b" : "1b";
    string str9 = !checkBox11.Checked ? "0b" : "1b";
    string str10 = !checkBox12.Checked ? "0b" : "1b";
    string str11 = !radioButton1.Checked ? (!radioButton2.Checked ? (!radioButton3.Checked ? "4" : "3") : "2") : "1";
    SetSlot();
    string str12;
    string str13;
    string str14;
    switch (str5) {
      case "31工-「紫龙息」": str12 = "Cobalt"; str13 = "blade"; str14 = "slash/Cobalt"; break;
      case "31工-「金巴」": str12 = "Palladium"; str13 = "blade"; str14 = "slash/Palladium"; break;
      case "HTOD的刀": str12 = "flammpfeil.slashblade.xianjiange.htodsword"; str13 = "xianjiange/HTOD'sword/htod/model"; str14 = "xianjiange/HTOD'sword/htod/texture"; break;
      case "XingKong的刀": str12 = "flammpfeil.slashblade.xianjiange.xingkongsword"; str13 = "xianjiange/HTOD'sword/xingkong/model"; str14 = "xianjiange/HTOD'sword/xingkong/texture"; break;
      case "til的刀": str12 = "flammpfeil.slashblade.xianjiange.tilsword"; str13 = "xianjiange/HTOD'sword/til/model"; str14 = "xianjiange/HTOD'sword/til/texture"; break;
      case "「V.V.V.V.V.」": str12 = "flammpfeil.slashblade.named.mmf.nethop"; str13 = "named/arthurs/model_grand"; str14 = "named/arthurs/texture_grand"; break;
      case "「不正经 · 淘汰」村姑": str12 = "flammpfeil.slashblade.named.ND"; str13 = "named/ND/ND"; str14 = "named/ND/ND"; break;
      case "「不正经 · 淘汰」电棍": str12 = "flammpfeil.slashblade.named.ND"; str13 = "named/ND/ND"; str14 = "named/ND/ND"; break;
      case "「不正经 · 觉醒」虚无剑": str12 = "flammpfeil.slashblade.named.ND"; str13 = "named/ND/ND"; str14 = "named/ND/ND"; break;
      case "「不正经」冰之剑_火箭形": str12 = "flammpfeil.slashblade.named.ND"; str13 = "named/ND/ND"; str14 = "named/ND/ND"; break;
      case "「不正经」冰之剑_锋利形": str12 = "flammpfeil.slashblade.named.ND"; str13 = "named/ND/ND"; str14 = "named/ND/ND"; break;
      case "「不正经」火之剑_火箭形": str12 = "flammpfeil.slashblade.named.ND"; str13 = "named/ND/ND"; str14 = "named/ND/ND"; break;
      case "「不正经」火之剑_锋利形": str12 = "flammpfeil.slashblade.named.ND"; str13 = "named/ND/ND"; str14 = "named/ND/ND"; break;
      case "「伊布之刃」": str12 = "flammpfeil.slashblade.named.eievui"; str13 = "named/eievui/model"; str14 = "named/eievui/texture"; break;
      case "「伪金」露台": str12 = "wrap.exparmory.katana.brass"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryBrass"; break;
      case "「击柝」露台": str12 = "wrap.reforged.wooden_katana"; str13 = "blade"; str14 = "BalkonWood"; break;
      case "「剑圣之刃」伍": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」叁": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」壹": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」拾": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」拾叁": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」拾壹": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」拾贰": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」捌": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」柒": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」玖": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」肆": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」贰": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「剑圣之刃」陆": str12 = "flammpfeil.slashblade.named.jiansheng"; str13 = "named/kevinwalker/jiansheng"; str14 = "named/kevinwalker/jiansheng"; break;
      case "「千兆」": str12 = "flammpfeil.slashblade.named.thousand"; str13 = "named/thousand/model_on"; str14 = "named/thousand/texture"; break;
      case "「千鹤」叁": str12 = "flammpfeil.slashblade.named.qianhe"; str13 = "named/kevinwalker/qianhe"; str14 = "named/kevinwalker/qianhe"; break;
      case "「千鹤」壹": str12 = "flammpfeil.slashblade.named.qianhe"; str13 = "named/kevinwalker/qianhe"; str14 = "named/kevinwalker/qianhe"; break;
      case "「千鹤」村正": str12 = "flammpfeil.slashblade.named.muramasa"; str13 = "named/muramasa/muramasa"; str14 = "named/muramasa/muramasa"; break;
      case "「千鹤」村雨": str12 = "flammpfeil.slashblade.named.murasamablade"; str13 = "named/murasamablade/murasama"; str14 = "named/murasamablade/murasama"; break;
      case "「千鹤」肆": str12 = "flammpfeil.slashblade.named.qianhe"; str13 = "named/kevinwalker/qianhe"; str14 = "named/kevinwalker/qianhe"; break;
      case "「千鹤」贰": str12 = "flammpfeil.slashblade.named.qianhe"; str13 = "named/kevinwalker/qianhe"; str14 = "named/kevinwalker/qianhe"; break;
      case "「命刃」": str12 = "flammpfeil.slashblade.named.latent"; str13 = "named/latent/latent"; str14 = "named/latent/latent"; break;
      case "「密陀僧」": str12 = "twilighttsuki.blade.mitsudasou"; str13 = "twilighttsuki/blade/tachi/mitsudasou/mitsudasou"; str14 = "twilighttsuki/blade/tachi/mitsudasou/mitsudasou"; break;
      case "「岫岩」露台": str12 = "wrap.exparmory.katana.quartz"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryQuartz"; break;
      case "「恶」": str12 = "flammpfeil.slashblade.unnamed.EvilBlade"; str13 = "unnamed/evil"; str14 = "unnamed/evil"; break;
      case "「断钢」露台": str12 = "wrap.exparmory.katana.adamantium"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryAdamantium"; break;
      case "「暗鸦」伍": str12 = "flammpfeil.slashblade.named.anya"; str13 = "named/kevinwalker/anya"; str14 = "named/kevinwalker/anya"; break;
      case "「暗鸦」叁": str12 = "flammpfeil.slashblade.named.anya"; str13 = "named/kevinwalker/anya"; str14 = "named/kevinwalker/anya"; break;
      case "「暗鸦」壹": str12 = "flammpfeil.slashblade.named.anya"; str13 = "named/kevinwalker/anya"; str14 = "named/kevinwalker/anya"; break;
      case "「暗鸦」柒": str12 = "flammpfeil.slashblade.named.anya"; str13 = "named/kevinwalker/anya"; str14 = "named/kevinwalker/anya"; break;
      case "「暗鸦」肆": str12 = "flammpfeil.slashblade.named.anya"; str13 = "named/kevinwalker/anya"; str14 = "named/kevinwalker/anya"; break;
      case "「暗鸦」贰": str12 = "flammpfeil.slashblade.named.anya"; str13 = "named/kevinwalker/anya"; str14 = "named/kevinwalker/anya"; break;
      case "「暗鸦」陆": str12 = "flammpfeil.slashblade.named.anya"; str13 = "named/kevinwalker/anya"; str14 = "named/kevinwalker/anya"; break;
      case "「暮雨」正宗": str12 = "twilighttsuki.blade.kurasame"; str13 = "twilighttsuki/blade/tachi/kurasame/kurasame"; str14 = "twilighttsuki/blade/tachi/kurasame/kurasame"; break;
      case "「村雨」叁": str12 = "flammpfeil.slashblade.named.aurora"; str13 = "named/kevinwalker/dragonsword"; str14 = "named/kevinwalker/aurora"; break;
      case "「村雨」壹": str12 = "flammpfeil.slashblade.named.newyear"; str13 = "named/kevinwalker/dragonsword"; str14 = "named/kevinwalker/newyear"; break;
      case "「村雨」贰": str12 = "flammpfeil.slashblade.named.dragonsword"; str13 = "named/kevinwalker/dragonsword"; str14 = "named/kevinwalker/dragonsword"; break;
      case "「梨木利亚」": str12 = "flammpfeil.slashblade.named.mmf.limuness"; str13 = "named/arthurs/model_pear"; str14 = "named/arthurs/texture_pear"; break;
      case "「楼观剑」": str12 = "flammpfeil.slashblade.named.roukan"; str13 = "named/roukan/model"; str14 = "named/roukan/texture"; break;
      case "「楼观旋风刃」": str12 = "flammpfeil.slashblade.named.roukan_xf"; str13 = "named/roukan/model"; str14 = "named/roukan/texture_xf"; break;
      case "「樱剪」": str12 = "flammpfeil.slashblade.named.roukan_bot"; str13 = "named/bot_roukan/model"; str14 = "named/bot_roukan/texture"; break;
      case "「灭」": str12 = "flammpfeil.slashblade.named.kingblade"; str13 = "named/kingblade/kingblade"; str14 = "named/kingblade/kingblade"; break;
      case "「狱」": str12 = "flammpfeil.slashblade.bladeex.EvilBladeex"; str13 = "bladeex/evilex/evilex"; str14 = "bladeex/evilex/evilex"; break;
      case "「白刃」": str12 = "flammpfeil.slashblade.named.whitenblade"; str13 = "named/sword/sword"; str14 = "named/sword/whitensword"; break;
      case "「白楼剑」": str12 = "flammpfeil.slashblade.named.hakurou"; str13 = "named/hakurou/model"; str14 = "named/hakurou/texture"; break;
      case "「白楼旋风刃」": str12 = "flammpfeil.slashblade.named.hakurou_xf"; str13 = "named/hakurou/model"; str14 = "named/hakurou/texture_xf"; break;
      case "「碎玉」露台": str12 = "wrap.exparmory.katana.onyx"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryOnyx"; break;
      case "「祭钢刃」": str12 = "flammpfeil.slashblade.named.mmf.lrsoft"; str13 = "named/arthurs/model_irsort"; str14 = "named/arthurs/texture_irsoft"; break;
      case "「科幻」露台": str12 = "wrap.exparmory.katana.certus"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryCertus"; break;
      case "「罗盘草」": str12 = "twilighttsuki.blade.silphium"; str13 = "twilighttsuki/blade/tachi/silphium/silphium"; str14 = "twilighttsuki/blade/tachi/silphium/silphium"; break;
      case "「荧光」壹": str12 = "flammpfeil.slashblade.named.yingguang"; str13 = "named/kevinwalker/yingguang"; str14 = "named/kevinwalker/yingguang"; break;
      case "「荧光」贰": str12 = "flammpfeil.slashblade.named.yingguang"; str13 = "named/kevinwalker/yingguang"; str14 = "named/kevinwalker/yingguang"; break;
      case "「血纸竹光」": str12 = "flammpfeil.slashblade.named.silverbamboolight_blood"; str13 = "blade"; str14 = "named/bamboolight/silverbamboo_blood"; break;
      case "「要塞」神秘": str12 = "flammpfeil.slashblade.named.fortress.thaumium.update"; str13 = "named/smith/model"; str14 = "named/thaum/texture_thaumium_update"; break;
      case "「要塞」虚无": str12 = "flammpfeil.slashblade.named.fortress.void.update"; str13 = "named/smith/model"; str14 = "named/thaum/texture_voidmetal_update"; break;
      case "「要塞」血红": str12 = "flammpfeil.slashblade.named.fortress.crimson.update"; str13 = "named/smith/model"; str14 = "named/thaum/texture_crimson_update"; break;
      case "「要塞」风雷": str12 = "flammpfeil.slashblade.named.fortress.elemental.update"; str13 = "named/smith/model"; str14 = "named/thaum/texture_elemental_update"; break;
      case "「锐岩」露台": str12 = "wrap.reforged.stone_katana"; str13 = "blade"; str14 = "BalkonStone"; break;
      case "「镇魂曲」": str12 = "flammpfeil.slashblade.named.scorn"; str13 = "named/scorn/model"; str14 = "named/scorn/texture"; break;
      case "「隐月 · 刃」": str12 = "flammpfeil.slashblade.named.xblades"; str13 = "named/xblades/xblades"; str14 = "named/xblades/xblades"; break;
      case "「隐者之竹光」": str12 = "flammpfeil.slashblade.named.bamboolight_recluse"; str13 = "blade"; str14 = "named/bamboolight/bamboo_top"; break;
      case "「风来之剑」": str12 = "flammpfeil.slashblade.named.wanderer"; str13 = "named/wanderer/wanderer"; str14 = "named/wanderer/wanderer"; break;
      case "「风来之械刃」": str12 = "flammpfeil.slashblade.named.wanderer"; str13 = "named/wanderer/wanderer"; str14 = "named/wanderer/wanderer"; break;
      case "「魔刀千刃」": str12 = "qian.blade.qian"; str13 = "qian/model"; str14 = "qian/texture"; break;
      case "「魔刃」": str12 = "flammpfeil.slashblade.named.magicblade"; str13 = "named/magicblade/magicblade"; str14 = "named/magicblade/magicblade"; break;
      case "「鹿丸」": str12 = "twilighttsuki.blade.shikamaru"; str13 = "twilighttsuki/blade/tachi/shikamaru/shikamaru"; str14 = "twilighttsuki/blade/tachi/shikamaru/shikamaru"; break;
      case "「黑刃」": str12 = "flammpfeil.slashblade.named.blackblade"; str13 = "named/sword/sword"; str14 = "named/sword/pseudosword"; break;
      case "「黑瞳」": str12 = "flammpfeil.slashblade.named.heitong"; str13 = "named/sange/sange"; str14 = "named/heitong/heitong"; break;
      case "一斥染「甚三红」": str12 = "twilighttsuki.blade.ikkonzome"; str13 = "twilighttsuki/blade/tachi/ikkonzome/ikkonzome"; str14 = "twilighttsuki/blade/tachi/ikkonzome/ikkonzome"; break;
      case "三雷拵": str12 = "lastsmith.handmade_saya_2"; str13 = "named/smith/model"; str14 = "handmade/sheath_2_wood"; break;
      case "上品「银纸竹光」": str12 = "flammpfeil.slashblade.named.silverbamboolight_top"; str13 = "blade"; str14 = "named/bamboolight/silverbamboo_top"; break;
      case "不可视之刃「风之影」· 风": str12 = "flammpfeil.slashblade.named.fengzhiying"; str13 = "named/fengzhiying/model"; str14 = "named/fengzhiying/texture"; break;
      case "不死斩「拜泪」": str12 = "flammpfeil.slashblade.named.fushikiri"; str13 = "named/sekiro/fushigiri"; str14 = "named/sekiro/fushigiri"; break;
      case "伊恩「永恒时光之轮 · 永劫根源魔枪」": str12 = "moflop.slashblade.chronos"; str13 = "named/negorerouse/chronos"; str14 = "named/negorerouse/chronos"; break;
      case "伪物「亡者」": str12 = "flammpfeil.slashblade.named.scorn_rust"; str13 = "named/scorn/model"; str14 = "named/scorn/texture_1"; break;
      case "伪物「白楼剑」": str12 = "flammpfeil.slashblade.named.hakurou_fake"; str13 = "named/hakurou/model"; str14 = "named/hakurou/texture"; break;
      case "伪物「葵」": str12 = "flammpfeil.slashblade.named.yamazakura.aoi_fake"; str13 = "named/yamazakura/model_fake"; str14 = "named/yamazakura/yamazakura_yayoi_sakura"; break;
      case "伪物「观楼剑」": str12 = "flammpfeil.slashblade.named.kanrou_fake"; str13 = "named/roukan/model"; str14 = "named/roukan/texture_fake"; break;
      case "侍月刀「炎水薄斩」": str12 = "flammpfeil.slashblade.named.blademaster.aquablaze"; str13 = "named/blademaster/blademaster"; str14 = "named/blademaster/aquablaze"; break;
      case "元素刀": str12 = "flammpfeil.slashblade.named.silverash.unelitism"; str13 = "named/blade"; str14 = "named/silverash/silverash"; break;
      case "元素刀「土」": str12 = "elementknife"; str13 = "elementtimes/土的刀"; str14 = "elementtimes/土的刀"; break;
      case "元素刀「木」": str12 = "elementknife"; str13 = "elementtimes/木的刀"; str14 = "elementtimes/木的刀"; break;
      case "元素刀「水」": str12 = "elementknife"; str13 = "elementtimes/水的刀"; str14 = "elementtimes/水的刀"; break;
      case "元素刀「火」": str12 = "elementknife"; str13 = "elementtimes/火的刀"; str14 = "elementtimes/火的刀"; break;
      case "元素刀「金」": str12 = "elementknife"; str13 = "elementtimes/金的刀"; str14 = "elementtimes/金的刀"; break;
      case "光剑「监视者」": str12 = "flammpfeil.slashblade.named.guangjian"; str13 = "named/guangjian/model"; str14 = "named/guangjian/texture"; break;
      case "八卦剑": str12 = "flammpfeil.slashblade.xianjiange.baguasword"; str13 = "xianjiange/HTOD'sword/bagua/model"; str14 = "xianjiange/HTOD'sword/bagua/texture"; break;
      case "冻樱刃「雪花苍月」": str12 = "flammpfeil.slashblade.named.frostwolfa"; str13 = "named/frostwolf/frostwolfa"; str14 = "named/frostwolf/frostwolfa"; break;
      case "冻樱刃「雪花苍月」叁": str12 = "flammpfeil.slashblade.named.dongying"; str13 = "named/kevinwalker/dongying"; str14 = "named/kevinwalker/dongying"; break;
      case "冻樱刃「雪花苍月」壹": str12 = "flammpfeil.slashblade.named.dongying"; str13 = "named/kevinwalker/dongying"; str14 = "named/kevinwalker/dongying"; break;
      case "冻樱刃「雪花苍月」贰": str12 = "flammpfeil.slashblade.named.dongying"; str13 = "named/kevinwalker/dongying"; str14 = "named/kevinwalker/dongying"; break;
      case "刀": str12 = "wrap.Wa.katana"; str13 = "wa/model"; str14 = "wa/waA"; break;
      case "刚剑「胴田贯」": str12 = "flammpfeil.slashblade.named.doutanuki"; str13 = "named/muramasa/muramasa"; str14 = "named/muramasa/doutanuki"; break;
      case "利刀「无名」红玉": str12 = "wrap.BambooMod.katana"; str13 = "blade"; str14 = "BambooKatana"; break;
      case "利刀「白鞘「」": str12 = "flammpfeil.slashblade.white"; str13 = "blade"; str14 = "white"; break;
      case "利刀「苍梅」": str12 = "SlashBladeTemplate.blue"; str13 = "wa/model"; str14 = "wa/template"; break;
      case "利刀「钢叶」露台": str12 = "twilighttsuki.tfblade.steeleaf"; str13 = "blade"; str14 = "TFSteeleaf"; break;
      case "利刀「铁」露台": str12 = "wrap.reforged.iron_katana"; str13 = "blade"; str14 = "BalkonIron"; break;
      case "利刀「铁树」露台": str12 = "twilighttsuki.tfblade.ironwood"; str13 = "blade"; str14 = "TFIronwood"; break;
      case "利刀「铁骑」露台": str12 = "twilighttsuki.tfblade.knightly"; str13 = "blade"; str14 = "TFKnightly"; break;
      case "利刃「斩铁」露台": str12 = "wrap.exparmory.katana.steel"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmorySteel"; break;
      case "勤忙": str12 = "flammpfeil.slashblade.xianjiange.qinmangsword"; str13 = "xianjiange/HTOD'sword/qinmang/model"; str14 = "xianjiange/HTOD'sword/qinmang/texture"; break;
      case "卡俄斯「溟濛万象」": str12 = "flammpfeil.slashblade.named.chaos"; str13 = "named/negorerouse/chaos"; str14 = "named/negorerouse/chaos"; break;
      case "厄瑞波斯「永黯沉寂」": str12 = "moflop.slashblade.erebus"; str13 = "named/negorerouse/erebus"; str14 = "named/negorerouse/erebus"; break;
      case "原罪「傲慢」": str12 = "flammpfeil.slashblade.named.lucifer"; str13 = "named/lucifer/lucifer"; str14 = "named/lucifer/lucifer"; break;
      case "原罪「嫉妒」": str12 = "flammpfeil.slashblade.named.leviathan"; str13 = "named/leviathan/leviathan"; str14 = "named/leviathan/leviathan"; break;
      case "原罪「懒惰」": str12 = "flammpfeil.slashblade.named.belphegor"; str13 = "named/belphegor/belphegor"; str14 = "named/belphegor/belphegor"; break;
      case "原罪「暴怒」": str12 = "flammpfeil.slashblade.named.samael"; str13 = "named/samael/samael"; str14 = "named/samael/samael"; break;
      case "原罪「色欲」": str12 = "flammpfeil.slashblade.named.asmodeus"; str13 = "named/asmodeus/asmodeus"; str14 = "named/asmodeus/asmodeus"; break;
      case "原罪「贪婪」": str12 = "flammpfeil.slashblade.named.mammon"; str13 = "named/mammon/mammon"; str14 = "named/mammon/mammon"; break;
      case "原罪「贪食」": str12 = "flammpfeil.slashblade.named.beelzebub"; str13 = "named/beelzebub/beelzebub"; str14 = "named/beelzebub/beelzebub"; break;
      case "原罪神「利维坦」": str12 = "flammpfeil.slashblade.bladeex.leviathanex"; str13 = "bladeex/leviathanex/leviathanex"; str14 = "bladeex/leviathanex/leviathanex"; break;
      case "原罪神「别西卜」": str12 = "flammpfeil.slashblade.bladeex.beelzebubex"; str13 = "bladeex/beelzebubex/beelzebubex"; str14 = "bladeex/beelzebubex/beelzebubex"; break;
      case "原罪神「玛门」": str12 = "flammpfeil.slashblade.bladeex.mammonex"; str13 = "bladeex/mammonex/mammonex"; str14 = "bladeex/mammonex/mammonex"; break;
      case "原罪神「萨迈尔」": str12 = "flammpfeil.slashblade.bladeex.samaelex"; str13 = "bladeex/samaelex/samaelex"; str14 = "bladeex/samaelex/samaelex"; break;
      case "原罪神「贝尔芬格」": str12 = "flammpfeil.slashblade.bladeex.belphegorex"; str13 = "bladeex/belphegorex/belphegorex"; str14 = "bladeex/belphegorex/belphegorex"; break;
      case "原罪神「路西法」": str12 = "flammpfeil.slashblade.bladeex.luciferex"; str13 = "bladeex/luciferex/luciferex"; str14 = "bladeex/luciferex/luciferex"; break;
      case "原罪神「阿斯莫德」": str12 = "flammpfeil.slashblade.bladeex.asmodeusex"; str13 = "bladeex/asmodeusex/asmodeusex"; str14 = "bladeex/asmodeusex/asmodeusex"; break;
      case "古刀「乌鸟」": str12 = "flammpfeil.slashblade.named.birdblade"; str13 = "named/bird/model"; str14 = "named/bird/1"; break;
      case "名刀「亡者」": str12 = "flammpfeil.slashblade.named.scorn_sealed"; str13 = "named/scorn/model"; str14 = "named/scorn/texture_0"; break;
      case "名刀「将军木」": str12 = "flammpfeil.slashblade.named.sagequoia"; str13 = "named/sagequoia/model"; str14 = "named/sagequoia/texture"; break;
      case "名刀「尚义」": str12 = "flammpfeil.slashblade.named.namedblade"; str13 = "named/famous/1"; str14 = "named/famous/7"; break;
      case "名刀「山上」": str12 = "flammpfeil.slashblade.named.namedblade3"; str13 = "named/famous/1"; str14 = "named/famous/3"; break;
      case "名刀「山城」": str12 = "flammpfeil.slashblade.named.namedblade1"; str13 = "named/famous/1"; str14 = "named/famous/1"; break;
      case "名刀「揳丸」": str12 = "flammpfeil.slashblade.named.kusabimaru"; str13 = "named/sekiro/kusabimaru"; str14 = "named/sekiro/kusabimaru"; break;
      case "名刀「斗刀」": str12 = "flammpfeil.slashblade.named.kogawa_rare"; str13 = "named/namedblade/model"; str14 = "named/namedblade/texture_rare"; break;
      case "名刀「江户」": str12 = "flammpfeil.slashblade.named.namedblade2"; str13 = "named/famous/1"; str14 = "named/famous/2"; break;
      case "名刀「浓州」": str12 = "flammpfeil.slashblade.named.namedblade4"; str13 = "named/famous/1"; str14 = "named/famous/4"; break;
      case "名刀「物理学圣剑」": str12 = "flammpfeil.slashblade.named.wulixueshengjian"; str13 = "named/wulixueshengjian/wulixueshengjian"; str14 = "named/wulixueshengjian/wulixueshengjian"; break;
      case "名刀「玻璃」露台": str12 = "twilighttsuki.tfblade.glass"; str13 = "blade"; str14 = "TFGlass"; break;
      case "名刀「观楼剑」": str12 = "flammpfeil.slashblade.named.kanrou"; str13 = "named/roukan/model"; str14 = "named/roukan/texture_fake_0"; break;
      case "名刀「金刚」露台": str12 = "wrap.reforged.diamond_katana"; str13 = "blade"; str14 = "BalkonDiamond"; break;
      case "名刀「金纸竹光」": str12 = "flammpfeil.slashblade.named.silverbamboolight_gold"; str13 = "named/yamato"; str14 = "named/silverbamboolight/silverbamboo_gold"; break;
      case "名刀「银纸竹光」": str12 = "flammpfeil.slashblade.silverbamboo"; str13 = "blade"; str14 = "silverbanboo"; break;
      case "圣剑「银弹」": str12 = "flammpfeil.slashblade.named.yinsezidan"; str13 = "named/yinsezidan/yinsezidan"; str14 = "named/yinsezidan/yinsezidan"; break;
      case "圣幸刀「绿乃雾」": str12 = "flammpfeil.slashblade.named.blademaster.greenmist"; str13 = "named/blademaster/blademaster"; str14 = "named/blademaster/greenmist"; break;
      case "型月刀「空之境界」": str12 = "flammpfeil.slashblade.named.tboen"; str13 = "named/tboen/model"; str14 = "named/tboen/texture"; break;
      case "塔耳塔洛斯「狱渊之锁」": str12 = "flammpfeil.slashblade.named.tartarus"; str13 = "named/negorerouse/tartarus"; str14 = "named/negorerouse/tartarus"; break;
      case "夜叉": str12 = "flammpfeil.slashblade.named.yashatrue"; str13 = "named/yasha/yashaTrue"; str14 = "named/yasha/yasha"; break;
      case "夜叉 (伪)": str12 = "flammpfeil.slashblade.named.yasha"; str13 = "named/yasha/yasha"; str14 = "named/yasha/yasha"; break;
      case "夜空之剑「阐释者」": str12 = "flammpfeil.slashblade.named.chanshizhe"; str13 = "named/chanshizhe/model"; str14 = "named/chanshizhe/texture"; break;
      case "夜魔": str12 = "flammpfeil.slashblade.named.nosoul"; str13 = "named/yasha/yasha"; str14 = "named/nosoul/yasha"; break;
      case "大刃「弦锷」露台": str12 = "wrap.exparmory.katana.bronze"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryBronze"; break;
      case "大名「逆银」露台": str12 = "wrap.exparmory.katana.sinisite"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmorySinisite"; break;
      case "大名「鍪银」露台": str12 = "wrap.exparmory.katana.thyrium"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryThyrium"; break;
      case "大地之刃": str12 = "flammpfeil.slashblade.named.terra"; str13 = "named/terra/terra"; str14 = "named/terra/terra"; break;
      case "大太刀「」": str12 = "flammpfeil.slashblade.named.murakumo"; str13 = ""; str14 = ""; break;
      case "大蛇鄂门": str12 = "flammpfeil.slashblade.named.orotiagito"; str13 = "named/agito"; str14 = "named/orotiagito"; break;
      case "天云「寒齿」": str12 = "flammpfeil.slashblade.named.mmf.zheng"; str13 = "named/smith/model"; str14 = "named/arthurs/texture_zheng"; break;
      case "天云「无念」": str12 = "flammpfeil.slashblade.named.smith.final"; str13 = "named/smith/model"; str14 = "named/smith/texture_final"; break;
      case "天云「残云」": str12 = "flammpfeil.slashblade.named.amagumo.cloud"; str13 = "named/agito"; str14 = "named/smith/texture_cloud"; break;
      case "天云「速风」": str12 = "flammpfeil.slashblade.named.amagumo.wind"; str13 = "named/smith/model"; str14 = "named/smith/texture_wind"; break;
      case "太刀": str12 = "wrap.Wa.tachi"; str13 = "wa/model"; str14 = "wa/waB"; break;
      case "太刀「余烬」露台": str12 = "wrap.exparmory.katana.ashstone"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryAshstone"; break;
      case "太刀「凰雉」露台": str12 = "wrap.exparmory.katana.malachite"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryMalachite"; break;
      case "太刀「左伊多津万」": str12 = "twilighttsuki.blade.saitaduma"; str13 = "twilighttsuki/blade/tachi/saitaduma/saitaduma"; str14 = "twilighttsuki/blade/tachi/saitaduma/saitaduma"; break;
      case "太刀「花绀青伽罗」独钴": str12 = "twilighttsuki.blade.vajra"; str13 = "twilighttsuki/blade/tachi/vajra/vajra"; str14 = "twilighttsuki/blade/tachi/vajra/vajra"; break;
      case "太刀「赛菲」露台": str12 = "wrap.exparmory.katana.argonite"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryArgonite"; break;
      case "太刀「龙熙」露台台": str12 = "wrap.exparmory.katana.dragonstone"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryDragonston"; break;
      case "奉神刀「鹿」": str12 = "flammpfeil.slashblade.named.fengshen"; str13 = "named/fengshen/model"; str14 = "named/fengshen/texture"; break;
      case "妖刀「似蛭」": str12 = "flammpfeil.slashblade.named.nihil"; str13 = "named/nihil/nihil"; str14 = "named/nihil/nihil"; break;
      case "妖刀「神狐」": str12 = "kitsunekamuya.blade.kitsunekamuya"; str13 = "kitsunekamuya/model"; str14 = "kitsunekamuya/texture"; break;
      case "妖刀「红樱」": str12 = "flammpfeil.slashblade.named.crimsoncherry"; str13 = "named/nihil/nihil"; str14 = "named/nihil/crimsoncherry"; break;
      case "宇宙最强之刃「万物终结 · 无尽星空」": str12 = "flammpfeil.slashblade.named.stredgeuniverse"; str13 = "named/stredgeuniverse/model"; str14 = "named/stredgeuniverse/texture"; break;
      case "宇界起源-「翱」": str12 = "UniverseEnergy"; str13 = "named/sange/sange"; str14 = "slash/UniverseEnergy"; break;
      case "安托则斯「冥光万法」": str12 = "flammpfeil.slashblade.named.antauge"; str13 = "named/negorerouse/antauge"; str14 = "named/negorerouse/antauge"; break;
      case "宙雷大刀-「绿夜」": str12 = "Endless"; str13 = "named/sange/sange"; str14 = "slash/Endless"; break;
      case "宝刀「山吹」露台": str12 = "wrap.reforged.golden_katana"; str13 = "blade"; str14 = "BalkonGold"; break;
      case "宝刀「霜冻」露台": str12 = "twilighttsuki.tfblade.icey"; str13 = "blade"; str14 = "TFIcey"; break;
      case "宿命行星 · 阿南刻「天数裁定」": str12 = "flammpfeil.slashblade.named.ananke"; str13 = "named/negorerouse/nyx"; str14 = "named/negorerouse/ananke"; break;
      case "寒鸦「死亡圣器」": str12 = "mistraven.blade.MistravenBlade"; str13 = "Mistraven/Mistraven"; str14 = "Mistraven/Mistraven"; break;
      case "小太刀「」": str12 = "twilighttsuki.blade.kodachi"; str13 = "twilighttsuki/blade/kodachi/kuruhana/kuruhana"; str14 = "twilighttsuki/blade/kodachi/kodachi0"; break;
      case "小太刀「咲夜子」": str12 = "twilighttsuki.blade.sakuya"; str13 = "twilighttsuki/blade/kodachi/sakuya/sakuya"; str14 = "twilighttsuki/blade/kodachi/sakuya/sakuya"; break;
      case "小太刀「小金兔」": str12 = "twilighttsuki.blade.usagi"; str13 = "twilighttsuki/blade/kodachi/usagi/usagi"; str14 = "twilighttsuki/blade/kodachi/usagi/usagi"; break;
      case "小太刀「小鸟丸」": str12 = "twilighttsuki.blade.suzume"; str13 = "twilighttsuki/blade/kodachi/suzume/suzume"; str14 = "twilighttsuki/blade/kodachi/suzume/suzume"; break;
      case "小太刀「落华」": str12 = "twilighttsuki.blade.kuruhana"; str13 = "twilighttsuki/blade/kodachi/kuruhana/kuruhana"; str14 = "twilighttsuki/blade/kodachi/kuruhana/kuruhana"; break;
      case "尼尔「永恒旋转之枪」": str12 = "moflop.slashblade.nier"; str13 = "named/negorerouse/nier"; str14 = "named/negorerouse/nier"; break;
      case "山樱「伪」": str12 = "flammpfeil.slashblade.named.kumasakura"; str13 = "named/kumasakura/kumasakura"; str14 = "named/kumasakura/kumasakura"; break;
      case "山樱「师走」": str12 = "flammpfeil.slashblade.named.yamazakura.shiwasu"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_shiwasu"; break;
      case "山樱「水无月」": str12 = "flammpfeil.slashblade.named.yamazakura.minazuki"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_minazuki"; break;
      case "山樱「神月」": str12 = "flammpfeil.slashblade.named.yamazakura.kamuy"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_kamuy"; break;
      case "山樱「葵」": str12 = "flammpfeil.slashblade.named.yamazakura.aoi"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_aoi"; break;
      case "山樱卯月": str12 = "flammpfeil.slashblade.named.yamazakura.uzuki"; str13 = "named/yamazakura/uzuki"; str14 = "named/yamazakura/yamazakura_uzuki"; break;
      case "山樱叶月": str12 = "flammpfeil.slashblade.named.yamazakura.hazuki"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_hazuki"; break;
      case "山樱如月「梅」": str12 = "flammpfeil.slashblade.named.yamazakura.ume"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_ume"; break;
      case "山樱弥生「樱」": str12 = "flammpfeil.slashblade.named.yamazakura.sakura"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_sakura"; break;
      case "山樱文月": str12 = "flammpfeil.slashblade.named.yamazakura.fumizuki"; str13 = "named/yamazakura/fumizuki"; str14 = "named/yamazakura/yamazakura_fumizuki"; break;
      case "山樱皋月": str12 = "flammpfeil.slashblade.named.yamazakura.satsuki"; str13 = "named/yamazakura/satsuki"; str14 = "named/yamazakura/yamazakura_satsuki"; break;
      case "山樱睦月「松」": str12 = "flammpfeil.slashblade.named.yamazakura.kadomatsu"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_kadomatsu"; break;
      case "山樱神无月「枫」": str12 = "flammpfeil.slashblade.named.yamazakura.kannazuki"; str13 = "named/yamazakura/kannazuki"; str14 = "named/yamazakura/yamazakura_kannazuki"; break;
      case "山樱长月「菊」": str12 = "flammpfeil.slashblade.named.yamazakura.kiku"; str13 = "named/yamazakura/model"; str14 = "named/yamazakura/yamazakura_kiku"; break;
      case "山樱霜月": str12 = "flammpfeil.slashblade.named.yamazakura.shimotsuki"; str13 = "named/yamazakura/shimotsuki"; str14 = "named/yamazakura/yamazakura_shimotsuki"; break;
      case "工-「儊晓」": str12 = "RuneSteel"; str13 = "blade"; str14 = "slash/RuneSteel"; break;
      case "工-「古一眉」": str12 = "AncientThulium"; str13 = "blade"; str14 = "slash/AncientThulium"; break;
      case "工-「魔钢刃」": str12 = "ManaS"; str13 = "blade"; str14 = "slash/ManaS"; break;
      case "巴鲁蒙格「胧」": str12 = "flammpfeil.slashblade.named.balmung"; str13 = "named/dios/dios"; str14 = "named/dios/balumg"; break;
      case "带鞘太刀": str12 = "flammpfeil.slashblade.named.sweapon"; str13 = "named/sweapon/model"; str14 = "named/sweapon/texture"; break;
      case "平庸「斗刀」": str12 = "flammpfeil.slashblade.named.kogawa_normal"; str13 = "named/namedblade/model"; str14 = "named/namedblade/texture_normal"; break;
      case "幻刃「灵物」露台": str12 = "wrap.exparmory.katana.manasteel"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryManasteel"; break;
      case "幻刃「玄绮」露台": str12 = "wrap.exparmory.katana.thaumium"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryThaumium"; break;
      case "幻刃「虚无」露台": str12 = "wrap.exparmory.katana.void"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryVoid"; break;
      case "幻魔炼金拵": str12 = "flammpfeil.slashblade.named.laemmle"; str13 = "named/laemmle/blade"; str14 = "named/laemmle/lem"; break;
      case "幽狂-「赤浴血」": str12 = "BloodMetal"; str13 = "named/agito"; str14 = "slash/BloodMetal"; break;
      case "异次元「管理者之刃」": str12 = "flammpfeil.slashblade.named.yiciyuan"; str13 = "named/yiciyuan/model"; str14 = "named/yiciyuan/texture"; break;
      case "异界剑魂「」": str12 = "flammpfeil.slashblade.named.soulb"; str13 = "named/latent/latent"; str14 = "named/latent/latent"; break;
      case "御神刀「神狐」": str12 = "kitsunekamuya.blade.ofudakitsunekamuya"; str13 = "ofudakitsunekamuya/model"; str14 = "ofudakitsunekamuya/texture"; break;
      case "德雷格兰「圣契」": str12 = "flammpfeil.slashblade.named.deligun"; str13 = "named/negorerouse/deligun"; str14 = "named/negorerouse/deligun"; break;
      case "折断的阎魔刀": str12 = "flammpfeil.slashblade.named.yamato.broken"; str13 = "named/yamato"; str14 = "named/yamato"; break;
      case "拉普兰德": str12 = "flammpfeil.slashblade.named.lappland"; str13 = "named/lappland/lappblade"; str14 = "named/lappland/lappblade"; break;
      case "拉普兰德「狼魂」": str12 = "flammpfeil.slashblade.named.lappland.wolfsoul"; str13 = "named/lappland/lappblade"; str14 = "named/lappland/lappblade"; break;
      case "拔刀剑": str12 = "flammpfeil.slashblade.named.slashblade_old"; str13 = "named/slashblade/1"; str14 = "named/slashblade/1"; break;
      case "撼地巨锤": str12 = "flammpfeil.slashblade.xianjiange.handichueisword"; str13 = "xianjiange/HTOD'sword/handichuei/model"; str14 = "xianjiange/HTOD'sword/handichuei/texture"; break;
      case "擒苍": str12 = "flammpfeil.slashblade.xianjiange.qingcangsword"; str13 = "xianjiange/HTOD'sword/qingcang/model"; str14 = "xianjiange/HTOD'sword/qingcang/texture"; break;
      case "散华": str12 = "flammpfeil.slashblade.named.sange"; str13 = "named/sange/sange"; str14 = "named/sange/sange"; break;
      case "文始": str12 = "flammpfeil.slashblade.named.roukan_tech"; str13 = "named/rf_roukan/model"; str14 = "named/rf_roukan/texture"; break;
      case "斑鸠之刃": str12 = "flammpfeil.slashblade.named.ikaruga"; str13 = "named/ikaruga/model"; str14 = "named/ikaruga/texture"; break;
      case "斗刀「孤独」": str12 = "flammpfeil.slashblade.named.kogawa_super"; str13 = "named/namedblade/model"; str14 = "named/namedblade/texture_super"; break;
      case "无神「无刃」": str12 = "flammpfeil.slashblade.named.kirisaya"; str13 = "named/kirisaya/kirisaya"; str14 = "named/kirisaya/kirisaya"; break;
      case "无铭「天狗作」": str12 = "flammpfeil.slashblade.named.birdblade_2"; str13 = "named/famous/1"; str14 = "named/bird/432"; break;
      case "无铭「影狐」": str12 = "flammpfeil.slashblade.named.mmf.fox"; str13 = "named/arthurs/model_fox"; str14 = "named/arthurs/texture_fox"; break;
      case "无铭「虚无」": str12 = "flammpfeil.slashblade.named.void_blade"; str13 = "named/sange/sange"; str14 = "named/void"; break;
      case "无铭刀「木偶」": str12 = "flammpfeil.slashblade.wood"; str13 = "blade"; str14 = "wood"; break;
      case "无铭刀「竹光」": str12 = "flammpfeil.slashblade.bamboo"; str13 = "blade"; str14 = "banboo"; break;
      case "无铭刀「简装」": str12 = "flammpfeil.slashblade.named.namedblade_basic"; str13 = "named/oldtime/soda"; str14 = "named/oldtime/2"; break;
      case "无魂剑「」": str12 = "flammpfeil.slashblade.named.platium.unelitism"; str13 = "named/"; str14 = ""; break;
      case "日耀剑「光日」": str12 = "flammpfeil.slashblade.named.mmf.tartaric_acid"; str13 = "named/sange/sange"; str14 = "named/arthurs/texture_943"; break;
      case "时之镰": str12 = "flammpfeil.slashblade.xianjiange.shizhiliansword"; str13 = "xianjiange/HTOD'sword/shizhilian/model"; str14 = "xianjiange/HTOD'sword/shizhilian/texture"; break;
      case "明兽刃「阳牙冰狼」": str12 = "flammpfeil.slashblade.named.frostwolfb"; str13 = "named/frostwolf/frostwolfb"; str14 = "named/frostwolf/frostwolfb"; break;
      case "明兽刃「阳牙冰狼」叁": str12 = "flammpfeil.slashblade.named.binglang"; str13 = "named/kevinwalker/binglang"; str14 = "named/kevinwalker/binglang"; break;
      case "明兽刃「阳牙冰狼」壹": str12 = "flammpfeil.slashblade.named.binglang"; str13 = "named/kevinwalker/binglang"; str14 = "named/kevinwalker/binglang"; break;
      case "明兽刃「阳牙冰狼」贰": str12 = "flammpfeil.slashblade.named.binglang"; str13 = "named/kevinwalker/binglang"; str14 = "named/kevinwalker/binglang"; break;
      case "星云剑「雾鸦」": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula"; break;
      case "星云剑「雾鸦」1": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula0"; break;
      case "星云剑「雾鸦」10": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula9"; break;
      case "星云剑「雾鸦」11": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula10"; break;
      case "星云剑「雾鸦」12": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula11"; break;
      case "星云剑「雾鸦」13": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula12"; break;
      case "星云剑「雾鸦」14": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula13"; break;
      case "星云剑「雾鸦」15": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula14"; break;
      case "星云剑「雾鸦」16": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula15"; break;
      case "星云剑「雾鸦」17": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula16"; break;
      case "星云剑「雾鸦」2": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula1"; break;
      case "星云剑「雾鸦」3": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula2"; break;
      case "星云剑「雾鸦」4": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula3"; break;
      case "星云剑「雾鸦」5": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula4"; break;
      case "星云剑「雾鸦」6": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula5"; break;
      case "星云剑「雾鸦」7": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula6"; break;
      case "星云剑「雾鸦」8": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula7"; break;
      case "星云剑「雾鸦」9": str12 = "innominandum.blade.BladeNebula"; str13 = "innominandum/nebula/nebula"; str14 = "innominandum/nebula/nebula8"; break;
      case "星典": str12 = "flammpfeil.slashblade.xianjiange.xingdiansword"; str13 = "xianjiange/HTOD'sword/xingdian/model"; str14 = "xianjiange/HTOD'sword/xingdian/texture"; break;
      case "星流利刃": str12 = "flammpfeil.slashblade.xianjiange.xinglioulirensword"; str13 = "xianjiange/HTOD'sword/xingliouliren/state/model"; str14 = "xianjiange/HTOD'sword/xingliouliren/state/texture"; break;
      case "普洛托革诺伊「始源」": str12 = "moflop.slashblade.protogenoi"; str13 = "named/negorerouse/protogenoi"; str14 = "named/negorerouse/protogenoi"; break;
      case "暗鸦": str12 = "flammpfeil.slashblade.named.darkraven"; str13 = "named/darkraven/darkraven"; str14 = "named/darkraven/darkraven"; break;
      case "曙色斩月": str12 = "twilighttsuki.blade.zangetsu"; str13 = "twilighttsuki/blade/tachi/zangetsu/zangetsu"; str14 = "twilighttsuki/blade/tachi/zangetsu/zangetsu"; break;
      case "月光樱「吹雪一闪」": str12 = "flammpfeil.slashblade.named.blademaster.moonlightcherry"; str13 = "named/blademaster/blademaster"; str14 = "named/blademaster/moonlightcherry"; break;
      case "月光紫「虚无之影」": str12 = "etherealshadow"; str13 = "kyokainokanata/etherealshadow"; str14 = "kyokainokanata/etherealshadow"; break;
      case "木刀「铁刀木」": str12 = "flammpfeil.slashblade.named.tagayasan"; str13 = "blade"; str14 = "named/tagayasan"; break;
      case "木鞘「「刃条」": str12 = "kitsunekamuya.blade.tobikitsunekamuya"; str13 = "tobikitsunekamuya/model"; str14 = "tobikitsunekamuya/texture"; break;
      case "木鞘「「神狐」": str12 = "kitsunekamuya.blade.shirokitsunekamuya"; str13 = "shirokitsunekamuya/model"; str14 = "shirokitsunekamuya/texture"; break;
      case "朴素拵": str12 = "lastsmith.handmade_saya_0"; str13 = "named/smith/model"; str14 = "handmade/sheath_0_wood"; break;
      case "杀马人之刃": str12 = "flammpfeil.slashblade.named.lappland.unelitism"; str13 = "named/lappland/lappblade"; str14 = "named/lappland/lappblade"; break;
      case "村锖丸": str12 = "housamo.blade.murasabimaru"; str13 = "housamo/model"; str14 = "housamo/murasamemaru"; break;
      case "村雨丸": str12 = "housamo.blade.murasamemaru"; str13 = "housamo/model"; str14 = "housamo/murasabimaru"; break;
      case "杰克的武士刀": str12 = "wrap.cwm.SamuriJack"; str13 = "blade"; str14 = "named/ExparmoryBlade/CWMSamuriJack"; break;
      case "极寒刃「雪走」· 雪": str12 = "flammpfeil.slashblade.named.xuezou"; str13 = "named/xuezou/model"; str14 = "named/xuezou/texture"; break;
      case "枯石大刀": str12 = "flammpfeil.slashblade.named.koseki"; str13 = "named/dios/dios"; str14 = "named/dios/koseki"; break;
      case "柮夭": str12 = "flammpfeil.slashblade.xianjiange.zuoyaosword"; str13 = "xianjiange/HTOD'sword/zuoyao/model"; str14 = "xianjiange/HTOD'sword/zuoyao/texture"; break;
      case "柯罗诺斯「万古琨矇」": str12 = "flammpfeil.slashblade.named.aeon"; str13 = "named/negorerouse/aeon"; str14 = "named/negorerouse/aeon"; break;
      case "柯罗诺斯「始源之枪」": str12 = "flammpfeil.slashblade.named.chronossy"; str13 = "named/negorerouse/chronossy"; str14 = "named/negorerouse/chronossy"; break;
      case "柯罗诺斯「永境之主」": str12 = "moflop.slashblade.chronosn"; str13 = "named/negorerouse/chronosn"; str14 = "named/negorerouse/chronosn"; break;
      case "棘羽「毕方」": str12 = "flammpfeil.slashblade.named.bifang"; str13 = "named/bifang/model"; str14 = "named/bifang/texture"; break;
      case "森森幽罗「青鬼」": str12 = "flammpfeil.slashblade.named.qinggui"; str13 = "named/qinggui/model"; str14 = "named/qinggui/texture"; break;
      case "模造刀「无魂」": str12 = "flammpfeil.slashblade.model_Blade"; str13 = "blade"; str14 = "model/unnamed/texture_model"; break;
      case "模造刀「武兴」": str12 = "flammpfeil.slashblade.model_Blade_1"; str13 = "blade"; str14 = "model/unnamed/texture_model_1"; break;
      case "次元之刃「伪」": str12 = "flammpfeil.slashblade.named.dimension"; str13 = "named/dimension/dimension"; str14 = "named/dimension/dimension"; break;
      case "欺骗者「影月」· 月": str12 = "flammpfeil.slashblade.named.yingyue"; str13 = "named/yingyue/model"; str14 = "named/yingyue/texture"; break;
      case "死神「幽之名」": str12 = "flammpfeil.slashblade.named.youming"; str13 = "named/youming/model"; str14 = "named/youming/texture"; break;
      case "水波折": str12 = "flammpfeil.slashblade.xianjiange.shueibozhesword"; str13 = "xianjiange/HTOD'sword/shueibozhesword/model"; str14 = "xianjiange/HTOD'sword/shueibozhesword/texture"; break;
      case "洞爷湖": str12 = "flammpfeil.slashblade.named.toyako"; str13 = "named/toyako/toyako"; str14 = "named/toyako/toyako"; break;
      case "洞虚幻刃": str12 = "flammpfeil.slashblade.xianjiange.voidswordsword"; str13 = "xianjiange/HTOD'sword/voidsword/model"; str14 = "xianjiange/HTOD'sword/voidsword/state/texture"; break;
      case "海格力斯「闪耀之星」": str12 = "moflop.slashblade.hercules"; str13 = "named/negorerouse/hercules"; str14 = "named/negorerouse/hercules"; break;
      case "渝州「长清」": str12 = "flammpfeil.slashblade.named.mmf.r_liu"; str13 = "named/arthurs/model_0"; str14 = "named/arthurs/texture_0"; break;
      case "激光剑1": str12 = "flammpfeil.slashblade.xianjiange.laserswordsword.state"; str13 = "xianjiange/HTOD'sword/lasersword/state/model"; str14 = "xianjiange/HTOD'sword/lasersword/state/textuer"; break;
      case "激光剑2": str12 = "flammpfeil.slashblade.xianjiange.laserswordsword.state"; str13 = "xianjiange/HTOD'sword/lasersword/state/model"; str14 = "xianjiange/HTOD'sword/lasersword/state/textuer"; break;
      case "激光剑3": str12 = "flammpfeil.slashblade.xianjiange.laserswordsword.state"; str13 = "xianjiange/HTOD'sword/lasersword/state/model"; str14 = "xianjiange/HTOD'sword/lasersword/state/textuer"; break;
      case "灵刃「狐月刀」": str12 = "flammpfeil.slashblade.named.foxfinal"; str13 = "named/foxex/model2"; str14 = "named/foxex/texture3"; break;
      case "灵钢刃「仙狐」": str12 = "flammpfeil.slashblade.named.fox_faerie"; str13 = "named/foxextra/model"; str14 = "named/foxextra/bladeFaerie"; break;
      case "灵钢刃「技术革新」": str12 = "flammpfeil.slashblade.named.mrblade_final"; str13 = "named/mrblade/advanced"; str14 = "named/mrblade/texture"; break;
      case "灵钢刃「灵狐」": str12 = "flammpfeil.slashblade.named.fox_elf"; str13 = "named/foxextra/model"; str14 = "named/foxextra/bladeElf"; break;
      case "灵钢刃「能量守恒」": str12 = "flammpfeil.slashblade.named.kineticenergyblade_final"; str13 = "named/mrblade/advanced"; str14 = "named/mrblade/texture"; break;
      case "灾厄之源「劫」": str12 = "flammpfeil.slashblade.named.jie"; str13 = "named/jie/model"; str14 = "named/jie/texture"; break;
      case "炎刀「炽铁」露台": str12 = "twilighttsuki.tfblade.fiery"; str13 = "blade"; str14 = "TFFiery"; break;
      case "炎极必寒「极意」": str12 = "flammpfeil.slashblade.named.jiyi"; str13 = "named/jiyi/model"; str14 = "named/jiyi/texture"; break;
      case "炎王-「火红莲」": str12 = "Crimson"; str13 = "named/agito"; str14 = "slash/Crimson"; break;
      case "炎王「流刃若火」": str12 = "flammpfeil.slashblade.named.lrrh"; str13 = "named/lrrh/model"; str14 = "named/lrrh/texture"; break;
      case "炼狱刀「死念」": str12 = "flammpfeil.slashblade.named.nihilbx"; str13 = "named/nihil/nihil"; str14 = "named/nihil/nihil_bx"; break;
      case "炼狱刀「真红」": str12 = "shinkuofuda.blade.shinku"; str13 = "shinkuofuda/shinku/model"; str14 = "shinkuofuda/shinku/texture"; break;
      case "炼狱刀「血腥」": str12 = "flammpfeil.slashblade.named.bloodkatanat"; str13 = "named/bloodkatanat/model"; str14 = "named/bloodkatanat/texture"; break;
      case "狐月刀「仙狐」": str12 = "flammpfeil.slashblade.named.foxex"; str13 = "named/foxex/model"; str14 = "named/foxex/texture"; break;
      case "狐月刀「灵狐」": str12 = "flammpfeil.slashblade.named.foxex2"; str13 = "named/foxex/model"; str14 = "named/foxex/texture2"; break;
      case "狐月刀「白狐」": str12 = "flammpfeil.slashblade.named.fox.white"; str13 = "named/sange/sange"; str14 = "named/sange/white"; break;
      case "狐月刀「黑狐」": str12 = "flammpfeil.slashblade.named.fox.black"; str13 = "named/sange/sange"; str14 = "named/sange/black"; break;
      case "狗年专属「啸月」": str12 = "flammpfeil.slashblade.named.xiaoyue"; str13 = "named/xiaoyue/model"; str14 = "named/xiaoyue/texture"; break;
      case "狱刀「似蛭」": str12 = "flammpfeil.slashblade.named.nihilul"; str13 = "named/nihil/nihil"; str14 = "named/nihil/nihilul"; break;
      case "狱刀「死念」赝": str12 = "shinkuofuda.blade.nihilexfake"; str13 = "shinkuofuda/nihilexfake/model"; str14 = "shinkuofuda/nihilexfake/texture"; break;
      case "狱刀「死念」赝 ": str12 = "flammpfeil.slashblade.named.bloodkatana"; str13 = "named/bloodkatana/model"; str14 = "named/bloodkatana/texture"; break;
      case "狱界剑「楼观剑」": str12 = "flammpfeil.slashblade.named.roukan_nether"; str13 = "named/roukan/model"; str14 = "named/roukan/texture_tx"; break;
      case "狱界剑「白楼剑」": str12 = "flammpfeil.slashblade.named.hakurou_nether"; str13 = "named/hakurou/model"; str14 = "named/hakurou/texture_tx"; break;
      case "现世刀「斩月」": str12 = "flammpfeil.slashblade.named.zangetsu"; str13 = "named/zhanyue/zhanyue"; str14 = "named/zhanyue/zhanyue"; break;
      case "生机「绿萝」": str12 = "flammpfeil.slashblade.named.lvluo"; str13 = "named/lvluo/model"; str14 = "named/lvluo/texture"; break;
      case "白「天锁斩月」": str12 = "flammpfeil.slashblade.named.zhanyue"; str13 = "named/zhanyue/model"; str14 = "named/zhanyue/texture"; break;
      case "白の契约": str12 = "flammpfeil.slashblade.named.baishiyue"; str13 = "named/baiqiyue/model"; str14 = "named/baiqiyue/texture"; break;
      case "白の约定": str12 = "flammpfeil.slashblade.named.baiyueding"; str13 = "named/baiyueding/model"; str14 = "named/baiyueding/texture"; break;
      case "白兰剑「君」": str12 = "flammpfeil.slashblade.named.bailan"; str13 = "blade"; str14 = "named/bailan/texture"; break;
      case "白刃": str12 = "flammpfeil.slashblade.xianjiange.bairensword"; str13 = "xianjiange/HTOD'sword/bairen/model"; str14 = "xianjiange/HTOD'sword/bairen/texture"; break;
      case "白金": str12 = "flammpfeil.slashblade.named.nmsl"; str13 = "named/blade"; str14 = "named/NMSL/NMSL"; break;
      case "百兽剑王「巨狮」": str12 = "flammpfeil.slashblade.named.baishoujianwang"; str13 = "named/baishoujianwang/model"; str14 = "named/baishoujianwang/texture"; break;
      case "真 · 龙一「文字」": str12 = "flammpfeil.slashblade.named.origin"; str13 = "named/splight/origin/model"; str14 = "named/splight/origin/texture"; break;
      case "石剑「」": str12 = "flammpfeil.slashblade.named.blade"; str13 = "named/blade/blade"; str14 = "named/blade/blade"; break;
      case "神威刀「乌卡」": str12 = "flammpfeil.slashblade.named.kamuy.water"; str13 = "named/kamuy/kamuy"; str14 = "named/kamuy/water"; break;
      case "神威刀「坎那」": str12 = "flammpfeil.slashblade.named.kamuy.lightning"; str13 = "named/kamuy/kamuy"; str14 = "named/kamuy/lightning"; break;
      case "神威刀「虎杖丸」": str12 = "flammpfeil.slashblade.named.kamuy.base"; str13 = "named/kamuy/kamuy"; str14 = "named/kamuy/kamuy"; break;
      case "神威刀「阿贝」": str12 = "flammpfeil.slashblade.named.kamuy.fire"; str13 = "named/kamuy/kamuy"; str14 = "named/kamuy/fire"; break;
      case "神秘要塞日本刀": str12 = "flammpfeil.slashblade.named.fortress.thaumium"; str13 = "named/smith/model"; str14 = "named/thaum/texture_thaumium"; break;
      case "神钢刃「工艺复兴」": str12 = "flammpfeil.slashblade.named.craftrev_extra"; str13 = "named/mrblade/advanced"; str14 = "named/mrblade/texture_craft"; break;
      case "神钢刃「血腥革新」": str12 = "flammpfeil.slashblade.named.bloodrev_extra"; str13 = "named/mrblade/advanced"; str14 = "named/mrblade/texture_blood"; break;
      case "神陨剑": str12 = "flammpfeil.slashblade.xianjiange.shenyunjiansword"; str13 = "xianjiange/HTOD'sword/shenyunjian/model"; str14 = "xianjiange/HTOD'sword/shenyunjian/texture"; break;
      case "管理员之刃「伪物」": str12 = "flammpfeil.slashblade.named.administrator"; str13 = "named/administrator/administrator"; str14 = "named/administrator/administrator"; break;
      case "紫刃「虚」": str12 = "flammpfeil.slashblade.named.purpleblade"; str13 = "named/purplesblade/purplesblade"; str14 = "named/purplesblade/purplesblade"; break;
      case "纳米太刀": str12 = "flammpfeil.slashblade.named.nanosaber"; str13 = "named/nanosaber/model"; str14 = "named/nanosaber/texture"; break;
      case "结月刀「付丧」": str12 = "flammpfeil.slashblade.named.yuzukitukumo"; str13 = "named/agito"; str14 = "named/a_tukumo"; break;
      case "结月刀「付丧」叁": str12 = "flammpfeil.slashblade.named.jieyue"; str13 = "named/kevinwalker/jieyue"; str14 = "named/kevinwalker/jieyue"; break;
      case "结月刀「付丧」壹": str12 = "flammpfeil.slashblade.named.jieyue"; str13 = "named/kevinwalker/jieyue"; str14 = "named/kevinwalker/jieyue"; break;
      case "结月刀「付丧」肆": str12 = "flammpfeil.slashblade.named.jieyue"; str13 = "named/kevinwalker/jieyue"; str14 = "named/kevinwalker/jieyue"; break;
      case "结月刀「付丧」贰": str12 = "flammpfeil.slashblade.named.jieyue"; str13 = "named/kevinwalker/jieyue"; str14 = "named/kevinwalker/jieyue"; break;
      case "结月刀「因缘」": str12 = "flammpfeil.slashblade.named.yukari"; str13 = "named/yukari/model"; str14 = "named/yukari/texture"; break;
      case "美工刀": str12 = "flammpfeil.slashblade.xianjiange.meigongdao"; str13 = "xianjiange/HTOD'sword/meigongdao/model"; str14 = "xianjiange/HTOD'sword/meigongdao/texture"; break;
      case "聚变之星 · 倪克斯「辰宿瞬变」": str12 = "flammpfeil.slashblade.named.nyx"; str13 = "named/negorerouse/nyx"; str14 = "named/negorerouse/nyx"; break;
      case "自定义": str12 = "custom_dios"; str13 = "named/dios/dios"; str14 = "named/dios/dios"; break;
      case "自铭「切裂」": str12 = "flammpfeil.slashblade.named.smithblade_basic_colored"; str13 = "named/famous/1"; str14 = "named/heartwork/color1"; break;
      case "自铭「妖侟」": str12 = "flammpfeil.slashblade.named.smithblade_bewitched_colored"; str13 = "named/famous/1"; str14 = "named/heartwork/color5"; break;
      case "自铭「平凡」": str12 = "flammpfeil.slashblade.named.smith_3"; str13 = "named/muramasa/muramasa"; str14 = "named/smith/smith_2"; break;
      case "自铭「御敌」": str12 = "flammpfeil.slashblade.named.smith_knife_2"; str13 = "named/smith/model_knife"; str14 = "named/smith/texture_knife_2"; break;
      case "自铭「止步」": str12 = "flammpfeil.slashblade.named.smith_1"; str13 = "named/muramasa/muramasa"; str14 = "named/smith/smith_0"; break;
      case "自铭「白露」": str12 = "flammpfeil.slashblade.named.smith_knife_1"; str13 = "named/smith/model_knife"; str14 = "named/smith/texture_knife_1"; break;
      case "自铭「白鞘」": str12 = "flammpfeil.slashblade.named.smithblade_basic"; str13 = "named/oldtime/soda"; str14 = "named/heartwork/2"; break;
      case "自铭「短刀」": str12 = "flammpfeil.slashblade.named.smith_knife"; str13 = "named/smith/model_knife"; str14 = "named/smith/texture_knife"; break;
      case "自铭「起源」": str12 = "flammpfeil.slashblade.unnamedBlade"; str13 = "blade"; str14 = "model/unnamed/texture"; break;
      case "自铭「迷途」": str12 = "flammpfeil.slashblade.named.smith_2"; str13 = "named/muramasa/muramasa"; str14 = "named/smith/smith_1"; break;
      case "自锻刀「神秘」": str12 = "lastsmith.handmade_thaum"; str13 = "named/yasha/yasha"; str14 = "handmade/white_thaum"; break;
      case "自锻刀「红钢」": str12 = "flammpfeil.slashblade.handmade.red_steel"; str13 = "named/smith/model"; str14 = "handmade/sheath_1_red_steel"; break;
      case "自锻刀「蓝钢」": str12 = "flammpfeil.slashblade.handmade.blue_steel"; str13 = "named/smith/model"; str14 = "handmade/sheath_1_blue_steel"; break;
      case "自锻刀「虚空」": str12 = "lastsmith.handmade_void"; str13 = "named/yasha/yasha"; str14 = "handmade/white_void"; break;
      case "花之妖精「弥葵」· 花": str12 = "flammpfeil.slashblade.named.huami"; str13 = "named/huami/model"; str14 = "named/huami/texture"; break;
      case "花天狂骨「花天」": str12 = "flammpfeil.slashblade.named.htkg"; str13 = "named/htkg/model"; str14 = "named/htkg/texture"; break;
      case "荆棘之刃「虚」": str12 = "flammpfeil.slashblade.named.vitex"; str13 = "named/vitex/vitex"; str14 = "named/vitex/vitex"; break;
      case "荧光": str12 = "flammpfeil.slashblade.named.fluorescentbar"; str13 = "named/fluorescentbar/fluorescentbar"; str14 = "named/fluorescentbar/fluorescentbar"; break;
      case "落樱何思": str12 = "twilighttsuki.blade.hananichi"; str13 = "twilighttsuki/blade/tachi/hananichi/hananichi"; str14 = "twilighttsuki/blade/tachi/hananichi/hananichi"; break;
      case "落英拵": str12 = "lastsmith.handmade_saya_1"; str13 = "named/smith/model"; str14 = "handmade/sheath_1_wood"; break;
      case "虚无之刃「」": str12 = "flammpfeil.slashblade.named.emptyblade"; str13 = "named/emptyblade/emptyblade"; str14 = "named/emptyblade/emptyblade"; break;
      case "虚空要塞日本刀": str12 = "flammpfeil.slashblade.named.fortress.void"; str13 = "named/smith/model"; str14 = "named/thaum/texture_voidmetal"; break;
      case "血刀「似蛭」": str12 = "flammpfeil.slashblade.named.nihilex"; str13 = "named/nihil/nihil"; str14 = "named/nihil/nihilex"; break;
      case "血刃「栗山未来」": str12 = "kuriyamamirai"; str13 = "kyokainokanata/kuriyamamirai"; str14 = "kyokainokanata/kuriyamamirai"; break;
      case "血月": str12 = "flammpfeil.slashblade.xianjiange.xueyesword"; str13 = "xianjiange/HTOD'sword/xueye/model"; str14 = "xianjiange/HTOD'sword/xueye/texture"; break;
      case "血腥要塞日本刀": str12 = "flammpfeil.slashblade.named.fortress.crimson"; str13 = "named/smith/model"; str14 = "named/thaum/texture_crimson"; break;
      case "血色木偶": str12 = "flammpfeil.slashblade.xianjiange.inequablepuppet"; str13 = "xianjiange/HTOD'sword/yaoyan/model"; str14 = "xianjiange/HTOD'sword/yaoyan/texture"; break;
      case "质太刀-「舞纵」": str12 = "NeutronEnergy"; str13 = "named/sange/sange"; str14 = "slash/NeutronEnergy"; break;
      case "赝刀「山吹」露台": str12 = "wrap.exparmory.katana.gildediron"; str13 = "blade"; str14 = "named/ExparmoryBlade/ExparmoryGildediron"; break;
      case "轩辕剑": str12 = "flammpfeil.slashblade.xianjiange.xuanyuansword"; str13 = "xianjiange/HTOD'sword/xuanyuan/model"; str14 = "xianjiange/HTOD'sword/xuanyuan/texture"; break;
      case "逐焰": str12 = "flammpfeil.slashblade.xianjiange.zhuyansword"; str13 = "xianjiange/HTOD'sword/zhuyan/state/model"; str14 = "xianjiange/HTOD'sword/zhuyan/texture"; break;
      case "邪魔刃「修罗」": str12 = "flammpfeil.slashblade.named.shura"; str13 = "named/sakura/model"; str14 = "named/sakura/texture_4"; break;
      case "邪魔刃「双」": str12 = "flammpfeil.slashblade.named.kataware"; str13 = "named/sakura/model"; str14 = "named/sakura/texture_3"; break;
      case "鄂门": str12 = "flammpfeil.slashblade.named.orotiagito.seald"; str13 = "named/agito"; str14 = "named/agito_true"; break;
      case "鄂门 ": str12 = "flammpfeil.slashblade.named.agito"; str13 = "named/agito"; str14 = "named/agito_false"; break;
      case "鄂门 (锈)": str12 = "flammpfeil.slashblade.named.orotiagito.rust"; str13 = "named/agito"; str14 = "named/agito_rust_true"; break;
      case "鄂门 (锈) ": str12 = "flammpfeil.slashblade.named.agito.rust"; str13 = "named/agito"; str14 = "named/agito_rust"; break;
      case "量子太刀": str12 = "flammpfeil.slashblade.named.quantumsaber"; str13 = "named/nanosaber/model"; str14 = "named/nanosaber/texture_1"; break;
      case "钢刃「源初」": str12 = "flammpfeil.slashblade.named.trblade_first"; str13 = "named/mrblade/basic"; str14 = "named/mrblade/trfirst"; break;
      case "钢刃「白狐」": str12 = "flammpfeil.slashblade.named.electric_fox_white"; str13 = "named/sange/sange"; str14 = "named/sange/white"; break;
      case "钢刃「纳米科技」": str12 = "flammpfeil.slashblade.named.hyperblade_second"; str13 = "named/mrblade/basic"; str14 = "named/mrblade/hypersecond"; break;
      case "钢刃「黑狐」": str12 = "flammpfeil.slashblade.named.electric_fox_black"; str13 = "named/sange/sange"; str14 = "named/sange/black"; break;
      case "钢枪「云破」": str12 = "flammpfeil.slashblade.named.B"; str13 = "named/BladeAnti/ChangQiang"; str14 = "named/BladeAnti/ChangQiang"; break;
      case "钻石剑「」": str12 = "flammpfeil.slashblade.named.blade"; str13 = "named/blade/blade"; str14 = "named/blade/blade"; break;
      case "铁剑「」": str12 = "flammpfeil.slashblade.named.blade"; str13 = "named/blade/blade"; str14 = "named/blade/blade"; break;
      case "铭刀「悭臾」": str12 = "flammpfeil.slashblade.named.qianyu"; str13 = "named/qianyu/qianyu"; str14 = "named/qianyu/qianyu"; break;
      case "铭刀「蟾宫」": str12 = "flammpfeil.slashblade.named.changong"; str13 = "named/changong/changong"; str14 = "named/changong/changong"; break;
      case "铭刀「鱼音」": str12 = "flammpfeil.slashblade.named.yuyin"; str13 = "named/yuyin/yuyin"; str14 = "named/yuyin/yuyin"; break;
      case "银灰": str12 = "flammpfeil.slashblade.named.platium"; str13 = "named/blade"; str14 = ""; break;
      case "锁狱镰": str12 = "flammpfeil.slashblade.xianjiange.suoyuliansword"; str13 = "xianjiange/HTOD'sword/suoyulian/model"; str14 = "xianjiange/HTOD'sword/suoyulian/texture"; break;
      case "锁魂": str12 = "flammpfeil.slashblade.xianjiange.shuohunsword"; str13 = "xianjiange/HTOD'sword/shuohun/model"; str14 = "xianjiange/HTOD'sword/shuohun/texture"; break;
      case "锈刀": str12 = "flammpfeil.slashblade.named.sabigatana"; str13 = "named/muramasa/muramasa"; str14 = "named/muramasa/sabigatana"; break;
      case "锈迹斑斑的刀": str12 = "kitsunekamuya.blade.sabigakitsunekamuya"; str13 = "sabigakitsunekamuya/model"; str14 = "sabigakitsunekamuya/texture"; break;
      case "长空落日": str12 = "flammpfeil.slashblade.xianjiange.changkongluorsword"; str13 = "xianjiange/HTOD'sword/changkongluor/model"; str14 = "xianjiange/HTOD'sword/changkongluor/texture"; break;
      case "阳": str12 = "flammpfeil.slashblade.xianjiange.yang"; str13 = "xianjiange/HTOD'sword/bagua/model"; str14 = "xianjiange/HTOD'sword/bagua/yang"; break;
      case "阴": str12 = "flammpfeil.slashblade.xianjiange.yin"; str13 = "xianjiange/HTOD'sword/bagua/model"; str14 = "xianjiange/HTOD'sword/bagua/yin"; break;
      case "阿尔忒弥斯「影月」": str12 = "moflop.slashblade.artemis"; str13 = "named/negorerouse/artemis"; str14 = "named/negorerouse/artemis"; break;
      case "阿尔忒弥斯「耀月」": str12 = "flammpfeil.slashblade.named.artemiss"; str13 = "named/negorerouse/artemiss"; str14 = "named/negorerouse/artemiss"; break;
      case "陨星杖": str12 = "flammpfeil.slashblade.xianjiange.yunxingzhangsword"; str13 = "xianjiange/HTOD'sword/yunxingzhangsword/model"; str14 = "xianjiange/HTOD'sword/yunxingzhangsword/texture"; break;
      case "雪鸦": str12 = "flammpfeil.slashblade.named.snowcrow"; str13 = "named/darkraven/snowcrow"; str14 = "named/darkraven/snowcrow"; break;
      case "青云": str12 = "flammpfeil.slashblade.xianjiange.qingyunsword"; str13 = "xianjiange/HTOD'sword/qingyun/model"; str14 = "xianjiange/HTOD'sword/qingyun/texture"; break;
      case "青瓷「伞」": str12 = "flammpfeil.slashblade.named.B"; str13 = "named/BladeAnti/San"; str14 = "named/BladeAnti/San"; break;
      case "静秘守卫": str12 = "flammpfeil.slashblade.xianjiange.jingmisouweisword"; str13 = "xianjiange/HTOD'sword/jingmisouwei/model"; str14 = "xianjiange/HTOD'sword/jingmisouwei/texture"; break;
      case "风雷要塞日本刀": str12 = "flammpfeil.slashblade.named.fortress.elemental"; str13 = "named/smith/model"; str14 = "named/thaum/texture_elemental"; break;
      case "驱魔刃「杏」": str12 = "flammpfeil.slashblade.named.ginkgo"; str13 = "named/sakura/model"; str14 = "named/sakura/texture_1"; break;
      case "驱魔刃「樱」": str12 = "flammpfeil.slashblade.named.sakura"; str13 = "named/sakura/model"; str14 = "named/sakura/texture"; break;
      case "驱魔刃「雪影」": str12 = "flammpfeil.slashblade.named.yukikage"; str13 = "named/sakura/model"; str14 = "named/sakura/texture_2"; break;
      case "魔剑「阎魔刀」": str12 = "flammpfeil.slashblade.named.yamato"; str13 = "named/yamato"; str14 = "named/yamato"; break;
      case "黑刃": str12 = "flammpfeil.slashblade.xianjiange.heirensword"; str13 = "xianjiange/HTOD'sword/heiren/model"; str14 = "xianjiange/HTOD'sword/heiren/texture"; break;
      case "黑快刀-「帝心」": str12 = "Bedrock"; str13 = "named/agito"; str14 = "slash/Bedrock"; break;
      case "黑快刀-「银刃」": str12 = "Dark"; str13 = "named/agito"; str14 = "slash/Dark"; break;
      case "龙一「战队超人」": str12 = "flammpfeil.slashblade.named.senta"; str13 = "named/splight/senta/model"; str14 = "named/splight/senta/texture"; break;
      case "龙一「文字」": str12 = "flammpfeil.slashblade.named.splight"; str13 = "named/sange/sange"; str14 = "named/splight/splight"; break;
      case "龙一「青年」": str12 = "flammpfeil.slashblade.named.young"; str13 = "named/splight/young/model"; str14 = "named/splight/young/texture_o"; break;
      case "龙一「麻雀」": str12 = "flammpfeil.slashblade.named.young"; str13 = "named/splight/young/model"; str14 = "named/splight/young/texture_g"; break;
      case "龙一「黑色守望」": str12 = "flammpfeil.slashblade.named.blackwatch"; str13 = "named/splight/blackwatch/model"; str14 = "named/splight/blackwatch/texture"; break;
      case "龙刃「猩红」": str12 = "flammpfeil.slashblade.named.dragonblade"; str13 = "named/dragonblade/dragonblade"; str14 = "named/dragonblade/dragonblade"; break;
      case "龙剑「行草俱利伽罗刻」": str12 = "twilighttsuki.blade.kurikara"; str13 = "twilighttsuki/blade/tachi/kurikara/kurikara"; str14 = "twilighttsuki/blade/tachi/kurikara/kurikara"; break;
      case "龙太刀「噬风者」": str12 = "flammpfeil.slashblade.named.windeater"; str13 = ""; str14 = ""; break;
      case "龙太刀「西风」": str12 = "flammpfeil.slashblade.zephyr"; str13 = "zephyr/model"; str14 = "zephyr/tex"; break;
      default: str12 = "custom_dios"; str13 = "named/dios/dios"; str14 = "named/dios/dios"; break;
    }

    if (str12 == "") {
      MessageBox.Show("模型未选择或该模型无效，请选择一个合适的模型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    } else {
      string str15;
      switch (index2) { 
        case 0: str15 = ""; break; 
        case 1: str15 = "0"; break; 
        case 2: str15 = "1"; break; 
        case 3: str15 = "8"; break; 
        case 4: str15 = "3"; break; 
        case 5: str15 = "2"; break; 
        case 6: str15 = "5"; break; 
        case 7: str15 = "4"; break; 
        case 8: str15 = "6"; break; 
        case 9: str15 = "7"; break; 
        case 10: str15 = "39"; break; 
        case 11: str15 = "20"; break; 
        case 12: str15 = "35"; break; 
        case 13: str15 = "36"; break; 
        case 14: str15 = "37"; break; 
        case 15: str15 = "38"; break; 
        case 16: str15 = "30"; break; 
        case 17: str15 = "31"; break; 
        case 18: str15 = "32"; break; 
        case 19: str15 = "159"; break; 
        case 20: str15 = "56709"; break; 
        case 21: str15 = "324"; break; 
        case 22: str15 = "423"; break; 
        case 23: str15 = "424"; break; 
        case 24: str15 = "1587"; break; 
        case 25: str15 = "7436"; break; 
        case 26: str15 = ""; break; 
        case 27: str15 = "20011116"; break; 
        case 28: str15 = "765432233"; break;
        case 29: str15 = "263"; break; 
        case 30: str15 = "265"; break; 
        case 31: str15 = "266"; break; 
        case 32: str15 = "264"; break; 
        case 33: str15 = "16"; break; 
        case 34: str15 = "17"; break; 
        case 35: str15 = "11"; break; 
        case 36: str15 = "12"; break; 
        case 37: str15 = "33"; break; 
        case 38: str15 = "16"; break; 
        case 39: str15 = "17"; break; 
        case 40: str15 = "60"; break; 
        case 41: str15 = "19"; break; 
        case 42: str15 = "21"; break; 
        case 43: str15 = "22"; break; 
        case 44: str15 = "23"; break; 
        case 45: str15 = "18"; break; 
        case 46: str15 = "24"; break;
        case 47: str15 = "25"; break;
        case 48: str15 = "26"; break;
        case 49: str15 = "27"; break;
        case 50: str15 = "28"; break; 
        case 51: str15 = "29"; break;
        case 52: str15 = "40"; break;
        case 53: str15 = "41"; break; 
        case 54: str15 = "61"; break; 
        case 55: str15 = "62"; break; 
        case 56: str15 = "63"; break; 
        case 57: str15 = "64"; break; 
        case 58: str15 = "-1"; break; 
        case 59: str15 = "-2"; break; 
        case 60: str15 = "-3"; break; 
        case 61: str15 = "-4"; break; 
        case 62: str15 = "-7"; break; 
        case 63: str15 = "-5"; break; 
        case 64: str15 = "-6"; break; 
        case 65: str15 = "-9"; break; 
        case 66: str15 = "-10"; break; 
        case 67: str15 = "-11"; break; 
        case 68: str15 = "-12"; break; 
        case 69: str15 = "-13"; break; 
        case 70: str15 = "-14"; break; 
        case 71: str15 = "-15"; break; 
        case 72: str15 = "-18"; break; 
        case 73: str15 = "-17"; break; 
        case 74: str15 = "-19"; break; 
        case 75: str15 = "-20"; break; 
        case 76: str15 = "-21"; break; 
        case 77: str15 = "-22"; break; 
        case 78: str15 = "-23"; break; 
        case 79: str15 = "-24"; break; 
        case 80: str15 = "-16"; break; 
        case 81: str15 = "-25"; break; 
        case 82: str15 = "-26"; break; 
        case 83: str15 = "-27"; break; 
        case 84: str15 = "-8"; break; 
        case 85: str15 = "-28"; break; 
        case 86: str15 = "152"; break; 
        case 87: str15 = "750954"; break; 
        case 88: str15 = "750955"; break; 
        case 89: str15 = "760959"; break; 
        case 90: str15 = "13248569"; break; 
        case 91: str15 = "13248999"; break; 
        case 92: str15 = "101"; break; 
        case 93: str15 = "102"; break; 
        case 94: str15 = "12001"; break; 
        case 95: str15 = "12002"; break; 
        case 96: str15 = "12003"; break; 
        case 97: str15 = "12004"; break; 
        case 98: str15 = "12005"; break; 
        case 99: str15 = "12006"; break; 
        case 100: str15 = "12007"; break; 
        case 101: str15 = "4106"; break; 
        case 102: str15 = "4105"; break; 
        case 103: str15 = "4104"; break; 
        case 104: str15 = "4101"; break; 
        case 105: str15 = "4103"; break; 
        case 106: str15 = "4102"; break; 
        case 107: str15 = "4100"; break; 
        case 108: str15 = "4200"; break; 
        case 109: str15 = "1701"; break; 
        case 110: str15 = "1702"; break; 
        case 111: str15 = "1703"; break; 
        case 112: str15 = "1704"; break; 
        case 113: str15 = "1705"; break; 
        case 114: str15 = "1706"; break; 
        case 115: str15 = "1707"; break; 
        case 116: str15 = "1708"; break; 
        case 117: str15 = "1709"; break; 
        case 118: str15 = "1710"; break; 
        case 119: str15 = "1711"; break; 
        case 120: str15 = "1712"; break; 
        case 121: str15 = "1713"; break;
        case 122: str15 = "1005"; break;
        case 123: str15 = "8888"; break; 
        case 124: str15 = "6666"; break; 
        case 125: str15 = "2333"; break; 
        case 126: str15 = "99999"; break; 
        case 127: str15 = "654897"; break;
        case 128: str15 = "123456"; break; 
        case 129: str15 = "11111111"; break; 
        case 130: str15 = "23345"; break; 
        case 131: str15 = "111222333"; break; 
        case 132: str15 = "65489747"; break; 
        case 133: str15 = "243"; break; 
        case 134: str15 = "244"; break; 
        case 135: str15 = "245"; break; 
        case 136: str15 = "246"; break; 
        case 137: str15 = "247"; break; 
        case 138: str15 = "4000"; break; 
        case 139: str15 = "10011"; break; 
        case 140: str15 = "10001"; break; 
        case 141: str15 = "10002"; break; 
        case 142: str15 = "10003"; break; 
        case 143: str15 = "10004"; break; 
        case 144: str15 = "10012"; break; 
        case 145: str15 = "10005"; break; 
        case 146: str15 = "10006"; break; 
        case 147: str15 = "10007"; break; 
        case 148: str15 = "10009"; break; 
        case 149: str15 = "10008"; break; 
        case 150: str15 = "10010"; break; 
        case 151: str15 = "12075"; break; 
        case 152: str15 = "12076"; break; 
        case 153: str15 = "12077"; break; 
        case 154: str15 = "42"; break; 
        case 155: str15 = "678"; break; 
        case 156: str15 = "4445"; break; 
        case 157: str15 = "4446"; break; 
        case 158: str15 = "66"; break; 
        case 159: str15 = "42"; break; 
        default: str15 = ""; break;
      }

      for (int index3 = 1; index3 < SpecialEffectGrid.Rows.Count; ++index3) {
        if ((bool)SpecialEffectGrid.Rows[index3].Cells[0].EditedFormattedValue &&
            (string)SpecialEffectGrid.Rows[index3].Cells[4].Value != null) {
          string editedFormattedValue = (string)SpecialEffectGrid.Rows[index3].Cells[4].EditedFormattedValue;   
          str3 = str3 + (string)SpecialEffectGrid.Rows[index3].Cells[3].EditedFormattedValue + ":" + editedFormattedValue + ",";
        }
      }

      for (int index4 = 0; index4 < EnchantmentGrid.Rows.Count; ++index4) {
        if ((bool)EnchantmentGrid.Rows[index4].Cells[0].EditedFormattedValue &&
            (string)EnchantmentGrid.Rows[index4].Cells[3].Value != null) {
          string editedFormattedValue1 = EnchantmentGrid.Rows[index4].Cells[2].EditedFormattedValue.ToString();   
          string editedFormattedValue2 = EnchantmentGrid.Rows[index4].Cells[3].EditedFormattedValue.ToString();   
          str4 = str4 + "{id:" + editedFormattedValue1 + ",lvl:" + editedFormattedValue2 + "},";
        }
      }

      if (str4.Length > 0) { 
        str4 = str4.Substring(0, str4.Length - 1);
      }

      if (str3.Length > 0) { 
        str3 = str3.Substring(0, str3.Length - 1);
      }

      if (str13.Length == 0) { 
        str13 = "blade";
      }

      if (str2.Length == 0) { 
        str2 = str1;
      }

      if (!checkBox7.Checked) num5 = 0;
      if (!checkBox6.Checked) num6 = 0;
      if (!checkBox5.Checked) num7 = 0;
      if (!checkBox9.Checked) num8 = 0;
      if (!checkBox8.Checked) num9 = 0;
      if (!checkBox10.Checked) num10 = 0;
      int num12 = num5 + num6 + num7 + num8 + num9 + num10;
      string str16 = ",killCount:";
      string str17 = ",ProudSoul:";
      string str18 = ",RepairCounter:";
      string str19 = ",SpecialAttackType:";
      string str20 = ",SB.SEffect:{" + str3 + "}";
      string str21 = ",Item:";
      string str22 = "ench:[" + str4 + "],";
      string str23 = ",Lore:[\"" + text8 + "\"]";
      string str24 = ",baseAttackModifier:";
      string str25 = ",RepairCost:";
      string str26 = ",AttackAmplifier:";
      string str27 = ",CustomMaxDamage:";
      if (text1.Length == 0) str16 = "";
      if (text2.Length == 0) str17 = "";
      if (text3.Length == 0) str18 = "";
      if (str15.Length == 0) str19 = "";
      if (str3.Length == 0) str20 = "";
      if (str4.Length == 0) str22 = "";
      if (text8.Length == 0) str23 = "";
      if (text9.Length == 0) str21 = "";
      if (text4.Length == 0) str24 = "";
      if (text5.Length == 0) str25 = "";
      if (text6.Length == 0) str26 = "";
      if (text7.Length == 0) str27 = "";
      string str28 = !buttonCheck2.Checked ? SeparateSlot : AllSlot;
      CommandOutputBox.Text = "/give @p flammpfeil.slashblade:slashblade 1 0 {StandbyRenderType:" + str11 + ",isNoScabbard:" + str6 +                
                              ",isBroken:" + str7 + str16 + text1 + str17 + text2 + str18 + text3 + str24 + text4 + str25 + text5 + str26 + text6 + str27 + text7 +                
                              ",CurrentItemName:\"" + str12 + "\",ModelName:\"" + str13 + "\",TextureName:\"" + str14 + "\"" + str19 + str15 + str20 +                
                              ",SummonedSwordColor:" + num4 + ",isDefaultBewitched:" + str10 + ",IsBewitchedActived:" + str9 + str28 + str21 + text9 +
                              ",Unbreakable:" + str8 + ",display:{Name:\"" + str2 + "\"" + str23 + "}," + str22 + "HideFlags:" + num12 + "}";
    }
  }

  private static void InstructionsButtonClick(object sender, EventArgs e) => new Form3().Show();

  private void label77_Click(object sender, EventArgs e) {
    ColorDialog colorDialog = new ColorDialog();
    int scrollPos = GetScrollPos(Handle, 1);
    if (colorDialog.ShowDialog() == DialogResult.OK) {
      label77.BackColor = colorDialog.Color;
      VerticalScroll.Value = scrollPos;
    }

    VerticalScroll.Value = scrollPos;
  }

  private void SelectAllSeRadioButtonClick(object sender, EventArgs e) {
    if (SpecialEffectGrid.Rows.Count <= 0) {
      return;
    }

    SpecialEffectGrid.EndEdit();
    foreach (DataGridViewRow row in SpecialEffectGrid.Rows) {
      row.Cells[0].Value = true;
    }
  }

  private void SelectNoneSeRadioButtonClick(object sender, EventArgs e) {
    if (SpecialEffectGrid.Rows.Count <= 0) {
      return;
    }
    SpecialEffectGrid.EndEdit();
    foreach (DataGridViewRow row in SpecialEffectGrid.Rows) {
      row.Cells[0].Value = false;
    }
  }

  private void SelectInvertSeRadioButtonClick(object sender, EventArgs e) {
    if (SpecialEffectGrid.Rows.Count <= 0) {
      return;
    }

    SpecialEffectGrid.EndEdit();
    foreach (DataGridViewRow row in SpecialEffectGrid.Rows) {
      row.Cells[0].Value = !true.Equals(row.Cells[0].Value);
    }
  }

  private void SpecialEffectGridEditingControlShowing(object sender, 
    DataGridViewEditingControlShowingEventArgs e) {
    if (SpecialEffectGrid.CurrentCellAddress.X != 4) {
      return;
    }

    CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
    CellEdit.SelectAll();
    CellEdit.KeyPress += Cells_KeyPress;
  }

  private void Cells_KeyPress(object sender, KeyPressEventArgs e) {
    if (SpecialEffectGrid.CurrentCellAddress.X != 4) {
      return;
    }

    if (e.KeyChar < '0' || e.KeyChar > '9') {
      e.Handled = true;
    }

    if (e.KeyChar == '\b') {
      e.Handled = false;
    }
  }

  private void Cells_KeyPress2(object sender, KeyPressEventArgs e) {
    if (EnchantmentGrid.CurrentCellAddress.X != 3) {
      return;
    }

    if (e.KeyChar < '0' || e.KeyChar > '9') {
      e.Handled = true;
    }

    if (e.KeyChar == '\b') {
      e.Handled = false;
    }
  }

  private void timer1_Tick(object sender, EventArgs e) {
    for (int i = 1; i < SpecialEffectGrid.Rows.Count; ++i) {
      SpecialEffectGrid.Rows[i].Cells[4].ReadOnly = !(bool)SpecialEffectGrid.Rows[i].Cells[0].EditedFormattedValue;
    }

    for (int i = 0; i < EnchantmentGrid.Rows.Count; ++i) {
      EnchantmentGrid.Rows[i].Cells[3].ReadOnly = !(bool)EnchantmentGrid.Rows[i].Cells[0].EditedFormattedValue;
    }
  }

  private void EnchantmentGridEditingControlShowing(object sender, 
    DataGridViewEditingControlShowingEventArgs e) {
    if (EnchantmentGrid.CurrentCellAddress.X != 3) {
      return;
    }

    CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
    CellEdit.SelectAll();
    CellEdit.KeyPress += Cells_KeyPress2;
  }

  private void BatchEnchantButtonClick(object sender, EventArgs e) {
    if (textBox69.Text.Length <= 0) {
      return;
    }

    for (int i = 1; i < SpecialEffectGrid.Rows.Count; ++i) {
      SpecialEffectGrid.Rows[i].Cells[4].Value = textBox69.Text;
    }
  }

  private void timer2_Tick(object sender, EventArgs e) {
    switch (ModelGrid.CurrentRow.Cells[0].Value.ToString()) {
      case "31工-「紫龙息」": ModelPreviewPictureBox.Image = Resources._288; break;
      case "31工-「金巴」": ModelPreviewPictureBox.Image = Resources._289; break;
      case "HTOD的刀": ModelPreviewPictureBox.Image = Resources._202; break;
      case "XingKong的刀": ModelPreviewPictureBox.Image = Resources._203; break;
      case "til的刀": ModelPreviewPictureBox.Image = Resources._201; break;
      case "「V.V.V.V.V.」": ModelPreviewPictureBox.Image = Resources._112; break;
      case "「伊布之刃」": ModelPreviewPictureBox.Image = Resources._118; break;
      case "「击柝」露台": ModelPreviewPictureBox.Image = Resources._23; break;
      case "「剑圣之刃」伍": ModelPreviewPictureBox.Image = Resources._323; break;
      case "「剑圣之刃」叁": ModelPreviewPictureBox.Image = Resources._321; break;
      case "「剑圣之刃」壹": ModelPreviewPictureBox.Image = Resources._319; break;
      case "「剑圣之刃」拾": ModelPreviewPictureBox.Image = Resources._328; break;
      case "「剑圣之刃」拾叁": ModelPreviewPictureBox.Image = Resources._331; break;
      case "「剑圣之刃」拾壹": ModelPreviewPictureBox.Image = Resources._329; break;
      case "「剑圣之刃」拾贰": ModelPreviewPictureBox.Image = Resources._330; break;
      case "「剑圣之刃」捌": ModelPreviewPictureBox.Image = Resources._326; break;
      case "「剑圣之刃」柒": ModelPreviewPictureBox.Image = Resources._325; break;
      case "「剑圣之刃」玖": ModelPreviewPictureBox.Image = Resources._327; break;
      case "「剑圣之刃」肆": ModelPreviewPictureBox.Image = Resources._322; break;
      case "「剑圣之刃」贰": ModelPreviewPictureBox.Image = Resources._320; break;
      case "「剑圣之刃」陆": ModelPreviewPictureBox.Image = Resources._324; break;
      case "「千兆」": ModelPreviewPictureBox.Image = Resources._87; break;
      case "「千鹤」叁": ModelPreviewPictureBox.Image = Resources._337; break;
      case "「千鹤」壹": ModelPreviewPictureBox.Image = Resources._335; break;
      case "「千鹤」村正": ModelPreviewPictureBox.Image = Resources._7; break;
      case "「千鹤」村雨": ModelPreviewPictureBox.Image = Resources._41; break;
      case "「千鹤」肆": ModelPreviewPictureBox.Image = Resources._338; break;
      case "「千鹤」贰": ModelPreviewPictureBox.Image = Resources._336; break;
      case "「命刃」": ModelPreviewPictureBox.Image = Resources._342; break;
      case "「密陀僧」": ModelPreviewPictureBox.Image = Resources._158; break;
      case "「恶」": ModelPreviewPictureBox.Image = Resources._264; break;
      case "「暗鸦」伍": ModelPreviewPictureBox.Image = Resources._307; break;
      case "「暗鸦」叁": ModelPreviewPictureBox.Image = Resources._305; break;
      case "「暗鸦」壹": ModelPreviewPictureBox.Image = Resources._303; break;
      case "「暗鸦」柒": ModelPreviewPictureBox.Image = Resources._309; break;
      case "「暗鸦」肆": ModelPreviewPictureBox.Image = Resources._306; break;
      case "「暗鸦」贰": ModelPreviewPictureBox.Image = Resources._304; break;
      case "「暗鸦」陆": ModelPreviewPictureBox.Image = Resources._308; break;
      case "「暮雨」正宗": ModelPreviewPictureBox.Image = Resources._164; break;
      case "「村雨」叁": ModelPreviewPictureBox.Image = Resources._302; break;
      case "「村雨」壹": ModelPreviewPictureBox.Image = Resources._300; break;
      case "「村雨」贰": ModelPreviewPictureBox.Image = Resources._301; break;
      case "「梨木利亚」": ModelPreviewPictureBox.Image = Resources._109; break;
      case "「楼观剑」": ModelPreviewPictureBox.Image = Resources._89; break;
      case "「楼观旋风刃」": ModelPreviewPictureBox.Image = Resources._95; break;
      case "「樱剪」": ModelPreviewPictureBox.Image = Resources._99; break;
      case "「灭」": ModelPreviewPictureBox.Image = Resources._351; break;
      case "「狱」": ModelPreviewPictureBox.Image = Resources._265; break;
      case "「白刃」": ModelPreviewPictureBox.Image = Resources._340; break;
      case "「白楼剑」": ModelPreviewPictureBox.Image = Resources._90; break;
      case "「白楼旋风刃」": ModelPreviewPictureBox.Image = Resources._96; break;
      case "「祭钢刃」": ModelPreviewPictureBox.Image = Resources._113; break;
      case "「罗盘草」": ModelPreviewPictureBox.Image = Resources._163; break;
      case "「荧光」壹": ModelPreviewPictureBox.Image = Resources._313; break;
      case "「荧光」贰": ModelPreviewPictureBox.Image = Resources._314; break;
      case "「血纸竹光」": ModelPreviewPictureBox.Image = Resources._80; break;
      case "「要塞」神秘": ModelPreviewPictureBox.Image = Resources._128; break;
      case "「要塞」虚无": ModelPreviewPictureBox.Image = Resources._129; break;
      case "「要塞」血红": ModelPreviewPictureBox.Image = Resources._131; break;
      case "「要塞」风雷": ModelPreviewPictureBox.Image = Resources._130; break;
      case "「锐岩」露台": ModelPreviewPictureBox.Image = Resources._22; break;
      case "「镇魂曲」": ModelPreviewPictureBox.Image = Resources._77; break;
      case "「隐月 · 刃」": ModelPreviewPictureBox.Image = Resources._343; break;
      case "「隐者之竹光」": ModelPreviewPictureBox.Image = Resources._78; break;
      case "「风来之剑」": ModelPreviewPictureBox.Image = Resources._46; break;
      case "「风来之械刃」": ModelPreviewPictureBox.Image = Resources._47; break;
      case "「魔刀千刃」": ModelPreviewPictureBox.Image = Resources._149; break;
      case "「魔刃」": ModelPreviewPictureBox.Image = Resources._341; break;
      case "「鹿丸」": ModelPreviewPictureBox.Image = Resources._162; break;
      case "「黑刃」": ModelPreviewPictureBox.Image = Resources._339; break;
      case "「黑瞳」": ModelPreviewPictureBox.Image = Resources._355; break;
      case "一斥染「甚三红」": ModelPreviewPictureBox.Image = Resources._165; break;
      case "三雷拵": ModelPreviewPictureBox.Image = Resources._123; break;
      case "上品「银纸竹光」": ModelPreviewPictureBox.Image = Resources._79; break;
      case "不可视之刃「风之影」· 风": ModelPreviewPictureBox.Image = Resources._274; break;
      case "不死斩「拜泪」": ModelPreviewPictureBox.Image = Resources._81; break;
      case "伊恩「永恒时光之轮 · 永劫根源魔枪」": ModelPreviewPictureBox.Image = Resources._137; break;
      case "伪物「亡者」": ModelPreviewPictureBox.Image = Resources._76; break;
      case "伪物「白楼剑」": ModelPreviewPictureBox.Image = Resources._93; break;
      case "伪物「葵」": ModelPreviewPictureBox.Image = Resources._74; break;
      case "伪物「观楼剑」": ModelPreviewPictureBox.Image = Resources._94; break;
      case "侍月刀「炎水薄斩」": ModelPreviewPictureBox.Image = Resources._42; break;
      case "光剑「监视者」": ModelPreviewPictureBox.Image = Resources._275; break;
      case "八卦剑": ModelPreviewPictureBox.Image = Resources._180; break;
      case "冻樱刃「雪花苍月」": ModelPreviewPictureBox.Image = Resources._33; break;
      case "冻樱刃「雪花苍月」叁": ModelPreviewPictureBox.Image = Resources._312; break;
      case "冻樱刃「雪花苍月」壹": ModelPreviewPictureBox.Image = Resources._310; break;
      case "冻樱刃「雪花苍月」贰": ModelPreviewPictureBox.Image = Resources._311; break;
      case "刀": ModelPreviewPictureBox.Image = Resources._50; break;
      case "刚剑「胴田贯」": ModelPreviewPictureBox.Image = Resources._3; break;
      case "利刀「无名」红玉": ModelPreviewPictureBox.Image = Resources._24; break;
      case "利刀「白鞘「」": ModelPreviewPictureBox.Image = Resources._59; break;
      case "利刀「苍梅」": ModelPreviewPictureBox.Image = Resources._106; break;
      case "利刀「钢叶」露台": ModelPreviewPictureBox.Image = Resources._168; break;
      case "利刀「铁」露台": ModelPreviewPictureBox.Image = Resources._21; break;
      case "利刀「铁树」露台": ModelPreviewPictureBox.Image = Resources._169; break;
      case "利刀「铁骑」露台": ModelPreviewPictureBox.Image = Resources._170; break;
      case "勤忙": ModelPreviewPictureBox.Image = Resources._191; break;
      case "卡俄斯「溟濛万象」": ModelPreviewPictureBox.Image = Resources._372; break;
      case "厄瑞波斯「永黯沉寂」": ModelPreviewPictureBox.Image = Resources._138; break;
      case "原罪「傲慢」": ModelPreviewPictureBox.Image = Resources._252; break;
      case "原罪「嫉妒」": ModelPreviewPictureBox.Image = Resources._254; break;
      case "原罪「懒惰」": ModelPreviewPictureBox.Image = Resources._255; break;
      case "原罪「暴怒」": ModelPreviewPictureBox.Image = Resources._250; break;
      case "原罪「色欲」": ModelPreviewPictureBox.Image = Resources._256; break;
      case "原罪「贪婪」": ModelPreviewPictureBox.Image = Resources._251; break;
      case "原罪「贪食」": ModelPreviewPictureBox.Image = Resources._253; break;
      case "原罪神「利维坦」": ModelPreviewPictureBox.Image = Resources._261; break;
      case "原罪神「别西卜」": ModelPreviewPictureBox.Image = Resources._260; break;
      case "原罪神「玛门」": ModelPreviewPictureBox.Image = Resources._258; break;
      case "原罪神「萨迈尔」": ModelPreviewPictureBox.Image = Resources._257; break;
      case "原罪神「贝尔芬格」": ModelPreviewPictureBox.Image = Resources._262; break;
      case "原罪神「路西法」": ModelPreviewPictureBox.Image = Resources._259; break;
      case "原罪神「阿斯莫德」": ModelPreviewPictureBox.Image = Resources._263; break;
      case "名刀「亡者」": ModelPreviewPictureBox.Image = Resources._75; break;
      case "名刀「将军木」": ModelPreviewPictureBox.Image = Resources._105; break;
      case "名刀「揳丸」": ModelPreviewPictureBox.Image = Resources._82; break;
      case "名刀「斗刀」": ModelPreviewPictureBox.Image = Resources._116; break;
      case "名刀「物理学圣剑」": ModelPreviewPictureBox.Image = Resources._226; break;
      case "名刀「玻璃」露台": ModelPreviewPictureBox.Image = Resources._172; break;
      case "名刀「观楼剑」": ModelPreviewPictureBox.Image = Resources._88; break;
      case "名刀「金刚」露台": ModelPreviewPictureBox.Image = Resources._19; break;
      case "名刀「银纸竹光」": ModelPreviewPictureBox.Image = Resources._58; break;
      case "圣剑「银弹」": ModelPreviewPictureBox.Image = Resources._227; break;
      case "圣幸刀「绿乃雾」": ModelPreviewPictureBox.Image = Resources._43; break;
      case "型月刀「空之境界」": ModelPreviewPictureBox.Image = Resources._53; break;
      case "塔耳塔洛斯「狱渊之锁」": ModelPreviewPictureBox.Image = Resources._371; break;
      case "夜叉": ModelPreviewPictureBox.Image = Resources._16; break;
      case "夜叉 (伪)": ModelPreviewPictureBox.Image = Resources._15; break;
      case "夜空之剑「阐释者」": ModelPreviewPictureBox.Image = Resources._272; break;
      case "夜魔": ModelPreviewPictureBox.Image = Resources._218; break;
      case "大地之刃": ModelPreviewPictureBox.Image = Resources._52; break;
      case "大蛇鄂门": ModelPreviewPictureBox.Image = Resources._8; break;
      case "天云「寒齿」": ModelPreviewPictureBox.Image = Resources._108; break;
      case "天云「无念」": ModelPreviewPictureBox.Image = Resources._83; break;
      case "天云「残云」": ModelPreviewPictureBox.Image = Resources._84; break;
      case "天云「速风」": ModelPreviewPictureBox.Image = Resources._85; break;
      case "太刀": ModelPreviewPictureBox.Image = Resources._51; break;
      case "太刀「左伊多津万」": ModelPreviewPictureBox.Image = Resources._157; break;
      case "太刀「花绀青伽罗」独钴": ModelPreviewPictureBox.Image = Resources._166; break;
      case "奉神刀「鹿」": ModelPreviewPictureBox.Image = Resources._273; break;
      case "妖刀「似蛭」": ModelPreviewPictureBox.Image = Resources._26; break;
      case "妖刀「神狐」": ModelPreviewPictureBox.Image = Resources._144; break;
      case "妖刀「红樱」": ModelPreviewPictureBox.Image = Resources._25; break;
      case "宇宙最强之刃「万物终结 · 无尽星空」": ModelPreviewPictureBox.Image = Resources._413; break;
      case "宇界起源-「翱」": ModelPreviewPictureBox.Image = Resources._299; break;
      case "安托则斯「冥光万法」": ModelPreviewPictureBox.Image = Resources._373; break;
      case "宙雷大刀-「绿夜」": ModelPreviewPictureBox.Image = Resources._297; break;
      case "宝刀「山吹」露台": ModelPreviewPictureBox.Image = Resources._20; break;
      case "宝刀「霜冻」露台": ModelPreviewPictureBox.Image = Resources._171; break;
      case "宿命行星 · 阿南刻「天数裁定」": ModelPreviewPictureBox.Image = Resources._377; break;
      case "小太刀「」": ModelPreviewPictureBox.Image = Resources._156; break;
      case "小太刀「咲夜子」": ModelPreviewPictureBox.Image = Resources._154; break;
      case "小太刀「小金兔」": ModelPreviewPictureBox.Image = Resources._152; break;
      case "小太刀「小鸟丸」": ModelPreviewPictureBox.Image = Resources._153; break;
      case "小太刀「落华」": ModelPreviewPictureBox.Image = Resources._155; break;
      case "尼尔「永恒旋转之枪」": ModelPreviewPictureBox.Image = Resources._136; break;
      case "山樱「伪」": ModelPreviewPictureBox.Image = Resources._347; break;
      case "山樱「师走」": ModelPreviewPictureBox.Image = Resources._70; break;
      case "山樱「水无月」": ModelPreviewPictureBox.Image = Resources._66; break;
      case "山樱「神月」": ModelPreviewPictureBox.Image = Resources._71; break;
      case "山樱「葵」": ModelPreviewPictureBox.Image = Resources._60; break;
      case "山樱卯月": ModelPreviewPictureBox.Image = Resources._73; break;
      case "山樱叶月": ModelPreviewPictureBox.Image = Resources._62; break;
      case "山樱如月「梅」": ModelPreviewPictureBox.Image = Resources._72; break;
      case "山樱弥生「樱」": ModelPreviewPictureBox.Image = Resources._67; break;
      case "山樱文月": ModelPreviewPictureBox.Image = Resources._61; break;
      case "山樱皋月": ModelPreviewPictureBox.Image = Resources._68; break;
      case "山樱睦月「松」": ModelPreviewPictureBox.Image = Resources._63; break;
      case "山樱神无月「枫」": ModelPreviewPictureBox.Image = Resources._64; break;
      case "山樱长月「菊」": ModelPreviewPictureBox.Image = Resources._65; break;
      case "山樱霜月": ModelPreviewPictureBox.Image = Resources._69; break;
      case "工-「儊晓」": ModelPreviewPictureBox.Image = Resources._291; break;
      case "工-「古一眉」": ModelPreviewPictureBox.Image = Resources._292; break;
      case "工-「魔钢刃」": ModelPreviewPictureBox.Image = Resources._290; break;
      case "平庸「斗刀」": ModelPreviewPictureBox.Image = Resources._115; break;
      case "幻魔炼金拵": ModelPreviewPictureBox.Image = Resources._40; break;
      case "幽狂-「赤浴血」": ModelPreviewPictureBox.Image = Resources._295; break;
      case "异次元「管理者之刃」": ModelPreviewPictureBox.Image = Resources._412; break;
      case "异界剑魂「」": ModelPreviewPictureBox.Image = Resources._349; break;
      case "御神刀「神狐」": ModelPreviewPictureBox.Image = Resources._148; break;
      case "德雷格兰「圣契」": ModelPreviewPictureBox.Image = Resources._374; break;
      case "折断的阎魔刀": ModelPreviewPictureBox.Image = Resources._14; break;
      case "撼地巨锤": ModelPreviewPictureBox.Image = Resources._187; break;
      case "擒苍": ModelPreviewPictureBox.Image = Resources._189; break;
      case "散华": ModelPreviewPictureBox.Image = Resources._12; break;
      case "文始": ModelPreviewPictureBox.Image = Resources._86; break;
      case "斑鸠之刃": ModelPreviewPictureBox.Image = Resources._107; break;
      case "斗刀「孤独」": ModelPreviewPictureBox.Image = Resources._117; break;
      case "无神「无刃」": ModelPreviewPictureBox.Image = Resources._39; break;
      case "无铭「影狐」": ModelPreviewPictureBox.Image = Resources._111; break;
      case "无铭刀「木偶」": ModelPreviewPictureBox.Image = Resources._56; break;
      case "无铭刀「竹光」": ModelPreviewPictureBox.Image = Resources._57; break;
      case "无魂剑「」": ModelPreviewPictureBox.Image = Resources._220; break;
      case "日耀剑「光日」": ModelPreviewPictureBox.Image = Resources._114; break;
      case "时之镰": ModelPreviewPictureBox.Image = Resources._199; break;
      case "明兽刃「阳牙冰狼」": ModelPreviewPictureBox.Image = Resources._34; break;
      case "明兽刃「阳牙冰狼」叁": ModelPreviewPictureBox.Image = Resources._334; break;
      case "明兽刃「阳牙冰狼」壹": ModelPreviewPictureBox.Image = Resources._332; break;
      case "明兽刃「阳牙冰狼」贰": ModelPreviewPictureBox.Image = Resources._333; break;
      case "星云剑「雾鸦」": ModelPreviewPictureBox.Image = Resources._143; break;
      case "星云剑「雾鸦」1": ModelPreviewPictureBox.Image = Resources._232; break;
      case "星云剑「雾鸦」10": ModelPreviewPictureBox.Image = Resources._241; break;
      case "星云剑「雾鸦」11": ModelPreviewPictureBox.Image = Resources._242; break;
      case "星云剑「雾鸦」12": ModelPreviewPictureBox.Image = Resources._243; break;
      case "星云剑「雾鸦」13": ModelPreviewPictureBox.Image = Resources._244; break;
      case "星云剑「雾鸦」14": ModelPreviewPictureBox.Image = Resources._245; break;
      case "星云剑「雾鸦」15": ModelPreviewPictureBox.Image = Resources._246; break;
      case "星云剑「雾鸦」16": ModelPreviewPictureBox.Image = Resources._247; break;
      case "星云剑「雾鸦」17": ModelPreviewPictureBox.Image = Resources._248; break;
      case "星云剑「雾鸦」2": ModelPreviewPictureBox.Image = Resources._233; break;
      case "星云剑「雾鸦」3": ModelPreviewPictureBox.Image = Resources._234; break;
      case "星云剑「雾鸦」4": ModelPreviewPictureBox.Image = Resources._235; break;
      case "星云剑「雾鸦」5": ModelPreviewPictureBox.Image = Resources._236; break;
      case "星云剑「雾鸦」6": ModelPreviewPictureBox.Image = Resources._237; break;
      case "星云剑「雾鸦」7": ModelPreviewPictureBox.Image = Resources._238; break;
      case "星云剑「雾鸦」8": ModelPreviewPictureBox.Image = Resources._239; break;
      case "星云剑「雾鸦」9": ModelPreviewPictureBox.Image = Resources._240; break;
      case "星典": ModelPreviewPictureBox.Image = Resources._193; break;
      case "星流利刃": ModelPreviewPictureBox.Image = Resources._183; break;
      case "普洛托革诺伊「始源」": ModelPreviewPictureBox.Image = Resources._140; break;
      case "暗鸦": ModelPreviewPictureBox.Image = Resources._30; break;
      case "曙色斩月": ModelPreviewPictureBox.Image = Resources._160; break;
      case "月光樱「吹雪一闪」": ModelPreviewPictureBox.Image = Resources._44; break;
      case "月光紫「虚无之影」": ModelPreviewPictureBox.Image = Resources._206; break;
      case "木刀「铁刀木」": ModelPreviewPictureBox.Image = Resources._18; break;
      case "木鞘「「刃条」": ModelPreviewPictureBox.Image = Resources._147; break;
      case "木鞘「「神狐」": ModelPreviewPictureBox.Image = Resources._145; break;
      case "朴素拵": ModelPreviewPictureBox.Image = Resources._121; break;
      case "杀马人之刃": ModelPreviewPictureBox.Image = Resources._222; break;
      case "村锖丸": ModelPreviewPictureBox.Image = Resources._142; break;
      case "村雨丸": ModelPreviewPictureBox.Image = Resources._141; break;
      case "极寒刃「雪走」· 雪": ModelPreviewPictureBox.Image = Resources._284; break;
      case "枯石大刀": ModelPreviewPictureBox.Image = Resources._6; break;
      case "柮夭": ModelPreviewPictureBox.Image = Resources._188; break;
      case "柯罗诺斯「万古琨矇」": ModelPreviewPictureBox.Image = Resources._379; break;
      case "柯罗诺斯「始源之枪」": ModelPreviewPictureBox.Image = Resources._378; break;
      case "柯罗诺斯「永境之主」": ModelPreviewPictureBox.Image = Resources._139; break;
      case "棘羽「毕方」": ModelPreviewPictureBox.Image = Resources._414; break;
      case "森森幽罗「青鬼」": ModelPreviewPictureBox.Image = Resources._282; break;
      case "次元之刃「伪」": ModelPreviewPictureBox.Image = Resources._346; break;
      case "欺骗者「影月」· 月": ModelPreviewPictureBox.Image = Resources._285; break;
      case "死神「幽之名」": ModelPreviewPictureBox.Image = Resources._286; break;
      case "水波折": ModelPreviewPictureBox.Image = Resources._176; break;
      case "洞爷湖": ModelPreviewPictureBox.Image = Resources._45; break;
      case "洞虚幻刃": ModelPreviewPictureBox.Image = Resources._184; break;
      case "海格力斯「闪耀之星」": ModelPreviewPictureBox.Image = Resources._135; break;
      case "渝州「长清」": ModelPreviewPictureBox.Image = Resources._110; break;
      case "激光剑1": ModelPreviewPictureBox.Image = Resources._194; break;
      case "激光剑2": ModelPreviewPictureBox.Image = Resources._195; break;
      case "激光剑3": ModelPreviewPictureBox.Image = Resources._196; break;
      case "灵钢刃「技术革新」": ModelPreviewPictureBox.Image = Resources._209; break;
      case "灵钢刃「能量守恒」": ModelPreviewPictureBox.Image = Resources._210; break;
      case "灾厄之源「劫」": ModelPreviewPictureBox.Image = Resources._278; break;
      case "炎刀「炽铁」露台": ModelPreviewPictureBox.Image = Resources._167; break;
      case "炎极必寒「极意」": ModelPreviewPictureBox.Image = Resources._279; break;
      case "炎王-「火红莲」": ModelPreviewPictureBox.Image = Resources._296; break;
      case "炎王「流刃若火」": ModelPreviewPictureBox.Image = Resources._280; break;
      case "炼狱刀「死念」": ModelPreviewPictureBox.Image = Resources._27; break;
      case "炼狱刀「真红」": ModelPreviewPictureBox.Image = Resources._151; break;
      case "炼狱刀「血腥」": ModelPreviewPictureBox.Image = Resources._267; break;
      case "狐月刀「白狐」": ModelPreviewPictureBox.Image = Resources._5; break;
      case "狐月刀「黑狐」": ModelPreviewPictureBox.Image = Resources._4; break;
      case "狗年专属「啸月」": ModelPreviewPictureBox.Image = Resources._283; break;
      case "狱刀「似蛭」": ModelPreviewPictureBox.Image = Resources._29; break;
      case "狱刀「死念」赝": ModelPreviewPictureBox.Image = Resources._150; break;
      case "狱刀「死念」赝 ": ModelPreviewPictureBox.Image = Resources._266; break;
      case "狱界剑「楼观剑」": ModelPreviewPictureBox.Image = Resources._91; break;
      case "狱界剑「白楼剑」": ModelPreviewPictureBox.Image = Resources._92; break;
      case "现世刀「斩月」": ModelPreviewPictureBox.Image = Resources._231; break;
      case "生机「绿萝」": ModelPreviewPictureBox.Image = Resources._281; break;
      case "白「天锁斩月」": ModelPreviewPictureBox.Image = Resources._287; break;
      case "白の契约": ModelPreviewPictureBox.Image = Resources._269; break;
      case "白の约定": ModelPreviewPictureBox.Image = Resources._271; break;
      case "白兰剑「君」": ModelPreviewPictureBox.Image = Resources._268; break;
      case "白刃": ModelPreviewPictureBox.Image = Resources._204; break;
      case "百兽剑王「巨狮」": ModelPreviewPictureBox.Image = Resources._270; break;
      case "石剑「」": ModelPreviewPictureBox.Image = Resources._354; break;
      case "神威刀「乌卡」": ModelPreviewPictureBox.Image = Resources._38; break;
      case "神威刀「坎那」": ModelPreviewPictureBox.Image = Resources._37; break;
      case "神威刀「虎杖丸」": ModelPreviewPictureBox.Image = Resources._35; break;
      case "神威刀「阿贝」": ModelPreviewPictureBox.Image = Resources._36; break;
      case "神秘要塞日本刀": ModelPreviewPictureBox.Image = Resources._124; break;
      case "神钢刃「工艺复兴」": ModelPreviewPictureBox.Image = Resources._208; break;
      case "神钢刃「血腥革新」": ModelPreviewPictureBox.Image = Resources._207; break;
      case "神陨剑": ModelPreviewPictureBox.Image = Resources._198; break;
      case "管理员之刃「伪物」": ModelPreviewPictureBox.Image = Resources._225; break;
      case "紫刃「虚」": ModelPreviewPictureBox.Image = Resources._345; break;
      case "纳米太刀": ModelPreviewPictureBox.Image = Resources._97; break;
      case "结月刀「付丧」": ModelPreviewPictureBox.Image = Resources._17; break;
      case "结月刀「付丧」叁": ModelPreviewPictureBox.Image = Resources._317; break;
      case "结月刀「付丧」壹": ModelPreviewPictureBox.Image = Resources._315; break;
      case "结月刀「付丧」肆": ModelPreviewPictureBox.Image = Resources._318; break;
      case "结月刀「付丧」贰": ModelPreviewPictureBox.Image = Resources._316; break;
      case "结月刀「因缘」": ModelPreviewPictureBox.Image = Resources._54; break;
      case "美工刀": ModelPreviewPictureBox.Image = Resources._174; break;
      case "聚变之星 · 倪克斯「辰宿瞬变」": ModelPreviewPictureBox.Image = Resources._376; break;
      case "自定义": ModelPreviewPictureBox.Image = Resources._0; break;
      case "自锻刀「神秘」": ModelPreviewPictureBox.Image = Resources._119; break;
      case "自锻刀「红钢」": ModelPreviewPictureBox.Image = Resources._132; break;
      case "自锻刀「蓝钢」": ModelPreviewPictureBox.Image = Resources._133; break;
      case "自锻刀「虚空」": ModelPreviewPictureBox.Image = Resources._120; break;
      case "花之妖精「弥葵」· 花": ModelPreviewPictureBox.Image = Resources._276; break;
      case "花天狂骨「花天」": ModelPreviewPictureBox.Image = Resources._277; break;
      case "荆棘之刃「虚」": ModelPreviewPictureBox.Image = Resources._348; break;
      case "荧光": ModelPreviewPictureBox.Image = Resources._32; break;
      case "落樱何思": ModelPreviewPictureBox.Image = Resources._161; break;
      case "落英拵": ModelPreviewPictureBox.Image = Resources._122; break;
      case "虚无之刃「」": ModelPreviewPictureBox.Image = Resources._350; break;
      case "虚空要塞日本刀": ModelPreviewPictureBox.Image = Resources._125; break;
      case "血刀「似蛭」": ModelPreviewPictureBox.Image = Resources._28; break;
      case "血刃「栗山未来」": ModelPreviewPictureBox.Image = Resources._205; break;
      case "血月": ModelPreviewPictureBox.Image = Resources._192; break;
      case "血腥要塞日本刀": ModelPreviewPictureBox.Image = Resources._127; break;
      case "血色木偶": ModelPreviewPictureBox.Image = Resources._173; break;
      case "质太刀-「舞纵」": ModelPreviewPictureBox.Image = Resources._298; break;
      case "轩辕剑": ModelPreviewPictureBox.Image = Resources._178; break;
      case "逐焰": ModelPreviewPictureBox.Image = Resources._190; break;
      case "邪魔刃「修罗」": ModelPreviewPictureBox.Image = Resources._104; break;
      case "邪魔刃「双」": ModelPreviewPictureBox.Image = Resources._103; break;
      case "鄂门": ModelPreviewPictureBox.Image = Resources._10; break;
      case "鄂门 ": ModelPreviewPictureBox.Image = Resources._1; break;
      case "鄂门 (锈)": ModelPreviewPictureBox.Image = Resources._9; break;
      case "鄂门 (锈) ": ModelPreviewPictureBox.Image = Resources._2; break;
      case "量子太刀": ModelPreviewPictureBox.Image = Resources._98; break;
      case "钢刃「源初」": ModelPreviewPictureBox.Image = Resources._211; break;
      case "钢刃「纳米科技」": ModelPreviewPictureBox.Image = Resources._212; break;
      case "钻石剑「」": ModelPreviewPictureBox.Image = Resources._352; break;
      case "铁剑「」": ModelPreviewPictureBox.Image = Resources._353; break;
      case "铭刀「悭臾」": ModelPreviewPictureBox.Image = Resources._229; break;
      case "铭刀「蟾宫」": ModelPreviewPictureBox.Image = Resources._230; break;
      case "铭刀「鱼音」": ModelPreviewPictureBox.Image = Resources._228; break;
      case "银灰": ModelPreviewPictureBox.Image = Resources._219; break;
      case "锁狱镰": ModelPreviewPictureBox.Image = Resources._185; break;
      case "锁魂": ModelPreviewPictureBox.Image = Resources._197; break;
      case "锈刀": ModelPreviewPictureBox.Image = Resources._11; break;
      case "锈迹斑斑的刀": ModelPreviewPictureBox.Image = Resources._146; break;
      case "长空落日": ModelPreviewPictureBox.Image = Resources._200; break;
      case "阳": ModelPreviewPictureBox.Image = Resources._182; break;
      case "阴": ModelPreviewPictureBox.Image = Resources._181; break;
      case "阿尔忒弥斯「影月」": ModelPreviewPictureBox.Image = Resources._134; break;
      case "阿尔忒弥斯「耀月」": ModelPreviewPictureBox.Image = Resources._375; break;
      case "陨星杖": ModelPreviewPictureBox.Image = Resources._177; break;
      case "雪鸦": ModelPreviewPictureBox.Image = Resources._31; break;
      case "青云": ModelPreviewPictureBox.Image = Resources._175; break;
      case "静秘守卫": ModelPreviewPictureBox.Image = Resources._186; break;
      case "风雷要塞日本刀": ModelPreviewPictureBox.Image = Resources._126; break;
      case "驱魔刃「杏」": ModelPreviewPictureBox.Image = Resources._101; break;
      case "驱魔刃「樱」": ModelPreviewPictureBox.Image = Resources._100; break;
      case "驱魔刃「雪影」": ModelPreviewPictureBox.Image = Resources._102; break;
      case "魔剑「阎魔刀」": ModelPreviewPictureBox.Image = Resources._13; break;
      case "黑刃": ModelPreviewPictureBox.Image = Resources._179; break;
      case "黑快刀-「帝心」": ModelPreviewPictureBox.Image = Resources._293; break;
      case "黑快刀-「银刃」": ModelPreviewPictureBox.Image = Resources._294; break;
      case "龙刃「猩红」": ModelPreviewPictureBox.Image = Resources._344; break;
      case "龙剑「行草俱利伽罗刻」": ModelPreviewPictureBox.Image = Resources._159; break;
      case "龙太刀「噬风者」": ModelPreviewPictureBox.Image = Resources._48; break;
      case "龙太刀「西风」": ModelPreviewPictureBox.Image = Resources._49; break;
      default: ModelPreviewPictureBox.Image = Resources.nameless; break;
    }
  }

  private void timer3_Tick(object sender, EventArgs e) {
    textBox21.Text = trackBar1.Value.ToString();
    textBox20.Text = trackBar2.Value.ToString();
    textBox19.Text = trackBar4.Value.ToString();
    textBox18.Text = trackBar3.Value.ToString();
    textBox17.Text = (trackBar8.Value / 10).ToString();
    textBox16.Text = trackBar7.Value.ToString();
    textBox15.Text = trackBar6.Value.ToString();
    textBox22.Text = trackBar5.Value.ToString();
    if (buttonCheck2.Checked) return;
    textBox32.Text = trackBar16.Value.ToString();
    textBox31.Text = trackBar15.Value.ToString();
    textBox30.Text = trackBar14.Value.ToString();
    textBox29.Text = trackBar13.Value.ToString();
    textBox28.Text = (trackBar12.Value / 10).ToString();
    textBox27.Text = trackBar11.Value.ToString();
    textBox26.Text = trackBar10.Value.ToString();
    textBox24.Text = trackBar9.Value.ToString();
    textBox41.Text = trackBar24.Value.ToString();
    textBox40.Text = trackBar23.Value.ToString();
    textBox39.Text = trackBar22.Value.ToString();
    textBox38.Text = trackBar21.Value.ToString();
    textBox37.Text = (trackBar20.Value / 10).ToString();
    textBox36.Text = trackBar19.Value.ToString();
    textBox35.Text = trackBar18.Value.ToString();
    textBox33.Text = trackBar17.Value.ToString();
    textBox50.Text = trackBar32.Value.ToString();
    textBox49.Text = trackBar31.Value.ToString();
    textBox48.Text = trackBar30.Value.ToString();
    textBox47.Text = trackBar29.Value.ToString();
    textBox46.Text = (trackBar28.Value / 10).ToString();
    textBox45.Text = trackBar27.Value.ToString();
    textBox44.Text = trackBar26.Value.ToString();
    textBox42.Text = trackBar25.Value.ToString();
    textBox59.Text = trackBar40.Value.ToString();
    textBox58.Text = trackBar39.Value.ToString();
    textBox57.Text = trackBar38.Value.ToString();
    textBox56.Text = trackBar37.Value.ToString();
    textBox55.Text = (trackBar36.Value / 10).ToString();
    textBox54.Text = trackBar35.Value.ToString();
    textBox53.Text = trackBar34.Value.ToString();
    textBox51.Text = trackBar33.Value.ToString();
    textBox68.Text = trackBar48.Value.ToString();
    textBox67.Text = trackBar47.Value.ToString();
    textBox66.Text = trackBar46.Value.ToString();
    textBox65.Text = trackBar45.Value.ToString();
    textBox64.Text = (trackBar44.Value / 10).ToString();
    textBox63.Text = trackBar43.Value.ToString();
    textBox62.Text = trackBar42.Value.ToString();
    textBox60.Text = trackBar41.Value.ToString();
  }

  private void SelectAllEnchantmentRadioButtonClick(object sender, EventArgs e) {
    if (EnchantmentGrid.Rows.Count <= 0) {
      return;
    }

    EnchantmentGrid.EndEdit();
    foreach (DataGridViewRow row in EnchantmentGrid.Rows) {
      row.Cells[0].Value = true;
    }
  }

  private void SelectNoneEnchantmentRadioButtonClick(object sender, EventArgs e) {
    if (EnchantmentGrid.Rows.Count <= 0) {
      return;
    }

    EnchantmentGrid.EndEdit();
    foreach (DataGridViewRow row in EnchantmentGrid.Rows) {
      row.Cells[0].Value = false;
    }
  }

  private void BatchSpecialEffectButtonClick(object sender, EventArgs e) {
    if (textBox23.Text.Length <= 0) {
      return;
    }

    for (int i = 1; i < EnchantmentGrid.Rows.Count; ++i) {
      EnchantmentGrid.Rows[i].Cells[3].Value = textBox23.Text;
    }
  }

}
  