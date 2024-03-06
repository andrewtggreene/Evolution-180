class User{
    protected string _name;
    protected Planet _position;
    protected List<Skill> _abilities = new List<Skill>{};
    protected List<TechUpgrades> _techUpgrades = new List<TechUpgrades>{};
    protected int _money;
    protected List<SpaceCraft> _spaceShips = new List<SpaceCraft>{};
    protected List<OutPost> _outPosts = new List<OutPost>{};
    protected List<SpaceStation> _spaceStations = new List<SpaceStation>{};
    protected SolarSystem _currentSolarSystem;
    protected List<LifeForm> _foundLifeForms = new List<LifeForm>{};
    protected List<Base> _bases = new List<Base>{};
    protected List<Resource> _resources = new List<Resource>{}; 
    public User(string name, int money, Planet position, SolarSystem solarSystem){
        _name = name;
        _money = money;
        _position = position;
        _currentSolarSystem = solarSystem;
    }

}