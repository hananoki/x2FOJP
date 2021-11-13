using HananokiLib;
using System;
using System.Threading;
using System.Windows.Forms;


namespace x2FOJP {
	static class Program {
		/// <summary>
		/// アプリケーションのメイン エントリ ポイントです。
		/// </summary>
		[STAThread]
		static void Main( string[] args ) {
			using( var mutex = new Mutex( false, typeof( MainForm ).ToString() ) ) {
				if( mutex.WaitOne( 0, false ) == false ) {
					MessageBox.Show( "[x2FOJP] instance is already running.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error );
					return;
				}
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault( false );
				Helper._init();
				if( 0 < args.Length ) {
					Debug.Log( args[ 0 ] );
					Helper.s_appPath = args[ 0 ];
				}
				Application.Run( new MainForm() );
			}
		}
	}
}
