using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_player : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake������ִ����ϣ� ");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable������ִ����ϣ�");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start������ִ����ϣ�");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update������ִ����ϣ�");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate������ִ�У�");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate������ִ�У�");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable������ִ�У�");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDistroy������ִ�У�");
    }
}

