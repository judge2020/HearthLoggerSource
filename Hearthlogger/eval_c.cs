// Decompiled with JetBrains decompiler
// Type: eval_c
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using Hearthlogger;
using System;
using System.Windows.Forms;

internal static class eval_c
{
  [NonSerialized]
  private string eval_a;

  [STAThread]
  private static void a()
  {
    int num1 = -2230;
    int num2 = num1;
    num1 = -2230;
    int num3 = num1;
    switch (num2 == num3)
    {
      case true:
        int num4 = 1;
        if (num4 == 0)
          ;
        num4 = 0;
        if (num4 == 0)
          ;
        num4 = 0;
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run((Form) new Form1());
        break;
      default:
        goto case 1;
    }
  }
}
