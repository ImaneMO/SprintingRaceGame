using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatforms : MonoBehaviour
{
    //this code dont work idkn why ?
    //private Vector3 positionA;
    //private Vector3 positionB;
    //private Vector3 nextPosition;

    //[SerializeField]
    //private float Vitesse;

    //[SerializeField]
    //private Transform childTronsform;

    //[SerializeField]
    //private Transform transformB;

    //void Start()
    //{
    //    positionA = childTronsform.localPosition;
    //    positionB = transformB.localPosition;
    //    nextPosition = positionB;
    //}

    //void Update()
    //{
    //    Move();    
    //}

    //private void Move ()
    //{
    //    childTronsform.localPosition = Vector3.MoveTowards(childTronsform.localPosition, nextPosition, Vitesse * Time.deltaTime);
    //    if (Vector3.Distance(childTronsform.localPosition , nextPosition) <= 0.1)
    //    {
    //        ChangeDestination();
    //    }
    //}

    //private void ChangeDestination ()
    //{
    //    nextPosition = nextPosition != positionA ? positionA : positionB;
    //}

    //lets try a new code ;)

    public Transform pos1, pos2;
    public float vitess;
    public Transform startPos;

    Vector3 nextPos;

    void Start()
    {
        nextPos = startPos.position;  
    }

    void Update()
    {
        if(transform.position == pos1.position)
        {
            nextPos = pos2.position;
        }
        if(transform.position == pos2.position)
        {
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, vitess * Time.deltaTime);
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawLine(pos1.position, pos2.position);
       
    }

}
