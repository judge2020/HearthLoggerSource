// Decompiled with JetBrains decompiler
// Type: eval_b
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

internal class eval_b
{
  [NonSerialized]
  private string eval_a;

  [DllImport("User32.dll")]
  public static extern bool mouse_event(eval_b.eval_a A_0, int A_1, int A_2, int A_3, UIntPtr A_4);

  public static void a(int A_0, int A_1)
  {
    int num1 = -11592;
    int num2 = num1;
    num1 = -11592;
    int num3 = num1;
    switch (num2 == num3)
    {
      case true:
        int num4 = 0;
        if (num4 == 0)
          ;
        num4 = 1;
        if (num4 == 0)
          ;
        num4 = 0;
        A_0 = A_0 * (int) ushort.MaxValue / SystemInformation.PrimaryMonitorSize.Width;
        A_1 = A_1 * (int) ushort.MaxValue / SystemInformation.PrimaryMonitorSize.Height;
        eval_b.mouse_event(eval_b.eval_a.a | eval_b.eval_a.eval_f, A_0, A_1, 0, UIntPtr.Zero);
        eval_b.mouse_event(eval_b.eval_a.eval_b | eval_b.eval_a.eval_f, A_0, A_1, 0, UIntPtr.Zero);
        eval_b.mouse_event(eval_b.eval_a.eval_c | eval_b.eval_a.eval_f, A_0, A_1, 0, UIntPtr.Zero);
        break;
      default:
        goto case 1;
    }
  }

  [Flags]
  public enum eval_a
  {
    a = 1,
    eval_b = 2,
    eval_c = 4,
    eval_d = 8,
    eval_e = 16,
    eval_f = 32768,
  }
}
