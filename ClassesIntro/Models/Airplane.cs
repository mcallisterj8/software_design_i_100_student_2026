public class Airplane {
    public string? Name { get; set; }
    public string? Airline { get; set; }
    public int NumEngines { get;set; }

    public Airplane() {}

    public Airplane(string givenName, int givenNumEngines) {
        this.Name = givenName;
        this.NumEngines = givenNumEngines;
    }

    public Airplane(string givenName, int givenNumEngines, string airline) {
        this.Name = givenName;
        this.NumEngines = givenNumEngines;
        this.Airline = airline;
    }

    public Airplane(int givenNumEngines, string givenName) {
        this.Name = givenName;
        this.NumEngines = givenNumEngines;
    }

    public Airplane(string givenName, string airline) {
        this.Name = givenName;
        this.Airline = airline;
    }

    // public Airplane(string airline, string givenName) {
    //     this.name = givenName;
    //     this.airline = airline;
    // }

}