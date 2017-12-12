﻿namespace Microsoft.Win32
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    [ComImport]
    [Guid( "B63EA76D-1F85-456F-A19C-48159EFA858B" )]
    [InterfaceType( ComInterfaceType.InterfaceIsIUnknown )]
    interface IShellItemArray
    {
        // Not supported: IBindCtx not defined, converting to IntPtr
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime )]
        void BindToHandler( [In, MarshalAs( UnmanagedType.Interface )] IntPtr pbc, [In] ref Guid rbhid, [In] ref Guid riid, out IntPtr ppvOut );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime )]
        void GetPropertyStore( [In] int flags, [In] ref Guid riid, out IntPtr ppv );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime )]
        void GetPropertyDescriptionList( [In] ref PropertyKey keyType, [In] ref Guid riid, out IntPtr ppv );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime )]
        void GetAttributes( [In] ShellItemArrayAttributeFlags dwAttribFlags, [In] uint sfgaoMask, out uint psfgaoAttribs );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime )]
        void GetCount( out uint pdwNumItems );

        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime )]
        void GetItemAt( [In] uint dwIndex, [MarshalAs( UnmanagedType.Interface )] out IShellItem ppsi );

        // Not supported: IEnumShellItems (will use GetCount and GetItemAt instead)
        [MethodImpl( MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime )]
        void EnumItems( [MarshalAs( UnmanagedType.Interface )] out IntPtr ppenumShellItems );
    }
}