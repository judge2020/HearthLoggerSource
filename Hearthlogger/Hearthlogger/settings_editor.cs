// Decompiled with JetBrains decompiler
// Type: Hearthlogger.settings_editor
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Hearthlogger
{
  public class settings_editor : Form
  {
    private string eval_a = "noparam";
    private string eval_b = "";
    private string eval_c = "";
    private string eval_d = "";
    private string eval_e = "";
    private string eval_f = "";
    private bool eval_g = true;
    private bool eval_h = false;
    private Dictionary<int, string> eval_i = new Dictionary<int, string>()
    {
      {
        2,
        "DRUID"
      },
      {
        3,
        "HUNTER"
      },
      {
        4,
        "MAGE"
      },
      {
        5,
        "PALADIN"
      },
      {
        6,
        "PRIEST"
      },
      {
        7,
        "ROGUE"
      },
      {
        8,
        "SHAMAN"
      },
      {
        9,
        "WARLOCK"
      },
      {
        10,
        "WARRIOR"
      }
    };
    private Dictionary<int, string> eval_j = new Dictionary<int, string>()
    {
      {
        0,
        "Practice"
      },
      {
        1,
        "Arena"
      },
      {
        2,
        "Constructed"
      },
      {
        3,
        "Friendly"
      }
    };
    private Dictionary<int, string> eval_k = new Dictionary<int, string>()
    {
      {
        0,
        "Casual"
      },
      {
        1,
        "Ranked"
      }
    };
    private Dictionary<int, string> eval_l = new Dictionary<int, string>()
    {
      {
        0,
        "Basic"
      },
      {
        1,
        "Custom"
      }
    };
    private Dictionary<string, string> eval_m = new Dictionary<string, string>();
    private IContainer eval_n = (IContainer) null;
    private CheckBox eval_o;
    private CheckBox eval_p;
    private CheckBox eval_q;
    private CheckBox eval_r;
    private CheckBox eval_s;
    private ComboBox eval_t;
    private ComboBox eval_u;
    private ComboBox eval_v;
    private ComboBox eval_w;
    private ComboBox eval_x;
    private Label eval_y;
    private GroupBox eval_z;
    private Label aa;
    private Label ab;
    private Label ac;
    private GroupBox eval_ad;
    private Label ae;
    private ComboBox eval_af;
    private Label ag;
    private ComboBox eval_ah;
    private Label ai;
    private ComboBox eval_aj;
    private ComboBox eval_ak;
    private Label eval_al;
    private ComboBox eval_am;
    private Label an;
    private Label ao;
    private GroupBox eval_ap;
    private CheckBox eval_aq;
    private CheckBox eval_ar;
    private Button eval_as;
    private ToolTip eval_at;
    private GroupBox eval_au;
    private Button eval_av;
    [NonSerialized]
    string eval_aw;

    public settings_editor(string[] args)
    {
      this.eval_a();
      this.eval_d = args[0];
      this.eval_e = args[1];
      this.eval_f = this.eval_d + "\\hrstore\\" + this.eval_e.Replace("@", "");
    }

    private void eval_q(object A_0, EventArgs A_1)
    {
      int num1 = -10260;
      int num2 = num1;
      num1 = -10260;
      int num3 = num1;
      switch (num2 == num3)
      {
        case true:
          int num4 = 0;
          if (num4 == 0)
            ;
          num4 = 0;
          num4 = 1;
          if (num4 == 0)
            ;
          this.eval_g = true;
          this.eval_d();
          this.eval_g = false;
          break;
        default:
          goto case 1;
      }
    }

    private void eval_d()
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
              this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
              flag = File.Exists(this.eval_c);
              num2 = 15;
              num1 = num2;
              goto default;
            default:
              string key1;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                    this.eval_h = true;
                    num2 = 49;
                    num1 = num2;
                    continue;
                  case 1:
                    this.eval_h = true;
                    num2 = 37;
                    num1 = num2;
                    continue;
                  case 2:
                    this.eval_h = true;
                    num2 = 26;
                    num1 = num2;
                    continue;
                  case 3:
                    this.eval_h = true;
                    num2 = 8;
                    num1 = num2;
                    continue;
                  case 4:
                    if (!flag)
                    {
                      num2 = 35;
                      num1 = num2;
                      continue;
                    }
                    goto case 17;
                  case 5:
                    if (!flag)
                    {
                      num2 = 45;
                      num1 = num2;
                      continue;
                    }
                    goto case 50;
                  case 6:
                    this.eval_h = true;
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 7:
                    if (!flag)
                    {
                      num2 = 46;
                      num1 = num2;
                      continue;
                    }
                    goto case 44;
                  case 8:
                    this.eval_u.Text = this.eval_i[Convert.ToInt32(key1)];
                    this.eval_v.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_i.Values);
                    key1 = this.eval_a("ArenaPreferredClass3");
                    flag = !(key1 == "error8888");
                    num2 = 28;
                    num1 = num2;
                    continue;
                  case 9:
                    this.eval_w.Text = this.eval_i[Convert.ToInt32(key1)];
                    this.eval_x.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_i.Values);
                    key1 = this.eval_a("ArenaPreferredClass5");
                    flag = !(key1 == "error8888");
                    num2 = 22;
                    num1 = num2;
                    continue;
                  case 10:
                    goto label_115;
                  case 11:
                    try
                    {
                      string[] files;
                      switch (0)
                      {
                        case 0:
label_50:
                          files = Directory.GetFiles(this.eval_f + "\\Settings\\Default\\CustomDecks");
                          flag = Enumerable.Count<string>((IEnumerable<string>) files) != 0;
                          num2 = 0;
                          num1 = num2;
                          goto default;
                        default:
                          string[] strArray;
                          int index;
                          string key2;
                          int num3;
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
                                num3 = 0;
                                this.eval_m.Clear();
                                strArray = files;
                                index = 0;
                                num2 = 15;
                                num1 = num2;
                                continue;
                              case 1:
                              case 11:
label_67:
                                ++index;
                                num2 = 10;
                                num1 = num2;
                                continue;
                              case 2:
                                num2 = 16118;
                                int num4 = num2;
                                num2 = 16118;
                                int num5 = num2;
                                switch (num4 == num5 ? 1 : 0)
                                {
                                  case 0:
                                  case 2:
                                    goto label_67;
                                  default:
                                    num2 = 0;
                                    if (num2 == 0)
                                      ;
                                    flag = num3 <= 0;
                                    num2 = 3;
                                    num1 = num2;
                                    continue;
                                }
                              case 3:
                                if (!flag)
                                {
                                  num2 = 8;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 7;
                              case 4:
                                if (!flag)
                                {
                                  num2 = 18;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 14;
                              case 5:
                                goto label_113;
                              case 6:
                                this.eval_h = true;
                                num2 = 19;
                                num1 = num2;
                                continue;
                              case 7:
                                num2 = 16;
                                num1 = num2;
                                continue;
                              case 8:
                                int num6 = (int) MessageBox.Show("You have several Heroes with the same names.\r\nYou should rename your Heroes and Re-Cache Custom Decks, otherwise they will not be available for the games.", "Warning!");
                                num2 = 7;
                                num1 = num2;
                                continue;
                              case 9:
                                if (!flag)
                                {
                                  num2 = 6;
                                  num1 = num2;
                                  continue;
                                }
                                goto case 19;
                              case 10:
                              case 15:
                                flag = index < strArray.Length;
                                num2 = 13;
                                num1 = num2;
                                continue;
                              case 12:
                                int num7 = (int) MessageBox.Show("Custom Decks not found!\r\n\r\nTo use this feature you have to Re-Cache Custom Decks in the bot.", "Error 1541!");
                                this.eval_a(true);
                                num2 = 5;
                                num1 = num2;
                                continue;
                              case 13:
                                if (flag)
                                {
                                  this.eval_c = strArray[index];
                                  key2 = this.eval_a("Name").Replace("\"", "");
                                  flag = !(key2 == "error8888");
                                  num2 = 4;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 2;
                                num1 = num2;
                                continue;
                              case 14:
                                flag = !this.eval_m.ContainsKey(key2);
                                num2 = 20;
                                num1 = num2;
                                continue;
                              case 16:
                                goto label_80;
                              case 17:
                                ++num3;
                                num2 = 1;
                                num1 = num2;
                                continue;
                              case 18:
                                this.eval_h = true;
                                num2 = 14;
                                num1 = num2;
                                continue;
                              case 19:
                                this.eval_m.Add(key2, key1);
                                num2 = 11;
                                num1 = num2;
                                continue;
                              case 20:
                                if (flag)
                                {
                                  key1 = this.eval_a("HeroCardId").Replace("\"", "");
                                  flag = !(key1 == "error8888");
                                  num2 = 9;
                                  num1 = num2;
                                  continue;
                                }
                                num2 = 17;
                                num1 = num2;
                                continue;
                              default:
                                goto label_50;
                            }
                          }
label_113:
                          return;
                      }
                    }
                    catch (Exception ex)
                    {
                      int num3 = (int) MessageBox.Show("Custom Decks not found!\r\n\r\nTo use this feature you have to Re-Cache Custom Decks in the bot.", "Error!");
                      this.eval_a(true);
                      return;
                    }
label_80:
                    this.eval_af.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_m.Keys);
                    this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                    key1 = this.eval_a("ConstructedCustomDeck").Replace("\"", "");
                    flag = !(key1 == "error8888");
                    num2 = 56;
                    num1 = num2;
                    continue;
                  case 12:
                    if (!flag)
                    {
                      num2 = 57;
                      num1 = num2;
                      continue;
                    }
                    goto case 58;
                  case 13:
                    num2 = 53;
                    num1 = num2;
                    continue;
                  case 14:
                    int num8 = (int) MessageBox.Show("File not exist\r\nPlease grab the Settings at start", "Error!");
                    this.Close();
                    num2 = 33;
                    num1 = num2;
                    continue;
                  case 15:
                    if (!flag)
                    {
                      num2 = 38;
                      num1 = num2;
                      continue;
                    }
                    this.eval_h = false;
                    flag = File.Exists(this.eval_f + "\\ok.txt");
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 16:
                    this.eval_s.Checked = key1 == "true";
                    key1 = this.eval_a("AutoGreet");
                    flag = !(key1 == "error8888");
                    num2 = 24;
                    num1 = num2;
                    continue;
                  case 17:
                    key1 = this.eval_a("ArenaDontDraft");
                    flag = !(key1 == "error8888");
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 18:
                    this.eval_af.Text = key1;
                    this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultRoutine.json";
                    flag = File.Exists(this.eval_c);
                    num2 = 54;
                    num1 = num2;
                    continue;
                  case 19:
                    this.eval_h = true;
                    num2 = 41;
                    num1 = num2;
                    continue;
                  case 20:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    if (!flag)
                    {
                      num2 = 3;
                      num1 = num2;
                      continue;
                    }
                    goto case 8;
                  case 21:
                    this.eval_h = true;
                    num2 = 32;
                    num1 = num2;
                    continue;
                  case 22:
                    if (!flag)
                    {
                      num2 = 36;
                      num1 = num2;
                      continue;
                    }
                    goto case 55;
                  case 23:
                    flag = this.eval_m.ContainsKey(key1);
                    num2 = 27;
                    num1 = num2;
                    continue;
                  case 24:
                    if (!flag)
                    {
                      num2 = 25;
                      num1 = num2;
                      continue;
                    }
                    goto case 59;
                  case 25:
                    this.eval_h = true;
                    num2 = 59;
                    num1 = num2;
                    continue;
                  case 26:
                    this.eval_aj.Text = this.eval_l[Convert.ToInt32(key1)];
                    this.eval_ah.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_i.Values);
                    key1 = this.eval_a("ConstructedBasicDeck");
                    flag = !(key1 == "error8888");
                    num2 = 31;
                    num1 = num2;
                    continue;
                  case 27:
                    if (!flag)
                    {
                      num2 = 42;
                      num1 = num2;
                      continue;
                    }
                    goto case 18;
                  case 28:
                    if (!flag)
                    {
                      num2 = 21;
                      num1 = num2;
                      continue;
                    }
                    goto case 32;
                  case 29:
                    goto label_109;
                  case 30:
                    if (!flag)
                    {
                      num2 = 51;
                      num1 = num2;
                      continue;
                    }
                    goto case 9;
                  case 31:
                    if (!flag)
                    {
                      num2 = 19;
                      num1 = num2;
                      continue;
                    }
                    goto case 41;
                  case 32:
                    this.eval_v.Text = this.eval_i[Convert.ToInt32(key1)];
                    this.eval_w.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_i.Values);
                    key1 = this.eval_a("ArenaPreferredClass4");
                    flag = !(key1 == "error8888");
                    num2 = 30;
                    num1 = num2;
                    continue;
                  case 33:
                    this.eval_t.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_i.Values);
                    key1 = this.eval_a("ArenaPreferredClass1");
                    flag = !(key1 == "error8888");
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 34:
                    this.eval_q.Checked = key1 == "true";
                    key1 = this.eval_a("ArenaDontOpenRewards");
                    flag = !(key1 == "error8888");
                    num2 = 47;
                    num1 = num2;
                    continue;
                  case 35:
                    this.eval_h = true;
                    num2 = 17;
                    num1 = num2;
                    continue;
                  case 36:
                    this.eval_h = true;
                    num2 = 55;
                    num1 = num2;
                    continue;
                  case 37:
                    this.eval_am.Text = this.eval_j[Convert.ToInt32(key1)];
                    this.eval_ak.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_k.Values);
                    key1 = this.eval_a("ConstructedMode");
                    flag = !(key1 == "error8888");
                    num2 = 43;
                    num1 = num2;
                    continue;
                  case 38:
                    num2 = 0;
                    int num9 = (int) MessageBox.Show("Settings not exist.\r\nPlease grab the Settings at start.", "Error!");
                    this.eval_a(true);
                    num2 = 10;
                    num1 = num2;
                    continue;
                  case 39:
                    if (!flag)
                    {
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    goto case 37;
                  case 40:
                    if (!flag)
                    {
                      num2 = 2;
                      num1 = num2;
                      continue;
                    }
                    goto case 26;
                  case 41:
                    this.eval_ah.Text = this.eval_i[Convert.ToInt32(key1)];
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 42:
                    key1 = "-";
                    num2 = 18;
                    num1 = num2;
                    continue;
                  case 43:
                    if (!flag)
                    {
                      num2 = 0;
                      num1 = num2;
                      continue;
                    }
                    goto case 49;
                  case 44:
                    num2 = 34;
                    num1 = num2;
                    continue;
                  case 45:
                    this.eval_h = true;
                    num2 = 50;
                    num1 = num2;
                    continue;
                  case 46:
                    this.eval_h = true;
                    num2 = 44;
                    num1 = num2;
                    continue;
                  case 47:
                    if (!flag)
                    {
                      num2 = 6;
                      num1 = num2;
                      continue;
                    }
                    goto case 13;
                  case 48:
                    this.Close();
                    num2 = 23;
                    num1 = num2;
                    continue;
                  case 49:
                    this.eval_ak.Text = this.eval_k[Convert.ToInt32(key1)];
                    this.eval_aj.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_l.Values);
                    key1 = this.eval_a("ConstructedDeckType");
                    flag = !(key1 == "error8888");
                    num2 = 40;
                    num1 = num2;
                    continue;
                  case 50:
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 51:
                    this.eval_h = true;
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 52:
                    this.eval_p.Checked = key1 == "true";
                    this.eval_am.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_j.Values);
                    key1 = this.eval_a("GameMode");
                    flag = !(key1 == "error8888");
                    num2 = 39;
                    num1 = num2;
                    continue;
                  case 53:
                    this.eval_r.Checked = key1 == "true";
                    key1 = this.eval_a("AutoConcedeAfterConstructedWin");
                    flag = !(key1 == "error8888");
                    num2 = 5;
                    num1 = num2;
                    continue;
                  case 54:
                    if (!flag)
                    {
                      num2 = 14;
                      num1 = num2;
                      continue;
                    }
                    goto case 33;
                  case 55:
                    this.eval_x.Text = this.eval_i[Convert.ToInt32(key1)];
                    this.eval_b();
                    this.eval_a(this.eval_h);
                    num2 = 29;
                    num1 = num2;
                    continue;
                  case 56:
                    if (!flag)
                    {
                      num2 = 48;
                      num1 = num2;
                      continue;
                    }
                    goto case 23;
                  case 57:
                    this.eval_h = true;
                    num2 = 58;
                    num1 = num2;
                    continue;
                  case 58:
                    this.eval_t.Text = this.eval_i[Convert.ToInt32(key1)];
                    this.eval_u.DataSource = (object) new List<string>((IEnumerable<string>) this.eval_i.Values);
                    key1 = this.eval_a("ArenaPreferredClass2");
                    flag = !(key1 == "error8888");
                    num2 = 20;
                    num1 = num2;
                    continue;
                  case 59:
                    num2 = 52;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_109:
              return;
label_115:
              return;
          }
      }
    }

    private string eval_a(string A_0)
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
              num2 = 11;
              num1 = num2;
              goto default;
            default:
              string str2;
              while (true)
              {
                int startIndex1;
                int num3;
                bool flag;
                int num4;
                switch (num1)
                {
                  case 0:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num4 = 1;
                    break;
                  case 1:
                  case 10:
                  case 14:
                    goto label_29;
                  case 2:
                    num2 = 12;
                    num1 = num2;
                    continue;
                  case 3:
                    num3 = str1.IndexOf("\r\n", startIndex1);
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 4:
                    flag = num3 < 0;
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 5:
                    int startIndex2 = startIndex1 + A_0.Length + 3;
                    str2 = str1.Substring(startIndex2, num3 - startIndex2);
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 6:
                    if (!flag)
                    {
                      num2 = 7;
                      num1 = num2;
                      continue;
                    }
                    num2 = 18985;
                    int num5 = num2;
                    num2 = 18985;
                    int num6 = num2;
                    switch (num5 == num6 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_29;
                      default:
                        num2 = 0;
                        if (num2 == 0)
                          ;
                        num3 = str1.IndexOf(",", startIndex1);
                        num2 = 8;
                        num1 = num2;
                        continue;
                    }
                  case 7:
                    num2 = 0;
                    int num7 = (int) MessageBox.Show("Parametr not exist\r\nMaybe structure Settings files was changed. Grab new Settings", "Error!");
                    str2 = "error8888";
                    num2 = 10;
                    num1 = num2;
                    continue;
                  case 8:
                    if (num3 != -1)
                    {
                      num2 = 0;
                      num1 = num2;
                      continue;
                    }
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 9:
                    if (!flag)
                    {
                      num2 = 3;
                      num1 = num2;
                      continue;
                    }
                    goto case 4;
                  case 11:
                    try
                    {
                      str1 = File.ReadAllText(this.eval_c);
                    }
                    catch (Exception ex)
                    {
                      int num8 = (int) MessageBox.Show("Read error", "Error!");
                      str2 = "error8888";
                      goto label_29;
                    }
                    startIndex1 = str1.LastIndexOf(A_0);
                    flag = startIndex1 >= 1;
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 12:
                    num4 = str1.Length - startIndex1 - A_0.Length >= 11 ? 1 : 0;
                    break;
                  case 13:
                    if (flag)
                    {
                      int num8 = (int) MessageBox.Show("No Value. Grab new Settings", "Error!");
                      str2 = "error8888";
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    num2 = 5;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
                flag = num4 != 0;
                num2 = 9;
                num1 = num2;
              }
label_29:
              return str2;
          }
      }
    }

    private void eval_c()
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
              flag = File.Exists(this.eval_c);
              num2 = 13;
              num1 = num2;
              goto default;
            default:
              while (true)
              {
                string contents;
                int startIndex1;
                int num3;
                int num4;
                int num5;
                switch (num1)
                {
                  case 0:
                    num2 = -18102;
                    int num6 = num2;
                    num2 = -18102;
                    int num7 = num2;
                    switch (num6 == num7 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        break;
                      default:
                        goto label_29;
                    }
                  case 1:
                    int num8 = (int) MessageBox.Show("File not exist\r\nPlease grab the Settings at start", "Error!");
                    num2 = 0;
                    num1 = num2;
                    continue;
                  case 2:
                    if (num4 >= 0)
                    {
                      num2 = 5;
                      num1 = num2;
                      continue;
                    }
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 3:
                    num3 = num4;
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 4:
                    num5 = num4 >= num3 ? 1 : 0;
                    goto label_35;
                  case 5:
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 6:
                    num2 = 0;
                    goto label_13;
                  case 7:
                    int num9 = (int) MessageBox.Show("Parametr not exist\r\nMaybe structure Settings files was changed. Param not applayed", "Error!");
                    num2 = 14;
                    num1 = num2;
                    continue;
                  case 8:
                    int startIndex2 = startIndex1 + this.eval_a.Length + 3;
                    contents = contents.Remove(startIndex2, num3 - startIndex2).Insert(startIndex2, this.eval_b);
                    File.WriteAllText(this.eval_c, contents);
                    num2 = 15;
                    num1 = num2;
                    continue;
                  case 9:
                    if (!flag)
                    {
                      num2 = 1;
                      if (num2 == 0)
                        ;
                      num2 = 3;
                      num1 = num2;
                      continue;
                    }
                    goto label_13;
                  case 10:
                    if (!flag)
                    {
                      num2 = 7;
                      num1 = num2;
                      continue;
                    }
                    num3 = contents.IndexOf("\r\n", startIndex1);
                    num4 = contents.IndexOf(",", startIndex1);
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 11:
                    try
                    {
                      contents = File.ReadAllText(this.eval_c);
                    }
                    catch (Exception ex)
                    {
                      return;
                    }
                    startIndex1 = contents.LastIndexOf(this.eval_a);
                    flag = startIndex1 >= 1;
                    break;
                  case 12:
                    if (!flag)
                    {
                      num2 = 8;
                      num1 = num2;
                      continue;
                    }
                    goto label_32;
                  case 13:
                    if (!flag)
                    {
                      num2 = 1;
                      num1 = num2;
                      continue;
                    }
                    contents = "";
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 14:
                    goto label_30;
                  case 15:
                    goto label_18;
                  case 16:
                    num5 = 1;
                    goto label_35;
                  default:
                    goto label_3;
                }
                num2 = 10;
                num1 = num2;
                continue;
label_13:
                flag = num3 < 0;
                num2 = 12;
                num1 = num2;
                continue;
label_35:
                flag = num5 != 0;
                num2 = 9;
                num1 = num2;
              }
label_18:
              return;
label_30:
              return;
label_32:
              return;
label_29:
              num2 = 0;
              if (num2 != 0)
                ;
              return;
          }
      }
    }

    private void eval_p(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !this.eval_g;
          num2 = 6;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
              case 4:
                this.eval_c();
                num2 = 7;
                num1 = num2;
                continue;
              case 1:
                num2 = 3;
                num1 = num2;
                continue;
              case 2:
                this.eval_b = "true";
                num2 = 0;
                num1 = num2;
                continue;
              case 3:
                goto label_19;
              case 5:
                if (flag)
                {
                  num2 = -9158;
                  int num3 = num2;
                  num2 = -9158;
                  int num4 = num2;
                  switch (num3 == num4 ? 1 : 0)
                  {
                    case 0:
                      goto label_15;
                    case 2:
                      goto label_12;
                    default:
                      num2 = 0;
                      if (num2 == 0)
                        ;
                      num2 = 0;
                      this.eval_b = "false";
                      num2 = 4;
                      num1 = num2;
                      continue;
                  }
                }
                else
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
              case 6:
                if (!flag)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                this.eval_a = "AutoGreet";
                flag = !this.eval_p.Checked;
                num2 = 5;
                num1 = num2;
                continue;
              case 7:
                goto label_14;
              default:
                goto label_2;
            }
          }
label_19:
          break;
label_15:
          break;
label_12:
          break;
label_14:
          num2 = 1;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_o(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag = !this.eval_g;
          num2 = 3;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_12;
              case 1:
                num2 = 2;
                num1 = num2;
                continue;
              case 2:
                goto label_11;
              case 3:
                if (!flag)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                this.eval_b();
                num2 = 2495;
                int num3 = num2;
                num2 = 2495;
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
                    num2 = 0;
                    num1 = num2;
                    continue;
                }
              default:
                goto label_2;
            }
          }
label_12:
          break;
label_11:
          num2 = 1;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_b()
    {
      int num1 = 0;
      num1 = 0;
      int num2 = num1;
      switch (num2)
      {
        default:
          bool flag;
          switch (0)
          {
            case 0:
label_3:
              this.eval_c = this.eval_f + "\\Settings\\Default\\Main.json";
              flag = File.Exists(this.eval_c);
              num1 = 30;
              num2 = num1;
              goto default;
            default:
              while (true)
              {
                int num3;
                int num4;
                int count;
                int startIndex1;
                int startIndex2;
                string contents;
                int num5;
                int num6;
                switch (num2)
                {
                  case 0:
                    int num7 = (int) MessageBox.Show("Parametr not exist\r\nMaybe structure Settings files was changed. Param not applayed", "Error!");
                    num1 = 16;
                    num2 = num1;
                    continue;
                  case 1:
                    int num8 = (int) MessageBox.Show("File not exist\r\nPlease grab the Settings at start", "Error!");
                    num1 = 22;
                    num2 = num1;
                    continue;
                  case 2:
                  case 5:
                    num1 = 24;
                    num2 = num1;
                    continue;
                  case 3:
                    try
                    {
                      contents = File.ReadAllText(this.eval_c);
                    }
                    catch (Exception ex)
                    {
                      return;
                    }
                    this.eval_a = "EnabledPlugins\": [";
                    startIndex2 = contents.LastIndexOf(this.eval_a);
                    flag = startIndex2 >= 1;
                    num1 = 39;
                    num2 = num1;
                    continue;
                  case 4:
                  case 41:
                    num1 = 2;
                    num2 = num1;
                    continue;
                  case 6:
                    num4 = 2 + contents.LastIndexOf("\r\n", startIndex1);
                    flag = num4 <= startIndex2;
                    num1 = 17;
                    num2 = num1;
                    continue;
                  case 7:
                    num1 = 28;
                    num2 = num1;
                    continue;
                  case 8:
                    count = num3 - num4 + 4;
                    num1 = 11;
                    num2 = num1;
                    continue;
                  case 9:
                    if (!flag)
                    {
                      num1 = 27;
                      num2 = num1;
                      continue;
                    }
                    flag = this.eval_o.Checked;
                    num1 = 33;
                    num2 = num1;
                    continue;
                  case 10:
                    if (!flag)
                    {
                      num1 = 40;
                      num2 = num1;
                      continue;
                    }
                    contents = contents.Insert(startIndex2, "\r\n    \"Quest\"\r\n");
                    File.WriteAllText(this.eval_c, contents);
                    num1 = 37;
                    num2 = num1;
                    continue;
                  case 11:
                    if (startIndex1 - startIndex2 <= 10)
                    {
                      num1 = 7;
                      num2 = num1;
                      continue;
                    }
                    num1 = 31;
                    num2 = num1;
                    continue;
                  case 12:
                    goto label_69;
                  case 13:
                    contents = contents.Remove(num4 - 2, count);
                    File.WriteAllText(this.eval_c, contents);
                    num1 = 35;
                    num2 = num1;
                    continue;
                  case 14:
                    num3 = contents.IndexOf("\r\n", startIndex1);
                    flag = num3 >= num5;
                    num1 = 26;
                    num2 = num1;
                    continue;
                  case 15:
                    num1 = 1;
                    if (num1 == 0)
                      ;
                    if (flag)
                    {
                      flag = !this.eval_g;
                      num1 = 9;
                      num2 = num1;
                      continue;
                    }
                    num1 = 32;
                    num2 = num1;
                    continue;
                  case 16:
                    goto label_65;
                  case 17:
                    if (!flag)
                    {
                      num1 = 14;
                      num2 = num1;
                      continue;
                    }
                    goto case 34;
                  case 18:
label_48:
                    num1 = 23;
                    num2 = num1;
                    continue;
                  case 19:
                    if (!flag)
                    {
                      num1 = 25;
                      num2 = num1;
                      continue;
                    }
                    contents = contents.Insert(startIndex2, "\r\n    \"Quest\",");
                    File.WriteAllText(this.eval_c, contents);
                    num1 = 12;
                    num2 = num1;
                    continue;
                  case 20:
                    flag = !this.eval_g;
                    num1 = 10;
                    num2 = num1;
                    continue;
                  case 21:
                    if (!flag)
                    {
                      num1 = 20;
                      num2 = num1;
                      continue;
                    }
                    startIndex1 = contents.IndexOf("\"Quest\"", startIndex2);
                    flag = startIndex1 >= 0;
                    num1 = 15;
                    num2 = num1;
                    continue;
                  case 22:
                    goto label_61;
                  case 23:
                    goto label_59;
                  case 24:
                    goto label_57;
                  case 25:
                    this.eval_o.Checked = false;
                    num1 = 36;
                    num2 = num1;
                    continue;
                  case 26:
                    if (!flag)
                    {
                      num1 = 8;
                      num2 = num1;
                      continue;
                    }
                    num1 = 34;
                    num2 = num1;
                    continue;
                  case 27:
                    this.eval_o.Checked = true;
                    num1 = 4;
                    num2 = num1;
                    continue;
                  case 28:
                    num6 = num5 - startIndex1 <= 17 ? 1 : 0;
                    break;
                  case 29:
                    count -= 2;
                    num1 = 13;
                    num2 = num1;
                    continue;
                  case 30:
                    if (!flag)
                    {
                      num1 = 1;
                      num2 = num1;
                      continue;
                    }
                    contents = "";
                    num1 = 3;
                    num2 = num1;
                    continue;
                  case 31:
                    num6 = 0;
                    break;
                  case 32:
                    flag = !this.eval_g;
                    num1 = 19;
                    num2 = num1;
                    continue;
                  case 33:
                    if (!flag)
                    {
                      num1 = 6;
                      num2 = num1;
                      continue;
                    }
                    goto case 4;
                  case 34:
                    num1 = 41;
                    num2 = num1;
                    continue;
                  case 35:
                    goto label_55;
                  case 36:
                    num1 = -7268;
                    int num9 = num1;
                    num1 = -7268;
                    int num10 = num1;
                    switch (num9 == num10 ? 1 : 0)
                    {
                      case 0:
                      case 2:
                        goto label_48;
                      default:
                        num1 = 0;
                        if (num1 == 0)
                          ;
                        num1 = 5;
                        num2 = num1;
                        continue;
                    }
                  case 37:
                    goto label_49;
                  case 38:
                    if (!flag)
                    {
                      num1 = 29;
                      num2 = num1;
                      continue;
                    }
                    goto case 13;
                  case 39:
                    if (flag)
                    {
                      startIndex2 += this.eval_a.Length;
                      num5 = contents.IndexOf("]", startIndex2);
                      flag = num5 - startIndex2 >= 3;
                      num1 = 21;
                      num2 = num1;
                      continue;
                    }
                    num1 = 0;
                    num2 = num1;
                    continue;
                  case 40:
                    this.eval_o.Checked = false;
                    num1 = 18;
                    num2 = num1;
                    continue;
                  default:
                    goto label_3;
                }
                flag = num6 != 0;
                num1 = 38;
                num2 = num1;
              }
label_57:
              return;
label_55:
              return;
label_49:
              return;
label_59:
              return;
label_69:
              return;
label_65:
              return;
label_61:
              return;
          }
      }
    }

    private void eval_n(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !this.eval_g;
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
                  num2 = 5;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                this.eval_a = "ArenaDontDraft";
                flag = !this.eval_q.Checked;
                num2 = 0;
                num2 = 7;
                num1 = num2;
                continue;
              case 1:
                this.eval_c();
                num2 = 4;
                num1 = num2;
                continue;
              case 2:
                num2 = 23865;
                int num3 = num2;
                num2 = 23865;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_6;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    this.eval_b = "true";
                    num2 = 1;
                    num1 = num2;
                    continue;
                }
              case 3:
label_6:
                num2 = 1;
                if (num2 == 0)
                  goto case 1;
                else
                  goto case 1;
              case 4:
                goto label_16;
              case 5:
                num2 = 6;
                num1 = num2;
                continue;
              case 6:
                goto label_10;
              case 7:
                if (flag)
                {
                  this.eval_b = "false";
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                num2 = 2;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_10:
          break;
label_16:
          break;
      }
    }

    private void eval_m(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag = !this.eval_g;
          num2 = 1;
          if (num2 == 0)
            ;
          num2 = 3;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
              case 4:
label_9:
                this.eval_c();
                num2 = 6;
                num1 = num2;
                continue;
              case 1:
                num2 = 2;
                num1 = num2;
                continue;
              case 2:
                goto label_16;
              case 3:
                if (!flag)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                this.eval_a = "ArenaDontOpenRewards";
                flag = !this.eval_r.Checked;
                num2 = 0;
                num2 = 7;
                num1 = num2;
                continue;
              case 5:
                num2 = 1310;
                int num3 = num2;
                num2 = 1310;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_9;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    this.eval_b = "true";
                    num2 = 0;
                    num1 = num2;
                    continue;
                }
              case 6:
                goto label_10;
              case 7:
                if (flag)
                {
                  this.eval_b = "false";
                  num2 = 4;
                  num1 = num2;
                  continue;
                }
                num2 = 5;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_10:
          break;
label_16:
          break;
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
          flag = !this.eval_g;
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
                  num2 = 4;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                this.eval_a = "AutoConcedeAfterConstructedWin";
                flag = !this.eval_s.Checked;
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 0;
                num2 = 7;
                num1 = num2;
                continue;
              case 1:
                goto label_16;
              case 2:
                num2 = 6194;
                int num3 = num2;
                num2 = 6194;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_8;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    this.eval_b = "true";
                    num2 = 6;
                    num1 = num2;
                    continue;
                }
              case 3:
                goto label_10;
              case 4:
                num2 = 1;
                num1 = num2;
                continue;
              case 5:
              case 6:
label_8:
                this.eval_c();
                num2 = 3;
                num1 = num2;
                continue;
              case 7:
                if (flag)
                {
                  this.eval_b = "false";
                  num2 = 5;
                  num1 = num2;
                  continue;
                }
                num2 = 2;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_10:
          break;
label_16:
          break;
      }
    }

    private void eval_k(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag1;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag1 = !this.eval_g;
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
                if (!flag1)
                {
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                num2 = -27309;
                int num3 = num2;
                num2 = -27309;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_10;
                  default:
                    num2 = 1;
                    if (num2 == 0)
                      ;
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                    this.eval_a = "GameMode";
                    this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_j, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                    {
                      int num5 = 12055;
                      int num6 = num5;
                      num5 = 12055;
                      int num7 = num5;
                      int num8;
                      bool flag2;
                      switch (num6 == num7 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          return flag2;
                        case 1:
                          num8 = 1;
                          if (num8 == 0)
                            ;
                          num8 = 0;
                          if (num8 == 0)
                            ;
                          flag2 = A_0_2.Value == this.eval_am.Text;
                          goto case 0;
                        default:
                          num8 = 0;
                          goto case 1;
                      }
                    })).Key.ToString();
                    this.eval_c();
                    num2 = 3;
                    num1 = num2;
                    continue;
                }
              case 2:
              case 3:
                goto label_10;
              default:
                goto label_2;
            }
          }
label_10:
          num2 = 0;
          break;
      }
    }

    private void eval_j(object A_0, EventArgs A_1)
    {
      int num1;
      bool flag1;
      int num2;
      switch (0)
      {
        case 0:
label_2:
          flag1 = !this.eval_g;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
              case 2:
                goto label_10;
              case 1:
                num2 = 1;
                if (num2 == 0)
                  ;
                if (!flag1)
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                num2 = 29462;
                int num3 = num2;
                num2 = 29462;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_10;
                  default:
                    num2 = 0;
                    if (num2 == 0)
                      ;
                    this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                    this.eval_a = "ConstructedMode";
                    this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_k, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                    {
                      int num5 = -26660;
                      int num6 = num5;
                      num5 = -26660;
                      int num7 = num5;
                      int num8;
                      bool flag2;
                      switch (num6 == num7 ? 1 : 0)
                      {
                        case 0:
                        case 2:
                          return flag2;
                        case 1:
                          num8 = 1;
                          if (num8 == 0)
                            ;
                          num8 = 0;
                          if (num8 == 0)
                            ;
                          flag2 = A_0_2.Value == this.eval_ak.Text;
                          goto case 0;
                        default:
                          num8 = 0;
                          goto case 1;
                      }
                    })).Key.ToString();
                    this.eval_c();
                    num2 = 0;
                    num1 = num2;
                    continue;
                }
              case 3:
                num2 = 2;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_10:
          num2 = 0;
          break;
      }
    }

    private void eval_i(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag1 = !this.eval_g;
          num2 = 3;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                num2 = -28562;
                int num3 = num2;
                num2 = -28562;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_5;
                  default:
                    goto label_9;
                }
              case 1:
                goto label_6;
              case 2:
label_5:
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 1;
                num1 = num2;
                continue;
              case 3:
                if (!flag1)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                this.eval_a = "ConstructedDeckType";
                this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_l, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                {
                  int num5 = 11540;
                  int num6 = num5;
                  num5 = 11540;
                  int num7 = num5;
                  int num8;
                  bool flag2;
                  switch (num6 == num7 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      num8 = 1;
                      if (num8 == 0)
                        ;
                      return flag2;
                    case 1:
                      num8 = 0;
                      if (num8 == 0)
                        ;
                      flag2 = A_0_2.Value == this.eval_aj.Text;
                      goto case 0;
                    default:
                      num8 = 0;
                      goto case 1;
                  }
                })).Key.ToString();
                this.eval_c();
                num2 = 0;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_6:
          break;
label_9:
          num2 = 0;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_h(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag1 = !this.eval_g;
          num2 = 3;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
label_5:
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 1;
                num1 = num2;
                continue;
              case 1:
                goto label_6;
              case 2:
                num2 = 7460;
                int num3 = num2;
                num2 = 7460;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_5;
                  default:
                    goto label_9;
                }
              case 3:
                if (!flag1)
                {
                  num2 = 0;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                this.eval_a = "ConstructedBasicDeck";
                this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_i, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                {
                  int num5 = -4286;
                  int num6 = num5;
                  num5 = -4286;
                  int num7 = num5;
                  int num8;
                  bool flag2;
                  switch (num6 == num7 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      return flag2;
                    case 1:
                      num8 = 1;
                      if (num8 == 0)
                        ;
                      num8 = 0;
                      if (num8 == 0)
                        ;
                      flag2 = A_0_2.Value == this.eval_ah.Text;
                      goto case 0;
                    default:
                      num8 = 0;
                      goto case 1;
                  }
                })).Key.ToString();
                this.eval_c();
                num2 = 2;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_6:
          break;
label_9:
          num2 = 0;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_g(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag = !this.eval_g;
          num2 = 1;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                num2 = -8739;
                int num3 = num2;
                num2 = -8739;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    goto label_8;
                }
              case 1:
                if (!flag)
                {
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultBot.json";
                this.eval_a = "ConstructedCustomDeck";
                this.eval_b = "\"" + this.eval_af.Text + "\"";
                this.eval_c();
                num2 = 0;
                num1 = num2;
                continue;
              case 2:
                goto label_5;
              case 3:
label_11:
                num2 = 2;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_5:
          break;
label_8:
          num2 = 0;
          if (num2 == 0)
            ;
          num2 = 1;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_f(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag1 = !this.eval_g;
          num2 = 2;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                goto label_5;
              case 1:
label_11:
                num2 = 0;
                num1 = num2;
                continue;
              case 2:
                if (!flag1)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultRoutine.json";
                this.eval_a = "ArenaPreferredClass1";
                this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_i, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                {
                  int num3 = -2511;
                  int num4 = num3;
                  num3 = -2511;
                  int num5 = num3;
                  int num6;
                  bool flag2;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      return flag2;
                    case 1:
                      num6 = 0;
                      if (num6 == 0)
                        ;
                      num6 = 1;
                      if (num6 == 0)
                        ;
                      flag2 = A_0_2.Value == this.eval_t.Text;
                      goto case 0;
                    default:
                      num6 = 0;
                      goto case 1;
                  }
                })).Key.ToString();
                this.eval_c();
                num2 = 3;
                num1 = num2;
                continue;
              case 3:
                num2 = -27032;
                int num7 = num2;
                num2 = -27032;
                int num8 = num2;
                switch (num7 == num8 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    goto label_8;
                }
              default:
                goto label_2;
            }
          }
label_5:
          break;
label_8:
          num2 = 1;
          if (num2 == 0)
            ;
          num2 = 0;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_e(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag1 = !this.eval_g;
          num2 = 1;
          if (num2 == 0)
            ;
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
                  num2 = 3;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultRoutine.json";
                this.eval_a = "ArenaPreferredClass2";
                this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_i, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                {
                  int num3 = 8945;
                  int num4 = num3;
                  num3 = 8945;
                  int num5 = num3;
                  int num6;
                  bool flag2;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      return flag2;
                    case 1:
                      num6 = 0;
                      if (num6 == 0)
                        ;
                      num6 = 1;
                      if (num6 == 0)
                        ;
                      flag2 = A_0_2.Value == this.eval_u.Text;
                      goto case 0;
                    default:
                      num6 = 0;
                      goto case 1;
                  }
                })).Key.ToString();
                this.eval_c();
                num2 = 1;
                num1 = num2;
                continue;
              case 1:
                num2 = 16202;
                int num7 = num2;
                num2 = 16202;
                int num8 = num2;
                switch (num7 == num8 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    goto label_9;
                }
              case 2:
                goto label_6;
              case 3:
label_11:
                num2 = 2;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_6:
          break;
label_9:
          num2 = 0;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_d(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag1 = !this.eval_g;
          num2 = 1;
          if (num2 == 0)
            ;
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
                num2 = 20714;
                int num3 = num2;
                num2 = 20714;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    goto label_9;
                }
              case 2:
label_11:
                num2 = 0;
                num1 = num2;
                continue;
              case 3:
                if (!flag1)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultRoutine.json";
                this.eval_a = "ArenaPreferredClass3";
                this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_i, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                {
                  int num5 = 10079;
                  int num6 = num5;
                  num5 = 10079;
                  int num7 = num5;
                  int num8;
                  bool flag2;
                  switch (num6 == num7 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      return flag2;
                    case 1:
                      num8 = 1;
                      if (num8 == 0)
                        ;
                      num8 = 0;
                      if (num8 == 0)
                        ;
                      flag2 = A_0_2.Value == this.eval_v.Text;
                      goto case 0;
                    default:
                      num8 = 0;
                      goto case 1;
                  }
                })).Key.ToString();
                this.eval_c();
                num2 = 1;
                num1 = num2;
                continue;
              default:
                goto label_2;
            }
          }
label_6:
          break;
label_9:
          num2 = 0;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_c(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag1 = !this.eval_g;
          num2 = 2;
          num1 = num2;
          goto default;
        default:
          while (true)
          {
            switch (num1)
            {
              case 0:
                num2 = 20050;
                int num3 = num2;
                num2 = 20050;
                int num4 = num2;
                switch (num3 == num4 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_10;
                  default:
                    goto label_8;
                }
              case 1:
label_10:
                num2 = 1;
                if (num2 == 0)
                  ;
                num2 = 3;
                num1 = num2;
                continue;
              case 2:
                if (!flag1)
                {
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultRoutine.json";
                this.eval_a = "ArenaPreferredClass4";
                this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_i, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                {
                  int num5 = -24183;
                  int num6 = num5;
                  num5 = -24183;
                  int num7 = num5;
                  int num8;
                  bool flag2;
                  switch (num6 == num7 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      num8 = 1;
                      if (num8 == 0)
                        ;
                      return flag2;
                    default:
                      num8 = 0;
                      num8 = 0;
                      if (num8 == 0)
                        ;
                      flag2 = A_0_2.Value == this.eval_w.Text;
                      goto case 0;
                  }
                })).Key.ToString();
                this.eval_c();
                num2 = 0;
                num1 = num2;
                continue;
              case 3:
                goto label_5;
              default:
                goto label_2;
            }
          }
label_5:
          break;
label_8:
          num2 = 0;
          if (num2 != 0)
            break;
          break;
      }
    }

    private void eval_b(object A_0, EventArgs A_1)
    {
      int num1;
      int num2;
      bool flag1;
      switch (0)
      {
        case 0:
label_2:
          num2 = 0;
          flag1 = !this.eval_g;
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
                this.eval_c = this.eval_f + "\\Settings\\Default\\DefaultRoutine.json";
                this.eval_a = "ArenaPreferredClass5";
                this.eval_b = Enumerable.FirstOrDefault<KeyValuePair<int, string>>((IEnumerable<KeyValuePair<int, string>>) this.eval_i, (Func<KeyValuePair<int, string>, bool>) (A_0_2 =>
                {
                  int num3 = 21071;
                  int num4 = num3;
                  num3 = 21071;
                  int num5 = num3;
                  bool flag2;
                  switch (num4 == num5 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      return flag2;
                    default:
                      int num6 = 0;
                      num6 = 1;
                      if (num6 == 0)
                        ;
                      num6 = 0;
                      if (num6 == 0)
                        ;
                      flag2 = A_0_2.Value == this.eval_x.Text;
                      goto case 0;
                  }
                })).Key.ToString();
                this.eval_c();
                num2 = 3;
                num1 = num2;
                continue;
              case 1:
                goto label_5;
              case 2:
label_11:
                num2 = 1;
                num1 = num2;
                continue;
              case 3:
                num2 = -26142;
                int num7 = num2;
                num2 = -26142;
                int num8 = num2;
                switch (num7 == num8 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_11;
                  default:
                    goto label_8;
                }
              default:
                goto label_2;
            }
          }
label_5:
          break;
label_8:
          num2 = 1;
          if (num2 == 0)
            ;
          num2 = 0;
          if (num2 != 0)
            break;
          break;
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
label_2:
          num2 = 29278;
          int num3 = num2;
          num2 = 29278;
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
              flag = MessageBox.Show("Reset these settings and capture new ones from the currently opened bot for " + this.eval_e + ".\r\n\r\nAre you sure?", "Grab settings", MessageBoxButtons.YesNo) == DialogResult.Yes;
              num2 = 4;
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
                num2 = 6;
                num1 = num2;
                continue;
              case 1:
                if (!flag)
                {
                  num2 = 2;
                  num1 = num2;
                  continue;
                }
                goto case 3;
              case 2:
                File.Create(this.eval_f + "\\ok.txt");
                num2 = 3;
                num1 = num2;
                continue;
              case 3:
                this.eval_q((object) null, EventArgs.Empty);
                num2 = 5;
                num1 = num2;
                continue;
              case 4:
                if (flag)
                {
                  settings_editor.CopyDirs(this.eval_d + "\\Settings", this.eval_f + "\\Settings", true);
                  flag = File.Exists(this.eval_f + "\\ok.txt");
                  num2 = 1;
                  num1 = num2;
                  continue;
                }
                goto label_7;
              case 5:
                goto label_15;
              case 6:
                goto label_13;
              default:
                goto label_2;
            }
          }
label_13:
          return;
label_15:
          return;
      }
label_7:
      num2 = 0;
      num2 = 0;
      num1 = num2;
      goto default;
    }

    public static void CopyDirs(string sorseRoot, string destRoot, bool overwrite)
    {
      int num1 = 0;
      switch (num1)
      {
        default:
          string[] strArray;
          int index;
          int num2;
          switch (0)
          {
            case 0:
label_3:
              strArray = Directory.GetDirectories(sorseRoot, "*.*", SearchOption.TopDirectoryOnly);
              index = 0;
              num2 = 17;
              num1 = num2;
              goto default;
            default:
              string str1;
              string str2;
              bool flag;
              while (true)
              {
                switch (num1)
                {
                  case 0:
                  case 13:
                    num2 = 11;
                    num1 = num2;
                    continue;
                  case 1:
                    if (!flag)
                    {
                      num2 = 10;
                      num1 = num2;
                      continue;
                    }
                    str1 = strArray[index];
                    string fileName1 = Path.GetFileName(str1);
                    str2 = Path.Combine(destRoot, fileName1);
                    flag = !File.Exists(str2);
                    num2 = 9;
                    num1 = num2;
                    continue;
                  case 2:
                    switch (flag)
                    {
                      case false:
                        flag = !(new FileInfo(str1).LastWriteTimeUtc > new FileInfo(str2).LastWriteTimeUtc);
                        num2 = 8;
                        num1 = num2;
                        continue;
                      case true:
                        num2 = -8550;
                        int num3 = num2;
                        num2 = -8550;
                        int num4 = num2;
                        switch (num3 == num4 ? 1 : 0)
                        {
                          case 0:
                          case 2:
                            goto label_27;
                          default:
                            num2 = 0;
                            if (num2 == 0)
                              ;
                            File.Copy(str1, str2, true);
                            num2 = 0;
                            num1 = num2;
                            continue;
                        }
                      default:
                        num2 = 5;
                        num1 = num2;
                        continue;
                    }
                  case 3:
                    num2 = 1;
                    if (num2 == 0)
                      goto case 0;
                    else
                      goto case 0;
                  case 4:
                    flag = index < strArray.Length;
                    num2 = 1;
                    num1 = num2;
                    continue;
                  case 5:
                    num2 = 13;
                    num1 = num2;
                    continue;
                  case 6:
label_27:
                    flag = overwrite;
                    num2 = 2;
                    num1 = num2;
                    continue;
                  case 7:
                    if (!flag)
                    {
                      num2 = 12;
                      num1 = num2;
                      continue;
                    }
                    string fileName2 = Path.GetFileName(strArray[index]);
                    string str3 = Path.Combine(destRoot, fileName2);
                    Directory.CreateDirectory(str3);
                    settings_editor.CopyDirs(Path.Combine(sorseRoot, fileName2), str3, overwrite);
                    ++index;
                    num2 = 18;
                    num1 = num2;
                    continue;
                  case 8:
                    if (!flag)
                    {
                      num2 = 14;
                      num1 = num2;
                      continue;
                    }
                    goto case 19;
                  case 9:
                    if (flag)
                    {
                      File.Copy(str1, str2, true);
                      num2 = 15;
                      num1 = num2;
                      continue;
                    }
                    num2 = 6;
                    num1 = num2;
                    continue;
                  case 10:
                    goto label_32;
                  case 11:
                  case 15:
                    ++index;
                    num2 = 16;
                    num1 = num2;
                    continue;
                  case 12:
                    strArray = Directory.GetFiles(sorseRoot);
                    index = 0;
                    num2 = 4;
                    num1 = num2;
                    continue;
                  case 14:
                    File.Copy(str1, str2, true);
                    num2 = 19;
                    num1 = num2;
                    continue;
                  case 16:
                    num2 = 0;
                    goto case 4;
                  case 17:
                  case 18:
                    flag = index < strArray.Length;
                    num2 = 7;
                    num1 = num2;
                    continue;
                  case 19:
                    num2 = 3;
                    num1 = num2;
                    continue;
                  default:
                    goto label_3;
                }
              }
label_32:
              return;
          }
      }
    }

    private void eval_a(bool A_0)
    {
      int num1 = 29848;
      int num2 = num1;
      num1 = 29848;
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
          this.eval_z.Enabled = !A_0;
          this.eval_ad.Enabled = !A_0;
          this.eval_au.Enabled = !A_0;
          this.eval_ap.Enabled = !A_0;
          this.eval_h = A_0;
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
label_3:
          num1 = 0;
          num1 = 5;
          num2 = num1;
          goto default;
        default:
          while (true)
          {
            num1 = 1;
            if (num1 == 0)
              ;
            bool flag;
            int num3;
            switch (num2)
            {
              case 0:
                num1 = 6;
                num2 = num1;
                continue;
              case 1:
                if (!flag)
                {
                  num1 = 2;
                  num2 = num1;
                  continue;
                }
                goto label_16;
              case 2:
                num1 = -24811;
                int num4 = num1;
                num1 = -24811;
                int num5 = num1;
                switch (num4 == num5 ? 1 : 0)
                {
                  case 0:
                  case 2:
                    goto label_3;
                  default:
                    num1 = 0;
                    if (num1 == 0)
                      ;
                    this.eval_n.Dispose();
                    num1 = 4;
                    num2 = num1;
                    continue;
                }
              case 3:
                num3 = 1;
                break;
              case 4:
                goto label_16;
              case 5:
                if (disposing)
                {
                  num1 = 0;
                  num2 = num1;
                  continue;
                }
                num1 = 3;
                num2 = num1;
                continue;
              case 6:
                num3 = this.eval_n == null ? 1 : 0;
                break;
              default:
                goto label_3;
            }
            flag = num3 != 0;
            num1 = 1;
            num2 = num1;
          }
label_16:
          base.Dispose(disposing);
          break;
      }
    }

    private void eval_a()
    {
      int num1 = 10196;
      int num2 = num1;
      num1 = 10196;
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
          this.eval_n = (IContainer) new Container();
          ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (settings_editor));
          this.eval_o = new CheckBox();
          this.eval_p = new CheckBox();
          this.eval_q = new CheckBox();
          this.eval_r = new CheckBox();
          this.eval_s = new CheckBox();
          this.eval_t = new ComboBox();
          this.eval_u = new ComboBox();
          this.eval_v = new ComboBox();
          this.eval_w = new ComboBox();
          this.eval_x = new ComboBox();
          this.eval_y = new Label();
          this.eval_z = new GroupBox();
          this.ao = new Label();
          this.aa = new Label();
          this.ab = new Label();
          this.ac = new Label();
          this.eval_ad = new GroupBox();
          this.ae = new Label();
          this.eval_af = new ComboBox();
          this.ag = new Label();
          this.eval_ah = new ComboBox();
          this.ai = new Label();
          this.eval_aj = new ComboBox();
          this.eval_ak = new ComboBox();
          this.eval_al = new Label();
          this.eval_am = new ComboBox();
          this.an = new Label();
          this.eval_ap = new GroupBox();
          this.eval_aq = new CheckBox();
          this.eval_ar = new CheckBox();
          this.eval_as = new Button();
          this.eval_at = new ToolTip(this.eval_n);
          this.eval_au = new GroupBox();
          this.eval_av = new Button();
          this.eval_z.SuspendLayout();
          this.eval_ad.SuspendLayout();
          this.eval_ap.SuspendLayout();
          this.eval_au.SuspendLayout();
          this.SuspendLayout();
          this.eval_o.AutoSize = true;
          this.eval_o.ForeColor = Color.White;
          this.eval_o.Location = new Point(6, 15);
          this.eval_o.Name = "chb_EnableQuest";
          this.eval_o.Size = new Size(122, 17);
          this.eval_o.TabIndex = 0;
          this.eval_o.Text = "Enable Quest Plugin";
          this.eval_o.UseVisualStyleBackColor = true;
          this.eval_o.CheckedChanged += new EventHandler(this.eval_o);
          this.eval_p.AutoSize = true;
          this.eval_p.ForeColor = Color.White;
          this.eval_p.Location = new Point(8, 36);
          this.eval_p.Name = "chb_AutoGreet";
          this.eval_p.Size = new Size(132, 17);
          this.eval_p.TabIndex = 1;
          this.eval_p.Text = "Auto-Greet Opponents";
          this.eval_p.UseVisualStyleBackColor = true;
          this.eval_p.CheckedChanged += new EventHandler(this.eval_p);
          this.eval_q.AutoSize = true;
          this.eval_q.ForeColor = Color.White;
          this.eval_q.Location = new Point(6, 15);
          this.eval_q.Name = "chb_DontDraftArena";
          this.eval_q.Size = new Size(108, 17);
          this.eval_q.TabIndex = 2;
          this.eval_q.Text = "Don't Draft Arena";
          this.eval_q.UseVisualStyleBackColor = true;
          this.eval_q.CheckedChanged += new EventHandler(this.eval_n);
          this.eval_r.AutoSize = true;
          this.eval_r.ForeColor = Color.White;
          this.eval_r.Location = new Point(6, 32);
          this.eval_r.Name = "chb_DontOpenRewards";
          this.eval_r.Size = new Size(125, 17);
          this.eval_r.TabIndex = 3;
          this.eval_r.Text = "Don't Open Rewards";
          this.eval_r.UseVisualStyleBackColor = true;
          this.eval_r.CheckedChanged += new EventHandler(this.eval_m);
          this.eval_s.AutoSize = true;
          this.eval_s.ForeColor = Color.White;
          this.eval_s.Location = new Point(6, 98);
          this.eval_s.Name = "chb_KeepRunk";
          this.eval_s.Size = new Size(171, 17);
          this.eval_s.TabIndex = 4;
          this.eval_s.Text = "Keep Constructed Runk/MMR";
          this.eval_s.UseVisualStyleBackColor = true;
          this.eval_s.CheckedChanged += new EventHandler(this.eval_l);
          this.eval_t.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_t.FlatStyle = FlatStyle.Popup;
          this.eval_t.ForeColor = Color.White;
          this.eval_t.FormattingEnabled = true;
          this.eval_t.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_t.Location = new Point(92, 55);
          this.eval_t.Name = "cb_PerfClass1";
          this.eval_t.Size = new Size(81, 21);
          this.eval_t.TabIndex = 10;
          this.eval_t.Text = "WARLOCK";
          this.eval_t.SelectedIndexChanged += new EventHandler(this.eval_f);
          this.eval_u.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_u.FlatStyle = FlatStyle.Popup;
          this.eval_u.ForeColor = Color.White;
          this.eval_u.FormattingEnabled = true;
          this.eval_u.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_u.Location = new Point(92, 75);
          this.eval_u.Name = "cb_PerfClass2";
          this.eval_u.Size = new Size(81, 21);
          this.eval_u.TabIndex = 11;
          this.eval_u.Text = "PALADIN";
          this.eval_u.SelectedIndexChanged += new EventHandler(this.eval_e);
          this.eval_v.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_v.FlatStyle = FlatStyle.Popup;
          this.eval_v.ForeColor = Color.White;
          this.eval_v.FormattingEnabled = true;
          this.eval_v.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_v.Location = new Point(92, 95);
          this.eval_v.Name = "cb_PerfClass3";
          this.eval_v.Size = new Size(81, 21);
          this.eval_v.TabIndex = 12;
          this.eval_v.Text = "PALADIN";
          this.eval_v.SelectedIndexChanged += new EventHandler(this.eval_d);
          this.eval_w.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_w.FlatStyle = FlatStyle.Popup;
          this.eval_w.ForeColor = Color.White;
          this.eval_w.FormattingEnabled = true;
          this.eval_w.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_w.Location = new Point(92, 115);
          this.eval_w.Name = "cb_PerfClass4";
          this.eval_w.Size = new Size(81, 21);
          this.eval_w.TabIndex = 13;
          this.eval_w.Text = "PALADIN";
          this.eval_w.SelectedIndexChanged += new EventHandler(this.eval_c);
          this.eval_x.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_x.FlatStyle = FlatStyle.Popup;
          this.eval_x.ForeColor = Color.White;
          this.eval_x.FormattingEnabled = true;
          this.eval_x.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_x.Location = new Point(92, 135);
          this.eval_x.Name = "cb_PerfClass5";
          this.eval_x.Size = new Size(81, 21);
          this.eval_x.TabIndex = 14;
          this.eval_x.Text = "PALADIN";
          this.eval_x.SelectedIndexChanged += new EventHandler(this.eval_b);
          this.eval_y.AutoSize = true;
          this.eval_y.ForeColor = Color.White;
          this.eval_y.Location = new Point(5, 58);
          this.eval_y.Name = "label1";
          this.eval_y.Size = new Size(84, 13);
          this.eval_y.TabIndex = 15;
          this.eval_y.Text = "PreferredClass1:";
          this.eval_z.Controls.Add((Control) this.ao);
          this.eval_z.Controls.Add((Control) this.eval_x);
          this.eval_z.Controls.Add((Control) this.aa);
          this.eval_z.Controls.Add((Control) this.eval_w);
          this.eval_z.Controls.Add((Control) this.ab);
          this.eval_z.Controls.Add((Control) this.eval_v);
          this.eval_z.Controls.Add((Control) this.ac);
          this.eval_z.Controls.Add((Control) this.eval_u);
          this.eval_z.Controls.Add((Control) this.eval_t);
          this.eval_z.Controls.Add((Control) this.eval_y);
          this.eval_z.Controls.Add((Control) this.eval_r);
          this.eval_z.Controls.Add((Control) this.eval_q);
          this.eval_z.Enabled = false;
          this.eval_z.ForeColor = Color.Orange;
          this.eval_z.Location = new Point(6, 64);
          this.eval_z.Name = "gb_Arena";
          this.eval_z.Size = new Size(179, 162);
          this.eval_z.TabIndex = 16;
          this.eval_z.TabStop = false;
          this.eval_z.Text = "Arena";
          this.ao.AutoSize = true;
          this.ao.ForeColor = Color.White;
          this.ao.Location = new Point(5, 138);
          this.ao.Name = "label5";
          this.ao.Size = new Size(84, 13);
          this.ao.TabIndex = 19;
          this.ao.Text = "PreferredClass5:";
          this.aa.AutoSize = true;
          this.aa.ForeColor = Color.White;
          this.aa.Location = new Point(5, 118);
          this.aa.Name = "label4";
          this.aa.Size = new Size(84, 13);
          this.aa.TabIndex = 18;
          this.aa.Text = "PreferredClass4:";
          this.ab.AutoSize = true;
          this.ab.ForeColor = Color.White;
          this.ab.Location = new Point(5, 98);
          this.ab.Name = "label3";
          this.ab.Size = new Size(84, 13);
          this.ab.TabIndex = 17;
          this.ab.Text = "PreferredClass3:";
          this.ac.AutoSize = true;
          this.ac.ForeColor = Color.White;
          this.ac.Location = new Point(5, 78);
          this.ac.Name = "label2";
          this.ac.Size = new Size(84, 13);
          this.ac.TabIndex = 16;
          this.ac.Text = "PreferredClass2:";
          this.eval_ad.Controls.Add((Control) this.ae);
          this.eval_ad.Controls.Add((Control) this.eval_af);
          this.eval_ad.Controls.Add((Control) this.ag);
          this.eval_ad.Controls.Add((Control) this.eval_ah);
          this.eval_ad.Controls.Add((Control) this.ai);
          this.eval_ad.Controls.Add((Control) this.eval_aj);
          this.eval_ad.Controls.Add((Control) this.eval_ak);
          this.eval_ad.Controls.Add((Control) this.eval_s);
          this.eval_ad.Controls.Add((Control) this.eval_al);
          this.eval_ad.ForeColor = Color.Orange;
          this.eval_ad.Location = new Point(191, 7);
          this.eval_ad.Name = "gb_Constructed";
          this.eval_ad.Size = new Size(179, 118);
          this.eval_ad.TabIndex = 17;
          this.eval_ad.TabStop = false;
          this.eval_ad.Text = "Constructed";
          this.ae.AutoSize = true;
          this.ae.ForeColor = Color.White;
          this.ae.Location = new Point(5, 76);
          this.ae.Name = "label7";
          this.ae.Size = new Size(71, 13);
          this.ae.TabIndex = 18;
          this.ae.Text = "Custom Deck";
          this.eval_af.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_af.FlatStyle = FlatStyle.Popup;
          this.eval_af.ForeColor = Color.White;
          this.eval_af.FormattingEnabled = true;
          this.eval_af.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_af.Location = new Point(76, 73);
          this.eval_af.Name = "cb_CustomDeckC";
          this.eval_af.Size = new Size(97, 21);
          this.eval_af.TabIndex = 13;
          this.eval_af.Text = "settings_editor";
          this.eval_af.SelectedIndexChanged += new EventHandler(this.eval_g);
          this.ag.AutoSize = true;
          this.ag.ForeColor = Color.White;
          this.ag.Location = new Point(5, 56);
          this.ag.Name = "label8";
          this.ag.Size = new Size(62, 13);
          this.ag.TabIndex = 17;
          this.ag.Text = "Basic Deck";
          this.eval_ah.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_ah.FlatStyle = FlatStyle.Popup;
          this.eval_ah.ForeColor = Color.White;
          this.eval_ah.FormattingEnabled = true;
          this.eval_ah.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_ah.Location = new Point(76, 53);
          this.eval_ah.Name = "cb_BasicDeckC";
          this.eval_ah.Size = new Size(97, 21);
          this.eval_ah.TabIndex = 12;
          this.eval_ah.Text = "PALADIN";
          this.eval_ah.SelectedIndexChanged += new EventHandler(this.eval_h);
          this.ai.AutoSize = true;
          this.ai.ForeColor = Color.White;
          this.ai.Location = new Point(5, 36);
          this.ai.Name = "label9";
          this.ai.Size = new Size(60, 13);
          this.ai.TabIndex = 16;
          this.ai.Text = "Deck Type";
          this.eval_aj.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_aj.FlatStyle = FlatStyle.Popup;
          this.eval_aj.ForeColor = Color.White;
          this.eval_aj.FormattingEnabled = true;
          this.eval_aj.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_aj.Location = new Point(76, 33);
          this.eval_aj.Name = "cb_DeckTypeC";
          this.eval_aj.Size = new Size(97, 21);
          this.eval_aj.TabIndex = 11;
          this.eval_aj.Text = "Custom";
          this.eval_aj.SelectedIndexChanged += new EventHandler(this.eval_i);
          this.eval_ak.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_ak.FlatStyle = FlatStyle.Popup;
          this.eval_ak.ForeColor = Color.White;
          this.eval_ak.FormattingEnabled = true;
          this.eval_ak.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_ak.Location = new Point(76, 13);
          this.eval_ak.Name = "cb_ModeC";
          this.eval_ak.Size = new Size(97, 21);
          this.eval_ak.TabIndex = 10;
          this.eval_ak.Text = "Ranked";
          this.eval_ak.SelectedIndexChanged += new EventHandler(this.eval_j);
          this.eval_al.AutoSize = true;
          this.eval_al.ForeColor = Color.White;
          this.eval_al.Location = new Point(5, 16);
          this.eval_al.Name = "label10";
          this.eval_al.Size = new Size(34, 13);
          this.eval_al.TabIndex = 15;
          this.eval_al.Text = "Mode";
          this.eval_am.BackColor = Color.FromArgb(49, 49, 49);
          this.eval_am.FlatStyle = FlatStyle.Popup;
          this.eval_am.ForeColor = Color.White;
          this.eval_am.FormattingEnabled = true;
          this.eval_am.Items.AddRange(new object[5]
          {
            (object) "1",
            (object) "2",
            (object) "3",
            (object) "4",
            (object) "5"
          });
          this.eval_am.Location = new Point(76, 12);
          this.eval_am.Name = "cb_GameMode";
          this.eval_am.Size = new Size(97, 21);
          this.eval_am.TabIndex = 18;
          this.eval_am.Text = "Constructed";
          this.eval_am.SelectedIndexChanged += new EventHandler(this.eval_k);
          this.an.AutoSize = true;
          this.an.ForeColor = Color.White;
          this.an.Location = new Point(5, 15);
          this.an.Name = "label6";
          this.an.Size = new Size(65, 13);
          this.an.TabIndex = 19;
          this.an.Text = "Game Mode";
          this.eval_ap.Controls.Add((Control) this.eval_aq);
          this.eval_ap.Controls.Add((Control) this.eval_ar);
          this.eval_ap.Controls.Add((Control) this.eval_o);
          this.eval_ap.ForeColor = Color.Orange;
          this.eval_ap.Location = new Point(191, 126);
          this.eval_ap.Name = "gb_Quest";
          this.eval_ap.Size = new Size(179, 69);
          this.eval_ap.TabIndex = 20;
          this.eval_ap.TabStop = false;
          this.eval_ap.Text = "Quest";
          this.eval_aq.AutoSize = true;
          this.eval_aq.ForeColor = Color.White;
          this.eval_aq.Location = new Point(6, 49);
          this.eval_aq.Name = "chb_OnlyUseCustomDecks";
          this.eval_aq.Size = new Size(141, 17);
          this.eval_aq.TabIndex = 2;
          this.eval_aq.Text = "Only Use Custom Decks";
          this.eval_aq.UseVisualStyleBackColor = true;
          this.eval_ar.AutoSize = true;
          this.eval_ar.ForeColor = Color.White;
          this.eval_ar.Location = new Point(6, 32);
          this.eval_ar.Name = "chb_StopAfterAllQuestsAreDone";
          this.eval_ar.Size = new Size(171, 17);
          this.eval_ar.TabIndex = 1;
          this.eval_ar.Text = "Stop After All Quests Are Done";
          this.eval_ar.UseVisualStyleBackColor = true;
          this.eval_as.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_as.FlatStyle = FlatStyle.Flat;
          this.eval_as.Font = new Font("Arial", 7f, FontStyle.Bold, GraphicsUnit.Point, (byte) 204);
          this.eval_as.ForeColor = Color.Orange;
          this.eval_as.Location = new Point(329, 201);
          this.eval_as.Name = "btn_grab";
          this.eval_as.Size = new Size(41, 23);
          this.eval_as.TabIndex = 21;
          this.eval_as.Text = "Grab";
          this.eval_at.SetToolTip((Control) this.eval_as, "Reset these settings and capture new ones from the currently opened bot");
          this.eval_as.UseVisualStyleBackColor = true;
          this.eval_as.Click += new EventHandler(this.eval_a);
          this.eval_au.Controls.Add((Control) this.eval_am);
          this.eval_au.Controls.Add((Control) this.an);
          this.eval_au.Controls.Add((Control) this.eval_p);
          this.eval_au.ForeColor = Color.Orange;
          this.eval_au.Location = new Point(6, 7);
          this.eval_au.Name = "gb_Game";
          this.eval_au.Size = new Size(179, 55);
          this.eval_au.TabIndex = 22;
          this.eval_au.TabStop = false;
          this.eval_au.Text = "Game";
          this.eval_av.DialogResult = DialogResult.OK;
          this.eval_av.FlatAppearance.BorderColor = Color.DimGray;
          this.eval_av.FlatStyle = FlatStyle.Flat;
          this.eval_av.ForeColor = Color.White;
          this.eval_av.Location = new Point(191, 200);
          this.eval_av.Name = "btn_PassSave";
          this.eval_av.Size = new Size(117, 23);
          this.eval_av.TabIndex = 23;
          this.eval_av.Text = "Close";
          this.eval_av.UseVisualStyleBackColor = true;
          this.AutoScaleDimensions = new SizeF(6f, 13f);
          this.AutoScaleMode = AutoScaleMode.Font;
          this.BackColor = Color.FromArgb(49, 49, 49);
          this.ClientSize = new Size(376, 229);
          this.Controls.Add((Control) this.eval_av);
          this.Controls.Add((Control) this.eval_au);
          this.Controls.Add((Control) this.eval_as);
          this.Controls.Add((Control) this.eval_ap);
          this.Controls.Add((Control) this.eval_ad);
          this.Controls.Add((Control) this.eval_z);
          this.FormBorderStyle = FormBorderStyle.FixedSingle;
          this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
          this.Name = "settings_editor";
          this.Text = "HB Settings Editor";
          this.Load += new EventHandler(this.eval_q);
          this.eval_z.ResumeLayout(false);
          this.eval_z.PerformLayout();
          this.eval_ad.ResumeLayout(false);
          this.eval_ad.PerformLayout();
          this.eval_ap.ResumeLayout(false);
          this.eval_ap.PerformLayout();
          this.eval_au.ResumeLayout(false);
          this.eval_au.PerformLayout();
          this.ResumeLayout(false);
          break;
        default:
          num4 = 0;
          goto case 1;
      }
    }
  }
}
