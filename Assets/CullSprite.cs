using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cull : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject destroyObject;
    void OnBecameInvisible()
    {
        Destroy(destroyObject);
    }
}
