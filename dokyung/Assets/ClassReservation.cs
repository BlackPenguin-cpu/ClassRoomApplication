using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum ClassStateType
{
    Basic,
    FrontNumber,
    BackNumber,
    Graphic,
    Programming
}

public class Group
{
    public int grade = 0;
    public int number = 0;
    public Color color = Color.black;
    public ClassStateType classStateType = ClassStateType.Basic;
}
public class ClassReservation : MonoBehaviour
{
    private Group nowGroup;
    private Group newGroup;
    private Button[][] classRoomBtn;
    private void Start()
    {
        Init();
    }
    private void Init()
    {
        for (int i = 0; i < transform.childCount; i++)
        {
            Transform child = transform.GetChild(i);
            for (int j = 0; j < child.childCount; j++)
            {
                classRoomBtn[i][j] = child.GetChild(j).GetComponent<Button>();
            }
        } 
    }

    public void gradeButtonClick(int grade)
    {
        newGroup.grade = grade;
    }
    public void numberButtonClick(int number)
    {
        newGroup.number = number;
    }
}
