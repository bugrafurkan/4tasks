using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPoint : MonoBehaviour
{
    float xRot, yRot = 0f;

    public Rigidbody ball;

    public float rotationSpeed = 5f;

    public float shootPower = 30f;

    public LineRenderer line;
    
    Vector3 startPosition;
    
    void Start(){
        startPosition = this.transform.position;
    }
   

    // Update is called once per frame
    void Update()
    {
        transform.position = ball.position;

        if (Input.GetMouseButton(0)){
            xRot += Input.GetAxis("Mouse X")*rotationSpeed;
            yRot += Input.GetAxis("Mouse Y")*rotationSpeed;
            if(yRot < -10f){
                yRot = -10f;
            }
             if(yRot > 30f){
                yRot = 30f;
            }
            transform.rotation = Quaternion.Euler(yRot, xRot, 0f);
            startPosition = transform.position;
            line.gameObject.SetActive(true);
            line.SetPosition(0, transform.position);
            line.SetPosition(1, transform.position + transform.forward * 4f);

        }
        
         if (Input.GetMouseButtonUp(0)){
             //mouseReleasePos.x = Input.GetAxis("Mouse X");
            Vector2 directionToEndPosition = startPosition - transform.position;
            float lengthVector = directionToEndPosition.SqrMagnitude();
             ball.velocity = transform.forward * lengthVector * shootPower;
             line.gameObject.SetActive(false);
         }


    }
}
