using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleDivControl : MonoBehaviour
{
    public KeyCode key;
    public GameObject view;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(key))
        {
            Debug.Log("toggling simple div panel");
            if (view.activeSelf)
            {
                closeSimpleDivPanel();
            }

            else
            {
                openSimpleDivPanel();
            }
        }
    }

    // TODO IEnumerator animation/transisition effect
    void openSimpleDivPanel()
    {
        view.SetActive(true);
    }

    void closeSimpleDivPanel()
    {
        view.SetActive(false);
    }
}
