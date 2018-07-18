using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErrorDlg : MonoBehaviour {

    const string errorpanelname = "errorpanel";

    public static ErrorDlg V;

    public GameObject m_errorDlgUI;
    public GameObject m_canvas;
    public GameObject m_template;

    public void Start()
    {
        V = this;
    }

    public void Update()
    {
        if (m_canvas.transform.childCount==1)
        {
            var target = m_canvas.transform.GetChild(0);
            if (target.name == errorpanelname )
            {
                GameObject.DestroyImmediate(target.gameObject);
            }
        }
    }

    public void SetError(string msg)
    {
        if (m_canvas.transform.childCount==0)
        {
            var panel = UGuiUtil.FindAndClone(m_template.transform,"Panel",m_canvas);
            panel.name = errorpanelname;
            UGuiUtil.SetPivot(panel,UIANCHORPOS.MC);
            UGuiUtil.SetAnchor(panel,UIANCHORPOS.MC);
            UGuiUtil.SetSize(panel,ScreenDef.reference_width,ScreenDef.reference_height_fix);
            UGuiUtil.SetPos(panel,0,0);
        }

        var clone = (GameObject)GameObject.Instantiate(m_errorDlgUI);
        clone.transform.SetParent(m_canvas.transform);

        UGuiUtil.SetPos(clone,0,0);
        //clone.transform.localPosition = VectorUtil.Affect_Z(clone.transform.localPosition,0);

    }


    [ContextMenu("TEST")]
    void Test()
    {
        SetError("!!!");
    }

}
