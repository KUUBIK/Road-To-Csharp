using System;
public class Number
{
    public int DigitalRoot(long data)
    {
        int shet = default;
        char[] datas = data.ToString().ToCharArray();
        for (int i = 0; i < datas.Length; i++)
        {
            shet = shet + Int32.Parse(datas[i].ToString());
        }

        if (shet >= 10)
        { return DigitalRoot(shet); }

        return shet;
    }
}