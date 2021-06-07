using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(Collider))]
public class DragAndShoot : MonoBehaviour
{
    private Vector3 mousePressDownPos;
    private Vector3 mouseReleasePos;

    private Rigidbody rb;

    private bool isShoot;

    public LineRenderer line;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnMouseDown()
    {
        mousePressDownPos = Input.mousePosition;
        line.gameObject.SetActive(true);
        line.SetPosition(0, transform.position);
        line.SetPosition(1, transform.position + transform.forward * 4f);

    
    }

    private void OnMouseUp()
    {
        mouseReleasePos = Input.mousePosition;
        line.gameObject.SetActive(false);
        Shoot(mouseReleasePos-mousePressDownPos);
    }

    private float forceMultiplier = 3;
    void Shoot(Vector3 Force)
    {
        if(isShoot)    
            return;
        
        rb.AddForce(new Vector3(Force.x,1.0f,Force.y) * -forceMultiplier);
        isShoot = true;
    }
    
}