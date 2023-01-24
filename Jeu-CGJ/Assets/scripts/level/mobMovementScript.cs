using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobMovementScript : MonoBehaviour
{
    [SerializeField] private float speed;
    private Transform m_transform;
    public BoxCollider2D hitboxWall;
    void Awake() => m_transform = transform;
    void FixedUpdate() => m_transform.position += m_transform.TransformDirection(Vector3.left) * speed;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void Flip()
    {
        transform.eulerAngles += new Vector3(0, 180, 0);
    }



    


}
