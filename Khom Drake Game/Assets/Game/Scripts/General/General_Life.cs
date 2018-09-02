using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class General_Life : MonoBehaviour {

	#region Attributes

	[SerializeField] [Range(0,500000)] private float totalLife;
	[SerializeField] [Range(0,100)] private float walkSpeed;
	private float actualLife;
	private Vector2 normalScale;
	private bool walk;
	private Animator animator;
	
	#endregion

	#region GetAndSetAttributes

	

	public Animator G_Anim
	{
		get
		{
			return this.animator;
		}
	}

	public float G_Walk_Speed
	{
		get
		{
			return this.walkSpeed;
		}

		protected set
		{
			this.walkSpeed = value;
		}
	}

	public bool G_In_Walk
	{
		get
		{
			return this.walk;
		}

		protected set
		{
			this.walk = value;
		}
	}

	public Vector2 G_Normal_Scale
	{
		get
		{
			return this.normalScale;
		}
	}

	public float G_Total_Life
	{
		get
		{
			return this.totalLife;
		}
	}

	public float G_Actual_Life
	{
		get
		{
			return this.actualLife;
		}

		set
		{
			this.actualLife = value;
		}
	}

	#endregion

	#region IEnumerator

	#endregion

	#region Unity Methodos

	public void Awake() 
	{
		actualLife = totalLife;
		normalScale = transform.localScale;
		animator = GetComponent<Animator>();
	}

	#endregion

	#region My Methodos

	#endregion

}

