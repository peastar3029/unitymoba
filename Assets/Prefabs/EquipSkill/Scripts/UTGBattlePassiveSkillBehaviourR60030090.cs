﻿using UnityEngine;
using System.Collections;

public class UTGBattlePassiveSkillBehaviourR60030090 : NTGBattlePassiveSkillBehaviour
{
    public float pAmount;

    public override void Respawn()
    {
        base.Respawn();

        pAmount = this.param[0];
        owner.baseAttrs.PPenetrateRate += pAmount;
        owner.ApplyBaseAttrs();

        FXEA();
        FXEB();
    }

    public override void Notify(NTGBattlePassive.Event e, object param)
    {
        if (e == NTGBattlePassive.Event.PassiveAdd)
        {
            var p = (NTGBattlePassiveSkillBehaviour) param;
            shooter = p.shooter;

            if (p.param[0] > this.param[0])
            {
                owner.baseAttrs.PPenetrateRate -= pAmount;
                pAmount = p.param[0];
                owner.baseAttrs.PPenetrateRate += pAmount;
                owner.ApplyBaseAttrs();
            }
        }
        else if (e == NTGBattlePassive.Event.PassiveRemove)
        {
            owner.baseAttrs.PPenetrateRate -= pAmount;
            owner.ApplyBaseAttrs();

            Release();
        }
    }
}