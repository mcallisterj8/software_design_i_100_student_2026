public class Airplane {
    public string? name;
    public string? airline;
    public int numEngines;

    public Airplane() {}

    public Airplane(string givenName, int givenNumEngines) {
        this.name = givenName;
        this.numEngines = givenNumEngines;
    }

    public Airplane(string givenName, string airline) {

    }

}