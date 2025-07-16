using System;//DateTime
using System.Runtime.InteropServices;//DllImport
using System.Text;//StringBuilder
using System.Windows.Forms;//Application

namespace XGCommLibDemo
{
    internal class PV
    {
        public static string iniFile = Application.StartupPath + @"\XGK_PLC.ini";// ini 파일

        public static string PLCIP;
        public static string PLCPORT;
        public static string PLCReadAddr;// PLC read address
        public static string PLCWriteAddr;// PLC Write address
        public static string PLCWordReadNo;// PLC Read Word Start No.  
        public static string PLCWordWriteNo; // PLC Write Word Start No.    
        public static string PlcManualBtNo;
        public static string PlcIONo;
        const int PLC_IN_NO = 320;//int.Parse(PV.PLCWordReadNo)*16;     // 예시값
        const int PLC_OUT_NO = 320;//int.Parse(PV.PLCWordReadNo) * 16;     // 예시값(PV.PLCWordWriteNo)*16;    // 예시값

        public static bool[] d_in = new bool[PLC_IN_NO];
        public static bool[] def_in = new bool[PLC_IN_NO];
        public static bool[] d_out = new bool[PLC_OUT_NO];
        public static bool[] def_out = new bool[PLC_OUT_NO];
        public static UInt16[] byWrite = new UInt16[20];
        public static UInt16[] byRead = new UInt16[20];
    }
}
