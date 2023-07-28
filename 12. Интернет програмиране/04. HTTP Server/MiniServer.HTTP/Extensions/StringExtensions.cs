﻿using System;
using System.Linq;

namespace MiniServer.HTTP.Extensions
{
    public static class StringExtensions
    {
        public static string Capitalize(this string text) => char.ToUpper(text[0]) + text.Substring(1).ToLower();
    }
}
