using UnityEngine.UI;
using UnityEngine;

/// <summary>
/// Initialize クラス
/// </summary>
/// 初期化処理を扱う静的クラス
public static class Initialize
{
	public static bool Reseted = false;

	// 初期化処理 (ゲーム開始時に 1 度だけ呼び出される)
	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	static void OnBeforeSceneLoadRuntimeMethod()
	{
		Debug.Log("-------- Start play --------");

		// 解像度およびフルスクリーンモードを正規化
		NormalizeScreen();

		// 目標 FPS を設定
		Application.targetFrameRate = Global.Game.FPS;
	}

	/// <summary>
	/// 解像度およびフルスクリーンモードを正規化
	/// </summary>
	static void NormalizeScreen()
	{
		// ディスプレイの解像度
		var ScreenWidth = Screen.width;
		var ScreenHeight = Screen.height;

		// ゲームウィンドウの解像度
		var GameWidth = Global.Game.Resolution.Width;
		var GameHeight = Global.Game.Resolution.Height;

		// フルスクリーンモード
		var FullScreenMode = Screen.fullScreen;

		// 必要に応じて画面設定をリセット
		if( (FullScreenMode) ||													// フルスクリーンで起動された場合
			(ScreenWidth%GameWidth != 0 || ScreenHeight%GameHeight != 0) ||		// ゲームウィンドウの横幅または高さがゲーム解像度の倍数でない場合
			(ScreenWidth/GameWidth != ScreenHeight/GameHeight) )				// ゲームウィンドウの横幅と高さの倍率が一致していない場合
		{
			var Width = Global.Client.DefaultWindowSize.Width;
			var Height = Global.Client.DefaultWindowSize.Height;
			var FullScr = Global.Client.DefaultFullScreenMode;
			var FPS = Global.Game.FPS;
			Screen.SetResolution(Width, Height, FullScr, FPS);
			Reseted = true;
		}
	}

}
