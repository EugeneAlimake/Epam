using System;
using System.Collections.Generic;
using System.Text;

namespace Basic_of_.Net_Fremework
{
    public class Unit
    {

        public static char maxnoRepeating(string str)
        {
            int len = str.Length;
            int count = 0;
            char res = str[0];

            // Find the maximum repeating
            // character starting from str[i]
            for (int i = 0; i < len; i++)
            {
                int cur_count = 1;
                for (int j = i + 1; j < len; j++)
                {
                    if (str[i] != str[j])
                        cur_count++;
                    else
                        break;
                }

                // Update result if required
                if (cur_count > count)
                {
                    count = cur_count;
                    res = str[i];
                }
            }
            return res;
        }
        public static char maxRepeating(string str)
        {
            int len = str.Length;
            int count = 0;
            char res = str[0];

            for (int i = 0; i < len; i++)
            {
                int cur_count = 1;
                for (int j = i + 1; j < len; j++)
                {
                    if (str[i] != str[j])
                        break;
                    cur_count++;
                }

                if (cur_count > count)
                {
                    count = cur_count;
                    res = str[i];
                }
            }
            return res;
        }

        public static int maxRepeatingint(int[] a)
        {

            int n = 10;
            int x = a[0], cnt = 1, mx = -1;
            for (int i = 1; i < n; ++i)
            {
                if (a[i] == x)
                    cnt++;
                else
                {
                    if (cnt > mx)
                        mx = cnt;
                    cnt = 1;
                    x = a[i];
                }
            }
            if (cnt > mx)
                mx = cnt;
            return mx;
        }
    }
}
