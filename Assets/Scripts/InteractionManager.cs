using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionManager : MonoBehaviour
{
    public Transform player;
    public float interactiveDistance;
    public UnityEvent functions;

    void Update()
    {
        float distance = Vector2.Distance(transform.position, player.position);

        if(distance <= interactiveDistance)
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                functions.Invoke();
                Destroy(gameObject);
            }
        }
    }
}
