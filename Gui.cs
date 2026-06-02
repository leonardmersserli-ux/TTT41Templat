using BepInEx;
using Photon.Pun;
using MalachiTemp.Backend;
using MalachiTemp.UI;
using UnityEngine;
using MalachiTemp.Utilities;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace dfgsfe
{
    /*
       PROTECTION NOTE: THIS TEMPLATE IS PROTECTED MATERIAL FROM "Project Malachi". 
       IF ANY MATERIAL FROM "MalachiTemp" FOUND IN ANY PROJECT/THING WITHOUT 
       CREDIT OR PERMISSION MUST AND WILL BE REMOVED IMMEDIATELY
    */
    [BepInPlugin("malachis.temp", "malachis.temp.GUI", "1.0.0")]
    public class Gui : BaseUnityPlugin
    {
        // Double click a grey square to open it, click the - in the box to the left of "#region" to close it
        #region Gui
        public void OnGUI()
        {
            if (open)
            {
                if (Mods.RGBMenu)
                {
                    GUI.color = Color.Lerp(WristMenu.menuObj.GetComponent<ColorChanger>().color, WristMenu.menuObj.GetComponent<ColorChanger>().color, Mathf.PingPong(Time.time, 1f));
                    GUI.backgroundColor = Color.Lerp(WristMenu.menuObj.GetComponent<ColorChanger>().color, WristMenu.menuObj.GetComponent<ColorChanger>().color, Mathf.PingPong(Time.time, 1f));
                    GUI.contentColor = Color.Lerp(WristMenu.menuObj.GetComponent<ColorChanger>().color, WristMenu.menuObj.GetComponent<ColorChanger>().color, Mathf.PingPong(Time.time, 1f));
                }
                else
                {
                    GUI.color = Color.Lerp(WristMenu.FirstColor, WristMenu.SecondColor, Mathf.PingPong(Time.time, 1f));
                    GUI.backgroundColor = Color.Lerp(WristMenu.FirstColor, WristMenu.SecondColor, Mathf.PingPong(Time.time, 1f));
                    GUI.contentColor = Color.Lerp(WristMenu.FirstColor, WristMenu.SecondColor, Mathf.PingPong(Time.time, 1f));
                }
                GUI.Box(new Rect(window.x, window.y + 7f, window.width, window.height + 2f), "");
                GUIStyle n = new GUIStyle(GUI.skin.label) { fontSize = 13, };
                GUI.Label(new Rect(window.x, window.y + 5f, 500f, 500f), "<color=white>|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|</color>", n);
                GUI.Label(new Rect(window.x + 100f, window.y + 5f, 500f, 500f), "<color=white>|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|</color>", n);
                GUI.Label(new Rect(window.x + 340f, window.y + 5f, 500f, 500f), "<color=white>|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|\n|</color>", n);
                GUI.Label(new Rect(window.x + 3f, window.y, 500f, 500f), "<color=white>------------------------------------------------------------------------------</color>", n);
                GUI.Label(new Rect(window.x + 3f, window.y + 250f, 500f, 500f), "<color=white>------------------------------------------------------------------------------</color>", n);
                GUI.Label(new Rect(window.x + 3f, window.y + 280f, 500f, 500f), "<color=white>------------------------------------------------------------------------------</color>", n);
                if (GUI.Button(new Rect(window.x + 4f, window.y + 265f, 334f, 25f), "<color=white>Disconnect</color>"))
                {
                    PhotonNetwork.Disconnect();
                    VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                }
                if (GUI.Button(new Rect(window.x + 4f, window.y + 15f, 96f, 20f), "<color=white>Settings</color>"))
                {
                    VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                    buttons = WristMenu.settingsbuttons;
                    CatOpen = true;
                }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 37f, 96f, 20f), "<color=white>" + WristMenu.buttons[3].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons1;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 59f, 96f, 20f), "<color=white>" + WristMenu.buttons[4].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons2;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 81f, 96f, 20f), "<color=white>" + WristMenu.buttons[5].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons3;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 102f, 96f, 20f), "<color=white>" + WristMenu.buttons[6].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons4;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 124f, 96f, 20f), "<color=white>" + WristMenu.buttons[7].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons5;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 146f, 96f, 20f), "<color=white>" + WristMenu.buttons[8].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons6;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 168f, 96f, 20f), "<color=white>" + WristMenu.buttons[9].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons7;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 190f, 96f, 20f), "<color=white>" + WristMenu.buttons[10].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons8;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 212f, 96f, 20f), "<color=white>" + WristMenu.buttons[11].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons9;
                        CatOpen = true;
                    }
                } catch { }
                try
                {
                    if (GUI.Button(new Rect(window.x + 4f, window.y + 234f, 96f, 20f), "<color=white>" + WristMenu.buttons[12].buttonText + "</color>"))
                    {
                        VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        buttons = WristMenu.CatButtons10;
                        CatOpen = true;
                    }
                } catch { }
                DrawButtons(buttons);
                Dragging();
            }
        }
        #endregion
        #region Update
        public void Update()
        {
            if (UnityInput.Current.GetKeyDown(OpenAndCloseGUI))
            {
                open = !open;
            }
        }
        private void Dragging()
        {
            if (Event.current.type == EventType.MouseDown && window.Contains(Event.current.mousePosition))
            {
                dragging = true;
                dragstart = Event.current.mousePosition - new Vector2(window.x, window.y);
            }
            else
            {
                if (Event.current.type == EventType.MouseUp)
                {
                    dragging = false;
                }
            }
            if (dragging)
            {
                window.position = Event.current.mousePosition - dragstart;
            }
        }
        #endregion
        #region Buttons
        public static void DrawButtons(List<ButtonInfo> Buttons)
        {
            if (CatOpen)
            {
                float width; if (Buttons.Count > 9) { width = 218f; } else { width = 228f; }
                scrollPosition = GUI.BeginScrollView(new Rect(window.x + 100f, window.y + 15f, 240f, 240f), scrollPosition, new Rect(0f, 0f, 0f, Buttons.Count * 26));
                for (int i = 0; i < Buttons.Count; i++)
                {
                    if (GUI.Button(new Rect(7f, 5 + i * 26, width, 20f), "<color=white>" + Buttons[i].buttonText + "</color>"))
                    {
                        if (Buttons[i].buttonText.Contains("Exit")) { CatOpen = false; }
                        else
                        {
                            Buttons[i].enabled = !Buttons[i].enabled;
                            WristMenu.lastPressedButtonIndex = i;
                            VRRig.LocalRig.PlayHandTapLocal(Mods.ButtonSound, false, 0.1f);
                        }
                    }
                }
                GUI.EndScrollView();
            }
        }
        #endregion
        #region Vars
        private bool open = true;
        public static bool CatOpen;
        public static KeyCode OpenAndCloseGUI = KeyCode.U; // insert (INS) to open and close the gui, u can change this to whatever u want by remove the "KeyCode.Insert" with "KeyCode." then whatever key u want
        static Vector2 scrollPosition;
        public static Rect window = new Rect(0f, 0f, 340f, 280f);
        private Vector2 dragstart;
        private bool dragging = false;
        public static List<ButtonInfo> buttons = new List<ButtonInfo>();
        #endregion
    }
}
