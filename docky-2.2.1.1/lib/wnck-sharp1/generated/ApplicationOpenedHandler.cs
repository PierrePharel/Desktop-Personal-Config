// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;

	public delegate void ApplicationOpenedHandler(object o, ApplicationOpenedArgs args);

	public class ApplicationOpenedArgs : GLib.SignalArgs {
		public Wnck.Application App{
			get {
				return (Wnck.Application) Args [0];
			}
		}

	}
}
