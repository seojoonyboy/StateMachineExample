using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "PluggableAI/Actions/Chase")]
public class ChaseAction : Action {
    private StateController _controller;
    private float speed = 1.0f;
    public override void Act(StateController controller) {
        _controller = controller;
        Chase(controller);
    }

    public override void TimeReset(StateController controller) {
        
    }
    private void Chase(StateController controller) {
        if (controller.GetType() == typeof(MinionStateController)) {
            ((MinionStateController)controller).StartChasing();
        }
    }
}