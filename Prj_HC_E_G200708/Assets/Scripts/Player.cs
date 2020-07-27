using UnityEngine;

public class Player : MonoBehaviour
{
	#region 欄位 
	[Header("速度"),Range(0,1000)]
	public float speed = 5;
	[Header("跳越高度"), Range(0,1000)]
	public int jump = 350;
	[Header("生命值"), Range(0,1000)]
	public float hp = 500;

	public bool isGround;
	public int coin;

	[Header("音效區域")]
	public AudioClip sndHit;
	public AudioClip sndSlide;
	public AudioClip sndJump;
	public AudioClip sndCoin;

	[Header("動畫控制器")]
	public Animator ani;
	[Header("Rigidbody")]
	public Rigidbody2D rid;
	[Header("CapsuleCollider")]
	public CapsuleCollider2D cap;
	#endregion

	#region 方法
	#endregion

	#region 事件
	#endregion

	/// <summary> 移動 </summary>
	public void Move()
	{
		
	}
	/// <summary> 跳躍 </summary>
	public void Jump()
	{

	}
	/// <summary> 滑行 </summary>
	public void Slide()
	{

	}
	/// <summary> 吃金幣 </summary>
	public void GetCoin()
	{

	}
	/// <summary> 受傷 </summary>
	public void Hurt()
	{

	}
	/// <summary> 死亡 </summary>
	public void Died()
	{

	}
	/// <summary> 通關 </summary>
	public void Win()
	{

	}

	void Start()
    {
        
    }

    void Update()
    {
        
    }
}
