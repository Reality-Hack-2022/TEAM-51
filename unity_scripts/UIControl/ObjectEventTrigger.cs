using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

public class ObjectEventTrigger : MonoBehaviour
{
    
    public PlayableDirector playableDirector;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void AnimationStart()
    {
        Debug.Log("object event triggered");
        playableDirector.Play();
    }

}
