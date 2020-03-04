﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum TagCategory
{
    Gender = 0,
    Age,
    Location,
    Occupation,
    Family,
    Financial,
    Searched
}


public class ProfileManager : MonoBehaviour
{
    List<ProfileBase> profiles;
    ProfileBase NewProfile;

    [SerializeField]
    Image profile_image;

    [SerializeField]
    Sprite[] image_assets = new Sprite[6];
    //Order: 0 child girl, 1 child boy, 2 adult female, 3 adult male, 4 elderly female, 5 elderly male

    [SerializeField]
    Text[] text_fields = new Text[7];
    //Order: 0 gender, 1 age, 2 location, 3 occupation, 4 family, 5 financial, 6 searched
    
    void Start()
    {
        profiles = new List<ProfileBase>();

        for (int i = 0; i < 120; i++)
        {
            VarRef.Tag gender = RandTag(TagCategory.Gender);
            VarRef.Tag age = RandTag(TagCategory.Age);
            VarRef.Tag location = RandTag(TagCategory.Location);

            VarRef.Tag occupation = RandTag(TagCategory.Occupation);
            if (age == VarRef.Tag.AgeChild && occupation == VarRef.Tag.OccEmployed) {
                occupation = VarRef.Tag.OccStudent;
            }
            VarRef.Tag family = RandTag(TagCategory.Family);
            if (age == VarRef.Tag.AgeChild) {
                family = VarRef.Tag.FamSingle;
            }
            VarRef.Tag financial = RandTag(TagCategory.Financial);
            VarRef.Tag search = RandTag(TagCategory.Searched);

            NewProfile = new ProfileBase(gender, age, location, occupation, family, financial, search);
            profiles.Add(NewProfile);
        }
    }

    void DisplayProfile(ProfileBase profile)
    {
        VarRef.Tag[] profile_tags = profile.GetTagArray();

        //Determine profile image, gender text and age text
        if (profile_tags[0] == VarRef.Tag.GenWoman)
        {
            text_fields[0].text = "Female";

            if (profile_tags[1] == VarRef.Tag.AgeChild) {
                profile_image.sprite = image_assets[0];
                text_fields[1].text = "Child";
            }
            else if (profile_tags[1] == VarRef.Tag.AgeAdult) {
                profile_image.sprite = image_assets[2];
                text_fields[1].text = "Adult";
            }
            else if (profile_tags[1] == VarRef.Tag.AgeElderly) {
                profile_image.sprite = image_assets[4];
                text_fields[1].text = "Elderly";
            }
            else Debug.Log("ProfileManager: Error in profile data - Female Age");
        }
        else if (profile_tags[0] == VarRef.Tag.GenMan)
        {
            text_fields[0].text = "Male";

            if (profile_tags[1] == VarRef.Tag.AgeChild) {
                profile_image.sprite = image_assets[1];
                text_fields[1].text = "Child";
            }
            else if (profile_tags[1] == VarRef.Tag.AgeAdult) {
                profile_image.sprite = image_assets[3];
                text_fields[1].text = "Adult";
            }
            else if (profile_tags[1] == VarRef.Tag.AgeElderly) {
                profile_image.sprite = image_assets[5];
                text_fields[1].text = "Elderly";
            }
            else Debug.Log("ProfileManager: Error in profile data - Male Age");
        }
        else Debug.Log("ProfileManager: Error in profile data - Gender");

        //Determine locaion text
        {
            if (profile_tags[2] == VarRef.Tag.LiveCity)
                text_fields[2].text = "Lives in a city";
            else if (profile_tags[2] == VarRef.Tag.LiveCountry)
                text_fields[2].text = "Lives in the countryside";
            else Debug.Log("ProfileManager: Error in profile data - Location");
        }

        //Determine occupation text
        {
            if (profile_tags[3] == VarRef.Tag.OccStudent)
                text_fields[3].text = "Student";
            else if (profile_tags[3] == VarRef.Tag.OccEmployed)
                text_fields[3].text = "Employed";
            else if (profile_tags[3] == VarRef.Tag.OccUnemployed)
                text_fields[3].text = "Unemployed";
            else Debug.Log("ProfileManager: Error in profile data - Occupation");
        }

        //Determine family text
        {
            if (profile_tags[4] == VarRef.Tag.FamSingle)
                text_fields[4].text = "Single";
            else if (profile_tags[4] == VarRef.Tag.FamInRelationship)
                text_fields[4].text = "In a relationship";
            else if (profile_tags[4] == VarRef.Tag.FamHasKids)
                text_fields[4].text = "Has children";
            else Debug.Log("ProfileManager: Error in profile data - Family");
        }

        //Determine financial text
        {
            if (profile_tags[5] == VarRef.Tag.FinPoor)
                text_fields[5].text = "Poor";
            else if (profile_tags[5] == VarRef.Tag.FinMiddleClass)
                text_fields[5].text = "Middle class";
            else if (profile_tags[5] == VarRef.Tag.FinRich)
                text_fields[5].text = "Rich";
            else Debug.Log("ProfileManager: Error in profile data - Financial");
        }

        //Determine search text
        {
            if (profile_tags[6] == VarRef.Tag.SearchFashion)
                text_fields[6].text = "Fashion and apparel";
            else if (profile_tags[6] == VarRef.Tag.SearchParty)
                text_fields[6].text = "Parties and festivities";
            else if (profile_tags[6] == VarRef.Tag.SearchOutdoor)
                text_fields[6].text = "Ourdoor activities";
            else if (profile_tags[6] == VarRef.Tag.SearchEatOut)
                text_fields[6].text = "Restaurants and eating out";
            else if (profile_tags[6] == VarRef.Tag.SearchVacation)
                text_fields[6].text = "Vacation and travel";
            else if (profile_tags[6] == VarRef.Tag.SearchIndoor)
                text_fields[6].text = "Indoor activities";
            else if (profile_tags[6] == VarRef.Tag.SearchVehicle)
                text_fields[6].text = "Vehicles and machinery";
            else Debug.Log("ProfileManager: Error in profile data - Searched");
        }

    }

    VarRef.Tag RandTag(TagCategory category)
    {
        int min = 0;
        int max = 0;

        switch (category)
        {
            case TagCategory.Gender:
                min = 0; max = 1;
                break;
            case TagCategory.Age:
                min = 2; max = 4;
                break;
            case TagCategory.Location:
                min = 5; max = 6;
                break;
            case TagCategory.Occupation:
                min = 7; max = 9;
                break;
            case TagCategory.Family:
                min = 10; max = 12;
                break;
            case TagCategory.Financial:
                min = 13; max = 15;
                break;
            case TagCategory.Searched:
                min = 16; max = 23;
                break;
            default:
                break;
        }
        int rand = Random.Range(min, max);
        VarRef.Tag ret = (VarRef.Tag)rand;

        return ret;
    }

    public List<ProfileBase> GetProfiles() { return profiles; }
}
