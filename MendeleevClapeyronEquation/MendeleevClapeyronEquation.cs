namespace MendeleevClapeyronEquation;
public class MendeleevClapeyronEquation : MCE
{
    protected decimal _p;
    protected decimal _v;
    protected decimal _m;
    protected decimal _M;
    protected decimal _t;
    protected decimal _R = 8.31m;

    public MendeleevClapeyronEquation(decimal mass, decimal molarMass)
    {
        _m = mass;
        _M = molarMass;
    }
    
    public override decimal CalculateTemperature(decimal pressure, decimal volume)
    {
        _p = pressure;
        _v = volume;

        decimal n = _m / _M;

        _t = (_p * _v) / (n * _R);
        
        return _t;
    }
}