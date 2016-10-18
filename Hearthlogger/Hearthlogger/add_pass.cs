// Decompiled with JetBrains decompiler
// Type: Hearthlogger.add_pass
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Hearthlogger
{
  public class add_pass : Form
  {
    private IContainer eval_a = (IContainer) null;
    private Label eval_b;
    public TextBox tb_Cname;
    private Label eval_c;
    private Label eval_d;
    public TextBox tb_Ulogin;
    public TextBox tb_Upass;
    private PictureBox eval_e;
    private Button eval_f;
    private Button eval_g;
    [NonSerialized]
    string eval_h;

    public add_pass(string[] args)
    {
      this.eval_a();
      this.tb_Ulogin.Text = args[0];
      this.tb_Upass.Text = "**********";
      this.tb_Cname.Text = args[2];
    }

    private void eval_c(object A_0, EventArgs A_1)
    {
      int num1 = 1;
      if (num1 == 0)
        ;
      num1 = 3460;
      int num2 = num1;
      num1 = 3460;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          if (num1 == 0)
            ;
          num1 = 0;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_b(object A_0, EventArgs A_1)
    {
      int num1 = 20963;
      int num2 = num1;
      num1 = 20963;
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
          break;
        default:
          goto case 1;
      }
    }

    private void eval_a(object A_0, EventArgs A_1)
    {
      int num1 = 8966;
      int num2 = num1;
      num1 = 8966;
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
          break;
        default:
          goto case 1;
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
          break;
        default:
          while (true)
          {
            bool flag;
            int num3;
            switch (num1)
            {
              case 0:
                num3 = 1;
                break;
              case 1:
                num2 = 0;
                num3 = this.eval_a == null ? 1 : 0;
                break;
              case 2:
                if (disposing)
                {
                  num2 = 5;
                  num1 = num2;
                  continue;
                }
                num2 = 0;
                num1 = num2;
                continue;
              case 3:
                if (!flag)
                {
                  num2 = 6;
                  num1 = num2;
                  continue;
                }
                goto label_15;
              case 4:
                goto label_15;
              case 5:
                num2 = 1;
                num1 = num2;
                continue;
              case 6:
                this.eval_a.Dispose();
                num2 = 4;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
            flag = num3 != 0;
            num2 = 3;
            num1 = num2;
          }
label_15:
          num2 = -11151;
          int num4 = num2;
          num2 = -11151;
          int num5 = num2;
          switch (num4 == num5 ? 1 : 0)
          {
            case 0:
            case 2:
              break;
            default:
              num2 = 0;
              if (num2 == 0)
                ;
              base.Dispose(disposing);
              return;
          }
      }
      num2 = 1;
      if (num2 == 0)
        ;
      num2 = 2;
      num1 = num2;
      goto default;
    }

    private void eval_a()
    {
      int num1 = 23951;
      int num2 = num1;
      num1 = 23951;
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
          ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (add_pass));
          this.eval_b = new Label();
          this.tb_Cname = new TextBox();
          this.eval_c = new Label();
          this.eval_d = new Label();
          this.tb_Ulogin = new TextBox();
          this.tb_Upass = new TextBox();
          this.eval_e = new PictureBox();
          this.eval_f = new Button();
          this.eval_g = new Button();
          ((ISupportInitialize) this.eval_e).BeginInit();
          this.SuspendLayout();
          this.eval_b.AutoSize = true;
          this.eval_b.ForeColor = Color.Orange;
          this.eval_b.Location = new Point(107, 55);
          this.eval_b.Name = "lbl_Cname";
          this.eval_b.Size = new Size(85, 13);
          this.eval_b.TabIndex = 0;
          this.eval_b.Text = "Character name:";
          this.tb_Cname.BackColor = Color.FromArgb(49, 49, 49);
          this.tb_Cname.BorderStyle = BorderStyle.FixedSingle;
          this.tb_Cname.ForeColor = Color.White;
          this.tb_Cname.Location = new Point(191, 52);
          this.tb_Cname.Name = "tb_Cname";
          this.tb_Cname.Size = new Size(180, 20);
          this.tb_Cname.TabIndex = 1;
          this.eval_c.AutoSize = true;
          this.eval_c.ForeColor = Color.Orange;
          this.eval_c.Location = new Point(107, 9);
          this.eval_c.Name = "lbl_Ulogin";
          this.eval_c.Size = new Size(36, 13);
          this.eval_c.TabIndex = 2;
          this.eval_c.Text = "Login:";
          this.eval_d.AutoSize = true;
          this.eval_d.ForeColor = Color.Orange;
          this.eval_d.Location = new Point(107, 32);
          this.eval_d.Name = "lbl_Upass";
          this.eval_d.Size = new Size(56, 13);
          this.eval_d.TabIndex = 3;
          this.eval_d.Text = "Password:";
          this.tb_Ulogin.BackColor = Color.FromArgb(49, 49, 49);
          this.tb_Ulogin.BorderStyle = BorderStyle.FixedSingle;
          this.tb_Ulogin.ForeColor = Color.White;
          this.tb_Ulogin.Location = new Point(141, 6);
          this.tb_Ulogin.Name = "tb_Ulogin";
          this.tb_Ulogin.Size = new Size(230, 20);
          this.tb_Ulogin.TabIndex = 4;
          this.tb_Upass.BackColor = Color.FromArgb(49, 49, 49);
          this.tb_Upass.BorderStyle = BorderStyle.FixedSingle;
          this.tb_Upass.ForeColor = Color.White;
          this.tb_Upass.Location = new Point(162, 29);
          this.tb_Upass.Name = "tb_Upass";
          this.tb_Upass.Size = new Size(209, 20);
          this.tb_Upass.TabIndex = 5;
          this.tb_Upass.TextChanged += new EventHandler(this.eval_a);
          this.eval_e.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
          this.eval_e.Location = new Point(6, 5);
          this.eval_e.Name = "pictureBox1";
          this.eval_e.Size = new Size(98, 96);
          this.eval_e.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_e.TabIndex = 8;
          this.eval_e.TabStop = false;
          this.eval_f.DialogResult = DialogResult.Cancel;
          this.eval_f.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_f.FlatStyle = FlatStyle.Flat;
          this.eval_f.ForeColor = Color.White;
          this.eval_f.Location = new Point(292, 80);
          this.eval_f.Name = "btn_PassCancel";
          this.eval_f.Size = new Size(79, 23);
          this.eval_f.TabIndex = 7;
          this.eval_f.Text = "Cancel";
          this.eval_f.UseVisualStyleBackColor = true;
          this.eval_f.Click += new EventHandler(this.eval_b);
          this.eval_g.DialogResult = DialogResult.OK;
          this.eval_g.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_g.FlatStyle = FlatStyle.Flat;
          this.eval_g.ForeColor = Color.White;
          this.eval_g.Location = new Point(110, 80);
          this.eval_g.Name = "btn_PassSave";
          this.eval_g.Size = new Size(176, 23);
          this.eval_g.TabIndex = 6;
          this.eval_g.Text = "Save";
          this.eval_g.UseVisualStyleBackColor = true;
          this.eval_g.Click += new EventHandler(this.eval_c);
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.BackColor = Color.FromArgb(49, 49, 49);
          this.ClientSize = new Size(377, 108);
          this.Controls.Add((Control) this.eval_e);
          this.Controls.Add((Control) this.eval_f);
          this.Controls.Add((Control) this.eval_g);
          this.Controls.Add((Control) this.tb_Upass);
          this.Controls.Add((Control) this.tb_Ulogin);
          this.Controls.Add((Control) this.eval_d);
          this.Controls.Add((Control) this.eval_c);
          this.Controls.Add((Control) this.tb_Cname);
          this.Controls.Add((Control) this.eval_b);
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
          this.Name = "add_pass";
          this.Text = "Battle.net info for changing accounts";
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
