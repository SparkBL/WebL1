namespace WebL_1.Models
{
    public interface ICalcUnit
    {
        int a { get; set; }
        int b { get; set; }

        int Div();
        int Min();
        int Mult();
        int Sum();
       
    }
}