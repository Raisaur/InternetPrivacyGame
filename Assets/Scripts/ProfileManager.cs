using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    void Start()
    {
        for (int i = 0; i < 120; i++)
        {
            //Order: gender, age, location, occupation, family, financial, searched
            NewProfile = new ProfileBase(RandTag(TagCategory.Gender), RandTag(TagCategory.Age), RandTag(TagCategory.Location),
                                         RandTag(TagCategory.Occupation), RandTag(TagCategory.Family),
                                         RandTag(TagCategory.Financial), RandTag(TagCategory.Searched));
            profiles.Add(NewProfile);
        }
    }

    void Update()
    {
        
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
}
