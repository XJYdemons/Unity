using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_player : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log("Awake命令已执行完毕！ ");
    }

    private void OnEnable()
    {
        Debug.Log("OnEnable命令已执行完毕！");
    }
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start命令已执行完毕！");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update命令已执行完毕！");
    }

    private void LateUpdate()
    {
        Debug.Log("LateUpdate命令已执行！");
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate命令已执行！");
    }
    private void OnDisable()
    {
        Debug.Log("OnDisable命令已执行！");
    }
    private void OnDestroy()
    {
        Debug.Log("OnDistroy命令已执行！");
    }
}

