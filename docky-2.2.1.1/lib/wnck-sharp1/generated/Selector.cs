// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Selector]
	public class Selector : Gtk.MenuBar {

		public Selector(IntPtr raw) : base(raw) {}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_selector_new();

		public Selector () : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Selector)) {
				CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
				return;
			}
			owned = true;
			Raw = wnck_selector_new();
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_selector_get_type();

		static GLib.GType _gtype = new GLib.GType (wnck_selector_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

#endregion
	}

	internal class SelectorAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_selector_get_type ();

		private static GLib.GType _gtype = new GLib.GType (wnck_selector_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}