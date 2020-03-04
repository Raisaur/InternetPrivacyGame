using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfileManager : MonoBehaviour
{
    List<ProfileBase> profiles;
    ProfileBase NewProfile;

    void Start()
    {
        //Order: gender, age, location, occupation, family, financial, searched
        NewProfile = new ProfileBase(VarRef.Tag.GenWoman, VarRef.Tag.AgeAdult, VarRef.Tag.LiveCity,
                                     VarRef.Tag.OccStudent, VarRef.Tag.FamSingle,
                                     VarRef.Tag.FinMiddleClass, VarRef.Tag.SearchFashion);
        profiles.Add(NewProfile);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
