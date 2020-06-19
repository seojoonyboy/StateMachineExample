using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/AttackDecision")]
public class AttackDecisions : Decision {
    
    //true : 공격범위까지 접근했는지?
    //false : continue
    public override bool Decide(StateController controller) {
        return true;
    }
}