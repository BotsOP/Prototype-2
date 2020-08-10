using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Despawn : MonoBehaviour
{
    public ProgressBar progressBar;
    

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("should despawn");
        Destroy(other.gameObject);
        progressBar.GetComponent<ProgressBar>().IncrementProgress(0.1f);
        
    }
}
