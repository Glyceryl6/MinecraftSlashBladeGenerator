using System;
using System.IO;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace MinecraftSlashBladeGenerator;

public partial class MainForm : Form {

  [DllImport("user32.dll")]
  private static extern int GetScrollPos(IntPtr handler, int nBar);

  public MainForm() {
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
    e.Handled = !(char.IsNumber(e.KeyChar) || e.KeyChar is '\r' or '\b');
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
      string[] csvLines = File.ReadAllLines(csvPath, Encoding.Default);
      dataGridView.Rows.Add(ReadFileLines(csvPath));
      for (int i = 0; i < ReadFileLines(csvPath); i++) {
        List<string> list = new List<string>(csvLines[i].Split(','));
        dataGridView.Rows[i].Cells[0].Value = list[0];
        dataGridView.Rows[i].Cells[1].Value = list[1];
        if (dataGridView == SaGridView) {
          SaGridView.Rows[i].Cells[2].Value = list[3];
        } else if (dataGridView == BasicGridView) {
          BasicGridView.Rows[i].Cells[2].Value = list[3];
          BasicGridView.Rows[i].Cells[3].Value = list[4];
          BasicGridView.Rows[i].Cells[4].Value = list[5];
        }

        dataGridView.Rows[i].Cells[1].Style.ForeColor = list[2] switch {
          "1.12.2" => Color.Red,
          "1.7.10" => Color.Navy,
          "both" => Color.Purple,
          _ => Color.Black
        };
      }
    }
  }

  private void AddInfo2(DataGridView dataGridView, string path) {
    string csvPath = Environment.CurrentDirectory + "/list/" + path;
    if (File.Exists(csvPath)) {
      string[] csvLines = File.ReadAllLines(csvPath, Encoding.Default);
      dataGridView.Rows.Add(ReadFileLines(csvPath));
      for (int i = 0; i < ReadFileLines(csvPath); i++) {
        List<string> list = new List<string>(csvLines[i].Split(','));
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

  private string AttributesText(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7, TextBox t8, string s) {
    string slot = s.Length > 0 ? ",Slot:" + s : "";
    return "{Operation:0,Amount:" + t1.Text + slot + ",AttributeName:" + "\"generic.attackDamage\",Name:\"attackDamage\"}," +       
           "{Operation:0,Amount:" + t2.Text + slot + ",AttributeName:" + "\"generic.attackSpeed\",Name:\"attackSpeed\"}," + 
           "{Operation:0,Amount:" + t3.Text + slot + ",AttributeName:" + "\"generic.maxHealth\",Name:\"maxHealth\"}," + 
           "{Operation:0,Amount:" + t4.Text + slot + ",AttributeName:" + "\"generic.movementSpeed\",Name:\"movementSpeed\"}," +       
           "{Operation:0,Amount:" + t5.Text + slot + ",AttributeName:" + "\"generic.knockbackResistance\",Name:\"knockbackResistance\"}," + 
           "{Operation:0,Amount:" + t6.Text + slot + ",AttributeName:" + "\"generic.armor\",Name:\"armor\"}," + 
           "{Operation:0,Amount:" + t7.Text + slot + ",AttributeName:" + "\"generic.armorToughness\",Name:\"armorToughness\"}," + 
           "{Operation:0,Amount:" + t8.Text + slot + ",AttributeName:" + "\"generic.luck\",Name:\"luck\"}";
  }

  private void SetAttributeModifiers() {
    AllSlot = ",AttributeModifiers:[" + AttributesText(textBox21, textBox20, textBox19, textBox18, textBox17, textBox16, textBox15, textBox22, "") + "]";
    SeparateSlot = ",AttributeModifiers:[" + 
                   AttributesText(textBox21, textBox20, textBox19, textBox18, textBox17, textBox16, textBox15, textBox22, "head") + "," +
                   AttributesText(textBox32, textBox31, textBox30, textBox29, textBox28, textBox27, textBox26, textBox24, "chest") + "," +
                   AttributesText(textBox41, textBox40, textBox39, textBox38, textBox37, textBox36, textBox35, textBox33, "legs") + "," +
                   AttributesText(textBox50, textBox49, textBox48, textBox47, textBox46, textBox45, textBox44, textBox42, "feet") + "," +
                   AttributesText(textBox59, textBox58, textBox57, textBox56, textBox55, textBox54, textBox53, textBox51, "mainhand") + "," +
                   AttributesText(textBox68, textBox67, textBox66, textBox65, textBox64, textBox63, textBox62, textBox60, "offhand") + "]";
  }

  private void CommandOutputButtonClick(object sender, EventArgs e) {
    Color color = ColorLabel.BackColor;
    int enchantmentsFlag = checkBox7.Checked ? 1 : 0;
    int attributesFlag = checkBox6.Checked ? 2 : 0;
    int unbreakableFlag = checkBox5.Checked ? 4 : 0;
    int canDestroyFlag = checkBox9.Checked ? 8 : 0;
    int canPlaceOnFlag = checkBox8.Checked ? 16 : 0;
    int othersFlag = checkBox10.Checked ? 32 : 0;
    int rgb = color.R * 65536 + color.G * 256 + color.B;
    string isNoScabbard = checkBox1.Checked ? "0b" : "1b";
    string isBroken = checkBox2.Checked ? "1b" : "0b";
    string unbreakable = checkBox4.Checked ? "1b" : "0b";
    string active = checkBox11.Checked ? "1b" : "0b";
    string bewitched = checkBox12.Checked ? "1b" : "0b";
    string standbyRenderType = !radioButton1.Checked ? !radioButton2.Checked ? !radioButton3.Checked ? "4" : "3" : "2" : "1";
    string currentItemName = BasicGridView.CurrentRow != null ? BasicGridView.CurrentRow.Cells[2].Value.ToString() : "";
    string modelName = BasicGridView.CurrentRow != null ? BasicGridView.CurrentRow.Cells[3].Value.ToString() : "blade";
    string textureName = BasicGridView.CurrentRow != null ? BasicGridView.CurrentRow.Cells[4].Value.ToString() : "";
    string specialAttack = SaGridView.CurrentRow != null ? SaGridView.CurrentRow.Cells[2].Value.ToString() : "";
    string specialEffect = "", enchantments = "", name = textBox12.Text;
    SetAttributeModifiers();
    if (currentItemName.Length > 0) {
      //添加已设置的SE
      for (int i = 1; i < SeGridView.Rows.Count; ++i) {
        if ((bool)SeGridView.Rows[i].Cells[0].EditedFormattedValue 
            && (string)SeGridView.Rows[i].Cells[4].Value != null) {
          string seLevel = SeGridView.Rows[i].Cells[4].EditedFormattedValue.ToString();   
          specialEffect += SeGridView.Rows[i].Cells[3].EditedFormattedValue + ":" + seLevel + ",";
        }
      }
      //添加已设置的附魔
      for (int i = 0; i < EnchantmentGrid.Rows.Count; ++i) {
        if ((bool)EnchantmentGrid.Rows[i].Cells[0].EditedFormattedValue 
            && (string)EnchantmentGrid.Rows[i].Cells[4].Value != null) {
          string id = EnchantmentGrid.Rows[i].Cells[3].EditedFormattedValue.ToString();   
          string lvl = EnchantmentGrid.Rows[i].Cells[4].EditedFormattedValue.ToString();   
          enchantments += "{id:" + id + ",lvl:" + lvl + "},";
        }
      }
      //如果添加了SE，则删除其文本末尾的逗号
      if (specialEffect.Length > 0) { 
        specialEffect = specialEffect.Substring(0, specialEffect.Length - 1);
      }
      //如果添加了附魔，则删除其文本末尾的逗号
      if (enchantments.Length > 0) { 
        enchantments = enchantments.Substring(0, enchantments.Length - 1);
      }
      //如果未填写自定义名称，则使用这把刀本身的名字
      if (textBox12.Text.Length == 0 && BasicGridView.CurrentRow != null) { 
        name = BasicGridView.CurrentRow.Cells[0].Value.ToString();
      }
      //将内容整合成最后的命令并输出
      string itemText = textBox14.Text.Length > 0 ? ",Item:" + textBox14.Text : "";
      string killCountText = textBox2.Text.Length > 0 ? ",killCount:" + textBox2.Text : "";
      string proudSoulText = textBox3.Text.Length > 0 ? ",ProudSoul:" + textBox3.Text : "";
      string repairCounterText = textBox4.Text.Length > 0 ? ",RepairCounter:" + textBox4.Text : "";
      string specialAttackText = specialAttack.Length > 0 ? ",SpecialAttackType:" + specialAttack : "";
      string specialEffectText = specialEffect.Length > 0 ? ",SB.SEffect:{" + specialEffect + "}" : "";
      string enchantText = enchantments.Length > 0 ? "ench:[" + enchantments + "]," : "";
      string loreText = textBox13.Text.Length > 0 ? ",Lore:[\"" + textBox13.Text + "\"]" : "";
      string baseAttackModifierText = textBox5.Text.Length > 0 ? ",baseAttackModifier:" + textBox5.Text : "";
      string repairCostText = textBox4.Text.Length > 0 ? ",RepairCost:" + textBox4.Text : "";
      string attackAmplifierText = textBox7.Text.Length > 0 ? ",AttackAmplifier:" + textBox7.Text : "";
      string customMaxDamageText = textBox8.Text.Length > 0 ? ",CustomMaxDamage:" + textBox8.Text : "";
      string attributeModifiersText = buttonCheck2.Checked ? AllSlot : SeparateSlot;
      int flags = enchantmentsFlag + attributesFlag + unbreakableFlag + canDestroyFlag + canPlaceOnFlag + othersFlag;
      CommandOutputBox.Text = @"/give @p flammpfeil.slashblade:slashblade 1 0 {StandbyRenderType:" + standbyRenderType + 
                              @",isNoScabbard:" + isNoScabbard + @",isBroken:" + isBroken + killCountText + proudSoulText + 
                              repairCounterText + baseAttackModifierText + repairCostText + attackAmplifierText + customMaxDamageText + 
                              @",CurrentItemName:""" + currentItemName + @""",ModelName:""" + modelName + @""",TextureName:""" + textureName + (char)34 + 
                              specialAttackText + specialEffectText + @",SummonedSwordColor:" + rgb + @",isDefaultBewitched:" + bewitched + 
                              @",IsBewitchedActived:" + active + attributeModifiersText + itemText + @",Unbreakable:" + unbreakable + 
                              @",display:{Name:""" + name + (char)34 + loreText + @"}," + enchantText + @"HideFlags:" + flags + @"}";
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

  private void SeGridViewEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
    if (SeGridView.CurrentCellAddress.X == 4) {
      CellEdit = (DataGridViewTextBoxEditingControl)e.Control;
      CellEdit.SelectAll();
      CellEdit.KeyPress += Cells_KeyPress;
    }
  }

  private void Cells_KeyPress(object sender, KeyPressEventArgs e) {
    if (SeGridView.CurrentCellAddress.X == 4) {
      if (e.KeyChar is < '0' or > '9') {
        e.Handled = true;
      }
      
      if (e.KeyChar == '\b') {
        e.Handled = false;
      }
    }
  }

  private void Cells_KeyPress2(object sender, KeyPressEventArgs e) {
    if (EnchantmentGrid.CurrentCellAddress.X == 3) {
      if (e.KeyChar is < '0' or > '9') {
        e.Handled = true;
      }

      if (e.KeyChar == '\b') {
        e.Handled = false;
      }
    }
  }

  private void timer1_Tick(object sender, EventArgs e) {
    if (ClientSize.Width < 944 || ClientSize.Height < 631) {
      ClientSize = new Size(944, 631);
    }
    if (SeGridView.CurrentRow != null) {
      SeGridView.CurrentRow.Cells[4].ReadOnly = !(bool)SeGridView.CurrentRow.Cells[0].EditedFormattedValue;
    }
    if (EnchantmentGrid.CurrentRow != null) {
      EnchantmentGrid.CurrentRow.Cells[4].ReadOnly = !(bool)EnchantmentGrid.CurrentRow.Cells[0].EditedFormattedValue;
    }
  }

  private void EnchantmentGridEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e) {
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