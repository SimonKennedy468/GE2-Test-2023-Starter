using System.Collections;
using UnityEngine;

public class testCollide : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
    }
}