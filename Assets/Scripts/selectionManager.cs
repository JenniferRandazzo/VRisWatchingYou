using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectionManager : MonoBehaviour
{
    [SerializeField] private Material highlightMaterial;
    [SerializeField] private Material defaultMaterial;
    [SerializeField] private string selectableTag = "Selectable";

    private Transform _selection;

    public Camera mainCamera;


    // Update is called once per frame
    private void Start()
    {
        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>() as Camera;
    }
    void Update()
    {
        if (_selection != null) {
            var selectionRenderer = _selection.GetComponent<Renderer>();
            selectionRenderer.material = defaultMaterial;
            _selection = null;
        }

        var ray = mainCamera.ScreenPointToRay(new Vector2(Screen.height/2, Screen.width/2));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            var selection = hit.transform;
            if (selection.CompareTag(selectableTag))
            {

                var selectionRenderer = selection.GetComponent<Renderer>();
                if (selectionRenderer != null)
                {

                    selectionRenderer.material = highlightMaterial;
                    Debug.Log("it works");
                    GameObject.Find("timerBar").GetComponent<Timer>().looking = true;

                }
                

                _selection = selection;
            }
            else
            {
                //alarm rings
                Debug.Log("you are looking away");
                GameObject.Find("timerBar").GetComponent<Timer>().looking = false;
            }
        }
    }
}
