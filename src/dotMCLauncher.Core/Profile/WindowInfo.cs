﻿using Newtonsoft.Json;

namespace dotMCLauncher.Core
{
    public class WindowInfo
    {
        [JsonProperty("height")] public int Y = 480;
        [JsonProperty("width")] public int X = 854;

        /// <summary>
        /// Устанавливает значения по умолчанию.
        /// </summary>
        public void SetDefaultValues()
        {
            Y = 480;
            X = 854;
        }

        public override string ToString()
        {
            return $"({X};{Y})";
        }

        /// <summary>
        /// Вывод как аргументы.
        /// </summary>
        public string ToCommandLineArg()
        {
            return $"--width {X} --height {Y}";
        }
    }
}
