// Decompiled with JetBrains decompiler
// Type: Hearthlogger.QuestLog
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hearthlogger
{
  public class QuestLog : Form
  {
    private IContainer eval_a = (IContainer) null;
    public string HearthstonePath;
    public bool useQuestLog;
    private CheckBox eval_b;
    private Button eval_c;
    private Button eval_d;
    private BindingSource eval_e;
    private Label eval_f;
    private Label eval_g;
    private Label eval_h;
    [NonSerialized]
    string eval_i;

    public QuestLog(string args)
    {
      this.eval_a();
      this.useQuestLog = args == "True" || args == "true";
      this.eval_b.Checked = this.useQuestLog;
    }

    private void eval_a(object A_0, EventArgs A_1)
    {
      int num1 = 11595;
      int num2 = num1;
      num1 = 11595;
      int num3 = num1;
      int num4;
      switch (num2 == num3 ? 1 : 0)
      {
        case 0:
        case 2:
label_9:
          num4 = 1;
          if (num4 != 0)
            break;
          break;
        default:
          num4 = 0;
          num4 = 0;
          if (num4 == 0)
            ;
          int num5;
          bool flag;
          switch (0)
          {
            case 0:
label_4:
              flag = !this.eval_b.Checked;
              num4 = 1;
              num5 = num4;
              goto default;
            default:
              while (true)
              {
                switch (num5)
                {
                  case 0:
                    goto label_7;
                  case 1:
                    if (!flag)
                    {
                      num4 = 3;
                      num5 = num4;
                      continue;
                    }
                    this.useQuestLog = false;
                    num4 = 2;
                    num5 = num4;
                    continue;
                  case 2:
                    goto label_9;
                  case 3:
                    this.useQuestLog = true;
                    num4 = 0;
                    num5 = num4;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_7:
              return;
          }
      }
    }

    protected override void Dispose(bool disposing)
    {
label_0:
      int num1;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          num2 = 0;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            bool flag;
            int num3;
            switch (num1)
            {
              case 0:
                if (disposing)
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                num2 = 2;
                num1 = num2;
                continue;
              case 1:
                if (!flag)
                {
                  num2 = 6;
                  num1 = num2;
                  continue;
                }
                goto label_16;
              case 2:
                num2 = -16846;
                int num4 = num2;
                num2 = -16846;
                int num5 = num2;
                switch (num4 == num5 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_0;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    num3 = 1;
                    break;
                }
              case 3:
                num2 = 4;
                num1 = num2;
                continue;
              case 4:
                num3 = this.eval_a == null ? 1 : 0;
                break;
              case 5:
                goto label_8;
              case 6:
                this.eval_a.Dispose();
                num2 = 5;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
            flag = num3 != 0;
            num2 = 1;
            num1 = num2;
          }
label_8:
          num2 = 1;
          if (num2 == 0)
            ;
label_16:
          base.Dispose(disposing);
          break;
      }
    }

    private void eval_a()
    {
      int num1 = -8016;
      int num2 = num1;
      num1 = -8016;
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
          this.eval_a = (IContainer) new Container();
          ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (QuestLog));
          this.eval_b = new CheckBox();
          this.eval_c = new Button();
          this.eval_d = new Button();
          this.eval_f = new Label();
          this.eval_g = new Label();
          this.eval_h = new Label();
          this.eval_e = new BindingSource(this.eval_a);
          ((ISupportInitialize) this.eval_e).BeginInit();
          this.SuspendLayout();
          this.eval_b.AutoSize = true;
          this.eval_b.ForeColor = Color.Orange;
          this.eval_b.Location = new Point(11, 10);
          this.eval_b.Name = "cb_useQuestLog";
          this.eval_b.Size = new Size(249, 17);
          this.eval_b.TabIndex = 0;
          this.eval_b.Text = "change account after complete all Daily Quests";
          this.eval_b.UseVisualStyleBackColor = true;
          this.eval_b.CheckedChanged += new EventHandler(this.eval_a);
          this.eval_c.DialogResult = DialogResult.Cancel;
          this.eval_c.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_c.FlatStyle = FlatStyle.Flat;
          this.eval_c.ForeColor = Color.White;
          this.eval_c.Location = new Point(174, 75);
          this.eval_c.Name = "btn_Qcancel";
          this.eval_c.Size = new Size(79, 23);
          this.eval_c.TabIndex = 8;
          this.eval_c.Text = "Cancel";
          this.eval_c.UseVisualStyleBackColor = true;
          this.eval_d.DialogResult = DialogResult.OK;
          this.eval_d.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_d.FlatStyle = FlatStyle.Flat;
          this.eval_d.ForeColor = Color.White;
          this.eval_d.Location = new Point(11, 75);
          this.eval_d.Name = "btn_Qsave";
          this.eval_d.Size = new Size(157, 23);
          this.eval_d.TabIndex = 9;
          this.eval_d.Text = "Save";
          this.eval_d.UseVisualStyleBackColor = true;
          this.eval_f.AutoSize = true;
          this.eval_f.ForeColor = Color.Gray;
          this.eval_f.Location = new Point(11, 30);
          this.eval_f.MaximumSize = new Size(250, 0);
          this.eval_f.Name = "label1";
          this.eval_f.Size = new Size(240, 13);
          this.eval_f.TabIndex = 1;
          this.eval_f.Text = "It works if you enabled the Quest plugin in the bot";
          this.eval_g.AutoSize = true;
          this.eval_g.ForeColor = Color.DarkGray;
          this.eval_g.Location = new Point(98, 43);
          this.eval_g.MaximumSize = new Size(250, 0);
          this.eval_g.Name = "label2";
          this.eval_g.Size = new Size(70, 13);
          this.eval_g.TabIndex = 10;
          this.eval_g.Text = "and checked";
          this.eval_h.AutoSize = true;
          this.eval_h.ForeColor = Color.Gray;
          this.eval_h.Location = new Point(39, 56);
          this.eval_h.MaximumSize = new Size(250, 0);
          this.eval_h.Name = "label3";
          this.eval_h.Size = new Size(183, 13);
          this.eval_h.TabIndex = 11;
          this.eval_h.Text = "\"Stop after all quests are completed\".";
          this.eval_e.DataSource = (object) typeof (QuestLog);
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.BackColor = Color.FromArgb(49, 49, 49);
          this.ClientSize = new Size(264, 108);
          this.Controls.Add((Control) this.eval_h);
          this.Controls.Add((Control) this.eval_g);
          this.Controls.Add((Control) this.eval_d);
          this.Controls.Add((Control) this.eval_c);
          this.Controls.Add((Control) this.eval_f);
          this.Controls.Add((Control) this.eval_b);
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
          this.Name = "QuestLog";
          this.Text = "QuestLog";
          ((ISupportInitialize) this.eval_e).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();
          break;
        default:
          goto case 1;
      }
    }
  }
}
