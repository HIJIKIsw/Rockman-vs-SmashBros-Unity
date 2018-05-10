using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {

	#region メンバーの宣言

	private struct ButtonStates													// 各ボタンの入力状態 構造体
	{
		public bool Up;
		public bool Down;
		public bool Left;
		public bool Right;
		public bool A;
		public bool B;
		public bool Start;
		public bool Select;
	}

	private struct ButtonSprites												// 各ボタンのスプライト 構造体
	{
		public SpriteRenderer Up;
		public SpriteRenderer Down;
		public SpriteRenderer Left;
		public SpriteRenderer Right;
		public SpriteRenderer A;
		public SpriteRenderer B;
		public SpriteRenderer Start;
		public SpriteRenderer Select;
	}

	private static ButtonStates ButtonState;									// 現在のボタン入力状態
	private static ButtonStates OldButtonState;									// 1フレーム前のボタン入力状態
	private static ButtonSprites ButtonSprite;									// 各ボタンのスプライト
	#endregion

	/// <summary>
	/// 初期化
	/// </summary>
	private void Start()
	{
		// 各ボタンのスプライトを取得
		ButtonSprite.Up = GameObject.Find("Up").GetComponent<SpriteRenderer>();
		ButtonSprite.Down = GameObject.Find("Down").GetComponent<SpriteRenderer>();
		ButtonSprite.Left = GameObject.Find("Left").GetComponent<SpriteRenderer>();
		ButtonSprite.Right = GameObject.Find("Right").GetComponent<SpriteRenderer>();
		ButtonSprite.A = GameObject.Find("A").GetComponent<SpriteRenderer>();
		ButtonSprite.B = GameObject.Find("B").GetComponent<SpriteRenderer>();
		ButtonSprite.Start = GameObject.Find("Start").GetComponent<SpriteRenderer>();
		ButtonSprite.Select = GameObject.Find("Select").GetComponent<SpriteRenderer>();
	}

	/// <summary>
	/// フレームの更新
	/// </summary>
	private void Update()
	{
		// 1フレーム前の入力状態
		OldButtonState = ButtonState;

		// キー入力状態を更新
		ButtonState.Up = Input.GetButton("Up");
		ButtonState.Down = Input.GetButton("Down");
		ButtonState.Left = Input.GetButton("Left");
		ButtonState.Right = Input.GetButton("Right");
		ButtonState.A = Input.GetButton("A");
		ButtonState.B = Input.GetButton("B");
		ButtonState.Start = Input.GetButton("Start");
		ButtonState.Select = Input.GetButton("Select");

		// ボタンのスプライトを管理
		ButtonSprite.Up.enabled = ButtonState.Up;
		ButtonSprite.Down.enabled = ButtonState.Down;
		ButtonSprite.Left.enabled = ButtonState.Left;
		ButtonSprite.Right.enabled = ButtonState.Right;
		ButtonSprite.A.enabled = ButtonState.A;
		ButtonSprite.B.enabled = ButtonState.B;
		ButtonSprite.Start.enabled = ButtonState.Start;
		ButtonSprite.Select.enabled = ButtonState.Select;
	}

}
