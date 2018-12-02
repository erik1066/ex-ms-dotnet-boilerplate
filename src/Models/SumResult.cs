using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System.Reflection;

namespace Foundation.Example.WebUI.Models
{
    /// <summary>
    /// The result of adding two numbers
    /// </summary>
    public sealed class SumResult
    {
        /// <summary>
        /// The first number
        /// </summary>
        public int FirstNumber { get; set; }

        /// <summary>
        /// The second number
        /// </summary>
        public int SecondNumber { get; set; }

        /// <summary>
        /// The sum of the two numbers
        /// </summary>
        public int Sum { get; set; }
    }
}