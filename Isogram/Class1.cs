using System;

namespace Isogram
{
    public class Class1
    {
        public static bool Isogram1(string str)
        {
            int i,j=0;
            for(i=0;i<str.Length;i++)
            {
                if (!(str[i].Equals(' ') || str[i].Equals('-')))
                {
                    j = i+1;
                    while(j<str.Length)
                    {
                        if(str[i]==str[j])
                        {
                            return false;
                        }
                        j++;
                    }
                }

            }
            return true;
        }
    }
}
