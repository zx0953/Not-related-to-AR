using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticVar
{
    /// <summary>
    /// 檢查BGM
    /// </summary>
    public static bool isBGMready { get; set; }

    //靜態建構式 (僅第一次執行)
    static StaticVar()
    {
        isBGMready = false;
    }
}

    
	

