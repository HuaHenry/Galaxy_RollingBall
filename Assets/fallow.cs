using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallow : MonoBehaviour
{
    public Transform t;    //定义了一个放风筝的人
    Vector3 o;             //定义风筝线
    // Start is called before the first frame update
    void Start()
    {
        o = transform.position - t.position;  //在游戏刚启动的时候确定风筝线的长度、方向等信息
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = t.position + o;  //让每时每刻风筝都被人和线拖着走
    }
}
