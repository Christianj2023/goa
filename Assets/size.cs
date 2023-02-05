using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class size : MonoBehaviour
{
	Vector3 temp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
	temp = transform.localScale;
	temp.x += Time.deltaTime;
        transform.localScale = temp;

}
}
