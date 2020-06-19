using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Decisions/PatrolDecision")]
public class PatrolDecisions : Decision {
    //true : 무언가를 감지, false : 감지된게 없음
    public override bool Decide(StateController controller) {
        if (controller.GetType() == typeof(MinionStateController)) {
            var detector = ((MinionStateController) controller).detector;
            var detectedObjects = detector
                .ReturnDetectedObjects();
            return detectedObjects != null && detectedObjects.Count != 0;
        }
        return true;
    }
}