namespace MendeleevClapeyronEquation;

public class MendeleevClapeyronEquationUsing : MendeleevClapeyronEquation
{
    private decimal _NA = 6.02m;
    public decimal N
    {
        get
        {
            return (_m * _NA) / _M;
        }
    }
    public MendeleevClapeyronEquationUsing(decimal mass, decimal molarMass) : base(mass, molarMass){}
    
}