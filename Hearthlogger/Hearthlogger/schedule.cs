// Decompiled with JetBrains decompiler
// Type: Hearthlogger.schedule
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hearthlogger
{
  public class schedule : Form
  {
    private int eval_a = 24;
    private int b = 7;
    private int eval_c = 4;
    private Panel[,] d = new Panel[24, 7];
    public int[] ArrSched = new int[168];
    private Label[] eval_g = new Label[25];
    private Label[] eval_h = new Label[7];
    private string[] eval_i = new string[7]
    {
      "Sun",
      "Mon",
      "Tue",
      "Wed",
      "Thu",
      "Fri",
      "Sat"
    };
    private Color eval_j = Color.FromArgb((int) byte.MaxValue, 128, 0);
    private Color k = Color.FromArgb((int) byte.MaxValue, 128, 0);
    private Color l = Color.FromArgb(0, 192, 0);
    private Color m = Color.FromArgb(65, 105, 225);
    private Color n = Color.FromArgb(0, 0, 0);
    private Color[] eval_o = new Color[24];
    private IContainer eval_p = (IContainer) null;
    private Panel[] eval_e;
    private Panel eval_f;
    private Button eval_q;
    private Button eval_r;
    private Label eval_s;
    private Label eval_t;
    private CheckBox eval_u;
    [NonSerialized]
    string eval_v;

    public schedule(int[] args, int nacc)
    {
      this.eval_a();
      if (args.Length != 168)
        Array.Resize<int>(ref args, 168);
      this.ArrSched = args;
      this.eval_c = nacc;
    }

    private void eval_b()
    {
      int num1 = 1;
      if (num1 == 0)
        ;
      num1 = -10789;
      int num2 = num1;
      num1 = -10789;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          if (num1 == 0)
            ;
          num1 = 0;
          this.eval_o[0] = Color.FromArgb((int) byte.MaxValue, 128, 0);
          this.eval_o[1] = Color.FromArgb(0, 192, 0);
          this.eval_o[2] = Color.FromArgb(65, 105, 225);
          this.eval_o[3] = Color.FromArgb(0, 0, 0);
          this.eval_o[4] = Color.FromArgb((int) byte.MaxValue, 0, 153);
          this.eval_o[5] = Color.FromArgb(153, 153, 102);
          this.eval_o[6] = Color.FromArgb(153, 0, 51);
          this.eval_o[7] = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 0);
          this.eval_o[8] = Color.FromArgb(153, 153, 153);
          this.eval_o[9] = Color.FromArgb(153, (int) byte.MaxValue, 102);
          this.eval_o[10] = Color.FromArgb(51, 0, 153);
          this.eval_o[11] = Color.FromArgb((int) byte.MaxValue, 204, 153);
          this.eval_o[12] = Color.FromArgb(204, 0, 0);
          this.eval_o[13] = Color.FromArgb(153, 0, (int) byte.MaxValue);
          this.eval_o[14] = Color.FromArgb(0, 153, 153);
          this.eval_o[15] = Color.FromArgb(102, 51, 0);
          this.eval_o[16] = Color.FromArgb(153, 204, (int) byte.MaxValue);
          this.eval_o[17] = Color.FromArgb(102, 102, 0);
          this.eval_o[18] = Color.FromArgb(0, 51, 153);
          this.eval_o[19] = Color.FromArgb(0, 51, 0);
          this.eval_o[20] = Color.FromArgb(0, (int) byte.MaxValue, (int) byte.MaxValue);
          this.eval_o[21] = Color.FromArgb(153, 0, 102);
          this.eval_o[22] = Color.FromArgb(102, 51, 102);
          this.eval_o[23] = Color.FromArgb(0, 0, 153);
          break;
        default:
          goto case 1;
      }
    }

    private void eval_f(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          bool flag;
          int num3;
          switch (0)
          {
            case 0:
label_3:
              this.eval_b();
              num2 = (DateTime.UtcNow - DateTime.Now).Hours;
              flag = num2 >= 0;
              num3 = 23;
              num1 = num3;
              goto default;
            default:
              while (true)
              {
                int index1;
                int j;
                int index2;
                int num4;
                int num5;
                switch (num1)
                {
                  case 0:
                    num2 = 24 - num2;
                    num4 = 0;
                    index1 = 0;
                    j = 0;
                    num3 = 24;
                    num1 = num3;
                    continue;
                  case 1:
                    if (!flag)
                    {
                      num3 = 18;
                      num1 = num3;
                      continue;
                    }
                    this.eval_h[j].ForeColor = Color.White;
                    num3 = 15;
                    num1 = num3;
                    continue;
                  case 2:
                    ++j;
                    num3 = 20;
                    num1 = num3;
                    continue;
                  case 3:
                  case 28:
                    flag = index1 < this.eval_a;
                    num3 = 17;
                    num1 = num3;
                    continue;
                  case 4:
                  case 9:
                    flag = index1 < this.eval_c;
                    num3 = 1;
                    if (num3 == 0)
                      ;
                    num3 = 22;
                    num1 = num3;
                    continue;
                  case 5:
                    goto label_54;
                  case 6:
                    num2 += 24;
                    num3 = 35;
                    num1 = num3;
                    continue;
                  case 7:
                    if (!flag)
                    {
                      num3 = 27;
                      num1 = num3;
                      continue;
                    }
                    goto case 12;
                  case 8:
                    num3 = 0;
                    num2 -= 24;
                    num3 = 0;
                    num1 = num3;
                    continue;
                  case 10:
                    num3 = 19;
                    num1 = num3;
                    continue;
                  case 11:
                  case 15:
                    this.eval_h[j].BackColor = Color.Transparent;
                    this.eval_h[j].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
                    this.eval_h[j].Text = this.eval_i[j];
                    this.eval_h[j].Size = new Size(33, 13);
                    this.eval_h[j].Location = new Point(10, 25 + 19 * j);
                    this.Controls.Add((Control) this.eval_h[j]);
                    index1 = 0;
                    num3 = 28;
                    num1 = num3;
                    continue;
                  case 12:
                    index2 = this.ArrSched[index1 + 24 * j] - 1;
                    this.d[index1, j] = new Panel();
                    this.d[index1, j].Visible = true;
                    this.d[index1, j].BorderStyle = BorderStyle.FixedSingle;
                    this.d[index1, j].ForeColor = Control.DefaultForeColor;
                    num3 = 32;
                    num1 = num3;
                    continue;
                  case 13:
                    this.eval_g[index1].Location = new Point(30 + num4 + 19 * index1, 5);
                    this.Controls.Add((Control) this.eval_g[index1]);
                    num3 = 12;
                    num1 = num3;
                    continue;
                  case 14:
                    if (!flag)
                    {
                      num3 = 29;
                      num1 = num3;
                      continue;
                    }
                    goto case 13;
                  case 16:
                    num5 = 0;
                    goto label_30;
                  case 17:
                    if (!flag)
                    {
                      num3 = 2;
                      num1 = num3;
                      continue;
                    }
                    flag = j != 0;
                    num3 = 7;
                    num1 = num3;
                    continue;
                  case 18:
                    this.eval_h[j].ForeColor = Color.FromArgb((int) byte.MaxValue, 128, 0);
                    num3 = 11;
                    num1 = num3;
                    continue;
                  case 19:
                    num5 = j != 6 ? 1 : 0;
                    goto label_30;
                  case 20:
                  case 24:
                    flag = j < this.b;
                    num3 = 25;
                    num1 = num3;
                    continue;
                  case 21:
                    if (j == 0)
                    {
                      num3 = 16;
                      num1 = num3;
                      continue;
                    }
                    num3 = 10;
                    num1 = num3;
                    continue;
                  case 22:
                    if (!flag)
                    {
                      num3 = 5;
                      num1 = num3;
                      continue;
                    }
                    this.eval_e[index1] = new Panel();
                    this.eval_e[index1].Visible = true;
                    this.eval_e[index1].BorderStyle = BorderStyle.FixedSingle;
                    this.eval_e[index1].ForeColor = Control.DefaultForeColor;
                    this.eval_e[index1].BackColor = this.eval_o[index1];
                    this.eval_e[index1].Tag = (object) index1;
                    this.eval_e[index1].Size = new Size(20, 20);
                    this.eval_e[index1].Location = new Point(40 + 19 * index1, 162);
                    this.eval_e[index1].MouseClick += new MouseEventHandler(this.eval_e);
                    this.Controls.Add((Control) this.eval_e[index1]);
                    this.eval_e[index1].BringToFront();
                    Label label1 = new Label();
                    label1.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular);
                    label1.Text = (index1 + 1).ToString();
                    label1.Location = new Point(-1, 9);
                    label1.ForeColor = this.eval_a(this.eval_o[index1]);
                    this.eval_e[index1].Controls.Add((Control) label1);
                    ++index1;
                    num3 = 9;
                    num1 = num3;
                    continue;
                  case 23:
                    if (!flag)
                    {
                      num3 = 6;
                      num1 = num3;
                      continue;
                    }
                    goto case 35;
                  case 25:
                    if (flag)
                    {
                      this.eval_h[j] = new Label();
                      this.eval_h[j].Visible = true;
                      num3 = 21;
                      num1 = num3;
                      continue;
                    }
                    num3 = 33;
                    num1 = num3;
                    continue;
                  case 26:
                    num4 = 4;
                    this.eval_g[index1].Size = new Size(15, 13);
                    num3 = 30;
                    num1 = num3;
                    continue;
                  case 27:
                    this.eval_a(index1);
                    num4 = 0;
                    flag = index1 >= 10;
                    num3 = 31;
                    num1 = num3;
                    continue;
                  case 29:
                    this.eval_g[index1].ForeColor = Color.FromArgb(192, 192, 192);
                    num3 = 13;
                    num1 = num3;
                    continue;
                  case 30:
                    num3 = 27926;
                    int num6 = num3;
                    num3 = 27926;
                    int num7 = num3;
                    switch (num6 == num7 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_14;
                      default:
                        num3 = 0;
                        if (num3 == 0)
                          break;
                        break;
                    }
                  case 31:
                    if (!flag)
                    {
                      num3 = 26;
                      num1 = num3;
                      continue;
                    }
                    break;
                  case 32:
                    this.d[index1, j].BackColor = index2 >= this.eval_c || index2 < 0 ? Color.FromArgb(73, 73, 73) : this.eval_o[index2];
                    this.d[index1, j].Size = new Size(20, 20);
                    this.d[index1, j].Location = new Point(40 + 19 * index1, 20 + 19 * j);
                    this.Controls.Add((Control) this.d[index1, j]);
                    this.d[index1, j].BringToFront();
                    this.d[index1, j].Tag = (object) new schedule.Pos(index1, j);
                    this.d[index1, j].MouseClick += new MouseEventHandler(this.eval_d);
                    ++index1;
                    num3 = 3;
                    num1 = num3;
                    continue;
                  case 33:
                    this.eval_a(index1);
                    this.eval_g[index1].Location = new Point(30 + num4 + 19 * index1, 5);
                    this.Controls.Add((Control) this.eval_g[index1]);
                    Label label2 = new Label();
                    label2.Visible = true;
                    label2.ForeColor = Color.FromArgb(192, 192, 192);
                    label2.BackColor = Color.Transparent;
                    label2.Font = new Font("Microsoft Sans Serif", 6f, FontStyle.Regular);
                    label2.Text = "UTC 0";
                    label2.Size = new Size(50, 13);
                    label2.Location = new Point(30 + 19 * num2, 154);
                    this.Controls.Add((Control) label2);
                    this.eval_e = new Panel[this.eval_c];
                    index1 = 0;
                    num3 = 4;
                    num1 = num3;
                    continue;
                  case 34:
                    if (!flag)
                    {
                      num3 = 8;
                      num1 = num3;
                      continue;
                    }
                    goto case 0;
                  case 35:
label_14:
                    flag = num2 <= 23;
                    num3 = 34;
                    num1 = num3;
                    continue;
                  default:
                    goto label_3;
                }
                flag = num2 != index1;
                num3 = 14;
                num1 = num3;
                continue;
label_30:
                flag = num5 != 0;
                num3 = 1;
                num1 = num3;
              }
label_54:
              this.eval_e[0].BorderStyle = BorderStyle.Fixed3D;
              this.eval_f = this.eval_e[0];
              return;
          }
      }
    }

    private void eval_a(int A_0)
    {
      int num1 = -14934;
      int num2 = num1;
      num1 = -14934;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          int num4 = 1;
          if (num4 == 0)
            ;
          num4 = 0;
          num4 = 0;
          if (num4 == 0)
            ;
          this.eval_g[A_0] = new Label();
          this.eval_g[A_0].Visible = true;
          this.eval_g[A_0].ForeColor = Color.White;
          this.eval_g[A_0].BackColor = Color.Transparent;
          this.eval_g[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.eval_g[A_0].Text = A_0.ToString();
          this.eval_g[A_0].Size = new Size(19, 13);
          break;
        default:
          goto case 1;
      }
    }

    private void eval_e(object A_0, EventArgs A_1)
    {
      int num1 = -18158;
      int num2 = num1;
      num1 = -18158;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          int num4 = 1;
          if (num4 == 0)
            ;
          num4 = 0;
          num4 = 0;
          if (num4 == 0)
            ;
          Panel panel = (Panel) A_0;
          this.eval_j = this.eval_o[(int) panel.Tag];
          panel.BorderStyle = BorderStyle.Fixed3D;
          this.eval_f.BorderStyle = BorderStyle.FixedSingle;
          this.eval_f = panel;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_d(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      schedule.Pos pos;
      bool flag;
      switch (0)
      {
        case 0:
label_3:
          num1 = 1;
          if (num1 == 0)
            ;
          pos = (schedule.Pos) ((Control) A_0).Tag;
          flag = !(this.d[pos.I, pos.J].BackColor == Color.FromArgb(73, 73, 73));
          num1 = -6960;
          int num3 = num1;
          num1 = -6960;
          int num4 = num1;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
              return;
            case 2:
              return;
            default:
              num1 = 0;
              if (num1 == 0)
                ;
              num1 = 1;
              num2 = num1;
              goto label_2;
          }
        default:
label_2:
          while (true)
          {
            num1 = 0;
            switch (num2)
            {
              case 0:
                this.d[pos.I, pos.J].BackColor = this.eval_j;
                num1 = 3;
                num2 = num1;
                continue;
              case 1:
                if (!flag)
                {
                  num1 = 0;
                  num2 = num1;
                  continue;
                }
                this.d[pos.I, pos.J].BackColor = Color.FromArgb(73, 73, 73);
                num1 = 2;
                num2 = num1;
                continue;
              case 2:
                goto label_9;
              case 3:
                goto label_1;
              default:
                goto label_3;
            }
          }
label_1:
          break;
label_9:
          break;
      }
    }

    private void eval_c(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      num1 = 27145;
      int num2 = num1;
      num1 = 27145;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 1;
          if (num1 == 0)
            ;
          num1 = 0;
          if (num1 != 0)
            break;
          break;
        default:
          goto case 1;
      }
    }

    private Color eval_a(Color A_0)
    {
      int num1;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          num2 = 9;
          num1 = num2;
          goto default;
        default:
          Color color;
          while (true)
          {
            bool flag;
            int num3;
            int num4;
            int num5;
            int num6;
            int num7;
            switch (num1)
            {
              case 0:
                if ((double) A_0.GetBrightness() >= 0.5)
                {
                  num2 = 12;
                  num1 = num2;
                  continue;
                }
                goto label_63;
              case 1:
                if (!flag)
                {
                  num2 = 18;
                  num1 = num2;
                  continue;
                }
                color = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
                num2 = 4;
                num1 = num2;
                continue;
              case 2:
                if ((double) A_0.GetSaturation() > 0.5)
                {
                  num2 = 38;
                  num1 = num2;
                  continue;
                }
                num2 = 24;
                num1 = num2;
                continue;
              case 3:
                if (flag)
                {
                  num2 = 6;
                  num1 = num2;
                  continue;
                }
                num2 = 19;
                num1 = num2;
                continue;
              case 4:
              case 8:
              case 14:
              case 15:
              case 30:
              case 36:
                goto label_67;
              case 5:
                if (!flag)
                {
                  num2 = 22;
                  num1 = num2;
                  continue;
                }
                num2 = 20;
                num1 = num2;
                continue;
              case 6:
                if ((double) A_0.GetSaturation() > 0.5)
                {
                  num2 = 16;
                  num1 = num2;
                  continue;
                }
                break;
              case 7:
                if ((double) A_0.GetSaturation() > 0.5)
                {
                  num2 = 35;
                  num1 = num2;
                  continue;
                }
                num2 = 26;
                num1 = num2;
                continue;
              case 9:
                if ((double) A_0.GetSaturation() > 0.5)
                {
                  num2 = 37;
                  num1 = num2;
                  continue;
                }
                goto label_63;
              case 10:
                color = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
                num2 = 30;
                num1 = num2;
                continue;
              case 11:
                num3 = (double) A_0.GetHue() <= 180.0 ? 1 : 0;
                goto label_16;
              case 12:
                num2 = 31;
                num1 = num2;
                continue;
              case 13:
                num4 = (double) A_0.GetBrightness() < 0.5 ? 1 : 0;
                goto label_47;
              case 16:
                num2 = 34;
                num1 = num2;
                continue;
              case 17:
                color = Color.FromArgb(0, 0, 0);
                num2 = 36;
                num1 = num2;
                continue;
              case 18:
                color = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
                num2 = 8;
                num1 = num2;
                continue;
              case 19:
                num2 = 11626;
                int num8 = num2;
                num2 = 11626;
                int num9 = num2;
                switch (num8 == num9 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_38;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    color = Color.FromArgb(0, 0, 0);
                    num2 = 15;
                    num1 = num2;
                    continue;
                }
              case 20:
                if ((double) A_0.GetSaturation() <= 0.5)
                {
                  num2 = 1;
                  if (num2 == 0)
                    ;
                  num2 = 29;
                  num1 = num2;
                  continue;
                }
                num2 = 28;
                num1 = num2;
                continue;
              case 21:
                num5 = (double) A_0.GetBrightness() >= 0.5 ? 1 : 0;
                goto label_59;
              case 22:
label_38:
                num2 = 0;
                color = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, (int) byte.MaxValue);
                num2 = 14;
                num1 = num2;
                continue;
              case 23:
                if (flag)
                {
                  num2 = 7;
                  num1 = num2;
                  continue;
                }
                num2 = 17;
                num1 = num2;
                continue;
              case 24:
                num2 = 13;
                num1 = num2;
                continue;
              case 25:
                num3 = 1;
                goto label_16;
              case 26:
                num2 = 39;
                num1 = num2;
                continue;
              case 27:
                if (flag)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                num2 = 10;
                num1 = num2;
                continue;
              case 28:
                num2 = 21;
                num1 = num2;
                continue;
              case 29:
                num5 = 1;
                goto label_59;
              case 31:
                num6 = (double) A_0.GetHue() > 180.0 ? 1 : 0;
                goto label_33;
              case 32:
                num6 = 1;
                goto label_33;
              case 33:
                num2 = 11;
                num1 = num2;
                continue;
              case 34:
                if ((double) A_0.GetBrightness() >= 0.5)
                {
                  num2 = 33;
                  num1 = num2;
                  continue;
                }
                break;
              case 35:
                num7 = 1;
                goto label_44;
              case 37:
                num2 = 0;
                num1 = num2;
                continue;
              case 38:
                num4 = 1;
                goto label_47;
              case 39:
                num7 = (double) A_0.GetBrightness() >= 0.5 ? 1 : 0;
                goto label_44;
              default:
                goto label_2;
            }
            num2 = 25;
            num1 = num2;
            continue;
label_16:
            flag = num3 != 0;
            num2 = 5;
            num1 = num2;
            continue;
label_33:
            flag = num6 != 0;
            num2 = 3;
            num1 = num2;
            continue;
label_44:
            flag = num7 != 0;
            num2 = 1;
            num1 = num2;
            continue;
label_47:
            flag = num4 != 0;
            num2 = 23;
            num1 = num2;
            continue;
label_59:
            flag = num5 != 0;
            num2 = 27;
            num1 = num2;
            continue;
label_63:
            num2 = 32;
            num1 = num2;
          }
label_67:
          return color;
      }
    }

    private void eval_b(object A_0, EventArgs A_1)
    {
label_0:
      int num1 = 0;
      int num2 = num1;
      switch (num2)
      {
        default:
          int num3;
          int index1;
          switch (0)
          {
            case 0:
label_3:
              num3 = 0;
              index1 = 0;
              num1 = 0;
              num1 = 14;
              num2 = num1;
              goto default;
            default:
              int index2;
              bool flag;
              int index3;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                  case 14:
                    flag = index1 < this.b;
                    num1 = 12;
                    num2 = num1;
                    continue;
                  case 1:
                  case 2:
                    this.ArrSched[index2 + 24 * index1] = num3;
                    num3 = 0;
                    ++index2;
                    num1 = 8;
                    num2 = num1;
                    continue;
                  case 3:
                    if (!flag)
                    {
                      num1 = 2;
                      num2 = num1;
                      continue;
                    }
                    flag = !(this.d[index2, index1].BackColor == this.eval_o[index3]);
                    num1 = 7;
                    num2 = num1;
                    continue;
                  case 4:
                    num3 = index3 + 1;
                    num1 = 1;
                    num2 = num1;
                    continue;
                  case 5:
                  case 11:
                    flag = index3 < this.eval_c;
                    num1 = 3;
                    num2 = num1;
                    continue;
                  case 6:
                    goto label_25;
                  case 7:
                    if (!flag)
                    {
                      num1 = 4;
                      num2 = num1;
                      continue;
                    }
                    ++index3;
                    num1 = 5;
                    num2 = num1;
                    continue;
                  case 8:
                    flag = index2 < this.eval_a;
                    num1 = 9;
                    num2 = num1;
                    continue;
                  case 9:
                    if (!flag)
                    {
                      num1 = 13;
                      num2 = num1;
                      continue;
                    }
                    index3 = 0;
                    num1 = 11;
                    num2 = num1;
                    continue;
                  case 10:
                    num1 = 1;
                    if (num1 == 0)
                      goto case 8;
                    else
                      goto case 8;
                  case 12:
                    if (flag)
                    {
                      index2 = 0;
                      num1 = 10;
                      num2 = num1;
                      continue;
                    }
                    num1 = 6;
                    num2 = num1;
                    continue;
                  case 13:
                    ++index1;
                    num1 = 0;
                    num2 = num1;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_25:
              num1 = -19204;
              int num4 = num1;
              num1 = -19204;
              int num5 = num1;
              switch (num4 == num5 ? 1 : 0)
              {
                case 0:
                case 2:
                  goto label_0;
                default:
                  num1 = 0;
                  if (num1 != 0)
                    ;
                  return;
              }
          }
      }
    }

    private void eval_a(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag;
      switch (0)
      {
        case 0:
label_5:
          flag = !this.eval_u.Checked;
          num1 = 10;
          num2 = num1;
          goto default;
        default:
          while (true)
          {
            num1 = -7718;
            int num3 = num1;
            num1 = -7718;
            int num4 = num1;
            int index1;
            switch (num3 == num4 ? 1 : 0)
            {
              case 0:
              case 2:
label_15:
                flag = index1 < this.b;
                num1 = 9;
                num2 = num1;
                continue;
              default:
                num1 = 1;
                if (num1 == 0)
                  ;
                num1 = 0;
                if (num1 == 0)
                  ;
                int index2;
                switch (num2)
                {
                  case 0:
                    index1 = 0;
                    num1 = 2;
                    num2 = num1;
                    continue;
                  case 1:
                    goto label_18;
                  case 2:
                  case 8:
                    goto label_15;
                  case 3:
                    this.eval_u.Checked = false;
                    num1 = 1;
                    num2 = num1;
                    continue;
                  case 4:
                    if (!flag)
                    {
                      num1 = 6;
                      num2 = num1;
                      continue;
                    }
                    this.d[index2, index1].BackColor = Color.FromArgb(73, 73, 73);
                    ++index2;
                    num1 = 7;
                    num2 = num1;
                    continue;
                  case 5:
                  case 7:
                    flag = index2 < this.eval_a;
                    num1 = 4;
                    num2 = num1;
                    continue;
                  case 6:
                    num1 = 0;
                    ++index1;
                    num1 = 8;
                    num2 = num1;
                    continue;
                  case 9:
                    if (flag)
                    {
                      index2 = 0;
                      num1 = 5;
                      num2 = num1;
                      continue;
                    }
                    num1 = 3;
                    num2 = num1;
                    continue;
                  case 10:
                    if (!flag)
                    {
                      num1 = 0;
                      num2 = num1;
                      continue;
                    }
                    goto label_20;
                  default:
                    goto label_5;
                }
            }
          }
label_18:
          break;
label_20:
          break;
      }
    }

    protected override void Dispose(bool disposing)
    {
      int num1 = 28600;
      int num2 = num1;
      num1 = 28600;
      int num3 = num1;
      int num4;
      int num5;
      switch (num2 == num3 ? 1 : 0)
      {
        case 0:
        case 2:
label_8:
          num5 = this.eval_p == null ? 1 : 0;
          goto label_10;
        default:
          num4 = 0;
          num4 = 0;
          if (num4 == 0)
            ;
          switch (0)
          {
            case 0:
              goto label_4;
          }
      }
label_3:
      int num6;
      bool flag;
      while (true)
      {
        switch (num6)
        {
          case 0:
            num4 = 4;
            num6 = num4;
            continue;
          case 1:
            goto label_14;
          case 2:
            goto label_15;
          case 3:
            if (disposing)
            {
              num4 = 0;
              num6 = num4;
              continue;
            }
            num4 = 1;
            num6 = num4;
            continue;
          case 4:
            goto label_8;
          case 5:
            this.eval_p.Dispose();
            num4 = 2;
            num6 = num4;
            continue;
          case 6:
            if (!flag)
            {
              num4 = 5;
              num6 = num4;
              continue;
            }
            goto label_15;
          default:
            goto label_4;
        }
      }
label_14:
      num5 = 1;
      goto label_10;
label_15:
      num4 = 1;
      if (num4 == 0)
        ;
      base.Dispose(disposing);
      return;
label_4:
      num4 = 3;
      num6 = num4;
      goto label_3;
label_10:
      flag = num5 != 0;
      num4 = 6;
      num6 = num4;
      goto label_3;
    }

    private void eval_a()
    {
      int num1 = 8532;
      int num2 = num1;
      num1 = 8532;
      int num3 = num1;
      int num4;
      switch (num2 == num3)
      {
        case true:
          num4 = 1;
          if (num4 == 0)
            ;
          num4 = 0;
          if (num4 == 0)
            ;
          this.eval_q = new Button();
          this.eval_r = new Button();
          this.eval_s = new Label();
          this.eval_t = new Label();
          this.eval_u = new CheckBox();
          this.SuspendLayout();
          this.eval_q.DialogResult = DialogResult.OK;
          this.eval_q.FlatStyle = FlatStyle.Flat;
          this.eval_q.ForeColor = Color.Silver;
          this.eval_q.Location = new Point(350, 190);
          this.eval_q.Name = "btn_SchedSave";
          this.eval_q.Size = new Size(85, 23);
          this.eval_q.TabIndex = 0;
          this.eval_q.Text = "Save";
          this.eval_q.UseVisualStyleBackColor = true;
          this.eval_q.Click += new EventHandler(this.eval_b);
          this.eval_r.DialogResult = DialogResult.Cancel;
          this.eval_r.FlatStyle = FlatStyle.Flat;
          this.eval_r.ForeColor = Color.Silver;
          this.eval_r.Location = new Point(441, 190);
          this.eval_r.Name = "btn_SchedCancel";
          this.eval_r.Size = new Size(55, 23);
          this.eval_r.TabIndex = 1;
          this.eval_r.Text = "Cancel";
          this.eval_r.UseVisualStyleBackColor = true;
          this.eval_r.Click += new EventHandler(this.eval_c);
          this.eval_s.AutoSize = true;
          this.eval_s.ForeColor = Color.FromArgb(224, 224, 224);
          this.eval_s.Location = new Point(-2, 161);
          this.eval_s.Name = "label1";
          this.eval_s.Size = new Size(37, 13);
          this.eval_s.TabIndex = 7;
          this.eval_s.Text = "Select";
          this.eval_t.AutoSize = true;
          this.eval_t.ForeColor = Color.FromArgb(224, 224, 224);
          this.eval_t.Location = new Point(-2, 170);
          this.eval_t.Name = "label2";
          this.eval_t.Size = new Size(49, 13);
          this.eval_t.TabIndex = 8;
          this.eval_t.Text = "account:";
          this.eval_u.AutoSize = true;
          this.eval_u.ForeColor = Color.Silver;
          this.eval_u.Location = new Point(12, 196);
          this.eval_u.Name = "chb_resetSch";
          this.eval_u.Size = new Size(100, 17);
          this.eval_u.TabIndex = 10;
          this.eval_u.Text = "Reset schedule";
          this.eval_u.UseVisualStyleBackColor = true;
          this.eval_u.CheckedChanged += new EventHandler(this.eval_a);
          this.AutoScaleMode = AutoScaleMode.None;
          this.BackColor = Color.FromArgb(49, 49, 49);
          this.ClientSize = new Size(510, 225);
          this.Controls.Add((Control) this.eval_u);
          this.Controls.Add((Control) this.eval_s);
          this.Controls.Add((Control) this.eval_r);
          this.Controls.Add((Control) this.eval_q);
          this.Controls.Add((Control) this.eval_t);
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.Name = "schedule";
          this.Text = "Schedule";
          this.Load += new EventHandler(this.eval_f);
          this.ResumeLayout(false);
          this.PerformLayout();
          break;
        default:
          num4 = 0;
          goto case 1;
      }
    }

    public struct Pos
    {
      public int I
      {
        get
        {
          int num1 = -8080;
          int num2 = num1;
          num1 = -8080;
          int num3 = num1;
          int num4;
          switch (num2 == num3 ? 1 : 0)
          {
            case 0:
            case 2:
              return num4;
            default:
              int num5 = 1;
              if (num5 == 0)
                ;
              num5 = 0;
              if (num5 == 0)
                ;
              num5 = 0;
              num4 = this.eval_a;
              goto case 0;
          }
        }
        set
        {
          int num1 = 25248;
          int num2 = num1;
          num1 = 25248;
          int num3 = num1;
          int num4;
          switch (num2 == num3)
          {
            case true:
              num4 = 0;
              if (num4 == 0)
                ;
              num4 = 1;
              if (num4 == 0)
                ;
              this.eval_a = value;
              break;
            default:
              num4 = 0;
              goto case 1;
          }
        }
      }

      public int J
      {
        get
        {
          int num1 = 11476;
          int num2 = num1;
          num1 = 11476;
          int num3 = num1;
          int num4;
          switch (num2 == num3 ? 1 : 0)
          {
            case 0:
            case 2:
              return num4;
            default:
              int num5 = 0;
              if (num5 == 0)
                ;
              num5 = 1;
              if (num5 == 0)
                ;
              num5 = 0;
              num4 = this.eval_b;
              goto case 0;
          }
        }
        set
        {
          int num1 = -20096;
          int num2 = num1;
          num1 = -20096;
          int num3 = num1;
          int num4;
          switch (num2 == num3)
          {
            case true:
              num4 = 1;
              if (num4 == 0)
                ;
              num4 = 0;
              if (num4 == 0)
                ;
              this.eval_b = value;
              break;
            default:
              num4 = 0;
              goto case 1;
          }
        }
      }

      public Pos(int i, int j)
      {
        this = new schedule.Pos();
        this.I = i;
        this.J = j;
      }
    }
  }
}
