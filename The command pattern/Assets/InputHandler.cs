using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
  [SerializeField] private GameObject actor;
  Animator anim;
  Command keyQ, keyW, keyE;
  // Start is called before the first frame update
  void Start()
  {
    keyQ = new PerformJump();
    keyW = new PerformPunch();
    keyE = new PerformKick();
    anim = actor.GetComponent<Animator>();
  }

  // Update is called once per frame
  void Update()
  {
    if (Input.GetKeyDown(KeyCode.Q))
    {
      keyQ.Execute(anim);
    }
    else if (Input.GetKeyDown(KeyCode.W))
    {
      keyW.Execute(anim);
    }
    else if (Input.GetKeyDown(KeyCode.E))
    {
      keyE.Execute(anim);
    }
  }
}
