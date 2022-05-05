using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickalbeObject : MonoBehaviour, IPickable
{
    [field: SerializeField]
    public bool KeepWorldPosition { get; private set; } = true;

    Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public GameObject PickUp()
    {
        if (rb != null)
            rb.isKinematic = true;

        return gameObject;
    }
}
