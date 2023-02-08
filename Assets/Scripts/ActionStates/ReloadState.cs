using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReloadState : ActionBaseState
{
    public override void EnterState(ActionStateManager actions)
    {
        actions.rHandAim.weight = 0;
        actions.lHandIK.weight = 0;
        actions.anim.SetTrigger("Reload");
    }

    public override void UpdateState(ActionStateManager actions)
    {

    }
}
