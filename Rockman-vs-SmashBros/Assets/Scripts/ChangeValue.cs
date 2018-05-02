using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ChangeValue : MonoBehaviour {

	[SerializeField]
	private Dropdown Dropdown;
	
	[SerializeField]
	private Text Text;

	/// <summary>
	/// Awake is called when the script instance is being loaded.
	/// </summary>
	void Awake()
	{
		// 画面解像度が許す限りの倍率を追加する (最大 8 倍)
		var DisplayWidth = Screen.currentResolution.width;
		var DisplayHeight = Screen.currentResolution.height;
		var MaxZoom = 8;

		for (int i = 2; i < MaxZoom; i++)
		{
			if (DisplayWidth <= Global.Game.Resolution.Width*i || DisplayHeight <= Global.Game.Resolution.Height*i)
			{
				break;
			}
			var Text = ""+Global.Game.Resolution.Width*i+"x"+Global.Game.Resolution.Height*i+" (x"+i+")";
			Dropdown.options.Add(new Dropdown.OptionData{ text = Text });
		}
	}

	/// <summary>
	/// OnValueChanged is called when the value changed of dropdown.
	/// </summary>
	public void OnValueChanged(int result)
	{
		var Width = Global.Game.Resolution.Width;
		var Height = Global.Game.Resolution.Height;
		var Zoom = result+1;

		    Screen.SetResolution(Width*Zoom, Height*Zoom, false, Global.Game.FPS);
	}

	private void Update()
	{

		var Width = Display.main.systemWidth;
		var Height = Display.main.systemHeight;

		Text.text = Initialize.Reseted.ToString();
		//Text.text = Width+"x"+Height;
	}
}