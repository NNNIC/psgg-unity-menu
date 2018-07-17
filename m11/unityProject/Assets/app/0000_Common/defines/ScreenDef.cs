using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenDef {

    /*
        スクリーン定義

        前提: screen_heightとscreen_widthが起動後に直ぐ設定されること

        UIはリファレンスエリアで動作
        横幅固定 
        縦がスクリーンサイズにより伸張する
        一定域を超える場合、カメラのview値を修正

        UICanvasCameraSetup.csにて利用中
    */


    public static float screen_height = 0; //Bootプロセスで設定予定
    public static float screen_width  = 0;

    // 横固定 縦はiPhone/iPad
    public const float reference_width = 640;

    public const float reference_height_max = 640 * 2.2f;  //これより大きい時のマスクは後ほど作成。カメラでやる手もある。
    public const float reference_height_min = 640 * 1.3f;

    private static float reference_height_calc { get { 
            var d = screen_height / screen_width;  //screen_width決定後に
            return reference_width * d;
        } }

    public static float reference_height { get {
            //return reference_height_calc;
            return Mathf.Clamp(reference_height_calc, reference_height_min, reference_height_max);
        } }

    private static bool is_over_reference_height { get {  return (reference_height_calc > reference_height_max);  } }

    public static float view_y { get {
            if (!is_over_reference_height) return 0;
            var diff = (reference_height_calc - reference_height_max);
            return (diff / reference_height_calc) * 0.5f;
        } }
    public static float view_height { get
        {
            if (!is_over_reference_height) return 1;
            return 1.0f - view_y * 2;
        } }
}
