using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laserScript : MonoBehaviour
{
    [SerializeField] private float defRayDistance = 100;
    public Transform laserPoint;
    public LineRenderer lineRenderer;
    Transform m_transform; 

    // Start is called before the first frame update
    void Start()
    {
        m_transform = GetComponent<Transform>(); 
    }

    // Update is called once per frame
    void Update()
    {
        ShootLaser();
    }

    void ShootLaser()
    {
        if(Physics2D.Raycast(m_transform.position, Vector2.down))
        {

            RaycastHit2D _hit = Physics2D.Raycast(laserPoint.position, Vector2.down);
            Draw2DRay(laserPoint.position, _hit.point);
            
        }
        else 
        {
            Draw2DRay(laserPoint.position, Vector2.down * defRayDistance);
        }
    }

    void Draw2DRay(Vector2 startPos, Vector2 endPos)
    {
        lineRenderer.SetPosition(0, startPos);
        lineRenderer.SetPosition(1, endPos);
    }
}
