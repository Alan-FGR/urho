using System;
using System.Runtime.InteropServices;

namespace Urho
{
   public partial class Deserializer : RefCounted
   {
      public Deserializer(IntPtr handle)
      {
         this.handle = handle;
      }

      // PINVOKE
      [DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
      internal static extern int Deserializer_ReadInt(IntPtr serializer);
      
      public int ReadInt()
      {
         Runtime.ValidateRefCounted (this);
         return Deserializer_ReadInt(handle);
      }

   }
}