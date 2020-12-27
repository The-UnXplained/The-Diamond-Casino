using GTA;
using GTA.Native;
using System;
using System.Windows.Forms;

namespace mpvinewood
{
    public class Main : Script
    {
        bool Initialized = false;

        public Main()
        {
            Tick += OnTick;
        }

        void RequestIpl(string iplName)
        {
            if (!Function.Call<bool>(Hash.IS_IPL_ACTIVE, iplName))
            {
                Function.Call(Hash.REQUEST_IPL, iplName);
            }
        }

		void Init()
		{
            RequestIpl("hei_dlc_casino_aircon");
            RequestIpl("hei_dlc_casino_aircon_lod");
            RequestIpl("hei_dlc_casino_door");
            RequestIpl("hei_dlc_casino_door_lod");
            RequestIpl("hei_dlc_vw_roofdoors_locked");
            RequestIpl("hei_dlc_windows_casino");
            RequestIpl("hei_dlc_windows_casino_lod");
            RequestIpl("vw_ch3_additions");
            RequestIpl("vw_ch3_additions_long_0");
            RequestIpl("vw_ch3_additions_strm_0");
            RequestIpl("vw_dlc_casino_door");
            RequestIpl("vw_dlc_casino_door_lod");
		}

        void OnTick(object sender, EventArgs e)
        {
            if (!Initialized)
            {
                Script.Wait(1000);
				Init();
				Initialized = true;
            }
        }
    }
}