using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Life : General_Life {

	#region Attributes

	[SerializeField] [Range(0,100)] private float jumpForce;
	private Rigidbody2D rigid;

	#endregion

	#region GetAndSetAttributes

	protected float G_Jump_Force
	{
		get
		{
			return this.jumpForce;
		}
	}

	protected Rigidbody2D G_Rigibody2D
	{
		get
		{
			return this.rigid;
		}
	}

	#endregion

	#region IEnumerator

	#endregion

	#region Unity Methodos

	new 

	public void Awake() {
		base.Awake();
		rigid = GetComponent<Rigidbody2D>();
	}

	#endregion

	#region My Methodos

	#endregion


}
