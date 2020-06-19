using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionDetector : Detector {
    [SerializeField] MinionStateController stateController;
    
    protected override void __OnTriggerEnter(Collider other) {
        base.__OnTriggerEnter(other);
        stateController.AddTarget(other.gameObject);
    }

    protected override void __OnTriggerStay(Collider other) {
        base.__OnTriggerStay(other);
    }

    protected override void __OnTriggerExit(Collider other) {
        base.__OnTriggerExit(other);
        stateController.RemoveTarget(other.gameObject);
    }

    public override List<GameObject> ReturnDetectedObjects() {
        return stateController.GetTargets();
    }

    //TODO 유닛이 Destroy된 경우
}