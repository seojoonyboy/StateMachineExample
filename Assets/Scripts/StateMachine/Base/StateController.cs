using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StateController : MonoBehaviour {
    public State currentState;

    public List<State> allStates;

    private bool aiActive;

    private IEnumerator coroutine;
    public virtual void Start() {
        currentState = allStates[0];

        coroutine = CheckState();
        StartCoroutine(coroutine);
    }

    IEnumerator CheckState() {
        while (true) {
            currentState.UpdateState(this);
            yield return new WaitForSeconds(3.0f);
        }
    }

    void OnDrawGizmos() {
        //if (currentState != null && eyes != null) {
        //    Gizmos.color = currentState.sceneGizmoColor;
        //    Gizmos.DrawWireSphere(eyes.position, enemyStats.lookSphereCastRadius);
        //}
    }

    public void TransitionToState(State state) {
        if (currentState != state) {
            currentState = state;
            currentState.UpdateState(this);
        }
    }
}