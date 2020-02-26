using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarRef : MonoBehaviour
{
    public enum Tag
    {
        //Gender
        GenWoman = 0,
        GenMan,

        //Age
        AgeChild,
        AgeAdult,
        AgeElderly,

        //Living location
        LiveCity,
        LiveCountry,

        //Occupation
        OccStudent,
        OccEmployed,
        OccUnemployed,

        //Family status
        FamSingle,
        FamInRelationship,
        FamHasKids,

        //Financial status
        FinPoor,
        FinMiddleClass,
        FinRich,

        //Most searched
        SearchFashion,
        SearchParty,
        SearchOutdoor,
        SearchEatOut,
        SearchVacation,
        SearchIndoor,
        SearchBusiness,
        SearchVehicle

    }

    public enum Topic
    {
        TravelCruise = 0,
        TravelCharter,
        TravelBudget,

        ElecPhone,
        ElecGames,
        ElecHouse,

        SportsFootball,
        SportsSkate,
        SportsHike,

        FoodQuick,
        FoodGourmet,
        FoodCafe,

        CarsBudget,
        CarsHighend,
        CarsParts,

        ClothesWomen,
        ClothesMen,
        ClothesCostume
    }
}
