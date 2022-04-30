using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float dogDelay = 0;
    // Update is called once per frame
    void Update()
    {
        dogDelay += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& dogDelay >= 2)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            dogDelay = 0;
        }
    }
}
