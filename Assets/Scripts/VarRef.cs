using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VarRef : MonoBehaviour
{
    public enum Tag
    {
        //Gender
        GenWoman = 0,       //0
        GenMan,             //1

        //Age
        AgeChild,           //2
        AgeAdult,           //3
        AgeElderly,         //4

        //Living location
        LiveCity,           //5
        LiveCountry,        //6

        //Occupation
        OccStudent,         //7
        OccEmployed,        //8
        OccUnemployed,      //9

        //Family status
        FamSingle,          //10
        FamInRelationship,  //11
        FamHasKids,         //12

        //Financial status
        FinPoor,            //13
        FinMiddleClass,     //14
        FinRich,            //15

        //Most searched
        SearchFashion,      //16
        SearchParty,        //17    
        SearchOutdoor,      //18
        SearchEatOut,       //19
        SearchVacation,     //20
        SearchIndoor,       //21
        SearchBusiness,     //22
        SearchVehicle,      //23

        //No tag
        blank               //24
    }

    public enum Topic
    {
        TravelCruise = 0,   //0
        TravelCharter,      //1
        TravelBudget,       //2

        ElecPhone,          //3
        ElecGames,          //4
        ElecHouse,          //5

        SportsFootball,     //6
        SportsGolf,     //7
        SportsGymnastics,         //8

        FoodQuick,          //9
        FoodGourmet,        //10
        FoodCafe,           //11

        CarsBudget,         //12
        CarsHighend,        //13
        CarsParts,          //14

        ClothesWomen,       //15
        ClothesMen,         //16
        ClothesCostume      //17
    }
}
