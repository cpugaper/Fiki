using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LevelTransitionController.instance.StartTransition(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private IEnumerator Transition(float time)
    {
        yield return new WaitForSeconds(time);
    }

}
