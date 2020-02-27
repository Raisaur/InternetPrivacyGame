﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{
    Button[] travel_buttons;
    Button[] electronics_buttons;
    Button[] sports_buttons;
    Button[] food_buttons;
    Button[] cars_buttons;
    Button[] clothes_buttons;

    [SerializeField]
    Button btn_travel, btn_electronics, btn_sports,
           btn_food, btn_cars, btn_clothes;

    [SerializeField]
    Button btn_travel_cruise, btn_travel_charter, btn_travel_budget, 
           btn_electronics_phone, btn_electronics_games, btn_electronics_house,
           btn_sports_football, btn_sports_swimwear, btn_sports_hiking,
           btn_food_quick, btn_food_gourmet, btn_food_cafe,
           btn_cars_budget, btn_cars_highend, btn_cars_parts,
           btn_clothes_women, btn_clothes_men, btn_clothes_costume;

    GameManager gm;

    // Start is called before the first frame update
    void Start()
    {
        travel_buttons = new Button[3];
        electronics_buttons = new Button[3];
        sports_buttons = new Button[3];
        food_buttons = new Button[3];
        cars_buttons = new Button[3];
        clothes_buttons = new Button[3];
        // add buttons to respective arrays
        { 
            travel_buttons[0] = btn_travel_cruise;
            travel_buttons[1] = btn_travel_charter;
            travel_buttons[2] = btn_travel_budget;

            electronics_buttons[0] = btn_electronics_phone;
            electronics_buttons[1] = btn_electronics_games;
            electronics_buttons[2] = btn_electronics_house;

            sports_buttons[0] = btn_sports_football;
            sports_buttons[1] = btn_sports_swimwear;
            sports_buttons[2] = btn_sports_hiking;

            food_buttons[0] = btn_food_quick;
            food_buttons[1] = btn_food_gourmet;
            food_buttons[2] = btn_food_gourmet;

            cars_buttons[0] = btn_cars_budget;
            cars_buttons[1] = btn_cars_highend;
            cars_buttons[2] = btn_cars_parts;

            clothes_buttons[0] = btn_clothes_women;
            clothes_buttons[1] = btn_clothes_men;
            clothes_buttons[2] = btn_clothes_costume;
        }

        btn_travel_cruise.onClick.AddListener(TravelCruiseClick);

        gm = GameObject.FindGameObjectWithTag("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ToggleButtons(bool onoff, Button[] buttons)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(onoff);
        }
    }

    //Travel buttons
    void TravelClick()
    {
        if (travel_buttons[0].IsActive())
            ToggleButtons(false, travel_buttons);

        else
            ToggleButtons(true, travel_buttons);
    }

    void TravelCruiseClick()
    {
        gm.GiveAd(VarRef.Topic.TravelCruise);
        ToggleButtons(false, travel_buttons);
    }

    void TravelCharterClick()
    {
        gm.GiveAd(VarRef.Topic.TravelCharter);
        ToggleButtons(false, travel_buttons);
    }

    void TravelBudgetClick()
    {
        gm.GiveAd(VarRef.Topic.TravelBudget);
        ToggleButtons(false, travel_buttons);
    }

    //Electronics buttons
    void ElectronicsClick()
    {
        if (electronics_buttons[0].IsActive())
            ToggleButtons(false, electronics_buttons);

        else
            ToggleButtons(true, electronics_buttons);
    }

    void ElectronicsPhonesClick()
    {
        gm.GiveAd(VarRef.Topic.ElecPhone);
        ToggleButtons(false, electronics_buttons);
    }

    void ElectronicGamesClick()
    {
        gm.GiveAd(VarRef.Topic.ElecGames);
        ToggleButtons(false, electronics_buttons);
    }

    void ElectronicHouseClick()
    {
        gm.GiveAd(VarRef.Topic.ElecHouse);
        ToggleButtons(false, electronics_buttons);
    }

    //Sports buttons
    void SportsClick()
    {
        if (sports_buttons[0].IsActive())
            ToggleButtons(false, sports_buttons);

        else
            ToggleButtons(true, sports_buttons);
    }
        
    void SportsFootballClick()
    {
        gm.GiveAd(VarRef.Topic.SportsFootball);
        ToggleButtons(false, sports_buttons);
    }

    void SportsSwimwearClick()
    {
        gm.GiveAd(VarRef.Topic.SportsSwimwear);
        ToggleButtons(false, sports_buttons);
    }

    void SportsHikeClick()
    {
        gm.GiveAd(VarRef.Topic.SportsHike);
        ToggleButtons(false, sports_buttons);
    }

    //Food buttons
    void FoodClick()
    {
        if (food_buttons[0].IsActive())
            ToggleButtons(false, food_buttons);

        else
            ToggleButtons(true, food_buttons);
    }
    void FoodQuickClick()
    {
        gm.GiveAd(VarRef.Topic.FoodQuick);
        ToggleButtons(false, food_buttons);
    }

    void FoodGourmetClick()
    {
        gm.GiveAd(VarRef.Topic.FoodGourmet);
        ToggleButtons(false, food_buttons);
    }

    void FoodCafeClick()
    {
        gm.GiveAd(VarRef.Topic.FoodCafe);
        ToggleButtons(false, food_buttons);
    }

    //Cars buttons
    void CarsClick()
    {
        if (cars_buttons[0].IsActive())
            ToggleButtons(false, cars_buttons);

        else
            ToggleButtons(true, cars_buttons);
    }
    void CarsBudgetClick()
    {
        gm.GiveAd(VarRef.Topic.CarsBudget);
        ToggleButtons(false, cars_buttons);
    }

    void CarsHighendClick()
    {
        gm.GiveAd(VarRef.Topic.CarsHighend);
        ToggleButtons(false, cars_buttons);
    }

    void CarsPartsClick()
    {
        gm.GiveAd(VarRef.Topic.CarsParts);
        ToggleButtons(false, cars_buttons);
    }

    //Clothes buttons
    void ClothesClick()
    {
        if (clothes_buttons[0].IsActive())
            ToggleButtons(false, clothes_buttons);

        else
            ToggleButtons(true, clothes_buttons);
    }
    void ClothesWomenClick()
    {
        gm.GiveAd(VarRef.Topic.ClothesWomen);
        ToggleButtons(false, clothes_buttons);
    }

    void ClothesMenClick()
    {
        gm.GiveAd(VarRef.Topic.ClothesMen);
        ToggleButtons(false, clothes_buttons);
    }

    void ClothesCostumeClick()
    {
        gm.GiveAd(VarRef.Topic.ClothesCostume);
        ToggleButtons(false, clothes_buttons);
    }
}
