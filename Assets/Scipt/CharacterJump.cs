 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartJumping()
    {
        transform.LeanMoveLocal(new Vector2(587, 0), 1) ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
