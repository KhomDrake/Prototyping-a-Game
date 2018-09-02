using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Script : Player_Life
{

	#region Attributes

	public static Player_Script instance {get; private set;}

	[Header("Ground")]
	[SerializeField] private Transform ground;
	[SerializeField] private LayerMask groundLayer;
	[SerializeField] private float rangeDectection;
	private bool inTheGround;

	#endregion

	#region GetAndSetAttributes

	#endregion

	#region IEnumerator

	#endregion

	#region Unity Methodos

	new 
	void Awake()
	{
		base.Awake();
		instance = this;
	}

	void Update()
	{
		Moviment();
		inTheGround = Physics2D.OverlapCircle(ground.position, rangeDectection, groundLayer);
		Attack();
	}

	void FixedUpdate()
	{
		G_Anim.SetBool("InWalk", G_In_Walk);
		G_Anim.SetBool("Ground", inTheGround);
	}

	#endregion

	#region My Methodos

	private void Attack()
	{
		if(CanAttackAgain() && Input.GetKeyDown(KeyCode.Q))
		{
			G_Anim.SetTrigger("BasicAttack");
			G_Rigibody2D.velocity = Vector2.zero;
		}
	}

	private void Moviment()
	{
		if(CanMove() && Input.GetKey(KeyCode.LeftArrow))
		{
			// transform.Translate(Vector2.left * G_Walk_Speed * Time.deltaTime);
			G_Rigibody2D.velocity = new Vector2(Vector2.left.x * G_Walk_Speed, G_Rigibody2D.velocity.y);
			transform.localScale = new Vector2(-G_Normal_Scale.x, G_Normal_Scale.y);
			G_In_Walk = true;
			G_Anim.SetBool("InWalk", G_In_Walk);
		}	
		if(CanMove() && Input.GetKey(KeyCode.RightArrow))
		{
			// transform.Translate(Vector2.right * G_Walk_Speed * Time.deltaTime);
			G_Rigibody2D.velocity = new Vector2(Vector2.right.x * G_Walk_Speed, G_Rigibody2D.velocity.y);
			transform.localScale = new Vector2(G_Normal_Scale.x, G_Normal_Scale.y);
			G_In_Walk = true;
			G_Anim.SetBool("InWalk", G_In_Walk);
		}		

		if(Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
		{
			G_In_Walk = false;
		}

		Jump();
	}

	private void Jump()
	{
		if(!inTheGround)
			return;

		if(Input.GetKeyDown(KeyCode.Space))
		{
			G_Rigibody2D.velocity += new Vector2(0, G_Jump_Force);
			G_Anim.SetTrigger("Jump");
		}
	}

	private bool CanMove()
	{
		string[] animThatCannotMatch = new string[]{"Knight_BasickAttack"};
		return Can(animThatCannotMatch);
	}

	private bool CanAttackAgain()
	{
		string[] animThatCannotMatch = new string[]{"Knight_BasickAttack"};
		return Can(animThatCannotMatch);
	}

	private bool Can(string[] cannotMatch)
	{
		string[] animThatCannotMatch = cannotMatch;
		string animName = G_Anim.GetCurrentAnimatorClipInfo(0)[0].clip.name;

		for (int i = 0; i < animThatCannotMatch.Length; i++)
		{
			if(animName == animThatCannotMatch[i])
				return false;
		}

		return true;
	}

	#endregion

}
