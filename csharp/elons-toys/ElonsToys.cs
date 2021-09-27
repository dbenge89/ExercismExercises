using System;

class RemoteControlCar
{
    public int Battery { get; set; } = 100;
    public int MetersDriven { get; set; } = 0;
    public static RemoteControlCar Buy()
    {
        RemoteControlCar car= new RemoteControlCar();
        return car;
    }

    public string DistanceDisplay()
    {
        return $"Driven {MetersDriven} meters";
    }

    public string BatteryDisplay()
    {
        if (Battery > 0) { return $"Battery at {Battery}%"; } return "Battery empty";
    }

    public void Drive()
    {
        if (Battery > 0)
        {
            MetersDriven += 20;
            Battery -= 1;
        }
        else BatteryDisplay();
    }
}
