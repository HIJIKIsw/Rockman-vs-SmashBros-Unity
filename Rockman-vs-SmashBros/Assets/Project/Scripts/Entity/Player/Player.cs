using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Player クラス
/// </summary>
public class Player : Entity {

	/// <summary>
	/// 初期化
	/// </summary>
	void Start () {
		
	}
	
	/// <summary>
	/// 更新
	/// </summary>
	protected override void Update ()
	{

		transform.position += new Vector3(1f, 0f);
		base.Update();
	}

}
