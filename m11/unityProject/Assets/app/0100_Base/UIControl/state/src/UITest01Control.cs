using System;
using UnityEngine;

public partial class UITest01Control {
	
    //UIControl m_uic { get { return UIControl.V; } }
    Canvas m_target;
    Canvas m_template;

    GameObject m_parent;
    GameObject m_latest;
    RectTransform m_latest_rt;

    public void SetTargetAndTemplate(Canvas target, Canvas template)
    {
        m_target   = target;
        m_template = template;
    }

    public bool IsEnd()
    {
        return CheckState(S_END);
    }

    void setup()
    {
        m_parent = m_target.gameObject;
    }

    void create(string parts, string reff)
    {
        var clone = UGuiUtil.FindAndClone(m_template.transform,reff,m_parent);
        if (clone!=null)
        {
            clone.name = parts;
            m_latest = clone;
            m_latest_rt = m_latest.GetComponent<RectTransform>();
        }
        else
        {
            throw new SystemException("Unexpected! {E8337688-F0C2-4506-9DE0-2CD12C0698B9}");
        }
        //var find = HierarchyUtility.FindGameObject(m_template.GetComponent<Transform>(),reff);
        //if (find!=null)
        //{
        //    var clone = (GameObject)GameObject.Instantiate( find );
        //    clone.transform.SetParent(m_parent.transform);
        //    clone.name = parts;

        //    m_latest = clone;
        //    m_latest_rt = m_latest.GetComponent<RectTransform>();
        //}
        //else
        //{
        //    throw new SystemException("Unexpected! {E8337688-F0C2-4506-9DE0-2CD12C0698B9}");
        //}
    }

    void set_pos(float x, float y) {
        if (m_latest_rt==null) throw new SystemException("Unexpected! {B33DAE1A-FAA5-41EF-B45C-FEC61B0EA1DB}");
        //m_latest_rt.anchoredPosition = new Vector3(x,y);

        UGuiUtil.SetPos(m_latest_rt,x,y);
    }

    void set_size(float w, float h) {
        if (m_latest_rt==null) throw new SystemException("Unexpected! {27138646-8AC1-491B-9F0F-63EA9DC8AEEA}");

        //m_latest_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, w);
        //m_latest_rt.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, h);

        UGuiUtil.SetSize(m_latest_rt,w,h);
    }

    void set_anchor(string a) {
        if (m_latest_rt==null) throw new SystemException("Unexpected! {C1BAF5D5-5453-41C9-80D5-333D7F7FCD4A}");
        UGuiUtil.SetAnchor(m_latest_rt,a);
    }

    void set_pivot(string a) {
        if (m_latest_rt==null) throw new SystemException("Unexpected! {C67C7683-FBE7-46F5-A3CF-41A19B94490E}");
        UGuiUtil.SetPivot(m_latest_rt,a);
    }

    void set_text(string s) {
        //if (m_latest_rt==null) throw new SystemException("Unexpected! {C67C7683-FBE7-46F5-A3CF-41A19B94490E}");

        //UnityEngine.UI.Text tc = HierarchyUtility.FindComponentInChildren<UnityEngine.UI.Text>(m_latest.transform);
        //tc.text = s;

        UGuiUtil.SetText(m_latest_rt,s);
    }


    bool _get_anchorpos(string anchorstr, out float x, out float y)
    {
        x = 0f;
        y = 0f;
        var pos_or_null = EnumUtil.TryParse(typeof(UIANCHORPOS),anchorstr);
        if (pos_or_null == null) return false;
        var pos = (UIANCHORPOS)pos_or_null;

        if (pos == UIANCHORPOS.TL) { x = 0;        y = 1;    }
        if (pos == UIANCHORPOS.TC) { x = 0.5f;     y = 1;    }
        if (pos == UIANCHORPOS.TR) { x = 1;        y = 1;    }
                                                           
        if (pos == UIANCHORPOS.ML) { x = 0;        y = 0.5f; }
        if (pos == UIANCHORPOS.MC) { x = 0.5f;     y = 0.5f; }
        if (pos == UIANCHORPOS.MR) { x = 1;        y = 0.5f; }

        if (pos == UIANCHORPOS.BL) { x = 0;        y = 0f;   }
        if (pos == UIANCHORPOS.BC) { x = 0.5f;     y = 0f;   }
        if (pos == UIANCHORPOS.BR) { x = 1;        y = 0f;   }

        return true;
    }

    void set_parent()
    {
        m_parent = m_latest;
    }

}
