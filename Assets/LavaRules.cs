using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaRules : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject selfObject;
    
    void Start()
    {
        selfObject = (GameObject)Resources.Load("Prefabs/lava");
    }
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log(collision.gameObject.ToString());
        if (collision.gameObject.ToString() == "Water(Clone) (UnityEngine.GameObject)")
        {
            Debug.Log("THINGS SHOULD HAPPEN NOW");
            Vector3 newBlockPosition = collision.gameObject.transform.position;
            collision.gameObject.SetActive(false);
            selfObject.SetActive(false);
            GameObject obsidian = (GameObject)Resources.Load("Prefabs/obsidian");
            Instantiate(obsidian, newBlockPosition, Quaternion.identity);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        //selfObject.SetActive(true) ;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
