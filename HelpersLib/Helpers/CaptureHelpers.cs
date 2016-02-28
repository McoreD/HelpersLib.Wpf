using ShareX.HelpersLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;

namespace HelpersLib
{
    public static class CaptureHelpers
    {
        public static Rect GetScreenBounds()
        {
            return new Rect()
            {
                X = SystemParameters.VirtualScreenLeft,
                Y = SystemParameters.VirtualScreenTop,
                Height = SystemParameters.VirtualScreenHeight,
                Width = SystemParameters.VirtualScreenWidth
            };
        }

        public static Point ScreenToClient(Point p)
        {
            int screenX = NativeMethods.GetSystemMetrics(SystemMetric.SM_XVIRTUALSCREEN);
            int screenY = NativeMethods.GetSystemMetrics(SystemMetric.SM_YVIRTUALSCREEN);
            return new Point(p.X - screenX, p.Y - screenY);
        }

        public static Point GetCursorPosition()
        {
            POINT point;

            if (NativeMethods.GetCursorPos(out point))
            {
                return new Point(point.X, point.Y);
            }

            return new Point();
        }

        public static Point GetZeroBasedMousePosition()
        {
            return ScreenToClient(GetCursorPosition());
        }
    }
}