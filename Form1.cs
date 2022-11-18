using MinecraftSlashBladeGenerator.Properties;

using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Collections.Generic;
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
    EnchantmentGrid.Rows.Add(30);
    AddInfo(BasicGridView, "blade_list.csv");
    AddInfo(SaGridView, "blade_sa.csv");
    AddSpecialEffectInfo();
    AddEnchantmentName();
  }
  
  private static int ReadFileLines(string path) {
    int lines = 0;
    FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
    StreamReader sr = new StreamReader(fs);
    while (sr.ReadLine() != null) {
      lines++;
    }

    fs.Close();
    sr.Close();
    return lines;
  }

  private void AddInfo(DataGridView dataGridView, string path) {
    string csvPath = Environment.CurrentDirectory + "/list/" + path;
    if (File.Exists(csvPath)) {
      string[] csvLineList = File.ReadAllLines(csvPath, Encoding.Default);
      dataGridView.Rows.Add(ReadFileLines(csvPath));
      for (int i = 0; i < ReadFileLines(csvPath); i++) {
        string s = csvLineList[i];
        Color iColor = Color.Black;
        List<string> list = new List<string>(s.Split(','));
        dataGridView.Rows[i].Cells[0].Value = list[0];
        dataGridView.Rows[i].Cells[1].Value = list[1];
        if (dataGridView == SaGridView) {
          SaGridView.Rows[i].Cells[2].Value = list[3];
        } else if (dataGridView == BasicGridView) {
          BasicGridView.Rows[i].Cells[2].Value = list[3];
          BasicGridView.Rows[i].Cells[3].Value = list[4];
          BasicGridView.Rows[i].Cells[4].Value = list[5];
        }
        switch (list[2]) {
          case "red" : iColor = Color.Red; break;
          case "navy" : iColor = Color.Navy; break;
          case "purple" : iColor = Color.Purple; break;
        }
        dataGridView.Rows[i].Cells[1].Style.ForeColor = iColor;
      }
    }
  }

  private void AddSpecialEffectInfo() {
    string csvPath = Environment.CurrentDirectory + "/list/blade_se.csv";
    if (File.Exists(csvPath)) {
      string[] csvLineList = File.ReadAllLines(csvPath, Encoding.Default);
      SeGridView.Rows.Add(ReadFileLines(csvPath));
      for (int i = 0; i < ReadFileLines(csvPath); i++) {
        string s = csvLineList[i];
        List<string> list = new List<string>(s.Split(','));
        SeGridView.Rows[i].Cells[1].Value = list[0];
        SeGridView.Rows[i].Cells[2].Value = list[1];
        SeGridView.Rows[i].Cells[3].Value = list[2];
      }
    }
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
    Color backColor = label77.BackColor;
    int enchantmentsFlag = checkBox7.Checked ? 1 : 0;
    int attributesFlag = checkBox6.Checked ? 2 : 0;
    int unbreakableFlag = checkBox5.Checked ? 4 : 0;
    int canDestroyFlag = checkBox9.Checked ? 8 : 0;
    int canPlaceOn = checkBox8.Checked ? 16 : 0;
    int others = checkBox10.Checked ? 32 : 0;
    int rgb = backColor.R * 65536 + backColor.G * 256 + backColor.B;
    string str1 = BasicGridView.CurrentRow.Cells[0].Value.ToString();
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
    string str6 = !checkBox1.Checked ? "1b" : "0b";
    string str7 = !checkBox2.Checked ? "0b" : "1b";
    string str8 = !checkBox4.Checked ? "0b" : "1b";
    string str9 = !checkBox11.Checked ? "0b" : "1b";
    string str10 = !checkBox12.Checked ? "0b" : "1b";
    string str11 = !radioButton1.Checked ? (!radioButton2.Checked ? (!radioButton3.Checked ? "4" : "3") : "2") : "1";
    SetSlot();
    string currentItemName = BasicGridView.CurrentRow.Cells[2].Value.ToString();
    string modelName = BasicGridView.CurrentRow.Cells[3].Value.ToString();
    string textureName = BasicGridView.CurrentRow.Cells[4].Value.ToString();

    if (currentItemName == "") {
      MessageBox.Show("模型未选择或该模型无效，请选择一个合适的模型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    } else {
      string str15 = SaGridView.CurrentRow.Cells[2].Value.ToString();
      for (int index3 = 1; index3 < SeGridView.Rows.Count; ++index3) {
        if ((bool)SeGridView.Rows[index3].Cells[0].EditedFormattedValue &&
            (string)SeGridView.Rows[index3].Cells[4].Value != null) {
          string editedFormattedValue = (string)SeGridView.Rows[index3].Cells[4].EditedFormattedValue;   
          str3 = str3 + (string)SeGridView.Rows[index3].Cells[3].EditedFormattedValue + ":" + editedFormattedValue + ",";
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

      if (modelName.Length == 0) { 
        modelName = "blade";
      }

      if (str2.Length == 0) { 
        str2 = str1;
      }

      int flags = enchantmentsFlag + attributesFlag + unbreakableFlag + canDestroyFlag + canPlaceOn + others;
      string str16 = text1.Length > 0 ? ",killCount:" : "";
      string str17 = text2.Length > 0 ? ",ProudSoul:" : "";
      string str18 = text3.Length > 0 ? ",RepairCounter:" : "";
      string str19 = str15.Length > 0 ? ",SpecialAttackType:" : "";
      string str20 = str3.Length > 0 ? ",SB.SEffect:{" + str3 + "}" : "";
      string str21 = text9.Length > 0 ? ",Item:" : "";
      string str22 = str4.Length > 0 ? "ench:[" + str4 + "]," : "";
      string str23 = text8.Length > 0 ? ",Lore:[\"" + text8 + "\"]" : "";
      string str24 = text4.Length > 0 ? ",baseAttackModifier:" : "";
      string str25 = text5.Length > 0 ? ",RepairCost:" : "";
      string str26 = text6.Length > 0 ? ",AttackAmplifier:" : "";
      string str27 = text7.Length > 0 ? ",CustomMaxDamage:" : "";
      string str28 = !buttonCheck2.Checked ? SeparateSlot : AllSlot;
      CommandOutputBox.Text = "/give @p flammpfeil.slashblade:slashblade 1 0 {StandbyRenderType:" + str11 + ",isNoScabbard:" + str6 +                
                              ",isBroken:" + str7 + str16 + text1 + str17 + text2 + str18 + text3 + str24 + text4 + str25 + text5 + str26 + text6 + str27 + text7 +                
                              ",CurrentItemName:\"" + currentItemName + "\",ModelName:\"" + modelName + "\",TextureName:\"" + textureName + "\"" + str19 + str15 + str20 +                
                              ",SummonedSwordColor:" + rgb + ",isDefaultBewitched:" + str10 + ",IsBewitchedActived:" + str9 + str28 + str21 + text9 +
                              ",Unbreakable:" + str8 + ",display:{Name:\"" + str2 + "\"" + str23 + "}," + str22 + "HideFlags:" + flags + "}";
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
    if (SeGridView.Rows.Count <= 0) {
      return;
    }

    SeGridView.EndEdit();
    foreach (DataGridViewRow row in SeGridView.Rows) {
      row.Cells[0].Value = true;
    }
  }

  private void SelectNoneSeRadioButtonClick(object sender, EventArgs e) {
    if (SeGridView.Rows.Count <= 0) {
      return;
    }
    SeGridView.EndEdit();
    foreach (DataGridViewRow row in SeGridView.Rows) {
      row.Cells[0].Value = false;
    }
  }

  private void SelectInvertSeRadioButtonClick(object sender, EventArgs e) {
    if (SeGridView.Rows.Count <= 0) {
      return;
    }

    SeGridView.EndEdit();
    foreach (DataGridViewRow row in SeGridView.Rows) {
      row.Cells[0].Value = !true.Equals(row.Cells[0].Value);
    }
  }

  private void SeGridViewEditingControlShowing(object sender, 
    DataGridViewEditingControlShowingEventArgs e) {
    if (SeGridView.CurrentCellAddress.X != 4) {
      return;
    }

    CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
    CellEdit.SelectAll();
    CellEdit.KeyPress += Cells_KeyPress;
  }

  private void Cells_KeyPress(object sender, KeyPressEventArgs e) {
    if (SeGridView.CurrentCellAddress.X != 4) {
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
    for (int i = 1; i < SeGridView.Rows.Count; ++i) {
      SeGridView.Rows[i].Cells[4].ReadOnly = !(bool)SeGridView.Rows[i].Cells[0].EditedFormattedValue;
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

    for (int i = 1; i < SeGridView.Rows.Count; ++i) {
      SeGridView.Rows[i].Cells[4].Value = textBox69.Text;
    }
  }

  private void timer2_Tick(object sender, EventArgs e) {
    switch (BasicGridView.CurrentRow.Cells[0].Value.ToString()) {
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
  