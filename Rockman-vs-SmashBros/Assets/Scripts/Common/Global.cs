/// <summary>
/// Global クラス
/// </summary>
public static class Global {

	// ゲームに関する定数
	public struct Game
	{
		public static int FPS = 60;

		// ゲームの内部解像度
		public struct Resolution
		{
			public const int Width = 256;
			public const int Height = 240;
		}
	}

	// クライアントに関する定数
	public struct Client
	{
		// デフォルトのフルスクリーンモード
		public const bool DefaultFullScreenMode = false;

		// ウィンドウのデフォルトサイズ
		public struct DefaultWindowSize
		{
			public const int Width = Game.Resolution.Width*2;
			public const int Height = Game.Resolution.Height*2;
		}
	}
}
