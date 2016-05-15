using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Security.Permissions;//Today
using System.Collections;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.CacheProviders;

namespace ANOGround
{
    class function1
    {

         static public byte[] GPSToCode(PointLatLng SCGpoint,byte id)
        {
            double WGSlat, WGSlng;
            EvilTransformU.transform(SCGpoint.Lat, SCGpoint.Lng, out WGSlat, out WGSlng);
            byte[] destinationBuff = new byte[42];
            destinationBuff[0] = 0xaa;
            destinationBuff[1] = 0xd1;
            destinationBuff[2] = 0x80;
            destinationBuff[3] = id;
            destinationBuff[4] = 0xaa;
            destinationBuff[5] = 0xaf;
            destinationBuff[6] = 0x0b;
            destinationBuff[7] = 0x20;
            byte[] b = Encoding.ASCII.GetBytes(WGSlat.ToString("N13"));
            for (int i = 0; i < 16; i++)
            {
                destinationBuff[8 + i] = b[i];
            }
            b = Encoding.ASCII.GetBytes(WGSlng.ToString("N12"));
            for (int i = 0; i < 16; i++)
            {
                destinationBuff[24 + i] = b[i];
            }
            destinationBuff[40] = destinationBuff[4];
            for (int i = 5; i < 40; i++)
            {
                destinationBuff[40] += destinationBuff[i];                 //正确！！！！
            }
            destinationBuff[41] = 0x55;
            return destinationBuff;
        }
    }
}
