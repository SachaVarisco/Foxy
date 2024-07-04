using UnityEngine;
using Unity.Services.Core;
using Unity.Services.Analytics;

public class InitWithDefault : MonoBehaviour
{
    async void Awake()
    { 
        Debug.Log("hace el init data");  
		await UnityServices.InitializeAsync();

		ConsentGiven();
    }

	void ConsentGiven()
	{
		AnalyticsService.Instance.StartDataCollection();
	}
}