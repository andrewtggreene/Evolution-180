class User{
    protected string _name;
    protected Planet _position;
    protected List<Skill> _abilities = new List<Skill>{};
    protected List<TechUpgrades> _techUpgrades = new List<TechUpgrades>{};
    protected int _money;
    protected List<SpaceCraft> _spaceShips = new List<SpaceCraft>{};
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
    public void SetName(string name){
        _name = name;
    }
    public string GetName(){
        return _name;
    }
    public void SetPosition(Planet planet){
        _position = planet;
    }
    public Planet GetPlanet(){
        return _position;
    }
    public void SetLocale(SolarSystem solarSystem){
        _currentSolarSystem = solarSystem;
    }
    public SolarSystem GetLocale(){
        return _currentSolarSystem;
    }
    public void BuySpaceship(int cost, SpaceCraft spaceCraft){
        _money -= cost;
        _spaceShips.Add(spaceCraft);
    }
    public List<SpaceCraft> GetListSpaceCraft(){
        return _spaceShips;
    }
    public void BuyTechUpgrade(int cost, TechUpgrades techUpgrades){
        _money -= cost;
        _techUpgrades.Add(techUpgrades);
    }
    public List<TechUpgrades> GetListTech(){
        return _techUpgrades;
    }
    public void BuySkill(int cost, Skill skill){
        _money -= cost;
        _abilities.Add(skill);
    }
    public List<Skill> GetListAbilities(){
        return _abilities;
    }
    public void LaunchSpaceStation(int cost, SpaceStation spaceStation){
        _money -= cost;
        _spaceStations.Add(spaceStation);
    }
    public List<SpaceStation> GetListSpaceStations(){
        return _spaceStations;
    }
    public void AddBase(int cost, Base based){
        _money -= cost;
        _bases.Add(based);
    }
    public List<Base> GetListBases(){
        return _bases;
    }
    public void AddOutpost(int cost, OutPost outPost){
        _money -= cost;
        _bases.Add(outPost);
    }
    public void UpgaradToBase(int cost, int index, Base newBase){
        _money -= cost;
        _bases.RemoveAt(index);
        _bases.Add(newBase);
    }
    public void FindLife(LifeForm lifeForm){
        _foundLifeForms.Add(lifeForm);
    }
    public List<LifeForm> GetListLifeForms(){
        return _foundLifeForms;
    }
    public void AddMoney(int money){
        _money += money;
    }
    public int GetMoney(){
        return _money;
    }
}