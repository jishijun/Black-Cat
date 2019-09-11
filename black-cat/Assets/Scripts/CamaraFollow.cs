using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public GameObject player;  //主角
    public float speed;  //相机跟随速度

    public float minPosy;  //相机不超过背景边界允许的最小值
    public float maxPosy;  //相机不超过背景边界允许的最大值

    void Update()
    {
        FixCameraPos();
    }

    void FixCameraPos()
    {
        float pPosY = player.transform.position.y;  //主角 y轴方向 时实坐标值
        float cPosY = transform.position.y;//相机 y轴方向 时实坐标值
        float pPosX = player.transform.position.x;  //主角 x轴方向 时实坐标值
        float cPosX = transform.position.x;//相机 x轴方向 时实坐标值
        if (pPosY - cPosY > 3)    // 并不是死死地跟随，是相机和主角之间距离超过某个值时才跟随
        {
            transform.position = new Vector3(transform.position.y, cPosY+speed, transform.position.z);
        }
        if (pPosY - cPosY < -3)
        {
            transform.position = new Vector3(transform.position.z, cPosY - speed, transform.position.z);
        }
        if (pPosX - cPosX > 3)    // 并不是死死地跟随，是相机和主角之间距离超过某个值时才跟随
        {
            transform.position = new Vector3(cPosX + speed, transform.position.y, transform.position.z);
        }
        if (pPosX - cPosX < -3)
        {
            transform.position = new Vector3(cPosX - speed, transform.position.y, transform.position.z);
        }
        float realPosX = Mathf.Clamp(transform.position.x, minPosy, maxPosy); // 相机X轴方向 限制移动区间，防止超过背景边界
        transform.position = new Vector3(realPosX, transform.position.y, transform.position.z);
    }
}

