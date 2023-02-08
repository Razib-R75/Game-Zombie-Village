using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultState : ActionBaseState
{
    public float scrollDirection;
    public override void EnterState(ActionStateManager actions)
    {
        
    }

    public override void UpdateState(ActionStateManager actions)
    {
        actions.rHandAim.weight = Mathf.Lerp(actions.rHandAim.weight, 1, 10 * Time.deltaTime);
        if(actions.lHandIK.weight==0)actions.lHandIK.weight = 1;

        if (Input.GetKeyDown(KeyCode.R) && CanReload(actions))
        {
            actions.SwitchState(actions.Reload);
        }
        else if (Input.mouseScrollDelta.y != 0)
        {
            scrollDirection = Input.mouseScrollDelta.y;
            actions.SwitchState(actions.Swap);
        }
    }

    bool CanReload(ActionStateManager action)
    {
        if (action.ammo.currentAmmo == action.ammo.clipSize) return false;
        else if (action.ammo.extraAmmo == 0) return false;
        else return true;
    }
}
