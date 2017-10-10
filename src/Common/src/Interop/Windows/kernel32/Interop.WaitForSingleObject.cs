// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

internal static partial class Interop
{
    internal static partial class Kernel32
    {
        [DllImport(Interop.Libraries.Kernel32, ExactSpelling = true, SetLastError = true, EntryPoint = "WaitForSingleObject")]
        public static extern int WaitForSingleObject(SafeWaitHandle handle, int timeout);
    }
}