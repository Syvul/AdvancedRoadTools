﻿using ColossalFramework.Plugins;
using System.IO;

namespace AdvancedRoadTools.Util
{
    public static class DebugLog
    {
        public static void LogToFileOnly(string msg)
        {
            using (FileStream fileStream = new FileStream("AdvancedRoadTools.txt", FileMode.Append))
            {
                StreamWriter streamWriter = new StreamWriter(fileStream);
                streamWriter.WriteLine(msg);
                streamWriter.Flush();
            }
        }

        public static void LogWarning(string msg)
        {
            DebugOutputPanel.AddMessage(PluginManager.MessageType.Warning, msg);
        }
    }
}