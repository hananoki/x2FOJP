using System.Windows.Forms;


namespace x2FOJP {

	public class LVItem {
		public string fullPath;
		public TargetInfo targetInfo;
	}

	public static class LVItemExtensions {
		public static string getFullPath( this ListViewItem lvitem ) {
			return ( (LVItem) lvitem.Tag ).fullPath;
		}
		public static TargetInfo targetInfo( this ListViewItem lvitem ) {
			return ( (LVItem) lvitem.Tag ).targetInfo;
		}
	}
}
