using System.Runtime.Versioning;

class LifeForm{
    bool _advanced;
    bool _friendly;
    bool _potentialFood;
    List<Resource> _neededResources;
    List<Skill> _skills;
    bool _spaceTravel;
    Planet _currentPlanet;
    SolarSystem _SolarSystem;
    string _name;
    string _description;
    public LifeForm(string name, string description, bool advanced, bool friendly, bool potentialFood, bool spaceTravel, Planet planet, SolarSystem solarSystem, List<Skill> skills, List<Resource> resources){
        _name = name;
        _description = description;
        _advanced = advanced;
        _friendly = friendly;
        _potentialFood = potentialFood;
        _spaceTravel = spaceTravel;
        _currentPlanet = planet;
        _SolarSystem = solarSystem;
        _skills = skills;
        _neededResources = resources;
    }
    public string GetName(){
        return _name;
    }
    public string GetDescription(){
        return _description;
    }
    public List<bool> GetAttributes(){
        List<bool> attributes = new List<bool>{_advanced, _friendly, _potentialFood, _spaceTravel};
        return attributes;
    }
    public Planet GetPlanet(){
        return _currentPlanet;
    }
    public SolarSystem GetSolarSystem(){
        return _SolarSystem;
    }
    public List<Skill> GetSkills(){
        return _skills;
    }
    public List<Resource> GetResources(){
        return _neededResources;
    }
}