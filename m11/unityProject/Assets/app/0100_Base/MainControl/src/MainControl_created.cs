// psggConverterLib.dll converted from MainControl.xlsx. 
public partial class MainControl : StateManager {

    public void Start()
    {
        Goto(S_START);
    }


    /*
        S_START
        開始
    */
    void S_START(bool bFirst)
    {
        if (bFirst)
        {
        }
        if (!HasNextState())
        {
            SetNextState(S_WAIT_BUT);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_END
        終了
    */
    void S_END(bool bFirst)
    {
        if (bFirst)
        {
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_WAIT_BUT
        Wait for new button
    */
    void S_WAIT_BUT(bool bFirst)
    {
        if (bFirst)
        {
        }
        br_BUT05(S_DISPEROR);
        if (HasNextState())
        {
            GoNextState();
        }
    }
    /*
        S_DISPEROR
        Diplay Error
    */
    void S_DISPEROR(bool bFirst)
    {
        if (bFirst)
        {
            disp_error();
        }
        if (!HasNextState())
        {
            SetNextState(S_WAIT_BUT);
        }
        if (HasNextState())
        {
            GoNextState();
        }
    }

}

