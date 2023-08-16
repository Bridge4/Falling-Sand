using System.Collections;
using System.Collections.Generic;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.U2D;

public class Place_Object : MonoBehaviour
{

    GameObject spawnObject;
    
    // Start is called before the first frame update
    void Start()
    {
        spawnObject = (GameObject)Resources.Load("Prefabs/Water");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetMouseButton(0))
        {
            spawnObject.SetActive(true);
            Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            //Vector3 offset = new Vector3(0, 0, -10);
            
            Instantiate(spawnObject, pos, Quaternion.identity);
        }
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            spawnObject = (GameObject)Resources.Load("Prefabs/Water");
            Debug.Log(spawnObject);
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            spawnObject = (GameObject)Resources.Load("Prefabs/Lava");
            Debug.Log(spawnObject);
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            //spawnObject = (GameObject)Resources.Load("Assets / Lava.prefab", typeof(GameObject));
            Debug.Log((GameObject)Resources.Load("Prefabs / Water"));
        }


    }
}
