using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class inventory : MonoBehaviour
{
    public int coin { get; private set; }

    public UnityEvent<inventory> Onambil;

    public void ambil()
    {
        coin++;
        Onambil.Invoke(this);
    }

}
