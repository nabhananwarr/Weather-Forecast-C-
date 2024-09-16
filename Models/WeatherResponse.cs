using Microsoft.AspNetCore.Mvc;
public class WeatherResponse
{
    public Location Location { get; set; }
    public Current Current { get; set; }
}

public class Location
{
    public string Name { get; set; }
    public string Region { get; set; }
    public string Country { get; set; }
    public double Lat { get; set; }
    public double Lon { get; set; }
    public string Tz_Id { get; set; }
    public long Localtime_Epoch { get; set; }
    public string Localtime { get; set; }
}

public class Current
{
    public long Last_Updated_Epoch { get; set; }
    public string Last_Updated { get; set; }
    public double Temp_C { get; set; }
    
    public double Humidity{ get; set; }

    public Condition Condition { get; set; }
    // Add other properties as needed...
}


public class Condition
{
    public string Text { get; set; }
    public string Icon { get; set; }
    public int Code { get; set; }
}
