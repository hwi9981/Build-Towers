using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    [Space]
    [Header("Player Start Setting:")]
    [SerializeField] int playerStartValue;

    [Space]
    [Header("Dev Setting:")]
    [SerializeField] Vector2 currentPos;
    [SerializeField] Transform playerCenter;
    [SerializeField] LayerMask cellMask;
    [SerializeField] Text playerValueText;

    int playerValue;
    Rigidbody2D playerRb;
    BoxCollider2D playerCollider;
    private void Awake()
    {
        currentPos = transform.position;
        playerRb = GetComponent<Rigidbody2D>();
        playerCollider = GetComponent<BoxCollider2D>();
        playerValue = playerStartValue;
        UpdateValue();
    }
    private void OnMouseDown()
    {
        //playerRb.isKinematic = true;
        playerCollider.isTrigger = true;
    }
    private void OnMouseDrag()
    {
        Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        playerRb.MovePosition(mousePos + (Vector2)(transform.position - playerCenter.position));
        
    }
    private void OnMouseUp()
    {
        //playerRb.isKinematic = false;
        playerCollider.isTrigger = false;

        RaycastHit2D hit = Physics2D.Raycast(playerCenter.position, Vector2.up, 0.2f, cellMask);
        if (hit)
        {
            CellController cell = hit.transform.GetComponent<CellController>();
            if (cell != null)
            {
               // OnMoveToNewCell(cell.cellValue);
                if (playerValue > cell.cellValue)
                {
                    playerValue += cell.cellValue;
                    cell.cellValue = 0;
                }
                else
                {
                    playerValue = 0;
                    cell.cellValue += playerValue;
                }
                currentPos = cell.standPos.position;
                cell.UpdateCellValue();
                UpdateValue();
                transform.position = currentPos;
            }
        }
        else
        {
            transform.position = currentPos;
        }
    }
    void OnMoveToNewCell(int cellValue)
    {
        if (playerValue > cellValue)
        {
            playerValue += cellValue;
            cellValue = 0;
        }
        else
        {
            playerValue = 0;
            cellValue += playerValue;
        }
    }
    void UpdateValue()
    {
        if (playerValue > 0)
            playerValueText.text = playerValue.ToString();
        else
            playerValueText.text = "";
    }

}
