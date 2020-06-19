using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Detector : MonoBehaviour {
    protected Collider _collider;
    
    public UnityAction OnTriggerEntered;
    public UnityAction OnTriggerExited;
    public UnityAction OnTriggerStayed;
    private void Awake() {
        _collider = GetComponent<Collider>();
        Physics.IgnoreCollision(_collider, transform.root.GetComponent<Collider>());
    }

    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.layer != 9) __OnTriggerEnter(other);
    }

    protected virtual void __OnTriggerEnter(Collider other) {
        OnTriggerEntered?.Invoke();
    }

    private void OnTriggerExit(Collider other) {
        if(other.gameObject.layer != 9) __OnTriggerExit(other);
    }

    protected virtual void __OnTriggerExit(Collider other) {
        OnTriggerExited?.Invoke();
    }

    private void OnTriggerStay(Collider other) {
        if(other.gameObject.layer != 9) __OnTriggerStay(other);
    }

    protected virtual void __OnTriggerStay(Collider other) {
        OnTriggerStayed?.Invoke();
    }

    public virtual List<GameObject> ReturnDetectedObjects() {
        return null;
    }
}