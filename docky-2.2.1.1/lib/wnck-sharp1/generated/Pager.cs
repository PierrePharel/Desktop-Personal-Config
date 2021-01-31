// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Pager]
	public class Pager : Gtk.Container {

		public Pager(IntPtr raw) : base(raw) {}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_pager_new(IntPtr screen);

		public Pager (Wnck.Screen screen) : base (IntPtr.Zero)
		{
			if (GetType () != typeof (Pager)) {
				throw new InvalidOperationException ("Can't override this constructor.");
			}
			owned = true;
			Raw = wnck_pager_new(screen == null ? IntPtr.Zero : screen.Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_pager_get_type();

		static GLib.GType _gtype = new GLib.GType (wnck_pager_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_pager_set_display_mode(IntPtr raw, int mode);

		public Wnck.PagerDisplayMode DisplayMode { 
			set {
				wnck_pager_set_display_mode(Handle, (int) value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_pager_set_shadow_type(IntPtr raw, int shadow_type);

		public Gtk.ShadowType ShadowType { 
			set {
				wnck_pager_set_shadow_type(Handle, (int) value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_pager_set_orientation(IntPtr raw, int orientation);

		public bool SetOrientation(Gtk.Orientation orientation) {
			bool raw_ret = wnck_pager_set_orientation(Handle, (int) orientation);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_pager_set_n_rows(IntPtr raw, int n_rows);

		public bool SetNRows(int n_rows) {
			bool raw_ret = wnck_pager_set_n_rows(Handle, n_rows);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_pager_set_show_all(IntPtr raw, bool show_all_workspaces);

		public bool ShowAllWorkspaces { 
			set {
				wnck_pager_set_show_all(Handle, value);
			}
		}

#endregion
	}

	internal class PagerAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_pager_get_type ();

		private static GLib.GType _gtype = new GLib.GType (wnck_pager_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
