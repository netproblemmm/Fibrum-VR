using System.Collections;
using UnityEngine;


public class GameEnding : MonoBehaviour
{
    public GameObject player;
    public GameObject EndText;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            EndText.SetActive(true);
        }
    }

    void Start()
    {

    }

    void Update()
    {

    }
}
