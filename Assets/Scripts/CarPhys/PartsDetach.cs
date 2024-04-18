using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartsDetach : MonoBehaviour
{
    public Collider BreakingCollider;
    public Rigidbody SelfRigid;
    public Collider TempCollider;
    void Start()
    {
        SelfRigid.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider other)
    {
        SelfRigid.isKinematic = false;
        TempCollider.enabled = false;
    }
}
