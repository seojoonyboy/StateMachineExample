using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/ChaseDecision")]
public class ChaseDecisions : Decision {
    public override bool Decide(StateController controller) {
        return true;
    }
}