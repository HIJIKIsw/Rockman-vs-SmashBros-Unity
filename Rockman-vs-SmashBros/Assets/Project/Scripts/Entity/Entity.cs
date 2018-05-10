using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Entity クラス
/// </summary>
public class Entity : MonoBehaviour {

	#region メンバー宣言
	public bool IsNoclip;														// 地形を無視するか
	public bool IsIgnoreGravity;												// 重力を無視するか
	#endregion

	/// <summary>
	/// 更新
	/// </summary>
	protected virtual void Update () {
		
	}
}
