// This file was generated by the Gtk# code generator.
// Any changes made will be lost if regenerated.

namespace Wnck {

	using System;
	using System.Collections;
	using System.Runtime.InteropServices;

#region Autogenerated code
	[Window]
	public class Window : GLib.Object {

		public Window(IntPtr raw) : base(raw) {}

		protected Window() : base(IntPtr.Zero)
		{
			CreateNativeObject (Array.Empty<IntPtr> (), Array.Empty<GLib.Value> (), 0);
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void GeometryChangedVMDelegate (IntPtr window);

		static GeometryChangedVMDelegate GeometryChangedVMCallback;

		static void geometrychanged_cb (IntPtr window)
		{
			try {
				Window window_managed = GLib.Object.GetObject (window, false) as Window;
				window_managed.OnGeometryChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideGeometryChanged (GLib.GType gtype)
		{
			if (GeometryChangedVMCallback == null)
				GeometryChangedVMCallback = new GeometryChangedVMDelegate (geometrychanged_cb);
			OverrideVirtualMethod (gtype, "geometry_changed", GeometryChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Wnck.Window), ConnectionMethod="OverrideGeometryChanged")]
		protected virtual void OnGeometryChanged ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			}
		}

		[GLib.Signal("geometry_changed")]
		public event System.EventHandler GeometryChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "geometry_changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "geometry_changed");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void WorkspaceChangedVMDelegate (IntPtr window);

		static WorkspaceChangedVMDelegate WorkspaceChangedVMCallback;

		static void workspacechanged_cb (IntPtr window)
		{
			try {
				Window window_managed = GLib.Object.GetObject (window, false) as Window;
				window_managed.OnWorkspaceChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideWorkspaceChanged (GLib.GType gtype)
		{
			if (WorkspaceChangedVMCallback == null)
				WorkspaceChangedVMCallback = new WorkspaceChangedVMDelegate (workspacechanged_cb);
			OverrideVirtualMethod (gtype, "workspace_changed", WorkspaceChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Wnck.Window), ConnectionMethod="OverrideWorkspaceChanged")]
		protected virtual void OnWorkspaceChanged ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			}
		}

		[GLib.Signal("workspace_changed")]
		public event System.EventHandler WorkspaceChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "workspace_changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "workspace_changed");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void IconChangedVMDelegate (IntPtr window);

		static IconChangedVMDelegate IconChangedVMCallback;

		static void iconchanged_cb (IntPtr window)
		{
			try {
				Window window_managed = GLib.Object.GetObject (window, false) as Window;
				window_managed.OnIconChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideIconChanged (GLib.GType gtype)
		{
			if (IconChangedVMCallback == null)
				IconChangedVMCallback = new IconChangedVMDelegate (iconchanged_cb);
			OverrideVirtualMethod (gtype, "icon_changed", IconChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Wnck.Window), ConnectionMethod="OverrideIconChanged")]
		protected virtual void OnIconChanged ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			}
		}

		[GLib.Signal("icon_changed")]
		public event System.EventHandler IconChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "icon_changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "icon_changed");
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void StateChangedVMDelegate (IntPtr window, int changed_mask, int new_state);

		static StateChangedVMDelegate StateChangedVMCallback;

		static void statechanged_cb (IntPtr window, int changed_mask, int new_state)
		{
			try {
				Window window_managed = GLib.Object.GetObject (window, false) as Window;
				window_managed.OnStateChanged ((Wnck.WindowState) changed_mask, (Wnck.WindowState) new_state);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideStateChanged (GLib.GType gtype)
		{
			if (StateChangedVMCallback == null)
				StateChangedVMCallback = new StateChangedVMDelegate (statechanged_cb);
			OverrideVirtualMethod (gtype, "state_changed", StateChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Wnck.Window), ConnectionMethod="OverrideStateChanged")]
		protected virtual void OnStateChanged (Wnck.WindowState changed_mask, Wnck.WindowState new_state)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				using (var val1 = new GLib.Value (changed_mask)) {
				inst_and_params.Append (val1);
					using (var val2 = new GLib.Value (new_state)) {
					inst_and_params.Append (val2);
					g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
					}
				}
			}
		}

		[GLib.Signal("state_changed")]
		public event Wnck.StateChangedHandler StateChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "state_changed", typeof (Wnck.StateChangedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "state_changed", typeof (Wnck.StateChangedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void ActionsChangedVMDelegate (IntPtr window, int changed_mask, int new_actions);

		static ActionsChangedVMDelegate ActionsChangedVMCallback;

		static void actionschanged_cb (IntPtr window, int changed_mask, int new_actions)
		{
			try {
				Window window_managed = GLib.Object.GetObject (window, false) as Window;
				window_managed.OnActionsChanged ((Wnck.WindowActions) changed_mask, (Wnck.WindowActions) new_actions);
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideActionsChanged (GLib.GType gtype)
		{
			if (ActionsChangedVMCallback == null)
				ActionsChangedVMCallback = new ActionsChangedVMDelegate (actionschanged_cb);
			OverrideVirtualMethod (gtype, "actions_changed", ActionsChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Wnck.Window), ConnectionMethod="OverrideActionsChanged")]
		protected virtual void OnActionsChanged (Wnck.WindowActions changed_mask, Wnck.WindowActions new_actions)
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (3);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				using (var val1 = new GLib.Value (changed_mask)) {
				inst_and_params.Append (val1);
					using (var val2 = new GLib.Value (new_actions)) {
					inst_and_params.Append (val2);
					g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
					}
				}
			}
		}

		[GLib.Signal("actions_changed")]
		public event Wnck.ActionsChangedHandler ActionsChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "actions_changed", typeof (Wnck.ActionsChangedArgs));
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "actions_changed", typeof (Wnck.ActionsChangedArgs));
				sig.RemoveDelegate (value);
			}
		}

		[UnmanagedFunctionPointer (CallingConvention.Cdecl)]
		delegate void NameChangedVMDelegate (IntPtr window);

		static NameChangedVMDelegate NameChangedVMCallback;

		static void namechanged_cb (IntPtr window)
		{
			try {
				Window window_managed = GLib.Object.GetObject (window, false) as Window;
				window_managed.OnNameChanged ();
			} catch (Exception e) {
				GLib.ExceptionManager.RaiseUnhandledException (e, false);
			}
		}

		private static void OverrideNameChanged (GLib.GType gtype)
		{
			if (NameChangedVMCallback == null)
				NameChangedVMCallback = new NameChangedVMDelegate (namechanged_cb);
			OverrideVirtualMethod (gtype, "name_changed", NameChangedVMCallback);
		}

		[GLib.DefaultSignalHandler(Type=typeof(Wnck.Window), ConnectionMethod="OverrideNameChanged")]
		protected virtual void OnNameChanged ()
		{
			GLib.Value ret = GLib.Value.Empty;
			GLib.ValueArray inst_and_params = new GLib.ValueArray (1);
			using (var val0 = new GLib.Value (this)) {
				inst_and_params.Append (val0);
				g_signal_chain_from_overridden (inst_and_params.ArrayPtr, ref ret);
			}
		}

		[GLib.Signal("name_changed")]
		public event System.EventHandler NameChanged {
			add {
				GLib.Signal sig = GLib.Signal.Lookup (this, "name_changed");
				sig.AddDelegate (value);
			}
			remove {
				GLib.Signal sig = GLib.Signal.Lookup (this, "name_changed");
				sig.RemoveDelegate (value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_has_icon_name(IntPtr raw);

		public bool HasIconName { 
			get {
				bool raw_ret = wnck_window_has_icon_name(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get(UIntPtr xwindow);

		public static Wnck.Window Get(ulong xwindow) {
			IntPtr raw_ret = wnck_window_get(new UIntPtr (xwindow));
			Wnck.Window ret = GLib.Object.GetObject(raw_ret) as Wnck.Window;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_stick(IntPtr raw);

		public void Stick() {
			wnck_window_stick(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_keyboard_move(IntPtr raw);

		public void KeyboardMove() {
			wnck_window_keyboard_move(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_set_skip_pager(IntPtr raw, bool skip);

		public bool SkipPager { 
			set {
				wnck_window_set_skip_pager(Handle, value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_icon(IntPtr raw);

		public Gdk.Pixbuf Icon { 
			get {
				IntPtr raw_ret = wnck_window_get_icon(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unmake_above(IntPtr raw);

		public void UnmakeAbove() {
			wnck_window_unmake_above(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_workspace(IntPtr raw);

		public Wnck.Workspace Workspace { 
			get {
				IntPtr raw_ret = wnck_window_get_workspace(Handle);
				Wnck.Workspace ret = GLib.Object.GetObject(raw_ret) as Wnck.Workspace;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_needs_attention(IntPtr raw);

		public bool NeedsAttention() {
			bool raw_ret = wnck_window_needs_attention(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_transient_is_most_recently_activated(IntPtr raw);

		public bool TransientIsMostRecentlyActivated() {
			bool raw_ret = wnck_window_transient_is_most_recently_activated(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_make_below(IntPtr raw);

		public void MakeBelow() {
			wnck_window_make_below(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unmaximize(IntPtr raw);

		public void Unmaximize() {
			wnck_window_unmaximize(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_activate(IntPtr raw, uint timestamp);

		public void Activate(uint timestamp) {
			wnck_window_activate(Handle, timestamp);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unpin(IntPtr raw);

		public void Unpin() {
			wnck_window_unpin(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_maximized_vertically(IntPtr raw);

		public bool IsMaximizedVertically { 
			get {
				bool raw_ret = wnck_window_is_maximized_vertically(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_keyboard_size(IntPtr raw);

		public void KeyboardSize() {
			wnck_window_keyboard_size(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_type();

		static GLib.GType _gtype = new GLib.GType (wnck_window_get_type());
		public static new GLib.GType GType { 
			get {
								return _gtype;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_application(IntPtr raw);

		public Wnck.Application Application { 
			get {
				IntPtr raw_ret = wnck_window_get_application(Handle);
				Wnck.Application ret = GLib.Object.GetObject(raw_ret) as Wnck.Application;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern int wnck_window_get_state(IntPtr raw);

		public Wnck.WindowState State { 
			get {
				int raw_ret = wnck_window_get_state(Handle);
				Wnck.WindowState ret = (Wnck.WindowState) raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_sticky(IntPtr raw);

		public bool IsSticky { 
			get {
				bool raw_ret = wnck_window_is_sticky(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern int wnck_window_get_actions(IntPtr raw);

		public Wnck.WindowActions Actions { 
			get {
				int raw_ret = wnck_window_get_actions(Handle);
				Wnck.WindowActions ret = (Wnck.WindowActions) raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_set_geometry(IntPtr raw, int gravity, int geometry_mask, int x, int y, int width, int height);

		public void SetGeometry(Wnck.WindowGravity gravity, Wnck.WindowMoveResizeMask geometry_mask, int x, int y, int width, int height) {
			wnck_window_set_geometry(Handle, (int) gravity, (int) geometry_mask, x, y, width, height);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_below(IntPtr raw);

		public bool IsBelow { 
			get {
				bool raw_ret = wnck_window_is_below(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_in_viewport(IntPtr raw, IntPtr workspace);

		public bool IsInViewport(Wnck.Workspace workspace) {
			bool raw_ret = wnck_window_is_in_viewport(Handle, workspace == null ? IntPtr.Zero : workspace.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_move_to_workspace(IntPtr raw, IntPtr space);

		public void MoveToWorkspace(Wnck.Workspace space) {
			wnck_window_move_to_workspace(Handle, space == null ? IntPtr.Zero : space.Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_session_id(IntPtr raw);

		public string SessionId { 
			get {
				IntPtr raw_ret = wnck_window_get_session_id(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_has_name(IntPtr raw);

		public bool HasName { 
			get {
				bool raw_ret = wnck_window_has_name(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_above(IntPtr raw);

		public bool IsAbove { 
			get {
				bool raw_ret = wnck_window_is_above(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_maximized_horizontally(IntPtr raw);

		public bool IsMaximizedHorizontally { 
			get {
				bool raw_ret = wnck_window_is_maximized_horizontally(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unmaximize_vertically(IntPtr raw);

		public void UnmaximizeVertically() {
			wnck_window_unmaximize_vertically(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_make_above(IntPtr raw);

		public void MakeAbove() {
			wnck_window_make_above(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unshade(IntPtr raw);

		public void Unshade() {
			wnck_window_unshade(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_minimized(IntPtr raw);

		public bool IsMinimized { 
			get {
				bool raw_ret = wnck_window_is_minimized(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_skip_tasklist(IntPtr raw);

		public bool IsSkipTasklist { 
			get {
				bool raw_ret = wnck_window_is_skip_tasklist(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unminimize(IntPtr raw, uint timestamp);

		public void Unminimize(uint timestamp) {
			wnck_window_unminimize(Handle, timestamp);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_maximize(IntPtr raw);

		public void Maximize() {
			wnck_window_maximize(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_maximized(IntPtr raw);

		public bool IsMaximized { 
			get {
				bool raw_ret = wnck_window_is_maximized(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr wnck_window_get_xid(IntPtr raw);

		public ulong Xid { 
			get {
				UIntPtr raw_ret = wnck_window_get_xid(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unmake_below(IntPtr raw);

		public void UnmakeBelow() {
			wnck_window_unmake_below(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_class_group(IntPtr raw);

		public Wnck.ClassGroup ClassGroup { 
			get {
				IntPtr raw_ret = wnck_window_get_class_group(Handle);
				Wnck.ClassGroup ret = GLib.Object.GetObject(raw_ret) as Wnck.ClassGroup;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_shade(IntPtr raw);

		public void Shade() {
			wnck_window_shade(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_minimize(IntPtr raw);

		public void Minimize() {
			wnck_window_minimize(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_pin(IntPtr raw);

		public void Pin() {
			wnck_window_pin(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_set_fullscreen(IntPtr raw, bool fullscreen);

		public bool Fullscreen { 
			set {
				wnck_window_set_fullscreen(Handle, value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_maximize_vertically(IntPtr raw);

		public void MaximizeVertically() {
			wnck_window_maximize_vertically(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_mini_icon(IntPtr raw);

		public Gdk.Pixbuf MiniIcon { 
			get {
				IntPtr raw_ret = wnck_window_get_mini_icon(Handle);
				Gdk.Pixbuf ret = GLib.Object.GetObject(raw_ret) as Gdk.Pixbuf;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_pinned(IntPtr raw);

		public bool IsPinned { 
			get {
				bool raw_ret = wnck_window_is_pinned(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern int wnck_window_get_sort_order(IntPtr raw);

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_set_sort_order(IntPtr raw, int order);

		public int SortOrder { 
			get {
				int raw_ret = wnck_window_get_sort_order(Handle);
				int ret = raw_ret;
				return ret;
			}
			set {
				wnck_window_set_sort_order(Handle, value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_name(IntPtr raw);

		public string Name { 
			get {
				IntPtr raw_ret = wnck_window_get_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_screen(IntPtr raw);

		public Wnck.Screen Screen { 
			get {
				IntPtr raw_ret = wnck_window_get_screen(Handle);
				Wnck.Screen ret = GLib.Object.GetObject(raw_ret) as Wnck.Screen;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern UIntPtr wnck_window_get_group_leader(IntPtr raw);

		public ulong GroupLeader { 
			get {
				UIntPtr raw_ret = wnck_window_get_group_leader(Handle);
				ulong ret = (ulong) raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_on_workspace(IntPtr raw, IntPtr workspace);

		public bool IsOnWorkspace(Wnck.Workspace workspace) {
			bool raw_ret = wnck_window_is_on_workspace(Handle, workspace == null ? IntPtr.Zero : workspace.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_set_skip_tasklist(IntPtr raw, bool skip);

		public bool SkipTasklist { 
			set {
				wnck_window_set_skip_tasklist(Handle, value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unmaximize_horizontally(IntPtr raw);

		public void UnmaximizeHorizontally() {
			wnck_window_unmaximize_horizontally(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_most_recently_activated(IntPtr raw);

		public bool IsMostRecentlyActivated { 
			get {
				bool raw_ret = wnck_window_is_most_recently_activated(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_unstick(IntPtr raw);

		public void Unstick() {
			wnck_window_unstick(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_or_transient_needs_attention(IntPtr raw);

		public bool OrTransientNeedsAttention() {
			bool raw_ret = wnck_window_or_transient_needs_attention(Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_activate_transient(IntPtr raw, uint timestamp);

		public void ActivateTransient(uint timestamp) {
			wnck_window_activate_transient(Handle, timestamp);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_get_client_window_geometry(IntPtr raw, out int xp, out int yp, out int widthp, out int heightp);

		public void GetClientWindowGeometry(out int xp, out int yp, out int widthp, out int heightp) {
			wnck_window_get_client_window_geometry(Handle, out xp, out yp, out widthp, out heightp);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_icon_name(IntPtr raw);

		public string IconName { 
			get {
				IntPtr raw_ret = wnck_window_get_icon_name(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_maximize_horizontally(IntPtr raw);

		public void MaximizeHorizontally() {
			wnck_window_maximize_horizontally(Handle);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_set_icon_geometry(IntPtr raw, int x, int y, int width, int height);

		public void SetIconGeometry(int x, int y, int width, int height) {
			wnck_window_set_icon_geometry(Handle, x, y, width, height);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_get_geometry(IntPtr raw, out int xp, out int yp, out int widthp, out int heightp);

		public void GetGeometry(out int xp, out int yp, out int widthp, out int heightp) {
			wnck_window_get_geometry(Handle, out xp, out yp, out widthp, out heightp);
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_active(IntPtr raw);

		public bool IsActive { 
			get {
				bool raw_ret = wnck_window_is_active(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_get_icon_is_fallback(IntPtr raw);

		public bool IconIsFallback { 
			get {
				bool raw_ret = wnck_window_get_icon_is_fallback(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern int wnck_window_get_pid(IntPtr raw);

		public int Pid { 
			get {
				int raw_ret = wnck_window_get_pid(Handle);
				int ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_fullscreen(IntPtr raw);

		public bool IsFullscreen { 
			get {
				bool raw_ret = wnck_window_is_fullscreen(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern int wnck_window_get_window_type(IntPtr raw);

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_set_window_type(IntPtr raw, int wintype);

		public Wnck.WindowType WindowType { 
			get {
				int raw_ret = wnck_window_get_window_type(Handle);
				Wnck.WindowType ret = (Wnck.WindowType) raw_ret;
				return ret;
			}
			set {
				wnck_window_set_window_type(Handle, (int) value);
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_shaded(IntPtr raw);

		public bool IsShaded { 
			get {
				bool raw_ret = wnck_window_is_shaded(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_skip_pager(IntPtr raw);

		public bool IsSkipPager { 
			get {
				bool raw_ret = wnck_window_is_skip_pager(Handle);
				bool ret = raw_ret;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_session_id_utf8(IntPtr raw);

		public string SessionIdUtf8 { 
			get {
				IntPtr raw_ret = wnck_window_get_session_id_utf8(Handle);
				string ret = GLib.Marshaller.Utf8PtrToString (raw_ret);
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_transient(IntPtr raw);

		public Wnck.Window Transient { 
			get {
				IntPtr raw_ret = wnck_window_get_transient(Handle);
				Wnck.Window ret = GLib.Object.GetObject(raw_ret) as Wnck.Window;
				return ret;
			}
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern bool wnck_window_is_visible_on_workspace(IntPtr raw, IntPtr workspace);

		public bool IsVisibleOnWorkspace(Wnck.Workspace workspace) {
			bool raw_ret = wnck_window_is_visible_on_workspace(Handle, workspace == null ? IntPtr.Zero : workspace.Handle);
			bool ret = raw_ret;
			return ret;
		}

		[DllImport("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern void wnck_window_close(IntPtr raw, uint timestamp);

		public void Close(uint timestamp) {
			wnck_window_close(Handle, timestamp);
		}

#endregion
	}

	internal class WindowAttribute : GLib.GTypeTypeAttribute {
		[DllImport ("wnck-1", CallingConvention = CallingConvention.Cdecl)]
		static extern IntPtr wnck_window_get_type ();

		private static GLib.GType _gtype = new GLib.GType (wnck_window_get_type ());
		public static GLib.GType GType { get { return _gtype; } }
		public override GLib.GType Type { get { return _gtype; } }

	}
}
