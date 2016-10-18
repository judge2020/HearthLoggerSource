// Decompiled with JetBrains decompiler
// Type: eval_e
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.Runtime.InteropServices;

internal class eval_e
{
  [NonSerialized]
  private string eval_a;

  [DllImport("user32.dll")]
  public static extern bool SetWindowPos(int A_0, int A_1, int A_2, int A_3, int A_4, int A_5, uint A_6);

  [DllImport("user32.dll")]
  public static extern bool GetWindowRect(IntPtr A_0, out eval_e.eval_a A_1);

  [DllImport("User32.dll")]
  public static extern IntPtr SetForegroundWindow(IntPtr A_0);

  [DllImport("user32.dll")]
  public static extern bool AdjustWindowRectEx(ref eval_e.eval_a A_0, uint A_1, bool A_2, uint A_3);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern uint GetWindowLong(IntPtr A_0, int A_1);

  [DllImport("user32.dll")]
  public static extern IntPtr GetMenu(IntPtr A_0);

  [DllImport("user32.dll", SetLastError = true)]
  public static extern IntPtr GetForegroundWindow();

  [DllImport("user32.dll", CharSet = CharSet.Auto)]
  public static extern bool PostMessage(IntPtr A_0, int A_1, int A_2, int A_3);

  [DllImport("user32.dll")]
  public static extern int LoadKeyboardLayout(string A_0, uint A_1);

  public static void eval_a(IntPtr A_0, int A_1, int A_2, int A_3, int A_4, bool A_5)
  {
    int num1 = 1;
    if (num1 == 0)
      ;
    int num2;
    bool flag;
    switch (0)
    {
      case 0:
label_3:
        flag = !A_5;
        num1 = 0;
        num2 = num1;
        goto default;
      default:
        eval_e.eval_a A_0_1;
        while (true)
        {
          switch (num2)
          {
            case 0:
              if (!flag)
              {
                num1 = 3;
                num2 = num1;
                continue;
              }
              break;
            case 1:
              num1 = 0;
              break;
            case 2:
              goto label_11;
            case 3:
label_6:
              num1 = 1;
              num2 = num1;
              continue;
            default:
              goto label_3;
          }
          A_0_1 = new eval_e.eval_a(0, 0, A_3, A_4);
          num1 = 21855;
          int num3 = num1;
          num1 = 21855;
          int num4 = num1;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_6;
            default:
              num1 = 0;
              if (num1 == 0)
                ;
              num1 = 2;
              num2 = num1;
              continue;
          }
        }
label_11:
        eval_e.AdjustWindowRectEx(ref A_0_1, eval_e.GetWindowLong(A_0, -16), eval_e.GetMenu(A_0).ToInt32() != 0, eval_e.GetWindowLong(A_0, -20));
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        // ISSUE: reference to a compiler-generated method
        eval_e.SetWindowPos((int) A_0, 0, A_1 + A_0_1.eval_a(), A_2 + A_0_1.eval_b(), A_0_1.eval_c() - A_0_1.eval_a(), A_0_1.eval_e() - A_0_1.eval_b(), 64U);
        break;
    }
  }

  public struct eval_a
  {
    public eval_a(int A_0, int A_1, int A_2, int A_3)
    {
      this = new eval_e.eval_a();
      // ISSUE: reference to a compiler-generated method
      this.eval_a(A_0);
      // ISSUE: reference to a compiler-generated method
      this.eval_b(A_1);
      // ISSUE: reference to a compiler-generated method
      this.eval_c(A_2);
      // ISSUE: reference to a compiler-generated method
      this.eval_e(A_3);
    }
  }
}
