using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurveDrawing : MonoBehaviour {

    public float minimum = -5.0F;
    public float maximum = 5.0F;
    static float t = 0.0f;

    public GameObject center;

    public GameObject point0;   
    public GameObject point1;
    public GameObject point2;
    public GameObject point3;

    public GameObject lerpPointA;
    public GameObject lerpPointB;
    public GameObject lerpPointC;
    public GameObject lerpPointD;
    public GameObject lerpPointE;

    public GameObject drawingPointF;

    private float StartTime;
    
        // Use this for initialization
    void Start ()
    {
        lerpPointA.transform.position = point0.transform.position;
        lerpPointB.transform.position = point1.transform.position;
        lerpPointC.transform.position = point2.transform.position;
        lerpPointD.transform.position = point0.transform.position;
        lerpPointE.transform.position = point1.transform.position;

        drawingPointF.transform.position = point0.transform.position;

        StartTime = Time.time;

    }


	    // Update is called once per frame
	void Update () {
        //Lerping only single float
        //lerpPointA.transform.position = new Vector3(Mathf.Lerp(minimum, maximum, t), 0, 0); 
        lerpPointA.transform.position = Vector3.Lerp(point0.transform.position, point1.transform.position, t);
        lerpPointB.transform.position = Vector3.Lerp(point1.transform.position, point2.transform.position, t);
        lerpPointC.transform.position = Vector3.Lerp(point2.transform.position, point3.transform.position, t);
        lerpPointD.transform.position = Vector3.Lerp(lerpPointA.transform.position, lerpPointB.transform.position, t);
        lerpPointE.transform.position = Vector3.Lerp(lerpPointB.transform.position, lerpPointC.transform.position, t);

        drawingPointF.transform.position = Vector3.Lerp(lerpPointD.transform.position, lerpPointE.transform.position, t);


        t += 0.1f * Time.deltaTime;

        //Animation restart condition after it's conpleted
        if (t > 10.0f)
        {
            /* Folloing commented code is to "Reverse" the animation once completed
            //float temp = maximum;
            // maximum = minimum;
            // minimum = temp;
            // center.transform.Rotate(Vector3.forward, 180.0f);
            //center.transform.position = new Vector3(0f, -10f, 0f);
            */
            t = 0.0f;
        }
    
    }




}
