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
                X = (int)SystemParameters.VirtualScreenLeft,
                Y = (int)SystemParameters.VirtualScreenTop,
                Height = (int)SystemParameters.VirtualScreenHeight,
                Width = (int)SystemParameters.VirtualScreenWidth
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

        public static Rect CreateRectangle(int x, int y, int x2, int y2)
        {
            int width, height;

            if (x <= x2)
            {
                width = x2 - x + 1;
            }
            else
            {
                width = x - x2 + 1;
                x = x2;
            }

            if (y <= y2)
            {
                height = y2 - y + 1;
            }
            else
            {
                height = y - y2 + 1;
                y = y2;
            }

            return new Rect(x, y, width, height);
        }

        public static Rect CreateRectangle(Point pos, Point pos2)
        {
            return CreateRectangle(pos.X, pos.Y, pos2.X, pos2.Y);
        }

        public static Rect CreateRectangle(double x1, double y1, double x2, double y2)
        {
            return CreateRectangle((int)x1, (int)y1, (int)x2, (int)y2);
        }
    }
}