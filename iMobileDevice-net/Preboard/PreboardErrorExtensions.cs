﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// <copyright file="PreboardErrorExtensions.cs" company="Quamotion">
// Copyright (c) 2016-2020 Quamotion. All rights reserved.
// </copyright>
#pragma warning disable 1591
#pragma warning disable 1572
#pragma warning disable 1573

namespace iMobileDevice.Preboard
{
    using System.Runtime.InteropServices;
    using System.Diagnostics;
    using iMobileDevice.iDevice;
    using iMobileDevice.Lockdown;
    using iMobileDevice.Afc;
    using iMobileDevice.Plist;
    
    
    public static class PreboardErrorExtensions
    {
        
        public static void ThrowOnError(this PreboardError value)
        {
            if ((value != PreboardError.Success))
            {
                throw new PreboardException(value);
            }
        }
        
        public static void ThrowOnError(this PreboardError value, string message)
        {
            if ((value != PreboardError.Success))
            {
                throw new PreboardException(value, message);
            }
        }
        
        public static bool IsError(this PreboardError value)
        {
            return (value != PreboardError.Success);
        }
    }
}
