// Decompiled with JetBrains decompiler
// Type: Hearthlogger.Form1
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using Hearthlogger.Properties;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Hearthlogger
{
  public class Form1 : Form
  {
    private int eval_a = 1;
    private string eval_b = Environment.CurrentDirectory;
    private int c = 0;
    private int eval_d = 1;
    private int eval_e = 0;
    private int eval_f = 0;
    private int eval_g = 0;
    private int[] h = new int[5];
    private int[,] eval_i = new int[9, 2]
    {
      {
        197,
        193
      },
      {
        330,
        193
      },
      {
        470,
        193
      },
      {
        197,
        319
      },
      {
        330,
        319
      },
      {
        470,
        319
      },
      {
        197,
        446
      },
      {
        330,
        446
      },
      {
        470,
        446
      }
    };
    private int[,] eval_j = new int[6, 2]
    {
      {
        387,
        587
      },
      {
        371,
        148
      },
      {
        220,
        135
      },
      {
        115,
        135
      },
      {
        396,
        333
      },
      {
        411,
        333
      }
    };
    public string BNetPath = "";
    private int eval_p = 1;
    private int eval_q = 0;
    private int eval_r = 0;
    private bool eval_s = false;
    private string eval_v = "";
    private string eval_w = "";
    private string eval_x = "5";
    private Stopwatch eval_y = new Stopwatch();
    private Stopwatch z = new Stopwatch();
    private Stopwatch eval_aa = new Stopwatch();
    private int[] eval_ac = new int[168];
    private bool eval_ad = false;
    private int ae = 0;
    private int eval_af = 0;
    private string eval_ag = "unknown";
    private bool eval_ah = false;
    private string[] eval_ai = new string[1];
    private string eval_aj = "";
    private int eval_ak = 0;
    private int eval_al = 0;
    private int eval_am = 0;
    private int eval_an = -2;
    private bool ao = false;
    private int eval_ap = 0;
    private int eval_aq = 1;
    private int eval_ar = 0;
    private int eval_as = 0;
    private bool eval_at = true;
    private bool eval_au = true;
    private int eval_av = 0;
    private int eval_aw = 7;
    private int eval_ax = 5;
    private int eval_ay = 70;
    private int eval_az = 300;
    private int eval_a0 = 25;
    private bool eval_a1 = false;
    private string eval_a2 = "-";
    private string eval_a3 = "";
    private string eval_a4 = "";
    private string eval_a5 = "";
    private string eval_a6 = "";
    private string eval_a7 = "";
    private string eval_a8 = "";
    private int eval_a9 = 0;
    private int ba = -1;
    private int bb = 4;
    private IContainer eval_bm = (IContainer) null;
    private string[] eval_k;
    private string[,] eval_l;
    private string[] eval_m;
    private string[] eval_n;
    private string[] eval_o;
    private DateTime eval_t;
    private DateTime eval_u;
    private global::eval_d[] eval_ab;
    private RadioButton[] bc;
    private Button[] eval_bd;
    private Button[] eval_be;
    private PictureBox[] bf;
    private ComboBox[] bg;
    private Label[] bh;
    private Label[] bi;
    private Label[] bj;
    private Label[] bk;
    private Label[] bl;
    private PictureBox eval_bn;
    private GroupBox eval_bo;
    private Label bp;
    private Label eval_bq;
    private Label eval_br;
    private Button eval_bs;
    private System.Windows.Forms.Timer bt;
    private Label bu;
    private System.Windows.Forms.Timer eval_bv;
    private Label eval_bw;
    private Label eval_bx;
    private CheckBox eval_by;
    private PictureBox eval_bz;
    private Label eval_b0;
    private Label eval_b1;
    private Label b2;
    private ToolTip eval_b3;
    private CheckBox eval_b4;
    private Label eval_b5;
    private PictureBox eval_b6;
    private System.Windows.Forms.Timer eval_b7;
    private PictureBox eval_b8;
    private Label b9;
    private PictureBox eval_ca;
    private Panel eval_cb;
    private Button eval_cc;
    private Button eval_cd;
    private Button eval_ce;
    private Button eval_cf;
    private Label eval_cg;
    private Label eval_ch;
    private Label eval_ci;
    private Label eval_cj;
    private PictureBox eval_ck;
    private PictureBox eval_cl;
    private PictureBox eval_cm;
    private PictureBox eval_cn;
    private Label eval_co;
    private Label eval_cp;
    private Label eval_cq;
    private Label eval_cr;
    private Label eval_cs;
    private Label eval_ct;
    private Label eval_cu;
    private Label eval_cv;
    private Label cw;
    private Label cx;
    private Label cy;
    private Label cz;
    private Button eval_c0;
    private Button eval_c1;
    private Button eval_c2;
    private Label eval_c3;
    private Label eval_c4;
    private Label eval_c5;
    private Label eval_c6;
    private ComboBox c7;
    private ComboBox c8;
    private ComboBox c9;
    private ComboBox da;
    private ComboBox eval_db;
    private ComboBox eval_dc;
    private ComboBox eval_dd;
    private ComboBox eval_de;
    private Button eval_df;
    private RadioButton dg;
    private RadioButton dh;
    private RadioButton di;
    private RadioButton dj;
    private PictureBox eval_dk;
    private PictureBox eval_dl;
    [NonSerialized]
    string eval_dm;

    public Form1()
    {
      this.eval_a();
    }

    [DllImport("user32.dll")]
    private static extern IntPtr GetDC(IntPtr A_0);

    [DllImport("user32.dll")]
    private static extern int ReleaseDC(IntPtr A_0, IntPtr A_1);

    [DllImport("gdi32.dll")]
    private static extern uint GetPixel(IntPtr A_0, int A_1, int A_2);

    public ComboBox getcb_Deck(int pos)
    {
      int num1;
      int num2;
      int num3;
      switch (0)
      {
        case 0:
label_2:
          num2 = pos;
          num3 = 3;
          num1 = num3;
          goto default;
        default:
          ComboBox comboBox;
          while (true)
          {
            switch (num1)
            {
              case 0:
                num3 = 2;
                num1 = num3;
                continue;
              case 1:
              case 4:
                goto label_11;
              case 2:
                comboBox = this.eval_de;
                num3 = 4;
                num1 = num3;
                continue;
              case 3:
                num3 = 0;
                if (num2 != 1)
                {
                  num3 = 0;
                  num1 = num3;
                  continue;
                }
                num3 = -1182;
                int num4 = num3;
                num3 = -1182;
                int num5 = num3;
                switch (num4 == num5 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    num3 = 0;
                    if (num3 == 0)
                      ;
                    num3 = 1;
                    if (num3 == 0)
                      ;
                    comboBox = this.eval_de;
                    num3 = 1;
                    num1 = num3;
                    continue;
                }
              default:
                goto label_2;
            }
          }
label_11:
          return comboBox;
      }
    }

    private void eval_ag(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          Button button;
          int index;
          add_pass addPass;
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              button = (Button) A_0;
              index = Convert.ToInt32(button.Tag);
              addPass = new add_pass(new string[3]
              {
                this.eval_ab[index].a,
                this.eval_ab[index].b,
                this.eval_ab[index].eval_c
              });
              flag = addPass.ShowDialog() != DialogResult.OK;
              num2 = -25333;
              int num3 = num2;
              num2 = -25333;
              int num4 = num2;
              switch (num3 == num4 ? 1 : 0)
              {
                case 0:
                case 2:
                  goto label_3;
                default:
                  num2 = 0;
                  if (num2 == 0)
                    ;
                  num2 = 1;
                  if (num2 == 0)
                    ;
                  num2 = 2;
                  num1 = num2;
                  goto label_2;
              }
            default:
label_2:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    if (!flag)
                    {
                      num2 = 4;
                      num1 = num2;
                      continue;
                    }
                    goto case 5;
                  case 1:
                    this.eval_ab[index].a = addPass.tb_Ulogin.Text;
                    flag = !(addPass.tb_Upass.Text != "**********");
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 2:
                    if (!flag)
                    {
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    goto label_15;
                  case 3:
                    goto label_11;
                  case 4:
                    this.eval_ab[index].b = addPass.tb_Upass.Text;
                    num2 = 5;
                    num1 = num2;
                    continue;
                  case 5:
                    num2 = 0;
                    this.eval_ab[index].eval_c = addPass.tb_Cname.Text;
                    button.Text = this.eval_ab[index].eval_c;
                    this.eval_aa();
                    num2 = 3;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_11:
              return;
label_15:
              return;
          }
      }
    }

    private void eval_h(int A_0)
    {
      int num1 = -26069;
      int num2 = num1;
      num1 = -26069;
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
          this.bc[A_0] = new RadioButton();
          this.bc[A_0].Visible = true;
          this.bc[A_0].AutoSize = true;
          this.bc[A_0].FlatStyle = FlatStyle.Flat;
          this.bc[A_0].Tag = (object) A_0;
          this.bc[A_0].UseVisualStyleBackColor = true;
          this.bc[A_0].Size = new Size(13, 12);
          this.bc[A_0].Location = new Point(5, 5 + A_0 * 24);
          this.bc[A_0].CheckedChanged += new EventHandler(this.eval_aa);
          this.eval_cb.Controls.Add((Control) this.bc[A_0]);
          this.eval_bd[A_0] = new Button();
          this.eval_bd[A_0].Visible = true;
          this.eval_bd[A_0].ForeColor = Color.White;
          this.eval_bd[A_0].FlatAppearance.BorderColor = Color.DimGray;
          this.eval_bd[A_0].FlatStyle = FlatStyle.Flat;
          this.eval_bd[A_0].Margin = new Padding(0);
          this.eval_bd[A_0].Name = "btn_Pass" + (A_0 + 1).ToString();
          this.eval_bd[A_0].Tag = (object) A_0;
          this.eval_bd[A_0].UseVisualStyleBackColor = true;
          this.eval_bd[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.eval_bd[A_0].Text = A_0.ToString();
          this.eval_bd[A_0].Size = new Size(125, 23);
          this.eval_bd[A_0].Location = new Point(22, A_0 * 24);
          this.eval_bd[A_0].Click += new EventHandler(this.eval_ag);
          this.eval_cb.Controls.Add((Control) this.eval_bd[A_0]);
          this.eval_be[A_0] = new Button();
          this.eval_be[A_0].Visible = true;
          this.eval_be[A_0].ForeColor = Color.White;
          this.eval_be[A_0].FlatAppearance.BorderColor = Color.DimGray;
          this.eval_be[A_0].FlatStyle = FlatStyle.Flat;
          this.eval_be[A_0].Margin = new Padding(0);
          this.eval_be[A_0].Tag = (object) A_0;
          this.eval_be[A_0].UseVisualStyleBackColor = true;
          this.eval_be[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.eval_be[A_0].Text = A_0.ToString();
          this.eval_be[A_0].Size = new Size(25, 23);
          this.eval_be[A_0].Location = new Point(146, A_0 * 24);
          this.eval_be[A_0].Click += new EventHandler(this.eval_k);
          this.eval_cb.Controls.Add((Control) this.eval_be[A_0]);
          this.bf[A_0] = new PictureBox();
          ((ISupportInitialize) this.bf[A_0]).BeginInit();
          this.bf[A_0].Visible = this.eval_b4.Checked;
          this.bf[A_0].Enabled = this.eval_b4.Checked;
          this.bf[A_0].Image = (Image) Resources.shedule;
          this.bf[A_0].Size = new Size(31, 20);
          this.bf[A_0].SizeMode = PictureBoxSizeMode.AutoSize;
          this.bf[A_0].Location = new Point(183, 2 + A_0 * 24);
          this.bf[A_0].Click += new EventHandler(this.eval_o);
          this.bf[A_0].MouseEnter += new EventHandler(this.eval_n);
          this.bf[A_0].MouseLeave += new EventHandler(this.eval_m);
          ((ISupportInitialize) this.bf[A_0]).EndInit();
          this.eval_cb.Controls.Add((Control) this.bf[A_0]);
          this.bg[A_0] = new ComboBox();
          this.bg[A_0].Visible = true;
          this.bg[A_0].BackColor = Color.White;
          this.bg[A_0].ForeColor = Color.Black;
          this.bg[A_0].FormattingEnabled = true;
          this.bg[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.bg[A_0].Items.AddRange(new object[14]
          {
            (object) 0,
            (object) 1,
            (object) 2,
            (object) 3,
            (object) 4,
            (object) 5,
            (object) 6,
            (object) 7,
            (object) 8,
            (object) 10,
            (object) 12,
            (object) 15,
            (object) 20,
            (object) 24
          });
          this.bg[A_0].Tag = (object) A_0;
          this.bg[A_0].Text = "0";
          this.bg[A_0].Size = new Size(35, 21);
          this.bg[A_0].Location = new Point(182, A_0 * 24);
          this.bg[A_0].SelectedIndexChanged += new EventHandler(this.eval_ae);
          this.eval_cb.Controls.Add((Control) this.bg[A_0]);
          this.bh[A_0] = new Label();
          this.bh[A_0].Visible = true;
          this.bh[A_0].ForeColor = Color.Goldenrod;
          this.bh[A_0].BackColor = Color.Transparent;
          this.bh[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.bh[A_0].Text = "--:--";
          this.bh[A_0].TextAlign = ContentAlignment.MiddleCenter;
          this.bh[A_0].Size = new Size(34, 13);
          this.bh[A_0].Location = new Point(221, 4 + A_0 * 24);
          this.eval_cb.Controls.Add((Control) this.bh[A_0]);
          this.bi[A_0] = new Label();
          this.bi[A_0].ForeColor = Color.White;
          this.bi[A_0].Visible = true;
          this.bi[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.bi[A_0].Text = "-";
          this.bi[A_0].TextAlign = ContentAlignment.MiddleCenter;
          this.bi[A_0].Size = new Size(34, 13);
          this.bi[A_0].Location = new Point(252, 5 + A_0 * 24);
          this.eval_cb.Controls.Add((Control) this.bi[A_0]);
          this.bj[A_0] = new Label();
          this.bj[A_0].ForeColor = Color.White;
          this.bj[A_0].Visible = true;
          this.bj[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.bj[A_0].Text = "-";
          this.bj[A_0].TextAlign = ContentAlignment.MiddleCenter;
          this.bj[A_0].Size = new Size(27, 13);
          this.bj[A_0].Location = new Point(280, 5 + A_0 * 24);
          this.eval_cb.Controls.Add((Control) this.bj[A_0]);
          this.bk[A_0] = new Label();
          this.bk[A_0].ForeColor = Color.CornflowerBlue;
          this.bj[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.bk[A_0].Text = "-";
          this.bk[A_0].TextAlign = ContentAlignment.MiddleCenter;
          this.bk[A_0].Size = new Size(34, 13);
          this.bk[A_0].Location = new Point(301, 5 + A_0 * 24);
          this.eval_cb.Controls.Add((Control) this.bk[A_0]);
          this.bl[A_0] = new Label();
          this.bl[A_0].ForeColor = Color.Gold;
          this.bj[A_0].Font = new Font("Microsoft Sans Serif", 8f, FontStyle.Regular);
          this.bl[A_0].Margin = new Padding(0);
          this.bl[A_0].Text = "-";
          this.bl[A_0].TextAlign = ContentAlignment.MiddleCenter;
          this.bl[A_0].Size = new Size(38, 13);
          this.bl[A_0].Location = new Point(337, 5 + A_0 * 24);
          this.eval_cb.Controls.Add((Control) this.bl[A_0]);
          break;
        default:
          num4 = 0;
          goto case 1;
      }
    }

    private void eval_af(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          bool flag1;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              flag1 = Process.GetProcessesByName("Hearthlogger").Length <= 1;
              num2 = 38;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                string[] strArray1;
                string[] strArray2;
                string[] strArray3;
                int A_0_1;
                OpenFileDialog openFileDialog;
                int num3;
                switch (num1)
                {
                  case 0:
                    if (!flag1)
                    {
                      num2 = 16;
                      num1 = num2;
                      continue;
                    }
                    this.bb = Enumerable.Count<string>((IEnumerable<string>) strArray1) - 1;
                    strArray3 = strArray1[Enumerable.Count<string>((IEnumerable<string>) strArray1) - 1].Split('\t');
                    num2 = 49;
                    num1 = num2;
                    continue;
                  case 1:
                    flag1 = File.Exists(this.BNetPath);
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 2:
                    this.eval_f(101);
                    this.c = 1;
                    this.eval_aa.Start();
                    flag1 = !this.eval_ad;
                    num2 = 58;
                    num1 = num2;
                    continue;
                  case 3:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    if (!flag1)
                    {
                      num2 = 39;
                      num1 = num2;
                      continue;
                    }
                    goto case 13;
                  case 4:
                    flag1 = File.Exists(this.eval_x);
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 5:
                    int num4 = (int) MessageBox.Show("The Hearthlogger is already running", "Be attentive");
                    Application.Exit();
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 6:
                    if (!flag1)
                    {
                      num2 = 11;
                      num1 = num2;
                      continue;
                    }
                    goto case 2;
                  case 7:
                    flag1 = !File.Exists(this.eval_w);
                    num2 = 62;
                    num1 = num2;
                    continue;
                  case 8:
                    try
                    {
                      this.eval_ax = Convert.ToInt32(strArray3[11]);
                    }
                    catch
                    {
                    }
                    num1 = 37;
                    continue;
                  case 9:
                    this.eval_n[A_0_1] = this.eval_m[A_0_1 * 6 + 6];
                    num2 = 24;
                    num1 = num2;
                    continue;
                  case 10:
                    int num5 = (int) MessageBox.Show("Please move the Hearthlogger.exe to the folder where Hearthbuddy.exe", "Initialization...");
                    Application.Exit();
                    num2 = 36;
                    num1 = num2;
                    continue;
                  case 11:
                    int num6 = (int) MessageBox.Show("To work reloger need to select the path to the Battle.net Launcher.exe");
                    openFileDialog = new OpenFileDialog();
                    openFileDialog.InitialDirectory = "C:\\Program Files\\Battle.net\\";
                    openFileDialog.Title = "Select the Battle.net Launcher.exe";
                    openFileDialog.FileName = "Battle.net Launcher.exe";
                    openFileDialog.Filter = "Battle.net Launcher|Battle.net Launcher.exe";
                    flag1 = openFileDialog.ShowDialog() != DialogResult.OK;
                    num2 = 31;
                    num1 = num2;
                    continue;
                  case 12:
                    if (!flag1)
                    {
                      num2 = 10;
                      num1 = num2;
                      continue;
                    }
                    goto case 36;
                  case 13:
                    this.eval_ab = new global::eval_d[this.bb];
                    this.eval_n = new string[this.bb];
                    this.eval_o = new string[this.bb];
                    this.bc = new RadioButton[this.bb];
                    this.eval_bd = new Button[this.bb];
                    this.eval_be = new Button[this.bb];
                    this.bf = new PictureBox[this.bb];
                    this.bg = new ComboBox[this.bb];
                    this.bh = new Label[this.bb];
                    this.bi = new Label[this.bb];
                    this.bj = new Label[this.bb];
                    this.bk = new Label[this.bb];
                    this.bl = new Label[this.bb];
                    A_0_1 = 0;
                    num2 = 29;
                    num1 = num2;
                    continue;
                  case 14:
                    num2 = 0;
                    flag1 = strArray3.Length <= 8;
                    num2 = 42;
                    num1 = num2;
                    continue;
                  case 15:
                    try
                    {
                      this.eval_a0 = Convert.ToInt32(strArray3[13]);
                    }
                    catch
                    {
                    }
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 16:
                    this.bb = Convert.ToInt32(strArray2[2]);
                    strArray3 = strArray1[Enumerable.Count<string>((IEnumerable<string>) strArray1) - 2].Split('\t');
                    num2 = 20;
                    num1 = num2;
                    continue;
                  case 17:
                    this.eval_ah = strArray3[3] == "True" || strArray3[3] == "true";
                    this.eval_e();
                    num2 = 56;
                    num1 = num2;
                    continue;
                  case 18:
                    this.eval_x = this.eval_b + "\\Hearthbuddy.exe";
                    this.eval_a3 = this.eval_b + "\\Hearthlogger.db";
                    this.eval_a4 = this.eval_b + "\\Hearthlogger.log";
                    this.eval_a5 = this.eval_b + "\\HearthloggerDebugLog.txt";
                    this.eval_w = this.eval_b + "\\Hearthlogger.sch";
                    this.eval_a7 = this.eval_b + "\\HearthloggerTmpLog.html";
                    this.eval_a6 = this.eval_b + "\\Logs";
                    this.eval_a8 = this.eval_b + "\\CustomDecks\\Silverfish\\Data\\Silver.exe";
                    flag1 = Process.GetProcessesByName("Hearthlogger").GetLength(0) <= 1;
                    num2 = 90;
                    num1 = num2;
                    continue;
                  case 19:
                    num2 = 22;
                    num1 = num2;
                    continue;
                  case 20:
                  case 49:
                    this.eval_bo.Controls.Remove((Control) this.eval_cb);
                    this.eval_cb = new Panel();
                    this.eval_cb.Name = "panel_Controls";
                    this.eval_cb.Location = new Point(2, 53);
                    this.eval_cb.Size = new Size(this.eval_bo.Width - 4, 4 + this.bb * 24);
                    this.eval_bo.Controls.Add((Control) this.eval_cb);
                    num2 = 65;
                    num1 = num2;
                    continue;
                  case 21:
                    this.eval_ar = Convert.ToInt32(strArray3[8]);
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 22:
                    try
                    {
                      this.eval_ap = Convert.ToInt32(strArray3[2]);
                    }
                    catch (FormatException ex)
                    {
                      this.eval_ap = 0;
                    }
                    num1 = 17;
                    continue;
                  case 23:
                    ++A_0_1;
                    num2 = 59;
                    num1 = num2;
                    continue;
                  case 24:
                    flag1 = string.IsNullOrEmpty(this.eval_m[A_0_1 * 6 + 1]);
                    num2 = 83;
                    num1 = num2;
                    continue;
                  case 25:
                    num3 = this.eval_m.Length == this.bb * 6 + 1 ? 1 : 0;
                    break;
                  case 26:
                    this.eval_ad = false;
                    num2 = 81;
                    num1 = num2;
                    continue;
                  case 27:
                    File.Move(this.eval_b + "\\Archelogger.db", this.eval_a3);
                    num2 = 64;
                    num1 = num2;
                    continue;
                  case 28:
                    if (!flag1)
                    {
                      num2 = 9;
                      num1 = num2;
                      continue;
                    }
                    goto case 24;
                  case 29:
                  case 72:
                    flag1 = A_0_1 < this.bb;
                    num2 = 82;
                    num1 = num2;
                    continue;
                  case 30:
                  case 48:
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 31:
                    if (!flag1)
                    {
                      num2 = 92;
                      num1 = num2;
                      continue;
                    }
                    int num7 = (int) MessageBox.Show("Without specifying the path to the Battle.net Launcher.exe reloger will not work. \r\n\r\nStart reloger again and specify the correct path to the Battle.net Launcher.exe.", "Error...");
                    Application.Exit();
                    num2 = 30;
                    num1 = num2;
                    continue;
                  case 32:
                    num2 = 46;
                    num1 = num2;
                    continue;
                  case 33:
                    this.eval_ab[A_0_1].g = Convert.ToInt32(this.eval_m[A_0_1 * 6 + 4]);
                    num2 = 75;
                    num1 = num2;
                    continue;
                  case 34:
                    if (flag1)
                    {
                      this.eval_ad = true;
                      this.eval_b4.Checked = true;
                      num2 = 71;
                      num1 = num2;
                      continue;
                    }
                    num2 = 26;
                    num1 = num2;
                    continue;
                  case 35:
                    this.eval_ab[A_0_1].eval_h = Convert.ToInt32(this.eval_m[A_0_1 * 6 + 5]);
                    num2 = 80;
                    num1 = num2;
                    continue;
                  case 36:
                    flag1 = File.Exists(this.eval_a3);
                    num2 = 95;
                    num1 = num2;
                    continue;
                  case 37:
                    try
                    {
                      this.eval_az = Convert.ToInt32(strArray3[12]);
                    }
                    catch
                    {
                    }
                    num1 = 15;
                    continue;
                  case 38:
                    if (!flag1)
                    {
                      num2 = 60;
                      num1 = num2;
                      continue;
                    }
                    goto case 18;
                  case 39:
                    Array.Resize<string>(ref this.eval_m, this.bb * 6 + 1);
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 40:
                    num2 = 25;
                    num1 = num2;
                    continue;
                  case 41:
                    goto label_186;
                  case 42:
                    if (!flag1)
                    {
                      num2 = 32;
                      num1 = num2;
                      continue;
                    }
                    goto case 7;
                  case 43:
                    try
                    {
                      switch (0)
                      {
                        case 0:
label_93:
                          flag1 = !(strArray3[7] == "*");
                          num2 = 3;
                          num1 = num2;
                          goto default;
                        default:
                          while (true)
                          {
                            num2 = -2992;
                            int num8 = num2;
                            num2 = -2992;
                            int num9 = num2;
                            switch (num8 == num9 ? 1 : 0)
                            {
                              case 0:
                              case 2:
label_98:
                                num2 = 0;
                                num1 = num2;
                                continue;
                              default:
                                num2 = 0;
                                if (num2 == 0)
                                  ;
                                switch (num1)
                                {
                                  case 0:
                                    goto label_64;
                                  case 1:
                                  case 2:
                                    goto label_98;
                                  case 3:
                                    if (!flag1)
                                    {
                                      num2 = 4;
                                      num1 = num2;
                                      continue;
                                    }
                                    this.eval_a2 = "-";
                                    num2 = 1;
                                    num1 = num2;
                                    continue;
                                  case 4:
                                    this.eval_a2 = "*";
                                    num2 = 2;
                                    num1 = num2;
                                    continue;
                                  default:
                                    goto label_93;
                                }
                            }
                          }
                      }
                    }
                    catch
                    {
                    }
label_64:
                    num2 = 44;
                    num1 = num2;
                    continue;
                  case 44:
                    flag1 = strArray3.Length <= 7;
                    num2 = 91;
                    num1 = num2;
                    continue;
                  case 45:
                    this.eval_ak = Convert.ToInt32(strArray3[5]);
                    num2 = 54;
                    num1 = num2;
                    continue;
                  case 46:
                    try
                    {
                      this.eval_aw = Convert.ToInt32(strArray3[9]);
                    }
                    catch
                    {
                    }
                    num1 = 77;
                    continue;
                  case 47:
                    this.eval_ag = this.eval_m[A_0_1 * 6 + 1];
                    this.eval_o[A_0_1] = this.eval_ag;
                    this.eval_p = A_0_1;
                    this.eval_d();
                    this.eval_p = 0;
                    num2 = 23;
                    num1 = num2;
                    continue;
                  case 50:
                    num2 = 41;
                    num1 = num2;
                    continue;
                  case 51:
                    num3 = 0;
                    break;
                  case 52:
                    if (!flag1)
                    {
                      num2 = 50;
                      num1 = num2;
                      continue;
                    }
                    this.bf[A_0_1].Visible = true;
                    this.bg[A_0_1].Visible = false;
                    ++A_0_1;
                    num2 = 66;
                    num1 = num2;
                    continue;
                  case 53:
                    this.eval_ab[A_0_1].f = this.eval_m[A_0_1 * 6 + 3];
                    num2 = 73;
                    num1 = num2;
                    continue;
                  case 54:
                    try
                    {
                      switch (0)
                      {
                        case 0:
label_83:
                          flag1 = Convert.ToInt32(strArray3[6]) != 1;
                          num2 = 2;
                          num1 = num2;
                          goto default;
                        default:
                          while (true)
                          {
                            switch (num1)
                            {
                              case 0:
                                this.eval_as = 1;
                                num2 = 3;
                                num1 = num2;
                                continue;
                              case 1:
                                goto label_115;
                              case 2:
                                if (!flag1)
                                {
                                  num2 = 0;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 3;
                              case 3:
                                num2 = 1;
                                num1 = num2;
                                continue;
                              default:
                                goto label_83;
                            }
                          }
                      }
                    }
                    catch
                    {
                    }
label_115:
                    num1 = 43;
                    continue;
                  case 55:
                  case 59:
                    flag1 = A_0_1 < this.bb;
                    num2 = 74;
                    num1 = num2;
                    continue;
                  case 56:
                    try
                    {
                      this.eval_aq = Convert.ToInt32(strArray3[4]);
                    }
                    catch
                    {
                      this.eval_aq = 0;
                    }
                    flag1 = string.IsNullOrEmpty(strArray3[5]);
                    num2 = 93;
                    num1 = num2;
                    continue;
                  case 57:
                    num2 = 88;
                    num1 = num2;
                    continue;
                  case 58:
                    if (!flag1)
                    {
                      num2 = 68;
                      num1 = num2;
                      continue;
                    }
                    goto label_190;
                  case 60:
                    int num10 = (int) MessageBox.Show("The Hearthlogger is already running", "Be attentive");
                    Application.Exit();
                    num2 = 18;
                    num1 = num2;
                    continue;
                  case 61:
                    if (!flag1)
                    {
                      num2 = 35;
                      num1 = num2;
                      continue;
                    }
                    goto case 80;
                  case 62:
                    if (!flag1)
                    {
                      num2 = 57;
                      num1 = num2;
                      continue;
                    }
                    goto case 1;
                  case 63:
                    flag1 = strArray3.Length <= 4;
                    num2 = 67;
                    num1 = num2;
                    continue;
                  case 64:
                  case 85:
                    num2 = 79;
                    num1 = num2;
                    continue;
                  case 65:
                    if (this.eval_m != null)
                    {
                      num2 = 40;
                      num1 = num2;
                      continue;
                    }
                    num2 = 51;
                    num1 = num2;
                    continue;
                  case 66:
                  case 76:
                    flag1 = A_0_1 < this.bb;
                    num2 = 52;
                    num1 = num2;
                    continue;
                  case 67:
                    if (!flag1)
                    {
                      num2 = 19;
                      num1 = num2;
                      continue;
                    }
                    goto case 44;
                  case 68:
                    this.eval_bq.Text = "User\r\nschedule";
                    A_0_1 = 0;
                    num2 = 76;
                    num1 = num2;
                    continue;
                  case 69:
                    flag1 = !File.Exists(this.eval_b + "\\Archelogger.db");
                    num2 = 89;
                    num1 = num2;
                    continue;
                  case 70:
                    this.BNetPath = strArray3[0];
                    flag1 = strArray3.Length <= 1;
                    num2 = 84;
                    num1 = num2;
                    continue;
                  case 71:
                  case 81:
                    num2 = 63;
                    num1 = num2;
                    continue;
                  case 73:
                    flag1 = string.IsNullOrEmpty(this.eval_m[A_0_1 * 6 + 4]);
                    num2 = 86;
                    num1 = num2;
                    continue;
                  case 74:
                    if (!flag1)
                    {
                      num2 = 70;
                      num1 = num2;
                      continue;
                    }
                    this.eval_ab[A_0_1] = new global::eval_d(strArray1[A_0_1].Split('\t'));
                    this.eval_ab[A_0_1].f = "";
                    this.eval_ab[A_0_1].g = 0;
                    this.eval_ab[A_0_1].eval_h = 0;
                    flag1 = string.IsNullOrEmpty(this.eval_m[A_0_1 * 6 + 3]);
                    num2 = 94;
                    num1 = num2;
                    continue;
                  case 75:
                    flag1 = string.IsNullOrEmpty(this.eval_m[A_0_1 * 6 + 5]);
                    num2 = 61;
                    num1 = num2;
                    continue;
                  case 77:
                    try
                    {
                      this.eval_ay = Convert.ToInt32(strArray3[10]);
                    }
                    catch
                    {
                    }
                    num1 = 8;
                    continue;
                  case 78:
                    flag1 = !string.IsNullOrEmpty(strArray3[1]);
                    num2 = 34;
                    num1 = num2;
                    continue;
                  case 79:
                    this.eval_y();
                    strArray1 = global::eval_a.eval_a(File.ReadAllText(this.eval_a3), "THANK_YoU_apocdev)").Split(new string[1]
                    {
                      "\r\n"
                    }, StringSplitOptions.RemoveEmptyEntries);
                    strArray2 = strArray1[Enumerable.Count<string>((IEnumerable<string>) strArray1) - 1].Split('\t');
                    flag1 = !(strArray2[0] == "@@@");
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 80:
                    flag1 = string.IsNullOrEmpty(this.eval_m[A_0_1 * 6 + 6]);
                    num2 = 28;
                    num1 = num2;
                    continue;
                  case 82:
                    if (flag1)
                    {
                      this.eval_h(A_0_1);
                      ++A_0_1;
                      num2 = 72;
                      num1 = num2;
                      continue;
                    }
                    num2 = 87;
                    num1 = num2;
                    continue;
                  case 83:
                    if (!flag1)
                    {
                      num2 = 47;
                      num1 = num2;
                      continue;
                    }
                    goto case 23;
                  case 84:
                    if (!flag1)
                    {
                      num2 = 78;
                      num1 = num2;
                      continue;
                    }
                    goto case 63;
                  case 86:
                    if (!flag1)
                    {
                      num2 = 33;
                      num1 = num2;
                      continue;
                    }
                    goto case 75;
                  case 87:
                    this.Height = 155 + this.bb * 24;
                    this.eval_bo.Height = 61 + this.bb * 24;
                    CheckBox checkBox1 = this.eval_b4;
                    Point location = this.eval_b4.Location;
                    Point point1 = new Point(location.X, this.Height - 59);
                    checkBox1.Location = point1;
                    CheckBox checkBox2 = this.eval_by;
                    location = this.eval_by.Location;
                    Point point2 = new Point(location.X, this.Height - 59);
                    checkBox2.Location = point2;
                    Label label1 = this.b9;
                    location = this.b9.Location;
                    Point point3 = new Point(location.X, this.Height - 57);
                    label1.Location = point3;
                    Label label2 = this.eval_bx;
                    location = this.eval_bx.Location;
                    Point point4 = new Point(location.X, this.Height - 57);
                    label2.Location = point4;
                    Label label3 = this.eval_bw;
                    location = this.eval_bw.Location;
                    Point point5 = new Point(location.X, this.eval_bo.Height + 19);
                    label3.Location = point5;
                    this.eval_d(100);
                    A_0_1 = 0;
                    num2 = 55;
                    num1 = num2;
                    continue;
                  case 88:
                    try
                    {
                      switch (0)
                      {
                        case 0:
label_31:
                          this.eval_ac = Array.ConvertAll<string, int>(File.ReadAllText(this.eval_w).Split('\t'), new Converter<string, int>(Convert.ToInt32));
                          flag1 = this.eval_ac.Length == 168;
                          num2 = 17;
                          num1 = num2;
                          goto default;
                        default:
                          while (true)
                          {
                            bool flag2;
                            int num8;
                            switch (num1)
                            {
                              case 0:
                                this.eval_ac[A_0_1] = 0;
                                flag2 = true;
                                num2 = 2;
                                num1 = num2;
                                continue;
                              case 1:
                                flag2 = false;
                                A_0_1 = 0;
                                num2 = 6;
                                num1 = num2;
                                continue;
                              case 2:
                                ++A_0_1;
                                num2 = 3;
                                num1 = num2;
                                continue;
                              case 3:
                              case 6:
                                flag1 = A_0_1 < this.eval_ac.Length;
                                num2 = 13;
                                num1 = num2;
                                continue;
                              case 4:
                                if (!flag1)
                                {
                                  num2 = 5;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 12;
                              case 5:
                                this.eval_z();
                                num2 = 12;
                                num1 = num2;
                                continue;
                              case 7:
                                if (!flag1)
                                {
                                  num2 = 0;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 2;
                              case 8:
                                num8 = 0;
                                break;
                              case 9:
                                Array.Resize<int>(ref this.eval_ac, 168);
                                num2 = 1;
                                num1 = num2;
                                continue;
                              case 10:
                                num2 = 15;
                                num1 = num2;
                                continue;
                              case 11:
                                if (this.eval_ac[A_0_1] < 0)
                                {
                                  num2 = 8;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 10;
                                num1 = num2;
                                continue;
                              case 12:
                                num2 = 16;
                                num1 = num2;
                                continue;
                              case 13:
                                if (!flag1)
                                {
                                  num2 = 14;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 11;
                                num1 = num2;
                                continue;
                              case 14:
                                flag1 = !flag2;
                                num2 = 4;
                                num1 = num2;
                                continue;
                              case 15:
                                num8 = this.eval_ac[A_0_1] <= this.bb ? 1 : 0;
                                break;
                              case 16:
                                goto label_22;
                              case 17:
                                if (!flag1)
                                {
                                  num2 = 9;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 1;
                              default:
                                goto label_31;
                            }
                            flag1 = num8 != 0;
                            num2 = 7;
                            num1 = num2;
                          }
                      }
                    }
                    catch
                    {
                    }
label_22:
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 89:
                    if (flag1)
                    {
                      this.ac();
                      num2 = 85;
                      num1 = num2;
                      continue;
                    }
                    num2 = 27;
                    num1 = num2;
                    continue;
                  case 90:
                    if (!flag1)
                    {
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    goto case 4;
                  case 91:
                    if (!flag1)
                    {
                      num2 = 21;
                      num1 = num2;
                      continue;
                    }
                    goto case 14;
                  case 92:
                    this.BNetPath = openFileDialog.FileName;
                    this.eval_aa();
                    num2 = 48;
                    num1 = num2;
                    continue;
                  case 93:
                    if (!flag1)
                    {
                      num2 = 45;
                      num1 = num2;
                      continue;
                    }
                    goto case 54;
                  case 94:
                    if (!flag1)
                    {
                      num2 = 53;
                      num1 = num2;
                      continue;
                    }
                    goto case 73;
                  case 95:
                    if (!flag1)
                    {
                      num2 = 69;
                      num1 = num2;
                      continue;
                    }
                    goto case 79;
                  default:
                    goto label_3;
                }
                flag1 = num3 != 0;
                num2 = 3;
                num1 = num2;
              }
label_186:
              return;
label_190:
              return;
          }
      }
    }

    private void ac()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
label_1:
          string str;
          int num2;
          int num3;
          switch (0)
          {
            case 0:
label_3:
              str = "";
              num2 = 0;
              num3 = 2;
              num1 = num3;
              goto default;
            default:
              bool flag;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    goto label_11;
                  case 1:
                    num3 = 0;
                    flag = num2 < this.bb;
                    num3 = 3;
                    num1 = num3;
                    continue;
                  case 2:
                    num3 = 1;
                    if (num3 == 0)
                      goto case 1;
                    else
                      goto case 1;
                  case 3:
                    num3 = 4426;
                    int num4 = num3;
                    num3 = 4426;
                    int num5 = num3;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_1;
                      default:
                        num3 = 0;
                        if (num3 == 0)
                          ;
                        if (!flag)
                        {
                          num3 = 0;
                          num1 = num3;
                          continue;
                        }
                        str += this.eval_ab();
                        ++num2;
                        num3 = 1;
                        num1 = num3;
                        continue;
                    }
                  default:
                    goto label_3;
                }
              }
label_11:
              File.WriteAllText(this.eval_a3, global::eval_a.eval_b(str + (object) "C:\\Program Files\\Battle.net\\Battle.net Launcher.exe\\r\\n@@@\\t" + (string) (object) this.eval_a + "\t" + (string) (object) this.bb, "THANK_YoU_apocdev)"));
              int num6 = (int) MessageBox.Show("Welcome!\r\n\r\nThe first launch is detected. Hearthlogger.db was created.", "Initialization...");
              return;
          }
      }
    }

    private string eval_ab()
    {
      int num1 = -6171;
      int num2 = num1;
      num1 = -6171;
      int num3 = num1;
      string str;
      switch (num2 == num3 ? 1 : 0)
      {
        case 0:
        case 2:
          return str;
        default:
          int num4 = 0;
          if (num4 == 0)
            ;
          num4 = 1;
          if (num4 == 0)
            ;
          num4 = 0;
          str = "\t\t...\t1\t0\t--:--\r\n";
          goto case 0;
      }
    }

    private void eval_aa()
    {
      int num1;
      int num2;
      StringBuilder stringBuilder;
      int index;
      switch (0)
      {
        case 0:
label_2:
          num2 = 1;
          if (num2 == 0)
            ;
          stringBuilder = new StringBuilder("", 500);
          index = 0;
          break;
        default:
          bool flag;
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_22;
              case 1:
              case 7:
                flag = index < this.bb;
                num2 = 5;
                num1 = num2;
                continue;
              case 2:
                stringBuilder.Append(this.BNetPath).Append("\t");
                flag = !this.eval_ad;
                num2 = 6;
                num1 = num2;
                continue;
              case 3:
                if (!flag)
                {
                  num2 = 4;
                  num1 = num2;
                  continue;
                }
                stringBuilder.Append(this.eval_ab());
                num2 = 9;
                num1 = num2;
                continue;
              case 4:
                stringBuilder.Append(this.eval_ab[index].a).Append("\t").Append(this.eval_ab[index].b).Append("\t").Append(this.eval_ab[index].eval_c).Append("\t").Append(this.eval_ab[index].d).Append("\t").Append(this.eval_ab[index].eval_e).Append("\t").Append(this.eval_ab[index].f).Append("\t").Append(this.eval_ab[index].eval_i).Append("\r\n");
                num2 = 11;
                num1 = num2;
                continue;
              case 5:
                if (!flag)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                flag = index >= Enumerable.Count<global::eval_d>((IEnumerable<global::eval_d>) this.eval_ab);
                num2 = 3;
                num1 = num2;
                continue;
              case 6:
                if (!flag)
                {
                  num2 = 31526;
                  int num3 = num2;
                  num2 = 31526;
                  int num4 = num2;
                  switch (num3 == num4 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_4;
                    default:
                      num2 = 0;
                      if (num2 == 0)
                        ;
                      num2 = 10;
                      num1 = num2;
                      continue;
                  }
                }
                else
                {
                  stringBuilder.Append("");
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
              case 8:
                goto label_19;
              case 9:
              case 11:
                ++index;
                num2 = 1;
                num1 = num2;
                continue;
              case 10:
                stringBuilder.Append("1");
                num2 = 8;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_19:
          num2 = 0;
label_22:
          stringBuilder.Append("\t").Append(this.eval_ap).Append("\t").Append(this.eval_ah.ToString()).Append("\t").Append(this.eval_aq).Append("\t").Append(this.eval_ak).Append("\t").Append(this.eval_as).Append("\t").Append(this.eval_a2).Append("\t").Append(this.eval_ar);
          stringBuilder.Append("\t").Append(this.eval_aw).Append("\t").Append(this.eval_ay).Append("\t").Append(this.eval_ax).Append("\t").Append(this.eval_az).Append("\t").Append(this.eval_a0).Append("\r\n");
          stringBuilder.Append("@@@\t").Append(this.eval_a).Append("\t").Append(this.bb);
          File.WriteAllText(this.eval_a3, global::eval_a.eval_b(stringBuilder.ToString(), "THANK_YoU_apocdev)"));
          return;
      }
label_4:
      num2 = 7;
      num1 = num2;
      goto default;
    }

    private void eval_z()
    {
label_0:
      int num1;
      int num2;
      StringBuilder stringBuilder;
      int index;
      switch (0)
      {
        case 0:
label_2:
          num2 = -9544;
          int num3 = num2;
          num2 = -9544;
          int num4 = num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_0;
            case 1:
              num2 = 0;
              if (num2 == 0)
                ;
              num2 = 1;
              if (num2 == 0)
                ;
              stringBuilder = new StringBuilder("", 500);
              index = 0;
              num2 = 1;
              num1 = num2;
              goto label_1;
            default:
              num2 = 0;
              goto case 1;
          }
        default:
label_1:
          bool flag;
          while (true)
          {
            switch (num1)
            {
              case 0:
              case 1:
                flag = index < this.eval_ac.Length - 1;
                num2 = 2;
                num1 = num2;
                continue;
              case 2:
                if (!flag)
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                stringBuilder.Append(this.eval_ac[index]).Append("\t");
                ++index;
                num2 = 0;
                num1 = num2;
                continue;
              case 3:
                goto label_11;
              default:
                goto label_2;
            }
          }
label_11:
          stringBuilder.Append(this.eval_ac[index]);
          File.WriteAllText(this.eval_w, stringBuilder.ToString());
          break;
      }
    }

    private void eval_y()
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !File.Exists(this.eval_a4);
          num2 = 3;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_27;
              case 1:
                goto label_25;
              case 2:
                try
                {
                  switch (0)
                  {
                    case 0:
label_11:
                      this.eval_k = File.ReadAllLines(this.eval_a4);
                      flag = this.eval_k.Length <= 1;
                      num2 = 8;
                      num1 = num2;
                      goto default;
                    default:
                      while (true)
                      {
                        switch (num1)
                        {
                          case 0:
                          case 5:
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
                            goto case 0;
                          case 2:
                            goto label_6;
                          case 3:
                            this.eval_m = this.eval_k[this.eval_k.Length - 1].Split('\t');
                            num2 = 0;
                            num1 = num2;
                            continue;
                          case 4:
                            num2 = -29403;
                            int num3 = num2;
                            num2 = -29403;
                            int num4 = num2;
                            switch (num3 == num4 ? 1 : 0)
                            {
                              case 0:
                              case 2:
                                Array.Resize<string>(ref this.eval_k, this.eval_k.Length - 1);
                                num2 = 3;
                                num1 = num2;
                                continue;
                              default:
                                num2 = 0;
                                if (num2 == 0)
                                  goto case 0;
                                else
                                  goto case 0;
                            }
                          case 6:
                            Array.Resize<string>(ref this.eval_k, 2);
                            num2 = 5;
                            num1 = num2;
                            continue;
                          case 7:
                            flag = !(this.eval_k[this.eval_k.Length - 1] == "");
                            num2 = 9;
                            num1 = num2;
                            continue;
                          case 8:
                            if (!flag)
                            {
                              num2 = 7;
                              num1 = num2;
                              continue;
                            }
                            flag = this.eval_k.Length != 1;
                            num2 = 1;
                            num1 = num2;
                            continue;
                          case 9:
                            if (!flag)
                            {
                              num2 = 4;
                              num1 = num2;
                              continue;
                            }
                            goto case 3;
                          default:
                            goto label_11;
                        }
                      }
                  }
                }
                catch
                {
                }
label_6:
                num2 = 0;
                num1 = num2;
                continue;
              case 3:
                if (!flag)
                {
                  num2 = 1;
                  if (num2 == 0)
                    ;
                  num2 = 4;
                  num1 = num2;
                  continue;
                }
                File.WriteAllText(this.eval_a4, "134915");
                Array.Resize<string>(ref this.eval_k, 1);
                this.eval_k[0] = "134915";
                num2 = 1;
                num1 = num2;
                continue;
              case 4:
                num2 = 2;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_25:
          break;
label_27:
          break;
      }
    }

    private string eval_g(int A_0)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          double num2;
          string str1;
          int num3;
          switch (0)
          {
            case 0:
label_3:
              num2 = 0.0;
              str1 = "-";
              num3 = 0;
              num1 = num3;
              goto default;
            default:
              string str2;
              while (true)
              {
                bool flag;
                int num4;
                int num5;
                switch (num1)
                {
                  case 0:
                    if (!string.IsNullOrEmpty(this.eval_ab[A_0].f))
                    {
                      num3 = 0;
                      num3 = 9;
                      num1 = num3;
                      continue;
                    }
                    num3 = 1;
                    num1 = num3;
                    continue;
                  case 1:
                    num3 = 1;
                    if (num3 == 0)
                      ;
                    num4 = 1;
                    goto label_25;
                  case 2:
                    if (!flag)
                    {
                      num3 = 7;
                      num1 = num3;
                      continue;
                    }
                    goto case 10;
                  case 3:
                    num5 = 1;
                    goto label_16;
                  case 4:
                    goto label_30;
                  case 5:
                    num3 = 12438;
                    int num6 = num3;
                    num3 = 12438;
                    int num7 = num3;
                    switch (num6 == num7 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        num3 = 0;
                        if (num3 == 0)
                          ;
                        str1 = Math.Round(num2, 1).ToString();
                        num3 = 13;
                        num1 = num3;
                        continue;
                    }
                  case 6:
                    if (num2 <= 0.0)
                    {
                      num3 = 3;
                      num1 = num3;
                      continue;
                    }
                    num3 = 12;
                    num1 = num3;
                    continue;
                  case 7:
                    TimeSpan timeSpan = TimeSpan.Parse(this.eval_ab[A_0].f);
                    num2 = (double) (60 * this.eval_ab[A_0].g) / timeSpan.TotalMinutes;
                    num3 = 6;
                    num1 = num3;
                    continue;
                  case 8:
                    num5 = num2 >= 1000.0 ? 1 : 0;
                    goto label_16;
                  case 9:
                    num3 = 11;
                    num1 = num3;
                    continue;
                  case 10:
                    str2 = str1;
                    num3 = 4;
                    num1 = num3;
                    continue;
                  case 11:
                    num4 = !(this.eval_ab[A_0].f != "--:--") ? 1 : 0;
                    goto label_25;
                  case 12:
                    num3 = 8;
                    num1 = num3;
                    continue;
                  case 13:
                    break;
                  case 14:
                    if (!flag)
                    {
                      num3 = 5;
                      num1 = num3;
                      continue;
                    }
                    goto case 13;
                  default:
                    goto label_3;
                }
                num3 = 10;
                num1 = num3;
                continue;
label_16:
                flag = num5 != 0;
                num3 = 14;
                num1 = num3;
                continue;
label_25:
                flag = num4 != 0;
                num3 = 2;
                num1 = num3;
              }
label_30:
              return str2;
          }
      }
    }

    private void eval_f(int A_0)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = A_0 <= 100;
          break;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                if (!flag)
                {
                  num2 = 12;
                  num1 = num2;
                  continue;
                }
                num2 = 1;
                num1 = num2;
                continue;
              case 1:
                this.bh[A_0].Text = this.eval_ab[A_0].f == "" ? "--:--" : this.eval_ab[A_0].f;
                this.bi[A_0].Text = this.eval_ab[A_0].g.ToString();
                this.bj[A_0].Text = this.eval_ab[A_0].eval_h.ToString();
                this.bk[A_0].Text = this.eval_g(A_0);
                num2 = 8;
                num1 = num2;
                continue;
              case 2:
                this.eval_be[A_0].Enabled = this.eval_ar >= 1;
                this.getcb_Deck(A_0 + 1).Text = this.eval_ab[A_0].d.ToString();
                this.bg[A_0].Text = this.eval_ab[A_0].eval_e.ToString();
                num2 = 5;
                num1 = num2;
                continue;
              case 3:
                goto label_22;
              case 4:
              case 9:
                num2 = -25955;
                int num3 = num2;
                num2 = -25955;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_3;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    flag = A_0 < this.bb;
                    num2 = 11;
                    num1 = num2;
                    continue;
                }
              case 5:
                this.bh[A_0].Text = this.eval_ab[A_0].f == "" ? "--:--" : this.eval_ab[A_0].f;
                this.bi[A_0].Text = this.eval_ab[A_0].g.ToString();
                this.bj[A_0].Text = this.eval_ab[A_0].eval_h.ToString();
                this.bk[A_0].Text = this.eval_g(A_0);
                num2 = 7;
                num1 = num2;
                continue;
              case 6:
                this.bc[this.eval_p].Checked = true;
                this.eval_h((object) null, EventArgs.Empty);
                num2 = 3;
                num1 = num2;
                continue;
              case 7:
                this.bl[A_0].Text = this.eval_n[A_0] == null ? "-" : this.eval_n[A_0];
                ++A_0;
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 9;
                num1 = num2;
                continue;
              case 8:
                this.bl[A_0].Text = this.eval_n[A_0] == null ? "-" : this.eval_n[A_0];
                num2 = 10;
                num1 = num2;
                continue;
              case 10:
                goto label_21;
              case 11:
                if (flag)
                {
                  this.eval_bd[A_0].Text = this.eval_ab[A_0].eval_c;
                  this.eval_be[A_0].Text = this.eval_e(A_0);
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                num2 = 6;
                num1 = num2;
                continue;
              case 12:
                A_0 = 0;
                num2 = 4;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_21:
          return;
label_22:
          return;
      }
label_3:
      num2 = 0;
      num1 = num2;
      goto default;
    }

    private string eval_e(int A_0)
    {
label_0:
      int num1;
      int num2;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          num2 = 1;
          if (num2 == 0)
            ;
          flag = this.eval_ar >= 1;
          num2 = 0;
          num1 = num2;
          goto default;
        default:
          string str;
          while (true)
          {
            switch (num1)
            {
              case 0:
                if (!flag)
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                flag = !File.Exists(this.eval_b + "\\hrstore\\" + this.eval_ab[A_0].a.Replace("@", "") + "\\ok.txt");
                num2 = 2;
                num1 = num2;
                continue;
              case 1:
              case 6:
                goto label_14;
              case 2:
                if (!flag)
                {
                  num2 = 4;
                  num1 = num2;
                  continue;
                }
                str = "..";
                num2 = 1;
                num1 = num2;
                continue;
              case 3:
                str = "..";
                num2 = 6;
                num1 = num2;
                continue;
              case 4:
                str = "s";
                num2 = 5;
                num1 = num2;
                continue;
              case 5:
                goto label_7;
              default:
                goto label_2;
            }
          }
label_7:
          num2 = -25429;
          int num3 = num2;
          num2 = -25429;
          int num4 = num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_0;
            default:
              num2 = 0;
              if (num2 == 0)
                break;
              break;
          }
label_14:
          num2 = 0;
          return str;
      }
    }

    private void eval_ae(object A_0, EventArgs A_1)
    {
      int num1;
      int index;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          index = Convert.ToInt32(((Control) A_0).Tag);
          flag = this.c != 0;
          num1 = 1;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                num1 = 2;
                continue;
              case 1:
                if (!flag)
                {
                  num1 = 0;
                  continue;
                }
                this.eval_ab[index].eval_e = Convert.ToInt32(this.bg[index].Text);
                this.eval_aa();
                num1 = 3;
                continue;
              case 2:
              case 3:
                goto label_8;
              default:
                goto label_2;
            }
          }
label_8:
          switch (31532 == 31532 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_8;
            default:
              int num2 = 1;
              if (num2 == 0)
                ;
              num2 = 0;
              if (num2 != 0)
                ;
              return;
          }
      }
    }

    private void eval_ad(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          this.eval_g();
          this.eval_au = true;
          this.eval_av = 0;
          flag = !(this.eval_bs.Text == "Start tracking");
          num2 = 7;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                this.eval_a("HL: Start pressed");
                num2 = 5;
                num1 = num2;
                continue;
              case 1:
                this.eval_a("HL: Stop pressed");
                num2 = 2;
                num1 = num2;
                continue;
              case 2:
                num2 = 0;
                this.eval_bs.Text = "Start tracking";
                this.eval_a(true);
                this.eval_d = 1;
                this.bt.Enabled = false;
                this.eval_b7.Enabled = false;
                this.eval_y.Stop();
                this.eval_aa.Restart();
                this.eval_bw.Visible = true;
                this.bu.Text = "...";
                break;
              case 3:
                goto label_20;
              case 4:
                flag = !this.eval_at;
                num2 = 6;
                num1 = num2;
                continue;
              case 5:
                this.eval_bs.Text = "Stop tracking";
                this.eval_a(false);
                this.eval_d = 0;
                this.eval_y.Start();
                this.eval_aa.Stop();
                this.eval_bw.Visible = false;
                this.c = 2;
                this.eval_i();
                this.bt.Enabled = true;
                this.eval_b7.Enabled = true;
                num2 = -26547;
                int num3 = num2;
                num2 = -26547;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    num2 = 9;
                    num1 = num2;
                    continue;
                }
              case 6:
                if (!flag)
                {
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                goto case 5;
              case 7:
                if (!flag)
                {
                  num2 = 4;
                  num1 = num2;
                  continue;
                }
                flag = !this.eval_at;
                num2 = 8;
                num1 = num2;
                continue;
              case 8:
                if (!flag)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                goto case 2;
              case 9:
                goto label_16;
              default:
                goto label_2;
            }
            num2 = 3;
            num1 = num2;
          }
label_16:
          break;
label_20:
          break;
      }
    }

    private void eval_a(bool A_0)
    {
      int num1;
      int num2;
      int index;
      switch (0)
      {
        case 0:
label_4:
          num1 = 0;
          index = 0;
          num1 = 2;
          num2 = num1;
          goto default;
        default:
          while (true)
          {
            num1 = 15164;
            int num3 = num1;
            num1 = 15164;
            int num4 = num1;
            switch (num3 == num4 ? 1 : 0)
            {
              case 0:
              case 2:
label_14:
                num1 = 4;
                num2 = num1;
                continue;
              default:
                num1 = 0;
                if (num1 == 0)
                  ;
                bool flag;
                switch (num2)
                {
                  case 0:
                    if (!flag)
                    {
                      num1 = 3;
                      num2 = num1;
                      continue;
                    }
                    goto label_16;
                  case 1:
                  case 2:
                    flag = index < this.bb;
                    num1 = 5;
                    num2 = num1;
                    continue;
                  case 3:
                    this.bh[this.eval_p].Enabled = true;
                    this.bc[this.eval_p].Enabled = true;
                    this.bf[this.eval_p].Image = (Image) Resources.shedule;
                    num1 = 6;
                    num2 = num1;
                    continue;
                  case 4:
                    flag = A_0;
                    num1 = 0;
                    num2 = num1;
                    continue;
                  case 5:
                    if (flag)
                    {
                      this.eval_bd[index].Enabled = A_0;
                      this.getcb_Deck(index + 1).Enabled = false;
                      this.bg[index].Enabled = A_0;
                      this.bh[index].Enabled = A_0;
                      this.bc[index].Enabled = A_0;
                      this.bf[index].Enabled = A_0;
                      num1 = 7;
                      num2 = num1;
                      continue;
                    }
                    goto label_14;
                  case 6:
                    goto label_16;
                  case 7:
                    this.bf[index].Image = A_0 ? (Image) Resources.shedule : (Image) Resources.sheduleOff;
                    ++index;
                    num1 = 1;
                    num2 = num1;
                    continue;
                  default:
                    goto label_4;
                }
            }
          }
label_16:
          num1 = 1;
          if (num1 != 0)
            break;
          break;
      }
    }

    private void eval_ac(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          this.bt.Enabled = false;
          flag = this.eval_r != 1;
          num2 = 4;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            int num3;
            switch (num1)
            {
              case 0:
                this.eval_d("timer");
                this.eval_r = 0;
                num2 = 12;
                num1 = num2;
                continue;
              case 1:
                if (!flag)
                {
                  num2 = 10;
                  num1 = num2;
                  continue;
                }
                this.eval_j();
                flag = this.eval_f != 0;
                num2 = 15;
                num1 = num2;
                continue;
              case 2:
              case 8:
                goto label_29;
              case 3:
                this.eval_v();
                num2 = 0;
                num2 = 11;
                num1 = num2;
                continue;
              case 4:
                if (!flag)
                {
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                goto case 12;
              case 5:
                this.eval_d = 0;
                num2 = 13;
                num1 = num2;
                continue;
              case 6:
                num2 = 14;
                num1 = num2;
                continue;
              case 7:
                if (this.eval_f == 0)
                {
                  num2 = 9;
                  num1 = num2;
                  continue;
                }
                num2 = 6;
                num1 = num2;
                continue;
              case 9:
                num3 = 0;
                break;
              case 10:
                num2 = 1;
                if (num2 == 0)
                  ;
                this.eval_x();
                flag = this.eval_e != 0;
                num2 = 16;
                num1 = num2;
                continue;
              case 11:
                num2 = 2;
                num1 = num2;
                continue;
              case 12:
                num2 = 7;
                num1 = num2;
                continue;
              case 13:
label_19:
                num2 = 8;
                num1 = num2;
                continue;
              case 14:
                num3 = !this.eval_s ? 1 : 0;
                break;
              case 15:
                if (!flag)
                {
                  num2 = 5;
                  num1 = num2;
                  continue;
                }
                goto case 13;
              case 16:
                if (!flag)
                {
                  num2 = -2556;
                  int num4 = num2;
                  num2 = -2556;
                  int num5 = num2;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_19;
                    default:
                      num2 = 0;
                      if (num2 == 0)
                        ;
                      num2 = 3;
                      num1 = num2;
                      continue;
                  }
                }
                else
                  goto case 11;
              default:
                goto label_2;
            }
            flag = num3 != 0;
            num2 = 1;
            num1 = num2;
          }
label_29:
          this.bt.Enabled = true;
          break;
      }
    }

    private void eval_x()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              flag = !this.eval_ad;
              num2 = 42;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                int num3;
                string A_0;
                string str1;
                string str2;
                int num4;
                switch (num1)
                {
                  case 0:
                    goto label_145;
                  case 1:
                    if (this.eval_b(this.ba))
                    {
                      num2 = 19;
                      num1 = num2;
                      continue;
                    }
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 2:
                    this.eval_bv.Enabled = false;
                    this.eval_b7.Enabled = false;
                    this.eval_bw.Visible = true;
                    flag = !this.eval_au;
                    num2 = 75;
                    num1 = num2;
                    continue;
                  case 3:
                    if (!flag)
                    {
                      num2 = 41;
                      num1 = num2;
                      continue;
                    }
                    goto case 49;
                  case 4:
                    num2 = 58;
                    num1 = num2;
                    continue;
                  case 5:
                    num2 = 70;
                    num1 = num2;
                    continue;
                  case 6:
                  case 86:
                    this.eval_bv.Enabled = true;
                    this.eval_b7.Enabled = true;
                    this.eval_bw.Visible = false;
                    this.ao = false;
                    num2 = 23;
                    num1 = num2;
                    continue;
                  case 7:
                    if (!flag)
                    {
                      num2 = 37;
                      num1 = num2;
                      continue;
                    }
                    flag = this.eval_w().LastIndexOf("[Quest] Now stopping the bot") <= 0;
                    num2 = 29;
                    num1 = num2;
                    continue;
                  case 8:
                    if (flag)
                    {
                      flag = this.eval_d != 1;
                      num2 = 91;
                      num1 = num2;
                      continue;
                    }
                    num2 = 79;
                    num1 = num2;
                    continue;
                  case 9:
                    if (!flag)
                    {
                      num2 = 26;
                      num1 = num2;
                      continue;
                    }
                    goto case 85;
                  case 10:
                    if (flag)
                    {
                      global::eval_e.SetForegroundWindow(Process.GetProcessesByName("Hearthstone")[0].MainWindowHandle);
                      flag = !this.eval_ah;
                      num2 = 24;
                      num1 = num2;
                      continue;
                    }
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 11:
                    if (!this.eval_b(this.ba))
                    {
                      num2 = 4;
                      num1 = num2;
                      continue;
                    }
                    goto case 88;
                  case 12:
                    num2 = 76;
                    num1 = num2;
                    continue;
                  case 13:
                    num2 = 59;
                    num1 = num2;
                    continue;
                  case 14:
                    num2 = 45;
                    num1 = num2;
                    continue;
                  case 15:
                    num2 = 22;
                    num1 = num2;
                    continue;
                  case 16:
                  case 51:
                    flag = num3 < 4;
                    num2 = 87;
                    num1 = num2;
                    continue;
                  case 17:
                    if (this.eval_b(this.ba))
                    {
                      num2 = 74;
                      num1 = num2;
                      continue;
                    }
                    num2 = 61;
                    num1 = num2;
                    continue;
                  case 18:
                    if (!flag)
                    {
                      num2 = 25;
                      num1 = num2;
                      continue;
                    }
                    goto case 14;
                  case 19:
                    str1 = "";
                    break;
                  case 20:
                    goto label_143;
                  case 21:
                    goto label_141;
                  case 22:
                    goto label_137;
                  case 23:
                  case 45:
                    flag = this.eval_d != 1;
                    num2 = 34;
                    num1 = num2;
                    continue;
                  case 24:
                    if (!flag)
                    {
                      num2 = 38;
                      num1 = num2;
                      continue;
                    }
                    goto case 57;
                  case 25:
                    this.c(this.eval_ap * 60 * 1000);
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 26:
                    num3 = 1;
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 27:
                    this.eval_e = 0;
                    num2 = 83;
                    num1 = num2;
                    continue;
                  case 28:
                    if (flag)
                    {
                      this.eval_bs.Text = "Delay " + this.eval_ap.ToString() + " min...";
                      flag = this.eval_ap == 0;
                      num2 = 18;
                      num1 = num2;
                      continue;
                    }
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 29:
label_101:
                    if (!flag)
                    {
                      num2 = 30;
                      num1 = num2;
                      continue;
                    }
                    goto case 27;
                  case 30:
                    flag = !this.eval_at;
                    num2 = 82;
                    num1 = num2;
                    continue;
                  case 31:
                  case 69:
                    flag = this.eval_d != 1;
                    num2 = 90;
                    num1 = num2;
                    continue;
                  case 32:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    if (flag)
                    {
                      flag = this.eval_d != 1;
                      num2 = 43;
                      num1 = num2;
                      continue;
                    }
                    num2 = 65;
                    num1 = num2;
                    continue;
                  case 33:
                    num2 = -20998;
                    int num5 = num2;
                    num2 = -20998;
                    int num6 = num2;
                    switch (num5 == num6 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_101;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        this.eval_s();
                        num2 = 69;
                        num1 = num2;
                        continue;
                    }
                  case 34:
                    if (!flag)
                    {
                      num2 = 60;
                      num1 = num2;
                      continue;
                    }
                    this.eval_bs.Text = "Wait... Reload";
                    this.eval_o();
                    flag = Process.GetProcessesByName("Battle.net").Length >= 1;
                    num2 = 32;
                    num1 = num2;
                    continue;
                  case 35:
                    this.eval_au = true;
                    this.eval_av = 0;
                    num2 = 84;
                    num1 = num2;
                    continue;
                  case 36:
                    this.eval_s = true;
                    num2 = 54;
                    num1 = num2;
                    continue;
                  case 37:
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 38:
                    num2 = 57;
                    num1 = num2;
                    continue;
                  case 39:
                    str2 = " did";
                    goto label_73;
                  case 40:
                    num2 = 27;
                    num1 = num2;
                    continue;
                  case 41:
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 42:
                    if (!flag)
                    {
                      num2 = 33;
                      num1 = num2;
                      continue;
                    }
                    this.eval_r();
                    num2 = 31;
                    num1 = num2;
                    continue;
                  case 43:
                    if (!flag)
                    {
                      num2 = 53;
                      num1 = num2;
                      continue;
                    }
                    this.eval_n();
                    flag = Process.GetProcessesByName("Hearthstone").Length >= 1;
                    num2 = 8;
                    num1 = num2;
                    continue;
                  case 44:
                    num2 = 0;
                    this.eval_a1 = true;
                    this.eval_bs.Text = "Break 2";
                    flag = this.eval_az == 0;
                    num2 = 81;
                    num1 = num2;
                    continue;
                  case 46:
                    goto label_136;
                  case 47:
                    num2 = 85;
                    num1 = num2;
                    continue;
                  case 48:
                    flag = this.eval_av < this.eval_aw;
                    num2 = 64;
                    num1 = num2;
                    continue;
                  case 49:
                    this.eval_e = 1;
                    this.eval_d(A_0);
                    flag = !this.ao;
                    num2 = 28;
                    num1 = num2;
                    continue;
                  case 50:
                    goto label_132;
                  case 52:
                    if (!flag)
                    {
                      num2 = 89;
                      num1 = num2;
                      continue;
                    }
                    goto case 83;
                  case 53:
                    num2 = 68;
                    num1 = num2;
                    continue;
                  case 54:
                    goto label_128;
                  case 55:
                    this.c(this.eval_ay * 60 * 1000);
                    num2 = 92;
                    num1 = num2;
                    continue;
                  case 56:
                    this.eval_a1 = true;
                    this.eval_bs.Text = "Break 1";
                    flag = this.eval_ay == 0;
                    num2 = 71;
                    num1 = num2;
                    continue;
                  case 57:
                    flag = this.eval_r != 0;
                    num2 = 52;
                    num1 = num2;
                    continue;
                  case 58:
                    if (this.eval_c("Hearthstone"))
                    {
                      num2 = 88;
                      num1 = num2;
                      continue;
                    }
                    num2 = 39;
                    num1 = num2;
                    continue;
                  case 59:
                    goto label_126;
                  case 60:
                    num2 = 62;
                    num1 = num2;
                    continue;
                  case 61:
                    num4 = 1;
                    goto label_109;
                  case 62:
                    goto label_124;
                  case 63:
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 64:
                    if (!flag)
                    {
                      num2 = 56;
                      num1 = num2;
                      continue;
                    }
                    goto case 63;
                  case 65:
                    num2 = 20;
                    num1 = num2;
                    continue;
                  case 66:
                    this.eval_a("HB: stop by request of the Quest plugin");
                    num2 = 40;
                    num1 = num2;
                    continue;
                  case 67:
                    str2 = "does";
                    goto label_73;
                  case 68:
                    goto label_122;
                  case 70:
                    goto label_120;
                  case 71:
                    if (!flag)
                    {
                      num2 = 55;
                      num1 = num2;
                      continue;
                    }
                    goto case 92;
                  case 72:
                    if (flag)
                    {
                      flag = this.eval_d != 1;
                      num2 = 10;
                      num1 = num2;
                      continue;
                    }
                    num2 = 77;
                    num1 = num2;
                    continue;
                  case 73:
                    if (!flag)
                    {
                      num2 = 44;
                      num1 = num2;
                      continue;
                    }
                    goto case 84;
                  case 74:
                    num2 = 80;
                    num1 = num2;
                    continue;
                  case 75:
                    if (flag)
                    {
                      flag = this.eval_av < this.eval_ax;
                      num2 = 73;
                      num1 = num2;
                      continue;
                    }
                    num2 = 48;
                    num1 = num2;
                    continue;
                  case 76:
                    str1 = " HB ";
                    break;
                  case 77:
                    num2 = 21;
                    num1 = num2;
                    continue;
                  case 78:
                    this.c(this.eval_az * 60 * 1000);
                    num2 = 35;
                    num1 = num2;
                    continue;
                  case 79:
                    num2 = 50;
                    num1 = num2;
                    continue;
                  case 80:
                    num4 = !this.eval_c("Hearthstone") ? 1 : 0;
                    goto label_109;
                  case 81:
                    if (!flag)
                    {
                      num2 = 78;
                      num1 = num2;
                      continue;
                    }
                    goto case 35;
                  case 82:
                    if (!flag)
                    {
                      num2 = 66;
                      num1 = num2;
                      continue;
                    }
                    goto case 40;
                  case 83:
                    this.eval_bs.Text = "Stop tracking";
                    num2 = 46;
                    num1 = num2;
                    continue;
                  case 84:
                    num2 = 86;
                    num1 = num2;
                    continue;
                  case 85:
                    this.eval_m();
                    flag = this.eval_b(this.ba);
                    num2 = 72;
                    num1 = num2;
                    continue;
                  case 87:
                    if (flag)
                    {
                      global::eval_b.a(485, 495);
                      global::eval_b.a(470, 389);
                      this.c(1000);
                      ++num3;
                      num2 = 51;
                      num1 = num2;
                      continue;
                    }
                    num2 = 47;
                    num1 = num2;
                    continue;
                  case 88:
                    num2 = 67;
                    num1 = num2;
                    continue;
                  case 89:
                    this.c(10000);
                    flag = this.eval_d != 1;
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 90:
                    if (flag)
                    {
                      num2 = 17;
                      num1 = num2;
                      continue;
                    }
                    num2 = 5;
                    num1 = num2;
                    continue;
                  case 91:
                    if (flag)
                    {
                      flag = this.eval_as <= 0;
                      num2 = 9;
                      num1 = num2;
                      continue;
                    }
                    num2 = 15;
                    num1 = num2;
                    continue;
                  case 92:
                    this.eval_au = false;
                    this.eval_av = 0;
                    num2 = 63;
                    num1 = num2;
                    continue;
                  case 93:
                    if (flag)
                    {
                      this.eval_s = false;
                      A_0 = "";
                      flag = !this.eval_at;
                      num2 = 3;
                      num1 = num2;
                      continue;
                    }
                    num2 = 36;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
                string str3 = this.eval_c("Hearthstone") ? "" : " HS ";
                string str4;
                string str5 = str4;
                string str6 = " not exist";
                A_0 = str1 + str3 + str5 + str6;
                num2 = 49;
                num1 = num2;
                continue;
label_73:
                str4 = str2;
                num2 = 1;
                num1 = num2;
                continue;
label_109:
                flag = num4 != 0;
                num2 = 93;
                num1 = num2;
              }
label_126:
              return;
label_128:
              return;
label_124:
              return;
label_120:
              return;
label_122:
              return;
label_132:
              return;
label_143:
              return;
label_145:
              return;
label_141:
              return;
label_136:
              return;
label_137:
              return;
          }
      }
    }

    private string eval_w()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          string str1;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              str1 = "";
              num2 = 5;
              num1 = num2;
              goto default;
            default:
              string str2;
              while (true)
              {
                bool flag;
                int num3;
                switch (num1)
                {
                  case 0:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    str2 = str1;
                    break;
                  case 1:
                  case 4:
                    num2 = -23007;
                    int num4 = num2;
                    num2 = -23007;
                    int num5 = num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        goto label_23;
                    }
                  case 2:
                    num3 = 1;
                    goto label_18;
                  case 3:
                    if (!flag)
                    {
                      num2 = 6;
                      num1 = num2;
                      continue;
                    }
                    try
                    {
                      str1 = File.ReadAllText(this.eval_v);
                      str2 = str1;
                      goto case 1;
                    }
                    catch (Exception ex)
                    {
                      str2 = "";
                      goto case 1;
                    }
                  case 5:
                    if (this.eval_d == 1)
                    {
                      num2 = 8;
                      num1 = num2;
                      continue;
                    }
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 6:
                    str2 = str1;
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 7:
                    if (flag)
                    {
                      flag = File.Exists(this.eval_v);
                      num2 = 3;
                      num1 = num2;
                      continue;
                    }
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 8:
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 9:
                    num3 = this.eval_s ? 1 : 0;
                    goto label_18;
                  default:
                    goto label_3;
                }
                num2 = 1;
                num1 = num2;
                continue;
label_18:
                flag = num3 != 0;
                num2 = 7;
                num1 = num2;
              }
label_23:
              num2 = 0;
              num2 = 0;
              if (num2 == 0)
                ;
              return str2;
          }
      }
    }

    private void eval_v()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          switch (0)
          {
            case 0:
label_3:
              num2 = 15;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                bool flag1;
                string str1;
                int startIndex;
                int count;
                bool flag2;
                int num3;
                int A_0;
                int num4;
                int num5;
                switch (num1)
                {
                  case 0:
                  case 53:
                    num2 = 47;
                    num1 = num2;
                    continue;
                  case 1:
                    if (!flag1)
                    {
                      num2 = 10;
                      num1 = num2;
                      continue;
                    }
                    this.eval_am = str1.Length - 33;
                    flag1 = this.eval_am >= 0;
                    num2 = 45;
                    num1 = num2;
                    continue;
                  case 2:
                    goto label_99;
                  case 3:
                    if (this.eval_ab[this.eval_p].g <= 29)
                    {
                      num2 = 49;
                      num1 = num2;
                      continue;
                    }
                    num2 = 31;
                    num1 = num2;
                    continue;
                  case 4:
                    this.eval_t();
                    this.eval_d("30 wins");
                    this.eval_d = 1;
                    this.eval_f = 1;
                    this.eval_bs.Text = "Sleep...30 Wins";
                    num2 = 28;
                    num1 = num2;
                    continue;
                  case 5:
                    num2 = 8;
                    num1 = num2;
                    continue;
                  case 6:
                    this.eval_am = 0;
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 7:
                    startIndex = -1;
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 8:
                    goto label_93;
                  case 9:
                  case 34:
                    flag1 = startIndex > 0;
                    num2 = 37;
                    num1 = num2;
                    continue;
                  case 10:
                    // ISSUE: explicit reference operation
                    // ISSUE: variable of a reference type
                    global::eval_d& local = @this.eval_ab[this.eval_p];
                    DateTime dateTime = DateTime.UtcNow;
                    dateTime = dateTime.AddMinutes((double) -(this.eval_aq * 60 - 2));
                    string str2 = dateTime.ToString("yyyyMMdd");
                    // ISSUE: explicit reference operation
                    (^local).eval_i = str2;
                    this.eval_aa();
                    this.eval_q();
                    this.eval_d("no quests");
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 11:
                    num2 = 48;
                    num1 = num2;
                    continue;
                  case 12:
                    str1.IndexOf("because there are no quests", this.eval_am);
                    num2 = 55;
                    num1 = num2;
                    continue;
                  case 13:
                    num2 = 32;
                    num1 = num2;
                    continue;
                  case 14:
                    goto label_91;
                  case 15:
                    if (this.eval_d == 1)
                    {
                      num2 = 13;
                      num1 = num2;
                      continue;
                    }
                    num2 = 33;
                    num1 = num2;
                    continue;
                  case 16:
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 17:
                    if (!flag1)
                    {
                      num2 = 21;
                      num1 = num2;
                      continue;
                    }
                    goto case 50;
                  case 18:
                  case 61:
                    flag1 = !flag2;
                    num2 = 59;
                    num1 = num2;
                    continue;
                  case 19:
                    this.eval_am = 0;
                    num2 = 39;
                    num1 = num2;
                    continue;
                  case 20:
                    if (!flag1)
                    {
                      num2 = 43;
                      num1 = num2;
                      continue;
                    }
                    goto case 16;
                  case 21:
                    this.eval_am = str1.Length - 1;
                    num2 = 50;
                    num1 = num2;
                    continue;
                  case 22:
                    if (!flag1)
                    {
                      num2 = 54;
                      num1 = num2;
                      continue;
                    }
                    goto case 56;
                  case 23:
                    if (!flag1)
                    {
                      num2 = 12;
                      num1 = num2;
                      continue;
                    }
                    goto case 55;
                  case 24:
                    num2 = 30;
                    num1 = num2;
                    continue;
                  case 25:
                    flag1 = str1.IndexOf("Defeat =>", startIndex) < 0;
                    num2 = 22;
                    num1 = num2;
                    continue;
                  case 26:
                    flag1 = this.eval_am >= 0;
                    num2 = 52;
                    num1 = num2;
                    continue;
                  case 27:
                    goto label_88;
                  case 28:
                    goto label_86;
                  case 29:
                    if (flag1)
                    {
                      flag1 = this.eval_f != 1;
                      num2 = 60;
                      num1 = num2;
                      continue;
                    }
                    num2 = 58;
                    num1 = num2;
                    continue;
                  case 30:
                    goto label_81;
                  case 31:
                    num2 = -25449;
                    int num6 = num2;
                    num2 = -25449;
                    int num7 = num2;
                    switch (num6 == num7 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_83;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        num2 = 57;
                        num1 = num2;
                        continue;
                    }
                  case 32:
                    num4 = this.eval_s ? 1 : 0;
                    goto label_73;
                  case 33:
                    num4 = 1;
                    goto label_73;
                  case 35:
                  case 47:
                    num2 = 34;
                    num1 = num2;
                    continue;
                  case 36:
                    if (!flag1)
                    {
                      num2 = 26;
                      num1 = num2;
                      continue;
                    }
                    goto case 48;
                  case 37:
                    if (!flag1)
                    {
                      num2 = 14;
                      num1 = num2;
                      continue;
                    }
                    A_0 = 0;
                    flag2 = false;
                    flag1 = str1.IndexOf("Victory =>", startIndex) >= 0;
                    num2 = 40;
                    num1 = num2;
                    continue;
                  case 38:
                    num2 = 0;
                    startIndex = -1;
                    this.eval_d(A_0);
                    this.eval_f(this.eval_p);
                    flag1 = this.eval_q != 1;
                    num2 = 29;
                    num1 = num2;
                    continue;
                  case 39:
                    flag1 = this.eval_am <= str1.Length - 1;
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 40:
                    if (flag1)
                    {
                      ++this.eval_ab[this.eval_p].g;
                      A_0 = 1;
                      flag2 = true;
                      num2 = 18;
                      num1 = num2;
                      continue;
                    }
                    num2 = 25;
                    num1 = num2;
                    continue;
                  case 41:
                    if (!flag1)
                    {
                      num2 = 4;
                      num1 = num2;
                      continue;
                    }
                    num2 = 35;
                    num1 = num2;
                    continue;
                  case 42:
                    if (flag1)
                    {
                      flag1 = !this.eval_ah;
                      num2 = 36;
                      num1 = num2;
                      continue;
                    }
                    num2 = 5;
                    num1 = num2;
                    continue;
                  case 43:
                    this.eval_al = startIndex + "[GameEventManagerOnGameOver]".Length;
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 44:
                    this.eval_d("acc Job's Done");
                    num2 = 27;
                    num1 = num2;
                    continue;
                  case 45:
                    if (!flag1)
                    {
                      num2 = 6;
                      num1 = num2;
                      continue;
                    }
                    goto case 11;
                  case 46:
                    if (!flag1)
                    {
                      num2 = 24;
                      num1 = num2;
                      continue;
                    }
                    str1 = this.eval_w();
                    flag1 = str1.Length >= 50;
                    goto label_83;
                  case 48:
                    count = str1.Length - this.eval_al;
                    startIndex = str1.LastIndexOf("[GameEventManagerOnGameOver]", str1.Length, count);
                    flag1 = startIndex <= this.eval_al;
                    num2 = 20;
                    num1 = num2;
                    continue;
                  case 49:
                    num5 = 1;
                    break;
                  case 50:
                    num3 = str1.IndexOf("[QuestPlus] Now stopping the bot", this.eval_am);
                    flag1 = num3 > this.eval_am;
                    num2 = 23;
                    num1 = num2;
                    continue;
                  case 51:
                    if (flag1)
                    {
                      startIndex = str1.LastIndexOf("[GameEventManagerOnGameOver]", startIndex, count);
                      num2 = 53;
                      num1 = num2;
                      continue;
                    }
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 52:
                    if (!flag1)
                    {
                      num2 = 19;
                      num1 = num2;
                      continue;
                    }
                    goto case 39;
                  case 54:
                    ++this.eval_ab[this.eval_p].eval_h;
                    flag2 = true;
                    num2 = 56;
                    num1 = num2;
                    continue;
                  case 55:
                    flag1 = num3 <= this.eval_am;
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 56:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 61;
                    num1 = num2;
                    continue;
                  case 57:
                    num5 = !this.eval_by.Checked ? 1 : 0;
                    break;
                  case 58:
                    this.eval_d("need switch to other acc");
                    num2 = 62;
                    num1 = num2;
                    continue;
                  case 59:
                    if (flag1)
                    {
                      count -= str1.Length - startIndex;
                      flag1 = count >= 0;
                      num2 = 51;
                      num1 = num2;
                      continue;
                    }
                    num2 = 38;
                    num1 = num2;
                    continue;
                  case 60:
                    if (!flag1)
                    {
                      num2 = 44;
                      num1 = num2;
                      continue;
                    }
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 62:
                    goto label_77;
                  default:
                    goto label_3;
                }
                flag1 = num5 != 0;
                num2 = 41;
                num1 = num2;
                continue;
label_73:
                flag1 = num4 != 0;
                num2 = 46;
                num1 = num2;
                continue;
label_83:
                num2 = 42;
                num1 = num2;
              }
label_86:
              return;
label_81:
              return;
label_77:
              return;
label_88:
              return;
label_99:
              return;
label_93:
              return;
label_91:
              return;
          }
      }
    }

    private void eval_d(int A_0)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          switch (0)
          {
            case 0:
label_3:
              num2 = 19;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                int index1;
                bool flag;
                DateTime dateTime1;
                switch (num1)
                {
                  case 0:
                    if (!flag)
                    {
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    string[] strArray1 = this.eval_m;
                    int index2 = 0;
                    dateTime1 = DateTime.UtcNow;
                    dateTime1 = dateTime1.AddMinutes(1440.0);
                    string str1 = dateTime1.ToString("yyyyMMdd");
                    strArray1[index2] = str1;
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 1:
                  case 13:
                    flag = index1 < this.bb;
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 2:
                    Array.Resize<string>(ref this.eval_k, this.eval_k.Length + 1);
                    this.eval_m = new string[this.eval_m.Length];
                    flag = this.eval_aq < 0;
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 3:
                    if (flag)
                      goto label_40;
                    else
                      break;
                  case 4:
                    if (!flag)
                    {
                      num2 = 18;
                      num1 = num2;
                      continue;
                    }
                    goto case 2;
                  case 5:
                    num2 = -728;
                    int num3 = num2;
                    num2 = -728;
                    int num4 = num2;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        num2 = 1;
                        if (num2 == 0)
                          ;
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        string[] strArray2 = this.eval_m;
                        int index3 = 0;
                        dateTime1 = DateTime.UtcNow;
                        string str2 = dateTime1.ToString("yyyyMMdd");
                        strArray2[index3] = str2;
                        num2 = 15;
                        num1 = num2;
                        continue;
                    }
                  case 6:
                    this.eval_t();
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 7:
                    flag = A_0 != 1;
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 8:
                    flag = A_0 >= 50;
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 9:
                    num2 = 0;
                    flag = !this.eval_at;
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 10:
                    if (!flag)
                    {
                      num2 = 22;
                      num1 = num2;
                      continue;
                    }
                    goto case 21;
                  case 11:
                    if (!flag)
                    {
                      num2 = 23;
                      num1 = num2;
                      continue;
                    }
                    goto case 16;
                  case 12:
                  case 15:
                    this.eval_y.Restart();
                    index1 = 0;
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 14:
                    if (flag)
                    {
                      this.eval_ab[index1].f = "--:--";
                      this.eval_ab[index1].g = 0;
                      this.eval_ab[index1].eval_h = 0;
                      this.bh[index1].Text = "--:--";
                      this.bi[index1].Text = "-";
                      this.bj[index1].Text = "-";
                      this.bk[index1].Text = "-";
                      ++index1;
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 16:
                    flag = A_0 != 0;
                    num2 = 10;
                    num1 = num2;
                    continue;
                  case 17:
                    goto label_36;
                  case 18:
                    this.eval_a("newBlizzDate");
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 19:
                    DateTime dateTime2;
                    try
                    {
                      dateTime2 = DateTime.ParseExact(this.eval_m[0], "yyyyMMdd", (IFormatProvider) null);
                    }
                    catch (Exception ex)
                    {
                      dateTime2 = DateTime.ParseExact("20010101", "yyyyMMdd", (IFormatProvider) null);
                    }
                    flag = !(dateTime2.AddMinutes((double) ((24 + this.eval_aq) * 60 + 2)) < DateTime.UtcNow);
                    num2 = 20;
                    num1 = num2;
                    continue;
                  case 20:
                    if (!flag)
                    {
                      num2 = 9;
                      num1 = num2;
                      continue;
                    }
                    goto case 8;
                  case 21:
                    num2 = 8;
                    num1 = num2;
                    continue;
                  case 22:
                    this.eval_ab[this.eval_p].g = 0;
                    this.eval_ab[this.eval_p].eval_h = 1;
                    num2 = 21;
                    num1 = num2;
                    continue;
                  case 23:
                    this.eval_ab[this.eval_p].g = 1;
                    this.eval_ab[this.eval_p].eval_h = 0;
                    num2 = 16;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
                num2 = 6;
                num1 = num2;
              }
label_36:
              return;
label_40:
              return;
          }
      }
    }

    private TimeSpan eval_u()
    {
      int num1;
      TimeSpan elapsed;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          elapsed = this.eval_y.Elapsed;
          num2 = 4;
          num1 = num2;
          goto default;
        default:
          TimeSpan timeSpan;
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
                num2 = 1;
                if (num2 == 0)
                  ;
                elapsed += TimeSpan.Parse(this.eval_ab[this.eval_p].f);
                num2 = 7;
                num1 = num2;
                continue;
              case 2:
                num3 = !(this.eval_ab[this.eval_p].f != "--:--") ? 1 : 0;
                break;
              case 3:
label_11:
                num2 = 2;
                num1 = num2;
                continue;
              case 4:
                if (!string.IsNullOrEmpty(this.eval_ab[this.eval_p].f))
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                num2 = 0;
                num1 = num2;
                continue;
              case 5:
                num2 = 0;
                num2 = -5349;
                int num4 = num2;
                num2 = -5349;
                int num5 = num2;
                switch (num4 == num5 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    goto label_8;
                }
              case 6:
                if (!flag)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                goto case 7;
              case 7:
                timeSpan = elapsed;
                num2 = 5;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
            flag = num3 != 0;
            num2 = 6;
            num1 = num2;
          }
label_8:
          num2 = 0;
          if (num2 == 0)
            ;
          return timeSpan;
      }
    }

    private void eval_t()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2 = -9518;
          int num3 = -9518;
          int num4 = num3;
          StringBuilder stringBuilder;
          int index1;
          switch (num2 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
label_5:
              this.eval_ab[this.eval_p].f = string.Format("{0:00}:{1:00}", (object) this.eval_u().Hours, (object) this.eval_u().Minutes);
              this.eval_y.Restart();
              int index2 = this.eval_p;
              this.eval_m[index2 * 6 + 1] = this.eval_o[index2];
              this.eval_m[index2 * 6 + 2] = this.eval_ab[index2].d.ToString();
              this.eval_m[index2 * 6 + 3] = this.eval_ab[index2].f;
              this.eval_m[index2 * 6 + 4] = this.eval_ab[index2].g.ToString();
              this.eval_m[index2 * 6 + 5] = this.eval_ab[index2].eval_h.ToString();
              this.eval_m[index2 * 6 + 6] = this.eval_n[index2];
              stringBuilder = new StringBuilder("", 500);
              index1 = 0;
              num3 = 0;
              num1 = num3;
              break;
            default:
              num3 = 0;
              if (num3 == 0)
                ;
              switch (0)
              {
                case 0:
                  goto label_5;
              }
          }
          bool flag;
          while (true)
          {
            switch (num1)
            {
              case 0:
              case 2:
                flag = index1 < this.eval_m.Length - 1;
                num3 = 1;
                num1 = num3;
                continue;
              case 1:
                num3 = 0;
                if (!flag)
                {
                  num3 = 3;
                  num1 = num3;
                  continue;
                }
                stringBuilder.Append(this.eval_m[index1]).Append("\t");
                ++index1;
                num3 = 1;
                if (num3 == 0)
                  ;
                num3 = 2;
                num1 = num3;
                continue;
              case 3:
                goto label_11;
              default:
                goto label_5;
            }
          }
label_11:
          stringBuilder.Append(this.eval_m[index1]);
          this.eval_k[this.eval_k.Length - 1] = stringBuilder.ToString();
          File.WriteAllLines(this.eval_a4, this.eval_k);
          break;
      }
    }

    private void eval_s()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
label_1:
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              DateTime now = DateTime.Now;
              int num3 = (int) now.DayOfWeek;
              now = DateTime.Now;
              flag = this.eval_ac[now.Hour + 24 * num3] != this.eval_p + 1;
              num2 = 0;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    if (!flag)
                    {
                      num2 = 0;
                      num2 = 2;
                      num1 = num2;
                      continue;
                    }
                    this.eval_q = 1;
                    num2 = -17391;
                    int num4 = num2;
                    num2 = -17391;
                    int num5 = num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_1;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        num2 = 1;
                        num1 = num2;
                        continue;
                    }
                  case 1:
                    goto label_12;
                  case 2:
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 3:
                    goto label_10;
                  default:
                    goto label_3;
                }
              }
label_10:
              return;
label_12:
              return;
          }
      }
    }

    private void eval_r()
    {
      int num1;
      int num2;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          flag = this.eval_u().TotalSeconds <= (double) (3600 * this.eval_ab[this.eval_p].eval_e + 10);
          break;
        default:
          while (true)
          {
            num1 = 0;
            switch (num2)
            {
              case 0:
                goto label_9;
              case 1:
                num1 = -1040;
                int num3 = num1;
                num1 = -1040;
                int num4 = num1;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_3;
                  default:
                    num1 = 0;
                    if (num1 == 0)
                      ;
                    num1 = 1;
                    if (num1 == 0)
                      ;
                    this.eval_t();
                    this.eval_d = 1;
                    this.eval_f = 1;
                    num1 = 0;
                    num2 = num1;
                    continue;
                }
              case 2:
                if (!flag)
                {
                  num1 = 1;
                  num2 = num1;
                  continue;
                }
                goto label_11;
              default:
                goto label_2;
            }
          }
label_9:
          return;
label_11:
          return;
      }
label_3:
      num1 = 2;
      num2 = num1;
      goto default;
    }

    private void eval_q()
    {
      int num1;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          ++this.eval_p;
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
                if (this.eval_p <= this.bb - 1)
                {
                  num2 = 6;
                  num1 = num2;
                  continue;
                }
                num2 = 5;
                num1 = num2;
                continue;
              case 1:
                num2 = 0;
                num2 = 12631;
                int num4 = num2;
                num2 = 12631;
                int num5 = num2;
                switch (num4 == num5 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    goto label_8;
                }
              case 2:
                this.bc[0].Checked = true;
                num2 = 7;
                num1 = num2;
                continue;
              case 3:
                if (flag)
                {
                  this.bc[this.eval_p].Checked = true;
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                num2 = 2;
                num1 = num2;
                continue;
              case 4:
                num3 = this.eval_p >= 0 ? 1 : 0;
                break;
              case 5:
                num3 = 0;
                break;
              case 6:
label_11:
                num2 = 4;
                num1 = num2;
                continue;
              case 7:
                goto label_17;
              default:
                goto label_2;
            }
            flag = num3 != 0;
            num2 = 1;
            if (num2 == 0)
              ;
            num2 = 3;
            num1 = num2;
          }
label_8:
          num2 = 0;
          if (num2 == 0)
            ;
label_17:
          this.eval_y.Stop();
          this.eval_y.Reset();
          break;
      }
    }

    private void eval_ab(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              flag = this.eval_d != 1;
              num2 = 33;
              num1 = num2;
              goto default;
            default:
              string str;
              int num3;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    if (!flag)
                    {
                      num2 = 4;
                      num1 = num2;
                      continue;
                    }
                    this.c(5000);
                    num2 = 36;
                    num1 = num2;
                    continue;
                  case 1:
                  case 14:
                    flag = num3 > this.eval_an;
                    num2 = 8;
                    num1 = num2;
                    continue;
                  case 2:
                    if (!flag)
                    {
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    str = "";
                    num2 = 45;
                    num1 = num2;
                    continue;
                  case 3:
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 4:
                    num2 = 26;
                    num1 = num2;
                    continue;
                  case 5:
                    num2 = 23;
                    num1 = num2;
                    continue;
                  case 6:
                    if (!flag)
                    {
                      num2 = 31;
                      num1 = num2;
                      continue;
                    }
                    goto case 42;
                  case 7:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num3 = str.LastIndexOf("[OpponentTurn]");
                    flag = num3 <= 0;
                    num2 = 28;
                    num1 = num2;
                    continue;
                  case 8:
                    if (!flag)
                    {
                      num2 = 35;
                      num1 = num2;
                      continue;
                    }
                    goto case 18;
                  case 9:
                    num2 = 10;
                    num1 = num2;
                    continue;
                  case 10:
                    goto label_73;
                  case 11:
                    num3 = str.LastIndexOf("We need the contents of this deck.");
                    flag = num3 <= 0;
                    num2 = 37;
                    num1 = num2;
                    continue;
                  case 12:
                    if (!flag)
                    {
                      num2 = 11;
                      num1 = num2;
                      continue;
                    }
                    goto case 43;
                  case 13:
                    num2 = 15;
                    num1 = num2;
                    continue;
                  case 15:
                    goto label_71;
                  case 16:
                    num3 = str.LastIndexOf("We do not need to cache custom decks.");
                    flag = num3 <= 0;
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 17:
                  case 25:
                    num2 = 43;
                    num1 = num2;
                    continue;
                  case 18:
label_52:
                    flag = num3 <= this.eval_an;
                    num2 = 38;
                    num1 = num2;
                    continue;
                  case 19:
                    if (!flag)
                    {
                      num2 = 32;
                      num1 = num2;
                      continue;
                    }
                    goto case 3;
                  case 20:
                    this.eval_an = num3;
                    this.eval_av = 0;
                    this.eval_au = true;
                    flag = this.eval_a9 != 0;
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 21:
                    if (!flag)
                    {
                      num2 = 9;
                      num1 = num2;
                      continue;
                    }
                    num3 = -3;
                    flag = this.eval_a9 <= -1;
                    num2 = 30;
                    num1 = num2;
                    continue;
                  case 22:
                    num2 = 24;
                    num1 = num2;
                    continue;
                  case 23:
                    goto label_67;
                  case 24:
                    goto label_63;
                  case 26:
                    goto label_59;
                  case 27:
                    if (flag)
                    {
                      flag = File.Exists(this.eval_v);
                      num2 = 2;
                      num1 = num2;
                      continue;
                    }
                    num2 = 22;
                    num1 = num2;
                    continue;
                  case 28:
                    if (!flag)
                    {
                      num2 = 39;
                      num1 = num2;
                      continue;
                    }
                    goto case 41;
                  case 29:
                    if (!flag)
                    {
                      num2 = 16;
                      num1 = num2;
                      continue;
                    }
                    goto case 7;
                  case 30:
                    if (flag)
                    {
                      num3 = str.LastIndexOf("[OpponentTurn]");
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    num2 = 44;
                    num1 = num2;
                    continue;
                  case 31:
                    this.eval_a9 = -1;
                    num2 = 42;
                    num1 = num2;
                    continue;
                  case 32:
                    this.eval_a9 = -1;
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 33:
                    if (!flag)
                    {
                      num2 = 13;
                      num1 = num2;
                      continue;
                    }
                    num2 = 0;
                    flag = !(this.eval_bs.Text != "Stop tracking");
                    num2 = 27;
                    num1 = num2;
                    continue;
                  case 34:
                    this.eval_a9 = 1;
                    num2 = 25;
                    num1 = num2;
                    continue;
                  case 35:
                    num3 = str.LastIndexOf("[GameplayScene_BEGIN_MULLIGAN]");
                    num2 = 18;
                    num1 = num2;
                    continue;
                  case 36:
                    goto label_58;
                  case 37:
                    if (!flag)
                    {
                      num2 = 34;
                      num1 = num2;
                      continue;
                    }
                    num3 = str.LastIndexOf("We do not need to cache custom decks.");
                    flag = num3 <= 0;
                    num2 = 19;
                    num1 = num2;
                    continue;
                  case 38:
                    if (flag)
                    {
                      this.eval_an = 0;
                      this.ao = true;
                      this.eval_d("Hang timer");
                      flag = this.eval_d != 1;
                      num2 = 0;
                      num1 = num2;
                      continue;
                    }
                    num2 = 20;
                    num1 = num2;
                    continue;
                  case 39:
                    this.eval_a9 = -1;
                    num2 = 41;
                    num1 = num2;
                    continue;
                  case 40:
                    goto label_56;
                  case 41:
                    num2 = 40;
                    num1 = num2;
                    continue;
                  case 42:
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 43:
                    flag = this.eval_a9 != 1;
                    num2 = -27072;
                    int num4 = num2;
                    num2 = -27072;
                    int num5 = num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_52;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        num2 = 29;
                        num1 = num2;
                        continue;
                    }
                  case 44:
                    num3 = str.LastIndexOf("[CollectionManagerScene_COLLECTION]");
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 45:
                    try
                    {
                      str = File.ReadAllText(this.eval_v);
                    }
                    catch (Exception ex)
                    {
                      return;
                    }
                    flag = str.Length >= 50;
                    num2 = 21;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_59:
              return;
label_58:
              return;
label_56:
              return;
label_63:
              return;
label_73:
              return;
label_71:
              return;
label_67:
              return;
          }
      }
    }

    private bool eval_p()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          byte g;
          byte b;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              Color color1 = Form1.eval_b(618, 71);
              g = color1.G;
              b = color1.B;
              num2 = 2;
              num1 = num2;
              goto default;
            default:
              bool flag1;
              while (true)
              {
                byte r;
                bool flag2;
                int num3;
                int num4;
                switch (num1)
                {
                  case 0:
                    num2 = 0;
                    flag1 = false;
                    num2 = 19;
                    num1 = num2;
                    continue;
                  case 1:
                    if (flag2)
                    {
                      Color color2 = Form1.eval_b(630, 72);
                      r = color2.R;
                      g = color2.G;
                      num2 = 9;
                      num1 = num2;
                      continue;
                    }
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 2:
                    if ((int) b == 0)
                    {
                      num2 = 7;
                      num1 = num2;
                      continue;
                    }
                    num2 = 8;
                    num1 = num2;
                    continue;
                  case 3:
                    if ((int) g > 140)
                    {
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 4:
                  case 19:
                  case 20:
                    goto label_39;
                  case 5:
                    num3 = 0;
                    goto label_28;
                  case 6:
                    num3 = (int) g >= 205 ? 1 : 0;
                    goto label_28;
                  case 7:
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 8:
                    num3 = 1;
                    goto label_28;
                  case 9:
                    if ((int) r >= 10)
                    {
                      num2 = 13;
                      num1 = num2;
                      continue;
                    }
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 10:
                    if ((int) g > 100)
                    {
                      num2 = 18;
                      num1 = num2;
                      continue;
                    }
                    num2 = 15;
                    num1 = num2;
                    continue;
                  case 11:
                    num2 = 9461;
                    int num5 = num2;
                    num2 = 9461;
                    int num6 = num2;
                    switch (num5 == num6 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_20;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        num2 = 6;
                        num1 = num2;
                        continue;
                    }
                  case 12:
                    if (flag2)
                    {
                      flag1 = false;
                      num2 = 20;
                      num1 = num2;
                      continue;
                    }
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 13:
                    num4 = 1;
                    break;
                  case 14:
label_20:
                    flag1 = true;
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 15:
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 16:
                    num4 = (int) g >= 180 ? 1 : 0;
                    break;
                  case 17:
                    num2 = 10;
                    num1 = num2;
                    continue;
                  case 18:
                    num4 = 0;
                    break;
                  default:
                    goto label_3;
                }
                flag2 = num4 != 0;
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 12;
                num1 = num2;
                continue;
label_28:
                flag2 = num3 != 0;
                num2 = 1;
                num1 = num2;
              }
label_39:
              return flag1;
          }
      }
    }

    private void eval_o()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          bool flag;
          switch (0)
          {
            case 0:
label_3:
              num2 = 0;
              flag = !this.eval_at;
              num2 = 1;
              if (num2 == 0)
                ;
              num2 = 2;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    this.eval_a("Battle.net: attempt to run");
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 1:
                    try
                    {
                      switch (0)
                      {
                        case 0:
label_9:
                          Process.Start(this.BNetPath);
                          this.c(this.eval_a0 * 1000);
                          flag = this.eval_d != 1;
                          num2 = 22;
                          num1 = num2;
                          goto default;
                        default:
                          while (true)
                          {
                            int num3;
                            Process process1;
                            IntPtr mainWindowHandle;
                            global::eval_e.eval_a A_1_1;
                            int num4;
                            Process[] processes;
                            int index1;
                            int num5;
                            switch (num1)
                            {
                              case 0:
                                this.eval_a("Battle.net is running successfully. Trying to find Main Window...");
                                num2 = 25;
                                num1 = num2;
                                continue;
                              case 1:
                              case 8:
                                flag = index1 < processes.Length;
                                num2 = 13;
                                num1 = num2;
                                continue;
                              case 2:
                                this.eval_k();
                                this.c(20000);
                                flag = this.eval_d != 1;
                                num2 = 14;
                                num1 = num2;
                                continue;
                              case 3:
                                if (!flag)
                                {
                                  num2 = 32;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 27;
                              case 4:
                                flag = !this.eval_at;
                                num2 = 35;
                                num1 = num2;
                                continue;
                              case 5:
                                if (!flag)
                                {
                                  num2 = 0;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 25;
                              case 6:
                                this.eval_a("Battle.net: attempt to Re-Login.");
                                num2 = 2;
                                num1 = num2;
                                continue;
                              case 7:
                                num2 = 28;
                                num1 = num2;
                                continue;
                              case 9:
                                if (num3 < 520)
                                {
                                  num2 = 24;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 36;
                                num1 = num2;
                                continue;
                              case 10:
                                num2 = 30;
                                num1 = num2;
                                continue;
                              case 11:
                                num2 = 19;
                                num1 = num2;
                                continue;
                              case 12:
                                num5 = num3 <= 430 ? 1 : 0;
                                break;
                              case 13:
                                if (flag)
                                {
                                  process1 = processes[index1];
                                  flag = !(process1.ProcessName == "Battle.net");
                                  num2 = 3;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 7;
                                num1 = num2;
                                continue;
                              case 14:
                                if (!flag)
                                {
                                  num2 = 26;
                                  num1 = num2;
                                  continue;
                                }
                                flag = !this.eval_at;
                                num2 = 5;
                                num1 = num2;
                                continue;
                              case 15:
                                goto label_208;
                              case 16:
                                flag = !this.eval_at;
                                num2 = 18;
                                num1 = num2;
                                continue;
                              case 17:
                                if (!flag)
                                {
                                  num2 = 16;
                                  num1 = num2;
                                  continue;
                                }
                                this.eval_d("Battle.net has no Window 1 :(");
                                num2 = 15;
                                num1 = num2;
                                continue;
                              case 18:
                                if (!flag)
                                {
                                  num2 = 34;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 29;
                              case 19:
                                goto label_191;
                              case 20:
                                if (!flag)
                                {
                                  num2 = 23;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 31;
                              case 21:
                                if (!flag)
                                {
                                  num2 = 4;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 10;
                              case 22:
                                if (!flag)
                                {
                                  num2 = 11;
                                  num1 = num2;
                                  continue;
                                }
                                processes = Process.GetProcesses();
                                index1 = 0;
                                num2 = 1;
                                num1 = num2;
                                continue;
                              case 23:
                                this.eval_a("Battle.net is running successfully. Check window...");
                                num2 = 31;
                                num1 = num2;
                                continue;
                              case 24:
                                num2 = 12;
                                num1 = num2;
                                continue;
                              case 25:
                                try
                                {
                                  Process process2;
                                  switch (0)
                                  {
                                    case 0:
label_167:
                                      process2 = Process.GetProcessesByName("Battle.net")[0];
                                      flag = !this.eval_at;
                                      num2 = 11;
                                      num1 = num2;
                                      goto default;
                                    default:
                                      while (true)
                                      {
                                        int num6;
                                        switch (num1)
                                        {
                                          case 0:
                                            flag = !this.eval_at;
                                            num2 = 16;
                                            num1 = num2;
                                            continue;
                                          case 1:
                                            if (flag)
                                            {
                                              num2 = 14;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 7;
                                            num1 = num2;
                                            continue;
                                          case 2:
                                            num2 = 13;
                                            num1 = num2;
                                            continue;
                                          case 3:
                                            this.eval_a("Battle.net is re-running successfully. Check window...");
                                            num2 = 17;
                                            num1 = num2;
                                            continue;
                                          case 4:
                                            goto label_183;
                                          case 5:
                                            goto label_142;
                                          case 6:
                                            if (flag)
                                            {
                                              this.eval_d("Battle.net has no Window 2 :(");
                                              num2 = 4;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 0;
                                            num1 = num2;
                                            continue;
                                          case 7:
                                            this.eval_d("Battle.net: login error :(");
                                            num2 = 15;
                                            num1 = num2;
                                            continue;
                                          case 8:
                                            num6 = 1;
                                            break;
                                          case 9:
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            num4 = A_1_1.eval_c() - A_1_1.eval_a();
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            num3 = A_1_1.eval_e() - A_1_1.eval_b();
                                            num2 = 12;
                                            num1 = num2;
                                            continue;
                                          case 10:
                                            this.eval_a("Battle.net has a Window.");
                                            num2 = 9;
                                            num1 = num2;
                                            continue;
                                          case 11:
                                            if (!flag)
                                            {
                                              num2 = 3;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 17;
                                          case 12:
                                            if (num3 >= 465)
                                            {
                                              num2 = 8;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 2;
                                            num1 = num2;
                                            continue;
                                          case 13:
                                            num6 = num3 <= 430 ? 1 : 0;
                                            break;
                                          case 14:
                                            num2 = 5;
                                            num1 = num2;
                                            continue;
                                          case 15:
                                            goto label_179;
                                          case 16:
                                            if (!flag)
                                            {
                                              num2 = 10;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 9;
                                          case 17:
                                            mainWindowHandle = process2.MainWindowHandle;
                                            flag = !global::eval_e.GetWindowRect(mainWindowHandle, out A_1_1);
                                            num2 = 6;
                                            num1 = num2;
                                            continue;
                                          default:
                                            goto label_167;
                                        }
                                        flag = num6 != 0;
                                        num2 = 1;
                                        num1 = num2;
                                      }
label_179:
                                      return;
label_183:
                                      return;
                                  }
                                }
                                catch (Exception ex)
                                {
                                  this.eval_d("Battle.net: The main window is not found :(");
                                  return;
                                }
label_142:
                                num2 = 10;
                                num1 = num2;
                                continue;
                              case 26:
                                num2 = 33;
                                num1 = num2;
                                continue;
                              case 27:
                                ++index1;
                                num2 = 8;
                                num1 = num2;
                                continue;
                              case 28:
                                goto label_211;
                              case 29:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                num4 = A_1_1.eval_c() - A_1_1.eval_a();
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                num3 = A_1_1.eval_e() - A_1_1.eval_b();
                                num2 = 9;
                                num1 = num2;
                                continue;
                              case 30:
                                try
                                {
                                  switch (0)
                                  {
                                    case 0:
label_33:
                                      flag = !this.eval_at;
                                      num2 = 58;
                                      num1 = num2;
                                      goto default;
                                    default:
                                      int num6;
                                      global::eval_e.eval_a A_1_2;
                                      int num7;
                                      int num8;
                                      while (true)
                                      {
                                        switch (num1)
                                        {
                                          case 0:
                                            num2 = 55;
                                            num1 = num2;
                                            continue;
                                          case 1:
                                          case 24:
                                          case 40:
                                            num2 = 70;
                                            num1 = num2;
                                            continue;
                                          case 2:
                                            if (!flag)
                                            {
                                              num2 = 33;
                                              num1 = num2;
                                              continue;
                                            }
                                            flag = !this.eval_at;
                                            num2 = 27;
                                            num1 = num2;
                                            continue;
                                          case 3:
                                            this.eval_a("Battle.net: wait window...");
                                            num2 = 20;
                                            num1 = num2;
                                            continue;
                                          case 4:
                                          case 42:
                                            this.eval_bs.Text = "Wait... Reload";
                                            num2 = 71;
                                            num1 = num2;
                                            continue;
                                          case 5:
                                            goto label_206;
                                          case 6:
                                            if (!flag)
                                            {
                                              num2 = 43;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 67;
                                          case 7:
                                          case 9:
                                            flag = global::eval_e.GetWindowRect(mainWindowHandle, out A_1_1);
                                            num2 = 75;
                                            num1 = num2;
                                            continue;
                                          case 8:
                                            if (!flag)
                                            {
                                              num2 = 39;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 54;
                                          case 10:
                                            if (!flag)
                                            {
                                              num2 = 0;
                                              num1 = num2;
                                              continue;
                                            }
                                            this.eval_y.Restart();
                                            global::eval_e.SetForegroundWindow(mainWindowHandle);
                                            this.c(500);
                                            global::eval_b.a(90, 60);
                                            this.c(1000);
                                            SendKeys.SendWait("{UP}");
                                            SendKeys.SendWait("{UP}");
                                            SendKeys.SendWait("{ENTER}");
                                            this.c(5000);
                                            flag = this.eval_d != 1;
                                            num2 = 11;
                                            num1 = num2;
                                            continue;
                                          case 11:
                                            if (flag)
                                            {
                                              flag = !this.eval_at;
                                              num2 = 60;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 51;
                                            num1 = num2;
                                            continue;
                                          case 12:
                                            if (!flag)
                                            {
                                              num2 = 76;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 17;
                                          case 13:
                                          case 35:
                                          case 64:
                                            num2 = 16;
                                            num1 = num2;
                                            continue;
                                          case 14:
                                            if (flag)
                                            {
                                              flag = this.eval_d != 1;
                                              num2 = 45;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 74;
                                            num1 = num2;
                                            continue;
                                          case 15:
                                            if (!flag)
                                            {
                                              num2 = 19;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 22;
                                          case 16:
                                          case 70:
                                            num2 = 57;
                                            num1 = num2;
                                            continue;
                                          case 17:
                                            num6 = 0;
                                            num2 = 9;
                                            num1 = num2;
                                            continue;
                                          case 18:
                                            num2 = 5;
                                            num1 = num2;
                                            continue;
                                          case 19:
                                            string[] strArray1 = new string[8];
                                            strArray1[0] = "Battle.net: new position: x:";
                                            string[] strArray2 = strArray1;
                                            int index2 = 1;
                                            // ISSUE: reference to a compiler-generated method
                                            int num9 = A_1_2.eval_a();
                                            string str1 = num9.ToString();
                                            strArray2[index2] = str1;
                                            strArray1[2] = ", y:";
                                            string[] strArray3 = strArray1;
                                            int index3 = 3;
                                            // ISSUE: reference to a compiler-generated method
                                            num9 = A_1_2.eval_b();
                                            string str2 = num9.ToString();
                                            strArray3[index3] = str2;
                                            strArray1[4] = ", w:";
                                            strArray1[5] = num7.ToString();
                                            strArray1[6] = ", h:";
                                            strArray1[7] = num8.ToString();
                                            this.eval_a(string.Concat(strArray1));
                                            num2 = 22;
                                            num1 = num2;
                                            continue;
                                          case 20:
                                            num2 = 31;
                                            num1 = num2;
                                            continue;
                                          case 21:
                                            if (flag)
                                            {
                                              flag = this.eval_d != 1;
                                              num2 = 68;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 61;
                                            num1 = num2;
                                            continue;
                                          case 22:
                                            flag = (DateTime.Now - this.eval_u).TotalSeconds >= 100.0;
                                            num2 = 32;
                                            num1 = num2;
                                            continue;
                                          case 23:
                                          case 25:
                                            flag = this.eval_p();
                                            num2 = 72;
                                            num1 = num2;
                                            continue;
                                          case 26:
                                            if (!flag)
                                            {
                                              num2 = 13;
                                              num1 = num2;
                                              continue;
                                            }
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            num4 = A_1_1.eval_c() - A_1_1.eval_a();
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            num3 = A_1_1.eval_e() - A_1_1.eval_b();
                                            flag = num3 <= 465;
                                            num2 = 50;
                                            num1 = num2;
                                            continue;
                                          case 27:
                                            if (!flag)
                                            {
                                              num2 = 49;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 73;
                                          case 28:
                                            flag = this.eval_d != 1;
                                            num2 = 10;
                                            num1 = num2;
                                            continue;
                                          case 29:
                                            goto label_204;
                                          case 30:
                                            goto label_199;
                                          case 31:
                                          case 69:
                                            flag = global::eval_e.GetWindowRect(mainWindowHandle, out A_1_1);
                                            num2 = 26;
                                            num1 = num2;
                                            continue;
                                          case 32:
                                            if (!flag)
                                            {
                                              num2 = 78;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 71;
                                          case 33:
                                            num2 = 30;
                                            num1 = num2;
                                            continue;
                                          case 34:
                                            flag = !this.eval_at;
                                            num2 = 63;
                                            num1 = num2;
                                            continue;
                                          case 36:
                                            if (!flag)
                                            {
                                              num2 = 41;
                                              num1 = num2;
                                              continue;
                                            }
                                            flag = !this.eval_at;
                                            num2 = 6;
                                            num1 = num2;
                                            continue;
                                          case 37:
                                            this.eval_a("Battle.net: change accounts - Log In");
                                            num2 = 77;
                                            num1 = num2;
                                            continue;
                                          case 38:
                                            this.eval_a("Battle.net: wait window...");
                                            num2 = 62;
                                            num1 = num2;
                                            continue;
                                          case 39:
                                            this.eval_a("Battle.net: No connection...");
                                            num2 = 54;
                                            num1 = num2;
                                            continue;
                                          case 41:
                                            num2 = 4;
                                            num1 = num2;
                                            continue;
                                          case 43:
                                            this.eval_a("Battle.net: No connection...");
                                            num2 = 67;
                                            num1 = num2;
                                            continue;
                                          case 44:
                                            num2 = 29;
                                            num1 = num2;
                                            continue;
                                          case 45:
                                            if (flag)
                                            {
                                              this.c(15000);
                                              flag = !this.eval_at;
                                              num2 = 53;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 18;
                                            num1 = num2;
                                            continue;
                                          case 46:
                                            this.eval_a("Battle.net: set position - start");
                                            num2 = 56;
                                            num1 = num2;
                                            continue;
                                          case 47:
                                            num2 = 24;
                                            num1 = num2;
                                            continue;
                                          case 48:
                                            if (!flag)
                                            {
                                              num2 = 47;
                                              num1 = num2;
                                              continue;
                                            }
                                            ++num6;
                                            flag = num6 <= 240;
                                            num2 = 21;
                                            num1 = num2;
                                            continue;
                                          case 49:
                                            this.eval_a("Battle.net: wait window...");
                                            num2 = 73;
                                            num1 = num2;
                                            continue;
                                          case 50:
                                            if (flag)
                                            {
                                              ++num6;
                                              flag = num6 <= 240;
                                              num2 = 14;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 59;
                                            num1 = num2;
                                            continue;
                                          case 51:
                                            num2 = 66;
                                            num1 = num2;
                                            continue;
                                          case 52:
                                            if (!flag)
                                            {
                                              num2 = 38;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 62;
                                          case 53:
                                            if (!flag)
                                            {
                                              num2 = 3;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 20;
                                          case 54:
                                            num2 = 25;
                                            num1 = num2;
                                            continue;
                                          case 55:
                                            goto label_197;
                                          case 56:
                                            global::eval_e.SetForegroundWindow(mainWindowHandle);
                                            this.c(500);
                                            global::eval_e.SetWindowPos((int) mainWindowHandle, 0, 10, 10, 800, 600, 64U);
                                            this.c(1000);
                                            A_1_2 = new global::eval_e.eval_a(0, 0, 1, 1);
                                            global::eval_e.GetWindowRect(mainWindowHandle, out A_1_2);
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            num7 = A_1_2.eval_c() - A_1_2.eval_a();
                                            // ISSUE: reference to a compiler-generated method
                                            // ISSUE: reference to a compiler-generated method
                                            num8 = A_1_2.eval_e() - A_1_2.eval_b();
                                            flag = !this.eval_at;
                                            num2 = 15;
                                            num1 = num2;
                                            continue;
                                          case 57:
                                            goto label_16;
                                          case 58:
                                            if (!flag)
                                            {
                                              num2 = 46;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 56;
                                          case 59:
                                            num2 = 64;
                                            num1 = num2;
                                            continue;
                                          case 60:
                                            if (!flag)
                                            {
                                              num2 = 37;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 77;
                                          case 61:
                                            num2 = 40;
                                            num1 = num2;
                                            continue;
                                          case 62:
                                            num2 = 7;
                                            num1 = num2;
                                            continue;
                                          case 63:
                                            if (!flag)
                                            {
                                              num2 = 65;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 28;
                                          case 65:
                                            this.eval_a("Battle.net: Log Out");
                                            num2 = 28;
                                            num1 = num2;
                                            continue;
                                          case 66:
                                            goto label_193;
                                          case 67:
                                            num2 = 23;
                                            num1 = num2;
                                            continue;
                                          case 68:
                                            if (!flag)
                                            {
                                              num2 = 44;
                                              num1 = num2;
                                              continue;
                                            }
                                            this.c(15000);
                                            flag = !this.eval_at;
                                            num2 = 52;
                                            num1 = num2;
                                            continue;
                                          case 71:
                                            this.eval_u = DateTime.Now;
                                            flag = this.eval_q != 1;
                                            num2 = 79;
                                            num1 = num2;
                                            continue;
                                          case 72:
                                            if (flag)
                                            {
                                              this.c(60000);
                                              ++num6;
                                              flag = num6 <= 120;
                                              num2 = 36;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 42;
                                            num1 = num2;
                                            continue;
                                          case 73:
                                            num6 = 0;
                                            num2 = 69;
                                            num1 = num2;
                                            continue;
                                          case 74:
                                            num2 = 35;
                                            num1 = num2;
                                            continue;
                                          case 75:
                                            if (flag)
                                            {
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              num4 = A_1_1.eval_c() - A_1_1.eval_a();
                                              // ISSUE: reference to a compiler-generated method
                                              // ISSUE: reference to a compiler-generated method
                                              num3 = A_1_1.eval_e() - A_1_1.eval_b();
                                              flag = num3 <= 465;
                                              num2 = 48;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 1;
                                            num1 = num2;
                                            continue;
                                          case 76:
                                            this.eval_a("Battle.net: wait window...");
                                            num2 = 17;
                                            num1 = num2;
                                            continue;
                                          case 77:
                                            this.eval_au = true;
                                            this.eval_av = 0;
                                            this.eval_a9 = 0;
                                            this.eval_k();
                                            this.c(20000);
                                            flag = this.eval_d != 1;
                                            num2 = 2;
                                            num1 = num2;
                                            continue;
                                          case 78:
                                            num6 = 0;
                                            this.eval_bs.Text = "No connection...";
                                            flag = !this.eval_at;
                                            num2 = 8;
                                            num1 = num2;
                                            continue;
                                          case 79:
                                            if (flag)
                                            {
                                              ++this.h[4];
                                              this.eval_bx.Text = string.Format("Total reboots: {0}", (object) this.h[4]);
                                              flag = !this.eval_at;
                                              num2 = 12;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 34;
                                            num1 = num2;
                                            continue;
                                          default:
                                            goto label_33;
                                        }
                                      }
label_197:
                                      return;
label_193:
                                      return;
label_199:
                                      return;
label_206:
                                      return;
label_204:
                                      return;
                                  }
                                }
                                catch
                                {
                                  flag = !this.eval_at;
                                  if (!flag)
                                  {
label_139:
                                    num2 = -30203;
                                    int num6 = num2;
                                    num2 = -30203;
                                    int num7 = num2;
                                    switch (num6 == num7 ? 1 : 0)
                                    {
                                      case 0:
                                      case 2:
                                        goto label_139;
                                      default:
                                        num2 = 0;
                                        if (num2 == 0)
                                          ;
                                        this.eval_a("Battle.net: undefined error");
                                        break;
                                    }
                                  }
                                }
label_16:
                                num2 = 27;
                                num1 = num2;
                                continue;
                              case 31:
                                mainWindowHandle = process1.MainWindowHandle;
                                A_1_1 = new global::eval_e.eval_a(0, 0, 1, 1);
                                num4 = 0;
                                num3 = 0;
                                flag = !global::eval_e.GetWindowRect(mainWindowHandle, out A_1_1);
                                num2 = 17;
                                num1 = num2;
                                continue;
                              case 32:
                                flag = !this.eval_at;
                                num2 = 20;
                                num1 = num2;
                                continue;
                              case 33:
                                goto label_187;
                              case 34:
                                this.eval_a("Battle.net has a Window.");
                                num2 = 29;
                                num1 = num2;
                                continue;
                              case 35:
                                if (!flag)
                                {
                                  num2 = 6;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 2;
                              case 36:
                                num5 = 1;
                                break;
                              default:
                                goto label_9;
                            }
                            flag = num5 != 0;
                            num2 = 21;
                            num1 = num2;
                          }
label_187:
                          return;
label_191:
                          return;
label_208:
                          return;
                      }
                    }
                    catch (Exception ex)
                    {
                      return;
                    }
label_211:
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 2:
                    if (!flag)
                    {
                      num2 = 0;
                      num1 = num2;
                      continue;
                    }
                    goto case 1;
                  case 3:
                    goto label_175;
                  default:
                    goto label_3;
                }
              }
label_175:
              return;
          }
      }
    }

    private void eval_n()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              ++this.eval_av;
              flag = !this.eval_at;
              num2 = 4;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    goto label_60;
                  case 1:
                    Process process = Process.GetProcessesByName("Battle.net")[0];
                    global::eval_e.SetForegroundWindow(process.MainWindowHandle);
                    global::eval_e.SetWindowPos((int) process.MainWindowHandle, 0, 10, 10, 800, 600, 64U);
                    this.c(500);
                    global::eval_b.a(170, 60);
                    this.c(500);
                    global::eval_e.SetWindowPos((int) process.MainWindowHandle, 0, 10, 10, 800, 600, 64U);
                    this.c(500);
                    global::eval_b.a(170, 60);
                    this.c(2000);
                    global::eval_e.SetForegroundWindow(process.MainWindowHandle);
                    global::eval_b.a(70, 430);
                    this.c(2000);
                    global::eval_e.SetForegroundWindow(process.MainWindowHandle);
                    global::eval_b.a(300, 540);
                    flag = !this.eval_at;
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 2:
                    goto label_48;
                  case 3:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    this.eval_c();
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 4:
label_4:
                    if (!flag)
                    {
                      num2 = 6;
                      num1 = num2;
                      continue;
                    }
                    goto case 1;
                  case 5:
                    this.eval_a("HS: click on Play button");
                    num2 = 8;
                    num1 = num2;
                    continue;
                  case 6:
                    this.eval_a("HS: attempt to run acc " + (object) this.eval_p);
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 7:
                    if (!flag)
                    {
                      num2 = 3;
                      num1 = num2;
                      continue;
                    }
                    goto label_62;
                  case 8:
                    this.c(25000);
                    flag = this.eval_d != 1;
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 9:
                    if (!flag)
                    {
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    goto case 8;
                  case 10:
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 11:
                    if (flag)
                    {
                      try
                      {
                        int num3;
                        switch (0)
                        {
                          case 0:
label_17:
                            num3 = 0;
                            num2 = 17;
                            num1 = num2;
                            goto default;
                          default:
                            Process[] processesByName;
                            while (true)
                            {
                              switch (num1)
                              {
                                case 0:
                                  if (!flag)
                                  {
                                    num2 = 23;
                                    num1 = num2;
                                    continue;
                                  }
                                  flag = (int) processesByName[0].MainWindowHandle == 0;
                                  num2 = 20;
                                  num1 = num2;
                                  continue;
                                case 1:
                                  goto label_10;
                                case 2:
                                  goto label_57;
                                case 3:
                                case 10:
                                  flag = num3 != 10;
                                  num2 = 13;
                                  num1 = num2;
                                  continue;
                                case 4:
                                  if (!flag)
                                  {
                                    num2 = 12;
                                    num1 = num2;
                                    continue;
                                  }
                                  goto case 18;
                                case 5:
                                  num2 = 11;
                                  num1 = num2;
                                  continue;
                                case 6:
                                case 17:
                                  flag = num3 < 10;
                                  num2 = 21;
                                  num1 = num2;
                                  continue;
                                case 7:
                                  num2 = 1;
                                  num1 = num2;
                                  continue;
                                case 8:
                                  flag = !this.eval_at;
                                  num2 = 4;
                                  num1 = num2;
                                  continue;
                                case 9:
                                case 19:
                                  ++num3;
                                  num2 = 6;
                                  num1 = num2;
                                  continue;
                                case 11:
                                  goto label_53;
                                case 12:
                                  this.eval_a("HS: processes is not found :(");
                                  num2 = 18;
                                  num1 = num2;
                                  continue;
                                case 13:
                                  if (flag)
                                  {
                                    flag = !this.eval_at;
                                    num2 = 14;
                                    num1 = num2;
                                    continue;
                                  }
                                  num2 = 8;
                                  num1 = num2;
                                  continue;
                                case 14:
                                  if (!flag)
                                  {
                                    num2 = 15;
                                    num1 = num2;
                                    continue;
                                  }
                                  goto case 7;
                                case 15:
                                  this.eval_a("HS: process is found");
                                  num2 = 7;
                                  num1 = num2;
                                  continue;
                                case 16:
                                  if (flag)
                                  {
                                    num2 = 9;
                                    num1 = num2;
                                    continue;
                                  }
                                  num2 = 5;
                                  num1 = num2;
                                  continue;
                                case 18:
                                  num2 = 2;
                                  num1 = num2;
                                  continue;
                                case 20:
                                  if (!flag)
                                  {
                                    num2 = 22;
                                    num1 = num2;
                                    continue;
                                  }
                                  num2 = 19;
                                  num1 = num2;
                                  continue;
                                case 21:
                                  if (flag)
                                  {
                                    processesByName = Process.GetProcessesByName("Hearthstone");
                                    flag = processesByName.Length != 0;
                                    num2 = 0;
                                    num1 = num2;
                                    continue;
                                  }
                                  num2 = 10;
                                  num1 = num2;
                                  continue;
                                case 22:
                                  num2 = 3;
                                  num1 = num2;
                                  continue;
                                case 23:
                                  this.c(1500);
                                  flag = this.eval_d != 1;
                                  num2 = 16;
                                  num1 = num2;
                                  continue;
                                default:
                                  goto label_17;
                              }
                            }
label_53:
                            return;
label_57:
                            return;
                        }
                      }
                      catch (Exception ex)
                      {
                        if (!this.eval_at)
                          return;
                        this.eval_a("HS: undefined error");
                        return;
                      }
label_10:
                      flag = this.eval_as <= 0;
                      num2 = 7;
                      num1 = num2;
                      continue;
                    }
                    num2 = 11164;
                    int num4 = num2;
                    num2 = 11164;
                    int num5 = num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_4;
                      default:
                        num2 = 0;
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        num2 = 10;
                        num1 = num2;
                        continue;
                    }
                  default:
                    goto label_3;
                }
              }
label_48:
              return;
label_60:
              return;
label_62:
              return;
          }
      }
    }

    private void eval_m()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              flag = !this.eval_at;
              num2 = 0;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    if (!flag)
                    {
                      num2 = 0;
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    goto case 2;
                  case 1:
                    this.eval_a("HB: attempt to run");
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 2:
                    try
                    {
                      switch (0)
                      {
                        case 0:
label_8:
                          flag = this.eval_ar <= 0;
                          num2 = 51;
                          num1 = num2;
                          goto default;
                        default:
                          int num3;
                          string str1;
                          IntPtr mainWindowHandle;
                          string text;
                          int num4;
                          global::eval_e.eval_a A_1;
                          while (true)
                          {
                            switch (num1)
                            {
                              case 0:
                                if (!flag)
                                {
                                  num2 = 44;
                                  num1 = num2;
                                  continue;
                                }
                                this.c(5000);
                                ++num3;
                                num2 = 26;
                                num1 = num2;
                                continue;
                              case 1:
                                if (!flag)
                                {
                                  num2 = 8;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 20;
                              case 2:
                                if (!flag)
                                {
                                  num2 = 17;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 5;
                              case 3:
                                num2 = 20;
                                num1 = num2;
                                continue;
                              case 4:
                                settings_editor.CopyDirs(str1 + "\\Settings", this.eval_b, true);
                                num2 = 50;
                                num1 = num2;
                                continue;
                              case 5:
                                this.c(3000);
                                global::eval_e.SetForegroundWindow(mainWindowHandle);
                                SendKeys.SendWait("+{TAB}");
                                this.c(500);
                                global::eval_e.SetForegroundWindow(mainWindowHandle);
                                SendKeys.SendWait("+{TAB}");
                                this.c(2000);
                                global::eval_e.SetForegroundWindow(mainWindowHandle);
                                SendKeys.SendWait("{ENTER}");
                                text = this.eval_bs.Text;
                                this.eval_bs.Text = "Sleep 5min";
                                this.eval_a1 = true;
                                this.eval_bw.Visible = true;
                                this.c(300000);
                                flag = this.eval_d != 1;
                                num2 = 46;
                                num1 = num2;
                                continue;
                              case 6:
                                flag = !this.eval_at;
                                num2 = 32;
                                num1 = num2;
                                continue;
                              case 7:
                                this.eval_h();
                                flag = !this.eval_at;
                                num2 = 9;
                                num1 = num2;
                                continue;
                              case 8:
                                flag = num4 >= 170;
                                num2 = 36;
                                num1 = num2;
                                continue;
                              case 9:
                                if (!flag)
                                {
                                  num2 = 40;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 33;
                              case 10:
                                num2 = 35;
                                num1 = num2;
                                continue;
                              case 11:
                                Process process = new Process();
                                process.StartInfo.UseShellExecute = false;
                                process.StartInfo.FileName = this.eval_x;
                                process.StartInfo.Arguments = "--autostart --config:Default";
                                process.Start();
                                this.c(30000);
                                this.ba = process.Id;
                                num3 = 0;
                                num2 = 28;
                                num1 = num2;
                                continue;
                              case 12:
                                this.eval_a("HB: can't get main window");
                                num2 = 21;
                                num1 = num2;
                                continue;
                              case 13:
                                if (!flag)
                                {
                                  num2 = 16;
                                  num1 = num2;
                                  continue;
                                }
                                this.eval_h();
                                A_1 = new global::eval_e.eval_a(0, 0, 1, 1);
                                num4 = 0;
                                mainWindowHandle = Process.GetProcessById(this.ba).MainWindowHandle;
                                flag = !global::eval_e.GetWindowRect(mainWindowHandle, out A_1);
                                num2 = 38;
                                num1 = num2;
                                continue;
                              case 14:
                                str1 = this.eval_b + "\\hrstore\\" + this.eval_ab[this.eval_p].a.Replace("@", "");
                                flag = !File.Exists(str1 + "\\ok.txt");
                                num2 = 24;
                                num1 = num2;
                                continue;
                              case 15:
                                goto label_124;
                              case 16:
                                num2 = 31;
                                num1 = num2;
                                continue;
                              case 17:
                                this.eval_a("HB: detected new version - press *Yes* button");
                                num2 = 5;
                                num1 = num2;
                                continue;
                              case 18:
                                if (flag)
                                {
                                  this.c(2000);
                                  flag = this.eval_d != 1;
                                  num2 = 13;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 7;
                                num1 = num2;
                                continue;
                              case 19:
                                this.eval_d("HB: hang");
                                num2 = 30;
                                num1 = num2;
                                continue;
                              case 20:
                                num2 = 34;
                                num1 = num2;
                                continue;
                              case 21:
                                num2 = 48;
                                num1 = num2;
                                continue;
                              case 22:
                                goto label_123;
                              case 23:
                                if (!flag)
                                {
                                  num2 = 1;
                                  if (num2 == 0)
                                    ;
                                  num2 = 12;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 21;
                              case 24:
                                if (!flag)
                                {
                                  num2 = 4;
                                  num1 = num2;
                                  continue;
                                }
                                settings_editor.CopyDirs(this.eval_b + "\\hrstore\\DefaultSettings", this.eval_b, true);
                                num2 = 27;
                                num1 = num2;
                                continue;
                              case 25:
                              case 41:
                                flag = this.eval_b(this.ba);
                                num2 = 18;
                                num1 = num2;
                                continue;
                              case 26:
                              case 28:
                                flag = num3 < 5;
                                num2 = 43;
                                num1 = num2;
                                continue;
                              case 27:
                              case 50:
                                num2 = 11;
                                num1 = num2;
                                continue;
                              case 29:
                                if (flag)
                                {
                                  flag = !this.eval_b(this.ba);
                                  num2 = 0;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 42;
                                num1 = num2;
                                continue;
                              case 30:
                                goto label_122;
                              case 31:
                                goto label_120;
                              case 32:
                                if (!flag)
                                {
                                  num2 = 37;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 3;
                              case 33:
                                num2 = 45;
                                num1 = num2;
                                continue;
                              case 34:
                              case 48:
                                try
                                {
                                  int num5;
                                  switch (0)
                                  {
                                    case 0:
label_73:
                                      this.eval_l();
                                      this.c(5000);
                                      this.eval_i();
                                      num5 = 0;
                                      num2 = 1;
                                      num1 = num2;
                                      goto default;
                                    default:
                                      string str2;
                                      while (true)
                                      {
                                        switch (num1)
                                        {
                                          case 0:
                                            num2 = 8;
                                            num1 = num2;
                                            continue;
                                          case 1:
                                          case 19:
                                            flag = true;
                                            num2 = 3;
                                            num1 = num2;
                                            continue;
                                          case 2:
                                          case 14:
                                            this.c(1000);
                                            flag = this.eval_d != 1;
                                            num2 = 11;
                                            num1 = num2;
                                            continue;
                                          case 3:
                                            flag = this.eval_d != 1;
                                            num2 = 4;
                                            num1 = num2;
                                            continue;
                                          case 4:
                                            if (flag)
                                            {
                                              str2 = "";
                                              num2 = 10;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 0;
                                            num1 = num2;
                                            continue;
                                          case 5:
                                            if (flag)
                                            {
                                              this.c(1000);
                                              ++num5;
                                              flag = num5 <= 120;
                                              num2 = 13;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 17;
                                            num1 = num2;
                                            continue;
                                          case 6:
                                            num2 = 9;
                                            num1 = num2;
                                            continue;
                                          case 7:
                                            if (!flag)
                                            {
                                              num2 = 16;
                                              num1 = num2;
                                              continue;
                                            }
                                            goto case 6;
                                          case 8:
                                            goto label_112;
                                          case 9:
                                            goto label_113;
                                          case 10:
                                            try
                                            {
                                              str2 = File.ReadAllText(this.eval_v);
                                            }
                                            catch (Exception ex)
                                            {
                                            }
                                            flag = str2.LastIndexOf("[Stats] Enable") < 0;
                                            num2 = 5;
                                            num1 = num2;
                                            continue;
                                          case 11:
                                            if (flag)
                                            {
                                              flag = this.eval_as <= 0;
                                              num2 = 7;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 12;
                                            num1 = num2;
                                            continue;
                                          case 12:
                                            num2 = 15;
                                            num1 = num2;
                                            continue;
                                          case 13:
                                            if (flag)
                                            {
                                              num2 = 19;
                                              num1 = num2;
                                              continue;
                                            }
                                            num2 = 18;
                                            num1 = num2;
                                            continue;
                                          case 15:
                                            goto label_110;
                                          case 16:
                                            this.eval_b();
                                            num2 = 6;
                                            num1 = num2;
                                            continue;
                                          case 17:
                                            num2 = 2;
                                            num1 = num2;
                                            continue;
                                          case 18:
                                            num2 = 14;
                                            num1 = num2;
                                            continue;
                                          default:
                                            goto label_73;
                                        }
                                      }
label_110:
                                      return;
label_112:
                                      return;
                                  }
                                }
                                catch
                                {
                                }
label_113:
                                num2 = 22;
                                num1 = num2;
                                continue;
                              case 35:
                                goto label_116;
                              case 36:
                                if (flag)
                                {
                                  flag = !this.eval_at;
                                  num2 = 2;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 19;
                                num1 = num2;
                                continue;
                              case 37:
                                this.eval_a("HB: running successfully.");
                                num2 = 3;
                                num1 = num2;
                                continue;
                              case 38:
                                if (flag)
                                {
                                  flag = !this.eval_at;
                                  num2 = 23;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 49;
                                num1 = num2;
                                continue;
                              case 39:
                                goto label_114;
                              case 40:
                                this.eval_a("HB: not start :(");
                                num2 = 33;
                                num1 = num2;
                                continue;
                              case 42:
                                num2 = 15;
                                num1 = num2;
                                continue;
                              case 43:
                                if (!flag)
                                {
                                  num2 = 25;
                                  num1 = num2;
                                  continue;
                                }
                                flag = this.eval_d != 1;
                                num2 = 29;
                                num1 = num2;
                                continue;
                              case 44:
                                num2 = 41;
                                num1 = num2;
                                continue;
                              case 45:
                                goto label_108;
                              case 46:
                                if (!flag)
                                {
                                  num2 = 10;
                                  num1 = num2;
                                  continue;
                                }
                                this.eval_bw.Visible = false;
                                this.eval_bs.Text = text;
                                this.eval_g();
                                this.eval_d("HB: end update");
                                num2 = 39;
                                num1 = num2;
                                continue;
                              case 47:
                                if (flag)
                                {
                                  flag = num4 >= 400;
                                  num2 = 1;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 6;
                                num1 = num2;
                                continue;
                              case 49:
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                int num6 = A_1.eval_c() - A_1.eval_a();
                                // ISSUE: reference to a compiler-generated method
                                // ISSUE: reference to a compiler-generated method
                                num4 = A_1.eval_e() - A_1.eval_b();
                                flag = num6 <= 500;
                                num2 = 47;
                                num1 = num2;
                                continue;
                              case 51:
                                if (!flag)
                                {
                                  num2 = 14;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 11;
                              default:
                                goto label_8;
                            }
                          }
label_116:
                          return;
label_114:
                          return;
label_108:
                          return;
label_124:
                          return;
label_122:
                          return;
label_120:
                          return;
                      }
                    }
                    catch (Exception ex)
                    {
                      if (!this.eval_at)
                        return;
                      int num3 = 25856;
                      int num4 = 25856;
                      int num5 = num4;
                      switch (num3 == num5 ? 1 : 0)
                      {
                        case 0:
                          return;
                        case 2:
                          return;
                        default:
                          num4 = 0;
                          if (num4 == 0)
                            ;
                          this.eval_a("HB: undefined error 2");
                          return;
                      }
                    }
label_123:
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 3:
                    goto label_94;
                  default:
                    goto label_3;
                }
              }
label_94:
              return;
          }
      }
    }

    private void eval_l()
    {
      int num1 = 17394;
      int num2 = num1;
      num1 = 17394;
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
          this.ae = 0;
          this.eval_af = 0;
          this.eval_al = 0;
          this.eval_ag = "unknown";
          this.eval_an = -2;
          this.eval_am = 0;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_k()
    {
      int num1 = 1;
      if (num1 == 0)
        ;
      num1 = 0;
      int num2 = num1;
      switch (num2)
      {
        default:
          bool flag;
          switch (0)
          {
            case 0:
label_4:
              this.eval_j();
              flag = this.eval_d != 1;
              num1 = 14;
              num2 = num1;
              goto default;
            default:
              Process[] processesByName;
              IEnumerator enumerator;
              while (true)
              {
                switch (num2)
                {
                  case 0:
                    goto label_48;
                  case 1:
                    goto label_44;
                  case 2:
                    num1 = 1;
                    num2 = num1;
                    continue;
                  case 3:
                    try
                    {
                      num1 = 5;
                      num2 = num1;
                      while (true)
                      {
                        switch (num2)
                        {
                          case 0:
                            if (!flag)
                            {
                              num1 = 2;
                              num2 = num1;
                              continue;
                            }
                            num1 = 7;
                            num2 = num1;
                            continue;
                          case 1:
                            if (flag)
                            {
                              flag = !(((InputLanguage) enumerator.Current).Culture.ToString() == "en-US");
                              num1 = 0;
                              num2 = num1;
                              continue;
                            }
                            num1 = 3;
                            num2 = num1;
                            continue;
                          case 2:
                            global::eval_e.PostMessage(global::eval_e.GetForegroundWindow(), 80, 1, global::eval_e.LoadKeyboardLayout("00000409", 1U));
                            num1 = 6;
                            num2 = num1;
                            continue;
                          case 3:
                          case 6:
                            num1 = 4;
                            num2 = num1;
                            continue;
                          case 4:
                            goto label_8;
                          case 5:
                            switch (0)
                            {
                              case 0:
                                break;
                              default:
                                continue;
                            }
                        }
                        flag = enumerator.MoveNext();
                        num1 = 1;
                        num2 = num1;
                      }
                    }
                    finally
                    {
                      IDisposable disposable;
                      int num3;
                      switch (0)
                      {
                        case 0:
label_34:
                          disposable = enumerator as IDisposable;
                          flag = disposable == null;
                          num3 = 1;
                          num2 = num3;
                          goto default;
                        default:
                          while (true)
                          {
                            switch (num2)
                            {
                              case 0:
                                disposable.Dispose();
                                num3 = 2;
                                num2 = num3;
                                continue;
                              case 1:
                                num3 = -22597;
                                int num4 = num3;
                                num3 = -22597;
                                int num5 = num3;
                                switch (num4 == num5 ? 1 : 0)
                                {
                                  case 0:
                                  case 2:
                                    goto label_42;
                                  default:
                                    num3 = 0;
                                    if (num3 == 0)
                                      ;
                                    if (!flag)
                                    {
                                      num3 = 0;
                                      num2 = num3;
                                      continue;
                                    }
                                    goto label_42;
                                }
                              case 2:
                                goto label_42;
                              default:
                                goto label_34;
                            }
                          }
label_42:;
                      }
                    }
label_8:
                    num1 = 10;
                    num2 = num1;
                    continue;
                  case 4:
                    flag = !(InputLanguage.CurrentInputLanguage.Culture.ToString().ToString() != "en-US");
                    num1 = 11;
                    num2 = num1;
                    continue;
                  case 5:
                    goto label_41;
                  case 6:
                    if (!flag)
                    {
                      num1 = 2;
                      num2 = num1;
                      continue;
                    }
                    global::eval_e.SetForegroundWindow(processesByName[0].MainWindowHandle);
                    SendKeys.SendWait(this.eval_ab[this.eval_p].a.Replace("+", "{+}"));
                    this.c(1000);
                    flag = this.eval_d != 1;
                    num1 = 12;
                    num2 = num1;
                    continue;
                  case 7:
                    num1 = 0;
                    num2 = num1;
                    continue;
                  case 8:
                    goto label_39;
                  case 9:
                    num1 = 5;
                    num2 = num1;
                    continue;
                  case 10:
                    global::eval_e.SetForegroundWindow(processesByName[0].MainWindowHandle);
                    SendKeys.SendWait(this.eval_ab[this.eval_p].b.Replace("+", "{+}"));
                    SendKeys.SendWait("+{TAB}");
                    this.c(2000);
                    flag = this.eval_d != 1;
                    num1 = 6;
                    num2 = num1;
                    continue;
                  case 11:
                    if (!flag)
                    {
                      num1 = 15;
                      num2 = num1;
                      continue;
                    }
                    goto case 10;
                  case 12:
                    if (flag)
                    {
                      num1 = 0;
                      global::eval_e.SetForegroundWindow(processesByName[0].MainWindowHandle);
                      SendKeys.SendWait("{ENTER}");
                      this.c(1000);
                      global::eval_e.SetForegroundWindow(processesByName[0].MainWindowHandle);
                      SendKeys.SendWait("{ENTER}");
                      this.c(2000);
                      this.eval_a(true);
                      this.eval_a(false);
                      this.eval_q = 0;
                      num1 = 8;
                      num2 = num1;
                      continue;
                    }
                    num1 = 9;
                    num2 = num1;
                    continue;
                  case 13:
                    if (!flag)
                    {
                      num1 = 4;
                      num2 = num1;
                      continue;
                    }
                    goto label_50;
                  case 14:
                    if (!flag)
                    {
                      num1 = 7;
                      num2 = num1;
                      continue;
                    }
                    processesByName = Process.GetProcessesByName("Battle.net");
                    flag = processesByName.GetLength(0) <= 0;
                    num1 = 13;
                    num2 = num1;
                    continue;
                  case 15:
                    enumerator = InputLanguage.InstalledInputLanguages.GetEnumerator();
                    num1 = 3;
                    num2 = num1;
                    continue;
                  default:
                    goto label_4;
                }
              }
label_41:
              return;
label_39:
              return;
label_48:
              return;
label_44:
              return;
label_50:
              return;
          }
      }
    }

    private void eval_j()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          bool flag1;
          int num3;
          switch (0)
          {
            case 0:
label_3:
              this.eval_f = 0;
              num2 = 0;
              flag1 = !this.eval_ad;
              num3 = 17;
              num1 = num3;
              goto default;
            default:
              while (true)
              {
                DateTime dateTime;
                double num4;
                int num5;
                bool flag2;
                int num6;
                int num7;
                int num8;
                int num9;
                int num10;
                int num11;
                int num12;
                switch (num1)
                {
                  case 0:
                    this.eval_d = 1;
                    this.eval_f = 1;
                    this.eval_bs.Text = "Sleep...30 Wins";
                    num3 = 5;
                    num1 = num3;
                    continue;
                  case 1:
                    if (!this.eval_by.Checked)
                    {
                      num3 = 11;
                      num1 = num3;
                      continue;
                    }
                    num3 = 59;
                    num1 = num3;
                    continue;
                  case 2:
                    if (!flag2)
                    {
                      num3 = 9;
                      num1 = num3;
                      continue;
                    }
                    goto label_80;
                  case 3:
                    num7 = 1;
                    goto label_71;
                  case 4:
                    goto label_109;
                  case 5:
                  case 47:
                  case 51:
                    num3 = 4;
                    num1 = num3;
                    continue;
                  case 6:
                    if (!(this.eval_ab[this.eval_p].b == ""))
                    {
                      num3 = 25;
                      num1 = num3;
                      continue;
                    }
                    goto label_80;
                  case 7:
                    if (!(this.eval_ab[this.eval_p].a == ""))
                    {
                      num3 = 65;
                      num1 = num3;
                      continue;
                    }
                    goto label_80;
                  case 8:
                    num8 = 0;
                    goto label_106;
                  case 9:
                    num3 = 57;
                    num1 = num3;
                    continue;
                  case 10:
                    num3 = 27;
                    num1 = num3;
                    continue;
                  case 11:
                    num9 = 1;
                    break;
                  case 12:
                    flag1 = num2 != 1;
                    num3 = 44;
                    num1 = num3;
                    continue;
                  case 13:
                    goto label_103;
                  case 14:
                    num8 = this.eval_ab[this.eval_p].g <= 29 ? 1 : 0;
                    goto label_106;
                  case 15:
                    num10 = 1;
                    goto label_90;
                  case 16:
                    num3 = 40;
                    num1 = num3;
                    continue;
                  case 17:
                    if (!flag1)
                    {
                      num3 = 37;
                      num1 = num3;
                      continue;
                    }
                    num5 = 1;
                    num3 = 32;
                    num1 = num3;
                    continue;
                  case 18:
                    this.eval_d = 1;
                    this.eval_f = 1;
                    this.eval_bs.Text = "Ac Quests done";
                    num3 = 51;
                    num1 = num3;
                    continue;
                  case 19:
                    if (!flag1)
                    {
                      num3 = 18;
                      num1 = num3;
                      continue;
                    }
                    goto case 5;
                  case 20:
                    if (!flag1)
                    {
                      num3 = 46;
                      num1 = num3;
                      continue;
                    }
                    goto case 64;
                  case 21:
                    num3 = 26;
                    num1 = num3;
                    continue;
                  case 22:
                    if (!flag1)
                    {
                      num3 = 66;
                      num1 = num3;
                      continue;
                    }
                    num3 = 1;
                    num1 = num3;
                    continue;
                  case 23:
                    num3 = 14;
                    num1 = num3;
                    continue;
                  case 24:
                    num4 = TimeSpan.Parse(this.eval_ab[this.eval_p].f).TotalMinutes;
                    num3 = 36;
                    num1 = num3;
                    continue;
                  case 25:
                    num3 = 29;
                    num1 = num3;
                    continue;
                  case 26:
                    num7 = !(this.eval_ab[this.eval_p].f != "--:--") ? 1 : 0;
                    goto label_71;
                  case 27:
                    num11 = !(this.eval_ab[this.eval_p].b == "") ? 1 : 0;
                    goto label_47;
                  case 28:
                    this.eval_d = 1;
                    this.eval_f = 1;
                    num3 = 60;
                    num1 = num3;
                    continue;
                  case 29:
                    if (num4 < (double) (60 * this.eval_ab[this.eval_p].eval_e))
                    {
                      num3 = 58;
                      num1 = num3;
                      continue;
                    }
                    goto label_80;
                  case 30:
                    num3 = 0;
                    this.eval_q();
                    this.eval_q = 1;
                    num2 = 1;
                    num3 = 55;
                    num1 = num3;
                    continue;
                  case 31:
                    if (!flag1)
                    {
                      num3 = 24;
                      num1 = num3;
                      continue;
                    }
                    goto case 36;
                  case 32:
                  case 35:
                    flag1 = num5 <= this.bb;
                    num3 = 61;
                    num1 = num3;
                    continue;
                  case 33:
                    if (flag1)
                    {
                      num3 = 39;
                      num1 = num3;
                      continue;
                    }
                    num3 = 30;
                    num1 = num3;
                    continue;
                  case 34:
                    string str1 = this.eval_ab[this.eval_p].eval_i;
                    dateTime = DateTime.UtcNow;
                    dateTime = dateTime.AddMinutes(120.0);
                    string str2 = dateTime.ToString("yyyyMMdd");
                    num12 = !(str1 == str2) ? 1 : 0;
                    goto label_87;
                  case 36:
                    flag2 = false;
                    num3 = 54;
                    num1 = num3;
                    continue;
                  case 37:
                    dateTime = DateTime.Now;
                    int num13 = (int) dateTime.DayOfWeek;
                    dateTime = DateTime.Now;
                    num6 = this.eval_ac[dateTime.Hour + 24 * num13];
                    flag1 = num6 != 0;
                    num3 = 48;
                    num1 = num3;
                    continue;
                  case 38:
                    num9 = this.eval_ab[this.eval_p].g <= 29 ? 1 : 0;
                    break;
                  case 39:
                    goto label_97;
                  case 40:
                    string str3 = this.eval_ab[this.eval_p].eval_i;
                    dateTime = DateTime.UtcNow;
                    dateTime = dateTime.AddMinutes(120.0);
                    string str4 = dateTime.ToString("yyyyMMdd");
                    num10 = !(str3 == str4) ? 1 : 0;
                    goto label_90;
                  case 41:
                    if (string.IsNullOrEmpty(this.eval_ab[this.eval_p].f))
                    {
                      num3 = 3;
                      num1 = num3;
                      continue;
                    }
                    num3 = 21;
                    num1 = num3;
                    continue;
                  case 42:
                    if (this.eval_ab[this.eval_p].a == "")
                    {
                      num3 = 52;
                      num1 = num3;
                      continue;
                    }
                    num3 = 10;
                    num1 = num3;
                    continue;
                  case 43:
                    num12 = 1;
                    goto label_87;
                  case 44:
                    if (!flag1)
                    {
                      num3 = 28;
                      num1 = num3;
                      continue;
                    }
                    goto case 62;
                  case 45:
                    num8 = 1;
                    goto label_106;
                  case 46:
                    flag2 = true;
                    num3 = 64;
                    num1 = num3;
                    continue;
                  case 48:
                    if (!flag1)
                    {
                      num3 = 49;
                      num1 = num3;
                      continue;
                    }
                    this.eval_p = num6 - 1;
                    num3 = 42;
                    num1 = num3;
                    continue;
                  case 49:
                    this.eval_d = 1;
                    this.eval_f = 1;
                    this.eval_bs.Text = "Sleep...";
                    num3 = 1;
                    if (num3 == 0)
                      ;
                    num3 = 13;
                    num1 = num3;
                    continue;
                  case 50:
                    goto label_93;
                  case 52:
                    num11 = 0;
                    goto label_47;
                  case 53:
                    num3 = 34;
                    num1 = num3;
                    continue;
                  case 54:
                    if (!this.eval_ah)
                    {
                      num3 = 15;
                      num1 = num3;
                      continue;
                    }
                    num3 = 16;
                    num1 = num3;
                    continue;
                  case 55:
                    ++num5;
                    num3 = 35;
                    num1 = num3;
                    continue;
                  case 56:
                    if (this.eval_ah)
                    {
                      num3 = 53;
                      num1 = num3;
                      continue;
                    }
                    num3 = 43;
                    num1 = num3;
                    continue;
                  case 57:
                    if (this.eval_by.Checked)
                    {
                      num3 = 23;
                      num1 = num3;
                      continue;
                    }
                    num3 = 45;
                    num1 = num3;
                    continue;
                  case 58:
                    num3 = 2;
                    num1 = num3;
                    continue;
                  case 59:
label_104:
                    num3 = 38;
                    num1 = num3;
                    continue;
                  case 60:
                    this.eval_bs.Text = this.eval_ah ? "Quest's done!" : "Job's done!";
                    num3 = 62;
                    num1 = num3;
                    continue;
                  case 61:
                    if (flag1)
                    {
                      num2 = 0;
                      num4 = 0.0;
                      num3 = 41;
                      num1 = num3;
                      continue;
                    }
                    num3 = 12;
                    num1 = num3;
                    continue;
                  case 62:
                    num3 = 50;
                    num1 = num3;
                    continue;
                  case 63:
                    if (flag1)
                    {
                      num3 = 56;
                      num1 = num3;
                      continue;
                    }
                    num3 = 0;
                    num1 = num3;
                    continue;
                  case 64:
                    num3 = 7;
                    num1 = num3;
                    continue;
                  case 65:
                    num3 = 6;
                    num1 = num3;
                    continue;
                  case 66:
                    num3 = 22236;
                    int num14 = num3;
                    num3 = 22236;
                    int num15 = num3;
                    switch (num14 == num15 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_104;
                      default:
                        num3 = 0;
                        if (num3 == 0)
                          ;
                        this.eval_d = 1;
                        this.eval_f = 1;
                        this.eval_bs.Text = "Empty acc...";
                        num3 = 47;
                        num1 = num3;
                        continue;
                    }
                  default:
                    goto label_3;
                }
                flag1 = num9 != 0;
                num3 = 63;
                num1 = num3;
                continue;
label_47:
                flag1 = num11 != 0;
                num3 = 22;
                num1 = num3;
                continue;
label_71:
                flag1 = num7 != 0;
                num3 = 31;
                num1 = num3;
                continue;
label_80:
                num3 = 8;
                num1 = num3;
                continue;
label_87:
                flag1 = num12 != 0;
                num3 = 19;
                num1 = num3;
                continue;
label_90:
                flag1 = num10 != 0;
                num3 = 20;
                num1 = num3;
                continue;
label_106:
                flag1 = num8 != 0;
                num3 = 33;
                num1 = num3;
              }
label_97:
              return;
label_93:
              return;
label_109:
              return;
label_103:
              return;
          }
      }
    }

    private void eval_i()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          try
          {
            int num2 = -3212;
            int num3 = -3212;
            int num4 = num3;
            switch (num2 == num4 ? 1 : 0)
            {
              case 0:
              case 2:
                break;
              default:
                num3 = 0;
                if (num3 == 0)
                  ;
                IEnumerator<string> enumerator = Directory.EnumerateFiles(this.eval_a6).GetEnumerator();
                bool flag;
                try
                {
                  num3 = 5;
                  num1 = num3;
                  while (true)
                  {
                    string current;
                    DateTime lastWriteTime;
                    switch (num1)
                    {
                      case 0:
                        num3 = 7;
                        num1 = num3;
                        continue;
                      case 1:
                        if (!flag)
                        {
                          num3 = 3;
                          num1 = num3;
                          continue;
                        }
                        goto case 2;
                      case 2:
                        num3 = 4;
                        num1 = num3;
                        continue;
                      case 3:
                        this.eval_t = lastWriteTime;
                        this.eval_v = current;
                        num3 = 2;
                        num1 = num3;
                        continue;
                      case 5:
                        switch (0)
                        {
                          case 0:
                            break;
                          default:
                            continue;
                        }
                      case 6:
                        if (flag)
                        {
                          current = enumerator.Current;
                          lastWriteTime = File.GetLastWriteTime(current);
                          flag = !(lastWriteTime > this.eval_t);
                          num3 = 1;
                          num1 = num3;
                          continue;
                        }
                        num3 = 0;
                        num1 = num3;
                        continue;
                      case 7:
                        goto label_27;
                    }
                    flag = enumerator.MoveNext();
                    num3 = 6;
                    num1 = num3;
                  }
                }
                finally
                {
                  int num5;
                  switch (0)
                  {
                    case 0:
label_19:
                      flag = enumerator == null;
                      num5 = 0;
                      num1 = num5;
                      goto default;
                    default:
                      while (true)
                      {
                        switch (num1)
                        {
                          case 0:
                            if (!flag)
                            {
                              num5 = 1;
                              num1 = num5;
                              continue;
                            }
                            goto label_24;
                          case 1:
                            enumerator.Dispose();
                            num5 = 2;
                            num1 = num5;
                            continue;
                          case 2:
                            goto label_24;
                          default:
                            goto label_19;
                        }
                      }
label_24:;
                  }
                }
            }
          }
          catch (Exception ex)
          {
            int num2 = (int) MessageBox.Show("Error 8412", ex.Message);
          }
label_27:
          if (1 != 0)
            break;
          break;
      }
    }

    private void eval_h()
    {
      int num1;
      int num2;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          num2 = 1;
          if (num2 == 0)
            ;
          this.eval_i();
          flag = this.eval_w().LastIndexOf(" - TRIPWIRE") < 0;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                num2 = 0;
                num2 = 19932;
                int num3 = num2;
                num2 = 19932;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    goto label_10;
                }
              case 1:
                if (flag)
                  goto case 0;
                else
                  break;
              case 2:
                this.eval_d("HB: TRIPWIRE");
                Process.Start(this.eval_v);
                Application.Exit();
                this.eval_d = 1;
                num2 = 0;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
            num2 = 2;
            num1 = num2;
          }
label_10:
          num2 = 0;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_d(string A_0)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          flag1 = !this.eval_at;
          num1 = 31;
          num2 = num1;
          goto default;
        default:
          while (true)
          {
            num1 = 0;
            bool flag2;
            int num3;
            int num4;
            int num5;
            int num6;
            int num7;
            switch (num2)
            {
              case 0:
                flag1 = !this.eval_c("Battle.net");
                num1 = 14;
                num2 = num1;
                continue;
              case 1:
                num1 = 32;
                num2 = num1;
                continue;
              case 2:
                num1 = 24;
                num2 = num1;
                continue;
              case 3:
                flag1 = !this.eval_c("WerFault");
                num1 = 17;
                num2 = num1;
                continue;
              case 4:
                flag2 = true;
                num1 = 34;
                num2 = num1;
                continue;
              case 5:
                if (!flag1)
                {
                  num1 = 1;
                  num2 = num1;
                  continue;
                }
                goto case 22;
              case 6:
                num3 = 0;
                goto label_49;
              case 7:
                this.eval_a("Close all: " + A_0);
                num1 = 4;
                num2 = num1;
                continue;
              case 8:
                num4 = 0;
                goto label_61;
              case 9:
                num5 = 0;
                goto label_66;
              case 10:
                num1 = 13;
                num2 = num1;
                continue;
              case 11:
                num3 = this.eval_b("Hearthstone") ? 1 : 0;
                goto label_49;
              case 12:
                num6 = 0;
                goto label_67;
              case 13:
                num7 = this.eval_b(Process.GetProcessById(this.ba).ProcessName) ? 1 : 0;
                break;
              case 14:
                if (!flag1)
                {
                  num1 = 21;
                  num2 = num1;
                  continue;
                }
                goto case 3;
              case 15:
                if (!flag2)
                {
                  num1 = 9;
                  num2 = num1;
                  continue;
                }
                num1 = 23;
                num2 = num1;
                continue;
              case 16:
                num1 = 28;
                num2 = num1;
                continue;
              case 17:
                if (!flag1)
                {
                  num1 = 27;
                  num2 = num1;
                  continue;
                }
                goto case 20;
              case 18:
                if (!flag1)
                {
                  num1 = 29;
                  num2 = num1;
                  continue;
                }
                goto case 35;
              case 19:
                if (!flag1)
                {
                  num1 = 25;
                  num2 = num1;
                  continue;
                }
                goto case 34;
              case 20:
                flag1 = !this.eval_c("BlizzardError");
                num1 = 5;
                num2 = num1;
                continue;
              case 21:
                num1 = 15;
                num2 = num1;
                continue;
              case 22:
                flag1 = !flag2;
                num1 = 19;
                num2 = num1;
                continue;
              case 23:
                num1 = 33;
                num2 = num1;
                continue;
              case 24:
                num4 = this.eval_b("BlizzardError") ? 1 : 0;
                goto label_61;
              case 25:
                goto label_68;
              case 26:
                if (!flag2)
                {
                  num1 = 6;
                  num2 = num1;
                  continue;
                }
                num1 = 37;
                num2 = num1;
                continue;
              case 27:
                num1 = 36;
                num2 = num1;
                continue;
              case 28:
                num6 = this.eval_b("WerFault") ? 1 : 0;
                goto label_67;
              case 29:
                num1 = 30;
                num2 = num1;
                continue;
              case 30:
                if (!flag2)
                {
                  num1 = -24788;
                  int num8 = num1;
                  num1 = -24788;
                  int num9 = num1;
                  switch (num8 == num9 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      goto label_56;
                    default:
                      num1 = 0;
                      if (num1 == 0)
                        ;
                      num1 = 39;
                      num2 = num1;
                      continue;
                  }
                }
                else
                {
                  num1 = 10;
                  num2 = num1;
                  continue;
                }
              case 31:
                if (!flag1)
                {
                  num1 = 7;
                  num2 = num1;
                  continue;
                }
                goto case 4;
              case 32:
                if (flag2)
                {
                  num1 = 2;
                  num2 = num1;
                  continue;
                }
                num1 = 8;
                num2 = num1;
                continue;
              case 33:
                num5 = this.eval_b("Battle.net") ? 1 : 0;
                goto label_66;
              case 34:
                flag2 = true;
                flag1 = !this.eval_b(this.ba);
                num1 = 18;
                num2 = num1;
                continue;
              case 35:
                flag1 = !this.eval_c("Hearthstone");
                num1 = 38;
                num2 = num1;
                continue;
              case 36:
                if (flag2)
                {
                  num1 = 16;
                  num2 = num1;
                  continue;
                }
                num1 = 12;
                num2 = num1;
                continue;
              case 37:
label_56:
                num1 = 11;
                num2 = num1;
                continue;
              case 38:
                if (!flag1)
                {
                  num1 = 40;
                  num2 = num1;
                  continue;
                }
                goto case 0;
              case 39:
                num7 = 0;
                break;
              case 40:
                num1 = 1;
                if (num1 == 0)
                  ;
                num1 = 26;
                num2 = num1;
                continue;
              default:
                goto label_2;
            }
            flag2 = num7 != 0;
            num1 = 35;
            num2 = num1;
            continue;
label_49:
            flag2 = num3 != 0;
            num1 = 0;
            num2 = num1;
            continue;
label_61:
            flag2 = num4 != 0;
            num1 = 22;
            num2 = num1;
            continue;
label_66:
            flag2 = num5 != 0;
            num1 = 3;
            num2 = num1;
            continue;
label_67:
            flag2 = num6 != 0;
            num1 = 20;
            num2 = num1;
          }
label_68:
          this.eval_s = false;
          this.h[2] = 0;
          this.h[3] = 0;
          this.c(1500);
          break;
      }
    }

    private void c(int A_0)
    {
      int num1;
      long num2;
      int num3;
      switch (0)
      {
        case 0:
label_2:
          this.z.Reset();
          this.z.Start();
          num2 = 0L;
          num3 = 0;
          num1 = num3;
          goto default;
        default:
          while (true)
          {
            bool flag;
            int num4;
            switch (num1)
            {
              case 0:
              case 5:
                flag = this.z.ElapsedMilliseconds <= (long) A_0;
                num3 = 3;
                num1 = num3;
                continue;
              case 1:
                num3 = 11;
                num1 = num3;
                continue;
              case 2:
                if (!this.eval_a1)
                {
                  num3 = 7;
                  num1 = num3;
                  continue;
                }
                num3 = 1;
                num1 = num3;
                continue;
              case 3:
label_18:
                if (flag)
                {
                  Application.DoEvents();
                  flag = this.eval_d != 1;
                  num3 = 8;
                  num1 = num3;
                  continue;
                }
                num3 = 4;
                num1 = num3;
                continue;
              case 4:
              case 10:
                goto label_25;
              case 6:
                num3 = 0;
                num3 = 5;
                num1 = num3;
                continue;
              case 7:
                num4 = 1;
                break;
              case 8:
                if (!flag)
                {
                  num3 = 9;
                  num1 = num3;
                  continue;
                }
                Thread.Sleep(1);
                num3 = 2;
                num1 = num3;
                continue;
              case 9:
                num3 = 10;
                num1 = num3;
                continue;
              case 11:
                num4 = this.z.ElapsedMilliseconds <= num2 ? 1 : 0;
                break;
              case 12:
                this.eval_bw.Text = new StringBuilder("", 5).Append("Break ").Append(num2 / 1000L / 60L).Append(" out of ").Append(A_0 / 1000 / 60).Append(" min").ToString();
                num2 = 1000L + this.z.ElapsedMilliseconds;
                num3 = 32491;
                int num5 = num3;
                num3 = 32491;
                int num6 = num3;
                switch (num5 == num6 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_18;
                  default:
                    num3 = 0;
                    if (num3 == 0)
                      ;
                    num3 = 6;
                    num1 = num3;
                    continue;
                }
              case 13:
                if (!flag)
                {
                  num3 = 12;
                  num1 = num3;
                  continue;
                }
                goto case 6;
              default:
                goto label_2;
            }
            flag = num4 != 0;
            num3 = 1;
            if (num3 == 0)
              ;
            num3 = 13;
            num1 = num3;
          }
label_25:
          this.z.Stop();
          this.eval_a1 = false;
          break;
      }
    }

    private void eval_g()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          Process[] processes;
          int index;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              processes = Process.GetProcesses();
              index = 0;
              num2 = 12;
              num1 = num2;
              goto default;
            default:
              Process process;
              bool flag;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    if (!flag)
                    {
                      num2 = 10;
                      num1 = num2;
                      continue;
                    }
                    flag = !process.ProcessName.StartsWith("System");
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 1:
                    if (flag)
                    {
                      num2 = 0;
                      flag = !process.ProcessName.StartsWith("Idle");
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 2:
                  case 3:
                  case 7:
                  case 14:
                    ++index;
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 4:
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 5:
                    if (!flag)
                    {
                      num2 = 6;
                      num1 = num2;
                      continue;
                    }
                    try
                    {
                      switch (0)
                      {
                        case 0:
label_14:
                          num2 = 9;
                          num1 = num2;
                          goto default;
                        default:
                          while (true)
                          {
                            int num3;
                            switch (num1)
                            {
                              case 0:
                                if (!flag)
                                {
                                  num2 = 7;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 1;
                              case 1:
                                num2 = 10;
                                num1 = num2;
                                continue;
                              case 2:
                                num3 = !process.MainWindowTitle.StartsWith("Hearthbuddy[") ? 1 : 0;
                                break;
                              case 3:
                                goto label_39;
                              case 4:
label_19:
                                num2 = 2;
                                num1 = num2;
                                continue;
                              case 5:
                                num3 = 0;
                                break;
                              case 6:
                                if (!flag)
                                {
                                  num2 = 8;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = -26412;
                                int num4 = num2;
                                num2 = -26412;
                                int num5 = num2;
                                switch (num4 == num5 ? 1 : 0)
                                {
                                  case 0:
                                  case 2:
                                    goto label_19;
                                  default:
                                    num2 = 0;
                                    if (num2 == 0)
                                      ;
                                    num2 = 3;
                                    num1 = num2;
                                    continue;
                                }
                              case 7:
                                this.eval_a("HB id " + this.ba.ToString());
                                num2 = 1;
                                num1 = num2;
                                continue;
                              case 8:
                                this.ba = process.Id;
                                flag = !this.eval_at;
                                num2 = 0;
                                num1 = num2;
                                continue;
                              case 9:
                                if (!(process.MainModule.ModuleName == "Hearthbuddy.exe"))
                                {
                                  num2 = 4;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 5;
                                num1 = num2;
                                continue;
                              case 10:
                                goto label_48;
                              default:
                                goto label_14;
                            }
                            flag = num3 != 0;
                            num2 = 6;
                            num1 = num2;
                          }
label_48:
                          return;
                      }
                    }
                    catch
                    {
                    }
label_39:
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 6:
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 8:
                    if (flag)
                    {
                      flag = !process.ProcessName.StartsWith("Hearthstone");
                      num2 = 0;
                      num1 = num2;
                      continue;
                    }
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 9:
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 10:
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 11:
                    num2 = 1;
                    if (num2 == 0)
                      goto case 2;
                    else
                      goto case 2;
                  case 12:
                  case 13:
                    flag = index < processes.Length;
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 15:
                    goto label_44;
                  case 16:
                    if (!flag)
                    {
                      num2 = 15;
                      num1 = num2;
                      continue;
                    }
                    process = processes[index];
                    flag = !process.ProcessName.StartsWith("Battle.net");
                    num2 = 8;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_44:
              return;
          }
      }
    }

    private bool eval_c(string A_0)
    {
      int num1 = -6112;
      int num2 = num1;
      num1 = -6112;
      int num3 = num1;
      int num4;
      bool flag;
      switch (num2 == num3 ? 1 : 0)
      {
        case 0:
        case 2:
          return flag;
        case 1:
          num4 = 1;
          if (num4 == 0)
            ;
          num4 = 0;
          if (num4 == 0)
            ;
          // ISSUE: object of a compiler-generated type is created
          // ISSUE: reference to a compiler-generated method
          flag = Enumerable.Any<Process>((IEnumerable<Process>) Process.GetProcesses(), new Func<Process, bool>(new Form1.eval_a()
          {
            a = A_0
          }.eval_a));
          goto case 0;
        default:
          num4 = 0;
          goto case 1;
      }
    }

    private bool eval_b(int A_0)
    {
      int num1;
      bool flag1;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag1 = A_0 >= 0;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          bool flag2;
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_12;
              case 1:
                num2 = -30566;
                int num3 = num2;
                num2 = -30566;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    num2 = 0;
                    num2 = 2;
                    num1 = num2;
                    continue;
                  default:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    if (flag1)
                      goto label_8;
                    else
                      goto case 0;
                }
              case 2:
                flag2 = false;
                num2 = 0;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_8:
          try
          {
            Process.GetProcessById(A_0);
            flag2 = true;
          }
          catch (ArgumentException ex)
          {
            flag2 = false;
          }
          catch (InvalidOperationException ex)
          {
            flag2 = false;
          }
label_12:
          return flag2;
      }
    }

    private bool eval_b(string A_0)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          Process[] processes;
          int index;
          Process process;
          bool flag1;
          switch (0)
          {
            case 0:
label_3:
              num2 = 0;
              num2 = -21965;
              int num3 = num2;
              num2 = -21965;
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
                  processes = Process.GetProcesses();
                  index = 0;
                  num2 = 8;
                  num1 = num2;
                  goto label_2;
              }
            default:
label_2:
              bool flag2;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                  case 1:
                  case 6:
                    goto label_23;
                  case 2:
                    flag2 = false;
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 3:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 5;
                    num1 = num2;
                    continue;
                  case 4:
                    if (flag1)
                    {
                      ++index;
                      num2 = 10;
                      num1 = num2;
                      continue;
                    }
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 5:
                    goto label_18;
                  case 7:
                    process.Close();
                    flag2 = true;
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 8:
                  case 10:
                    flag1 = index < processes.Length;
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 9:
                    if (flag1)
                    {
                      flag2 = false;
                      num2 = 0;
                      num1 = num2;
                      continue;
                    }
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 11:
                    if (!flag1)
                    {
                      num2 = 2;
                      num1 = num2;
                      continue;
                    }
                    process = processes[index];
                    flag1 = !process.ProcessName.StartsWith(A_0);
                    num2 = 4;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_18:
              try
              {
                process.Kill();
                break;
              }
              catch (Exception ex)
              {
                flag2 = false;
              }
label_23:
              return flag2;
          }
          flag1 = !process.WaitForExit(3000);
          num2 = 9;
          num1 = num2;
          goto default;
      }
    }

    private void eval_aa(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag;
      int num3;
      int num4;
      switch (0)
      {
        case 0:
label_2:
          RadioButton radioButton = (RadioButton) A_0;
          num2 = Convert.ToInt32(radioButton.Tag);
          flag = !radioButton.Checked;
          num3 = -27668;
          int num5 = num3;
          num3 = -27668;
          int num6 = num3;
          switch (num5 == num6 ? 1 : 0)
          {
            case 0:
            case 2:
              break;
            default:
              num3 = 0;
              if (num3 == 0)
                ;
              num3 = 1;
              if (num3 == 0)
                ;
              num3 = 3;
              num1 = num3;
              goto label_1;
          }
        default:
label_1:
          while (true)
          {
            switch (num1)
            {
              case 0:
                num3 = 1;
                num1 = num3;
                continue;
              case 1:
                if (this.c <= 1)
                {
                  num3 = 6;
                  num1 = num3;
                  continue;
                }
                num3 = 5;
                num1 = num3;
                continue;
              case 2:
                this.eval_p = num2;
                this.eval_q = 1;
                num3 = 9;
                num1 = num3;
                continue;
              case 3:
                if (!flag)
                {
                  num3 = 0;
                  num1 = num3;
                  continue;
                }
                goto label_22;
              case 4:
                goto label_10;
              case 5:
                num3 = 4;
                num1 = num3;
                continue;
              case 6:
                goto label_14;
              case 7:
              case 9:
                num3 = 8;
                num1 = num3;
                continue;
              case 8:
                goto label_18;
              case 10:
                if (flag)
                {
                  num3 = 0;
                  this.eval_p = num2;
                  num3 = 7;
                  num1 = num3;
                  continue;
                }
                num3 = 2;
                num1 = num3;
                continue;
              default:
                goto label_2;
            }
          }
label_18:
          return;
label_22:
          return;
label_10:
          num4 = this.eval_p == num2 ? 1 : 0;
          goto label_19;
      }
label_14:
      num4 = 1;
label_19:
      flag = num4 != 0;
      num3 = 10;
      num1 = num3;
      goto default;
    }

    private void eval_f()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          int num3;
          bool flag;
          int num4;
          switch (0)
          {
            case 0:
label_3:
              TimeSpan timeSpan = DateTime.UtcNow - DateTime.MinValue.AddMinutes((double) ((24 + this.eval_aq) * 60));
              num2 = timeSpan.Hours;
              num3 = timeSpan.Minutes;
              flag = !(this.eval_a2 != "-");
              num4 = 10;
              num1 = num4;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    flag = num2 == 0;
                    num4 = 6;
                    num1 = num4;
                    continue;
                  case 1:
                    num2 = 24 - num2;
                    num4 = 5;
                    num1 = num4;
                    continue;
                  case 2:
label_16:
                    num4 = 0;
                    num4 = 7;
                    num1 = num4;
                    continue;
                  case 3:
                    if (!flag)
                    {
                      num4 = 4;
                      num1 = num4;
                      continue;
                    }
                    goto case 2;
                  case 4:
                    num4 = 1;
                    if (num4 == 0)
                      ;
                    num2 = 23;
                    num4 = 2;
                    num1 = num4;
                    continue;
                  case 5:
                    flag = num3 == 0;
                    num4 = 8;
                    num1 = num4;
                    continue;
                  case 6:
                    if (!flag)
                    {
                      num4 = 1;
                      num1 = num4;
                      continue;
                    }
                    goto case 5;
                  case 7:
                    num4 = 11;
                    num1 = num4;
                    continue;
                  case 8:
                    if (!flag)
                    {
                      num4 = -28114;
                      int num5 = num4;
                      num4 = -28114;
                      int num6 = num4;
                      switch (num5 == num6 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          goto label_16;
                        default:
                          num4 = 0;
                          if (num4 == 0)
                            ;
                          num4 = 9;
                          num1 = num4;
                          continue;
                      }
                    }
                    else
                      goto case 7;
                  case 9:
                    num3 = 60 - num3;
                    --num2;
                    flag = num2 >= 0;
                    num4 = 3;
                    num1 = num4;
                    continue;
                  case 10:
                    if (!flag)
                    {
                      num4 = 0;
                      num1 = num4;
                      continue;
                    }
                    goto label_22;
                  case 11:
                    goto label_22;
                  default:
                    goto label_3;
                }
              }
label_22:
              this.b9.Text = string.Format("{0}{1:00}:{2:00}{3}", (object) this.eval_a2, (object) num2, (object) num3, (object) this.eval_a2);
              return;
          }
      }
    }

    private void eval_z(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !(this.eval_a2 == "-");
          num2 = 2;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_11;
              case 1:
                goto label_7;
              case 2:
                if (!flag)
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                this.eval_a2 = "-";
                num2 = 0;
                num1 = num2;
                continue;
              case 3:
                this.eval_a2 = "*";
                num2 = 1;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_7:
          num2 = 6670;
          int num3 = num2;
          num2 = 6670;
          int num4 = num2;
          switch (num3 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              break;
            case 1:
              num2 = 1;
              if (num2 == 0)
                ;
              num2 = 0;
              if (num2 == 0)
                break;
              break;
            default:
              num2 = 0;
              goto case 1;
          }
label_11:
          this.eval_f();
          this.eval_aa();
          break;
      }
    }

    private void eval_y(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              this.eval_f();
              flag = this.eval_f != 1;
              num2 = 1;
              num1 = num2;
              goto default;
            default:
label_2:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    if (flag)
                    {
                      flag = this.eval_g != 3;
                      num2 = 19;
                      num1 = num2;
                      continue;
                    }
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 1:
                    while (flag)
                    {
                      flag = this.eval_d != 0;
                      num2 = -22562;
                      int num3 = num2;
                      num2 = -22562;
                      int num4 = num2;
                      switch (num3 == num4 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          continue;
                        default:
                          num2 = 0;
                          if (num2 == 0)
                            ;
                          num2 = 5;
                          num1 = num2;
                          goto label_2;
                      }
                    }
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 2:
                    goto label_34;
                  case 3:
                    goto label_30;
                  case 4:
                  case 7:
                  case 10:
                  case 18:
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 5:
                    if (!flag)
                    {
                      num2 = 0;
                      num2 = 14;
                      num1 = num2;
                      continue;
                    }
                    StringBuilder stringBuilder = new StringBuilder("", 5);
                    TimeSpan elapsed = this.eval_aa.Elapsed;
                    string str = string.Format("{0:00}:{1:00}", (object) (9 - elapsed.Minutes), (object) (59 - elapsed.Seconds));
                    this.eval_bw.Text = stringBuilder.Append("Autostart in ").Append(str).Append(" min").ToString();
                    flag = this.eval_aa.ElapsedMilliseconds <= 599000L;
                    num2 = 15;
                    num1 = num2;
                    continue;
                  case 6:
                    if (!flag)
                    {
                      num2 = 16;
                      num1 = num2;
                      continue;
                    }
                    flag = this.eval_g != 2;
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 8:
                    this.eval_bs.PerformClick();
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 9:
                    num2 = 3;
                    num1 = num2;
                    continue;
                  case 11:
                    this.bu.Text = "...";
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 12:
                    this.bu.Text = "..";
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 13:
                    goto label_27;
                  case 14:
                    string format = "{0:00}:{1:00}";
                    TimeSpan timeSpan = this.eval_u();
                    // ISSUE: variable of a boxed type
                    __Boxed<int> local1 = (ValueType) timeSpan.Hours;
                    timeSpan = this.eval_u();
                    // ISSUE: variable of a boxed type
                    __Boxed<int> local2 = (ValueType) timeSpan.Minutes;
                    this.bh[this.eval_p].Text = string.Format(format, (object) local1, (object) local2);
                    ++this.eval_g;
                    flag = this.eval_g != 1;
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 15:
                    if (!flag)
                    {
                      num2 = 8;
                      num1 = num2;
                      continue;
                    }
                    goto case 9;
                  case 16:
                    this.bu.Text = ".";
                    num2 = 10;
                    num1 = num2;
                    continue;
                  case 17:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 19:
                    if (!flag)
                    {
                      num2 = 11;
                      num1 = num2;
                      continue;
                    }
                    this.bu.Text = "";
                    this.eval_g = 0;
                    num2 = 18;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_27:
              return;
label_30:
              return;
label_34:
              return;
          }
      }
    }

    private static Color eval_b(int A_0, int A_1)
    {
      int num1 = 0;
      num1 = 10152;
      int num2 = num1;
      num1 = 10152;
      int num3 = num1;
      Color color;
      switch (num2 == num3 ? 1 : 0)
      {
        case 0:
        case 2:
          return color;
        default:
          num1 = 1;
          if (num1 == 0)
            ;
          num1 = 0;
          if (num1 == 0)
            ;
          IntPtr dc = Form1.GetDC(IntPtr.Zero);
          uint pixel = Form1.GetPixel(dc, A_0, A_1);
          Form1.ReleaseDC(IntPtr.Zero, dc);
          color = Color.FromArgb((int) pixel & (int) byte.MaxValue, ((int) pixel & 65280) >> 8, ((int) pixel & 16711680) >> 16);
          goto case 0;
      }
    }

    private void eval_x(object A_0, EventArgs A_1)
    {
      int num1 = -2192;
      int num2 = num1;
      num1 = -2192;
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
          this.eval_bz.Image = (Image) Resources.spisokC;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_w(object A_0, EventArgs A_1)
    {
      int num1 = 27588;
      int num2 = num1;
      num1 = 27588;
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
          this.eval_bz.Image = (Image) Resources.spisokBW4;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_v(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int length;
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              length = this.eval_k.Length - 1;
              flag = !string.IsNullOrEmpty(this.eval_k[length]);
              num2 = 5;
              num1 = num2;
              goto default;
            default:
              StringBuilder stringBuilder;
              string A_3;
              string A_4;
              int A_0_1;
              string A_1_1;
              string A_2;
              int index1;
              string[] strArray;
              int index2;
              int index3;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    if (!flag)
                    {
                      num2 = 20;
                      num1 = num2;
                      continue;
                    }
                    goto case 11;
                  case 1:
                    stringBuilder.Append("</tr>");
                    ++A_0_1;
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 2:
                    stringBuilder = new StringBuilder("", 4000);
                    stringBuilder.Append("<!DOCTYPE html><html> <head><meta charset=\"utf-8\"><title>Statistics</title><style type=\"text/css\">");
                    stringBuilder.Append("body {font-size: 90%; background: #313131; color: #ffa500;}");
                    stringBuilder.Append("table {width: 80%;border: 2px solid #404040;margin: auto;}");
                    stringBuilder.Append("td, th {text-align: center; padding: 3px; } th {border-bottom: 4px double #404040; }");
                    stringBuilder.Append(".nm {background: #000000; color: #ffa500;}");
                    stringBuilder.Append(".gold {background: #313131; color: #ffd700;}");
                    stringBuilder.Append(".win {background: #313131; color: #ffffff;}");
                    stringBuilder.Append(".wh {text-align: center; background: #313131; color: #6495ed;}");
                    stringBuilder.Append("</style></head><body><table><tr><th rowspan=\"2\" class=\"nm\">Date</th>");
                    A_3 = "";
                    A_4 = "";
                    A_1_1 = "";
                    A_2 = "";
                    index1 = 0;
                    num2 = 22;
                    num1 = num2;
                    continue;
                  case 3:
                    flag = !string.IsNullOrEmpty(this.eval_k[length]);
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 4:
                  case 17:
                    flag = index3 < strArray.Length;
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 5:
                    if (!flag)
                    {
                      num2 = 25;
                      num1 = num2;
                      continue;
                    }
                    goto case 3;
                  case 6:
                    num2 = 0;
                    if (!flag)
                    {
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    stringBuilder.Append(this.eval_a(A_0_1, index1));
                    ++index1;
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 7:
                  case 13:
                    flag = A_0_1 < this.eval_l.GetLength(0);
                    num2 = 10;
                    num1 = num2;
                    continue;
                  case 8:
                  case 21:
                    flag = index1 > 0;
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 9:
                  case 23:
                    flag = index1 < this.bb;
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 10:
                    if (!flag)
                    {
                      num2 = 1;
                      if (num2 == 0)
                        ;
                      num2 = 24;
                      num1 = num2;
                      continue;
                    }
                    stringBuilder.Append("<td class=\"nm\">").Append(this.eval_l[A_0_1, 0]).Append("</td>").Append(this.eval_a(A_0_1, 0));
                    index1 = 1;
                    num2 = 23;
                    num1 = num2;
                    continue;
                  case 11:
                    this.eval_l = new string[length, Enumerable.Count<string>((IEnumerable<string>) this.eval_m)];
                    this.c(1000);
                    index1 = length;
                    num2 = 21;
                    num1 = num2;
                    continue;
                  case 12:
                    stringBuilder.Append(A_3).Append("</tr><tr>").Append(A_4).Append("</tr>");
                    A_0_1 = 0;
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 14:
                    if (!flag)
                    {
                      num2 = 2;
                      num1 = num2;
                      continue;
                    }
                    strArray = this.eval_k[index1].Split('\t');
                    index2 = length - index1;
                    index3 = 0;
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 15:
                    num2 = 31872;
                    int num3 = num2;
                    num2 = 31872;
                    int num4 = num2;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_39;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        --index1;
                        num2 = 8;
                        num1 = num2;
                        continue;
                    }
                  case 16:
                    if (!flag)
                    {
                      num2 = 15;
                      num1 = num2;
                      continue;
                    }
                    this.eval_l[index2, index3] = strArray[index3];
                    ++index3;
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 18:
                    if (!flag)
                    {
                      num2 = 12;
                      num1 = num2;
                      continue;
                    }
                    this.eval_a(index1, A_1_1, A_2, out A_3, out A_4);
                    A_1_1 = A_3;
                    A_2 = A_4;
                    ++index1;
                    num2 = 19;
                    num1 = num2;
                    continue;
                  case 19:
                  case 22:
                    flag = index1 < this.bb;
                    num2 = 18;
                    num1 = num2;
                    continue;
                  case 20:
                    --length;
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 24:
                    goto label_39;
                  case 25:
                    --length;
                    num2 = 3;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_39:
              stringBuilder.Append("</table><p class=\"wh\">W/h - Wins per hour</p></body></html>");
              File.WriteAllText(this.eval_a7, stringBuilder.ToString());
              Process.Start(this.eval_a7);
              return;
          }
      }
    }

    private void eval_u(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          Settings settings;
          bool flag1;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              this.eval_aa.Stop();
              settings = new Settings(new int[11]
              {
                this.eval_ap,
                this.eval_aq,
                this.eval_as,
                -1,
                this.eval_ar,
                this.eval_aw,
                this.eval_ay,
                this.eval_ax,
                this.eval_az,
                this.eval_a0,
                this.bb
              });
              flag1 = settings.ShowDialog() != DialogResult.OK;
              num2 = 10;
              num1 = num2;
              goto default;
            default:
              int index;
              int num3;
              bool flag2;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    index = 0;
                    num2 = 15;
                    num1 = num2;
                    continue;
                  case 1:
                  case 36:
                    flag1 = index < this.bb;
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 2:
                    this.bh[index].Text = "--:--";
                    this.eval_ab[this.eval_p].eval_i = "20010101";
                    ++index;
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 3:
                    num2 = -9799;
                    int num4 = num2;
                    num2 = -9799;
                    int num5 = num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_29;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        this.eval_m[index * 6 + 3] = "--:--";
                        num2 = 2;
                        num1 = num2;
                        continue;
                    }
                  case 4:
                    this.eval_aw = Decimal.ToInt32(settings.nUD_restartAttempts1.Value);
                    this.eval_ay = Decimal.ToInt32(settings.nUD_pauseBtwAttempts1.Value);
                    this.eval_ax = Decimal.ToInt32(settings.nUD_restartAttempts2.Value);
                    this.eval_az = Decimal.ToInt32(settings.nUD_pauseBtwAttempts2.Value);
                    this.eval_a0 = Decimal.ToInt32(settings.nUD_bnetStartTime.Value);
                    this.eval_aq = Decimal.ToInt32(settings.nUD_newBlizzDayTimeShift.Value);
                    flag1 = !settings.cb_uniqueSettings.Checked;
                    num2 = 39;
                    num1 = num2;
                    continue;
                  case 5:
                    this.eval_at = true;
                    num2 = 18;
                    num1 = num2;
                    continue;
                  case 6:
                    this.bb = num3;
                    flag2 = true;
                    num2 = 27;
                    num1 = num2;
                    continue;
                  case 7:
                    flag1 = num3 >= this.bb;
                    num2 = 40;
                    num1 = num2;
                    continue;
                  case 8:
                  case 28:
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 9:
                  case 15:
                    flag1 = index < this.bb;
                    num2 = 32;
                    num1 = num2;
                    continue;
                  case 10:
                    if (!flag1)
                    {
                      num2 = 13;
                      num1 = num2;
                      continue;
                    }
                    goto label_59;
                  case 11:
                    goto label_59;
                  case 12:
                    if (!flag1)
                    {
                      num2 = 31;
                      num1 = num2;
                      continue;
                    }
                    this.eval_ab[index].eval_i = "";
                    ++index;
                    num2 = 36;
                    num1 = num2;
                    continue;
                  case 13:
                    flag1 = !settings.cb_enableDebugLog.Checked;
                    num2 = 19;
                    num1 = num2;
                    continue;
                  case 14:
                    this.eval_ar = 1;
                    num2 = 23;
                    num1 = num2;
                    continue;
                  case 16:
                    flag1 = !settings.cb_resetQuestDone.Checked;
                    num2 = 34;
                    num1 = num2;
                    continue;
                  case 17:
                    this.eval_f(101);
                    flag1 = !settings.cb_resetTimers.Checked;
                    num2 = 29;
                    num1 = num2;
                    continue;
                  case 18:
                    this.eval_ap = Decimal.ToInt32(settings.nUD_pauseBtwRestarts.Value);
                    num2 = 24;
                    num1 = num2;
                    continue;
                  case 19:
                    if (!flag1)
                    {
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    goto case 18;
                  case 20:
                    index = 0;
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 21:
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 22:
                    if (!flag1)
                    {
                      num2 = 6;
                      num1 = num2;
                      continue;
                    }
                    goto case 27;
                  case 23:
                  case 30:
label_29:
                    this.eval_aa();
                    flag1 = !flag2;
                    num2 = 25;
                    num1 = num2;
                    continue;
                  case 24:
                    this.eval_as = settings.chb_moveGameAtStart.Checked ? 1 : 0;
                    flag2 = false;
                    num3 = Decimal.ToInt32(settings.nUD_accNum.Value);
                    flag1 = num3 == this.bb;
                    num2 = 26;
                    num1 = num2;
                    continue;
                  case 25:
                    if (!flag1)
                    {
                      num2 = 38;
                      num1 = num2;
                      continue;
                    }
                    goto case 17;
                  case 26:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    if (!flag1)
                    {
                      num2 = 7;
                      num1 = num2;
                      continue;
                    }
                    goto case 4;
                  case 27:
                    num2 = 28;
                    num1 = num2;
                    continue;
                  case 29:
                    if (!flag1)
                    {
                      num2 = 0;
                      num1 = num2;
                      continue;
                    }
                    goto case 16;
                  case 31:
                    num2 = 21;
                    num1 = num2;
                    continue;
                  case 32:
                    if (!flag1)
                    {
                      num2 = 37;
                      num1 = num2;
                      continue;
                    }
                    this.eval_ab[index].f = "--:--";
                    flag1 = string.IsNullOrEmpty(this.eval_m[index * 6 + 3]);
                    num2 = 33;
                    num1 = num2;
                    continue;
                  case 33:
                    if (!flag1)
                    {
                      num2 = 3;
                      num1 = num2;
                      continue;
                    }
                    goto case 2;
                  case 34:
                    if (!flag1)
                    {
                      num2 = 20;
                      num1 = num2;
                      continue;
                    }
                    goto case 21;
                  case 35:
                    flag1 = MessageBox.Show((string) (object) (this.bb - num3) + (object) " bottom accounts will be deleted.", "Confirm changes", MessageBoxButtons.YesNo) != DialogResult.Yes;
                    num2 = 22;
                    num1 = num2;
                    continue;
                  case 37:
                    this.eval_f = 0;
                    this.eval_y.Reset();
                    this.eval_u();
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 38:
                    this.eval_af((object) null, EventArgs.Empty);
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 39:
                    if (flag1)
                    {
                      num2 = 0;
                      this.eval_ar = 0;
                      num2 = 30;
                      num1 = num2;
                      continue;
                    }
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 40:
                    if (flag1)
                    {
                      this.bb = num3;
                      flag2 = true;
                      num2 = 8;
                      num1 = num2;
                      continue;
                    }
                    num2 = 35;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_59:
              this.eval_aa.Start();
              return;
          }
      }
    }

    private void eval_t(object A_0, EventArgs A_1)
    {
      int num1 = 16890;
      int num2 = num1;
      num1 = 16890;
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
          this.eval_b8.Image = (Image) Resources.cogwheelC;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_s(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      num1 = 1;
      if (num1 == 0)
        ;
      num1 = 28545;
      int num2 = num1;
      num1 = 28545;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          if (num1 == 0)
            ;
          this.eval_b8.Image = (Image) Resources.cogwheelBW;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_r(object A_0, EventArgs A_1)
    {
      int num1;
      QuestLog questLog;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          questLog = new QuestLog(this.eval_ah.ToString());
          flag = questLog.ShowDialog() != DialogResult.OK;
          num2 = 3;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                this.eval_ah = questLog.useQuestLog;
                this.eval_e();
                this.eval_aa();
                num2 = 5;
                num1 = num2;
                continue;
              case 1:
                num2 = 0;
                flag = this.eval_ah == questLog.useQuestLog;
                num2 = 2;
                num1 = num2;
                continue;
              case 2:
                if (flag)
                  goto case 5;
                else
                  break;
              case 3:
                num2 = 18988;
                int num3 = num2;
                num2 = 18988;
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
                    if (!flag)
                    {
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    goto label_14;
                }
              case 4:
                goto label_9;
              case 5:
                num2 = 4;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
            num2 = 1;
            if (num2 == 0)
              ;
            num2 = 0;
            num1 = num2;
          }
label_9:
          break;
label_14:
          break;
      }
    }

    private void eval_q(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      num1 = -31708;
      int num2 = num1;
      num1 = -31708;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          if (num1 == 0)
            ;
          num1 = 1;
          if (num1 == 0)
            ;
          this.eval_b6.Image = (Image) Resources.questLogSelect;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_p(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      num1 = 1;
      if (num1 == 0)
        ;
      num1 = -982;
      int num2 = num1;
      num1 = -982;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          if (num1 == 0)
            ;
          this.eval_e();
          break;
        default:
          goto case 1;
      }
    }

    private void eval_e()
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !this.eval_ah;
          num2 = 3;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_6;
              case 1:
                num2 = 8336;
                int num3 = num2;
                num2 = 8336;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    goto label_10;
                }
              case 2:
                this.eval_b6.Image = (Image) Resources.questLogJob;
                break;
              case 3:
                if (!flag)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                this.eval_b6.Image = (Image) Resources.questLogDisable;
                num2 = 0;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
            num2 = 1;
            num1 = num2;
          }
label_6:
          num2 = 1;
          if (num2 != 0)
            break;
          break;
label_10:
          num2 = 0;
          if (num2 == 0)
            ;
          num2 = 0;
          break;
      }
    }

    private void eval_a(int A_0, string A_1, string A_2, out string A_3, out string A_4)
    {
      int num1 = 0;
      num1 = -7943;
      int num2 = num1;
      num1 = -7943;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          if (num1 == 0)
            ;
          num1 = 1;
          if (num1 == 0)
            ;
          StringBuilder stringBuilder1 = new StringBuilder("", 500);
          StringBuilder stringBuilder2 = new StringBuilder("", 500);
          stringBuilder1.Append(A_1).Append("<td class=\"nm\" colspan=\"4\" align=\"center\"><b>").Append(this.eval_ab[A_0].eval_c).Append("</b></td>");
          stringBuilder2.Append(A_2).Append("<th class=\"nm\">Time</th><th class=\"win\">W</th><th>L</th><th class=\"wh\">W/h</th>");
          A_3 = stringBuilder1.ToString();
          A_4 = stringBuilder2.ToString();
          break;
        default:
          goto case 1;
      }
    }

    private string eval_a(int A_0, int A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          StringBuilder stringBuilder;
          double num2;
          string str1;
          string str2;
          bool flag;
          int num3;
          switch (0)
          {
            case 0:
label_3:
              stringBuilder = new StringBuilder("", 500);
              num2 = 0.0;
              str1 = "";
              str2 = "";
              flag = string.IsNullOrEmpty(this.eval_l[A_0, A_1 * 6 + 4]);
              num3 = 1;
              if (num3 == 0)
                ;
              num3 = 1;
              num1 = num3;
              goto default;
            default:
              string str3;
              while (true)
              {
                string str4;
                string str5;
                int num4;
                switch (num1)
                {
                  case 0:
                    if (!string.IsNullOrEmpty(this.eval_l[A_0, A_1 * 6 + 3]))
                    {
                      num3 = 2;
                      num1 = num3;
                      continue;
                    }
                    num3 = 8;
                    num1 = num3;
                    continue;
                  case 1:
                    if (!flag)
                    {
                      num3 = 6;
                      num1 = num3;
                      continue;
                    }
                    goto case 9;
                  case 2:
                    num3 = 11;
                    num1 = num3;
                    continue;
                  case 3:
                    str4 = "";
                    num3 = 0;
                    num1 = num3;
                    continue;
                  case 4:
                    goto label_54;
                  case 5:
                    if (!flag)
                    {
                      num3 = 10;
                      num1 = num3;
                      continue;
                    }
                    goto case 3;
                  case 6:
                    num3 = -25029;
                    int num5 = num3;
                    num3 = -25029;
                    int num6 = num3;
                    switch (num5 == num6 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_53;
                      default:
                        num3 = 0;
                        if (num3 == 0)
                          ;
                        str2 = this.eval_l[A_0, A_1 * 6 + 4];
                        num3 = 9;
                        num1 = num3;
                        continue;
                    }
                  case 7:
                    stringBuilder.Append("<td class=\"nm\">").Append(str1).Append("</td><td class=\"win\">").Append(str2).Append("</td><td>").Append(str5).Append("</td><td class=\"wh\">").Append(str4).Append("</td>").Append("</td>");
                    str3 = stringBuilder.ToString();
                    num3 = 4;
                    num1 = num3;
                    continue;
                  case 8:
                    num4 = 1;
                    break;
                  case 9:
                    str5 = "";
                    flag = string.IsNullOrEmpty(this.eval_l[A_0, A_1 * 6 + 5]);
                    num3 = 0;
                    num3 = 5;
                    num1 = num3;
                    continue;
                  case 10:
                    str5 = this.eval_l[A_0, A_1 * 6 + 5];
                    num3 = 3;
                    num1 = num3;
                    continue;
                  case 11:
                    num4 = string.IsNullOrEmpty(this.eval_l[A_0, A_1 * 6 + 3]) ? 1 : 0;
                    break;
                  case 12:
                    num3 = 14;
                    num1 = num3;
                    continue;
                  case 13:
                    if (!flag)
                    {
                      num3 = 12;
                      num1 = num3;
                      continue;
                    }
                    goto case 7;
                  case 14:
                    try
                    {
                      TimeSpan timeSpan;
                      switch (0)
                      {
                        case 0:
label_24:
                          timeSpan = TimeSpan.Parse(this.eval_l[A_0, A_1 * 6 + 3]);
                          num3 = 5;
                          num1 = num3;
                          goto default;
                        default:
                          while (true)
                          {
                            int num7;
                            int num8;
                            switch (num1)
                            {
                              case 0:
                                num7 = 1;
                                break;
                              case 1:
                                if (!flag)
                                {
                                  num3 = 14;
                                  num1 = num3;
                                  continue;
                                }
                                goto case 9;
                              case 2:
                                goto label_52;
                              case 3:
                                str1 = string.Format("{0:00}:{1:00}", (object) timeSpan.Hours, (object) timeSpan.Minutes);
                                num3 = 9;
                                num1 = num3;
                                continue;
                              case 4:
                                num8 = 1;
                                goto label_43;
                              case 5:
                                if (timeSpan.TotalMinutes > 0.0)
                                {
                                  num3 = 8;
                                  num1 = num3;
                                  continue;
                                }
                                num3 = 4;
                                num1 = num3;
                                continue;
                              case 6:
                                str4 = Math.Round(num2, 1).ToString();
                                num3 = 3;
                                num1 = num3;
                                continue;
                              case 7:
                                if (!flag)
                                {
                                  num3 = 6;
                                  num1 = num3;
                                  continue;
                                }
                                goto case 3;
                              case 8:
                                num3 = 11;
                                num1 = num3;
                                continue;
                              case 9:
                                num3 = 2;
                                num1 = num3;
                                continue;
                              case 10:
                                if (num2 <= 0.0)
                                {
                                  num3 = 0;
                                  num1 = num3;
                                  continue;
                                }
                                num3 = 13;
                                num1 = num3;
                                continue;
                              case 11:
                                num8 = timeSpan.TotalMinutes >= 1800.0 ? 1 : 0;
                                goto label_43;
                              case 12:
                                num7 = num2 >= 1000.0 ? 1 : 0;
                                break;
                              case 13:
                                num3 = 12;
                                num1 = num3;
                                continue;
                              case 14:
                                num2 = (double) (60 * Convert.ToInt32(this.eval_l[A_0, A_1 * 6 + 4])) / timeSpan.TotalMinutes;
                                num3 = 10;
                                num1 = num3;
                                continue;
                              default:
                                goto label_24;
                            }
                            flag = num7 != 0;
                            num3 = 7;
                            num1 = num3;
                            continue;
label_43:
                            flag = num8 != 0;
                            num3 = 1;
                            num1 = num3;
                          }
                      }
                    }
                    catch (Exception ex)
                    {
                    }
label_52:
                    goto label_53;
                  default:
                    goto label_3;
                }
                flag = num4 != 0;
                num3 = 13;
                num1 = num3;
                continue;
label_53:
                num3 = 7;
                num1 = num3;
              }
label_54:
              return str3;
          }
      }
    }

    private void eval_o(object A_0, EventArgs A_1)
    {
      int num1;
      schedule schedule;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          this.eval_aa.Stop();
          schedule = new schedule(this.eval_ac, this.bb);
          flag = schedule.ShowDialog() != DialogResult.OK;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                this.eval_ac = schedule.ArrSched;
                this.eval_z();
                num2 = 2;
                num1 = num2;
                continue;
              case 1:
label_3:
                if (!flag)
                {
                  num2 = 0;
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                goto label_9;
              case 2:
                num2 = -15623;
                int num3 = num2;
                num2 = -15623;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_3;
                  default:
                    goto label_7;
                }
              default:
                goto label_2;
            }
          }
label_7:
          num2 = 1;
          if (num2 == 0)
            ;
          num2 = 0;
          if (num2 == 0)
            ;
label_9:
          this.eval_aa.Start();
          break;
      }
    }

    private void eval_n(object A_0, EventArgs A_1)
    {
      int num1 = 31498;
      int num2 = num1;
      num1 = 31498;
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
          (A_0 as PictureBox).Image = (Image) Resources.sheduleSelect;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_m(object A_0, EventArgs A_1)
    {
      int num1 = 1;
      if (num1 == 0)
        ;
      num1 = -15632;
      int num2 = num1;
      num1 = -15632;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          num1 = 0;
          if (num1 == 0)
            ;
          (A_0 as PictureBox).Image = (Image) Resources.shedule;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_l(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !this.eval_b4.Checked;
          num2 = 6;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            int index;
            switch (num1)
            {
              case 0:
label_17:
                flag = index < this.bb;
                num2 = 2;
                num1 = num2;
                continue;
              case 1:
                num2 = -3807;
                int num3 = num2;
                num2 = -3807;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      goto label_17;
                    else
                      goto label_17;
                }
              case 2:
                num2 = 0;
                if (flag)
                {
                  this.bf[index].Visible = true;
                  this.bf[index].Enabled = true;
                  this.bg[index].Visible = false;
                  ++index;
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                num2 = 8;
                num1 = num2;
                continue;
              case 3:
              case 10:
                flag = index < this.bb;
                num2 = 7;
                num1 = num2;
                continue;
              case 4:
                num2 = 1;
                if (num2 == 0)
                  ;
                this.eval_by.Text = "change account after 30 wins";
                num2 = 9;
                num1 = num2;
                continue;
              case 5:
                this.eval_ad = true;
                this.eval_bq.Text = "User\r\nschedule";
                index = 0;
                num2 = 1;
                num1 = num2;
                continue;
              case 6:
                if (flag)
                {
                  this.eval_ad = false;
                  this.eval_bq.Text = "Duration,\r\nhours";
                  index = 0;
                  num2 = 10;
                  num1 = num2;
                  continue;
                }
                break;
              case 7:
                if (flag)
                {
                  this.bf[index].Visible = false;
                  this.bf[index].Enabled = false;
                  this.bg[index].Visible = true;
                  ++index;
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                num2 = 4;
                num1 = num2;
                continue;
              case 8:
                this.eval_by.Text = "stop account after 30 wins";
                num2 = 11;
                num1 = num2;
                continue;
              case 9:
              case 11:
                goto label_20;
              default:
                goto label_2;
            }
            num2 = 5;
            num1 = num2;
          }
label_20:
          this.eval_aa();
          break;
      }
    }

    private void eval_d()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          Bitmap bitmap;
          ContentAlignment contentAlignment;
          string key;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              bitmap = Resources._0unknown;
              contentAlignment = ContentAlignment.MiddleLeft;
              key = this.eval_ag;
              num2 = 7;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                int num3;
                switch (num1)
                {
                  case 0:
                    // ISSUE: reference to a compiler-generated field
                    if (global::eval_f.eval_c == null)
                    {
                      num2 = 6;
                      num1 = num2;
                      continue;
                    }
                    goto case 12;
                  case 1:
                  case 4:
                  case 5:
                  case 10:
                  case 11:
                  case 13:
                  case 14:
                  case 16:
                  case 17:
                  case 18:
                  case 19:
                    goto label_31;
                  case 2:
                    switch (num3)
                    {
                      case 0:
                        contentAlignment = ContentAlignment.MiddleCenter;
                        num2 = 16;
                        num1 = num2;
                        continue;
                      case 1:
                        bitmap = Resources._0priest;
                        num2 = 14;
                        num1 = num2;
                        continue;
                      case 2:
                        bitmap = Resources._0paladin;
                        num2 = 4;
                        num1 = num2;
                        continue;
                      case 3:
                        bitmap = Resources._0warlock;
                        num2 = 18;
                        num1 = num2;
                        continue;
                      case 4:
                        bitmap = Resources._0mage;
                        num2 = 1;
                        num1 = num2;
                        continue;
                      case 5:
                        bitmap = Resources._0shaman;
                        num2 = 10;
                        num1 = num2;
                        continue;
                      case 6:
                        num2 = 0;
                        bitmap = Resources._0druid;
                        num2 = 13;
                        num1 = num2;
                        continue;
                      case 7:
                        bitmap = Resources._0warrior;
                        num2 = 19;
                        num1 = num2;
                        continue;
                      case 8:
                        bitmap = Resources._0hunter;
                        num2 = 11;
                        num1 = num2;
                        continue;
                      case 9:
                        bitmap = Resources._0rogue;
                        num2 = 17;
                        num1 = num2;
                        continue;
                      default:
                        num2 = 3;
                        num1 = num2;
                        continue;
                    }
                  case 3:
                    num2 = 5;
                    num1 = num2;
                    continue;
                  case 6:
                    // ISSUE: reference to a compiler-generated field
                    global::eval_f.eval_c = new Dictionary<string, int>(10)
                    {
                      {
                        "unknown",
                        0
                      },
                      {
                        "Priest",
                        1
                      },
                      {
                        "Paladin",
                        2
                      },
                      {
                        "Warlock",
                        3
                      },
                      {
                        "Mage",
                        4
                      },
                      {
                        "Shaman",
                        5
                      },
                      {
                        "Druid",
                        6
                      },
                      {
                        "Warrior",
                        7
                      },
                      {
                        "Hunter",
                        8
                      },
                      {
                        "Rogue",
                        9
                      }
                    };
                    break;
                  case 7:
                    if (key != null)
                    {
                      num2 = 9;
                      num1 = num2;
                      continue;
                    }
                    goto label_31;
                  case 8:
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 9:
                    num2 = -20708;
                    int num4 = num2;
                    num2 = -20708;
                    int num5 = num2;
                    switch (num4 == num5 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        num2 = 1;
                        if (num2 == 0)
                          ;
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        num2 = 0;
                        num1 = num2;
                        continue;
                    }
                  case 12:
                    num2 = 15;
                    num1 = num2;
                    continue;
                  case 15:
                    // ISSUE: reference to a compiler-generated field
                    // ISSUE: explicit non-virtual call
                    if (__nonvirtual (global::eval_f.eval_c.TryGetValue(key, out num3)))
                    {
                      num2 = 8;
                      num1 = num2;
                      continue;
                    }
                    goto label_31;
                  default:
                    goto label_3;
                }
                num2 = 12;
                num1 = num2;
              }
label_31:
              this.eval_bd[this.eval_p].Image = (Image) bitmap;
              this.eval_bd[this.eval_p].TextAlign = contentAlignment;
              return;
          }
      }
    }

    private bool eval_c()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          int num2;
          bool flag1;
          switch (0)
          {
            case 0:
label_3:
              num2 = 1;
              if (num2 == 0)
                ;
              flag1 = !this.eval_at;
              num2 = 0;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    if (!flag1)
                    {
                      num2 = 2;
                      num1 = num2;
                      continue;
                    }
                    goto label_8;
                  case 1:
                    goto label_8;
                  case 2:
                    num2 = 0;
                    this.eval_a("HS: set position - start");
                    num2 = 1;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_8:
              bool flag2;
              try
              {
                global::eval_e.eval_a A_1;
                int num3;
                int num4;
                switch (0)
                {
                  case 0:
label_10:
                    Process process = Process.GetProcessesByName("Hearthstone")[0];
                    global::eval_e.SetForegroundWindow(process.MainWindowHandle);
                    global::eval_e.eval_a(process.MainWindowHandle, 48, 50, 884, 612, false);
                    this.c(1000);
                    A_1 = new global::eval_e.eval_a(0, 0, 1, 1);
                    global::eval_e.GetWindowRect(process.MainWindowHandle, out A_1);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    num3 = A_1.eval_c() - A_1.eval_a();
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    num4 = A_1.eval_e() - A_1.eval_b();
                    flag1 = !this.eval_at;
                    num2 = 2;
                    num1 = num2;
                    goto default;
                  default:
                    while (true)
                    {
                      switch (num1)
                      {
                        case 0:
label_13:
                          string[] strArray1 = new string[8];
                          strArray1[0] = "HS: new position: x:";
                          string[] strArray2 = strArray1;
                          int index1 = 1;
                          // ISSUE: reference to a compiler-generated method
                          int num5 = A_1.eval_a();
                          string str1 = num5.ToString();
                          strArray2[index1] = str1;
                          strArray1[2] = ", y:";
                          string[] strArray3 = strArray1;
                          int index2 = 3;
                          // ISSUE: reference to a compiler-generated method
                          num5 = A_1.eval_b();
                          string str2 = num5.ToString();
                          strArray3[index2] = str2;
                          strArray1[4] = ", w:";
                          strArray1[5] = num3.ToString();
                          strArray1[6] = ", h:";
                          strArray1[7] = num4.ToString();
                          this.eval_a(string.Concat(strArray1));
                          num2 = 10276;
                          int num6 = num2;
                          num2 = 10276;
                          int num7 = num2;
                          switch (num6 == num7 ? 1 : 0)
                          {
                            case 0:
                            case 2:
                              goto label_13;
                            default:
                              num2 = 0;
                              if (num2 == 0)
                                ;
                              num2 = 1;
                              num1 = num2;
                              continue;
                          }
                        case 1:
                          flag2 = true;
                          num2 = 3;
                          num1 = num2;
                          continue;
                        case 2:
                          if (!flag1)
                          {
                            num2 = 0;
                            num1 = num2;
                            continue;
                          }
                          goto case 1;
                        case 3:
                          goto label_20;
                        default:
                          goto label_10;
                      }
                    }
                }
              }
              catch
              {
                if (this.eval_at)
                  this.eval_a("HS: set position - error");
                flag2 = false;
              }
label_20:
              return flag2;
          }
      }
    }

    private bool eval_b()
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          bool flag1;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              this.c(700);
              flag1 = !this.eval_at;
              num2 = 1;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    goto label_8;
                  case 1:
                    if (!flag1)
                    {
                      num2 = 2;
                      num1 = num2;
                      continue;
                    }
                    goto label_8;
                  case 2:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    this.eval_a("HB: set position - start");
                    num2 = 0;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_8:
              bool flag2;
              try
              {
                Process processById;
                global::eval_e.eval_a A_1;
                int num3;
                int num4;
                switch (0)
                {
                  case 0:
label_10:
                    processById = Process.GetProcessById(this.ba);
                    global::eval_e.SetForegroundWindow(processById.MainWindowHandle);
                    A_1 = new global::eval_e.eval_a(0, 0, 1, 1);
                    global::eval_e.GetWindowRect(processById.MainWindowHandle, out A_1);
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    num3 = A_1.eval_c() - A_1.eval_a();
                    // ISSUE: reference to a compiler-generated method
                    // ISSUE: reference to a compiler-generated method
                    num4 = A_1.eval_e() - A_1.eval_b();
                    num2 = 0;
                    num1 = num2;
                    goto default;
                  default:
                    while (true)
                    {
                      int num5;
                      switch (num1)
                      {
                        case 0:
                          // ISSUE: reference to a compiler-generated method
                          if (A_1.eval_a() == 5)
                          {
                            num2 = 10;
                            num1 = num2;
                            continue;
                          }
                          break;
                        case 1:
                          // ISSUE: reference to a compiler-generated method
                          if (A_1.eval_b() == 5)
                          {
                            num2 = 4;
                            num1 = num2;
                            continue;
                          }
                          break;
                        case 2:
label_29:
                          num2 = 5;
                          num1 = num2;
                          continue;
                        case 3:
                          string[] strArray1 = new string[8];
                          strArray1[0] = "HB: new position: x:";
                          string[] strArray2 = strArray1;
                          int index1 = 1;
                          // ISSUE: reference to a compiler-generated method
                          int num6 = A_1.eval_a();
                          string str1 = num6.ToString();
                          strArray2[index1] = str1;
                          strArray1[2] = ", y:";
                          string[] strArray3 = strArray1;
                          int index2 = 3;
                          // ISSUE: reference to a compiler-generated method
                          num6 = A_1.eval_b();
                          string str2 = num6.ToString();
                          strArray3[index2] = str2;
                          strArray1[4] = ", w:";
                          strArray1[5] = num3.ToString();
                          strArray1[6] = ", h:";
                          strArray1[7] = num4.ToString();
                          this.eval_a(string.Concat(strArray1));
                          num2 = 11;
                          num1 = num2;
                          continue;
                        case 4:
                          num2 = 13;
                          num1 = num2;
                          continue;
                        case 5:
                          num5 = num4 != 600 ? 1 : 0;
                          goto label_26;
                        case 6:
                          num5 = 1;
                          goto label_26;
                        case 7:
                          if (!flag1)
                          {
                            num2 = 3;
                            num1 = num2;
                            continue;
                          }
                          goto case 11;
                        case 8:
                        case 12:
                          goto label_37;
                        case 9:
                          flag2 = true;
                          num2 = 12;
                          num1 = num2;
                          continue;
                        case 10:
                          num2 = 1;
                          num1 = num2;
                          continue;
                        case 11:
                          num2 = -4957;
                          int num7 = num2;
                          num2 = -4957;
                          int num8 = num2;
                          switch (num7 == num8 ? 1 : 0)
                          {
                            case 0:
                            case 2:
                              goto label_29;
                            default:
                              num2 = 0;
                              if (num2 == 0)
                                ;
                              this.c(1200);
                              flag2 = true;
                              num2 = 8;
                              num1 = num2;
                              continue;
                          }
                        case 13:
                          if (num3 == 630)
                          {
                            num2 = 2;
                            num1 = num2;
                            continue;
                          }
                          break;
                        case 14:
                          if (flag1)
                          {
                            global::eval_e.eval_a(processById.MainWindowHandle, 13, 35, 614, 562, false);
                            flag1 = !this.eval_at;
                            num2 = 7;
                            num1 = num2;
                            continue;
                          }
                          num2 = 9;
                          num1 = num2;
                          continue;
                        default:
                          goto label_10;
                      }
                      num2 = 6;
                      num1 = num2;
                      continue;
label_26:
                      flag1 = num5 != 0;
                      num2 = 14;
                      num1 = num2;
                    }
                }
              }
              catch
              {
                if (this.eval_at)
                  this.eval_a("HB: set position - error");
                flag2 = false;
              }
label_37:
              return flag2;
          }
      }
    }

    private void eval_a(string A_0)
    {
      int num1 = -3358;
      int num2 = num1;
      num1 = -3358;
      int num3 = num1;
      switch (num2 == num3 ? 1 : 0)
      {
        case 0:
        case 2:
          if (1 != 0)
            break;
          break;
        default:
          int num4 = 0;
          num4 = 0;
          if (num4 == 0)
            ;
          StringBuilder stringBuilder = new StringBuilder("", 1000);
          stringBuilder.Append(DateTime.UtcNow.ToString("yyyy-MM-dd HH:mm:ss"));
          stringBuilder.Append("\t");
          stringBuilder.Append(A_0);
          stringBuilder.Append("\r\n");
          try
          {
            File.AppendAllText(this.eval_a5, stringBuilder.ToString(), Encoding.Default);
            goto case 0;
          }
          catch (Exception ex)
          {
            goto case 0;
          }
      }
    }

    private void eval_k(object A_0, EventArgs A_1)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          if (1 == 0)
            ;
          bool flag;
          int num2;
          switch (0)
          {
            case 0:
label_4:
              this.eval_aa.Stop();
              int index = Convert.ToInt32(((Control) A_0).Tag);
              flag = new settings_editor(new string[3]
              {
                this.eval_b,
                this.eval_ab[index].a,
                this.eval_ab[index].eval_c
              }).ShowDialog() != DialogResult.OK;
              num2 = 1;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 1:
                    num2 = 17870;
                    int num3 = num2;
                    num2 = 17870;
                    int num4 = num2;
                    switch (num3 == num4 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_10;
                      default:
                        num2 = 0;
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        if (!flag)
                        {
                          num2 = 0;
                          num1 = num2;
                          continue;
                        }
                        goto label_10;
                    }
                  case 2:
                    goto label_10;
                  default:
                    goto label_4;
                }
              }
label_10:
              this.eval_f(101);
              this.eval_aa.Start();
              return;
          }
      }
    }

    private void eval_j(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          flag = this.eval_ar >= 1;
          num1 = 0;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                if (!flag)
                {
                  num1 = 2;
                  continue;
                }
                goto label_10;
              case 1:
                goto label_7;
              case 2:
                this.eval_ar = 1;
                this.eval_aa();
                this.eval_f(101);
                num1 = 1;
                continue;
              default:
                goto label_2;
            }
          }
label_7:
          int num2 = -30792;
          int num3 = -30792;
          int num4 = num3;
          switch (num2 == num4 ? 1 : 0)
          {
            case 0:
            case 2:
              break;
            default:
              num3 = 0;
              if (num3 == 0)
                break;
              break;
          }
label_10:
          num3 = 1;
          if (num3 != 0)
            break;
          break;
      }
    }

    private void eval_i(object A_0, EventArgs A_1)
    {
      int num1 = 1;
      if (num1 == 0)
        ;
      num1 = 19056;
      int num2 = num1;
      num1 = 19056;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          if (num1 == 0)
            ;
          num1 = 0;
          this.eval_ca.Image = (Image) Resources.bot_settings;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_h(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = this.eval_ar <= 0;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_9;
              case 1:
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 0;
                if (!flag)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                this.eval_ca.Image = (Image) Resources.bot_settings_bw;
                num2 = 3;
                num1 = num2;
                continue;
              case 2:
                num2 = -25584;
                int num3 = num2;
                num2 = -25584;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                    goto label_13;
                  case 2:
                    goto label_11;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    this.eval_ca.Image = (Image) Resources.bot_settings;
                    num2 = 0;
                    num1 = num2;
                    continue;
                }
              case 3:
                goto label_4;
              default:
                goto label_2;
            }
          }
label_4:
          break;
label_9:
          break;
label_11:
          break;
label_13:
          break;
      }
    }

    private void eval_g(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = this.c != 0;
          num2 = 0;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                if (flag)
                {
                  this.eval_ab[0].d = Convert.ToInt32(this.eval_de.Text);
                  this.eval_aa();
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                break;
              case 1:
                num2 = 30488;
                int num3 = num2;
                num2 = 30488;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    num2 = 3;
                    num1 = num2;
                    continue;
                }
              case 2:
                goto label_11;
              case 3:
                goto label_9;
              default:
                goto label_2;
            }
            num2 = 1;
            num1 = num2;
          }
label_9:
          break;
label_11:
          break;
      }
    }

    private void eval_a(object A_0, FormClosingEventArgs A_1)
    {
      int num1 = 5414;
      int num2 = num1;
      num1 = 5414;
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
          this.eval_d = 1;
          Application.Exit();
          break;
        default:
          goto case 1;
      }
    }

    private void eval_f(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = this.eval_p >= 1;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_11;
              case 1:
                if (flag)
                {
                  this.eval_a(this.eval_p - 1);
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                break;
              case 2:
                num2 = -16895;
                int num3 = num2;
                num2 = -16895;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    num2 = 3;
                    num1 = num2;
                    continue;
                }
              case 3:
                goto label_9;
              default:
                goto label_2;
            }
            num2 = 2;
            num1 = num2;
          }
label_9:
          break;
label_11:
          break;
      }
    }

    private void eval_e(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = this.eval_p <= this.bb - 2;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_11;
              case 1:
                if (flag)
                {
                  this.eval_a(this.eval_p + 1);
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                break;
              case 2:
                goto label_9;
              case 3:
                num2 = 5116;
                int num3 = num2;
                num2 = 5116;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    break;
                  default:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    num2 = 2;
                    num1 = num2;
                    continue;
                }
              default:
                goto label_2;
            }
            num2 = 3;
            num1 = num2;
          }
label_9:
          break;
label_11:
          break;
      }
    }

    private void eval_a(int A_0)
    {
      int num1 = 1;
      if (num1 == 0)
        ;
      num1 = 21237;
      int num2 = num1;
      num1 = 21237;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          num1 = 0;
          if (num1 == 0)
            ;
          global::eval_d evalD = this.eval_ab[this.eval_p];
          this.eval_ab[this.eval_p] = this.eval_ab[A_0];
          this.eval_ab[A_0] = evalD;
          string str1 = this.eval_n[this.eval_p];
          this.eval_n[this.eval_p] = this.eval_n[A_0];
          this.eval_n[A_0] = str1;
          string str2 = this.eval_o[this.eval_p];
          this.eval_o[this.eval_p] = this.eval_o[A_0];
          this.eval_o[A_0] = str2;
          this.eval_p = A_0;
          this.eval_f(101);
          this.eval_aa();
          break;
        default:
          goto case 1;
      }
    }

    private void eval_d(object A_0, EventArgs A_1)
    {
      int num1 = 22319;
      int num2 = num1;
      num1 = 22319;
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
          this.eval_dk.Image = (Image) Resources.arrows_up_c;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_c(object A_0, EventArgs A_1)
    {
      int num1 = 1;
      if (num1 == 0)
        ;
      num1 = 18595;
      int num2 = num1;
      num1 = 18595;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          num1 = 0;
          num1 = 0;
          if (num1 == 0)
            ;
          this.eval_dk.Image = (Image) Resources.arrows_up_bw;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_b(object A_0, EventArgs A_1)
    {
      int num1 = -24061;
      int num2 = num1;
      num1 = -24061;
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
          this.eval_dl.Image = (Image) Resources.arrows_down_c;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_a(object A_0, EventArgs A_1)
    {
      int num1 = 21521;
      int num2 = num1;
      num1 = 21521;
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
          this.eval_dl.Image = (Image) Resources.arrows_down_bw;
          break;
        default:
          goto case 1;
      }
    }

    protected override void Dispose(bool disposing)
    {
      int num1;
      int num2;
      bool flag;
      int num3;
      switch (0)
      {
        case 0:
label_2:
          num2 = 2478;
          int num4 = num2;
          num2 = 2478;
          int num5 = num2;
          switch (num4 == num5 ? 1 : 0)
          {
            case 0:
            case 2:
              goto label_16;
            default:
              num2 = 0;
              if (num2 == 0)
                ;
              num2 = 2;
              num1 = num2;
              goto label_1;
          }
        default:
label_1:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_11;
              case 1:
                goto label_9;
              case 2:
                if (disposing)
                {
                  num2 = 6;
                  num1 = num2;
                  continue;
                }
                num2 = 5;
                num1 = num2;
                continue;
              case 3:
                this.eval_bm.Dispose();
                num2 = 0;
                num1 = num2;
                continue;
              case 4:
                if (!flag)
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                goto label_17;
              case 5:
                goto label_16;
              case 6:
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 1;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_9:
          num3 = this.eval_bm == null ? 1 : 0;
          break;
label_11:
          num2 = 0;
label_17:
          base.Dispose(disposing);
          return;
      }
label_12:
      flag = num3 != 0;
      num2 = 4;
      num1 = num2;
      goto default;
label_16:
      num3 = 1;
      goto label_12;
    }

    private void eval_a()
    {
      int num1 = -24881;
      int num2 = num1;
      num1 = -24881;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          int num4 = 0;
          num4 = 1;
          if (num4 == 0)
            ;
          num4 = 0;
          if (num4 == 0)
            ;
          this.eval_bm = (IContainer) new Container();
          ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Form1));
          this.eval_bo = new GroupBox();
          this.eval_cb = new Panel();
          this.eval_cc = new Button();
          this.eval_cd = new Button();
          this.eval_ce = new Button();
          this.eval_cf = new Button();
          this.eval_cg = new Label();
          this.eval_ch = new Label();
          this.eval_ci = new Label();
          this.eval_cj = new Label();
          this.eval_ck = new PictureBox();
          this.eval_cl = new PictureBox();
          this.eval_cm = new PictureBox();
          this.eval_cn = new PictureBox();
          this.eval_co = new Label();
          this.eval_cp = new Label();
          this.eval_cq = new Label();
          this.eval_cr = new Label();
          this.eval_cs = new Label();
          this.eval_ct = new Label();
          this.eval_cu = new Label();
          this.eval_cv = new Label();
          this.cw = new Label();
          this.cx = new Label();
          this.cy = new Label();
          this.cz = new Label();
          this.eval_c0 = new Button();
          this.eval_c1 = new Button();
          this.eval_c2 = new Button();
          this.eval_c3 = new Label();
          this.eval_c4 = new Label();
          this.eval_c5 = new Label();
          this.eval_c6 = new Label();
          this.c7 = new ComboBox();
          this.c8 = new ComboBox();
          this.c9 = new ComboBox();
          this.da = new ComboBox();
          this.eval_db = new ComboBox();
          this.eval_dc = new ComboBox();
          this.eval_dd = new ComboBox();
          this.eval_de = new ComboBox();
          this.eval_df = new Button();
          this.dg = new RadioButton();
          this.dh = new RadioButton();
          this.di = new RadioButton();
          this.dj = new RadioButton();
          this.eval_ca = new PictureBox();
          this.eval_b5 = new Label();
          this.eval_b0 = new Label();
          this.eval_b1 = new Label();
          this.b2 = new Label();
          this.bu = new Label();
          this.bp = new Label();
          this.eval_bq = new Label();
          this.eval_br = new Label();
          this.eval_bs = new Button();
          this.bt = new System.Windows.Forms.Timer(this.eval_bm);
          this.eval_bv = new System.Windows.Forms.Timer(this.eval_bm);
          this.eval_bw = new Label();
          this.eval_bx = new Label();
          this.eval_by = new CheckBox();
          this.eval_b3 = new ToolTip(this.eval_bm);
          this.b9 = new Label();
          this.eval_dl = new PictureBox();
          this.eval_dk = new PictureBox();
          this.eval_b8 = new PictureBox();
          this.eval_b6 = new PictureBox();
          this.eval_bz = new PictureBox();
          this.eval_b4 = new CheckBox();
          this.eval_b7 = new System.Windows.Forms.Timer(this.eval_bm);
          this.eval_bn = new PictureBox();
          this.eval_bo.SuspendLayout();
          this.eval_cb.SuspendLayout();
          ((ISupportInitialize) this.eval_ck).BeginInit();
          ((ISupportInitialize) this.eval_cl).BeginInit();
          ((ISupportInitialize) this.eval_cm).BeginInit();
          ((ISupportInitialize) this.eval_cn).BeginInit();
          ((ISupportInitialize) this.eval_ca).BeginInit();
          ((ISupportInitialize) this.eval_dl).BeginInit();
          ((ISupportInitialize) this.eval_dk).BeginInit();
          ((ISupportInitialize) this.eval_b8).BeginInit();
          ((ISupportInitialize) this.eval_b6).BeginInit();
          ((ISupportInitialize) this.eval_bz).BeginInit();
          ((ISupportInitialize) this.eval_bn).BeginInit();
          this.SuspendLayout();
          this.eval_bo.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_bo.Controls.Add((Control) this.eval_cb);
          this.eval_bo.Controls.Add((Control) this.eval_ca);
          this.eval_bo.Controls.Add((Control) this.eval_b5);
          this.eval_bo.Controls.Add((Control) this.eval_b0);
          this.eval_bo.Controls.Add((Control) this.eval_b1);
          this.eval_bo.Controls.Add((Control) this.b2);
          this.eval_bo.Controls.Add((Control) this.bu);
          this.eval_bo.Controls.Add((Control) this.bp);
          this.eval_bo.Controls.Add((Control) this.eval_bq);
          this.eval_bo.Controls.Add((Control) this.eval_br);
          this.eval_bo.ForeColor = Color.Orange;
          this.eval_bo.Location = new Point(138, 30);
          this.eval_bo.Name = "gb_Settings";
          this.eval_bo.Size = new Size(387, 157);
          this.eval_bo.TabIndex = 1;
          this.eval_bo.TabStop = false;
          this.eval_bo.Text = "Settings";
          this.eval_cb.Controls.Add((Control) this.eval_cc);
          this.eval_cb.Controls.Add((Control) this.eval_cd);
          this.eval_cb.Controls.Add((Control) this.eval_ce);
          this.eval_cb.Controls.Add((Control) this.eval_cf);
          this.eval_cb.Controls.Add((Control) this.eval_cg);
          this.eval_cb.Controls.Add((Control) this.eval_ch);
          this.eval_cb.Controls.Add((Control) this.eval_ci);
          this.eval_cb.Controls.Add((Control) this.eval_cj);
          this.eval_cb.Controls.Add((Control) this.eval_ck);
          this.eval_cb.Controls.Add((Control) this.eval_cl);
          this.eval_cb.Controls.Add((Control) this.eval_cm);
          this.eval_cb.Controls.Add((Control) this.eval_cn);
          this.eval_cb.Controls.Add((Control) this.eval_co);
          this.eval_cb.Controls.Add((Control) this.eval_cp);
          this.eval_cb.Controls.Add((Control) this.eval_cq);
          this.eval_cb.Controls.Add((Control) this.eval_cr);
          this.eval_cb.Controls.Add((Control) this.eval_cs);
          this.eval_cb.Controls.Add((Control) this.eval_ct);
          this.eval_cb.Controls.Add((Control) this.eval_cu);
          this.eval_cb.Controls.Add((Control) this.eval_cv);
          this.eval_cb.Controls.Add((Control) this.cw);
          this.eval_cb.Controls.Add((Control) this.cx);
          this.eval_cb.Controls.Add((Control) this.cy);
          this.eval_cb.Controls.Add((Control) this.cz);
          this.eval_cb.Controls.Add((Control) this.eval_c0);
          this.eval_cb.Controls.Add((Control) this.eval_c1);
          this.eval_cb.Controls.Add((Control) this.eval_c2);
          this.eval_cb.Controls.Add((Control) this.eval_c3);
          this.eval_cb.Controls.Add((Control) this.eval_c4);
          this.eval_cb.Controls.Add((Control) this.eval_c5);
          this.eval_cb.Controls.Add((Control) this.eval_c6);
          this.eval_cb.Controls.Add((Control) this.c7);
          this.eval_cb.Controls.Add((Control) this.c8);
          this.eval_cb.Controls.Add((Control) this.c9);
          this.eval_cb.Controls.Add((Control) this.da);
          this.eval_cb.Controls.Add((Control) this.eval_db);
          this.eval_cb.Controls.Add((Control) this.eval_dc);
          this.eval_cb.Controls.Add((Control) this.eval_dd);
          this.eval_cb.Controls.Add((Control) this.eval_de);
          this.eval_cb.Controls.Add((Control) this.eval_df);
          this.eval_cb.Controls.Add((Control) this.dg);
          this.eval_cb.Controls.Add((Control) this.dh);
          this.eval_cb.Controls.Add((Control) this.di);
          this.eval_cb.Controls.Add((Control) this.dj);
          this.eval_cb.Location = new Point(2, 53);
          this.eval_cb.Name = "panel_Controls";
          this.eval_cb.Size = new Size(383, 100);
          this.eval_cb.TabIndex = 188;
          this.eval_cc.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_cc.FlatStyle = FlatStyle.Flat;
          this.eval_cc.ForeColor = Color.White;
          this.eval_cc.Location = new Point(146, 72);
          this.eval_cc.Margin = new Padding(0);
          this.eval_cc.Name = "btn_customDeck4";
          this.eval_cc.Size = new Size(25, 23);
          this.eval_cc.TabIndex = 218;
          this.eval_cc.Tag = (object) "3";
          this.eval_cc.Text = "...";
          this.eval_cc.UseVisualStyleBackColor = true;
          this.eval_cd.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_cd.FlatStyle = FlatStyle.Flat;
          this.eval_cd.ForeColor = Color.White;
          this.eval_cd.Location = new Point(146, 48);
          this.eval_cd.Margin = new Padding(0);
          this.eval_cd.Name = "btn_customDeck3";
          this.eval_cd.Size = new Size(25, 23);
          this.eval_cd.TabIndex = 217;
          this.eval_cd.Tag = (object) "2";
          this.eval_cd.Text = "...";
          this.eval_cd.UseVisualStyleBackColor = true;
          this.eval_ce.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_ce.FlatStyle = FlatStyle.Flat;
          this.eval_ce.ForeColor = Color.White;
          this.eval_ce.Location = new Point(146, 24);
          this.eval_ce.Margin = new Padding(0);
          this.eval_ce.Name = "btn_customDeck2";
          this.eval_ce.Size = new Size(25, 23);
          this.eval_ce.TabIndex = 216;
          this.eval_ce.Tag = (object) "1";
          this.eval_ce.Text = "S";
          this.eval_ce.UseVisualStyleBackColor = true;
          this.eval_cf.BackgroundImage = (Image) Resources._0unknown;
          this.eval_cf.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_cf.FlatStyle = FlatStyle.Flat;
          this.eval_cf.ForeColor = Color.Goldenrod;
          this.eval_cf.Location = new Point(146, 0);
          this.eval_cf.Margin = new Padding(0);
          this.eval_cf.Name = "btn_customDeck1";
          this.eval_cf.Size = new Size(25, 23);
          this.eval_cf.TabIndex = 215;
          this.eval_cf.Tag = (object) "0";
          this.eval_cf.Text = "s";
          this.eval_cf.UseVisualStyleBackColor = true;
          this.eval_cf.Click += new EventHandler(this.eval_k);
          this.eval_cg.ForeColor = Color.Gold;
          this.eval_cg.Location = new Point(337, 77);
          this.eval_cg.Margin = new Padding(0);
          this.eval_cg.Name = "l_Gold4";
          this.eval_cg.Size = new Size(38, 13);
          this.eval_cg.TabIndex = 214;
          this.eval_cg.Text = "-";
          this.eval_cg.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_ch.ForeColor = Color.Gold;
          this.eval_ch.Location = new Point(337, 53);
          this.eval_ch.Margin = new Padding(0);
          this.eval_ch.Name = "l_Gold3";
          this.eval_ch.Size = new Size(38, 13);
          this.eval_ch.TabIndex = 213;
          this.eval_ch.Text = "-";
          this.eval_ch.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_ci.ForeColor = Color.Gold;
          this.eval_ci.Location = new Point(337, 29);
          this.eval_ci.Margin = new Padding(0);
          this.eval_ci.Name = "l_Gold2";
          this.eval_ci.Size = new Size(38, 13);
          this.eval_ci.TabIndex = 212;
          this.eval_ci.Text = "-";
          this.eval_ci.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_cj.ForeColor = Color.Gold;
          this.eval_cj.Location = new Point(337, 5);
          this.eval_cj.Margin = new Padding(0);
          this.eval_cj.Name = "l_Gold1";
          this.eval_cj.Size = new Size(38, 13);
          this.eval_cj.TabIndex = 211;
          this.eval_cj.Text = "-";
          this.eval_cj.TextAlign = ContentAlignment.TopCenter;
          this.eval_ck.Enabled = false;
          this.eval_ck.Image = (Image) Resources.shedule;
          this.eval_ck.Location = new Point(183, 2);
          this.eval_ck.Name = "pb_sch1";
          this.eval_ck.Size = new Size(31, 20);
          this.eval_ck.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_ck.TabIndex = 210;
          this.eval_ck.TabStop = false;
          this.eval_ck.Visible = false;
          this.eval_ck.Click += new EventHandler(this.eval_o);
          this.eval_ck.MouseEnter += new EventHandler(this.eval_n);
          this.eval_ck.MouseLeave += new EventHandler(this.eval_m);
          this.eval_cl.Enabled = false;
          this.eval_cl.Image = (Image) Resources.shedule;
          this.eval_cl.Location = new Point(183, 74);
          this.eval_cl.Name = "pb_sch4";
          this.eval_cl.Size = new Size(31, 20);
          this.eval_cl.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_cl.TabIndex = 209;
          this.eval_cl.TabStop = false;
          this.eval_cl.Visible = false;
          this.eval_cm.Enabled = false;
          this.eval_cm.Image = (Image) Resources.shedule;
          this.eval_cm.Location = new Point(183, 50);
          this.eval_cm.Name = "pb_sch3";
          this.eval_cm.Size = new Size(31, 20);
          this.eval_cm.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_cm.TabIndex = 208;
          this.eval_cm.TabStop = false;
          this.eval_cm.Visible = false;
          this.eval_cn.Enabled = false;
          this.eval_cn.Image = (Image) Resources.shedule;
          this.eval_cn.Location = new Point(183, 26);
          this.eval_cn.Name = "pb_sch2";
          this.eval_cn.Size = new Size(31, 20);
          this.eval_cn.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_cn.TabIndex = 207;
          this.eval_cn.TabStop = false;
          this.eval_cn.Visible = false;
          this.eval_co.ForeColor = Color.White;
          this.eval_co.Location = new Point(280, 77);
          this.eval_co.Name = "l_loss4";
          this.eval_co.Size = new Size(27, 13);
          this.eval_co.TabIndex = 206;
          this.eval_co.Text = "-";
          this.eval_co.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_cp.ForeColor = Color.White;
          this.eval_cp.Location = new Point(280, 53);
          this.eval_cp.Name = "l_loss3";
          this.eval_cp.Size = new Size(27, 13);
          this.eval_cp.TabIndex = 205;
          this.eval_cp.Text = "-";
          this.eval_cp.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_cq.ForeColor = Color.White;
          this.eval_cq.Location = new Point(280, 29);
          this.eval_cq.Name = "l_loss2";
          this.eval_cq.Size = new Size(27, 13);
          this.eval_cq.TabIndex = 204;
          this.eval_cq.Text = "-";
          this.eval_cq.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_cr.ForeColor = Color.White;
          this.eval_cr.Location = new Point(280, 5);
          this.eval_cr.Name = "l_loss1";
          this.eval_cr.Size = new Size(27, 13);
          this.eval_cr.TabIndex = 203;
          this.eval_cr.Text = "-";
          this.eval_cr.TextAlign = ContentAlignment.TopCenter;
          this.eval_cs.ForeColor = Color.White;
          this.eval_cs.Location = new Point(252, 77);
          this.eval_cs.Name = "l_wins4";
          this.eval_cs.Size = new Size(34, 13);
          this.eval_cs.TabIndex = 202;
          this.eval_cs.Text = "-";
          this.eval_cs.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_ct.ForeColor = Color.White;
          this.eval_ct.Location = new Point(252, 53);
          this.eval_ct.Name = "l_wins3";
          this.eval_ct.Size = new Size(34, 13);
          this.eval_ct.TabIndex = 201;
          this.eval_ct.Text = "-";
          this.eval_ct.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_cu.ForeColor = Color.White;
          this.eval_cu.Location = new Point(252, 29);
          this.eval_cu.Name = "l_wins2";
          this.eval_cu.Size = new Size(34, 13);
          this.eval_cu.TabIndex = 200;
          this.eval_cu.Text = "-";
          this.eval_cu.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_cv.ForeColor = Color.White;
          this.eval_cv.Location = new Point(252, 5);
          this.eval_cv.Name = "l_wins1";
          this.eval_cv.Size = new Size(34, 13);
          this.eval_cv.TabIndex = 199;
          this.eval_cv.Text = "-";
          this.eval_cv.TextAlign = ContentAlignment.TopCenter;
          this.cw.ForeColor = Color.CornflowerBlue;
          this.cw.Location = new Point(301, 77);
          this.cw.Name = "l_wh4";
          this.cw.Size = new Size(34, 13);
          this.cw.TabIndex = 198;
          this.cw.Text = "-";
          this.cw.TextAlign = ContentAlignment.MiddleCenter;
          this.cx.ForeColor = Color.CornflowerBlue;
          this.cx.Location = new Point(301, 53);
          this.cx.Name = "l_wh3";
          this.cx.Size = new Size(34, 13);
          this.cx.TabIndex = 197;
          this.cx.Text = "-";
          this.cx.TextAlign = ContentAlignment.MiddleCenter;
          this.cy.ForeColor = Color.CornflowerBlue;
          this.cy.Location = new Point(301, 29);
          this.cy.Name = "l_wh2";
          this.cy.Size = new Size(34, 13);
          this.cy.TabIndex = 196;
          this.cy.Text = "-";
          this.cy.TextAlign = ContentAlignment.MiddleCenter;
          this.cz.ForeColor = Color.CornflowerBlue;
          this.cz.Location = new Point(301, 5);
          this.cz.Name = "l_wh1";
          this.cz.Size = new Size(34, 13);
          this.cz.TabIndex = 195;
          this.cz.Text = "-";
          this.cz.TextAlign = ContentAlignment.TopCenter;
          this.eval_c0.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_c0.FlatStyle = FlatStyle.Flat;
          this.eval_c0.ForeColor = Color.White;
          this.eval_c0.Location = new Point(22, 72);
          this.eval_c0.Margin = new Padding(0);
          this.eval_c0.Name = "btn_Pass4";
          this.eval_c0.Size = new Size(125, 23);
          this.eval_c0.TabIndex = 194;
          this.eval_c0.Tag = (object) "3";
          this.eval_c0.Text = "...";
          this.eval_c0.UseVisualStyleBackColor = true;
          this.eval_c1.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_c1.FlatStyle = FlatStyle.Flat;
          this.eval_c1.ForeColor = Color.White;
          this.eval_c1.Location = new Point(22, 48);
          this.eval_c1.Margin = new Padding(0);
          this.eval_c1.Name = "btn_Pass3";
          this.eval_c1.Size = new Size(125, 23);
          this.eval_c1.TabIndex = 193;
          this.eval_c1.Tag = (object) "2";
          this.eval_c1.Text = "...";
          this.eval_c1.UseVisualStyleBackColor = true;
          this.eval_c2.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_c2.FlatStyle = FlatStyle.Flat;
          this.eval_c2.ForeColor = Color.White;
          this.eval_c2.Location = new Point(22, 24);
          this.eval_c2.Margin = new Padding(0);
          this.eval_c2.Name = "btn_Pass2";
          this.eval_c2.Size = new Size(125, 23);
          this.eval_c2.TabIndex = 192;
          this.eval_c2.Tag = (object) "1";
          this.eval_c2.Text = "...";
          this.eval_c2.UseVisualStyleBackColor = true;
          this.eval_c3.ForeColor = Color.Goldenrod;
          this.eval_c3.Location = new Point(221, 76);
          this.eval_c3.Name = "l_Trun4";
          this.eval_c3.Size = new Size(34, 13);
          this.eval_c3.TabIndex = 191;
          this.eval_c3.Text = "--:--";
          this.eval_c3.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_c4.ForeColor = Color.Goldenrod;
          this.eval_c4.Location = new Point(221, 52);
          this.eval_c4.Name = "l_Trun3";
          this.eval_c4.Size = new Size(34, 13);
          this.eval_c4.TabIndex = 190;
          this.eval_c4.Text = "--:--";
          this.eval_c4.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_c5.ForeColor = Color.Goldenrod;
          this.eval_c5.Location = new Point(221, 28);
          this.eval_c5.Name = "l_Trun2";
          this.eval_c5.Size = new Size(34, 13);
          this.eval_c5.TabIndex = 189;
          this.eval_c5.Text = "--:--";
          this.eval_c5.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_c6.ForeColor = Color.Goldenrod;
          this.eval_c6.Location = new Point(221, 4);
          this.eval_c6.Name = "l_Trun1";
          this.eval_c6.Size = new Size(34, 13);
          this.eval_c6.TabIndex = 176;
          this.eval_c6.Text = "--:--";
          this.eval_c6.TextAlign = ContentAlignment.TopCenter;
          this.c7.BackColor = Color.White;
          this.c7.ForeColor = Color.Black;
          this.c7.FormattingEnabled = true;
          this.c7.Items.AddRange(new object[14]
          {
            (object) "0",
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "10",
            (object) "12",
            (object) "15",
            (object) "20",
            (object) "24"
          });
          this.c7.Location = new Point(182, 73);
          this.c7.Name = "cb_DT4";
          this.c7.Size = new Size(35, 21);
          this.c7.TabIndex = 188;
          this.c7.Tag = (object) "4";
          this.c7.Text = "0";
          this.c8.BackColor = Color.White;
          this.c8.ForeColor = Color.Black;
          this.c8.FormattingEnabled = true;
          this.c8.Items.AddRange(new object[14]
          {
            (object) "0",
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "10",
            (object) "12",
            (object) "15",
            (object) "20",
            (object) "24"
          });
          this.c8.Location = new Point(182, 49);
          this.c8.Name = "cb_DT3";
          this.c8.Size = new Size(35, 21);
          this.c8.TabIndex = 187;
          this.c8.Tag = (object) "3";
          this.c8.Text = "0";
          this.c9.BackColor = Color.White;
          this.c9.ForeColor = Color.Black;
          this.c9.FormattingEnabled = true;
          this.c9.Items.AddRange(new object[14]
          {
            (object) "0",
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "10",
            (object) "12",
            (object) "15",
            (object) "20",
            (object) "24"
          });
          this.c9.Location = new Point(182, 25);
          this.c9.Name = "cb_DT2";
          this.c9.Size = new Size(35, 21);
          this.c9.TabIndex = 186;
          this.c9.Tag = (object) "2";
          this.c9.Text = "0";
          this.da.BackColor = Color.White;
          this.da.ForeColor = Color.Black;
          this.da.FormattingEnabled = true;
          this.da.Items.AddRange(new object[14]
          {
            (object) "0",
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "10",
            (object) "12",
            (object) "15",
            (object) "20",
            (object) "24"
          });
          this.da.Location = new Point(182, 1);
          this.da.Name = "cb_DT1";
          this.da.Size = new Size(35, 21);
          this.da.TabIndex = 185;
          this.da.Tag = (object) "1";
          this.da.Text = "7";
          this.da.SelectedIndexChanged += new EventHandler(this.eval_ae);
          this.eval_db.BackColor = Color.White;
          this.eval_db.Enabled = false;
          this.eval_db.ForeColor = Color.Black;
          this.eval_db.FormattingEnabled = true;
          this.eval_db.Items.AddRange(new object[9]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "9"
          });
          this.eval_db.Location = new Point(353, 72);
          this.eval_db.Name = "cb_Deck4";
          this.eval_db.Size = new Size(30, 21);
          this.eval_db.TabIndex = 184;
          this.eval_db.Text = "1";
          this.eval_b3.SetToolTip((Control) this.eval_db, "Temporally disabled");
          this.eval_db.Visible = false;
          this.eval_dc.BackColor = Color.White;
          this.eval_dc.Enabled = false;
          this.eval_dc.ForeColor = Color.Black;
          this.eval_dc.FormattingEnabled = true;
          this.eval_dc.Items.AddRange(new object[9]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "9"
          });
          this.eval_dc.Location = new Point(353, 48);
          this.eval_dc.Name = "cb_Deck3";
          this.eval_dc.Size = new Size(30, 21);
          this.eval_dc.TabIndex = 183;
          this.eval_dc.Text = "1";
          this.eval_b3.SetToolTip((Control) this.eval_dc, "Temporally disabled");
          this.eval_dc.Visible = false;
          this.eval_dd.BackColor = Color.White;
          this.eval_dd.Enabled = false;
          this.eval_dd.ForeColor = Color.Black;
          this.eval_dd.FormattingEnabled = true;
          this.eval_dd.Items.AddRange(new object[9]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "9"
          });
          this.eval_dd.Location = new Point(353, 24);
          this.eval_dd.Name = "cb_Deck2";
          this.eval_dd.Size = new Size(30, 21);
          this.eval_dd.TabIndex = 182;
          this.eval_dd.Text = "1";
          this.eval_b3.SetToolTip((Control) this.eval_dd, "Temporally disabled");
          this.eval_dd.Visible = false;
          this.eval_de.BackColor = Color.White;
          this.eval_de.Enabled = false;
          this.eval_de.ForeColor = Color.Black;
          this.eval_de.FormattingEnabled = true;
          this.eval_de.Items.AddRange(new object[9]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5",
            (object) "6",
            (object) "7",
            (object) "8",
            (object) "9"
          });
          this.eval_de.Location = new Point(353, 0);
          this.eval_de.Name = "cb_Deck1";
          this.eval_de.Size = new Size(30, 21);
          this.eval_de.TabIndex = 181;
          this.eval_de.Text = "1";
          this.eval_b3.SetToolTip((Control) this.eval_de, "Temporally disabled");
          this.eval_de.Visible = false;
          this.eval_de.SelectedIndexChanged += new EventHandler(this.eval_g);
          this.eval_df.BackgroundImage = (Image) Resources._0unknown;
          this.eval_df.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_df.FlatStyle = FlatStyle.Flat;
          this.eval_df.ForeColor = Color.White;
          this.eval_df.Location = new Point(22, 0);
          this.eval_df.Margin = new Padding(0);
          this.eval_df.Name = "btn_Pass1";
          this.eval_df.Size = new Size(125, 23);
          this.eval_df.TabIndex = 180;
          this.eval_df.Tag = (object) "0";
          this.eval_df.Text = "button1";
          this.eval_df.UseVisualStyleBackColor = true;
          this.eval_df.Click += new EventHandler(this.eval_ag);
          this.dg.AutoSize = true;
          this.dg.FlatStyle = FlatStyle.Flat;
          this.dg.Location = new Point(5, 77);
          this.dg.Name = "rb_4";
          this.dg.Size = new Size(13, 12);
          this.dg.TabIndex = 179;
          this.dg.TabStop = true;
          this.dg.Tag = (object) "4";
          this.dg.UseVisualStyleBackColor = true;
          this.dh.AutoSize = true;
          this.dh.FlatStyle = FlatStyle.Flat;
          this.dh.Location = new Point(5, 53);
          this.dh.Name = "rb_3";
          this.dh.Size = new Size(13, 12);
          this.dh.TabIndex = 178;
          this.dh.TabStop = true;
          this.dh.Tag = (object) "3";
          this.dh.UseVisualStyleBackColor = true;
          this.di.AutoSize = true;
          this.di.FlatStyle = FlatStyle.Flat;
          this.di.Location = new Point(5, 29);
          this.di.Name = "rb_2";
          this.di.Size = new Size(13, 12);
          this.di.TabIndex = 177;
          this.di.TabStop = true;
          this.di.Tag = (object) "2";
          this.di.UseVisualStyleBackColor = true;
          this.dj.AutoSize = true;
          this.dj.BackColor = Color.FromArgb(49, 49, 49);
          this.dj.BackgroundImageLayout = ImageLayout.None;
          this.dj.FlatStyle = FlatStyle.Flat;
          this.dj.ForeColor = Color.Orange;
          this.dj.Location = new Point(5, 5);
          this.dj.Name = "rb_1";
          this.dj.Size = new Size(13, 12);
          this.dj.TabIndex = 175;
          this.dj.TabStop = true;
          this.dj.Tag = (object) "1";
          this.dj.UseVisualStyleBackColor = false;
          this.dj.CheckedChanged += new EventHandler(this.eval_aa);
          this.eval_ca.Enabled = false;
          this.eval_ca.Image = (Image) Resources.bot_settings_bw;
          this.eval_ca.Location = new Point(149, 10);
          this.eval_ca.Margin = new Padding(0);
          this.eval_ca.Name = "pb_botSettings";
          this.eval_ca.Size = new Size(22, 40);
          this.eval_ca.TabIndex = 187;
          this.eval_ca.TabStop = false;
          this.eval_b3.SetToolTip((Control) this.eval_ca, "Allows to use your own Bot Settings and Custom Deck for each account.\r\n\r\nClick to activate.");
          this.eval_ca.Click += new EventHandler(this.eval_j);
          this.eval_ca.MouseEnter += new EventHandler(this.eval_i);
          this.eval_ca.MouseLeave += new EventHandler(this.eval_h);
          this.eval_b5.Enabled = false;
          this.eval_b5.ForeColor = Color.Gold;
          this.eval_b5.Location = new Point(343, 17);
          this.eval_b5.Name = "l_GoldL";
          this.eval_b5.Size = new Size(33, 26);
          this.eval_b5.TabIndex = 46;
          this.eval_b5.Text = "Gold";
          this.eval_b5.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_b0.AutoSize = true;
          this.eval_b0.Location = new Point(289, 25);
          this.eval_b0.Name = "l_lossL";
          this.eval_b0.Size = new Size(13, 13);
          this.eval_b0.TabIndex = 37;
          this.eval_b0.Text = "L";
          this.eval_b0.TextAlign = ContentAlignment.TopCenter;
          this.eval_b3.SetToolTip((Control) this.eval_b0, "Losses per day");
          this.eval_b1.AutoSize = true;
          this.eval_b1.Location = new Point(263, 25);
          this.eval_b1.Name = "l_winsL";
          this.eval_b1.Size = new Size(18, 13);
          this.eval_b1.TabIndex = 32;
          this.eval_b1.Text = "W";
          this.eval_b1.TextAlign = ContentAlignment.TopCenter;
          this.eval_b3.SetToolTip((Control) this.eval_b1, "Wins per day");
          this.b2.AutoSize = true;
          this.b2.ForeColor = Color.CornflowerBlue;
          this.b2.Location = new Point(308, 25);
          this.b2.Name = "l_whL";
          this.b2.Size = new Size(29, 13);
          this.b2.TabIndex = 27;
          this.b2.Text = "W/h";
          this.b2.TextAlign = ContentAlignment.TopCenter;
          this.eval_b3.SetToolTip((Control) this.b2, "Wins per hour");
          this.bu.BackColor = Color.Transparent;
          this.bu.ForeColor = Color.FromArgb((int) byte.MaxValue, 192, 128);
          this.bu.Location = new Point(46, 1);
          this.bu.Name = "label1";
          this.bu.Size = new Size(37, 16);
          this.bu.TabIndex = 10;
          this.bu.Text = "...";
          this.bp.AutoSize = true;
          this.bp.Location = new Point(227, 17);
          this.bp.Name = "l_Run";
          this.bp.Size = new Size(30, 26);
          this.bp.TabIndex = 7;
          this.bp.Text = "Run,\r\nh:m";
          this.bp.TextAlign = ContentAlignment.TopCenter;
          this.eval_bq.AutoSize = true;
          this.eval_bq.Location = new Point(176, 17);
          this.eval_bq.Name = "l_Duration";
          this.eval_bq.Size = new Size(50, 26);
          this.eval_bq.TabIndex = 6;
          this.eval_bq.Text = "Duration,\r\nhours";
          this.eval_bq.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_br.AutoSize = true;
          this.eval_br.Image = (Image) Resources._0unknown;
          this.eval_br.Location = new Point(41, 24);
          this.eval_br.Name = "l_Character_name";
          this.eval_br.Size = new Size(82, 13);
          this.eval_br.TabIndex = 4;
          this.eval_br.Text = "Character name";
          this.eval_bs.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_bs.FlatStyle = FlatStyle.Flat;
          this.eval_bs.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
          this.eval_bs.ForeColor = Color.Orange;
          this.eval_bs.Location = new Point(430, 8);
          this.eval_bs.Name = "btn_StartR";
          this.eval_bs.Size = new Size(94, 22);
          this.eval_bs.TabIndex = 9;
          this.eval_bs.Text = "Start tracking";
          this.eval_bs.UseVisualStyleBackColor = true;
          this.eval_bs.Click += new EventHandler(this.eval_ad);
          this.bt.Interval = 10000;
          this.bt.Tick += new EventHandler(this.eval_ac);
          this.eval_bv.Enabled = true;
          this.eval_bv.Interval = 1000;
          this.eval_bv.Tick += new EventHandler(this.eval_y);
          this.eval_bw.ForeColor = Color.Orange;
          this.eval_bw.Location = new Point(409, 176);
          this.eval_bw.Margin = new Padding(3, 0, 0, 0);
          this.eval_bw.Name = "lbl_autostart";
          this.eval_bw.Size = new Size(109, 17);
          this.eval_bw.TabIndex = 10;
          this.eval_bw.Text = "Autostart in 10:00 min";
          this.eval_bw.TextAlign = ContentAlignment.MiddleCenter;
          this.eval_bx.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_bx.ForeColor = Color.CornflowerBlue;
          this.eval_bx.Location = new Point(427, 194);
          this.eval_bx.Name = "lbl_Reboots";
          this.eval_bx.Size = new Size(100, 19);
          this.eval_bx.TabIndex = 12;
          this.eval_bx.Text = "Total reboots: 0";
          this.eval_by.ForeColor = Color.Gray;
          this.eval_by.Location = new Point(199, 192);
          this.eval_by.Name = "cb_30WinsRelogin";
          this.eval_by.Size = new Size(179, 18);
          this.eval_by.TabIndex = 0;
          this.eval_by.Text = "change account after 30 wins";
          this.eval_by.UseVisualStyleBackColor = true;
          this.b9.BackColor = Color.FromArgb(49, 49, 49);
          this.b9.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte) 204);
          this.b9.ForeColor = Color.DarkOliveGreen;
          this.b9.Location = new Point(374, 194);
          this.b9.Name = "lbl_TS";
          this.b9.Size = new Size(48, 19);
          this.b9.TabIndex = 17;
          this.b9.Text = "-24:24-";
          this.b9.TextAlign = ContentAlignment.TopCenter;
          this.eval_b3.SetToolTip((Control) this.b9, "The time elapsed from the time when you got a new Daily Quest.\r\n* Click to change the viev: elapsed(-) / remaining(*)\r\n** Double-click  to edit.");
          this.b9.Click += new EventHandler(this.eval_z);
          this.b9.DoubleClick += new EventHandler(this.eval_u);
          this.eval_dl.Image = (Image) Resources.arrows_down_bw;
          this.eval_dl.Location = new Point(297, 10);
          this.eval_dl.Margin = new Padding(0);
          this.eval_dl.Name = "pb_arrowDown";
          this.eval_dl.Size = new Size(14, 19);
          this.eval_dl.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_dl.TabIndex = 190;
          this.eval_dl.TabStop = false;
          this.eval_b3.SetToolTip((Control) this.eval_dl, "Move Down the selected account");
          this.eval_dl.Click += new EventHandler(this.eval_e);
          this.eval_dl.MouseEnter += new EventHandler(this.eval_b);
          this.eval_dl.MouseLeave += new EventHandler(this.eval_a);
          this.eval_dk.Image = (Image) Resources.arrows_up_bw;
          this.eval_dk.Location = new Point(284, 10);
          this.eval_dk.Margin = new Padding(0);
          this.eval_dk.Name = "pb_arrowUp";
          this.eval_dk.Size = new Size(14, 19);
          this.eval_dk.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_dk.TabIndex = 189;
          this.eval_dk.TabStop = false;
          this.eval_b3.SetToolTip((Control) this.eval_dk, "Move Up  the selected account");
          this.eval_dk.Click += new EventHandler(this.eval_f);
          this.eval_dk.MouseEnter += new EventHandler(this.eval_d);
          this.eval_dk.MouseLeave += new EventHandler(this.eval_c);
          this.eval_b8.Image = (Image) Resources.cogwheelBW;
          this.eval_b8.Location = new Point(395, 5);
          this.eval_b8.Margin = new Padding(0);
          this.eval_b8.Name = "pb_Settings";
          this.eval_b8.Size = new Size(31, 31);
          this.eval_b8.TabIndex = 16;
          this.eval_b8.TabStop = false;
          this.eval_b3.SetToolTip((Control) this.eval_b8, "Hearthlogger settings");
          this.eval_b8.Click += new EventHandler(this.eval_u);
          this.eval_b8.MouseEnter += new EventHandler(this.eval_t);
          this.eval_b8.MouseLeave += new EventHandler(this.eval_s);
          this.eval_b6.Image = (Image) Resources.questLogDisable;
          this.eval_b6.Location = new Point(318, 2);
          this.eval_b6.Margin = new Padding(0);
          this.eval_b6.Name = "pb_QuestLog";
          this.eval_b6.Size = new Size(41, 34);
          this.eval_b6.TabIndex = 15;
          this.eval_b6.TabStop = false;
          this.eval_b3.SetToolTip((Control) this.eval_b6, "Use Daily Quests");
          this.eval_b6.Click += new EventHandler(this.eval_r);
          this.eval_b6.MouseEnter += new EventHandler(this.eval_q);
          this.eval_b6.MouseLeave += new EventHandler(this.eval_p);
          this.eval_bz.Image = (Image) Resources.spisokBW4;
          this.eval_bz.Location = new Point(359, 5);
          this.eval_bz.Name = "pictureBox_Log";
          this.eval_bz.Size = new Size(29, 28);
          this.eval_bz.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_bz.TabIndex = 13;
          this.eval_bz.TabStop = false;
          this.eval_b3.SetToolTip((Control) this.eval_bz, "Game stats");
          this.eval_bz.Click += new EventHandler(this.eval_v);
          this.eval_bz.MouseEnter += new EventHandler(this.eval_x);
          this.eval_bz.MouseLeave += new EventHandler(this.eval_w);
          this.eval_b4.ForeColor = Color.Gray;
          this.eval_b4.Location = new Point(12, 192);
          this.eval_b4.Name = "cb_useSchedule";
          this.eval_b4.Size = new Size(179, 18);
          this.eval_b4.TabIndex = 14;
          this.eval_b4.Text = "use schedule (your local time)";
          this.eval_b4.UseVisualStyleBackColor = true;
          this.eval_b4.CheckedChanged += new EventHandler(this.eval_l);
          this.eval_b7.Interval = 180000;
          this.eval_b7.Tick += new EventHandler(this.eval_ab);
          this.eval_bn.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
          this.eval_bn.Location = new Point(8, 12);
          this.eval_bn.Name = "pictureBox1";
          this.eval_bn.Size = new Size(119, 182);
          this.eval_bn.SizeMode = PictureBoxSizeMode.AutoSize;
          this.eval_bn.TabIndex = 0;
          this.eval_bn.TabStop = false;
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.BackColor = Color.FromArgb(49, 49, 49);
          this.ClientSize = new Size(534, 213);
          this.Controls.Add((Control) this.eval_dl);
          this.Controls.Add((Control) this.eval_dk);
          this.Controls.Add((Control) this.b9);
          this.Controls.Add((Control) this.eval_b8);
          this.Controls.Add((Control) this.eval_b6);
          this.Controls.Add((Control) this.eval_b4);
          this.Controls.Add((Control) this.eval_bz);
          this.Controls.Add((Control) this.eval_by);
          this.Controls.Add((Control) this.eval_bx);
          this.Controls.Add((Control) this.eval_bw);
          this.Controls.Add((Control) this.eval_bs);
          this.Controls.Add((Control) this.eval_bo);
          this.Controls.Add((Control) this.eval_bn);
          this.ForeColor = Color.Gray;
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
          this.MaximizeBox = false;
          this.Name = "Form1";
          this.Text = "Hearthlogger (2.0.4.32 alpha)";
          this.FormClosing += new FormClosingEventHandler(this.eval_a);
          this.Load += new EventHandler(this.eval_af);
          this.eval_bo.ResumeLayout(false);
          this.eval_bo.PerformLayout();
          this.eval_cb.ResumeLayout(false);
          this.eval_cb.PerformLayout();
          ((ISupportInitialize) this.eval_ck).EndInit();
          ((ISupportInitialize) this.eval_cl).EndInit();
          ((ISupportInitialize) this.eval_cm).EndInit();
          ((ISupportInitialize) this.eval_cn).EndInit();
          ((ISupportInitialize) this.eval_ca).EndInit();
          ((ISupportInitialize) this.eval_dl).EndInit();
          ((ISupportInitialize) this.eval_dk).EndInit();
          ((ISupportInitialize) this.eval_b8).EndInit();
          ((ISupportInitialize) this.eval_b6).EndInit();
          ((ISupportInitialize) this.eval_bz).EndInit();
          ((ISupportInitialize) this.eval_bn).EndInit();
          this.ResumeLayout(false);
          this.PerformLayout();
          break;
        default:
          goto case 1;
      }
    }
  }
}
