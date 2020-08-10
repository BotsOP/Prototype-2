using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    int timesHit;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name != "Border")
        {
            if (timesHit == 0)
            {
                transform.Rotate(0, Random.Range(150, 210), 0);
                Destroy(other.gameObject);
            }
            else
            {
                transform.Rotate(0, Random.Range(150, 210), 0);
            }
            timesHit++;
            GameObject.Find("Text").GetComponent<ScoreBoard>().scoreBoardProgress(10);
        }

    }
}
