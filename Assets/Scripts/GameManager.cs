using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<ProfileBase> profile_list;
    ProfileBase current_profile;
    int current_profile_index = 0;

    // Start is called before the first frame update
    void Start()
    {
        current_profile = profile_list[0];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GiveAd()
    {
        for (int i = 0; i < current_profile.GetNrOfTags(); i++)
        {
            //get each tag and check lists
        }
    }

    void LoadNextProfile()
    {
        current_profile_index++;
        current_profile = profile_list[current_profile_index];
    }
}
