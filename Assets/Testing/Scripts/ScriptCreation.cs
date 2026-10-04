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


    public void CreateRoad10()
    {
        RoadArchitect.Tests.UnitTests.RoadArchitectUnitTest10();
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


    public void UpdateRoadSystem10()
    {
        GameObject roadSystem = GameObject.Find("RoadArchitectSystem10");
        RoadArchitect.RoadSystem sys = roadSystem.GetComponent<RoadArchitect.RoadSystem>();
        sys.UpdateAllRoads();
    }


    public void ResetTester()
    {
        GameObject tester = GameObject.Find("Car");
        Vector3 position = new Vector3();
        position.x = 713;
        position.y = 0.17f;
        position.z = 555;
        Vector3 eulerAngles = new Vector3();
        eulerAngles.x = 0;
        eulerAngles.y = -90;
        eulerAngles.z = 0;
        tester.transform.position = position;
        tester.transform.eulerAngles = eulerAngles;
        // TODO: reset forces
    }
}
#endif
