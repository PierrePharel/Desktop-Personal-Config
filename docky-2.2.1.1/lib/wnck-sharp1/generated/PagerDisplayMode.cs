// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[PagerDisplayMode]
	public enum PagerDisplayMode {

		Name,
		Content,
	}

	internal class PagerDisplayModeAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_pager_display_mode_get_type ();

		private static GLib.GType _gtype = new GLib.GType (wnck_pager_display_mode_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
