using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallBreak : MonoBehaviour
{
    public float wallHealth;
    public float totalWallHealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    if (collision.collider.tag == "Player")
    //    {
    //        if (Input.GetKeyDown(KeyCode.W))
    //        {
    //            takeDammage();
    //        }
    //    }
    //}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            takeDammage();
        }
    }

    void takeDammage()
    {
        if (wallHealth > 0)
        {
            wallHealth--;
            transform.localScale = new Vector3(0.5f, wallHealth, 0.5f);
        }
    }
}
