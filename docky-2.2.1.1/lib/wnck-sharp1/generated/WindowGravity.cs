// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[WindowGravity]
	public enum WindowGravity {

		Current,
		Northwest = 1,
		North = 2,
		Northeast = 3,
		West = 4,
		Center = 5,
		East = 6,
		Southwest = 7,
		South = 8,
		Southeast = 9,
		Static = 10,
	}

	internal class WindowGravityAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_gravity_get_type ();

		private static GLib.GType _gtype = new GLib.GType (wnck_window_gravity_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
#endregion
}
