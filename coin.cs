using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        inventory inven = other.GetComponent<inventory>();

        if (inven != null)
        {
            inven.ambil();
            gameObject.SetActive(false);
        }

    }
}
