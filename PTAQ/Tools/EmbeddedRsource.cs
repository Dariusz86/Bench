﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class EmbeddedResource
    {
        private EmbeddedResource()
        {
        }

        public static StreamReader GetStream(System.Reflection.Assembly assembly, string name)
        {
            foreach (string resName in assembly.GetManifestResourceNames())
            {
                if (resName.EndsWith(name))
                {
                    return new System.IO.StreamReader(assembly.GetManifestResourceStream(resName));
                }
            }
            return null;
        }

        public static string GetString(System.Reflection.Assembly assembly, string name)
        {
            System.IO.StreamReader sr = EmbeddedResource.GetStream(assembly, name);
            string data = sr.ReadToEnd();
            sr.Close();
            return data;
        }

        public static string GetString(string name)
        {
            return EmbeddedResource.GetString(typeof(EmbeddedResource).Assembly, name);
        }
    }
}
