using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public GameObject player;
    // public float speed;
    
    [SerializeField] private float rotationSpeed = 10f;
    [SerializeField] private Transform rotateAround;
    
    private float distance;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, player.transform.position);
        Vector2 direction = player.transform.position - transform.position;
       direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        float rotspeed = rotationSpeed * distance;
        
  
    // transform.position = Vector2.MoveTowards(this.transform.position, player.transform.position, speed * Time.deltaTime);
    transform.rotation = Quaternion.Euler(Vector3.forward * angle);
    //this.transform.RotateAround(rotateAround.position, Vector3.forward, rotationSpeed * Time.deltaTime);
    this.transform.RotateAround(rotateAround.position, Vector3.forward, rotspeed * Time.deltaTime);


    }
}