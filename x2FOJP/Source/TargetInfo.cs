using HananokiLib;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace x2FOJP {

	//////////////////////////////////////////////////////////////////////////////////
	public class TargetInfo {
		public string name;
		public int flag;
		//public DateTime updateTime;
	}


	//////////////////////////////////////////////////////////////////////////////////
	public class TargetInfoFile {

		string filePath = $"{Helper.s_appPath}\\x2FOJP.filelist";

		List<TargetInfo> m_targetInfo = new List<TargetInfo>();

		Dictionary<string, TargetInfo> m_dic = new Dictionary<string, TargetInfo>();


		/////////////////////////////////////////
		public TargetInfo get( string filename ) {
			TargetInfo result;
			if( m_dic.TryGetValue( filename, out result ) ) {
				return result;
			}
			result = new TargetInfo();
			result.name = filename;
			result.flag = D.ENABLE_CONV_FILE;

			m_targetInfo.Add( result );
			m_dic.Add( filename, result );
			return result;
		}


		/////////////////////////////////////////
		public void load() {
			if( !filePath.isExistsFile() ) return;

			var lines = File.ReadAllLines( filePath );
			m_targetInfo = new List<TargetInfo>( lines.Length * 2 );
			foreach( var p in lines ) {
				var t = p.Split( '\t' );
				m_targetInfo.Add( new TargetInfo {
					name = t[ 0 ],
					flag = int.Parse( t[ 1 ] ),
					//updateTime = DateTime.Parse( t[ 2 ] ),
				} );
			}

			m_dic = new Dictionary<string, TargetInfo>( m_targetInfo.Count );
			foreach( var p in m_targetInfo ) {
				m_dic.Add( p.name, p );
			}

		}


		/////////////////////////////////////////
		public void save() {
			var b = new StringBuilder();
			foreach( var s in m_targetInfo ) {
				//b.Append( $"{s.name}\t{s.flag.ToString()}\t{s.updateTime.ToString()}\n" );
				b.Append( $"{s.name}\t{s.flag.ToString()}\n" );
			}
			File.WriteAllText( filePath, b.ToString() );
		}
	}

}
