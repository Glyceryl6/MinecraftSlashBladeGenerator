using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftSlashBladeGenerator;

partial class Form3 {
    
    private IContainer components;
    private Label label81;
    private Label label1;
    private Label label2;
    private Label label3;
    
    protected override void Dispose(bool disposing) {
        if (disposing && components != null) {
            components.Dispose();
        }
        base.Dispose(disposing);
    }
    
    #region Windows Form Designer generated code

    private void InitializeComponent() { 
        ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form3)); 
        components = new Container();
        label81 = new Label();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        SuspendLayout();
        label81.BackColor = SystemColors.ControlLightLight;
        label81.Font = new Font("微软雅黑", 10f, FontStyle.Regular, GraphicsUnit.Point,  134);
        label81.ForeColor = Color.Black;
        label81.Location = new Point(9, 9);
        label81.Name = "label81";
        label81.Size = new Size(702, 187);
        label81.TabIndex = 37;
        label81.Text = componentResourceManager.GetString("label81.Text");
        label1.BackColor = SystemColors.ControlLightLight;
        label1.Font = new Font("微软雅黑", 10f, FontStyle.Bold, GraphicsUnit.Point,  134);
        label1.ForeColor = Color.Red;
        label1.Location = new Point(9, 196);
        label1.Name = "label1";
        label1.Size = new Size(702, 243);
        label1.TabIndex = 38;
        label1.Text = componentResourceManager.GetString("label1.Text");
        label2.BackColor = SystemColors.ControlLightLight;
        label2.Font = new Font("微软雅黑", 10f, FontStyle.Regular, GraphicsUnit.Point,  134);
        label2.ForeColor = Color.Black;
        label2.Location = new Point(9, 439);
        label2.Name = "label2";
        label2.Size = new Size(702, 187);
        label2.TabIndex = 39;
        label2.Text = componentResourceManager.GetString("label2.Text");
        label3.BackColor = SystemColors.ControlLightLight;
        label3.Font = new Font("微软雅黑", 10f, FontStyle.Bold, GraphicsUnit.Point,  134);
        label3.ForeColor = Color.Red;
        label3.Location = new Point(9, 626);
        label3.Name = "label3";
        label3.Size = new Size(702, 180);
        label3.TabIndex = 40;
        label3.Text = componentResourceManager.GetString("label3.Text");
        AutoScaleDimensions = new SizeF(6f, 12f);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = SystemColors.Control;
        ClientSize = new Size(734, 424);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(label81);
        Font = new Font("宋体", 9f, FontStyle.Regular, GraphicsUnit.Point,  134);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Name = nameof (Form3);
        ShowIcon = false;
        StartPosition = FormStartPosition.CenterScreen;
        Text = "各种常见问题及注意事项";
        ResumeLayout(false);
    }
    
    #endregion
    
}