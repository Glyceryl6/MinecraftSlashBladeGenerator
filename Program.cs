// Decompiled with JetBrains decompiler
// Type: MinecraftSlashBladeGenerator.Program
// Assembly: MinecraftSlashBladeGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB172600-17B5-47DA-A94D-A55A7C8CD28B
// Assembly location: E:\Microsoft Visual Studio\CSharpCode\MinecraftSlashBladeGenerator\obj\Debug\MinecraftSlashBladeGenerator.exe

using System;
using System.Windows.Forms;

namespace MinecraftSlashBladeGenerator
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
