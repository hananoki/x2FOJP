using HananokiLib;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace x2FOJP {

	public partial class MainForm : Form {

		/////////////////////////////////////////
		void onRetrieveVirtualItem( object sender, RetrieveVirtualItemEventArgs e ) {
			if( m_items.Count <= e.ItemIndex ) return;
			if( m_items == null ) return;

			e.Item = m_items[ e.ItemIndex ];
		}



		/////////////////////////////////////////
		// チェックボックスがクリックされたらその部分を再描画
		void listView1_MouseClick( object sender, MouseEventArgs e ) {
			var listview = (ListView) sender;
			var item = listview.GetItemAt( e.X, e.Y );


			//var item = listview.GetItemAt( e.X, e.Y );
			if( item != null ) {
				if( e.X < ( item.Bounds.Left + 16 ) ) {
					item.invertChecked();
					item.targetInfo().flag.Toggle( 0x01, item.Checked );
				}
			}

		}


		/////////////////////////////////////////
		void initListView() {
			m_items = new List<ListViewItem>();
			if( m_config.srcXMLFolderPath.isExistsDirectory() ) {
				var files = Directory.GetFiles( m_config.srcXMLFolderPath );
				foreach( var p in files ) {
					var newItem = new ListViewItem( new string[] { p.getFileName() } );
					newItem.Checked = true;
					newItem.Checked = false;
					var ti = m_targetInfo.get( p.getFileName() );
					newItem.Checked = ti.flag.Has( D.ENABLE_CONV_FILE );
					var lvitem = new LVItem {
						fullPath = p,
						targetInfo = ti
					};
					
					if( imageList1.Images.Count == 0 ) {
						imageList1.Images.Add( icon.file( p ) );
					}
					newItem.ImageIndex = 0;
					newItem.Tag = lvitem;
					m_items.Add( newItem );
				}
			}

			listView1.VirtualListSize = m_items.Count;
			listView1.Columns[ 0 ].Width = listView1.Width - 4;
			listView1.Columns[ 0 ].Text = "ファイルリスト";

			m_statusBarMessage.setNotifyText( $"{S.UPDATE_FILELIST}" );
		}

	} // class
}
