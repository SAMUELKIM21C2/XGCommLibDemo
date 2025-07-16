using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;//WndProc
namespace XGCommLibDemo
{
    public partial class Form1
    {
        private void InitData()
        {
            childMain = new ChildForm.MAIN();
            childFormHome = new ChildForm.FormHome();
            childIO_View = new ChildForm.IO_View();
            childManual = new ChildForm.Manual();

            // ini 파일 읽기
            PV.PLCIP = PF.Getinivalue("PLC_Data", "PLCIP");
            PV.PLCPORT = PF.Getinivalue("PLC_Data", "PLCPORT");
            PV.PLCWriteAddr = PF.Getinivalue("PLC_Data", "PLCWriteAddr");
            PV.PLCReadAddr = PF.Getinivalue("PLC_Data", "PLCReadAddr");
            PV.PLCWordReadNo = PF.Getinivalue("PLC_Data", "PLCWordReadNo");
            PV.PLCWordWriteNo = PF.Getinivalue("PLC_Data", "PLCWordWriteNo");
            PV.PlcManualBtNo = PF.Getinivalue("PLC_Data", "PlcManualBtNo");
            PV.PlcIONo = PF.Getinivalue("PLC_Data", "PlcIONo");

        }

    }
}
