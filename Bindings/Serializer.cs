using System;
using System.Runtime.InteropServices;

namespace Urho
{
   public partial class Serializer : RefCounted
   {
      public Serializer(IntPtr handle)
		{
			this.handle = handle;
		}

      // PINVOKE
      [DllImport (Consts.NativeImport, CallingConvention = CallingConvention.Cdecl)]
		internal static extern bool Serializer_WriteInt(IntPtr serializer, int value);
      
		public bool WriteInt(int value)
		{
			Runtime.ValidateRefCounted (this);
			return Serializer_WriteInt(handle, value);
		}

   }
}
