using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Okull
{
    public class Program
    {
        public Program()
        {
            StreamWriter logFile = File.CreateText("Okull.json");
            logFile.AutoFlush = true;
            writer = new JsonTextWriter(logFile);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartObject();
            writer.WritePropertyName("Operations");
            writer.WriteStartArray();
        }
    }
}



//Konsol uygulaması olarak çalıştıramadım. İlk defa bu yıl yazılım gördüğüm için çok iyi değilim. Ama istediğiniz İnterfaceleri ve enumları eksiksiz olarak yaptım hocam.
