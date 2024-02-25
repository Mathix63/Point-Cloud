using UnityEngine;

public class Around : MonoBehaviour {

    public GameObject centre;

    public Vector3 axe;

    public float angle;

    void Update()
    {
        transform.RotateAround(centre.transform.position, axe, angle*Time.deltaTime);
    }
}
