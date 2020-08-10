﻿using UnityEngine;

public class CameraControl : MonoBehaviour
{
	[Header("目標:要追蹤的物件")]
	public Transform target;
	[Header("追蹤速度"),Range(0,10)]
	public float speed = 1;
	[Header("攝影機拍攝的上限與下限")]
	public Vector2 limit = new Vector2(0,0.7f);

	/// <summary> 追蹤 </summary>
	private void Track()
	{
		Vector3 posA = transform.position;					// A點:攝影機目標
		Vector3 posB = target.position;						// B點:目標 座標

		posB.z = -10;										// 攝影機Z軸固定 -10
		posB.y = Mathf.Clamp(posB.y, limit.x, limit.y);		// Y軸 = 數學.夾住(Y軸, 限制.X, 限制.Y)

		// A點 = 差值(A點,B點,百分比)
		posA = Vector3.Lerp(posA,posB,speed*Time.deltaTime);

		transform.position = posA;							// 攝影機.座標 = A點
	}

	// Late Update 在 Update 後執行,攝影機追蹤
	void LateUpdate()
    {
		Track();
    }
}
