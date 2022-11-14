using MinecraftSlashBladeGenerator.Properties;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace MinecraftSlashBladeGenerator {
  
  public class ButtonCheck : UserControl {
    
    private bool isCheck = true;
    private CheckStyle checkStyle = CheckStyle.Style1;
    private IContainer components = null;

    public ButtonCheck() {
      InitializeComponent();
      SetStyle(ControlStyles.AllPaintingInWmPaint, true);
      SetStyle(ControlStyles.DoubleBuffer, true);
      SetStyle(ControlStyles.ResizeRedraw, true);
      SetStyle(ControlStyles.Selectable, true);
      SetStyle(ControlStyles.SupportsTransparentBackColor, true);
      SetStyle(ControlStyles.UserPaint, true);
      BackColor = Color.Transparent;
      Cursor = Cursors.Hand;
      Size = new Size(87, 27);
    }

    public bool Checked {
      set {
        isCheck = value;
        Invalidate();
      }
      get => isCheck;
    }

    public CheckStyle CheckStyleX {
      set {
        checkStyle = value;
        Invalidate();
      }
      get => checkStyle;
    }

    protected override void OnPaint(PaintEventArgs e) {
      Bitmap bitmap1 = null;
      Bitmap bitmap2 = null;
      if (checkStyle == CheckStyle.Style1) {
        bitmap1 = Resources.自选;
        bitmap2 = Resources.自定;
      } else if (checkStyle == CheckStyle.Style2) {
        bitmap1 = Resources.所有;
        bitmap2 = Resources.分离;
      }
      Graphics graphics = e.Graphics;
      Rectangle rect = new Rectangle();
      ref Rectangle local = ref rect;
      Size size = Size;
      int width = size.Width;
      int height = size.Height;
      local = new Rectangle(0, 0, width, height);
      if (bitmap1 != null && bitmap2 != null) {
        graphics.DrawImage(isCheck ? bitmap1 : bitmap2, rect);
      }
    }

    private void ButtonCheck_Click(object sender, EventArgs e) {
      isCheck = !isCheck;
      Invalidate();
    }

    protected override void Dispose(bool disposing) {
      if (disposing && components != null) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent() {
      SuspendLayout();
      AutoScaleDimensions = new SizeF(6f, 12f);
      AutoScaleMode = AutoScaleMode.Font;
      Name = nameof (ButtonCheck);
      Click += ButtonCheck_Click;
      ResumeLayout(false);
    }

    public enum CheckStyle {
      Style1,
      Style2
    }
  }
}
