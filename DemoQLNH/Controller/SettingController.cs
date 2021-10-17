using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoQLNH
{
    class SettingController
    {
        private Color bgcTableFree = Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(208)))), ((int)(((byte)(80)))));
        private Color bgcTableFreeHover = Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(254)))), ((int)(((byte)(0)))));
        private Color bgcTableActive = Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(48)))), ((int)(((byte)(37)))));
        private Color bgcTableActiveHover = Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
        private Color bgcTableBooking = Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(154)))), ((int)(((byte)(190)))));
        private Color bgcTableBookingHover = Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(191)))), ((int)(((byte)(254)))));

        public Color BgcTableFree { get => bgcTableFree; set => bgcTableFree = value; }
        public Color BgcTableFreeHover { get => bgcTableFreeHover; set => bgcTableFreeHover = value; }
        public Color BgcTableActive { get => bgcTableActive; set => bgcTableActive = value; }
        public Color BgcTableActiveHover { get => bgcTableActiveHover; set => bgcTableActiveHover = value; }

        public Color textColorFree = Color.Black;
        public Color textColorActive = Color.White;
        private Color textColorBooking = Color.White;
        private static SettingController instance;
        internal static SettingController Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SettingController();
                }
                return instance;
            }
            set => instance = value;
        }

        public Color BgcTableBooking { get => bgcTableBooking; set => bgcTableBooking = value; }
        public Color BgcTableBookingHover { get => bgcTableBookingHover; set => bgcTableBookingHover = value; }
        public Color TextColorBooking { get => textColorBooking; set => textColorBooking = value; }
    }
}
