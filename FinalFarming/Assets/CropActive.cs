using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CropActive : MonoBehaviour
{
    public GameObject CropLand;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnButtonP()
    {
        Instantiate(CropLand,transform.position,transform.rotation);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
