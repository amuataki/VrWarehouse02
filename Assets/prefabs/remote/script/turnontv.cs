using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class turnontv : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   public void Tvonoff()
    {
        XRRayInteractor xRRayInteractor = GetComponent<XRRayInteractor>();
        bool somethinghit;
        somethinghit = xRRayInteractor.TryGetCurrent3DRaycastHit(out RaycastHit raycastHit);
        if(somethinghit == true) 
        { Debug.Log(raycastHit.transform.gameObject.name); }

            Debug.Log("Hey");
    }
}
