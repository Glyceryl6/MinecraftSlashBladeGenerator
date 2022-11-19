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
  private static extern int GetScrollPos(IntPtr handler, int nBar);

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
    AddInfo(BasicGridView, "blade_list.csv");
    AddInfo(SaGridView, "blade_sa.csv");
    AddInfo2(SeGridView, "blade_se.csv");
    AddInfo2(EnchantmentGrid, "enchantments.csv");
    AutoScroll = true;
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

  private void AddInfo2(DataGridView dataGridView, string path) {
    string csvPath = Environment.CurrentDirectory + "/list/" + path;
    if (File.Exists(csvPath)) {
      string[] csvLineList = File.ReadAllLines(csvPath, Encoding.Default);
      dataGridView.Rows.Add(ReadFileLines(csvPath));
      for (int i = 0; i < ReadFileLines(csvPath); i++) {
        List<string> list = new List<string>(csvLineList[i].Split(','));
        dataGridView.Rows[i].Cells[1].Value = list[0];
        dataGridView.Rows[i].Cells[2].Value = list[1];
        dataGridView.Rows[i].Cells[3].Value = list[2];
      }
    }
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
              str2 + AttackDamageBox.Text + str1 + "\"generic.attackDamage\",Name:\"attackDamage\"}," +       
              str2 + AttackSpeedBox.Text + str1 + "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + 
              str2 + MaxHealthBox.Text + str1 + "\"generic.maxHealth\",Name:\"maxHealth\"}," + 
              str2 + MovementSpeedBox.Text + str1 + "\"generic.movementSpeed\",Name:\"movementSpeed\"}," +       
              str2 + KnockbackResistanceBox.Text + str1 + "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + 
              str2 + ArmorBox.Text + str1 + "\"generic.armor\",Name:\"armor\"}," + 
              str2 + ArmorToughnessBox.Text + str1 + "\"generic.armorToughness\",Name:\"armorToughness\"}," + 
              str2 + LuckBox.Text + str1 + "\"generic.luck\",Name:\"luck\"}]";
    SeparateSlot = ",AttributeModifiers:[" + str2 + AttackDamageBox.Text + ",Slot:head" + str1 +            
                   "\"generic.attackDamage\",Name:\"attackDamage\"}," + str2 + AttackSpeedBox.Text + ",Slot:head" + str1 + 
                   "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + str2 + MaxHealthBox.Text + ",Slot:head" + str1 + 
                   "\"generic.maxHealth\",Name:\"maxHealth\"}," + str2 + MovementSpeedBox.Text + ",Slot:head" + str1 +            
                   "\"generic.movementSpeed\",Name:\"movementSpeed\"}," + str2 + KnockbackResistanceBox.Text + ",Slot:head" + str1 +
                   "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + str2 + ArmorBox.Text + ",Slot:head" + str1 +            
                   "\"generic.armor\",Name:\"armor\"}," + str2 + ArmorToughnessBox.Text + ",Slot:head" + str1 +            
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + LuckBox.Text + ",Slot:head" + str1 +
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
                   "\"generic.armorToughness\",Name:\"armorToughness\"}," + str2 + textBox60.Text + ",Slot:offhand" + str1 + 
                   "\"generic.luck\",Name:\"luck\"}]";
  }

  private void CommandOutputButtonClick(object sender, EventArgs e) {
    Color backColor = ColorLabel.BackColor;
    int enchantmentsFlag = checkBox7.Checked ? 1 : 0;
    int attributesFlag = checkBox6.Checked ? 2 : 0;
    int unbreakableFlag = checkBox5.Checked ? 4 : 0;
    int canDestroyFlag = checkBox9.Checked ? 8 : 0;
    int canPlaceOnFlag = checkBox8.Checked ? 16 : 0;
    int othersFlag = checkBox10.Checked ? 32 : 0;
    int rgb = backColor.R * 65536 + backColor.G * 256 + backColor.B;
    string killCount = textBox2.Text;
    string proudSoul = textBox3.Text;
    string repairCounter = textBox4.Text;
    string baseAttackModifier = textBox5.Text;
    string repairCost = textBox4.Text;
    string attackAmplifier = textBox7.Text;
    string customMaxDamage = textBox8.Text;
    string name = textBox12.Text;
    string item = textBox14.Text;
    string isNoScabbard = !checkBox1.Checked ? "1b" : "0b";
    string isBroken = !checkBox2.Checked ? "0b" : "1b";
    string unbreakable = !checkBox4.Checked ? "0b" : "1b";
    string active = !checkBox11.Checked ? "0b" : "1b";
    string bewitched = !checkBox12.Checked ? "0b" : "1b";
    string standbyRenderType = !radioButton1.Checked ? 
      (!radioButton2.Checked ? (!radioButton3.Checked ? "4" : "3") : "2") : "1";
    string currentItemName = BasicGridView.CurrentRow != null ? BasicGridView.CurrentRow.Cells[2].Value.ToString() : "";
    string modelName = BasicGridView.CurrentRow != null ? BasicGridView.CurrentRow.Cells[3].Value.ToString() : "";
    string textureName = BasicGridView.CurrentRow != null ? BasicGridView.CurrentRow.Cells[4].Value.ToString() : "";
    string specialAttack = SaGridView.CurrentRow != null ? SaGridView.CurrentRow.Cells[2].Value.ToString() : "";
    string specialEffect = "";
    string enchantments = "";
    SetSlot();

    if (currentItemName == "") {
      MessageBox.Show("模型未选择或该模型无效，请选择一个有效的模型！", "错误", MessageBoxButtons.OK, MessageBoxIcon.Hand);
    } else {
      for (int i = 1; i < SeGridView.Rows.Count; ++i) {
        if ((bool)SeGridView.Rows[i].Cells[0].EditedFormattedValue 
            && (string)SeGridView.Rows[i].Cells[4].Value != null) {
          string seLevel = SeGridView.Rows[i].Cells[4].EditedFormattedValue.ToString();   
          specialEffect = specialEffect + SeGridView.Rows[i].Cells[3].EditedFormattedValue + ":" + seLevel + ",";
        }
      }

      for (int i = 0; i < EnchantmentGrid.Rows.Count; ++i) {
        if ((bool)EnchantmentGrid.Rows[i].Cells[0].EditedFormattedValue 
            && (string)EnchantmentGrid.Rows[i].Cells[4].Value != null) {
          string id = EnchantmentGrid.Rows[i].Cells[3].EditedFormattedValue.ToString();   
          string lvl = EnchantmentGrid.Rows[i].Cells[4].EditedFormattedValue.ToString();   
          enchantments = enchantments + "{id:" + id + ",lvl:" + lvl + "},";
        }
      }

      if (enchantments.Length > 0) { 
        enchantments = enchantments.Substring(0, enchantments.Length - 1);
      }

      if (specialEffect.Length > 0) { 
        specialEffect = specialEffect.Substring(0, specialEffect.Length - 1);
      }

      if (modelName.Length == 0) { 
        modelName = "blade";
      }

      if (name.Length == 0 && BasicGridView.CurrentRow != null) { 
        name = BasicGridView.CurrentRow.Cells[0].Value.ToString();
      }

      string itemText = item.Length > 0 ? ",Item:" : "";
      string killCountText = killCount.Length > 0 ? ",killCount:" : "";
      string proudSoulText = proudSoul.Length > 0 ? ",ProudSoul:" : "";
      string repairCounterText = repairCounter.Length > 0 ? ",RepairCounter:" : "";
      string specialAttackText = specialAttack.Length > 0 ? ",SpecialAttackType:" : "";
      string specialEffectText = specialEffect.Length > 0 ? ",SB.SEffect:{" + specialEffect + "}" : "";
      string enchantText = enchantments.Length > 0 ? "ench:[" + enchantments + "]," : "";
      string loreText = textBox13.Text.Length > 0 ? ",Lore:[\"" + textBox13.Text + "\"]" : "";
      string baseAttackModifierText = baseAttackModifier.Length > 0 ? ",baseAttackModifier:" : "";
      string repairCostText = repairCost.Length > 0 ? ",RepairCost:" : "";
      string attackAmplifierText = attackAmplifier.Length > 0 ? ",AttackAmplifier:" : "";
      string customMaxDamageText = customMaxDamage.Length > 0 ? ",CustomMaxDamage:" : "";
      string attributeModifiersText = !buttonCheck2.Checked ? SeparateSlot : AllSlot;
      int flags = enchantmentsFlag + attributesFlag + unbreakableFlag + canDestroyFlag + canPlaceOnFlag + othersFlag;
      CommandOutputBox.Text = "/give @p flammpfeil.slashblade:slashblade 1 0 {StandbyRenderType:" + standbyRenderType + 
                              ",isNoScabbard:" + isNoScabbard + ",isBroken:" + isBroken + killCountText + killCount + 
                              proudSoulText + proudSoul + repairCounterText + repairCounter + baseAttackModifierText + 
                              baseAttackModifier + repairCostText + repairCost + attackAmplifierText + attackAmplifier + 
                              customMaxDamageText + customMaxDamage + ",CurrentItemName:\"" + currentItemName + 
                              "\",ModelName:\"" + modelName + "\",TextureName:\"" + textureName + (char)34 + 
                              specialAttackText + specialAttack + specialEffectText + ",SummonedSwordColor:" + rgb + 
                              ",isDefaultBewitched:" + bewitched + ",IsBewitchedActived:" + active + 
                              attributeModifiersText + itemText + item + ",Unbreakable:" + unbreakable + 
                              ",display:{Name:\"" + name + (char)34 + loreText + "}," + enchantText + "HideFlags:" + flags + "}";
    }
  }

  private static void InstructionsButtonClick(object sender, EventArgs e) => new Form3().Show();

  private void ColorLabelClick(object sender, EventArgs e) {
    ColorDialog colorDialog = new ColorDialog();
    int scrollPos = GetScrollPos(Handle, 1);
    if (colorDialog.ShowDialog() == DialogResult.OK) {
      ColorLabel.BackColor = colorDialog.Color;
      VerticalScroll.Value = scrollPos;
    }

    VerticalScroll.Value = scrollPos;
  }

  private void SelectAllSeRadioButtonClick(object sender, EventArgs e) {
    if (SeGridView.Rows.Count > 0) {
      SeGridView.EndEdit();
      foreach (DataGridViewRow row in SeGridView.Rows) {
        row.Cells[0].Value = true;
      }
    }
  }

  private void SelectNoneSeRadioButtonClick(object sender, EventArgs e) {
    if (SeGridView.Rows.Count > 0) {
      SeGridView.EndEdit();
      foreach (DataGridViewRow row in SeGridView.Rows) {
        row.Cells[0].Value = false;
      }
    }
  }

  private void SelectInvertSeRadioButtonClick(object sender, EventArgs e) {
    if (SeGridView.Rows.Count > 0) {
      SeGridView.EndEdit();
      foreach (DataGridViewRow row in SeGridView.Rows) {
        row.Cells[0].Value = !true.Equals(row.Cells[0].Value);
      }
    }
  }

  private void SeGridViewEditingControlShowing(object sender, 
    DataGridViewEditingControlShowingEventArgs e) {
    if (SeGridView.CurrentCellAddress.X == 4) {
      CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
      CellEdit.SelectAll();
      CellEdit.KeyPress += Cells_KeyPress;
    }
  }

  private void Cells_KeyPress(object sender, KeyPressEventArgs e) {
    if (SeGridView.CurrentCellAddress.X == 4) {
      if (e.KeyChar < '0' || e.KeyChar > '9') {
        e.Handled = true;
      }

      if (e.KeyChar == '\b') {
        e.Handled = false;
      }
    }
  }

  private void Cells_KeyPress2(object sender, KeyPressEventArgs e) {
    if (EnchantmentGrid.CurrentCellAddress.X == 3) {
      if (e.KeyChar < '0' || e.KeyChar > '9') {
        e.Handled = true;
      }

      if (e.KeyChar == '\b') {
        e.Handled = false;
      }
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
    if (EnchantmentGrid.CurrentCellAddress.X == 3) {
      CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
      CellEdit.SelectAll();
      CellEdit.KeyPress += Cells_KeyPress2;
    }
  }

  private void BatchSeButtonClick(object sender, EventArgs e) {
    if (textBox69.Text.Length > 0) {
      for (int i = 1; i < SeGridView.Rows.Count; i++) {
        SeGridView.Rows[i].Cells[4].Value = textBox69.Text;
      }
    }
  }
  
  private void BatchEnchantButtonClick(object sender, EventArgs e) {
    if (textBox23.Text.Length > 0) {
      for (int i = 0; i < EnchantmentGrid.Rows.Count; ++i) {
        EnchantmentGrid.Rows[i].Cells[4].Value = textBox23.Text;
      }
    }
  }

  private void BasicGridViewRowClickTick(object sender, EventArgs e) {
    if (BasicGridView.CurrentRow != null) {
      Image errorImage = ModelPreviewBox.ErrorImage;
      string name = BasicGridView.CurrentRow.Cells[0].Value.ToString();
      string path = Environment.CurrentDirectory + "/images/" + name + ".png";
      ModelPreviewBox.Image = File.Exists(path) ? Image.FromFile(path) : errorImage;
    }
  }

  private void AttributesTrackBarTick(object sender, EventArgs e) {
    AttackDamageBox.Text = trackBar1.Value.ToString();
    AttackSpeedBox.Text = trackBar2.Value.ToString();
    MaxHealthBox.Text = trackBar4.Value.ToString();
    MovementSpeedBox.Text = trackBar3.Value.ToString();
    KnockbackResistanceBox.Text = (trackBar8.Value / 10).ToString();
    ArmorBox.Text = trackBar7.Value.ToString();
    ArmorToughnessBox.Text = trackBar6.Value.ToString();
    LuckBox.Text = trackBar5.Value.ToString();
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
    if (EnchantmentGrid.Rows.Count > 0) {
      EnchantmentGrid.EndEdit();
      foreach (DataGridViewRow row in EnchantmentGrid.Rows) {
        row.Cells[0].Value = true;
      }
    }
  }

  private void SelectNoneEnchantmentRadioButtonClick(object sender, EventArgs e) {
    if (EnchantmentGrid.Rows.Count > 0) {
      EnchantmentGrid.EndEdit();
      foreach (DataGridViewRow row in EnchantmentGrid.Rows) {
        row.Cells[0].Value = false;
      }
    }
  }

}