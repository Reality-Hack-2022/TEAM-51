using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject camPosition;

    static GameObject l;

    private void OnEnable()
    {

        if (l == null)
        {
            l = this.gameObject;
            //Debug.Log("Initializing permanent object " + this.gameObject.name);
        }
        else
            Destroy(this.gameObject);

        DontDestroyOnLoad(this.gameObject);
    }

    // define my camera and target moving destination

    void Start()
    {
        // EventManager.Instance.AddListener<SceneTransites>(CameraMove);
    }

    void Update()
    {
 
    }

    private void CameraMove(){
        transform.position = camPosition.transform.position;
        transform.rotation = camPosition.transform.rotation;
    }

}
