using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
      Animator _doorAnim;
      private void OnTriggerEnter(Collider other)
      {
        _doorAnim.SetBool("Opening", true);
      }
    
  //  private void OnTriggerExit(Collider other)
   // {
     //   _doorAnim.SetBool("isOpening", false);
   // }


    void Start()
    {
        _doorAnim = this.transform.parent.GetComponent<Animator>();
    }

   
}
