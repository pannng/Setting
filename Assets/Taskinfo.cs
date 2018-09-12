using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Taskinfo : MonoBehaviour {

    public Text TaskNum;
    public Text Task;

    public GameObject Big;
	
	public void Task1 () {
        TaskNum.text = "Task 1 选择";
        Task.text = "1）请选中红色背包" +
            "2）请选中绿色鞋子" +
            "选中成功时，目标物体将会高亮";
	}

    public void Task2()
    {
        Big.SetActive(true);
        TaskNum.text = "Task 2 缩放";
        Task.text = "1）请将红色背包放大2倍，具体大小由黄色框体提示" +
            "2）请将红色背包缩小至0.5倍，具体大小由绿色边框提示" +
            "3）请将红色背包还原至原来尺寸，具体大小由蓝色边框提示" +
            "缩放成功时，您将听到提示音";
    }

    public void Task3()
    {
        TaskNum.text = "Task 3 旋转";
        Task.text = "1）请将红色背包旋转180度，使背包背面朝向您" +
            "2）请将红色背包旋转90度，使背包的侧面朝向您" +
            "旋转成功时，您将听到提示音";
    }

    public void Task4()
    {
        TaskNum.text = "Task 4 查看详情";
        Task.text = "请打开详情菜单";
    }

    public void Task5()
    {
        TaskNum.text = "Task 5 调整颜色和型号";
        Task.text = "请打开操作菜单，对红色背包进行调整" +
            "1）依次调整颜色为红，蓝，绿" +
            "2）依次调整型号为S, M, L" +
            "按钮选择成功时，您将听到按键音";
    }

    public void Task6()
    {
        TaskNum.text = "Task 6 加入购物车";
        Task.text = "请将红色背包和绿色鞋子加入购物车内" +
            "加入购物车成功时。您将听到提示音";
    }
}
