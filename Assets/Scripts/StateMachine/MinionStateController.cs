using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinionStateController : StateController {
    public MinionDetector detector;
    List<GameObject> detectedTargets;

    private bool isChasing = false;
    private float Speed = 2.0f;
    private void Update() {
        if (isChasing) {
            if (detectedTargets.Count > 0) {
                transform.position = Vector3.MoveTowards(
                    transform.position, 
                    detectedTargets[0].transform.position,
                    Speed * Time.deltaTime);
            }
            else isChasing = false;
        }
    }

    public void AddTarget(GameObject target) {
        if (detectedTargets == null) detectedTargets = new List<GameObject>();
        detectedTargets.Add(target);
    }

    public void RemoveTarget(GameObject target) {
        if(detectedTargets == null) return;
        detectedTargets.Remove(target);
    }

    public List<GameObject> GetTargets() {
        return detectedTargets;
    }

    public void StartChasing() {
        isChasing = true;
    }
}