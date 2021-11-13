using HananokiLib;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml;


namespace x2FOJP {
	
	public class XMLParse {
		
		public string xmlPath;

		public class Header {
			public string Addon;
			public string Source;
			public string Dest;
			public string Version;
		}

		public class Data {
			public string EDID;
			public string REC;
			public string Source;
			public string Dest;
		}

		public Header header = new Header();
		public List<Data> datas = new List<Data>();

		public string srcTxtFileName => $"{header.Addon}_{header.Source}.txt";
		public string dstTxtFileName => $"{header.Addon}_{header.Dest}.txt";

		public bool skip;


		/////////////////////////////////////////
		public void convert( string outputPath ) {
			Data temp2 = null;
			var original = new List<string>();
			var translated = new List<string>();

			bool chkParams = false;

			using( var readxml = XmlReader.Create( xmlPath ) ) {
				for( ; readxml.Read(); ) {
					if( readxml.NodeType == XmlNodeType.Element ) {
						if( readxml.LocalName == "Params" ) {
							chkParams = true;
						}
						else if( readxml.LocalName == "Addon" ) {
							header.Addon = readxml.ReadElementContentAsString().getBaseName();
						}
						else if( readxml.LocalName == "String" ) {
							temp2 = new Data();
						}
						else if( readxml.LocalName == "EDID" ) {
							temp2.EDID = readxml.ReadElementContentAsString();
						}
						else if( readxml.LocalName == "REC" ) {
							temp2.REC = readxml.ReadElementContentAsString();
						}
						else if( readxml.LocalName == "Source" ) {
							if( chkParams ) {
								header.Source = readxml.ReadElementContentAsString();
							}
							else {
								temp2.Source = readxml.ReadElementContentAsString().Replace( "\n", "[CRLF]" );
							}
						}
						else if( readxml.LocalName == "Dest" ) {
							if( chkParams ) {
								header.Dest = readxml.ReadElementContentAsString();
								if( header.Dest == "ja" ) header.Dest = "jp";
							}
							else {
								temp2.Dest = readxml.ReadElementContentAsString().Replace( "\n", "[CRLF]" );
							}
						}
						continue;
					}

					else if( readxml.NodeType == XmlNodeType.EndElement ) {
						if( readxml.LocalName == "Params" ) {
							chkParams = false;

							var cnvPath = $"{outputPath}\\{srcTxtFileName}";
							if( cnvPath.isExistsFile() ) {
								if( !Helper.hasDependUpdate( xmlPath, cnvPath ) ) {
									skip = true;
									// 日付によりコンバートはしない
									break;
								}
							}
						}
						else if( readxml.LocalName == "String" ) {
							datas.Add( temp2 );
						}
						continue;
					}
				}
			}

			if( skip ) return;

			//
			var lst = datas
				.Where( x => x.REC != "TES4:CNAM" ) // これは要らんでしょ
				.Where( x => x.Source != x.Dest )   // 翻訳元と先で同じ場合は出力しない
				.Distinct( x => x.Source )          // 重複した翻訳元は除去
				;

			using( var origEN = new StreamWriter( $"{outputPath}\\{srcTxtFileName}", false, Encoding.GetEncoding( "Shift_JIS" ) ) ) {
				foreach( var item in lst.Select( x => x.Source ) ) {
					origEN.WriteLine( item );
				}
			}
			using( var outJP = new StreamWriter( $"{outputPath}\\{dstTxtFileName}", false, Encoding.GetEncoding( "Shift_JIS" ) ) ) {
				foreach( var item in lst.Select( x => x.Dest ) ) {
					outJP.WriteLine( item );
				}
			}
		}

	} // class
}
