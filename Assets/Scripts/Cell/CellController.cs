using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellController : MonoBehaviour
{
    public int cellValue;
    public Transform standPos;
    [SerializeField] Text cellValueText;
    private void Awake()
    {
        UpdateCellValue();
    }
    public void UpdateCellValue()
    {
        if (cellValue > 0)
            cellValueText.text = cellValue.ToString();
        else
            cellValueText.text = "";
    }
}
