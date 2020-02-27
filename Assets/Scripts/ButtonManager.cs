using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    [SerializeField]
    Button[] travel_buttons;
    [SerializeField]
    Button[] electronics_buttons;
    [SerializeField]
    Button[] sports_buttons;
    [SerializeField]
    Button[] food_buttons;
    [SerializeField]
    Button[] cars_buttons;
    [SerializeField]
    Button[] clothes_buttons;

    GameManager gm;

    int i = 0;
    int category_nr = 1;

    // Start is called before the first frame update
    void Start()
    {
        travel_buttons = new Button[3];
        electronics_buttons = new Button[3];
        sports_buttons = new Button[3];
        food_buttons = new Button[3];
        cars_buttons = new Button[3];
        clothes_buttons = new Button[3];


        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
