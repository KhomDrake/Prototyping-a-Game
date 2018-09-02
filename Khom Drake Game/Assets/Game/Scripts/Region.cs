using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Region : MonoBehaviour {

	#region Attributes

	#endregion

	#region GetAndSetAttributes

	#endregion

	#region IEnumerator

	#endregion

	#region Unity Methodos

	#endregion

	#region My Methodos

	#endregion
	
	#region static Stuff

	private static List<KeyCode> keysCode = new List<KeyCode>()
	{KeyCode.A, KeyCode.B, KeyCode.C, KeyCode.D, KeyCode.E, KeyCode.F, KeyCode.G, KeyCode.H, KeyCode.I, KeyCode.J, KeyCode.K
	, KeyCode.L, KeyCode.M, KeyCode.N, KeyCode.O, KeyCode.P, KeyCode.Q, KeyCode.R, KeyCode.S, KeyCode.T, KeyCode.U, KeyCode.V
	, KeyCode.W, KeyCode.X, KeyCode.Y, KeyCode.Z, KeyCode.Alpha0, KeyCode.Alpha1, KeyCode.Alpha2, KeyCode.Alpha3, KeyCode.Alpha4, KeyCode.Alpha5, KeyCode.Alpha6
	, KeyCode.Alpha7, KeyCode.Alpha8, KeyCode.Alpha9, KeyCode.Backspace, KeyCode.Backslash, KeyCode.LeftAlt, KeyCode.RightAlt, KeyCode.LeftControl
	, KeyCode.RightControl, KeyCode.Delete, KeyCode.UpArrow, KeyCode.DownArrow, KeyCode.LeftArrow, KeyCode.RightArrow, KeyCode.Colon, 
	KeyCode.Comma, KeyCode.F1, KeyCode.F2, KeyCode.F3, KeyCode.F4, KeyCode.F5, KeyCode.F6, KeyCode.F7, KeyCode.F8, KeyCode.F9, KeyCode.F10, KeyCode.F11, KeyCode.F12};
	private static List<string> keysString = new List<string>()
	{"A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z"
	, "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "BackSpace", "/", "LeftAlt", "RightAlt", "LeftCrtl", "RightCrtl", "delete"
	, "UP", "DOWN", "LEFT", "RIGHT", ";", ",", "F1", "F2", "F3", "F4", "F5", "F6", "F7", "F8", "F9", "F10", "F11", "F12"};

	public static string KeyCodeToString(KeyCode key)
	{
		for(int i = 0; i < keysCode.Count; i++)
		{
			if(keysCode[i] == key)
				return keysString[i];
		}
		return "";
	}

	public static KeyCode StringToKeyCode(string s)
	{
		for(int i = 0; i < keysString.Count; i++)
		{
			if(keysString[i] == s)
				return keysCode[i];
		}
		return KeyCode.None;
	}


	#endregion


}
