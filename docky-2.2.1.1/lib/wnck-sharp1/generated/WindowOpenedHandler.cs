// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;

	public delegate void WindowOpenedHandler(object o, WindowOpenedArgs args);

	public class WindowOpenedArgs : GLib.SignalArgs {
		public Wnck.Window Window{
			get {
				return (Wnck.Window) Args [0];
			}
		}

	}
}
