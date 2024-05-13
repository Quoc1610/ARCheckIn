using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEditor;
using UnityEngine;
using UnityEngine.UI;
public class UIExample : BaseUI
{
    public Button btnDatKham;
    public Button bthLichSu;
    public Button btnHoSo;
    public Button bthThanhToan;
    public Button btnTheoDoi;
    public Button bthDatLich;
    public Button btnNhanVienAI;
    public Button bthHoTro;
    public List<Button> lsBao = new List<Button>();
    public Button btnDieuHuong;
    public Image imgBlurDark;

    private void Start()
    {
        imgBlurDark.gameObject.SetActive(false);
    }

    public void OnbtnDatKham_Clicked()
    {
        //To Do đăj khám function
        Debug.Log("Dat Kham");
        imgBlurDark.gameObject.SetActive(!imgBlurDark.gameObject.activeSelf);
    }
}
