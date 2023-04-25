using System.Collections;
using UnityEngine;

public class testCollide : MonoBehaviour
{
    public GameObject camera;
    public GameObject lookTarget;
    public Vector3 lookPoint;
    public bool isCollided = false;
    public GameObject target;
    public GameObject head;
    public Vector3 dir;

    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(isCollided == true)
        {
            //lookPoint = head.transform.position - lookTarget.transform.position;
            camera.transform.LookAt(lookTarget.transform);
            
            camera.transform.parent = head.transform;
        }

        if (Input.GetKey(KeyCode.Z))
        {
            isCollided = false;
            //in update method, so being activated while z is held, not pressed, meaning user cant controll boid after leaving
            camera.AddComponent<FPSController>();
            camera.transform.parent = null;


            Destroy(head.GetComponent<boidController>());


        }
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "boidTargetCollider")
        {
            Debug.Log("controlling boid");
            camera.transform.position = other.transform.position;
            target = other.gameObject;
            //this.transform.position = other.transform.position;
            head.AddComponent<boidController>();
            isCollided = true;

            
            
            Destroy(camera.GetComponent<FPSController>());

        }
        
    }
}
