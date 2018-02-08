using System;
using System.Runtime.InteropServices;

namespace Urho
{
   public partial class VectorBuffer : RefCounted
   {
      public VectorBuffer(IntPtr handle)
      {
         this.handle = handle;
      }

      // PINVOKE
      [DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool VectorBuffer_WriteInt(IntPtr buffer, int value);
      
      public bool WriteInt(int value)
      {
         Runtime.ValidateRefCounted (this);
         return VectorBuffer_WriteInt(handle, value);
      }

      [DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int VectorBuffer_ReadInt(IntPtr buffer);
      
      public int ReadInt()
      {
         Runtime.ValidateRefCounted (this);
         return VectorBuffer_ReadInt(handle);
      }

      [DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
      internal static extern bool VectorBuffer_SeekRelative(IntPtr buffer, int value);
      
      public bool SeekRelative(int value)
      {
         Runtime.ValidateRefCounted (this);
         return VectorBuffer_SeekRelative(handle, value);
      }


   }
}
