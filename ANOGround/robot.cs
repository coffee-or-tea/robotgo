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
using System.Security.Permissions;
using System.Collections;
using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using GMap.NET.WindowsForms.ToolTips;
using GMap.NET.CacheProviders;
using System.Threading;

namespace ANOGround
{
    class robot
    {
        public int robotID
        {
            get;
            set;
        }
        public PointLatLng nowPoint
        {
            get;
            set;
        }
        public PointLatLng lastPoint
        {
            get;
            set;
        }

        public GMapOverlay robotOverlay
        {
            get;
            set;
        }
    
        public void getpoint(byte[] latitude, byte[] longitude)
        {
            double wglat, wglng;
            double lat,   lng;

            double.TryParse(System.Text.Encoding.Default.GetString(latitude), out wglat);
            double.TryParse(System.Text.Encoding.Default.GetString(longitude), out wglng);
            //double.TryParse(System.Text.Encoding.Default.GetString(Azimuth), out azi);


            wglat = (wglat - (int)wglat / 100 * 100) / 60 + (int)wglat / 100;
            wglng = (wglng - (int)wglng / 100 * 100) / 60 + (int)wglng / 100;
            EvilTransform.transform(wglat, wglng, out lat, out lng);

            if (nowPoint.Lat != 0 && lat > 30 && lng > 100)
            {
                lastPoint = nowPoint;
                nowPoint = new PointLatLng(lat, lng);
                List<PointLatLng> points = new List<PointLatLng>();
                points.Add(lastPoint);
                points.Add(nowPoint);
                GMapRoute r = new GMapRoute(points, "");
                r.Stroke = new Pen(Color.Red, 2);
                robotOverlay.Routes.Add(r);
            }
            else if (lat > 30 && lng > 100)
            {
                nowPoint = new PointLatLng(lat, lng); ;
            }
        }
    }
}
