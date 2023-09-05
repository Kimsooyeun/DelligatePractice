using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Android;

public class Player01 : TestBase
{
    Item item;
    public Action<int> GetItem;
    public Action MakeFurnitual;


    protected override void Awake()
    {
        base.Awake();
        item = FindObjectOfType<Item>();
    }
    protected override void OnEnable()
    {
        base.OnEnable();
        item.FailMake += IsFail;
        item.SuccessMake += IsSuccess;
    }

    void IsFail(int x)
    {
        Debug.Log($"{x}개가 부족합니다.");
    }
    void IsSuccess()
    {
        Debug.Log("Make");
    }

    protected override void Test1(InputAction.CallbackContext _)
    {
        GetItem(1);

    }

    protected override void Test2(InputAction.CallbackContext _)
    {
        MakeFurnitual();
    }
}
