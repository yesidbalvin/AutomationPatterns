﻿using System;

namespace Observer.Attributes
{
    [AttributeUsage(AttributeTargets.Method, Inherited = true, AllowMultiple = false)]
    public class KnownIssueAttribute : Attribute
    {
        public KnownIssueAttribute()
        {
        }

        public int BugId { get; set; }
    }
}
