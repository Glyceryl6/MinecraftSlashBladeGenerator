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
      AllArmorGroupBox.Text = buttonCheck2.Checked ? "装备位置: 所有" : "装备位置: 头盔";
      ChestPlateGroupBox.Enabled = !buttonCheck2.Checked;
      BootsGroupBox.Enabled = !buttonCheck2.Checked;
      LeggingsGroupBox.Enabled = !buttonCheck2.Checked;
      OffHandGroupBox.Enabled = !buttonCheck2.Checked;
      MainHandGroupBox.Enabled = !buttonCheck2.Checked;
  }

  private void SetSlot() {
    string str1 = ",AttributeName:";
    string str2 = "{Operation:0,Amount:";
    AllSlot = ",AttributeModifiers:[" + 
              str2 + textBox21.Text + str1 + "\"generic.attackDamage\",Name:\"attackDamage\"}," +       
              str2 + textBox20.Text + str1 + "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + 
              str2 + textBox19.Text + str1 + "\"generic.maxHealth\",Name:\"maxHealth\"}," + 
              str2 + textBox18.Text + str1 + "\"generic.movementSpeed\",Name:\"movementSpeed\"}," +       
              str2 + textBox17.Text + str1 + "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + 
              str2 + textBox16.Text + str1 + "\"generic.armor\",Name:\"armor\"}," + 
              str2 + textBox15.Text + str1 + "\"generic.armorToughness\",Name:\"armorToughness\"}," + 
              str2 + textBox22.Text + str1 + "\"generic.luck\",Name:\"luck\"}]";
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
    int canPlaceOnFlag = checkBox8.Checked ? 16 : 0;
    int othersFlag = checkBox10.Checked ? 32 : 0;
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
      for (int i = 1; i < SeGridView.Rows.Count; ++i) {
        if ((bool)SeGridView.Rows[i].Cells[0].EditedFormattedValue &&
            (string)SeGridView.Rows[i].Cells[4].Value != null) {
          string editedFormattedValue = (string)SeGridView.Rows[i].Cells[4].EditedFormattedValue;   
          str3 = str3 + (string)SeGridView.Rows[i].Cells[3].EditedFormattedValue + ":" + editedFormattedValue + ",";
        }
      }

      for (int i = 0; i < EnchantmentGrid.Rows.Count; ++i) {
        if ((bool)EnchantmentGrid.Rows[i].Cells[0].EditedFormattedValue &&
            (string)EnchantmentGrid.Rows[i].Cells[3].Value != null) {
          string editedFormattedValue1 = EnchantmentGrid.Rows[i].Cells[2].EditedFormattedValue.ToString();   
          string editedFormattedValue2 = EnchantmentGrid.Rows[i].Cells[3].EditedFormattedValue.ToString();   
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
      int flags = enchantmentsFlag + attributesFlag + unbreakableFlag + canDestroyFlag + canPlaceOnFlag + othersFlag;
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

  private void BasicGridViewRowClickTick(object sender, EventArgs e) {
    if (BasicGridView.CurrentRow != null) {
      Image errorImage = ModelPreviewPictureBox.ErrorImage;
      string name = BasicGridView.CurrentRow.Cells[0].Value.ToString();
      string path = Environment.CurrentDirectory + "/images/" + name + ".png";
      ModelPreviewPictureBox.Image = File.Exists(path) ? Image.FromFile(path) : errorImage;
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