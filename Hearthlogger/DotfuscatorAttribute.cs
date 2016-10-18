// Decompiled with JetBrains decompiler
// Type: DotfuscatorAttribute
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.Runtime.InteropServices;

[AttributeUsage(AttributeTargets.Assembly)]
[ComVisible(false)]
public sealed class DotfuscatorAttribute : Attribute
{
  private string a;
  private bool b;
  private int c;

  public string A
  {
    get
    {
      return this.a;
    }
  }

  public bool B
  {
    get
    {
      return this.b;
    }
  }

  public int C
  {
    get
    {
      return this.c;
    }
  }

  public DotfuscatorAttribute(string a, int c, bool b)
  {
    DotfuscatorAttribute dotfuscatorAttribute = this;
    // ISSUE: explicit constructor call
    dotfuscatorAttribute.\u002Ector();
    string str = a;
    dotfuscatorAttribute.a = str;
    this.c = c;
    this.b = b;
  }

  public string a()
  {
    return this.a;
  }

  public bool b()
  {
    return this.b;
  }

  public int c()
  {
    return this.c;
  }
}
