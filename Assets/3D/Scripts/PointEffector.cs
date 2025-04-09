using System;
using UnityEngine;

public class PointEffector : MonoBehaviour
{
    [SerializeField, Range(-100, 100)] float force = 5;
    [SerializeField, Range(0, 5)] float radius = 2.5f;

    void Start()
    {
        
    }

    void Update()
    {
        gameObject.transform.localScale = new Vector3(radius * 2, radius * 2, radius * 2);
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Vector3 direction = other.transform.position - gameObject.transform.position;
            float strength = -(direction.magnitude / radius) + 1;
            if (strength > 0)
            {
                other.GetComponent<Rigidbody>().AddForce(direction.normalized * strength * force);
            }
        }
    }
}
