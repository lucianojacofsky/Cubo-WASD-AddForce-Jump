using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    [SerializeField] GameObject UIElements;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTrriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            UIElements.SetActive(true);

        }
    }
    void OnTrriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("NPC"))
        {
            UIElements.SetActive(false);
        }
    }
}
