using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill_Object : MonoBehaviour {

	#region atributos

    [SerializeField] private Skill skill;
    private bool side;
    [SerializeField] private bool isToMoveOneDirection, notChangeScale, trueIsLeft;
    [SerializeField] [Range(0, 100)] private float speed;
    Vector3 normalScale;

    #endregion

    #region getAndSetAtributos

    public bool Side
    {
        get
        {
            return this.side;
        }

        set
        {
            this.side = value;
        }
    }

    public Skill MySkill
    {
        get
        {
            return this.skill;
        }
    }


    #endregion

    #region unityMethodos

    private void Awake()
    {
        normalScale = transform.localScale;
        side = skill.MySkill.side;
        StartCoroutine(skill.TimeToSpendInScreen(this.gameObject));
    }

    private void FixedUpdate()
    {
        if (notChangeScale && isToMoveOneDirection)
            MoveOneDirection(this.transform, speed, side);
        else if (!notChangeScale && isToMoveOneDirection)
            MoveOneDirection(this.transform, speed, side, normalScale, trueIsLeft);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
//            collision.GetComponent<EnemyLife>().TakeDamage(MySkill.Damage);
            Destroy(this.gameObject);
        }

    }

    #endregion

    #region IEnumerator



    #endregion

    #region myMethodos

    public static void MoveOneDirection(Transform _myTransform, float _MySpeed, bool _MyDireciton)
    {
        _myTransform.Translate(_MyDireciton ? Vector3.right * Time.deltaTime * _MySpeed : Vector3.left * Time.deltaTime * _MySpeed);
    }

    public static void MoveOneDirection(Transform _myTransform, float _MySpeed, bool _MyDireciton, Vector3 _NormalScale, bool _trueIsLeft)
    {
        _myTransform.Translate(_MyDireciton ? Vector3.right * Time.deltaTime * _MySpeed : Vector3.left * Time.deltaTime * _MySpeed);
        
        if(!_trueIsLeft)  
            _myTransform.localScale = _MyDireciton ? _NormalScale : -_NormalScale;
        else
            _myTransform.localScale = _MyDireciton ? -_NormalScale : _NormalScale;
    }

    #endregion

}
