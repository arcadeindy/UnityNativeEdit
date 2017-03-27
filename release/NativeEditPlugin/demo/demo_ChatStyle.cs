using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Collections;

public class demo_ChatStyle : MonoBehaviour
{
	public Text log;
	public NativeEditBox edit;

	public void OnEditValugChanged (string str)
	{
		log.text += string.Format ("{0}\n", str);
	}

	public void OnEditEnded (string str)
	{
		log.text += string.Format ("<color=cyan>[OnEditEnded]</color> {0}\n", str);
	}

	public void OnClick_SetFocus (bool focus)
	{
		edit.SetFocus (focus);
	}

	public void OnReturnPressed ()
	{
		log.text += string.Format ("<color=orange>[OnReturnPressed]</color> {0}\n", edit.text);
	}

	public void OnClick_ClearLog ()
	{
		log.text = "";
	}

	public void OnClick_Submit ()
	{
		log.text += string.Format ("<color=red>[OnSubmit]</color> {0}\n", edit.text);
		edit.SetFocus (false);
		edit.text = "";
	}

}
