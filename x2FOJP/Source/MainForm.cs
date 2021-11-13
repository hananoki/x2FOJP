using HananokiLib;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;



namespace x2FOJP {
	public partial class MainForm : Form {

		public static MainForm instance;

		public Config m_config;


		StatusBarMessage m_statusBarMessage;

		List<ListViewItem> m_items;
		TargetInfoFile m_targetInfo;


		/////////////////////////////////////////
		public MainForm() {
			instance = this;
			InitializeComponent();
		}



		/////////////////////////////////////////
		void MainForm_Load( object sender, EventArgs e ) {
			Font = SystemFonts.IconTitleFont;
			Text = $"{Text} - {Helper.version}";

			m_config = Config.load();
			rollbackWindow();

			m_statusBarMessage = new StatusBarMessage( this, toolStripStatusLabel1 );

			listView1.SetDoubleBuffered( true );

			m_targetInfo = new TargetInfoFile();
			m_targetInfo.load();

			showFileListPanel();

			///////////////////
			textBox_xTranslatorPath.init( S.TXTBOX_XTRANSLATOR, ( s ) => {
				m_config.xTranslatorPath = s;
				return s;
			} );
			textBox_xTranslatorPath.setText( m_config.xTranslatorPath );

			///////////////////
			textBox_fojp.init( S.TXTBOX_FOJP, ( s ) => {
				m_config.fojpFilePath = s;
				return s;
			} );
			textBox_fojp.setText( m_config.fojpFilePath );

			///////////////////
			textBox_xmlFolder.init( S.TXTBOX_XML_FOLDER, ( s ) => {
				if( s.isExistsFile() ) {
					s = s.getDirectoryName();
				}
				m_config.srcXMLFolderPath = s;
				return s;
			} );
			textBox_xmlFolder.setText( m_config.srcXMLFolderPath );

			///////////////////
			textBox_convTxtFolder.init( S.TXTBOX_TXT_FOLDER, ( s ) => {
				if( s.isExistsFile() ) {
					s = s.getDirectoryName();
				}
				m_config.outputFolderPath = s;
				return s;
			} );
			textBox_convTxtFolder.setText( m_config.outputFolderPath );

			///////////////////
			textBox_prefix.init( S.TXTBOX_ADD_PATH, ( s ) => {
				m_config.prefix = s;
				return s;
			} );
			textBox_prefix.checkMode = false;
			textBox_prefix.setText( m_config.prefix );


			initListView();
		}



		/////////////////////////////////////////
		void MainForm_FormClosing( object sender, FormClosingEventArgs e ) {
			backupWindow();

			m_config.save();

			m_targetInfo.save();
		}


		/////////////////////////////////////////
		void tsb_Convert_Click( object sender, EventArgs e ) => processConvert();


		/////////////////////////////////////////
		void tsb_Setting_Click( object sender, EventArgs e ) => showSettingPanel();


		/////////////////////////////////////////
		void tsb_xTranslator_Click( object sender, EventArgs e ) {
			shell.start( m_config.xTranslatorPath );
		}


		/////////////////////////////////////////
		void tsb_return_Click( object sender, EventArgs e ) => showFileListPanel();


		/////////////////////////////////////////
		void tsb_Refresh_Click( object sender, EventArgs e ) {
			initListView();
		}


		/////////////////////////////////////////
		void checkBox1_CheckStateChanged( object sender, EventArgs e ) {
			var chkbox = (CheckBox) sender;

			if( chkbox == checkBox1 ) {
				m_config.flag.Toggle( D.ENABLE_WRITE_FOJP, chkbox.Checked );
				toggleFOJPState( chkbox.Checked );
			}
			else {
				m_config.flag.Toggle( D.ENABLE_LAUNCHER, chkbox.Checked );
				toggleLAUNCHERState( chkbox.Checked );
			}
		}

	} // class
}
