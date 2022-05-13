using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTrigger : MonoBehaviour
{
    private Animator animatorTest;

    // Start is called before the first frame update
    void Start()
    {
        animatorTest = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (animatorTest != null) //check if anim controller is attached
        {
            #region //forward
            if (Input.GetKeyDown(KeyCode.W)) //Z on fr
            {
                animatorTest.SetBool("Locomotion", true);
                animatorTest.SetTrigger("EmoteCancel"); //enable emote cancel + transition to locomotion
            }

            if (Input.GetKeyUp(KeyCode.W)) //Z on fr
            {
                if ((Input.GetKey(KeyCode.A) == false) && (Input.GetKey(KeyCode.D) == false)) //if Q / D is not being held down
                {
                    animatorTest.SetBool("Locomotion", false);
                }
            }
            #endregion

            #region //left
            if (Input.GetKeyDown(KeyCode.A)) //Q on fr
            {
                animatorTest.SetBool("Locomotion", true);
                animatorTest.SetTrigger("EmoteCancel");
            }

            if (Input.GetKeyUp(KeyCode.A)) //Q on fr
            {
                if(Input.GetKey(KeyCode.W) == false) //if Z is not being held down
                {
                    animatorTest.SetBool("Locomotion", false);
                }
            }
            #endregion

            #region //right
            if (Input.GetKeyDown(KeyCode.D))
            {
                animatorTest.SetBool("Locomotion", true);
                animatorTest.SetTrigger("EmoteCancel");
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                if (Input.GetKey(KeyCode.W) == false) //if Z is not being held down
                {
                    animatorTest.SetBool("Locomotion", false);
                }
            }
            #endregion

            if (Input.GetKeyDown(KeyCode.Q)) //A on fr
            {
                animatorTest.SetTrigger("Attack");
            }

            if(Input.GetKeyDown(KeyCode.E))
            {
                animatorTest.SetTrigger("Emote");
            }
        }
    }
}
