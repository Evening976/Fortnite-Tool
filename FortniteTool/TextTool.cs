using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

namespace FortniteTool
{
    public static class TextTool
    {

        public static int GetNumbers(string text)
        {
            int counter = 0;
            StreamReader reader = new StreamReader(Global.configPath);
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.Contains(text))
                {
                    break;
                }
                counter++;
            }

            Regex re = new Regex(@"\d+");

            reader.Close();

            int v;

            int.TryParse(re.Match(line).ToString(), out v);

            return v;
        }

        private static void ReplaceLine(string OldChar, string NewChar)
        {
            StreamReader sr = new StreamReader(Global.configPath);
            String[] rows = Regex.Split(sr.ReadToEnd(), "\r\n");
            sr.Close();

            StreamWriter sw = new StreamWriter(Global.configPath);
            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i].StartsWith(OldChar))
                {
                    rows[i] = NewChar;
                }
                sw.WriteLine(rows[i]);
            }
            sw.Close();
        }

        public static void ApplySettings(string newResX, string newResY, Global.FullScreenMode fsMode, string M_FPS)
        {
            for (int i = 0; i < Global.FullscreenModeText.Length; i++)
            {
                ReplaceLine(Global.FullscreenModeText[i], Global.FullscreenModeText[i] + (int)fsMode);
            }


            for (int i = 0; i < Global.ResolutionXText.Length; i++)
            {
                ReplaceLine(Global.ResolutionXText[i], Global.ResolutionXText[i] + newResX);
            }


            for (int i = 0; i < Global.ResolutionYText.Length; i++)
            {
                ReplaceLine(Global.ResolutionYText[i], Global.ResolutionYText[i] + newResY);
            }

            ReplaceLine(Global.FramerateLimitText, Global.FramerateLimitText + M_FPS + ".000000");
        }

    }

    public static class Global
    {
        public static string configPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\FortniteGame\\Saved\\Config\\WindowsClient\\GameUserSettings.ini";

        public static string[] ResolutionXText =
        {
            "ResolutionSizeX=",
            "DesiredScreenWidth=",
            "LastUserConfirmedDesiredScreenWidth=",
            "LastUserConfirmedResolutionSizeX="
        };

        public static string[] ResolutionYText =
        {
            "ResolutionSizeY=",
            "DesiredScreenHeight=",
            "LastUserConfirmedDesiredScreenHeight=",
            "LastUserConfirmedResolutionSizeY="
        };

        public static string[] FullscreenModeText =
        {
           "PreferredFullscreenMode=",
           "FullscreenMode="
        };

        public static string FramerateLimitText =
            "FrameRateLimit=";

        public enum FullScreenMode
        {
            Fullscreen=0,
            FullscreenWindowed=1
        };

        public static int ResX, ResY, M_FPS;

        public static FullScreenMode fsMode;

    }
}
