using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Presenter : MonoBehaviour
{
    public input laststate;
    public Model model;
    public View view;
    public List<GameObject> value;
    public Stack<GameObject> stack = new Stack<GameObject>();
    Dictionary<string, List<GameObject>> myTable = new Dictionary<string, List<GameObject>>();
    public void StateSetUI(input input)
    {
        laststate = input;
        if (model.data.ContainsKey(input.ToString()))
        {
            value = model.data[input.ToString()];
            for(int i = 0; i < value.Count; i++)
            {
                if (!value[i].transform.gameObject.activeSelf)
                {
                    stack.Push(value[i]);
                    view.ShowUI(true, value[i]);
                    break;
                }
            }
        }
    }
    public void SetUI()
    {

        value = model.data[laststate.ToString()];
        for (int i = 0; i < value.Count; i++)
        {
            if (!value[i].transform.gameObject.activeSelf)
            {
                stack.Push(value[i]);
                view.ShowUI(true, value[i]);
                break;
            }
        }

    }
    public void OutUI()
    {
        view.ShowUI(false, stack.Pop());                  
    }
}
