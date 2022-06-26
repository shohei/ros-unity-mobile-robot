using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Std;

public class MySubscriber : MonoBehaviour
{
    ROSConnection ros;
    // Start is called before the first frame update
    void Start()
    {
        ros = ROSConnection.GetOrCreateInstance();
        ros.Subscribe<StringMsg>("my_topic",OnSubscribe);        
    }

    // Update is called once per frame
    void OnSubscribe(StringMsg msg)
    {
        Debug.Log("Subscribe : "+msg.data); 
    }
}
