using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using System.IO;

namespace OhScrap
{
    [KSPAddon(KSPAddon.Startup.Flight, false)]
    class Logger : MonoBehaviour
    {
        public List<string> logs = new List<string>();
        public static Logger instance;
        string directory;
        public void Awake()
        {
            logs.Add("Using Oh Scrap " + Version.Number);
            instance = this;
            directory = KSPUtil.ApplicationRootPath + "/GameData/OhScrap/Logs/";
            if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);
            DirectoryInfo source = new DirectoryInfo(directory);
            foreach (FileInfo fi in source.GetFiles())
            {
                var creationTime = fi.CreationTime;
                if (creationTime < (DateTime.Now - new TimeSpan(1, 0, 0, 0)))
                {
                    fi.Delete();
                }
            }
        }

        public void Log(string s)
        {
            logs.Add(s);
            //Debug.Log("[OhScrap]: " + s);
            Debug.Log(string.Format("[OhScrap (UPFM) v{0}]: ", Version.Text) + s);
        }

        public void OnDisable()
        {
            if (logs.Count() == 1) return;
            string path = directory + DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + ".txt";
            using (StreamWriter writer = File.AppendText(path))
            {
                foreach (string s in logs)
                {
                    writer.WriteLine(s);
                }
            }
        }

        /// <summary>Messages to the screen in the specified format.</summary>
        /// <param name="format">The format.</param>
        /// <param name="args">The arguments.</param>
        private void Message(string format, params object[] args)
        {
            //ScreenMessages.PostScreenMessage(string.Format(format, args), 3.0f, ScreenMessageStyle.UPPER_CENTER);
            ScreenMessages.PostScreenMessage(string.Format(format, args), 3f, 0);
        }

        /// <summary>Add messages to the log. Prepends "OhScrap (UPFM) v{0}]: ", Version.Text</summary>
        /// <param name="logMsg">The message.</param>
        /// <param name="xDebug">require DEBUG setting to create log entry</param>
        private void Dlog(string logMsg, bool xDebug = true)
        {
            logMsg = string.Format("[OhScrap (UPFM) v{0}]: ", Version.Text) + logMsg;
            if (xDebug || HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().logging)
            {
                Debug.Log(logMsg);
            }
            else
            {
#if DEBUG
                    Debug.Log(logMsg);
#endif
            }
        }

        /// <summary>LogWarning: Add messages to the log. Prepends "OhScrap (UPFM) v{0}]: ", Version.Text</summary>
        /// <param name="logMsg">The message.</param>
        /// <param name="xDebug">require DEBUG setting to create log entry</param>
        private void DlogWarning(string logMsg, bool xDebug = true)
        {
            logMsg = string.Format("[OhScrap (UPFM) v{0}]: ", Version.Text) + logMsg;
            if (xDebug || HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().logging)
            {
                Debug.LogWarning(logMsg);
            }
            else
            {
#if DEBUG
                    Debug.LogWarning(logMsg);
#endif
            }
        }

        /// <summary>LogError: Add messages to the log. Prepends "OhScrap (UPFM) v{0}]: ", Version.Text</summary>
        /// <param name="logMsg">The message.</param>
        /// <param name="xDebug">require DEBUG setting to create log entry</param>
        private void DlogError(string logMsg, bool xDebug = true)
        {
            logMsg = string.Format("[OhScrap (UPFM) v{0}]: ", Version.Text) + logMsg;
            if (xDebug || HighLogic.CurrentGame.Parameters.CustomParams<UPFMSettings>().logging)
            {
                Debug.LogError(logMsg);
            }
            else
            {
#if DEBUG
                    Debug.LogError(logMsg);
#endif
            }
        }
    }
}

