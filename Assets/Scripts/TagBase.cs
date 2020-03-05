using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TagBase 
{
    public VarRef.Tag this_tag;

    public List<VarRef.Topic> tier1;
    public List<VarRef.Topic> tier2;
    public List<VarRef.Topic> tier3;

    public TagBase()
    {
        tier1 = new List<VarRef.Topic>();
        tier2 = new List<VarRef.Topic>();
        tier3 = new List<VarRef.Topic>();
    }
}

public class TagList 
{
    public List<TagBase> tag_list;

    public TagList()
    {
        tag_list = new List<TagBase>();

        for (int i = 0; i < (int)VarRef.Tag.blank; i++)
        {
            TagBase NewTag = new TagBase();
            NewTag.this_tag = (VarRef.Tag)i;
            tag_list.Add(NewTag);
        }

        {
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.ClothesWomen);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.GenWoman].tier3.Add(VarRef.Topic.FoodGourmet);
        }

        {
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.ClothesMen);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.SportsSwimwear);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.CarsHighend);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.CarsParts);
            tag_list[(int)VarRef.Tag.GenMan].tier3.Add(VarRef.Topic.FoodQuick);
        }

        {
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.SportsSwimwear);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.AgeChild].tier3.Add(VarRef.Topic.ClothesCostume);
        }

        {
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.AgeAdult].tier3.Add(VarRef.Topic.FoodQuick);
        }

        {
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.SportsHike);
            tag_list[(int)VarRef.Tag.AgeElderly].tier3.Add(VarRef.Topic.CarsParts);
        }

        {
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.SportsSwimwear);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.LiveCity].tier3.Add(VarRef.Topic.CarsHighend);
        }

        {
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.SportsHike);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.LiveCountry].tier3.Add(VarRef.Topic.CarsParts);
        }

        {
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.OccStudent].tier2.Add(VarRef.Topic.FoodCafe);

            tag_list[(int)VarRef.Tag.OccStudent].tier3.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.OccStudent].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.OccStudent].tier3.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.OccStudent].tier3.Add(VarRef.Topic.ClothesCostume);
            tag_list[(int)VarRef.Tag.OccStudent].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.OccStudent].tier3.Add(VarRef.Topic.SportsSwimwear);
            tag_list[(int)VarRef.Tag.OccStudent].tier3.Add(VarRef.Topic.CarsBudget);
        }

        {
            tag_list[(int)VarRef.Tag.OccEmployed].tier2.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.OccEmployed].tier2.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.OccEmployed].tier2.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.OccEmployed].tier2.Add(VarRef.Topic.TravelBudget);

            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.ClothesCostume);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.SportsHike);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.CarsHighend);
            tag_list[(int)VarRef.Tag.OccEmployed].tier3.Add(VarRef.Topic.CarsParts);
        }

        {
            tag_list[(int)VarRef.Tag.OccUnemployed].tier2.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier2.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier2.Add(VarRef.Topic.TravelBudget);

            tag_list[(int)VarRef.Tag.OccUnemployed].tier3.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier3.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier3.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier3.Add(VarRef.Topic.SportsSwimwear);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.OccUnemployed].tier3.Add(VarRef.Topic.CarsParts);
        }

        {
            tag_list[(int)VarRef.Tag.FamSingle].tier2.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.FamSingle].tier2.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.FamSingle].tier2.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.FamSingle].tier2.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.FamSingle].tier2.Add(VarRef.Topic.TravelBudget);

            tag_list[(int)VarRef.Tag.FamSingle].tier3.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.FamSingle].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.FamSingle].tier3.Add(VarRef.Topic.SportsSwimwear);
            tag_list[(int)VarRef.Tag.FamSingle].tier3.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.FamSingle].tier3.Add(VarRef.Topic.CarsParts);
        }

        {
            tag_list[(int)VarRef.Tag.FamInRelationship].tier2.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.FamInRelationship].tier2.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.FamInRelationship].tier2.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.FamInRelationship].tier2.Add(VarRef.Topic.SportsHike);

            tag_list[(int)VarRef.Tag.FamInRelationship].tier3.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.FamInRelationship].tier3.Add(VarRef.Topic.CarsParts);
            tag_list[(int)VarRef.Tag.FamInRelationship].tier3.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.FamInRelationship].tier3.Add(VarRef.Topic.ClothesWomen);
            tag_list[(int)VarRef.Tag.FamInRelationship].tier3.Add(VarRef.Topic.ClothesMen);
        }

        {
            tag_list[(int)VarRef.Tag.FamHasKids].tier2.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.FamHasKids].tier2.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.FamHasKids].tier2.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.FamHasKids].tier2.Add(VarRef.Topic.SportsSwimwear);

            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.ClothesWomen);
            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.ClothesMen);
            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.ElecHouse);
            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.ClothesCostume);
            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.CarsHighend);
            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.FamHasKids].tier3.Add(VarRef.Topic.FoodGourmet);
        }

        {
            tag_list[(int)VarRef.Tag.SearchFashion].tier1.Add(VarRef.Topic.ClothesWomen);
            tag_list[(int)VarRef.Tag.SearchFashion].tier1.Add(VarRef.Topic.ClothesMen);

            tag_list[(int)VarRef.Tag.SearchFashion].tier2.Add(VarRef.Topic.ClothesCostume);
        }

        {
            tag_list[(int)VarRef.Tag.SearchParty].tier1.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.SearchParty].tier1.Add(VarRef.Topic.ClothesCostume);

            tag_list[(int)VarRef.Tag.SearchParty].tier2.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.SearchParty].tier2.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.SearchParty].tier2.Add(VarRef.Topic.ClothesWomen);
            tag_list[(int)VarRef.Tag.SearchParty].tier2.Add(VarRef.Topic.ClothesMen);
        }

        {
            tag_list[(int)VarRef.Tag.SearchOutdoor].tier1.Add(VarRef.Topic.SportsHike);
            tag_list[(int)VarRef.Tag.SearchOutdoor].tier1.Add(VarRef.Topic.SportsSwimwear);

            tag_list[(int)VarRef.Tag.SearchOutdoor].tier2.Add(VarRef.Topic.SportsFootball);
            tag_list[(int)VarRef.Tag.SearchOutdoor].tier2.Add(VarRef.Topic.TravelBudget);
        }

        {
            tag_list[(int)VarRef.Tag.SearchEatOut].tier1.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.SearchEatOut].tier1.Add(VarRef.Topic.FoodQuick);

            tag_list[(int)VarRef.Tag.SearchEatOut].tier2.Add(VarRef.Topic.FoodGourmet);
        }

        {
            tag_list[(int)VarRef.Tag.SearchVacation].tier1.Add(VarRef.Topic.TravelCharter);
            tag_list[(int)VarRef.Tag.SearchVacation].tier1.Add(VarRef.Topic.TravelBudget);

            tag_list[(int)VarRef.Tag.SearchVacation].tier2.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.SearchVacation].tier2.Add(VarRef.Topic.SportsHike);
        }

        {
            tag_list[(int)VarRef.Tag.SearchIndoor].tier1.Add(VarRef.Topic.ElecGames);
            tag_list[(int)VarRef.Tag.SearchIndoor].tier1.Add(VarRef.Topic.FoodCafe);

            tag_list[(int)VarRef.Tag.SearchIndoor].tier2.Add(VarRef.Topic.ElecPhone);
            tag_list[(int)VarRef.Tag.SearchIndoor].tier2.Add(VarRef.Topic.ElecHouse);
        }

        {
            tag_list[(int)VarRef.Tag.SearchBusiness].tier1.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.SearchBusiness].tier1.Add(VarRef.Topic.FoodCafe);

            tag_list[(int)VarRef.Tag.SearchBusiness].tier2.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.SearchBusiness].tier2.Add(VarRef.Topic.TravelCruise);
            tag_list[(int)VarRef.Tag.SearchBusiness].tier2.Add(VarRef.Topic.TravelCharter);
        }

        {
            tag_list[(int)VarRef.Tag.SearchVehicle].tier1.Add(VarRef.Topic.CarsHighend);
            tag_list[(int)VarRef.Tag.SearchVehicle].tier1.Add(VarRef.Topic.CarsBudget);

            tag_list[(int)VarRef.Tag.SearchVehicle].tier2.Add(VarRef.Topic.CarsParts);
            tag_list[(int)VarRef.Tag.SearchVehicle].tier2.Add(VarRef.Topic.TravelBudget);
        }

        {
            tag_list[(int)VarRef.Tag.FinPoor].tier1.Add(VarRef.Topic.SportsHike);
            tag_list[(int)VarRef.Tag.FinPoor].tier1.Add(VarRef.Topic.TravelBudget);

            tag_list[(int)VarRef.Tag.FinPoor].tier2.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.FinPoor].tier2.Add(VarRef.Topic.FoodCafe);
            tag_list[(int)VarRef.Tag.FinPoor].tier2.Add(VarRef.Topic.CarsParts);
            tag_list[(int)VarRef.Tag.FinPoor].tier2.Add(VarRef.Topic.CarsBudget);
        }

        {
            tag_list[(int)VarRef.Tag.FinMiddleClass].tier1.Add(VarRef.Topic.CarsBudget);
            tag_list[(int)VarRef.Tag.FinMiddleClass].tier1.Add(VarRef.Topic.TravelCharter);

            tag_list[(int)VarRef.Tag.FinMiddleClass].tier2.Add(VarRef.Topic.FoodQuick);
            tag_list[(int)VarRef.Tag.FinMiddleClass].tier2.Add(VarRef.Topic.TravelBudget);
            tag_list[(int)VarRef.Tag.FinMiddleClass].tier2.Add(VarRef.Topic.ElecHouse);
        }

        {
            tag_list[(int)VarRef.Tag.FinRich].tier1.Add(VarRef.Topic.CarsHighend);
            tag_list[(int)VarRef.Tag.FinRich].tier1.Add(VarRef.Topic.TravelCharter);

            tag_list[(int)VarRef.Tag.FinRich].tier2.Add(VarRef.Topic.FoodGourmet);
            tag_list[(int)VarRef.Tag.FinRich].tier2.Add(VarRef.Topic.TravelCruise);
        }
    }
}