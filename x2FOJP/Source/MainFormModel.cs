using HananokiLib;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;



namespace x2FOJP {

	public partial class MainForm : Form {

		/////////////////////////////////////////
		void rollbackWindow() {
			//Location = new Point( m_config.x, m_config.y );
			Width = m_config.width;
			Height = m_config.height;
		}


		/////////////////////////////////////////
		void backupWindow() {
			m_config.x = Location.X;
			m_config.y = Location.Y;
			m_config.width = Width;
			m_config.height = Height;
		}


		/////////////////////////////////////////
		void showFileListPanel() {
			toggleUIPanel( true );

			stateXTransButton();
			initListView();

			listView1. Focus();
		}



		/////////////////////////////////////////
		void showSettingPanel() {
			toggleUIPanel( false );

			checkBox1.Checked = m_config.flag.Has( D.ENABLE_WRITE_FOJP );
			checkBox2.Checked = m_config.flag.Has( D.ENABLE_LAUNCHER );

			toggleFOJPState( checkBox1.Checked );
			toggleLAUNCHERState( checkBox2.Checked );

			Focus();
		}



		/////////////////////////////////////////
		void toggleUIPanel( bool toggle ) {
			m_statusBarMessage.clearNotifyText();

			panel_ListView.Visible = toggle;
			panel_Settings.Visible = !toggle;

			tsb_Return.Visible = !toggle;
			tsb_Settings.Visible = toggle;

			tsb_Refresh.Visible = toggle;
			toolStripSeparator3.Visible = toggle;
			tsb_xTranslator.Visible = toggle;
			toolStripSeparator2.Visible = toggle;
			tsb_Convert.Visible = toggle;
		}



		/////////////////////////////////////////
		void toggleFOJPState( bool toggle ) {
			lbl_fojp.Enabled = toggle;
			lbl_prefix.Enabled = toggle;
			textBox_fojp.Enabled = toggle;
			textBox_prefix.Enabled = toggle;
		}

		/////////////////////////////////////////
		void toggleLAUNCHERState( bool toggle ) {
			label1.Enabled = toggle;
			textBox_xTranslatorPath.Enabled = toggle;
		}



		/////////////////////////////////////////
		void stateXTransButton() {
			if( !m_config .flag.Has(D.ENABLE_LAUNCHER)) {
				tsb_xTranslator.Visible = false;
				toolStripSeparator2.Visible = false;
				return;
			}

			tsb_xTranslator.Visible = true;
			toolStripSeparator2.Visible = true;
			if( m_config.xTranslatorPath.isExistsFile() ) {
				tsb_xTranslator.Text = "xTranslator";
				tsb_xTranslator.Image = icon.file( m_config.xTranslatorPath );
				tsb_xTranslator.Enabled = true;
			}
			else {
				tsb_xTranslator.Text = "Not Found: xTranslator";
				tsb_xTranslator.Image = icon.warning;
				tsb_xTranslator.Enabled = false;
			}
		}



		/////////////////////////////////////////
		void processConvert() {
			try {
				if( m_config.fojpFilePath.isEmpty() ) {
					m_statusBarMessage.setNotifyText( S.MSG_UNSET_FOJP_XML, StatusBarMessage.NotifyType.Warning );
					return;
				}
				if( !m_config.fojpFilePath.isExistsFile() ) {
					m_statusBarMessage.setNotifyText( S.MSG_NOT_FOUND_FOJP_XML, StatusBarMessage.NotifyType.Warning );
					return;
				}

				var lst = m_items
					.Where( x => x.Checked )
					.Select( x => new XMLParse { xmlPath = x.getFullPath() } ).ToList();

				if( lst.Count() == 0 ) {
					var result = MessageBox.Show( S.MSG_NO_CONV, S.CONFIRM, MessageBoxButtons.OKCancel );
					if( result == DialogResult.Cancel ) {
						m_statusBarMessage.setNotifyText( S.MSG_STOP );
						return;
					}
				}
				var lst2 = lst.ToArray();

				foreach( var p in lst2 ) {
					p.convert( m_config.outputFolderPath );
				}
				processfojp( lst2 );

				m_statusBarMessage.setNotifyText( $"{S.MSG_COMP}: 変換:{lst2.Where( x => !x.skip ).Count()} スキップ:{lst2.Where(x=>x.skip).Count()}"  );
			}
			catch( Exception e ) {
				m_statusBarMessage.setNotifyText( $"{e.GetType().Name}\n{e.Message}", StatusBarMessage.NotifyType.Error );
			}
		}



		/////////////////////////////////////////
		void processfojp( XMLParse[] datas ) {
			var findSection = false;
			var output = File.ReadAllLines( m_config.fojpFilePath );
			var b = new StringBuilder();
			var rela = m_config.prefix;
			if( rela.isEmpty() ) {
				rela = string.Empty;
			}
			else {
				rela += "/";
			}

			bool beginScope = false;

			foreach( var s in output ) {
				if( !beginScope ) b.Append( s );

				s.match( @"<!-- x2FOJP Begin -->", ( m ) => {
					findSection = true;
					b.Append( "\n" );
					var space = s.Replace( "<!-- x2FOJP Begin -->", "" ).Replace( "\n", "" );
					foreach( var p in datas ) {
						b.Append( $"{space}<file {p.header.Dest}=\"{rela}{p.dstTxtFileName}\" {p.header.Source}=\"{rela}{p.srcTxtFileName}\" />" );
						b.Append( "\n" );
					}
					//b.Append( $"{space}<file jp=\"{rela}NV Muffler_jp.txt\" en=\"{rela}NV Muffler_en.txt\" />" );

					beginScope = true;
				} );
				s.match( @"<!-- x2FOJP End -->", ( m ) => {
					b.Append( s );
					beginScope = false;
				} );

				if( !beginScope ) b.Append( "\n" );
			}
			File.WriteAllText( m_config.fojpFilePath, b.ToString() );

			if( !findSection ) {
				MessageBox.Show( "<!-- x2FOJP Begin -->が見つからないためfojp.xmlの書き込みはありません", "情報", MessageBoxButtons.OK );
			}
		}
	}
}
