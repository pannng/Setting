using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Taskinfo : MonoBehaviour {

    public Text TaskNum;
    public Text Task;

    public GameObject Big;

    public AudioClip clip;

    public void Task1 () {
        TaskNum.text = "Task 1  选择";
        Task.text = "\n1）请选中红色背包\n\n" +
            "2）请选中绿色鞋子\n\n\n" +
            "选中成功时，目标物体将会高亮";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task2()
    {
        Big.SetActive(true);
        TaskNum.text = "Task 2  缩放";
        Task.text = "\n1）请将红色背包放大2倍\n\n" +
            "2）请将红色背包还原至原来尺寸\n\n\n" +
            "缩放具体的目标大小将由黄色框体提示\n"+
            "缩放成功时，您将听到提示音";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task3()
    {
        TaskNum.text = "Task 3  旋转";
        Task.text = "\n1）请将红色背包旋转180度，使背包背面向您\n\n" +
            "2）请将红色背包旋转90度，使背包的侧面向您\n\n\n" +
            "旋转成功时，您将听到提示音";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task4()
    {
        TaskNum.text = "Task 4  查看详情";
        Task.text = "\n\n请打开详情菜单，查看后关闭详情菜单";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task5()
    {
        TaskNum.text = "Task 5  调整颜色和型号";
        Task.text = "\n请打开操作菜单，对红色背包进行调整\n\n" +
            "1）依次调整颜色为红，蓝，绿\n\n" +
            "2）依次调整型号为S, M, L\n\n\n" +
            "按钮选择成功时，您将听到按键音";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }

    public void Task6()
    {
        TaskNum.text = "Task 6  加入购物车";
        Task.text = "\n请将红色背包和绿色鞋子加入购物车内\n\n" +
            "加入购物车成功时，您将听到提示音\n";
        AudioSource.PlayClipAtPoint(clip, transform.position);
    }
}
