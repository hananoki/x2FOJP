using HananokiLib;


namespace x2FOJP {
	public class Config {
		public int width = 800;
		public int height = 600;
		public int x;
		public int y;

		public int flag;

		public string xTranslatorPath;
		public string fojpFilePath;
		public string srcXMLFolderPath;
		public string outputFolderPath;
		public string prefix;


		/////////////////////////////////////////
		public static Config load() {
			var config = new Config();
			Helper.ReadJson( ref config, Helper.configPath );
			return config;
		}


		/////////////////////////////////////////
		public void save() {
			Helper.WriteJson( this );
		}

	} // class


	public class ConfigTitle {
		public string name;
		public int flag;
		//public string updateTime;
	} // class

}
