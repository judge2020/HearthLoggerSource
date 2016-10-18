// Decompiled with JetBrains decompiler
// Type: eval_d
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

internal struct eval_d
{
  public string a;
  public string b;
  public string eval_c;
  public int d;
  public int eval_e;
  public string f;
  public int g;
  public int eval_h;
  public string eval_i;

  public eval_d(string[] A_0)
  {
    this.a = A_0[0];
    this.b = A_0[1];
    this.eval_c = A_0[2];
    this.d = int.Parse(A_0[3]);
    this.eval_e = int.Parse(A_0[4]);
    this.f = A_0[5];
    this.g = 0;
    this.eval_h = 0;
    this.eval_i = "";
    if (A_0.Length < 7)
      return;
    this.eval_i = A_0[6];
  }
}
