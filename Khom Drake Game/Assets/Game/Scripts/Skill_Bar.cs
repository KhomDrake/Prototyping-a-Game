using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Skill_Bar : MonoBehaviour, IDropHandler
{

    #region Attributes

	[SerializeField] private Text key;
	[SerializeField] private Image skillImg;
	[SerializeField] private KeyCode keyCode;

    #endregion

    #region GetAndSetAttributes

    #endregion

    #region IEnumerator

    #endregion

    #region Unity Methodos

	void Awake()
	{
		key = GetComponentInChildren<Text>();
		skillImg = GetComponentsInChildren<Image>()[1];
		key.text = Region.KeyCodeToString(keyCode);
	}

	public void OnDrop(PointerEventData eventData)
    {
       
    }

    #endregion

    #region My Methodos

	public void ChooseSkill()
	{

	}

	public void setSkill()
	{

	}


    #endregion

	
}
