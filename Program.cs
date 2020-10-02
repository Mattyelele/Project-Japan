// Decompiled with JetBrains decompiler
// Type: Project_Japan.Program
// Assembly: Project Japan, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 12264953-4A90-48AA-834A-171C83DEF005
// Assembly location: C:\Users\tekzl\Desktop\Project Japan\Project Japan.exe

using System;
using System.Windows.Forms;

namespace Project_Japan
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new form());
    }
  }
}
