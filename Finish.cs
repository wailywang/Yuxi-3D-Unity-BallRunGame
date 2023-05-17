using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("Panel").gameObject.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        GameObject canvas = GameObject.Find("Canvas");
        canvas.transform.Find("Panel").gameObject.SetActive(true);
    }
  
}
