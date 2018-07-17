using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIControl : MonoBehaviour {

    [HideInInspector]
    public UIControlCompo m_tc;

	// Use this for initialization
	IEnumerator Start () {

        Debug.Log("Waiting 2 sec");

        yield return new WaitForSeconds(2);

        Debug.Log("..Start !");

        m_tc = GetComponent<UIControlCompo>();
        m_tc.SetTarget_TemplateAndStart();

        while(true)
        {
            if (m_tc.IsEnd()) break;

            yield return null;
        }

        Debug.Log("..END !!");
	}
	
}
