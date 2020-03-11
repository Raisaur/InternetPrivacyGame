using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonManager : MonoBehaviour
{
    Button[] travel_buttons;
    Button[] electronics_buttons;
    Button[] sports_buttons;
    Button[] food_buttons;
    Button[] cars_buttons;
    Button[] clothes_buttons;

    Button[] upgrade_buttons;
    int upgrade_level;
    bool upgrade_1_done = false;

    [SerializeField]
    Button btn_travel, btn_electronics, btn_sports,
           btn_food, btn_cars, btn_clothes;

    [SerializeField]
    Button btn_travel_cruise, btn_travel_charter, btn_travel_budget, 
           btn_electronics_phone, btn_electronics_games, btn_electronics_house,
           btn_sports_football, btn_sports_golf, btn_sports_gymnastics,
           btn_food_quick, btn_food_gourmet, btn_food_cafe,
           btn_cars_budget, btn_cars_highend, btn_cars_parts,
           btn_clothes_women, btn_clothes_men, btn_clothes_costume;

    [SerializeField]
    Button btn_upgrade1, btn_upgrade_2;
    [SerializeField]
    Image data_block_1, data_block_2;
    [SerializeField]
    Button exit_button;

    GameManager gm;
    SoundManager sm;
    [SerializeField]
    ConfirmationBox confirmation_box;

    [SerializeField]
    GameObject exit_box;
    [SerializeField]
    Button exit_box_button;

    bool promotion_ready = false;

    // Start is called before the first frame update
    void Start()
    {
        travel_buttons = new Button[3];
        electronics_buttons = new Button[3];
        sports_buttons = new Button[3];
        food_buttons = new Button[3];
        cars_buttons = new Button[3];
        clothes_buttons = new Button[3];

        upgrade_buttons = new Button[2];
        upgrade_level = 0;
        confirmation_box.gameObject.SetActive(false);
        exit_box.gameObject.SetActive(false);

        // add buttons to respective arrays
        { 
            travel_buttons[0] = btn_travel_cruise;
            travel_buttons[1] = btn_travel_charter;
            travel_buttons[2] = btn_travel_budget;

            electronics_buttons[0] = btn_electronics_phone;
            electronics_buttons[1] = btn_electronics_games;
            electronics_buttons[2] = btn_electronics_house;

            sports_buttons[0] = btn_sports_football;
            sports_buttons[1] = btn_sports_golf;
            sports_buttons[2] = btn_sports_gymnastics;

            food_buttons[0] = btn_food_quick;
            food_buttons[1] = btn_food_gourmet;
            food_buttons[2] = btn_food_cafe;

            cars_buttons[0] = btn_cars_budget;
            cars_buttons[1] = btn_cars_highend;
            cars_buttons[2] = btn_cars_parts;

            clothes_buttons[0] = btn_clothes_women;
            clothes_buttons[1] = btn_clothes_men;
            clothes_buttons[2] = btn_clothes_costume;

            upgrade_buttons[0] = btn_upgrade1;
            upgrade_buttons[1] = btn_upgrade_2;
        }

        sm = GameObject.FindGameObjectWithTag("SoundManager").GetComponent<SoundManager>();

        btn_travel.onClick.AddListener(TravelClick);
        btn_electronics.onClick.AddListener(ElectronicsClick);
        btn_sports.onClick.AddListener(SportsClick);
        btn_food.onClick.AddListener(FoodClick);
        btn_cars.onClick.AddListener(CarsClick);
        btn_clothes.onClick.AddListener(ClothesClick);

        btn_travel_cruise.onClick.AddListener(TravelCruiseClick);
        btn_travel_charter.onClick.AddListener(TravelCharterClick);
        btn_travel_budget.onClick.AddListener(TravelBudgetClick);

        btn_electronics_phone.onClick.AddListener(ElectronicsPhonesClick);
        btn_electronics_games.onClick.AddListener(ElectronicGamesClick);
        btn_electronics_house.onClick.AddListener(ElectronicHouseClick);

        btn_sports_football.onClick.AddListener(SportsFootballClick);
        btn_sports_golf.onClick.AddListener(SportsGolfClick);
        btn_sports_gymnastics.onClick.AddListener(SportsGymnasticsClick);

        btn_food_quick.onClick.AddListener(FoodQuickClick);
        btn_food_gourmet.onClick.AddListener(FoodGourmetClick);
        btn_food_cafe.onClick.AddListener(FoodCafeClick);

        btn_cars_budget.onClick.AddListener(CarsBudgetClick);
        btn_cars_highend.onClick.AddListener(CarsHighendClick);
        btn_cars_parts.onClick.AddListener(CarsPartsClick);

        btn_clothes_women.onClick.AddListener(ClothesWomenClick);
        btn_clothes_men.onClick.AddListener(ClothesMenClick);
        btn_clothes_costume.onClick.AddListener(ClothesCostumeClick);

        btn_upgrade1.onClick.AddListener(Upgrade1Click);
        btn_upgrade_2.onClick.AddListener(Upgrade2Click);

        exit_button.onClick.AddListener(ExitClick);
        exit_box_button.onClick.AddListener(Exit);
        exit_box.SetActive(false);

        gm = GetComponent<GameManager>();
    }

    public void PromotionClick()
    {
        if (promotion_ready)
        {
            exit_box.SetActive(true);
        }
        if (!promotion_ready)
            promotion_ready = true;
    }

    void Exit()
    {
        Application.Quit();
    }

    void ToggleButtons(bool onoff, Button[] buttons)
    {
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].gameObject.SetActive(onoff);
        }
    }

    IEnumerator ShowConfirmationBox()
    {
        confirmation_box.ShowConfirmationBox();

        while (confirmation_box.ReturnResult() == ConfirmationResults.ResNull)
            yield return null;

        confirmation_box.HideConfirmationBox();
    }

    void ExitClick()
    {
        StartCoroutine(ShowConfirmationBox());
        confirmation_box.SetAction(Application.Quit);
    }

    //Upgrade buttons
    void Upgrade1Click()
    {
        if (gm.GetCurrency() >= gm.GetUpgradeCost(upgrade_level))
        {
            if (upgrade_level < upgrade_buttons.Length)
            {
                StartCoroutine(ShowConfirmationBox());
                confirmation_box.SetAction(Upgrade1);
            }
        }
    }

    void Upgrade1()
    {
        gm.SubtractCurrency(gm.GetUpgradeCost(upgrade_level));
        sm.PlayUpgradeSound();
        data_block_1.gameObject.SetActive(false);
        upgrade_buttons[upgrade_level].gameObject.SetActive(false);

        upgrade_level++;
        gm.SetUpgradeLevel(upgrade_level);
        btn_upgrade_2.interactable = true;
        upgrade_1_done = true;
    }

    void Upgrade2Click()
    {
        if (!upgrade_1_done)
            return;

        if (gm.GetCurrency() >= gm.GetUpgradeCost(upgrade_level))
        {
            if (upgrade_level < upgrade_buttons.Length)
            {
                StartCoroutine(ShowConfirmationBox());
                confirmation_box.SetAction(Upgrade2);
            }
        }
    }

    void Upgrade2()
    {
        gm.SubtractCurrency(gm.GetUpgradeCost(upgrade_level));
        sm.PlayUpgradeSound();
        data_block_2.gameObject.SetActive(false);
        upgrade_buttons[upgrade_level].gameObject.SetActive(false);

        upgrade_level++;
        gm.SetUpgradeLevel(upgrade_level);
        gm.promote_box.SetText1();
        gm.promote_box.DisplayShow();
    }

    //Travel buttons
    void TravelClick()
    {
        ToggleButtons(false, electronics_buttons);
        ToggleButtons(false, sports_buttons);
        ToggleButtons(false, food_buttons);
        ToggleButtons(false, cars_buttons);
        ToggleButtons(false, clothes_buttons);

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
        ToggleButtons(false, travel_buttons);
        ToggleButtons(false, sports_buttons);
        ToggleButtons(false, food_buttons);
        ToggleButtons(false, cars_buttons);
        ToggleButtons(false, clothes_buttons);

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
        ToggleButtons(false, travel_buttons);
        ToggleButtons(false, electronics_buttons);
        ToggleButtons(false, food_buttons);
        ToggleButtons(false, cars_buttons);
        ToggleButtons(false, clothes_buttons);

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

    void SportsGolfClick()
    {
        gm.GiveAd(VarRef.Topic.SportsGolf);
        ToggleButtons(false, sports_buttons);
    }

    void SportsGymnasticsClick()
    {
        gm.GiveAd(VarRef.Topic.SportsGymnastics);
        ToggleButtons(false, sports_buttons);
    }

    //Food buttons
    void FoodClick()
    {
        ToggleButtons(false, travel_buttons);
        ToggleButtons(false, electronics_buttons);
        ToggleButtons(false, sports_buttons);
        ToggleButtons(false, cars_buttons);
        ToggleButtons(false, clothes_buttons);

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
        ToggleButtons(false, travel_buttons);
        ToggleButtons(false, electronics_buttons);
        ToggleButtons(false, sports_buttons);
        ToggleButtons(false, food_buttons);
        ToggleButtons(false, clothes_buttons);

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
        ToggleButtons(false, travel_buttons);
        ToggleButtons(false, electronics_buttons);
        ToggleButtons(false, sports_buttons);
        ToggleButtons(false, food_buttons);
        ToggleButtons(false, cars_buttons);

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
