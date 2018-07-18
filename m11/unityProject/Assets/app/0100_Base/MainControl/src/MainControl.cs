﻿using System;

public partial class MainControl  {
		
	// write your code 

	void br_BUT05(Action<bool> st)
    {
        if (!HasNextState())
        {
            var cur = MainStateEvent.Cur();
            if (cur!=null && cur.id == MainStateEventId.BUTTON && cur.name == "BUT05" )
            { 
                SetNextState(st);
            }
        }
    }

    void disp_error()
    {
        ErrorDlg.V.SetError("test");
    }

}
