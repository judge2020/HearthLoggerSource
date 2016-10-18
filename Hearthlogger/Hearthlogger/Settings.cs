// Decompiled with JetBrains decompiler
// Type: Hearthlogger.Settings
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using Hearthlogger.Properties;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace Hearthlogger
{
  public class Settings : Form
  {
    private Stopwatch a = new Stopwatch();
    private IContainer eval_b = (IContainer) null;
    private Label eval_c;
    private Label eval_d;
    private Button eval_e;
    private Button eval_f;
    public NumericUpDown nUD_pauseBtwRestarts;
    private PictureBox eval_g;
    public CheckBox cb_resetTimers;
    public CheckBox cb_resetQuestDone;
    public NumericUpDown nUD_newBlizzDayTimeShift;
    private Label eval_h;
    private Label eval_i;
    public CheckBox cb_enableDebugLog;
    private ToolTip eval_j;
    public CheckBox cb_uniqueSettings;
    public NumericUpDown nUD_pauseBtwAttempts2;
    private Label eval_k;
    public NumericUpDown nUD_restartAttempts2;
    private Label eval_l;
    private Label eval_m;
    public NumericUpDown nUD_pauseBtwAttempts1;
    private Label eval_n;
    public NumericUpDown nUD_restartAttempts1;
    private Label eval_o;
    private Label eval_p;
    public NumericUpDown nUD_accNum;
    private Label eval_q;
    public CheckBox chb_moveGameAtStart;
    public NumericUpDown nUD_bnetStartTime;
    private Label eval_r;
    private Label eval_s;
    [NonSerialized]
    string eval_t;

    public Settings(int[] args)
    {
      this.eval_a();
      this.eval_a(args[0], this.nUD_pauseBtwRestarts);
      this.eval_a(args[1], this.nUD_newBlizzDayTimeShift);
      this.chb_moveGameAtStart.Checked = args[2] > 0;
      this.cb_uniqueSettings.Checked = args[4] > 0;
      this.eval_a(args[5], this.nUD_restartAttempts1);
      this.eval_a(args[6], this.nUD_pauseBtwAttempts1);
      this.eval_a(args[7], this.nUD_restartAttempts2);
      this.eval_a(args[8], this.nUD_pauseBtwAttempts2);
      this.eval_a(args[9], this.nUD_bnetStartTime);
      this.eval_a(args[10], this.nUD_accNum);
      this.cb_resetTimers.Checked = false;
      this.cb_resetQuestDone.Checked = false;
      if (!(this.nUD_newBlizzDayTimeShift.Value == new Decimal(1)))
        this.eval_h.Text = "hours.";
      else
        this.eval_h.Text = "hour.";
    }

    private void eval_a(int A_0, NumericUpDown A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !((Decimal) A_0 < A_1.Minimum);
          num2 = 2;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                A_1.Value = A_1.Minimum;
                num2 = 13871;
                int num3 = num2;
                num2 = 13871;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    num2 = 5;
                    num1 = num2;
                    continue;
                }
              case 1:
                A_1.Value = A_1.Maximum;
                num2 = 0;
                num2 = 4;
                num1 = num2;
                continue;
              case 2:
                if (!flag)
                {
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                flag = !((Decimal) A_0 > A_1.Maximum);
                num2 = 6;
                num1 = num2;
                continue;
              case 3:
                goto label_11;
              case 4:
                goto label_6;
              case 5:
                goto label_7;
              case 6:
                if (!flag)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                A_1.Value = (Decimal) A_0;
                break;
              default:
                goto label_2;
            }
            num2 = 3;
            num1 = num2;
          }
label_7:
          break;
label_11:
          break;
label_6:
          num2 = 1;
          if (num2 != 0)
            break;
          break;
      }
    }

    protected override void Dispose(bool disposing)
    {
      int num1;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          num2 = 12591;
          int num3 = num2;
          num2 = 12591;
          int num4 = num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              break;
            default:
              num2 = 0;
              if (num2 == 0)
                ;
              num2 = 6;
              num1 = num2;
              goto label_1;
          }
        default:
label_1:
          while (true)
          {
            bool flag;
            int num5;
            switch (num1)
            {
              case 0:
                num5 = this.eval_b == null ? 1 : 0;
                break;
              case 1:
                goto label_16;
              case 2:
                this.eval_b.Dispose();
                num2 = 1;
                num1 = num2;
                continue;
              case 3:
                num2 = 0;
                num1 = num2;
                continue;
              case 4:
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 0;
                num5 = 1;
                break;
              case 5:
                if (!flag)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                goto label_16;
              case 6:
                if (!disposing)
                {
                  num2 = 4;
                  num1 = num2;
                  continue;
                }
                goto label_6;
              default:
                goto label_2;
            }
            flag = num5 != 0;
            num2 = 5;
            num1 = num2;
          }
label_16:
          base.Dispose(disposing);
          return;
      }
label_6:
      num2 = 3;
      num1 = num2;
      goto default;
    }

    private void eval_a()
    {
      int num1 = -23301;
      int num2 = num1;
      num1 = -23301;
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
          this.eval_b = (IContainer) new Container();
          ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Settings));
          this.eval_c = new Label();
          this.eval_d = new Label();
          this.eval_e = new Button();
          this.eval_f = new Button();
          this.nUD_pauseBtwRestarts = new NumericUpDown();
          this.eval_g = new PictureBox();
          this.cb_resetTimers = new CheckBox();
          this.cb_resetQuestDone = new CheckBox();
          this.nUD_newBlizzDayTimeShift = new NumericUpDown();
          this.eval_h = new Label();
          this.eval_i = new Label();
          this.cb_enableDebugLog = new CheckBox();
          this.eval_j = new ToolTip(this.eval_b);
          this.cb_uniqueSettings = new CheckBox();
          this.nUD_accNum = new NumericUpDown();
          this.chb_moveGameAtStart = new CheckBox();
          this.nUD_pauseBtwAttempts2 = new NumericUpDown();
          this.eval_k = new Label();
          this.nUD_restartAttempts2 = new NumericUpDown();
          this.eval_l = new Label();
          this.eval_m = new Label();
          this.nUD_pauseBtwAttempts1 = new NumericUpDown();
          this.eval_n = new Label();
          this.nUD_restartAttempts1 = new NumericUpDown();
          this.eval_o = new Label();
          this.eval_p = new Label();
          this.eval_q = new Label();
          this.nUD_bnetStartTime = new NumericUpDown();
          this.eval_r = new Label();
          this.eval_s = new Label();
          this.nUD_pauseBtwRestarts.BeginInit();
          ((ISupportInitialize) this.eval_g).BeginInit();
          this.nUD_newBlizzDayTimeShift.BeginInit();
          this.nUD_accNum.BeginInit();
          this.nUD_pauseBtwAttempts2.BeginInit();
          this.nUD_restartAttempts2.BeginInit();
          this.nUD_pauseBtwAttempts1.BeginInit();
          this.nUD_restartAttempts1.BeginInit();
          this.nUD_bnetStartTime.BeginInit();
          this.SuspendLayout();
          this.eval_c.AutoSize = true;
          this.eval_c.ForeColor = Color.Orange;
          this.eval_c.Location = new Point(143, 12);
          this.eval_c.Name = "label2";
          this.eval_c.Size = new Size(121, 13);
          this.eval_c.TabIndex = 8;
          this.eval_c.Text = "Pause between restarts:";
          this.eval_d.AutoSize = true;
          this.eval_d.ForeColor = Color.Orange;
          this.eval_d.Location = new Point(297, 12);
          this.eval_d.Name = "label3";
          this.eval_d.Size = new Size(26, 13);
          this.eval_d.TabIndex = 10;
          this.eval_d.Text = "min.";
          this.eval_e.DialogResult = DialogResult.Cancel;
          this.eval_e.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_e.FlatStyle = FlatStyle.Flat;
          this.eval_e.ForeColor = Color.White;
          this.eval_e.Location = new Point(348, 175);
          this.eval_e.Name = "btn_PassCancel";
          this.eval_e.Size = new Size(121, 23);
          this.eval_e.TabIndex = 12;
          this.eval_e.Text = "Cancel";
          this.eval_e.UseVisualStyleBackColor = true;
          this.eval_f.DialogResult = DialogResult.OK;
          this.eval_f.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_f.FlatStyle = FlatStyle.Flat;
          this.eval_f.ForeColor = Color.White;
          this.eval_f.Location = new Point(6, 175);
          this.eval_f.Name = "btn_PassSave";
          this.eval_f.Size = new Size(336, 23);
          this.eval_f.TabIndex = 11;
          this.eval_f.Text = "Save";
          this.eval_f.UseVisualStyleBackColor = true;
          this.nUD_pauseBtwRestarts.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_pauseBtwRestarts.BorderStyle = BorderStyle.None;
          this.nUD_pauseBtwRestarts.ForeColor = Color.White;
          this.nUD_pauseBtwRestarts.Location = new Point(262, 12);
          this.nUD_pauseBtwRestarts.Name = "nUD_pauseBtwRestarts";
          this.nUD_pauseBtwRestarts.Size = new Size(35, 16);
          this.nUD_pauseBtwRestarts.TabIndex = 13;
          this.nUD_pauseBtwRestarts.TextAlign = HorizontalAlignment.Center;
          this.eval_j.SetToolTip((Control) this.nUD_pauseBtwRestarts, "If you often have a Max Sessions error - increase this value (default=0).");
          this.eval_g.Image = (Image) Resources.hl_settings;
          this.eval_g.Location = new Point(6, 8);
          this.eval_g.Name = "pictureBox1";
          this.eval_g.Size = new Size(132, 123);
          this.eval_g.TabIndex = 14;
          this.eval_g.TabStop = false;
          this.cb_resetTimers.AutoSize = true;
          this.cb_resetTimers.ForeColor = Color.White;
          this.cb_resetTimers.Location = new Point(337, 34);
          this.cb_resetTimers.Name = "cb_resetTimers";
          this.cb_resetTimers.Size = new Size(120, 17);
          this.cb_resetTimers.TabIndex = 16;
          this.cb_resetTimers.Text = "Reset current timers";
          this.cb_resetTimers.UseVisualStyleBackColor = true;
          this.cb_resetQuestDone.AutoSize = true;
          this.cb_resetQuestDone.ForeColor = Color.White;
          this.cb_resetQuestDone.Location = new Point(337, 52);
          this.cb_resetQuestDone.Name = "cb_resetQuestDone";
          this.cb_resetQuestDone.Size = new Size(105, 17);
          this.cb_resetQuestDone.TabIndex = 17;
          this.cb_resetQuestDone.Text = "Reset Quest info";
          this.cb_resetQuestDone.UseVisualStyleBackColor = true;
          this.nUD_newBlizzDayTimeShift.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_newBlizzDayTimeShift.BorderStyle = BorderStyle.None;
          this.nUD_newBlizzDayTimeShift.ForeColor = Color.White;
          this.nUD_newBlizzDayTimeShift.Location = new Point(277, 74);
          NumericUpDown numericUpDown1 = this.nUD_newBlizzDayTimeShift;
          int[] bits1 = new int[4];
          bits1[0] = 12;
          Decimal num5 = new Decimal(bits1);
          numericUpDown1.Maximum = num5;
          this.nUD_newBlizzDayTimeShift.Minimum = new Decimal(new int[4]
          {
            12,
            0,
            0,
            int.MinValue
          });
          this.nUD_newBlizzDayTimeShift.Name = "nUD_newBlizzDayTimeShift";
          this.nUD_newBlizzDayTimeShift.Size = new Size(35, 16);
          this.nUD_newBlizzDayTimeShift.TabIndex = 21;
          this.nUD_newBlizzDayTimeShift.TextAlign = HorizontalAlignment.Center;
          this.eval_j.SetToolTip((Control) this.nUD_newBlizzDayTimeShift, "Correction for reset timers and stats.");
          this.nUD_newBlizzDayTimeShift.Value = new Decimal(new int[4]
          {
            1,
            0,
            0,
            int.MinValue
          });
          this.eval_h.AutoSize = true;
          this.eval_h.ForeColor = Color.Orange;
          this.eval_h.Location = new Point(312, 74);
          this.eval_h.Name = "lbl_setting_BlizzHours";
          this.eval_h.Size = new Size(36, 13);
          this.eval_h.TabIndex = 20;
          this.eval_h.Text = "hours.";
          this.eval_i.AutoSize = true;
          this.eval_i.ForeColor = Color.Orange;
          this.eval_i.Location = new Point(143, 74);
          this.eval_i.Name = "label5";
          this.eval_i.Size = new Size(136, 13);
          this.eval_i.TabIndex = 19;
          this.eval_i.Text = "Daily Quest time correction:";
          this.cb_enableDebugLog.ForeColor = Color.Orange;
          this.cb_enableDebugLog.Location = new Point(146, 51);
          this.cb_enableDebugLog.Name = "cb_enableDebugLog";
          this.cb_enableDebugLog.Size = new Size(133, 18);
          this.cb_enableDebugLog.TabIndex = 32;
          this.cb_enableDebugLog.Text = "Enable Debug Log";
          this.eval_j.SetToolTip((Control) this.cb_enableDebugLog, "Save HearthloggerDebugLog.txt until the next restart.");
          this.cb_enableDebugLog.UseVisualStyleBackColor = true;
          this.cb_uniqueSettings.Enabled = false;
          this.cb_uniqueSettings.ForeColor = Color.Orange;
          this.cb_uniqueSettings.Location = new Point(146, 34);
          this.cb_uniqueSettings.Name = "cb_uniqueSettings";
          this.cb_uniqueSettings.Size = new Size(166, 17);
          this.cb_uniqueSettings.TabIndex = 33;
          this.cb_uniqueSettings.Text = "Enable Unique bot settings";
          this.eval_j.SetToolTip((Control) this.cb_uniqueSettings, "Allows to use your own Bot Settings and Custom Deck for each account.");
          this.cb_uniqueSettings.UseVisualStyleBackColor = true;
          this.nUD_accNum.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_accNum.BorderStyle = BorderStyle.None;
          this.nUD_accNum.ForeColor = Color.White;
          this.nUD_accNum.Location = new Point(437, 12);
          NumericUpDown numericUpDown2 = this.nUD_accNum;
          int[] bits2 = new int[4];
          bits2[0] = 25;
          Decimal num6 = new Decimal(bits2);
          numericUpDown2.Maximum = num6;
          NumericUpDown numericUpDown3 = this.nUD_accNum;
          int[] bits3 = new int[4];
          bits3[0] = 4;
          Decimal num7 = new Decimal(bits3);
          numericUpDown3.Minimum = num7;
          this.nUD_accNum.Name = "nUD_accNum";
          this.nUD_accNum.Size = new Size(35, 16);
          this.nUD_accNum.TabIndex = 50;
          this.nUD_accNum.TextAlign = HorizontalAlignment.Center;
          this.eval_j.SetToolTip((Control) this.nUD_accNum, "The number of Battle.net accounts (from 4 to 24).");
          NumericUpDown numericUpDown4 = this.nUD_accNum;
          int[] bits4 = new int[4];
          bits4[0] = 4;
          Decimal num8 = new Decimal(bits4);
          numericUpDown4.Value = num8;
          this.chb_moveGameAtStart.AutoSize = true;
          this.chb_moveGameAtStart.ForeColor = Color.White;
          this.chb_moveGameAtStart.Location = new Point(147, 93);
          this.chb_moveGameAtStart.Name = "chb_moveGameAtStart";
          this.chb_moveGameAtStart.Size = new Size(174, 17);
          this.chb_moveGameAtStart.TabIndex = 57;
          this.chb_moveGameAtStart.Text = "Move the game and bot at start";
          this.eval_j.SetToolTip((Control) this.chb_moveGameAtStart, "It also helps to accelerate the solving of some problems when the connection is broken.");
          this.chb_moveGameAtStart.UseVisualStyleBackColor = true;
          this.nUD_pauseBtwAttempts2.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_pauseBtwAttempts2.BorderStyle = BorderStyle.None;
          this.nUD_pauseBtwAttempts2.ForeColor = Color.White;
          this.nUD_pauseBtwAttempts2.Location = new Point(365, 155);
          NumericUpDown numericUpDown5 = this.nUD_pauseBtwAttempts2;
          int[] bits5 = new int[4];
          bits5[0] = 1400;
          Decimal num9 = new Decimal(bits5);
          numericUpDown5.Maximum = num9;
          this.nUD_pauseBtwAttempts2.Name = "nUD_pauseBtwAttempts2";
          this.nUD_pauseBtwAttempts2.Size = new Size(42, 16);
          this.nUD_pauseBtwAttempts2.TabIndex = 54;
          this.nUD_pauseBtwAttempts2.TextAlign = HorizontalAlignment.Center;
          NumericUpDown numericUpDown6 = this.nUD_pauseBtwAttempts2;
          int[] bits6 = new int[4];
          bits6[0] = 300;
          Decimal num10 = new Decimal(bits6);
          numericUpDown6.Value = num10;
          this.eval_k.AutoSize = true;
          this.eval_k.ForeColor = Color.Orange;
          this.eval_k.Location = new Point(407, 155);
          this.eval_k.Name = "label11";
          this.eval_k.Size = new Size(26, 13);
          this.eval_k.TabIndex = 53;
          this.eval_k.Text = "min.";
          this.nUD_restartAttempts2.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_restartAttempts2.BorderStyle = BorderStyle.None;
          this.nUD_restartAttempts2.ForeColor = Color.White;
          this.nUD_restartAttempts2.Location = new Point(202, 154);
          NumericUpDown numericUpDown7 = this.nUD_restartAttempts2;
          int[] bits7 = new int[4];
          bits7[0] = 30;
          Decimal num11 = new Decimal(bits7);
          numericUpDown7.Maximum = num11;
          this.nUD_restartAttempts2.Name = "nUD_restartAttempts2";
          this.nUD_restartAttempts2.Size = new Size(35, 16);
          this.nUD_restartAttempts2.TabIndex = 52;
          this.nUD_restartAttempts2.TextAlign = HorizontalAlignment.Center;
          NumericUpDown numericUpDown8 = this.nUD_restartAttempts2;
          int[] bits8 = new int[4];
          bits8[0] = 5;
          Decimal num12 = new Decimal(bits8);
          numericUpDown8.Value = num12;
          this.eval_l.AutoSize = true;
          this.eval_l.ForeColor = Color.Orange;
          this.eval_l.Location = new Point(239, 154);
          this.eval_l.Name = "label13";
          this.eval_l.Size = new Size(128, 13);
          this.eval_l.TabIndex = 51;
          this.eval_l.Text = "times in a row, take break";
          this.eval_m.AutoSize = true;
          this.eval_m.ForeColor = Color.Orange;
          this.eval_m.Location = new Point(4, 154);
          this.eval_m.Name = "label14";
          this.eval_m.Size = new Size(200, 13);
          this.eval_m.TabIndex = 50;
          this.eval_m.Text = "If after that HB (the game) also can't start";
          this.nUD_pauseBtwAttempts1.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_pauseBtwAttempts1.BorderStyle = BorderStyle.None;
          this.nUD_pauseBtwAttempts1.ForeColor = Color.White;
          this.nUD_pauseBtwAttempts1.Location = new Point(243, 137);
          NumericUpDown numericUpDown9 = this.nUD_pauseBtwAttempts1;
          int[] bits9 = new int[4];
          bits9[0] = 998;
          Decimal num13 = new Decimal(bits9);
          numericUpDown9.Maximum = num13;
          this.nUD_pauseBtwAttempts1.Name = "nUD_pauseBtwAttempts1";
          this.nUD_pauseBtwAttempts1.Size = new Size(36, 16);
          this.nUD_pauseBtwAttempts1.TabIndex = 49;
          this.nUD_pauseBtwAttempts1.TextAlign = HorizontalAlignment.Center;
          NumericUpDown numericUpDown10 = this.nUD_pauseBtwAttempts1;
          int[] bits10 = new int[4];
          bits10[0] = 70;
          Decimal num14 = new Decimal(bits10);
          numericUpDown10.Value = num14;
          this.eval_n.AutoSize = true;
          this.eval_n.ForeColor = Color.Orange;
          this.eval_n.Location = new Point(279, 137);
          this.eval_n.Name = "label12";
          this.eval_n.Size = new Size(26, 13);
          this.eval_n.TabIndex = 48;
          this.eval_n.Text = "min.";
          this.nUD_restartAttempts1.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_restartAttempts1.BorderStyle = BorderStyle.None;
          this.nUD_restartAttempts1.ForeColor = Color.White;
          this.nUD_restartAttempts1.Location = new Point(83, 136);
          NumericUpDown numericUpDown11 = this.nUD_restartAttempts1;
          int[] bits11 = new int[4];
          bits11[0] = 30;
          Decimal num15 = new Decimal(bits11);
          numericUpDown11.Maximum = num15;
          this.nUD_restartAttempts1.Name = "nUD_restartAttempts1";
          this.nUD_restartAttempts1.Size = new Size(35, 16);
          this.nUD_restartAttempts1.TabIndex = 47;
          this.nUD_restartAttempts1.TextAlign = HorizontalAlignment.Center;
          NumericUpDown numericUpDown12 = this.nUD_restartAttempts1;
          int[] bits12 = new int[4];
          bits12[0] = 7;
          Decimal num16 = new Decimal(bits12);
          numericUpDown12.Value = num16;
          this.eval_o.AutoSize = true;
          this.eval_o.ForeColor = Color.Orange;
          this.eval_o.Location = new Point(118, 136);
          this.eval_o.Name = "label4";
          this.eval_o.Size = new Size(128, 13);
          this.eval_o.TabIndex = 46;
          this.eval_o.Text = "times in a row, take break";
          this.eval_p.AutoSize = true;
          this.eval_p.ForeColor = Color.Orange;
          this.eval_p.Location = new Point(4, 136);
          this.eval_p.Name = "label10";
          this.eval_p.Size = new Size(80, 13);
          this.eval_p.TabIndex = 45;
          this.eval_p.Text = "If HB can't start";
          this.eval_q.AutoSize = true;
          this.eval_q.ForeColor = Color.Orange;
          this.eval_q.Location = new Point(334, 12);
          this.eval_q.Name = "label1";
          this.eval_q.Size = new Size(106, 13);
          this.eval_q.TabIndex = 55;
          this.eval_q.Text = "Number of accounts:";
          this.nUD_bnetStartTime.BackColor = Color.FromArgb(64, 64, 64);
          this.nUD_bnetStartTime.BorderStyle = BorderStyle.None;
          this.nUD_bnetStartTime.ForeColor = Color.White;
          this.nUD_bnetStartTime.Location = new Point(266, 115);
          NumericUpDown numericUpDown13 = this.nUD_bnetStartTime;
          int[] bits13 = new int[4];
          bits13[0] = 800;
          Decimal num17 = new Decimal(bits13);
          numericUpDown13.Maximum = num17;
          NumericUpDown numericUpDown14 = this.nUD_bnetStartTime;
          int[] bits14 = new int[4];
          bits14[0] = 10;
          Decimal num18 = new Decimal(bits14);
          numericUpDown14.Minimum = num18;
          this.nUD_bnetStartTime.Name = "nUD_bnetStartTime";
          this.nUD_bnetStartTime.Size = new Size(42, 16);
          this.nUD_bnetStartTime.TabIndex = 58;
          this.nUD_bnetStartTime.TextAlign = HorizontalAlignment.Center;
          NumericUpDown numericUpDown15 = this.nUD_bnetStartTime;
          int[] bits15 = new int[4];
          bits15[0] = 25;
          Decimal num19 = new Decimal(bits15);
          numericUpDown15.Value = num19;
          this.eval_r.AutoSize = true;
          this.eval_r.ForeColor = Color.Orange;
          this.eval_r.Location = new Point(308, 115);
          this.eval_r.Name = "label6";
          this.eval_r.Size = new Size(27, 13);
          this.eval_r.TabIndex = 60;
          this.eval_r.Text = "sec.";
          this.eval_s.AutoSize = true;
          this.eval_s.ForeColor = Color.Orange;
          this.eval_s.Location = new Point(145, 114);
          this.eval_s.Name = "label7";
          this.eval_s.Size = new Size(123, 13);
          this.eval_s.TabIndex = 59;
          this.eval_s.Text = "Wait until BNet is started";
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.BackColor = Color.FromArgb(49, 49, 49);
          this.ClientSize = new Size(476, 202);
          this.Controls.Add((Control) this.nUD_bnetStartTime);
          this.Controls.Add((Control) this.chb_moveGameAtStart);
          this.Controls.Add((Control) this.nUD_accNum);
          this.Controls.Add((Control) this.eval_q);
          this.Controls.Add((Control) this.nUD_pauseBtwAttempts2);
          this.Controls.Add((Control) this.eval_k);
          this.Controls.Add((Control) this.nUD_restartAttempts2);
          this.Controls.Add((Control) this.eval_l);
          this.Controls.Add((Control) this.eval_m);
          this.Controls.Add((Control) this.nUD_pauseBtwAttempts1);
          this.Controls.Add((Control) this.eval_n);
          this.Controls.Add((Control) this.nUD_restartAttempts1);
          this.Controls.Add((Control) this.eval_o);
          this.Controls.Add((Control) this.eval_p);
          this.Controls.Add((Control) this.cb_uniqueSettings);
          this.Controls.Add((Control) this.cb_enableDebugLog);
          this.Controls.Add((Control) this.nUD_newBlizzDayTimeShift);
          this.Controls.Add((Control) this.eval_h);
          this.Controls.Add((Control) this.eval_i);
          this.Controls.Add((Control) this.cb_resetQuestDone);
          this.Controls.Add((Control) this.cb_resetTimers);
          this.Controls.Add((Control) this.eval_g);
          this.Controls.Add((Control) this.nUD_pauseBtwRestarts);
          this.Controls.Add((Control) this.eval_e);
          this.Controls.Add((Control) this.eval_f);
          this.Controls.Add((Control) this.eval_d);
          this.Controls.Add((Control) this.eval_c);
          this.Controls.Add((Control) this.eval_s);
          this.Controls.Add((Control) this.eval_r);
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
          this.Name = "Settings";
          this.Text = "Settings                     (hold your mouse over the item for tips)";
          this.nUD_pauseBtwRestarts.EndInit();
          ((ISupportInitialize) this.eval_g).EndInit();
          this.nUD_newBlizzDayTimeShift.EndInit();
          this.nUD_accNum.EndInit();
          this.nUD_pauseBtwAttempts2.EndInit();
          this.nUD_restartAttempts2.EndInit();
          this.nUD_pauseBtwAttempts1.EndInit();
          this.nUD_restartAttempts1.EndInit();
          this.nUD_bnetStartTime.EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();
          break;
        default:
          goto case 1;
      }
    }
  }
}
