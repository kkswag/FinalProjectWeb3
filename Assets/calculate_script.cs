using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class calculate_script : MonoBehaviour
{
    // Start is called before the first frame update
    public Text output;
    public int allCoin;
    public static string status;
    void Start()
    {

        allCoin = (scorecoin_script.c_score);
        if (allCoin >= 40)
        {
            status = "สุขภาพปอดปกติ";
        }
        else
        if (allCoin >= 21 && allCoin <= 39)
        {
            status = "สุขภาพปอดเริ่มมีปัญหา";
        }
        else
        if (allCoin >= 1 && allCoin <= 20)
        {
            status = "สุขภาพปอดมีปัญหา";
        }
        setdata();
    }

    // Update is called once per frame
    void Update()
    {
        

        output.text = status;

    }

    public void setdata()
    {
        print("save");
        string url = "http://localhost/theBreathOfPaper/userInsert.php";
        WWWForm form = new WWWForm();
        form.AddField("gender", age_script.sex);
        form.AddField("totalCoin", scorecoin_script.c_score);
        form.AddField("status", status);
        WWW www = new WWW(url, form);

    }


}
