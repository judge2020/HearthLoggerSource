// Decompiled with JetBrains decompiler
// Type: eval_a
// Assembly: Hearthlogger, Version=2.0.4.32, Culture=neutral, PublicKeyToken=null
// MVID: 8E68E8A1-1A61-468F-93FB-7A5468F27BAB
// Assembly location: C:\Users\hunte\Downloads\hearthLoggerDubug\Hearthlogger.exe

using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

internal class eval_a
{
  private static readonly byte[] a;
  [NonSerialized]
  private string eval_b;

  static eval_a()
  {
    int num1 = -6331;
    int num2 = num1;
    num1 = -6331;
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
        eval_a.a = Encoding.ASCII.GetBytes("o1806442kbM7ow");
        break;
      default:
        num4 = 0;
        goto case 1;
    }
  }

  public static string eval_b(string A_0, string A_1)
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
            flag = !string.IsNullOrEmpty(A_0);
            num2 = 4;
            num1 = num2;
            goto default;
          default:
            string str1;
            while (true)
            {
              RijndaelManaged rijndaelManaged;
              string str2;
              switch (num1)
              {
                case 0:
                  goto label_49;
                case 1:
                  num2 = 1;
                  if (num2 == 0)
                    ;
                  num2 = 5539;
                  int num3 = num2;
                  num2 = 5539;
                  int num4 = num2;
                  switch (num3 == num4 ? 1 : 0)
                  {
                    case 0:
                    case 2:
                      break;
                    default:
                      goto label_8;
                  }
                case 2:
                  try
                  {
                    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(A_1, eval_a.a);
                    rijndaelManaged = new RijndaelManaged();
                    rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
                    ICryptoTransform encryptor = rijndaelManaged.CreateEncryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                    MemoryStream memoryStream = new MemoryStream();
                    try
                    {
                      memoryStream.Write(BitConverter.GetBytes(rijndaelManaged.IV.Length), 0, 4);
                      memoryStream.Write(rijndaelManaged.IV, 0, rijndaelManaged.IV.Length);
                      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, encryptor, CryptoStreamMode.Write);
                      try
                      {
                        StreamWriter streamWriter = new StreamWriter((Stream) cryptoStream);
                        try
                        {
                          streamWriter.Write(A_0);
                        }
                        finally
                        {
                          int num5;
                          switch (0)
                          {
                            case 0:
label_15:
                              flag = streamWriter == null;
                              num5 = 2;
                              num1 = num5;
                              goto default;
                            default:
                              while (true)
                              {
                                switch (num1)
                                {
                                  case 0:
                                    goto label_19;
                                  case 1:
                                    streamWriter.Dispose();
                                    num5 = 0;
                                    num1 = num5;
                                    continue;
                                  case 2:
                                    if (!flag)
                                    {
                                      num5 = 1;
                                      num1 = num5;
                                      continue;
                                    }
                                    goto label_19;
                                  default:
                                    goto label_15;
                                }
                              }
label_19:;
                          }
                        }
                      }
                      finally
                      {
                        int num5;
                        switch (0)
                        {
                          case 0:
label_22:
                            flag = cryptoStream == null;
                            num5 = 2;
                            num1 = num5;
                            goto default;
                          default:
                            while (true)
                            {
                              switch (num1)
                              {
                                case 0:
                                  cryptoStream.Dispose();
                                  num5 = 1;
                                  num1 = num5;
                                  continue;
                                case 1:
                                  goto label_26;
                                case 2:
                                  if (!flag)
                                  {
                                    num5 = 0;
                                    num1 = num5;
                                    continue;
                                  }
                                  goto label_26;
                                default:
                                  goto label_22;
                              }
                            }
label_26:;
                        }
                      }
                      str2 = Convert.ToBase64String(memoryStream.ToArray());
                      break;
                    }
                    finally
                    {
                      int num5;
                      switch (0)
                      {
                        case 0:
label_30:
                          flag = memoryStream == null;
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
                                goto label_34;
                              case 1:
                                memoryStream.Dispose();
                                num5 = 2;
                                num1 = num5;
                                continue;
                              case 2:
                                goto label_34;
                              default:
                                goto label_30;
                            }
                          }
label_34:;
                      }
                    }
                  }
                  finally
                  {
                    switch (0)
                    {
                      case 0:
label_37:
                        flag = rijndaelManaged == null;
                        num1 = 1;
                        goto default;
                      default:
                        while (true)
                        {
                          switch (num1)
                          {
                            case 0:
                              goto label_41;
                            case 1:
                              if (!flag)
                              {
                                num1 = 2;
                                continue;
                              }
                              goto label_41;
                            case 2:
                              rijndaelManaged.Clear();
                              num1 = 0;
                              continue;
                            default:
                              goto label_37;
                          }
                        }
label_41:;
                    }
                  }
                case 3:
                  if (flag)
                  {
                    num2 = 0;
                    str2 = (string) null;
                    rijndaelManaged = (RijndaelManaged) null;
                    num2 = 2;
                    num1 = num2;
                    continue;
                  }
                  num2 = 5;
                  num1 = num2;
                  continue;
                case 4:
                  if (!flag)
                  {
                    num2 = 1;
                    num1 = num2;
                    continue;
                  }
                  flag = !string.IsNullOrEmpty(A_1);
                  num2 = 3;
                  num1 = num2;
                  continue;
                case 5:
                  goto label_48;
                default:
                  goto label_3;
              }
              str1 = str2;
              num2 = 0;
              num1 = num2;
            }
label_8:
            num2 = 0;
            if (num2 == 0)
              ;
            throw new ArgumentNullException("plainText");
label_48:
            throw new ArgumentNullException("sharedSecret");
label_49:
            return str1;
        }
    }
  }

  public static string eval_a(string A_0, string A_1)
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
            flag = !string.IsNullOrEmpty(A_0);
            num2 = 3;
            num1 = num2;
            goto default;
          default:
            RijndaelManaged rijndaelManaged;
            string str1;
            string str2;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  if (flag)
                  {
                    rijndaelManaged = (RijndaelManaged) null;
                    str1 = (string) null;
                    num2 = 4;
                    num1 = num2;
                    continue;
                  }
                  num2 = 5;
                  num1 = num2;
                  continue;
                case 1:
                  goto label_6;
                case 2:
                  goto label_48;
                case 3:
                  if (!flag)
                  {
                    num2 = 1;
                    num1 = num2;
                    continue;
                  }
                  num2 = 0;
                  flag = !string.IsNullOrEmpty(A_1);
                  num2 = 0;
                  num1 = num2;
                  continue;
                case 4:
                  try
                  {
                    Rfc2898DeriveBytes rfc2898DeriveBytes = new Rfc2898DeriveBytes(A_1, eval_a.a);
                    MemoryStream memoryStream = new MemoryStream(Convert.FromBase64String(A_0));
                    try
                    {
                      rijndaelManaged = new RijndaelManaged();
                      rijndaelManaged.Key = rfc2898DeriveBytes.GetBytes(rijndaelManaged.KeySize / 8);
                      rijndaelManaged.IV = eval_a.eval_a((Stream) memoryStream);
                      ICryptoTransform decryptor = rijndaelManaged.CreateDecryptor(rijndaelManaged.Key, rijndaelManaged.IV);
                      CryptoStream cryptoStream = new CryptoStream((Stream) memoryStream, decryptor, CryptoStreamMode.Read);
                      try
                      {
                        num2 = -6461;
                        int num3 = num2;
                        num2 = -6461;
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
                            StreamReader streamReader = new StreamReader((Stream) cryptoStream);
                            try
                            {
                              str1 = streamReader.ReadToEnd();
                              break;
                            }
                            finally
                            {
                              int num5;
                              switch (0)
                              {
                                case 0:
label_15:
                                  flag = streamReader == null;
                                  num5 = 2;
                                  num1 = num5;
                                  goto default;
                                default:
                                  while (true)
                                  {
                                    switch (num1)
                                    {
                                      case 0:
                                        goto label_19;
                                      case 1:
                                        streamReader.Dispose();
                                        num5 = 0;
                                        num1 = num5;
                                        continue;
                                      case 2:
                                        if (!flag)
                                        {
                                          num5 = 1;
                                          num1 = num5;
                                          continue;
                                        }
                                        goto label_19;
                                      default:
                                        goto label_15;
                                    }
                                  }
label_19:;
                              }
                            }
                        }
                      }
                      finally
                      {
                        int num3;
                        switch (0)
                        {
                          case 0:
label_22:
                            flag = cryptoStream == null;
                            num3 = 0;
                            num1 = num3;
                            goto default;
                          default:
                            while (true)
                            {
                              switch (num1)
                              {
                                case 0:
                                  if (!flag)
                                  {
                                    num3 = 2;
                                    num1 = num3;
                                    continue;
                                  }
                                  goto label_26;
                                case 1:
                                  goto label_26;
                                case 2:
                                  cryptoStream.Dispose();
                                  num3 = 1;
                                  num1 = num3;
                                  continue;
                                default:
                                  goto label_22;
                              }
                            }
label_26:;
                        }
                      }
                    }
                    finally
                    {
                      int num3;
                      switch (0)
                      {
                        case 0:
label_29:
                          flag = memoryStream == null;
                          num3 = 1;
                          num1 = num3;
                          goto default;
                        default:
                          while (true)
                          {
                            switch (num1)
                            {
                              case 0:
                                goto label_33;
                              case 1:
                                if (!flag)
                                {
                                  num3 = 2;
                                  num1 = num3;
                                  continue;
                                }
                                goto label_33;
                              case 2:
                                memoryStream.Dispose();
                                num3 = 0;
                                num1 = num3;
                                continue;
                              default:
                                goto label_29;
                            }
                          }
label_33:;
                      }
                    }
                  }
                  finally
                  {
                    switch (0)
                    {
                      case 0:
label_36:
                        flag = rijndaelManaged == null;
                        num1 = 1;
                        goto default;
                      default:
                        while (true)
                        {
                          switch (num1)
                          {
                            case 0:
                              goto label_40;
                            case 1:
                              if (!flag)
                              {
                                num1 = 2;
                                continue;
                              }
                              goto label_40;
                            case 2:
                              rijndaelManaged.Clear();
                              num1 = 0;
                              continue;
                            default:
                              goto label_36;
                          }
                        }
label_40:;
                    }
                  }
                  str2 = str1;
                  num1 = 2;
                  continue;
                case 5:
                  goto label_47;
                default:
                  goto label_3;
              }
            }
label_6:
            num2 = 1;
            if (num2 == 0)
              ;
            throw new ArgumentNullException("cipherText");
label_47:
            throw new ArgumentNullException("sharedSecret");
label_48:
            return str2;
        }
    }
  }

  private static byte[] eval_a(Stream A_0)
  {
    int num1 = 0;
    switch (num1)
    {
      default:
        byte[] buffer1;
        bool flag;
        int num2;
        switch (0)
        {
          case 0:
label_3:
            buffer1 = new byte[4];
            flag = A_0.Read(buffer1, 0, buffer1.Length) == buffer1.Length;
            break;
          default:
            byte[] buffer2;
            byte[] numArray;
            while (true)
            {
              switch (num1)
              {
                case 0:
                  if (!flag)
                  {
                    num2 = 1;
                    num1 = num2;
                    continue;
                  }
                  numArray = buffer2;
                  num2 = 3;
                  num1 = num2;
                  continue;
                case 1:
                  goto label_9;
                case 2:
                  goto label_13;
                case 3:
                  goto label_16;
                case 4:
                  if (!flag)
                  {
                    num2 = -32435;
                    int num3 = num2;
                    num2 = -32435;
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
                        num2 = 2;
                        num1 = num2;
                        continue;
                    }
                  }
                  else
                  {
                    num2 = 0;
                    buffer2 = new byte[BitConverter.ToInt32(buffer1, 0)];
                    flag = A_0.Read(buffer2, 0, buffer2.Length) == buffer2.Length;
                    num2 = 0;
                    num1 = num2;
                    continue;
                  }
                default:
                  goto label_3;
              }
            }
label_9:
            throw new SystemException("Did not read byte array properly");
label_13:
            num2 = 1;
            if (num2 == 0)
              ;
            throw new SystemException("Stream did not contain properly formatted byte array");
label_16:
            return numArray;
        }
label_4:
        num2 = 4;
        num1 = num2;
        goto default;
    }
  }
}
