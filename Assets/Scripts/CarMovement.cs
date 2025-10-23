using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovement : MonoBehaviour
{
    // Start is called before the first frame update

    // Variables
    public float speed;
    // benefits of using this. instead of declaring variable
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position += transform.right * speed * Time.deltaTime;
    }
    

}
