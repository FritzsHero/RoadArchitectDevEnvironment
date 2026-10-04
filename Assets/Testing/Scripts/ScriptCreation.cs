#if UNITY_EDITOR
using UnityEngine;


public class ScriptCreation : MonoBehaviour
{
    public void CreateRoad1()
    {
        RoadArchitect.Tests.UnitTests.RoadArchitectUnitTest1To5();
    }


    public void CreateRoad6()
    {
        RoadArchitect.Tests.UnitTests.RoadArchitectUnitTest6();
    }


    public void CreateRoad7()
    {
        RoadArchitect.Tests.UnitTests.RoadArchitectUnitTest7();
    }


    public void CreateRoad8()
    {
        RoadArchitect.Tests.UnitTests.RoadArchitectUnitTest8();
    }


    public void CreateRoad9()
    {
        RoadArchitect.Tests.UnitTests.RoadArchitectUnitTest9();
    }


    public void UpdateRoadSystem1()
    {
        GameObject roadSystem = GameObject.Find("RoadArchitectSystem1");
        RoadArchitect.RoadSystem sys = roadSystem.GetComponent<RoadArchitect.RoadSystem>();
        sys.UpdateAllRoads();
    }


    public void UpdateRoadSystem6()
    {
        GameObject roadSystem = GameObject.Find("RoadArchitectSystem6");
        RoadArchitect.RoadSystem sys = roadSystem.GetComponent<RoadArchitect.RoadSystem>();
        sys.UpdateAllRoads();
    }


    public void UpdateRoadSystem7()
    {
        GameObject roadSystem = GameObject.Find("RoadArchitectSystem7");
        RoadArchitect.RoadSystem sys = roadSystem.GetComponent<RoadArchitect.RoadSystem>();
        sys.UpdateAllRoads();
    }


    public void UpdateRoadSystem8()
    {
        GameObject roadSystem = GameObject.Find("RoadArchitectSystem8");
        RoadArchitect.RoadSystem sys = roadSystem.GetComponent<RoadArchitect.RoadSystem>();
        sys.UpdateAllRoads();
    }


    public void UpdateRoadSystem9()
    {
        GameObject roadSystem = GameObject.Find("RoadArchitectSystem9");
        RoadArchitect.RoadSystem sys = roadSystem.GetComponent<RoadArchitect.RoadSystem>();
        sys.UpdateAllRoads();
    }
}
#endif
