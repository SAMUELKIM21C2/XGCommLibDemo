using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace XGCommLibDemo
{
    internal class PF
    {   
        // ini 파일 읽기/쓰기
        [DllImport("kernel32.dll")]
        public static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        public static extern int WritePrivateProfileString(string section, string key, string def, string filePath);

        // ini 파일 읽기
        public static string Getinivalue(string section, string key)
        {
            StringBuilder temp = new StringBuilder(100);

            int i = GetPrivateProfileString(section, key, "", temp, 100, PV.iniFile);
            return temp.ToString();
        }

        // ini 파일 쓰기
        public static void Setinivalue(string section, string key, string value)
        {
            WritePrivateProfileString(section, key, value, PV.iniFile);
        }

        // 현재날짜시간
        public static string GetDateTime()
        {
            return DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static void CalcOutData(int bit, int set)
        {
            int port_no = bit / 16;
            int bit_no = bit % 16;

            UInt16 mask_bit = 0x01;
            mask_bit <<= bit_no;

            if (set != 0)
                PV.byWrite[port_no] |= mask_bit;
            else
                PV.byWrite[port_no] &= (UInt16)~mask_bit;
        }
    }
}

