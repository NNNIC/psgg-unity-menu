using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourcesUtil {

    /// <summary>
    /// リソースのプレハブからコンポーネントを取得する便利関数
    /// </summary>
    public static  T LoadComponent<T>(string path)
    {
        var prefab = Resources.Load<GameObject>(path);
        if (prefab==null)
        {
            return default(T);
        }

        return prefab.GetComponent<T>();
    }

    public static GameObject InstantiatePrefab(string path)
    {
        var prefab = Resources.Load<GameObject>(path);
        if (prefab==null) return null;
        var go = (GameObject)GameObject.Instantiate(prefab);
        return go;
    }

}
