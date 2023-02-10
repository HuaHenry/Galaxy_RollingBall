using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM : MonoBehaviour
{
    public GameObject panel;
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);  //����
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GameOver()
    {
        Time.timeScale = 0;   //ײ����ʱ��Ͳ����ţ�ֹͣ��
        panel.SetActive(true);  //��ʾ
        Text t = panel.transform.Find("Text (Legacy)").GetComponent<Text>();
        t.text = "Don't Give Up!";
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);  //���¼��س���
    }

    public void Finish()
    {
        Time.timeScale = 0;   //ײ����ʱ��Ͳ����ţ�ֹͣ��
        panel.SetActive(true);  //��ʾ
        Text t = panel.transform.Find("Text (Legacy)").GetComponent<Text>();
        t.text = "You've Done It!";
    }

}
