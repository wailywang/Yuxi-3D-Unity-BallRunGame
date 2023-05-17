using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    // Start is called before the first frame update
    bool lift = false;

    // Update is called once per frame
    private void Update()
    {
        if (!lift) return;
        transform.parent.Translate(0, 10 * Time.deltaTime, 0);
    }
    private void OnTriggerEnter(Collider other)
    {
        lift = true;
    }
}
