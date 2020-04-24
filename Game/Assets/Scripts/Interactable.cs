using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Interactable : MonoBehaviour
{
    public Hand m_ActiveHand = null;
    public GameObject Effect;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (m_ActiveHand != null)
        {
            Effect.SetActive(true);
        }
        else
        {
            Effect.SetActive(false);
        }
    }
}
