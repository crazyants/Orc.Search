﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="StringExtensions.cs" company="WildGums">
//   Copyright (c) 2008 - 2015 WildGums. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Search
{
    public static class StringExtensions
    {
        public static string PrepareOrcSearchFilter(this string filter)
        {
            if (!filter.Contains("*") &&
                !filter.Contains(":") &&
                !filter.Contains(" ") &&
                !filter.Contains("AND") &&
                !filter.Contains("OR"))
            {
                filter += "*";
            }

            return filter;
        }

        public static bool IsValidOrcSearchFilter(this string filter)
        {
            if (string.IsNullOrWhiteSpace(filter))
            {
                return false;
            }

            filter = filter.Trim();
            if (filter.EndsWith(":"))
            {
                return false;
            }

            return true;
        }
    }
}