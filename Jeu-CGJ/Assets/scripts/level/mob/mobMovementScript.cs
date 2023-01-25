using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mobMovementScript : MonoBehaviour
{
    [SerializeField] public float speed;
    private Transform m_transform;
    public BoxCollider2D hitboxWall;
    void Awake() => m_transform = transform;
    void FixedUpdate() => m_transform.position += m_transform.TransformDirection(Vector3.left) * speed;
    public bool isFlipped;

    public Animator anim;
    
    // Start is called before the first frame update
    void Start()
    {
        if(isFlipped)
        {
            Flip();
        }
    }

    // Update is called once per frame
    void Update()
    {
       if(EventManager.levelStarted)
       {
            anim.SetBool("started",true);
       }
    }

    public int front = -1;
    public void Flip()
    {
    
        transform.eulerAngles += new Vector3(0, 180, 0);
        front *= -1;
        transform.GetChild(1).transform.localPosition = new Vector3(0, 0, front);
        

        //chope l'enfant "inFrontOfBlock"
        //transform.GetChild(2).transform.position = new Vector3(transform.GetChild(2).transform.position.x,transform.GetChild(2).transform.position.y,transform.GetChild(2).transform.position.z*-1);
       
    
 }



    


}
