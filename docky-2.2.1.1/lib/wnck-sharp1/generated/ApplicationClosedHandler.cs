// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;

	public delegate void ApplicationClosedHandler(object o, ApplicationClosedArgs args);

	public class ApplicationClosedArgs : GLib.SignalArgs {
		public Wnck.Application App{
			get {
				return (Wnck.Application) Args [0];
			}
		}

	}
}