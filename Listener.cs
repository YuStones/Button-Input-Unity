using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour
{
    public GameObject objectToSpawn;
    public Vector3 position;
    public Quaternion rotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // Invoked when a line of data is received from the serial device.
    void OnMessageArrived(string msg)
    {
        if (msg != ""){
            Debug.Log(msg);
            if(int.Parse(msg) != 1110000){
                GameObject newObject = Instantiate(objectToSpawn, position, rotation);
            }
        }
    }

    // Invoked when a connect/disconnect event occurs. The parameter 'success'
    // will be 'true' upon connection, and 'false' upon disconnection or
    // failure to connect.
    void OnConnectionEvent(bool success)
    {
        if(success){
            Debug.Log("Success");
        }else{
            Debug.Log("Failed");
        }
    }
}
