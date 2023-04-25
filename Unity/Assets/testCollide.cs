using System.Collections;
using UnityEngine;

public class testCollide : MonoBehaviour
{
    public GameObject camera;
    public bool isCollided = false;
    public GameObject target;
    public GameObject head;
    public Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCollided == true)
        {
            camera.transform.LookAt(head.transform);
            dir = target.transform.position - camera.transform.position;
            camera.transform.Translate(dir);
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("entered");
        target = other.gameObject; 
        //this.transform.position = other.transform.position;
        isCollided = true;
    }
}
